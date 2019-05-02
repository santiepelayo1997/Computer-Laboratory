using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using DealerImporterTool.Class;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace DealerImporterTool
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        private SqlConnection mvSqlCon;
        private SqlCommand mvSqlCom;
        private SqlTransaction mvSqlTrans;
        private string mvStrConString = "";
        private string cmd;
        private bool isSuccess;
        private DataTable dtImported;
        private DataTable dtError;
        private DialogResult dgResult;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Main()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            this.txtServer.Text = Properties.Settings.Default.server;
            this.txtDatabase.Text = Properties.Settings.Default.databaseName;
            this.txtPassword.Text = Properties.Settings.Default.passWord;
            this.txtUsername.Text = Properties.Settings.Default.userName;

            mvSqlCon = new SqlConnection();
            mvSqlCom = new SqlCommand();
            mvSqlTrans = null;

            mvStrConString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", txtServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text == "")
            {
                openFileDialog1.Title = "Browse Files";
                openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
                openFileDialog1.FileName = "";
                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string fileName = openFileDialog1.FileName;
                    txtFileName.Text = fileName;
                }
                else if (result == DialogResult.Cancel)
                {
                    txtFileName.Text = "";
                }
            }

            if (txtFileName.Text != "")
            {
                this.btnUpload.Text = "  UPLOAD";
                if (btnUpload.Text == "  UPLOAD")
                {
                    btnUpload.Enabled = false;
                    lblClear.Enabled = false;

                    UploadFile();
                    //enable browse and clear
                }
            }
        }

        private void UploadFile()
        {
            if (mvSqlCon == null)
            {
                if (!ConnectToDatabase())
                    return;
            }

            if (mvSqlCon.State != ConnectionState.Open)
            {
                if (!ConnectToDatabase())
                    return;
            }

            bgwUpload.RunWorkerAsync();
        }


        private void lblClear_Click_1(object sender, EventArgs e)
        {
            txtFileName.Text = "";
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            if (txtFileName.Text == "")
            {
                lblClear.Visible = false;
                this.btnUpload.Text = "  BROWSE";
            }
            else
            {
                lblClear.Visible = true;
            }
        }

        private void txtFileName_MouseHover(object sender, EventArgs e)
        {
            string ss = openFileDialog1.FileName;
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(txtFileName, ss);
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            mvStrConString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};Application Name={4}", txtServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text, Application.ProductName);
            if (ConnectToDatabase())
                MessageBox.Show("Database test successfully connected.");
            else
                MessageBox.Show("Database test connection failed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ConnectToDatabase()
        {
            try
            {
                if (String.IsNullOrEmpty(txtServer.Text) || String.IsNullOrEmpty(txtDatabase.Text) || String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("ERROR: Connection is not yet configured.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Global.WriteLog("ERROR: Connection is not yet configured.");
                    txtServer.Focus();
                    materialTabControl1.SelectedTab = tabPage2;
                    return false;
                }

                if (mvSqlCon != null)
                { 
                    if (mvSqlCon.State == ConnectionState.Open)
                    {
                        Global.CloseDBConnection(ref mvSqlCon);
                    }
                }

                if (!Global.CreateDBConnection(mvStrConString, ref mvSqlCon, ref mvSqlCom))
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Global.WriteLog("ERROR: " + ex.Message);
                return false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
       
            Properties.Settings.Default.server         =  this.txtServer.Text;
            Properties.Settings.Default.databaseName   =  this.txtDatabase.Text;
            Properties.Settings.Default.passWord       =  this.txtPassword.Text;
            Properties.Settings.Default.userName       =  this.txtUsername.Text;
            Properties.Settings.Default.Save();

            MessageBox.Show("Configuration settings has been saved!");

            materialTabControl1.SelectedTab = tabPage1;
        }

        private DataTable dtSelect(string strQuery, SqlCommand cmd)
        {
            string strMsg = "";
            DataTable dt = null;
            
            try
            {
                strMsg = "Select query: " + strQuery;
                Global.WriteLog(strMsg);

                cmd.CommandTimeout = 0;
                cmd.CommandText = strQuery;
                dt = new DataTable();
                using (SqlDataReader _dr = cmd.ExecuteReader())
                {
                    dt.Load(_dr);
                }
            }
            catch (Exception ex)
            {
                Global.WriteLog("ERROR: " + ex.Message);
            }
            
            return dt;
        }

        private void bgwUpload_DoWork(object sender, DoWorkEventArgs e)
        {
            isSuccess = false;
            string hostNames="";
            try
            {
                cmd = String.Format("SELECT hostname FROM master.dbo.sysprocesses WHERE program_name=\'{0}\' AND hostname<>\'{1}\'", Application.ProductName, System.Net.Dns.GetHostName());
                dtError = dtSelect(cmd, mvSqlCom);

                if (dtError.Rows.Count > 0)
                {
                    for (int i=0; i < dtError.Rows.Count; i++)
                        hostNames += dtError.Rows[i][0] + "";

                    MessageBox.Show("ERROR: Another instance of importing dealers to database is currently running in the following computer(s):\n" + hostNames + "\n Please close or wait for it to complete to avoid problems in importing.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                Global.SetLabelMethod(lblProgressMsg, "Initializing");
                Global.SetProgressMethod(pbProgress, 1);
                cmd = "IF OBJECT_ID('dbo.customerImportTemp', 'U') IS NOT NULL \n" +
                       "DROP TABLE dbo.customerImportTemp \n" +
                       "IF OBJECT_ID(\'dbo.customerImportTempError\', \'U\') IS NOT NULL DROP TABLE dbo.customerImportTempError \n" +
                       "IF OBJECT_ID(\'dbo.customerImportTemp\') IS NOT NULL DROP TABLE customerImportTemp \n" +
                       "SELECT TOP 0 temporaryCode as DealerCode,FirstName,LastName,cellphone as MobileNumber,CONVERT(VARCHAR(50),Birthday) as Birthday,CONVERT(VARCHAR(MAX),\'\') as BranchCode,cardTypeId as [Rank],CONVERT(VARCHAR(50),\'\') as Sponsor \n" +
                       "INTO  dbo.customerImportTemp \n" +
                       "FROM customer WITH (NOLOCK) \n" +
                       "SELECT TOP 0 temporaryCode as DealerCode,FirstName,LastName,cellphone as MobileNumber,CONVERT(VARCHAR(50),birthday) as Birthday,CONVERT(VARCHAR(MAX),\'\') as BranchCode,cardTypeId as [Rank],CONVERT(VARCHAR(50),\'\') as Sponsor, CONVERT(VARCHAR(100),\'\') as reason \n" +
                       "INTO  dbo.customerImportTempError \n" +
                       "FROM customer WITH (NOLOCK) ";

                Global.DBExecute(mvSqlCon, mvSqlCom, mvSqlTrans, cmd);

                Global.SetLabelMethod(lblProgressMsg, "Reading file");
                Global.SetProgressMethod(pbProgress, 5);
                cmd = "BULK INSERT customerImportTemp \n" +
                       "FROM \'" + txtFileName.Text.Trim() + "\' \n" +
                       "WITH ( \n" +
                       "	FIRSTROW = 2, \n" +
                       "    FIELDTERMINATOR = \',\', \n" +
                       "    ROWTERMINATOR = \'\\n\' \n" +
                       "); ";

                Global.DBExecute(mvSqlCon, mvSqlCom, mvSqlTrans, cmd);


                Global.SetLabelMethod(lblProgressMsg, "Checking blank dealer codes");
                Global.SetProgressMethod(pbProgress, 10);
                cmd = "INSERT INTO customerImportTempError \n" +
                      "SELECT t.*, \'No dealer codes specified\' \n" +
                      "FROM customerImportTemp t \n" +
                      "WHERE ISNULL(t.DealerCode,\'\')=\'\' \n" +
                      "DELETE FROM customerImportTemp \n" +
                      "WHERE ISNULL(DealerCode,'')=\'\' ";
                Global.DBExecute(mvSqlCon, mvSqlCom, mvSqlTrans, cmd);

                Global.SetLabelMethod(lblProgressMsg, "Checking already existing dealer codes");
                Global.SetProgressMethod(pbProgress, 12);
                cmd = "INSERT INTO customerImportTempError \n" +
                      "SELECT t.*, \'Already Exist\' \n" +
                      "FROM customerImportTemp t \n" +
                      "LEFT JOIN Customer c WITH (NOLOCK) ON t.DealerCode=c.temporaryCode \n" +
                      "WHERE ISNULL(c.temporaryCode,\'\')<>\'\' \n" +
                      "UPDATE t \n" +
                      "SET DealerCode=\'\' \n" +
                      "FROM customerImportTemp t \n" +
                      "LEFT JOIN Customer c WITH (NOLOCK) ON t.DealerCode=c.temporaryCode \n" +
                      "WHERE ISNULL(c.temporaryCode,\'\')<>\'\' \n" +
                      "DELETE FROM customerImportTemp \n" +
                      "WHERE DealerCode=\'\' ";

                Global.DBExecute(mvSqlCon, mvSqlCom, mvSqlTrans, cmd);

                Global.SetLabelMethod(lblProgressMsg, "Checking invalid or blank names");
                Global.SetProgressMethod(pbProgress, 14);
                cmd = "INSERT INTO customerImportTempError \n" +
                      "SELECT *, \'Blank Name\' \n" +
                      "FROM customerImportTemp \n" +
                      "WHERE LEN(ISNULL(firstName,\'\')+ISNULL(lastName,\'\')) < 2 \n" +
                      "DELETE customerImportTemp " +
                      "WHERE LEN(ISNULL(firstName,\'\')+ISNULL(lastName,\'\')) < 2 ";

                Global.DBExecute(mvSqlCon, mvSqlCom, mvSqlTrans, cmd);

                Global.SetLabelMethod(lblProgressMsg, "Checking invalid branch");
                Global.SetProgressMethod(pbProgress, 18);
                cmd = "INSERT INTO customerImportTempError \n" +
                      "SELECT t.*, \'Site RefCode not found\' \n" +
                      "FROM customerImportTemp t \n" +
                      "LEFT JOIN Site s WITH (NOLOCK) ON t.BranchCode=s.refCode \n" +
                      "WHERE ISNULL(s.refCode,\'\')=\'\' \n" +
                      "UPDATE t \n" +
                      "SET BranchCode=\'\' \n" +
                      "FROM customerImportTemp t \n" +
                      "LEFT JOIN Site s WITH (NOLOCK) ON t.BranchCode=s.refCode \n" +
                      "WHERE ISNULL(s.refCode,\'\')=\'\'  \n" +
                      "DELETE FROM customerImportTemp \n" +
                      "WHERE BranchCode=\'\' ";

                Global.DBExecute(mvSqlCon, mvSqlCom, mvSqlTrans, cmd);


                Global.SetLabelMethod(lblProgressMsg, "Checking invalid rank");
                Global.SetProgressMethod(pbProgress, 21);
                cmd = "INSERT INTO customerImportTempError \n" +
                      "SELECT t.*, 'Invalid rank' \n" +
                      "FROM customerImportTemp t \n" +
                      "WHERE [rank] NOT IN (SELECT cardTypeId FROM cardType WHERE isDirectSelling=1) \n" +
                      "DELETE customerImportTemp " +
                      "WHERE [rank] NOT IN (SELECT cardTypeId FROM cardType WHERE isDirectSelling=1) ";

                Global.DBExecute(mvSqlCon, mvSqlCom, mvSqlTrans, cmd);

                Global.SetLabelMethod(lblProgressMsg, "Preparing data");
                Global.SetProgressMethod(pbProgress, 25);
                cmd = "ALTER TABLE customerImportTemp \n" +
                      "ADD \n" +
                      " [name] [varchar](MAX) NULL, \n" +
                      " [name2] [varchar](MAX) NULL, \n" +
                      " [membershipsiteCode] [varchar](50) NULL, \n" +
                      " [customerId] [INT] NULL; \n";

                Global.DBExecute(mvSqlCon, mvSqlCom, mvSqlTrans, cmd);

                cmd = "UPDATE customerImportTemp \n" +
                      "SET name = ISNULL(lastName,\'\') + \', \' + ISNULL(firstName,\'\') \n" +
                      "UPDATE customerImportTemp \n" +
                      "SET name2 = name ";

                Global.DBExecute(mvSqlCon, mvSqlCom, mvSqlTrans, cmd);

                cmd = "UPDATE customerImportTemp \n" +
                      "SET membershipSiteCode = s.siteId \n" +
                      "FROM customerImportTemp t \n" +
                      "LEFT JOIN Site s ON s.RefCode = t.BranchCode ";

                Global.DBExecute(mvSqlCon, mvSqlCom, mvSqlTrans, cmd);

                Global.SetLabelMethod(lblProgressMsg, "Removing duplicates");
                Global.SetProgressMethod(pbProgress, 35);
                cmd = "WITH CTE AS( \n" +
                      " SELECT DealerCode,firstName,lastName,MobileNumber,birthday,BranchCode,[rank],sponsor, \n" +
                      "    DupCount = ROW_NUMBER()OVER(PARTITION BY DealerCode ORDER BY DealerCode) \n" +
                      " FROM dbo.customerImportTemp \n" +
                      ") \n" +
                      "INSERT INTO customerImportTempError \n" +
                      "SELECT DealerCode,firstName,lastName,MobileNumber,birthday,BranchCode,[rank],sponsor, \'DUPLICATE\' FROM CTE WHERE DupCount > 1; \n" +
                      "WITH CTE AS( \n" +
                      " SELECT DealerCode,firstName,lastName,MobileNumber,birthday,BranchCode,[rank],sponsor, \n" +
                      "    DupCount = ROW_NUMBER()OVER(PARTITION BY DealerCode ORDER BY DealerCode) \n" +
                      " FROM dbo.customerImportTemp \n" +
                      ") \n" +
                      "DELETE CTE WHERE DupCount > 1;";

                Global.DBExecute(mvSqlCon, mvSqlCom, mvSqlTrans, cmd);

                cmd = "DECLARE @customerId INT \n" +
                      "SET @customerId = (SELECT MAX(CustomerId) FROM Customer WITH (NOLOCK)) \n" +
                      "UPDATE customerImportTemp \n" +
                      "SET  @customerId = customerId = @customerId + 1 ";

                Global.DBExecute(mvSqlCon, mvSqlCom, mvSqlTrans, cmd);

                Global.SetLabelMethod(lblProgressMsg, "Transferring dealers to database");
                Global.SetProgressMethod(pbProgress, 40);
                cmd = "INSERT INTO customer(customerId,customerCode,temporaryCode,cardTypeId,firstName,lastName,birthday,cellphone,membershipSiteCode,name,name2,updateDate,expiryDate,createDate,membershipDate,datePromoted,status) \n" +
                      "SELECT t.customerId,REPLACE(STR(t.customerId,7),\' \',\'0\'),t.DealerCode,[rank],t.firstName,t.lastName,CONVERT(DATETIME,ISNULL(t.birthday,\'1/1/1900\'),105),t.MobileNumber,t.membershipSiteCode,t.name,t.name2,GETDATE(),\'12/31/3000\',GETDATE(),GETDATE(),GETDATE(),\'A\' \n" +
                      "FROM customerImportTemp t \n" +
                      "LEFT JOIN Customer c ON t.DealerCode=c.temporaryCode \n" +
                      "WHERE ISNULL(c.temporaryCode,\'\')=\'\' ";

                Global.DBExecute(mvSqlCon, mvSqlCom, mvSqlTrans, cmd);

                Global.SetLabelMethod(lblProgressMsg, "Transferring dealers to database");
                Global.SetProgressMethod(pbProgress, 90);
                cmd = "IF (SELECT COUNT(customerId) FROM customerImportTemp WITH (NOLOCK)) > 0 BEGIN \n" +
                      "   UPDATE counter SET value = (SELECT MAX(customerId) FROM customerImportTemp WITH (NOLOCK)) \n" +
                      "   WHERE name = \'customerId\' END";

                Global.DBExecute(mvSqlCon, mvSqlCom, mvSqlTrans, cmd);

                cmd = "SELECT dealerCode,name FROM customerImportTemp";
                dtImported = dtSelect(cmd, mvSqlCom);

                cmd = "SELECT dealerCode,ISNULL(lastName,\'\') + \', \' + ISNULL(firstName,\'\') as name,reason FROM customerImportTempError";
                dtError = dtSelect(cmd, mvSqlCom);

                Global.SetProgressMethod(pbProgress, 100);
                Global.SetLabelMethod(lblProgressMsg, "Done");
                

                isSuccess = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Global.WriteLog("ERROR: " + ex.Message);
                isSuccess = false;
            }
        }

        private void bgwUpload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnUpload.Enabled = true;
            lblClear.Enabled = true;
            dgResult = DialogResult.No;
            if (isSuccess)
            {
                if (dtImported.Rows.Count > 0)
                {
                    if (dtError.Rows.Count > 0)
                        dgResult = MessageBox.Show("Successfully imported file " + openFileDialog1.SafeFileName + " with " + dtImported.Rows.Count.ToString() + " dealers imported out of " + (dtImported.Rows.Count + dtError.Rows.Count).ToString() + ". Do you want to view the errors?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    else
                        MessageBox.Show("Successfully imported file " + openFileDialog1.SafeFileName + " with " + dtImported.Rows.Count.ToString() + " dealers.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (dtError.Rows.Count > 0)
                        dgResult = MessageBox.Show("No dealers imported out of " + (dtImported.Rows.Count + dtError.Rows.Count).ToString() + " dealers to import due to error/s. Do you want to view the errors?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    else
                        dgResult = MessageBox.Show("No dealers imported due to error/s. Do you want to view the errors?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                Global.WriteLog("Successfully imported file: " + txtFileName.Text + "\nTotal Dealers Imported:" + dtImported.Rows.Count.ToString() + "\nTotal Dealers With Errors:");

                if (dgResult == DialogResult.Yes)
                {
                    Global.dtErrorSummary = dtError;
                    ErrorSummary f = new ErrorSummary();
                    f.ShowDialog(this);
                }
            }

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
