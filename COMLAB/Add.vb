Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation
Imports System.Net
Imports MetroFramework
Imports System.Runtime.InteropServices
Imports System.Reflection
Imports Microsoft.Win32

Public Class Add

    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

    Dim usertype As String = "STUDENT"
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
    Sub RefreshDatabase()
        Connection()
        Dim Query As String = "select * from tbl_register"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "id")
        Form1.bunifuCustomDataGrid1.DataSource = ds.Tables(0)
        MysqlConn.Close()
    End Sub
    Sub Cleartextbox()
        txtStudentID.Text = String.Empty
        txtCourse.Text = String.Empty
        txtFirstName.Text = String.Empty
        txtLastName.Text = String.Empty
        txtPassword.Text = String.Empty
        txtYear.Text = String.Empty
        txtMiddleInitial.Text = String.Empty
        txtContactNo.Text = String.Empty
        txtAddress.Text = String.Empty
    End Sub
    Private Sub Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
    Private Sub Add_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleCreated
        KeyboardJammer.Jam()
    End Sub
    Private Sub Add_HandleDestroyed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleDestroyed
        KeyboardJammer.UnJam()
    End Sub
    Public Function GetComputerName() As String
        Dim ComputerName As String
        ComputerName = System.Net.Dns.GetHostName
        Return ComputerName
    End Function

    Dim result As String
    Dim strHostName As String = System.Net.Dns.GetHostName()
    Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

    Function getMacAddress()
        Dim pcadd() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        Return pcadd(1).GetPhysicalAddress.ToString
    End Function

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

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtStudentID.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please input Student ID!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtCourse.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please input First Name!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtFirstName.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please input Last Name!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtLastName.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please input Middle Initial!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtMiddleInitial.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please input Course!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtYear.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please input Year!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtAddress.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please input Address!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtContactNo.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please input Contact No!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtPassword.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please input Password!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Dim computername As String
            computername = GetComputerName()
            For Each ipheal As System.Net.IPAddress In iphe.AddressList
                If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                    result = ipheal.ToString()
                End If
            Next
            Connection()
            Dim READER As MySqlDataReader
            Try
                MysqlConn.Open()
                Dim Sql As String
                Sql = "Insert into tbl_register (studentid,password,firstname,lastname,middleinitial,course,year,address,contactno,ipaddress,pcname,usertype) values (@studentid,@password,@firstname,@lastname,@middleinitial,@course,@year,@address,@contactno,@ipaddress,@pcname,@usertype)"
                Command = New MySqlCommand(Sql, MysqlConn)
                Command.Parameters.AddWithValue("@studentid", txtStudentID.Text)
                Command.Parameters.AddWithValue("@password", txtPassword.Text)
                Command.Parameters.AddWithValue("@firstname", txtFirstName.Text)
                Command.Parameters.AddWithValue("@lastname", txtLastName.Text)
                Command.Parameters.AddWithValue("@middleinitial", txtMiddleInitial.Text)
                Command.Parameters.AddWithValue("@course", txtCourse.Text)
                Command.Parameters.AddWithValue("@year", txtYear.Text)
                Command.Parameters.AddWithValue("@address", txtAddress.Text)
                Command.Parameters.AddWithValue("@contactno", txtContactNo.Text)
                Command.Parameters.AddWithValue("@ipaddress", result)
                Command.Parameters.AddWithValue("@pcname", computername)
                Command.Parameters.AddWithValue("@usertype", usertype)
                READER = Command.ExecuteReader
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Me.Hide()
            RefreshDatabase()
            Cleartextbox()
            Form1.RefreshDatabase()

            MysqlConn.Close()
            MetroFramework.MetroMessageBox.Show(Me, "Successfully Register.", "Success.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Login.Show()
        End If
    End Sub

    Private Sub txtMiddleInitial_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtMiddleInitial.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
        If txtMiddleInitial.Text.Length >= 2 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MetroFramework.MetroMessageBox.Show(Me, "2 Characters Only!", "Invalid Middle Initial", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub txtLastName_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtFirstName_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtContactNo_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtContactNo.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
        Dim allowedChars As String = "0123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
        If txtContactNo.Text.Length >= 12 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MetroFramework.MetroMessageBox.Show(Me, "11 Digits Only!", "Invalid Temperature", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
End Class