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

namespace ImporterTool
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
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
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text == "")
            {
                openFileDialog1.Title = "Browse Files";
                openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
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
                    //disable browse and clear
                    //new function call - UploadFile
                    //enable browse and clear
                }
            }
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
            SqlConnection DBConn = new SqlConnection();
            string sConnString = "Data Source={0};Initial Catalog={1};User ID={2};Password={3}";
            DBConn.ConnectionString = string.Format(sConnString, txtServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
            try
            {
                DBConn.Open();
                MessageBox.Show("Connection is Active!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
       
            Properties.Settings.Default.server         =  this.txtServer.Text;
            Properties.Settings.Default.databaseName   =  this.txtDatabase.Text;
            Properties.Settings.Default.passWord       =  this.txtPassword.Text;
            Properties.Settings.Default.userName       =  this.txtUsername.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("OK");
        }
    }
}
