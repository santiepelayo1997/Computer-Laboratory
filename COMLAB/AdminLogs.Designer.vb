<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Animation6 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation5 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminLogs))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.sidemenu = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton1 = New ns1.BunifuFlatButton()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuImageButton4 = New ns1.BunifuImageButton()
        Me.bunifuThinButton21 = New ns1.BunifuThinButton2()
        Me.bunifuImageButton3 = New ns1.BunifuImageButton()
        Me.bunifuFlatButton2 = New ns1.BunifuFlatButton()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton9 = New ns1.BunifuFlatButton()
        Me.label3 = New System.Windows.Forms.Label()
        Me.bunifuMetroTextbox1 = New ns1.BunifuMetroTextbox()
        Me.bunifuCustomDataGrid1 = New ns1.BunifuCustomDataGrid()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.bunifuImageButton1 = New ns1.BunifuImageButton()
        Me.animator1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.ADMIN = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblAdminID = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblOffline = New System.Windows.Forms.Label()
        Me.panelanimator1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.sidemenu.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel3.SuspendLayout()
        CType(Me.bunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.bunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'sidemenu
        '
        Me.sidemenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.sidemenu.Controls.Add(Me.BunifuFlatButton1)
        Me.sidemenu.Controls.Add(Me.pictureBox1)
        Me.sidemenu.Controls.Add(Me.BunifuImageButton4)
        Me.sidemenu.Controls.Add(Me.bunifuThinButton21)
        Me.sidemenu.Controls.Add(Me.bunifuImageButton3)
        Me.sidemenu.Controls.Add(Me.bunifuFlatButton2)
        Me.panelanimator1.SetDecoration(Me.sidemenu, BunifuAnimatorNS.DecorationType.None)
        Me.animator1.SetDecoration(Me.sidemenu, BunifuAnimatorNS.DecorationType.None)
        Me.sidemenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidemenu.Location = New System.Drawing.Point(0, 0)
        Me.sidemenu.Name = "sidemenu"
        Me.sidemenu.Size = New System.Drawing.Size(256, 768)
        Me.sidemenu.TabIndex = 4
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "          User Logs"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelanimator1.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.animator1.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0.0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 50.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 286)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(278, 51)
        Me.BunifuFlatButton1.TabIndex = 12
        Me.BunifuFlatButton1.Text = "          User Logs"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'pictureBox1
        '
        Me.animator1.SetDecoration(Me.pictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator1.SetDecoration(Me.pictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(61, 47)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(144, 83)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 11
        Me.pictureBox1.TabStop = False
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.panelanimator1.SetDecoration(Me.BunifuImageButton4, BunifuAnimatorNS.DecorationType.None)
        Me.animator1.SetDecoration(Me.BunifuImageButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton4.Image = CType(resources.GetObject("BunifuImageButton4.Image"), System.Drawing.Image)
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(9, 11)
        Me.BunifuImageButton4.Name = "BunifuImageButton4"
        Me.BunifuImageButton4.Size = New System.Drawing.Size(27, 29)
        Me.BunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton4.TabIndex = 3
        Me.BunifuImageButton4.TabStop = False
        Me.BunifuImageButton4.Zoom = 10
        '
        'bunifuThinButton21
        '
        Me.bunifuThinButton21.ActiveBorderThickness = 1
        Me.bunifuThinButton21.ActiveCornerRadius = 25
        Me.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.White
        Me.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.bunifuThinButton21.BackgroundImage = CType(resources.GetObject("bunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.bunifuThinButton21.ButtonText = "Administrator"
        Me.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelanimator1.SetDecoration(Me.bunifuThinButton21, BunifuAnimatorNS.DecorationType.None)
        Me.animator1.SetDecoration(Me.bunifuThinButton21, BunifuAnimatorNS.DecorationType.None)
        Me.bunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuThinButton21.ForeColor = System.Drawing.Color.White
        Me.bunifuThinButton21.IdleBorderThickness = 1
        Me.bunifuThinButton21.IdleCornerRadius = 25
        Me.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.bunifuThinButton21.IdleLineColor = System.Drawing.Color.White
        Me.bunifuThinButton21.Location = New System.Drawing.Point(70, 138)
        Me.bunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.bunifuThinButton21.Name = "bunifuThinButton21"
        Me.bunifuThinButton21.Size = New System.Drawing.Size(128, 37)
        Me.bunifuThinButton21.TabIndex = 10
        Me.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bunifuImageButton3
        '
        Me.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.panelanimator1.SetDecoration(Me.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None)
        Me.animator1.SetDecoration(Me.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None)
        Me.bunifuImageButton3.Image = CType(resources.GetObject("bunifuImageButton3.Image"), System.Drawing.Image)
        Me.bunifuImageButton3.ImageActive = Nothing
        Me.bunifuImageButton3.Location = New System.Drawing.Point(219, 726)
        Me.bunifuImageButton3.Name = "bunifuImageButton3"
        Me.bunifuImageButton3.Size = New System.Drawing.Size(27, 35)
        Me.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bunifuImageButton3.TabIndex = 5
        Me.bunifuImageButton3.TabStop = False
        Me.bunifuImageButton3.Zoom = 10
        '
        'bunifuFlatButton2
        '
        Me.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuFlatButton2.BorderRadius = 0
        Me.bunifuFlatButton2.ButtonText = "          Records"
        Me.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelanimator1.SetDecoration(Me.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.animator1.SetDecoration(Me.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.bunifuFlatButton2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifuFlatButton2.Iconimage = CType(resources.GetObject("bunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.bunifuFlatButton2.Iconimage_right = Nothing
        Me.bunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.bunifuFlatButton2.Iconimage_Selected = Nothing
        Me.bunifuFlatButton2.IconMarginLeft = 0
        Me.bunifuFlatButton2.IconMarginRight = 0
        Me.bunifuFlatButton2.IconRightVisible = True
        Me.bunifuFlatButton2.IconRightZoom = 0.0R
        Me.bunifuFlatButton2.IconVisible = True
        Me.bunifuFlatButton2.IconZoom = 50.0R
        Me.bunifuFlatButton2.IsTab = False
        Me.bunifuFlatButton2.Location = New System.Drawing.Point(0, 236)
        Me.bunifuFlatButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bunifuFlatButton2.Name = "bunifuFlatButton2"
        Me.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.bunifuFlatButton2.selected = False
        Me.bunifuFlatButton2.Size = New System.Drawing.Size(278, 51)
        Me.bunifuFlatButton2.TabIndex = 4
        Me.bunifuFlatButton2.Text = "          Records"
        Me.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.bunifuFlatButton2.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.White
        Me.panel3.Controls.Add(Me.BunifuFlatButton9)
        Me.panel3.Controls.Add(Me.label3)
        Me.panel3.Controls.Add(Me.bunifuMetroTextbox1)
        Me.panel3.Controls.Add(Me.bunifuCustomDataGrid1)
        Me.panelanimator1.SetDecoration(Me.panel3, BunifuAnimatorNS.DecorationType.None)
        Me.animator1.SetDecoration(Me.panel3, BunifuAnimatorNS.DecorationType.None)
        Me.panel3.Location = New System.Drawing.Point(293, 99)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(1037, 578)
        Me.panel3.TabIndex = 6
        '
        'BunifuFlatButton9
        '
        Me.BunifuFlatButton9.Activecolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.BunifuFlatButton9.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.BunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton9.BorderRadius = 7
        Me.BunifuFlatButton9.ButtonText = "Export to Excel"
        Me.BunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelanimator1.SetDecoration(Me.BunifuFlatButton9, BunifuAnimatorNS.DecorationType.None)
        Me.animator1.SetDecoration(Me.BunifuFlatButton9, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton9.Iconimage = CType(resources.GetObject("BunifuFlatButton9.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton9.Iconimage_right = Nothing
        Me.BunifuFlatButton9.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton9.Iconimage_Selected = Nothing
        Me.BunifuFlatButton9.IconMarginLeft = 10
        Me.BunifuFlatButton9.IconMarginRight = 0
        Me.BunifuFlatButton9.IconRightVisible = True
        Me.BunifuFlatButton9.IconRightZoom = 0.0R
        Me.BunifuFlatButton9.IconVisible = True
        Me.BunifuFlatButton9.IconZoom = 50.0R
        Me.BunifuFlatButton9.IsTab = False
        Me.BunifuFlatButton9.Location = New System.Drawing.Point(18, 27)
        Me.BunifuFlatButton9.Name = "BunifuFlatButton9"
        Me.BunifuFlatButton9.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.BunifuFlatButton9.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton9.selected = False
        Me.BunifuFlatButton9.Size = New System.Drawing.Size(169, 30)
        Me.BunifuFlatButton9.TabIndex = 77
        Me.BunifuFlatButton9.Text = "Export to Excel"
        Me.BunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton9.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton9.TextFont = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.animator1.SetDecoration(Me.label3, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator1.SetDecoration(Me.label3, BunifuAnimatorNS.DecorationType.None)
        Me.label3.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.label3.Location = New System.Drawing.Point(761, 32)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(67, 21)
        Me.label3.TabIndex = 15
        Me.label3.Text = "Search"
        '
        'bunifuMetroTextbox1
        '
        Me.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Gray
        Me.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.Silver
        Me.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.bunifuMetroTextbox1.BorderThickness = 1
        Me.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.animator1.SetDecoration(Me.bunifuMetroTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator1.SetDecoration(Me.bunifuMetroTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.bunifuMetroTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bunifuMetroTextbox1.isPassword = False
        Me.bunifuMetroTextbox1.Location = New System.Drawing.Point(829, 28)
        Me.bunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1"
        Me.bunifuMetroTextbox1.Size = New System.Drawing.Size(189, 29)
        Me.bunifuMetroTextbox1.TabIndex = 14
        Me.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bunifuCustomDataGrid1
        '
        Me.bunifuCustomDataGrid1.AllowUserToAddRows = False
        Me.bunifuCustomDataGrid1.AllowUserToDeleteRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        Me.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.bunifuCustomDataGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White
        Me.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(12)
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.animator1.SetDecoration(Me.bunifuCustomDataGrid1, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator1.SetDecoration(Me.bunifuCustomDataGrid1, BunifuAnimatorNS.DecorationType.None)
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bunifuCustomDataGrid1.DefaultCellStyle = DataGridViewCellStyle13
        Me.bunifuCustomDataGrid1.DoubleBuffered = True
        Me.bunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.White
        Me.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bunifuCustomDataGrid1.Location = New System.Drawing.Point(18, 72)
        Me.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1"
        Me.bunifuCustomDataGrid1.ReadOnly = True
        Me.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.Padding = New System.Windows.Forms.Padding(16)
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bunifuCustomDataGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.bunifuCustomDataGrid1.RowHeadersVisible = False
        DataGridViewCellStyle15.Padding = New System.Windows.Forms.Padding(12)
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bunifuCustomDataGrid1.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.bunifuCustomDataGrid1.ShowCellToolTips = False
        Me.bunifuCustomDataGrid1.Size = New System.Drawing.Size(995, 477)
        Me.bunifuCustomDataGrid1.TabIndex = 1
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.panel2.Controls.Add(Me.bunifuImageButton1)
        Me.panelanimator1.SetDecoration(Me.panel2, BunifuAnimatorNS.DecorationType.None)
        Me.animator1.SetDecoration(Me.panel2, BunifuAnimatorNS.DecorationType.None)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(256, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1086, 40)
        Me.panel2.TabIndex = 7
        '
        'bunifuImageButton1
        '
        Me.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.panelanimator1.SetDecoration(Me.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.animator1.SetDecoration(Me.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.bunifuImageButton1.Image = CType(resources.GetObject("bunifuImageButton1.Image"), System.Drawing.Image)
        Me.bunifuImageButton1.ImageActive = Nothing
        Me.bunifuImageButton1.Location = New System.Drawing.Point(7, 5)
        Me.bunifuImageButton1.Name = "bunifuImageButton1"
        Me.bunifuImageButton1.Size = New System.Drawing.Size(27, 29)
        Me.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bunifuImageButton1.TabIndex = 2
        Me.bunifuImageButton1.TabStop = False
        Me.bunifuImageButton1.Zoom = 10
        '
        'animator1
        '
        Me.animator1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.animator1.Cursor = Nothing
        Animation6.AnimateOnlyDifferences = True
        Animation6.BlindCoeff = CType(resources.GetObject("Animation6.BlindCoeff"), System.Drawing.PointF)
        Animation6.LeafCoeff = 0.0!
        Animation6.MaxTime = 1.0!
        Animation6.MinTime = 0.0!
        Animation6.MosaicCoeff = CType(resources.GetObject("Animation6.MosaicCoeff"), System.Drawing.PointF)
        Animation6.MosaicShift = CType(resources.GetObject("Animation6.MosaicShift"), System.Drawing.PointF)
        Animation6.MosaicSize = 0
        Animation6.Padding = New System.Windows.Forms.Padding(0)
        Animation6.RotateCoeff = 0.0!
        Animation6.RotateLimit = 0.0!
        Animation6.ScaleCoeff = CType(resources.GetObject("Animation6.ScaleCoeff"), System.Drawing.PointF)
        Animation6.SlideCoeff = CType(resources.GetObject("Animation6.SlideCoeff"), System.Drawing.PointF)
        Animation6.TimeCoeff = 0.0!
        Animation6.TransparencyCoeff = 0.0!
        Me.animator1.DefaultAnimation = Animation6
        '
        'ADMIN
        '
        Me.ADMIN.AutoSize = True
        Me.animator1.SetDecoration(Me.ADMIN, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator1.SetDecoration(Me.ADMIN, BunifuAnimatorNS.DecorationType.None)
        Me.ADMIN.Location = New System.Drawing.Point(670, 704)
        Me.ADMIN.Name = "ADMIN"
        Me.ADMIN.Size = New System.Drawing.Size(42, 13)
        Me.ADMIN.TabIndex = 19
        Me.ADMIN.Text = "ADMIN"
        Me.ADMIN.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.panelanimator1.SetDecoration(Me.DataGridView1, BunifuAnimatorNS.DecorationType.None)
        Me.animator1.SetDecoration(Me.DataGridView1, BunifuAnimatorNS.DecorationType.None)
        Me.DataGridView1.Location = New System.Drawing.Point(311, 704)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(53, 28)
        Me.DataGridView1.TabIndex = 18
        Me.DataGridView1.Visible = False
        '
        'lblAdminID
        '
        Me.lblAdminID.AutoSize = True
        Me.animator1.SetDecoration(Me.lblAdminID, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator1.SetDecoration(Me.lblAdminID, BunifuAnimatorNS.DecorationType.None)
        Me.lblAdminID.Location = New System.Drawing.Point(570, 719)
        Me.lblAdminID.Name = "lblAdminID"
        Me.lblAdminID.Size = New System.Drawing.Size(57, 13)
        Me.lblAdminID.TabIndex = 17
        Me.lblAdminID.Text = "lblAdminID"
        Me.lblAdminID.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.animator1.SetDecoration(Me.Label30, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator1.SetDecoration(Me.Label30, BunifuAnimatorNS.DecorationType.None)
        Me.Label30.Location = New System.Drawing.Point(478, 697)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(19, 13)
        Me.Label30.TabIndex = 16
        Me.Label30.Text = "17"
        Me.Label30.Visible = False
        '
        'lblOffline
        '
        Me.lblOffline.AutoSize = True
        Me.animator1.SetDecoration(Me.lblOffline, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator1.SetDecoration(Me.lblOffline, BunifuAnimatorNS.DecorationType.None)
        Me.lblOffline.Location = New System.Drawing.Point(417, 696)
        Me.lblOffline.Name = "lblOffline"
        Me.lblOffline.Size = New System.Drawing.Size(51, 13)
        Me.lblOffline.TabIndex = 15
        Me.lblOffline.Text = "OFFLINE"
        Me.lblOffline.Visible = False
        '
        'panelanimator1
        '
        Me.panelanimator1.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic
        Me.panelanimator1.Cursor = Nothing
        Animation5.AnimateOnlyDifferences = True
        Animation5.BlindCoeff = CType(resources.GetObject("Animation5.BlindCoeff"), System.Drawing.PointF)
        Animation5.LeafCoeff = 0.0!
        Animation5.MaxTime = 1.0!
        Animation5.MinTime = 0.0!
        Animation5.MosaicCoeff = CType(resources.GetObject("Animation5.MosaicCoeff"), System.Drawing.PointF)
        Animation5.MosaicShift = CType(resources.GetObject("Animation5.MosaicShift"), System.Drawing.PointF)
        Animation5.MosaicSize = 20
        Animation5.Padding = New System.Windows.Forms.Padding(30)
        Animation5.RotateCoeff = 0.0!
        Animation5.RotateLimit = 0.0!
        Animation5.ScaleCoeff = CType(resources.GetObject("Animation5.ScaleCoeff"), System.Drawing.PointF)
        Animation5.SlideCoeff = CType(resources.GetObject("Animation5.SlideCoeff"), System.Drawing.PointF)
        Animation5.TimeCoeff = 0.0!
        Animation5.TransparencyCoeff = 0.0!
        Me.panelanimator1.DefaultAnimation = Animation5
        Me.panelanimator1.TimeStep = 0.05!
        '
        'AdminLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1342, 768)
        Me.Controls.Add(Me.ADMIN)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblAdminID)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.lblOffline)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.sidemenu)
        Me.animator1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminLogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminLogs"
        Me.sidemenu.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        CType(Me.bunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        CType(Me.bunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Private WithEvents sidemenu As System.Windows.Forms.Panel
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents BunifuImageButton4 As ns1.BunifuImageButton
    Private WithEvents bunifuThinButton21 As ns1.BunifuThinButton2
    Private WithEvents bunifuImageButton3 As ns1.BunifuImageButton
    Private WithEvents bunifuFlatButton2 As ns1.BunifuFlatButton
    Private WithEvents BunifuFlatButton1 As ns1.BunifuFlatButton
    Private WithEvents panel3 As System.Windows.Forms.Panel
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents bunifuMetroTextbox1 As ns1.BunifuMetroTextbox
    Public WithEvents bunifuCustomDataGrid1 As ns1.BunifuCustomDataGrid
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents bunifuImageButton1 As ns1.BunifuImageButton
    Friend WithEvents panelanimator1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents animator1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents ADMIN As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblAdminID As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lblOffline As System.Windows.Forms.Label
    Friend WithEvents BunifuFlatButton9 As ns1.BunifuFlatButton
End Class
