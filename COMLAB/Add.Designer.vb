<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtYear = New MetroFramework.Controls.MetroComboBox()
        Me.txtCourse = New MetroFramework.Controls.MetroComboBox()
        Me.btnBack = New ns1.BunifuThinButton2()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtContactNo = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAddress = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPassword = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMiddleInitial = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLastName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFirstName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnAdd = New ns1.BunifuThinButton2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStudentID = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1382, 900)
        Me.Panel1.TabIndex = 85
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(255, 104)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(114, 513)
        Me.Panel3.TabIndex = 106
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtYear)
        Me.Panel2.Controls.Add(Me.txtCourse)
        Me.Panel2.Controls.Add(Me.btnBack)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtContactNo)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txtAddress)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtPassword)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtMiddleInitial)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtLastName)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtFirstName)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtStudentID)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(255, 104)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(862, 511)
        Me.Panel2.TabIndex = 0
        '
        'txtYear
        '
        Me.txtYear.FormattingEnabled = True
        Me.txtYear.ItemHeight = 23
        Me.txtYear.Items.AddRange(New Object() {"", "1st", "2nd", "3rd", "4th"})
        Me.txtYear.Location = New System.Drawing.Point(520, 112)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(286, 29)
        Me.txtYear.TabIndex = 105
        Me.txtYear.UseSelectable = True
        '
        'txtCourse
        '
        Me.txtCourse.FormattingEnabled = True
        Me.txtCourse.ItemHeight = 23
        Me.txtCourse.Items.AddRange(New Object() {"", "BSIT", "BSCS", "BSEE", "BSCE", "BSME", "BSBA", "BSOA", "BSHRM", "BSA"})
        Me.txtCourse.Location = New System.Drawing.Point(198, 406)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(286, 29)
        Me.txtCourse.TabIndex = 104
        Me.txtCourse.UseSelectable = True
        '
        'btnBack
        '
        Me.btnBack.ActiveBorderThickness = 2
        Me.btnBack.ActiveCornerRadius = 25
        Me.btnBack.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnBack.ActiveForecolor = System.Drawing.Color.White
        Me.btnBack.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.ButtonText = "Back"
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.IdleBorderThickness = 1
        Me.btnBack.IdleCornerRadius = 25
        Me.btnBack.IdleFillColor = System.Drawing.Color.White
        Me.btnBack.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnBack.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(520, 393)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(138, 42)
        Me.btnBack.TabIndex = 103
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gray
        Me.Label13.Location = New System.Drawing.Point(517, 231)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 21)
        Me.Label13.TabIndex = 102
        Me.Label13.Text = "Contact No"
        '
        'txtContactNo
        '
        Me.txtContactNo.Depth = 0
        Me.txtContactNo.Hint = ""
        Me.txtContactNo.Location = New System.Drawing.Point(521, 255)
        Me.txtContactNo.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContactNo.SelectedText = ""
        Me.txtContactNo.SelectionLength = 0
        Me.txtContactNo.SelectionStart = 0
        Me.txtContactNo.Size = New System.Drawing.Size(285, 23)
        Me.txtContactNo.TabIndex = 101
        Me.txtContactNo.UseSystemPasswordChar = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Gray
        Me.Label14.Location = New System.Drawing.Point(517, 161)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 21)
        Me.Label14.TabIndex = 100
        Me.Label14.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Depth = 0
        Me.txtAddress.Hint = ""
        Me.txtAddress.Location = New System.Drawing.Point(521, 185)
        Me.txtAddress.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.SelectionLength = 0
        Me.txtAddress.SelectionStart = 0
        Me.txtAddress.Size = New System.Drawing.Size(285, 23)
        Me.txtAddress.TabIndex = 99
        Me.txtAddress.UseSystemPasswordChar = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(517, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 21)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Year"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(517, 303)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 21)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Depth = 0
        Me.txtPassword.Hint = ""
        Me.txtPassword.Location = New System.Drawing.Point(521, 327)
        Me.txtPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.Size = New System.Drawing.Size(285, 23)
        Me.txtPassword.TabIndex = 96
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(196, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 21)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "First Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(196, 373)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 21)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Course"
        '
        'txtMiddleInitial
        '
        Me.txtMiddleInitial.Depth = 0
        Me.txtMiddleInitial.Hint = ""
        Me.txtMiddleInitial.Location = New System.Drawing.Point(200, 327)
        Me.txtMiddleInitial.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtMiddleInitial.Name = "txtMiddleInitial"
        Me.txtMiddleInitial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMiddleInitial.SelectedText = ""
        Me.txtMiddleInitial.SelectionLength = 0
        Me.txtMiddleInitial.SelectionStart = 0
        Me.txtMiddleInitial.Size = New System.Drawing.Size(285, 23)
        Me.txtMiddleInitial.TabIndex = 93
        Me.txtMiddleInitial.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(196, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 21)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Middle Initial"
        '
        'txtLastName
        '
        Me.txtLastName.Depth = 0
        Me.txtLastName.Hint = ""
        Me.txtLastName.Location = New System.Drawing.Point(200, 255)
        Me.txtLastName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.SelectionLength = 0
        Me.txtLastName.SelectionStart = 0
        Me.txtLastName.Size = New System.Drawing.Size(285, 23)
        Me.txtLastName.TabIndex = 91
        Me.txtLastName.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(196, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Last Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Depth = 0
        Me.txtFirstName.Hint = ""
        Me.txtFirstName.Location = New System.Drawing.Point(199, 185)
        Me.txtFirstName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.SelectionLength = 0
        Me.txtFirstName.SelectionStart = 0
        Me.txtFirstName.Size = New System.Drawing.Size(285, 23)
        Me.txtFirstName.TabIndex = 89
        Me.txtFirstName.UseSystemPasswordChar = False
        '
        'btnAdd
        '
        Me.btnAdd.ActiveBorderThickness = 2
        Me.btnAdd.ActiveCornerRadius = 25
        Me.btnAdd.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnAdd.ActiveForecolor = System.Drawing.Color.White
        Me.btnAdd.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.ButtonText = "Register"
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.IdleBorderThickness = 1
        Me.btnAdd.IdleCornerRadius = 25
        Me.btnAdd.IdleFillColor = System.Drawing.Color.White
        Me.btnAdd.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnAdd.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(668, 393)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(138, 42)
        Me.btnAdd.TabIndex = 88
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(195, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 21)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "StudentID"
        '
        'txtStudentID
        '
        Me.txtStudentID.Depth = 0
        Me.txtStudentID.Hint = ""
        Me.txtStudentID.Location = New System.Drawing.Point(199, 112)
        Me.txtStudentID.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentID.SelectedText = ""
        Me.txtStudentID.SelectionLength = 0
        Me.txtStudentID.SelectionStart = 0
        Me.txtStudentID.Size = New System.Drawing.Size(285, 23)
        Me.txtStudentID.TabIndex = 86
        Me.txtStudentID.UseSystemPasswordChar = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(145, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 19)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Registration Form"
        '
        'Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1378, 762)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Add"
        Me.Resizable = False
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtYear As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtCourse As MetroFramework.Controls.MetroComboBox
    Private WithEvents btnBack As ns1.BunifuThinButton2
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtContactNo As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMiddleInitial As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As MaterialSkin.Controls.MaterialSingleLineTextField
    Private WithEvents btnAdd As ns1.BunifuThinButton2
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStudentID As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
