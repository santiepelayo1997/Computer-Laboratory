namespace DealerImporterTool
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pbProgress = new ns1.BunifuCircleProgressbar();
            this.lblClear = new System.Windows.Forms.Label();
            this.txtFileName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnUpload = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblProgressMsg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSubmit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnTestConnection = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtDatabase = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.bgwUpload = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.lblMinimize);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 20);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.White;
            this.lblMinimize.Location = new System.Drawing.Point(405, -3);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(19, 20);
            this.lblMinimize.TabIndex = 22;
            this.lblMinimize.Text = "_";
            this.lblMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(428, 1);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(19, 18);
            this.lblClose.TabIndex = 21;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 58);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(65, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barter - Dealer Importer Tool";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 98);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(446, 426);
            this.materialTabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(438, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Import Tool";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pbProgress);
            this.panel4.Controls.Add(this.lblClear);
            this.panel4.Controls.Add(this.txtFileName);
            this.panel4.Controls.Add(this.btnUpload);
            this.panel4.Controls.Add(this.lblProgressMsg);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 397);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(24, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Browse .csv file then click upload to bulk import dealers";
            // 
            // pbProgress
            // 
            this.pbProgress.animated = false;
            this.pbProgress.animationIterval = 5;
            this.pbProgress.animationSpeed = 300;
            this.pbProgress.BackColor = System.Drawing.Color.White;
            this.pbProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbProgress.BackgroundImage")));
            this.pbProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.pbProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.pbProgress.LabelVisible = true;
            this.pbProgress.LineProgressThickness = 8;
            this.pbProgress.LineThickness = 5;
            this.pbProgress.Location = new System.Drawing.Point(119, 133);
            this.pbProgress.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pbProgress.MaxValue = 100;
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.pbProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.pbProgress.Size = new System.Drawing.Size(201, 201);
            this.pbProgress.TabIndex = 18;
            this.pbProgress.Value = 0;
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblClear.Location = new System.Drawing.Point(388, 51);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(20, 20);
            this.lblClear.TabIndex = 6;
            this.lblClear.Text = "X";
            this.lblClear.Visible = false;
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click_1);
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.Color.White;
            this.txtFileName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFileName.Enabled = false;
            this.txtFileName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFileName.Location = new System.Drawing.Point(139, 49);
            this.txtFileName.Multiline = true;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(270, 25);
            this.txtFileName.TabIndex = 2;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            this.txtFileName.MouseHover += new System.EventHandler(this.txtFileName_MouseHover);
            // 
            // btnUpload
            // 
            this.btnUpload.Depth = 0;
            this.btnUpload.Location = new System.Drawing.Point(27, 49);
            this.btnUpload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Primary = true;
            this.btnUpload.Size = new System.Drawing.Size(114, 25);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = " BROWSE";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblProgressMsg
            // 
            this.lblProgressMsg.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressMsg.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProgressMsg.Location = new System.Drawing.Point(17, 340);
            this.lblProgressMsg.Name = "lblProgressMsg";
            this.lblProgressMsg.Size = new System.Drawing.Size(400, 41);
            this.lblProgressMsg.TabIndex = 11;
            this.lblProgressMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(22, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Progress in Percent";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(438, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(-4, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(442, 404);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnSubmit);
            this.panel5.Controls.Add(this.btnTestConnection);
            this.panel5.Controls.Add(this.lblPassword);
            this.panel5.Controls.Add(this.txtPassword);
            this.panel5.Controls.Add(this.lblUsername);
            this.panel5.Controls.Add(this.txtUsername);
            this.panel5.Controls.Add(this.lblDatabase);
            this.panel5.Controls.Add(this.txtDatabase);
            this.panel5.Controls.Add(this.lblServer);
            this.panel5.Controls.Add(this.txtServer);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(442, 404);
            this.panel5.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Depth = 0;
            this.btnSubmit.Location = new System.Drawing.Point(239, 345);
            this.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Primary = true;
            this.btnSubmit.Size = new System.Drawing.Size(110, 30);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "SAVE";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Depth = 0;
            this.btnTestConnection.Location = new System.Drawing.Point(101, 345);
            this.btnTestConnection.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Primary = true;
            this.btnTestConnection.Size = new System.Drawing.Size(132, 30);
            this.btnTestConnection.TabIndex = 20;
            this.btnTestConnection.Text = "TEST CONNECTION";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPassword.Location = new System.Drawing.Point(30, 260);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "";
            this.txtPassword.Location = new System.Drawing.Point(34, 286);
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(378, 23);
            this.txtPassword.TabIndex = 19;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUsername.Location = new System.Drawing.Point(30, 187);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 21;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Depth = 0;
            this.txtUsername.Hint = "";
            this.txtUsername.Location = new System.Drawing.Point(34, 210);
            this.txtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.Size = new System.Drawing.Size(378, 23);
            this.txtUsername.TabIndex = 18;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabase.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDatabase.Location = new System.Drawing.Point(30, 118);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(72, 20);
            this.lblDatabase.TabIndex = 19;
            this.lblDatabase.Text = "Database";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Depth = 0;
            this.txtDatabase.Hint = "";
            this.txtDatabase.Location = new System.Drawing.Point(34, 141);
            this.txtDatabase.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.PasswordChar = '\0';
            this.txtDatabase.SelectedText = "";
            this.txtDatabase.SelectionLength = 0;
            this.txtDatabase.SelectionStart = 0;
            this.txtDatabase.Size = new System.Drawing.Size(378, 23);
            this.txtDatabase.TabIndex = 17;
            this.txtDatabase.UseSystemPasswordChar = false;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblServer.Location = new System.Drawing.Point(30, 50);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(50, 20);
            this.lblServer.TabIndex = 17;
            this.lblServer.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Depth = 0;
            this.txtServer.Hint = "";
            this.txtServer.Location = new System.Drawing.Point(34, 74);
            this.txtServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtServer.Name = "txtServer";
            this.txtServer.PasswordChar = '\0';
            this.txtServer.SelectedText = "";
            this.txtServer.SelectionLength = 0;
            this.txtServer.SelectionStart = 0;
            this.txtServer.Size = new System.Drawing.Size(378, 23);
            this.txtServer.TabIndex = 16;
            this.txtServer.UseSystemPasswordChar = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 73);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(450, 38);
            this.materialTabSelector1.TabIndex = 9;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // bgwUpload
            // 
            this.bgwUpload.WorkerReportsProgress = true;
            this.bgwUpload.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwUpload_DoWork);
            this.bgwUpload.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwUpload_RunWorkerCompleted);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 524);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.Label lblProgressMsg;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpload;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsername;
        private System.Windows.Forms.Label lblDatabase;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDatabase;
        private System.Windows.Forms.Label lblServer;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtServer;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtFileName;
        private MaterialSkin.Controls.MaterialRaisedButton btnTestConnection;
        private MaterialSkin.Controls.MaterialRaisedButton btnSubmit;
        private ns1.BunifuCircleProgressbar pbProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker bgwUpload;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblMinimize;
    }
}

