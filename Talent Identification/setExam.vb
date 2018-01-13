Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class setExam
    Dim _con As New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim _cmd As MySqlCommand

    Private Sub TileItem3_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Loadgrid()
        _con.Close()
        Try
            _con.Open()
            _cmd = New MySqlCommand("select * from exams where industry='" + FrmLogin.industry.ToUpper + "' ", _con)
            Dim myda2 As MySqlDataAdapter = New MySqlDataAdapter(_cmd)
            Dim mydataset2 As DataSet = New DataSet
            myda2.Fill(mydataset2, "exams")
            DataGridView1.DataSource = mydataset2.Tables("exams").DefaultView
            DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.RowCount - 1
            DataGridView1.Rows(DataGridView1.RowCount - 1).Selected = True
            DataGridView1.CurrentCell = DataGridView1.Rows(DataGridView1.RowCount - 1).Cells(0)
            _con.Close()
        Catch ex As Exception
            _con.Close()
            ' MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        If e1.Text = "" Or e2.Text = "" Or e3.Text = "" Or e4.Text = "" Or e5.Text = "" Or e6.Text = "" Then
            MsgBox("missing parameters")
            Exit Sub
        End If

        If e1.Enabled = True Then

            Try
                _con.Open()
                _cmd = New MySqlCommand("INSERT into exams(industry,examID,question,option1,option2,option3,answer) values ('" & FrmLogin.industry.ToUpper & "','" & e1.Text & "', '" & e2.Text.ToString.Replace("'", "''") & "','" + e3.Text.ToString.Replace("'", "''") + "', '" & e4.Text.ToString.Replace("'", "''") & "', '" & e5.Text.ToString.Replace("'", "''") & "', '" & e6.Text & "')", _con)
                _cmd.ExecuteReader(CommandBehavior.CloseConnection)
                _cmd.Dispose()
                _con.Close()
                MsgBox("Exam Question Saved")
                Loadgrid()
                clearsometxt()
                'TabPane2.SelectedPageIndex = 1
            Catch ex As Exception
                _cmd.Dispose()
                _con.Close()
                MessageBox.Show(ex.Message, "Error")
            End Try
        Else
            Try
                _con.Open()
                _cmd = New MySqlCommand("update exams set question='" + e2.Text.ToString.Replace("'", "''") + "', option1='" + e3.Text.ToString.Replace("'", "''") + "',option2='" + e4.Text.ToString.Replace("'", "''") + "',option3='" + e5.Text.ToString.Replace("'", "''") + "',answer='" + e6.Text + "' where questionID='" + e0.Text + "' ", _con)
                _cmd.ExecuteReader(CommandBehavior.CloseConnection)
                _cmd.Dispose()
                _con.Close()
                MessageBox.Show("Question Updated")
                e1.Enabled = True
                SimpleButton6.Enabled = False
                clearAlltxt()
                Loadgrid()
                TabPane2.SelectedPageIndex = 1
            Catch ex As Exception
                _cmd.Dispose()
                _con.Close()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            e0.Text = dr.Cells(0).Value.ToString
            e1.Text = dr.Cells(2).Value.ToString
            e2.Text = dr.Cells(3).Value.ToString
            e3.Text = dr.Cells(4).Value.ToString
            e4.Text = dr.Cells(5).Value.ToString
            e5.Text = dr.Cells(6).Value.ToString
            e6.Text = dr.Cells(7).Value.ToString
            e1.Enabled = False
            SimpleButton7.Enabled = True
            TabPane2.SelectedPageIndex = 0
        Catch ex As Exception

        End Try
    End Sub
    Private Sub clearAlltxt()
        e0.Text = ""
        e1.Text = ""
        e2.Text = ""
        e3.Text = ""
        e4.Text = ""
        e5.Text = ""
        e6.Text = ""
    End Sub

    Private Sub clearsometxt()
        e2.Text = ""
        e3.Text = ""
        e4.Text = ""
        e5.Text = ""
        e6.Text = ""
    End Sub

    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadgrid()
    End Sub

    Private Sub TileItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        TabControl1.SelectedIndex = 0
    End Sub



    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs)
        Dispose()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dispose()
    End Sub
End Class
