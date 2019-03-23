Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation
Imports System.Net


Public Class AddAdmin

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
    Sub RefreshDatabase()
        Connection()
        Dim Query As String = "select idno AS 'No', studentid AS 'Student ID',password AS 'Password',firstname AS 'First Name',lastname AS 'Last Name',middleinitial AS 'Middle Initial',course AS 'Course',year AS 'Year',address AS 'Address',contactno AS 'Contact No',ipaddress AS 'Ip Address',pcname AS 'PC Name',date_register AS 'Date Register' from tbl_register ORDER by idno ASC"
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
    Private Sub AddAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtStudentID.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please input Student ID!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtFirstName.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please input First Name!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtLastName.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please input Last Name!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtMiddleInitial.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please input Middle Initial!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtAddress.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please input Address!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtContactNo.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please input Contact No!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtPassword.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please input Password!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf cmbUsertype.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please input User Type!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)

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
                Command.Parameters.AddWithValue("@usertype", cmbUsertype.Text)
                READER = Command.ExecuteReader
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Me.Hide()
            RefreshDatabase()
            Form1.RefreshDatabase()
            Cleartextbox()
            MysqlConn.Close()
            MetroFramework.MetroMessageBox.Show(Me, "Successfully Register.", "Success.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
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

    Private Sub txtLastName_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
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

    Private Sub txtCourse_KeyPress_1(sender As Object, e As KeyPressEventArgs)
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