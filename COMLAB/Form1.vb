Imports MySql.Data.MySqlClient
Imports MetroFramework
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form1
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
        Dim Quer As String = "select idno AS 'No', studentid AS 'Student ID',password AS 'Password',firstname AS 'First Name',lastname AS 'Last Name',middleinitial AS 'Middle Initial',course AS 'Course',year AS 'Year',address AS 'Address',contactno AS 'Contact No',ipaddress AS 'Ip Address',pcname AS 'PC Name',usertype AS 'User Type',date_register AS 'Date Register' from tbl_register ORDER by idno ASC"
        Dim adp As New MySqlDataAdapter(Quer, MysqlConn)
        Dim ds As New DataSet()
        adp.Fill(ds, "tbl_register")
        bunifuCustomDataGrid1.DataSource = ds.Tables(0)
        MysqlConn.Close()
    End Sub
 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        bunifuFlatButton2.selected = True
        BunifuImageButton4.Visible = False
        Connection()

        Dim Quer As String = "select idno AS 'No', studentid AS 'Student ID',password AS 'Password',firstname AS 'First Name',lastname AS 'Last Name',middleinitial AS 'Middle Initial',course AS 'Course',year AS 'Year',address AS 'Address',contactno AS 'Contact No',ipaddress AS 'Ip Address',pcname AS 'PC Name',usertype AS 'User Type',date_register AS 'Date Register' from tbl_register ORDER by idno ASC"
        Dim adp As New MySqlDataAdapter(Quer, MysqlConn)
        Dim ds As New DataSet()
        adp.Fill(ds, "tbl_register")
        bunifuCustomDataGrid1.DataSource = ds.Tables(0)
        MysqlConn.Close()


        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=comlab"
        Dim Querya As String = "select * from tbl_userlogs"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        DataGridView1.DataSource = dsa.Tables(0)
        lblAdminID.Text = dsa.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()

    End Sub




    Private Sub bunifuImageButton1_Click(sender As Object, e As EventArgs) Handles bunifuImageButton1.Click
        BunifuImageButton4.Visible = True
        panel3.Location = New Point(197, 99)
        sidemenu.Width = 49
        sidemenu.Visible = False
        panelanimator1.ShowSync(sidemenu)
        bunifuImageButton1.Visible = False
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        sidemenu.Width = 256
        panel3.Location = New Point(293, 99)
        sidemenu.Visible = False
        animator1.ShowSync(sidemenu)
        BunifuImageButton4.Visible = False
        bunifuImageButton1.Visible = True
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddAdmin.Show()
    End Sub

    Private Sub bunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles bunifuMetroTextbox1.OnValueChanged
        Dim Santie As New MySqlDataAdapter
        Dim Pelayo As New DataTable
        Dim binding As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select * from tbl_register where CONCAT(idno,studentid,password,firstname,lastname,middleinitial,course,year,address,contactno,usertype) LIKE '%" & bunifuMetroTextbox1.Text & "%' "
            Command = New MySqlCommand(Query, MysqlConn)
            Santie.SelectCommand = Command
            Santie.Fill(Pelayo)
            binding.DataSource = Pelayo
            bunifuCustomDataGrid1.DataSource = binding
            Santie.Update(Pelayo)
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub bunifuThinButton23_Click(sender As Object, e As EventArgs) Handles bunifuThinButton23.Click
        Connection()
        If TextBox1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please choose record to be delete", "Select First", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Select Case MetroMessageBox.Show(Me, "Are you sure to delete this user?", "DELETE USER", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)
                Case MsgBoxResult.Ok
                    Dim reader As MySqlDataReader
                    Try
                        MysqlConn.Open()
                        Dim query As String
                        query = "Delete from tbl_register where studentid=@id"
                        Command = New MySqlCommand(query, MysqlConn)
                        Command.Parameters.AddWithValue("@id", ID.Text)
                        reader = Command.ExecuteReader
                        MetroFramework.MetroMessageBox.Show(Me, "Successfully Delete!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        MysqlConn.Close()
                    Catch ex As Exception
                        MsgBox("ERROR NA")
                    Finally
                        MysqlConn.Dispose()
                    End Try
                Case MsgBoxResult.Cancel
            End Select
        End If
        RefreshDatabase()
    End Sub

    Private Sub bunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles bunifuCustomDataGrid1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = bunifuCustomDataGrid1.Rows(e.RowIndex)
            ID.Text = row.Cells("Student ID").Value.ToString
            TextBox1.Text = row.Cells("Student ID").Value.ToString
            UpdateForm.txtStudentID.Text = row.Cells("Student ID").Value.ToString
            UpdateForm.studentno.Text = row.Cells("Student ID").Value.ToString
            UpdateForm.txtPassword.Text = row.Cells("Password").Value.ToString
            UpdateForm.txtFirstName.Text = row.Cells("First Name").Value.ToString
            UpdateForm.txtLastName.Text = row.Cells("Last Name").Value.ToString
            UpdateForm.txtMiddleInitial.Text = row.Cells("Middle Initial").Value.ToString
            UpdateForm.txtCourse.Text = row.Cells("Course").Value.ToString
            UpdateForm.txtYear.Text = row.Cells("Year").Value.ToString
            UpdateForm.txtContactNo.Text = row.Cells("Contact No").Value.ToString
            UpdateForm.txtAddress.Text = row.Cells("Address").Value.ToString
            UpdateForm.cmbUsertype.Text = row.Cells("User Type").Value.ToString
        End If
    End Sub

    Private Sub bunifuThinButton24_Click(sender As Object, e As EventArgs) Handles bunifuThinButton24.Click
        If TextBox1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please choose record to be update", "Select First", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            UpdateForm.Show()
        End If
    End Sub
    Sub updatestatus()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=comlab"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update tbl_register set status='" & lblOffline.Text & "'  where usertype = '" & ADMIN.Text & "'"
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
    Private Sub bunifuImageButton3_Click(sender As Object, e As EventArgs) Handles bunifuImageButton3.Click
        Select Case MetroMessageBox.Show(Me, "Are you sure to exit the application?", "LOG OUT.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            Case MsgBoxResult.Ok
                Login.Show()
                UpdateStatus()
                Login.MaterialSingleLineTextField1.Clear()
                Login.MaterialSingleLineTextField2.Clear()
                Me.Hide()
            Case MsgBoxResult.Cancel
        End Select
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=comlab"
        Dim regDate As DateTime = DateTime.Now
        Dim strDate As String = regDate.ToString("yyyy-MM-dd HH:mm:ss")
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update tbl_userlogs set id='" & lblAdminID.Text & "',timeout= '" & strDate & "' where id = '" & lblAdminID.Text & "'"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
            MysqlConn.Close()
        End Try
    End Sub
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.Hide()
        AdminLogs.Show()
        AdminLogs.Refreshlogs()
    End Sub
    Public Function GetComputerName() As String
        Dim ComputerName As String
        ComputerName = System.Net.Dns.GetHostName
        Return ComputerName
    End Function
    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim computername As String
        computername = GetComputerName()
        Dim i As Int16, j As Int16

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Sheet1")


        For i = 0 To bunifuCustomDataGrid1.RowCount - 1
            For j = 0 To bunifuCustomDataGrid1.ColumnCount - 1
                For k As Integer = 1 To bunifuCustomDataGrid1.Columns.Count
                    xlWorkSheet.Cells(1, k) = bunifuCustomDataGrid1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = bunifuCustomDataGrid1(j, i).Value.ToString()
                Next
            Next
        Next
        xlWorkBook.SaveAs("C:\Users\" + computername + "\Desktop\StudentRecords.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
        Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
        xlWorkBook.Close(True, misValue, misValue)
        xlApp.Quit()


        releaseObject(xlWorkSheet)
        releaseObject(xlWorkBook)
        releaseObject(xlApp)

        MetroFramework.MetroMessageBox.Show(Me, "Successfully Exported to Excel.", "Saved to C:\Users\" + computername + "\Desktop\StudentRecords.xls", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Exception Occured while releasing object " + ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub sidemenu_Paint(sender As Object, e As PaintEventArgs) Handles sidemenu.Paint

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        AdminAccount.Show()
    End Sub
End Class
