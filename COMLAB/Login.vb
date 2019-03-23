Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation
Imports System.Net
Imports MetroFramework
Imports System.Runtime.InteropServices
Imports System.Reflection
Imports Microsoft.Win32


Public Class Login
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim cn As New MySqlConnection("Server=localhost; User ID=root;Password=; Database=comlab")
    Public Property stringpass As String
    Public Function GetComputerName() As String
        Dim ComputerName As String
        ComputerName = System.Net.Dns.GetHostName
        Return ComputerName
    End Function

    Sub Connection()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=comlab"
        Try
            MysqlConn.Open()
        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        If MaterialSingleLineTextField2.UseSystemPasswordChar = False Then

            MaterialSingleLineTextField2.UseSystemPasswordChar = True
            BunifuImageButton1.Text = "Hide"
        Else
            MaterialSingleLineTextField2.UseSystemPasswordChar = False
            BunifuImageButton1.Text = "Show"
        End If
    End Sub

    Public cntAttempts = 0
    Private Async Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If MaterialSingleLineTextField1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write your Username!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField2.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write your Password!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim cmd As New MySqlCommand
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            Dim sql As String

            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=comlab"
            Dim result As String
            Dim strHostName As String = System.Net.Dns.GetHostName()
            Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

            Dim computername As String
            computername = GetComputerName()
            For Each ipheal As System.Net.IPAddress In iphe.AddressList
                If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                    result = ipheal.ToString()
                End If
            Next

            Dim regDate As DateTime = DateTime.Now
            Dim strDate As String = regDate.ToString("hh:mm tt")
            Dim now As DateTime = DateTime.Now

            sql = "select * from tbl_register where studentid ='" & MaterialSingleLineTextField1.Text & "' and password = '" & MaterialSingleLineTextField2.Text & "'"
            With cmd
                .Connection = cn
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim username, password, usertype, status, firstname, lastname, course, year As String
                username = dt.Rows(0).Item(1)
                firstname = dt.Rows(0).Item(3)
                lastname = dt.Rows(0).Item(4)
                password = dt.Rows(0).Item(2)
                course = dt.Rows(0).Item(6)
                year = dt.Rows(0).Item(7)
                usertype = dt.Rows(0).Item(12)
                status = dt.Rows(0).Item(13)
                If usertype = "ADMIN" Then
                    If status = "ONLINE" Then
                        MetroFramework.MetroMessageBox.Show(Me, "Cannot be Access!", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, "Successfully Login! as " & usertype, "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        updatestatus()
                        userlogs()

                        Dim READER As MySqlDataReader

                        Try
                            MysqlConn.Open()
                            Dim Sql2 As String
                            Sql2 = "Insert into tbl_userlogs (studentid,timein,name,lastname,Course,Year,pcname,datetime_login) values ('" & MaterialSingleLineTextField1.Text & "','" & strDate & "','" & firstname & "','" & lastname & "','" & course & "','" & year & "','" & computername & "','" & now.ToShortDateString() & "')"
                            Command = New MySqlCommand(Sql2, MysqlConn)
                            READER = Command.ExecuteReader
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                        Form1.Show()
                        Me.Hide()
                    End If
                ElseIf usertype = "STUDENT" Then

                    MetroFramework.MetroMessageBox.Show(Me, "Successfully Login! as " & usertype, "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    userlogs()
                    Dim READER As MySqlDataReader

                    Try
                        MysqlConn.Open()
                        Dim Sql1 As String
                        Sql1 = "Insert into tbl_userlogs (studentid,timein,name,lastname,Course,Year,pcname,datetime_login) values ('" & MaterialSingleLineTextField1.Text & "','" & strDate & "','" & firstname & "','" & lastname & "','" & course & "','" & year & "','" & computername & "','" & now.ToShortDateString() & "')"
                        Command = New MySqlCommand(Sql1, MysqlConn)
                        READER = Command.ExecuteReader
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try

                    StudentForm.Show()
                    Me.Hide()
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Password or Username are Incorrect!", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cntAttempts += 1
                    If cntAttempts = 3 Then
                        MetroFramework.MetroMessageBox.Show(Me, "Please check your account!", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        BunifuThinButton21.Enabled = False
                        Await Task.Delay(5000)
                        BunifuThinButton21.Enabled = True
                        cntAttempts = 0
                    End If
                End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Password or Username are Incorrect!", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cntAttempts += 1
                If cntAttempts = 3 Then
                    MetroFramework.MetroMessageBox.Show(Me, "Please check your account!", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    BunifuThinButton21.Enabled = False
                    Await Task.Delay(5000)
                    BunifuThinButton21.Enabled = True
                    cntAttempts = 0
                End If
            End If
            da.Dispose()
        End If
    End Sub
    Sub userlogs()
        Dim Query As String = "select * from tbl_userlogs"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "app_id")
        AdminLogs.bunifuCustomDataGrid1.DataSource = ds.Tables(0)
        MysqlConn.Close()
    End Sub
    Sub updatestatus()
        Dim Reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update tbl_register set status='" & lblStatus.Text & "'  where usertype = '" & MaterialSingleLineTextField1.Text & "'"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
            Me.Hide()
            MysqlConn.Close()
        End Try
    End Sub
    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs)
        Select Case MetroMessageBox.Show(Me, "Are you sure to exit the application?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Case MsgBoxResult.Ok
                Application.Exit()
            Case MsgBoxResult.Cancel
        End Select
    End Sub

    Private Sub MaterialSingleLineTextField1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField1.KeyPress
        If e.KeyChar = Chr(13) Then
            BunifuThinButton21_Click(Me, EventArgs.Empty)
        End If
    End Sub


    Private Sub MaterialSingleLineTextField2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField2.KeyPress
        If e.KeyChar = Chr(13) Then
            BunifuThinButton21_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Add.Show()
        Me.Hide()
    End Sub

    Private Sub Login_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Alt = True And e.KeyCode = Keys.F4 Or e.Alt = True And e.KeyCode = Keys.Escape Then
            e.Handled = True
        End If
    End Sub
  
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Private Sub Login_FormClosing_1(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub Login_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleCreated
        KeyboardJammer.Jam()
    End Sub
    Private Sub Login_HandleDestroyed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleDestroyed
        KeyboardJammer.UnJam()
    End Sub
    Public Class KeyboardJammer
        Private Delegate Function HookCallback(ByVal nCode As Integer, ByVal wParam As Integer, ByVal lParam As IntPtr) As Integer
        Private Shared HookDelegate As HookCallback
        Private Shared HookId As Integer
        Private Const Wh_Keyboard_LL As Integer = 13
        Private Const Vk_Tab As Integer = 9
        Private Const Vk_Escape As Integer = 27
        Private Const vk_Del As Integer = 46
        Private Const Vk_F4 As Integer = 115
        Private Const VK_LWinKey As Integer = 91
        Private Const VK_RWinKey As Integer = 92
        Private Shared Function KeyBoardHookProc(ByVal nCode As Integer, ByVal wParam As Integer, ByVal lParam As IntPtr) As Integer
            'All keyboard events will be sent here.
            'Don't process just pass along.
            If nCode < 0 Then
                Return CallNextHookEx(HookId, nCode, wParam, lParam)
            End If
            'Extract the keyboard structure from the lparam
            'This will contain the virtual key and any flags.
            'This is using the my.computer.keyboard to get the
            'flags instead
            Dim KeyboardSruct As KBDLLHOOKSTRUCT = Marshal.PtrToStructure(lParam, GetType(KBDLLHOOKSTRUCT))

            If KeyboardSruct.vkCode = Vk_Tab And My.Computer.Keyboard.AltKeyDown Then
                'Alt Tab
                Return 1
            ElseIf KeyboardSruct.vkCode = Vk_Escape And My.Computer.Keyboard.CtrlKeyDown Then
                'Control Escape
                Return 1
            ElseIf KeyboardSruct.vkCode = VK_LWinKey Or KeyboardSruct.vkCode = VK_RWinKey Then
                'Left Windows Key or Rigth Windows Key
                Return 1
            ElseIf KeyboardSruct.vkCode = vk_Del And My.Computer.Keyboard.CtrlKeyDown And My.Computer.Keyboard.AltKeyDown Then
                'Ctrl Alt Del
                Return 1
            ElseIf KeyboardSruct.vkCode = Vk_F4 And My.Computer.Keyboard.AltKeyDown Then
                'Alt F4
                Return 1
            End If
            'Send the message along 
            Return CallNextHookEx(HookId, nCode, wParam, lParam)
        End Function
        Public Shared Sub Jam()
            'Add the low level keyboard hook
            If HookId = 0 Then
                HookDelegate = AddressOf KeyBoardHookProc
                HookId = SetWindowsHookEx(Wh_Keyboard_LL, HookDelegate, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly.GetModules()(0)), 0)
                If HookId = 0 Then
                    'error
                End If
            End If
        End Sub
        Public Shared Sub UnJam()
            'Remove the hook
            UnhookWindowsHookEx(HookId)
        End Sub
        <DllImport("user32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)> _
        Private Shared Function CallNextHookEx( _
       ByVal idHook As Integer, _
       ByVal nCode As Integer, _
       ByVal wParam As IntPtr, _
       ByVal lParam As IntPtr) As Integer
        End Function
        <DllImport("user32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall, SetLastError:=True)> _
        Private Shared Function SetWindowsHookEx( _
           ByVal idHook As Integer, _
           ByVal HookProc As HookCallback, _
           ByVal hInstance As IntPtr, _
           ByVal wParam As Integer) As Integer
        End Function
        <DllImport("user32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall, SetLastError:=True)> _
        Private Shared Function UnhookWindowsHookEx(ByVal idHook As Integer) As Integer
        End Function
        Private Structure KBDLLHOOKSTRUCT
            Public vkCode As Integer
            Public scanCode As Integer
            Public flags As Integer
            Public time As Integer
            Public dwExtraInfo As IntPtr
        End Structure
    End Class
End Class