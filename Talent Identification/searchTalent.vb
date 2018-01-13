Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class searchTalent
    Dim _con As New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim _cmd As MySqlCommand



    Private Sub Loadgrid()
        _con.Close()
        Try
            _con.Open()
            _cmd = New MySqlCommand("select * from users ", _con)
            Dim myda2 As MySqlDataAdapter = New MySqlDataAdapter(_cmd)
            Dim mydataset2 As DataSet = New DataSet
            myda2.Fill(mydataset2, "users")
            DataGridView1.DataSource = mydataset2.Tables("users").DefaultView
            DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.RowCount - 1
            DataGridView1.Rows(DataGridView1.RowCount - 1).Selected = True
            DataGridView1.CurrentCell = DataGridView1.Rows(DataGridView1.RowCount - 1).Cells(0)
            _con.Close()
        Catch ex As Exception
            _con.Close()
            ' MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loadgrid()
    End Sub






    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs)
        Dispose()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dispose()
    End Sub

End Class
