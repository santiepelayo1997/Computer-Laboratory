<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminAccount
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminAccount))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.sidemenu = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton1 = New ns1.BunifuFlatButton()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuImageButton4 = New ns1.BunifuImageButton()
        Me.bunifuThinButton21 = New ns1.BunifuThinButton2()
        Me.bunifuImageButton3 = New ns1.BunifuImageButton()
        Me.bunifuFlatButton2 = New ns1.BunifuFlatButton()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.bunifuImageButton1 = New ns1.BunifuImageButton()
        Me.animator1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.panelanimator1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton9 = New ns1.BunifuFlatButton()
        Me.label3 = New System.Windows.Forms.Label()
        Me.bunifuMetroTextbox1 = New ns1.BunifuMetroTextbox()
        Me.bunifuCustomDataGrid1 = New ns1.BunifuCustomDataGrid()
        Me.bunifuThinButton24 = New ns1.BunifuThinButton2()
        Me.bunifuThinButton23 = New ns1.BunifuThinButton2()
        Me.btnAdd = New ns1.BunifuThinButton2()
        Me.BunifuFlatButton3 = New ns1.BunifuFlatButton()
        Me.ADMIN = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblAdminID = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblOffline = New System.Windows.Forms.Label()
        Me.sidemenu.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.bunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel3.SuspendLayout()
        CType(Me.bunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.sidemenu.Controls.Add(Me.BunifuFlatButton3)
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
        Me.BunifuFlatButton1.TabIndex = 13
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
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0.0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0.0!
        Animation1.RotateLimit = 0.0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0.0!
        Animation1.TransparencyCoeff = 0.0!
        Me.animator1.DefaultAnimation = Animation1
        '
        'panelanimator1
        '
        Me.panelanimator1.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic
        Me.panelanimator1.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0.0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0.0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 20
        Animation2.Padding = New System.Windows.Forms.Padding(30)
        Animation2.RotateCoeff = 0.0!
        Animation2.RotateLimit = 0.0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0.0!
        Animation2.TransparencyCoeff = 0.0!
        Me.panelanimator1.DefaultAnimation = Animation2
        Me.panelanimator1.TimeStep = 0.05!
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.White
        Me.panel3.Controls.Add(Me.BunifuFlatButton9)
        Me.panel3.Controls.Add(Me.label3)
        Me.panel3.Controls.Add(Me.bunifuMetroTextbox1)
        Me.panel3.Controls.Add(Me.bunifuCustomDataGrid1)
        Me.panel3.Controls.Add(Me.bunifuThinButton24)
        Me.panel3.Controls.Add(Me.bunifuThinButton23)
        Me.panel3.Controls.Add(Me.btnAdd)
        Me.panelanimator1.SetDecoration(Me.panel3, BunifuAnimatorNS.DecorationType.None)
        Me.animator1.SetDecoration(Me.panel3, BunifuAnimatorNS.DecorationType.None)
        Me.panel3.Location = New System.Drawing.Point(293, 99)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(1037, 578)
        Me.panel3.TabIndex = 8
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
        Me.BunifuFlatButton9.Location = New System.Drawing.Point(577, 28)
        Me.BunifuFlatButton9.Name = "BunifuFlatButton9"
        Me.BunifuFlatButton9.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.BunifuFlatButton9.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton9.selected = False
        Me.BunifuFlatButton9.Size = New System.Drawing.Size(169, 30)
        Me.BunifuFlatButton9.TabIndex = 76
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
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.bunifuCustomDataGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White
        Me.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(12)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.animator1.SetDecoration(Me.bunifuCustomDataGrid1, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator1.SetDecoration(Me.bunifuCustomDataGrid1, BunifuAnimatorNS.DecorationType.None)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bunifuCustomDataGrid1.DefaultCellStyle = DataGridViewCellStyle3
        Me.bunifuCustomDataGrid1.DoubleBuffered = True
        Me.bunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.White
        Me.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bunifuCustomDataGrid1.Location = New System.Drawing.Point(18, 72)
        Me.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1"
        Me.bunifuCustomDataGrid1.ReadOnly = True
        Me.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(16)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bunifuCustomDataGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.bunifuCustomDataGrid1.RowHeadersVisible = False
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(12)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bunifuCustomDataGrid1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.bunifuCustomDataGrid1.ShowCellToolTips = False
        Me.bunifuCustomDataGrid1.Size = New System.Drawing.Size(995, 477)
        Me.bunifuCustomDataGrid1.TabIndex = 1
        '
        'bunifuThinButton24
        '
        Me.bunifuThinButton24.ActiveBorderThickness = 1
        Me.bunifuThinButton24.ActiveCornerRadius = 25
        Me.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White
        Me.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.White
        Me.bunifuThinButton24.BackColor = System.Drawing.Color.White
        Me.bunifuThinButton24.BackgroundImage = CType(resources.GetObject("bunifuThinButton24.BackgroundImage"), System.Drawing.Image)
        Me.bunifuThinButton24.ButtonText = "Update"
        Me.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelanimator1.SetDecoration(Me.bunifuThinButton24, BunifuAnimatorNS.DecorationType.None)
        Me.animator1.SetDecoration(Me.bunifuThinButton24, BunifuAnimatorNS.DecorationType.None)
        Me.bunifuThinButton24.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuThinButton24.ForeColor = System.Drawing.Color.White
        Me.bunifuThinButton24.IdleBorderThickness = 1
        Me.bunifuThinButton24.IdleCornerRadius = 25
        Me.bunifuThinButton24.IdleFillColor = System.Drawing.Color.White
        Me.bunifuThinButton24.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.bunifuThinButton24.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.bunifuThinButton24.Location = New System.Drawing.Point(166, 22)
        Me.bunifuThinButton24.Margin = New System.Windows.Forms.Padding(5)
        Me.bunifuThinButton24.Name = "bunifuThinButton24"
        Me.bunifuThinButton24.Size = New System.Drawing.Size(138, 42)
        Me.bunifuThinButton24.TabIndex = 13
        Me.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bunifuThinButton23
        '
        Me.bunifuThinButton23.ActiveBorderThickness = 1
        Me.bunifuThinButton23.ActiveCornerRadius = 25
        Me.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White
        Me.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.White
        Me.bunifuThinButton23.BackColor = System.Drawing.Color.White
        Me.bunifuThinButton23.BackgroundImage = CType(resources.GetObject("bunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.bunifuThinButton23.ButtonText = "Delete"
        Me.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelanimator1.SetDecoration(Me.bunifuThinButton23, BunifuAnimatorNS.DecorationType.None)
        Me.animator1.SetDecoration(Me.bunifuThinButton23, BunifuAnimatorNS.DecorationType.None)
        Me.bunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuThinButton23.ForeColor = System.Drawing.Color.White
        Me.bunifuThinButton23.IdleBorderThickness = 1
        Me.bunifuThinButton23.IdleCornerRadius = 25
        Me.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White
        Me.bunifuThinButton23.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.bunifuThinButton23.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.bunifuThinButton23.Location = New System.Drawing.Point(18, 22)
        Me.bunifuThinButton23.Margin = New System.Windows.Forms.Padding(5)
        Me.bunifuThinButton23.Name = "bunifuThinButton23"
        Me.bunifuThinButton23.Size = New System.Drawing.Size(138, 42)
        Me.bunifuThinButton23.TabIndex = 12
        Me.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdd
        '
        Me.btnAdd.ActiveBorderThickness = 1
        Me.btnAdd.ActiveCornerRadius = 25
        Me.btnAdd.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnAdd.ActiveForecolor = System.Drawing.Color.White
        Me.btnAdd.ActiveLineColor = System.Drawing.Color.White
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.ButtonText = "Add "
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelanimator1.SetDecoration(Me.btnAdd, BunifuAnimatorNS.DecorationType.None)
        Me.animator1.SetDecoration(Me.btnAdd, BunifuAnimatorNS.DecorationType.None)
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.IdleBorderThickness = 1
        Me.btnAdd.IdleCornerRadius = 25
        Me.btnAdd.IdleFillColor = System.Drawing.Color.White
        Me.btnAdd.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnAdd.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(314, 22)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(138, 42)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "          Admin Accounts"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelanimator1.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.animator1.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = CType(resources.GetObject("BunifuFlatButton3.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0.0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 50.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(-1, 334)
        Me.BunifuFlatButton3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(278, 51)
        Me.BunifuFlatButton3.TabIndex = 14
        Me.BunifuFlatButton3.Text = "          Admin Accounts"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ADMIN
        '
        Me.ADMIN.AutoSize = True
        Me.animator1.SetDecoration(Me.ADMIN, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator1.SetDecoration(Me.ADMIN, BunifuAnimatorNS.DecorationType.None)
        Me.ADMIN.Location = New System.Drawing.Point(690, 712)
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
        Me.DataGridView1.Location = New System.Drawing.Point(331, 712)
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
        Me.lblAdminID.Location = New System.Drawing.Point(590, 727)
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
        Me.Label30.Location = New System.Drawing.Point(498, 705)
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
        Me.lblOffline.Location = New System.Drawing.Point(437, 704)
        Me.lblOffline.Name = "lblOffline"
        Me.lblOffline.Size = New System.Drawing.Size(51, 13)
        Me.lblOffline.TabIndex = 15
        Me.lblOffline.Text = "OFFLINE"
        Me.lblOffline.Visible = False
        '
        'AdminAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1342, 768)
        Me.Controls.Add(Me.ADMIN)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblAdminID)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.lblOffline)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.sidemenu)
        Me.animator1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminAccount"
        Me.sidemenu.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        CType(Me.bunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        CType(Me.bunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Private WithEvents sidemenu As System.Windows.Forms.Panel
    Private WithEvents BunifuFlatButton1 As ns1.BunifuFlatButton
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents BunifuImageButton4 As ns1.BunifuImageButton
    Private WithEvents bunifuThinButton21 As ns1.BunifuThinButton2
    Private WithEvents bunifuImageButton3 As ns1.BunifuImageButton
    Private WithEvents bunifuFlatButton2 As ns1.BunifuFlatButton
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents bunifuImageButton1 As ns1.BunifuImageButton
    Friend WithEvents panelanimator1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents animator1 As BunifuAnimatorNS.BunifuTransition
    Private WithEvents panel3 As System.Windows.Forms.Panel
    Friend WithEvents BunifuFlatButton9 As ns1.BunifuFlatButton
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents bunifuMetroTextbox1 As ns1.BunifuMetroTextbox
    Public WithEvents bunifuCustomDataGrid1 As ns1.BunifuCustomDataGrid
    Private WithEvents bunifuThinButton24 As ns1.BunifuThinButton2
    Private WithEvents bunifuThinButton23 As ns1.BunifuThinButton2
    Private WithEvents btnAdd As ns1.BunifuThinButton2
    Private WithEvents BunifuFlatButton3 As ns1.BunifuFlatButton
    Friend WithEvents ADMIN As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblAdminID As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lblOffline As System.Windows.Forms.Label
End Class
