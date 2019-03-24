Imports MySql.Data.MySqlClient
Imports MetroFramework
Imports Excel = Microsoft.Office.Interop.Excel
Public Class AdminLogs
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
    Private Sub bunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles bunifuFlatButton2.Click
        Me.Hide()
        Form1.Show()
        Form1.RefreshDatabase()
    End Sub

    Private Sub AdminLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuFlatButton1.selected = True
        BunifuImageButton4.Visible = False
        Me.WindowState = FormWindowState.Maximized
        Connection()
        Dim Quer As String = "select id AS 'No',studentid AS 'USER',timein AS 'Time In',name AS 'First Name',lastname AS 'Last Name',Course,Year,pcname AS 'PC Name',datetime_login AS 'Date' from tbl_userlogs ORDER by id ASC"
        Dim adp As New MySqlDataAdapter(Quer, MysqlConn)
        Dim ds As New DataSet()
        adp.Fill(ds, "tbl_register")
        bunifuCustomDataGrid1.DataSource = ds.Tables(0)
        MysqlConn.Close()
    End Sub
    Sub Refreshlogs()
        Connection()
        Dim Quer As String = "select id AS 'No',studentid AS 'USER',timein AS 'Time In',name AS 'First Name',lastname AS 'Last Name',Course,Year,pcname AS 'PC Name',datetime_login AS 'Date' from tbl_userlogs  ORDER by id ASC"
        Dim adp As New MySqlDataAdapter(Quer, MysqlConn)
        Dim ds As New DataSet()
        adp.Fill(ds, "tbl_register")
        bunifuCustomDataGrid1.DataSource = ds.Tables(0)
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

    Private Sub bunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles bunifuMetroTextbox1.OnValueChanged
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim binding As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select * from tbl_userlogs where CONCAT(id,studentid,timein,datetime_login,firstname,lastname,Course,Year,pcname) LIKE '%" & bunifuMetroTextbox1.Text & "%'"
            Command = New MySqlCommand(Query, MysqlConn)
            da.SelectCommand = Command
            da.Fill(dt)
            binding.DataSource = dt
            bunifuCustomDataGrid1.DataSource = binding
            da.Update(dt)
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
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
            Application.Exit()
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
        xlWorkBook.SaveAs("C:\Users\" + computername + "\Desktop\Userlogs.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
        Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
        xlWorkBook.Close(True, misValue, misValue)
        xlApp.Quit()


        releaseObject(xlWorkSheet)
        releaseObject(xlWorkBook)
        releaseObject(xlApp)

        MetroFramework.MetroMessageBox.Show(Me, "Successfully Exported to Excel.", "Saved to C:\Users\" + computername + "\Desktop\StudentRecords.xls", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Function GetComputerName() As String
        Dim ComputerName As String
        ComputerName = System.Net.Dns.GetHostName
        Return ComputerName
    End Function

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

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        AdminAccount.Show()
    End Sub
End Class
