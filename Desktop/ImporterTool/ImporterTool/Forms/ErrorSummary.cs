using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealerImporterTool.Class;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace DealerImporterTool
{

    public partial class ErrorSummary : MetroFramework.Forms.MetroForm
    {
        public ErrorSummary()
        {
            InitializeComponent();

            this.dgvError.DataSource = Global.dtErrorSummary;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            this.Hide();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
