using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Reflection;
using System.Data.SqlClient;

namespace DealerImporterTool.Class
{
    class Global
    {
        public delegate void delegateSetLabel(Label lbl, string msg);
        public delegate void delegateSetProgress(ns1.BunifuCircleProgressbar pb, int value);
        public static string gvLogPath = new System.IO.FileInfo(AppDomain.CurrentDomain.BaseDirectory).DirectoryName + "\\Logs\\";
        public static string gvLogFile = DateTime.Now.ToString("yyyyMMdd") + ".txt";
        public static DataTable dtErrorSummary;

        public static void SetLabelMethod(Label lbl, string msg)
        {
            if (lbl == null)
                return;

            if (lbl.InvokeRequired)
            {
                lbl.Invoke(new delegateSetLabel(SetLabelMethod), new object[] { lbl, msg });
            }
            else
            {
                lbl.Text = msg;
            }
        }

        public static void SetProgressMethod(ns1.BunifuCircleProgressbar pb, int value)
        {
            if (pb == null)
                return;

            if (pb.InvokeRequired)
            {
                pb.Invoke(new delegateSetProgress(SetProgressMethod), new object[] { pb, value });
            }
            else
            {
                pb.Value = value;
            }
        }

        public static void CloseDBConnection(ref SqlConnection sqlCon)
        {
            string strMsg = "";

            if (sqlCon.State == ConnectionState.Open)
            {
                strMsg = "Attempt to close the current database connection...";
                Global.WriteLog(strMsg);

                sqlCon.Close();

                strMsg = "Successfully disconnected...";
                Global.WriteLog(strMsg);
            }
        }

        public static void DBExecute(SqlConnection sqlCon, SqlCommand sqlCom, SqlTransaction sqlTrans, string cmdText)
        {
            string strMsg = "";

            try
            {
                strMsg = "Execute query...";
                Global.WriteLog(strMsg);
                sqlCom.CommandText = cmdText;
                strMsg = "Query: " + sqlCom.CommandText;
                Global.WriteLog(strMsg);

                sqlCom.ExecuteNonQuery();
                //sqlTrans.Commit();

                strMsg = "Successfully executed...";
                Global.WriteLog(strMsg);
            }
            catch (Exception ex)
            {
                try
                {
                    if (sqlTrans != null)
                    {
                        strMsg = "ERROR: Failed to commit rollback transaction...";
                        Global.WriteLog(strMsg);

                        sqlTrans.Rollback();

                        strMsg = "Successfully rollback the transaction...";
                        Global.WriteLog(strMsg);
                    }
                }
                catch (Exception ex2)
                {
                    Global.WriteLog(ex2.Message);
                }
            }
        }

        public static bool CreateDBConnection(string strConnectionString, ref SqlConnection sqlCon, ref SqlCommand sqlCom)
        {
            string strMsg = "";
            try
            {
                strMsg = "Create database connection...";
                Global.WriteLog(strMsg);

                sqlCon.ConnectionString = strConnectionString;
                sqlCon.Open();
                sqlCom = sqlCon.CreateCommand();
                sqlCom.Connection = sqlCon;

                strMsg = "Successfully conected in the database...";
                Global.WriteLog(strMsg);
                return true;
            }
            catch (Exception ex)
            {
                Global.WriteLog("ERROR: " + ex.Message);
                MessageBox.Show("An error was encountered while creating database connection..." +
                    Environment.NewLine +
                    "Kindly check log file: " + gvLogFile + " in: " + Environment.NewLine + gvLogPath,
                        Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void WriteLog(string strMsg)
        {
            int cnt = 0;
            FileStream fs;
            StreamWriter sw;
            fs = null;
            sw = null;

waiting:
            try
            {
                if (cnt == 3)
                    return;
                else
                {
                    if (!Directory.Exists(gvLogPath))
                        Directory.CreateDirectory(gvLogPath);

                    if (File.Exists(gvLogPath + gvLogFile))
                        fs = new FileStream(gvLogPath + gvLogFile, FileMode.Append, FileAccess.Write, FileShare.None);
                    else
                        fs = new FileStream(gvLogPath + gvLogFile, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);

                    if (fs != null)
                    {
                        sw = new StreamWriter(fs);
                        sw.WriteLine(DateTime.Now.ToString() + " - " + strMsg);
                        sw.Close();
                        fs.Close();
                    }
                }
            }
            catch
            {
                cnt += 1;
                if (fs != null)
                {
                    fs.Close();
                }
                if (sw != null)
                {
                    sw.Close();
                }

                goto waiting;
            }
        }
    }
}
