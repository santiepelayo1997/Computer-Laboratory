Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation
Imports System.Net
Imports MetroFramework
Imports System.Runtime.InteropServices
Imports System.Reflection
Imports Microsoft.Win32

Public Class UpdateForm

    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
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
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If studentno.Text = "admin" Then
            MetroFramework.MetroMessageBox.Show(Me, "This is admin account cannot be update call your admin", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Connection()
            Dim Reader As MySqlDataReader
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "Update tbl_register set studentid=@studentid,password=@password,firstname=@firstname,lastname=@lastname,middleinitial=@middleinitial,course=@course,year=@year,address=@address,contactno=@contactno,usertype=@usertype where studentid = '" & studentno.Text & "'"
                Command = New MySqlCommand(Query, MysqlConn)
                Command.Parameters.AddWithValue("@studentid", txtStudentID.Text)
                Command.Parameters.AddWithValue("@password", txtPassword.Text)
                Command.Parameters.AddWithValue("@firstname", txtFirstName.Text)
                Command.Parameters.AddWithValue("@lastname", txtLastName.Text)
                Command.Parameters.AddWithValue("@middleinitial", txtMiddleInitial.Text)
                Command.Parameters.AddWithValue("@course", txtCourse.Text)
                Command.Parameters.AddWithValue("@year", txtYear.Text)
                Command.Parameters.AddWithValue("@address", txtAddress.Text)
                Command.Parameters.AddWithValue("@contactno", txtContactNo.Text)
                Command.Parameters.AddWithValue("@usertype", cmbUsertype.Text)
                Reader = Command.ExecuteReader
                MysqlConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MysqlConn.Dispose()
                Me.Hide()
                MysqlConn.Close()
                Form1.RefreshDatabase()
                MetroFramework.MetroMessageBox.Show(Me, "Successfully Updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtMiddleInitial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMiddleInitial.KeyPress
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

    Private Sub txtContactNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContactNo.KeyPress
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

    Private Sub txtCourse_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub UpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
    Private Sub UpdateForm_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleCreated
        KeyboardJammer.Jam()
    End Sub
    Private Sub UpdateForm_HandleDestroyed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleDestroyed
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