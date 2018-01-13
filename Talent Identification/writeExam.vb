Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class writeExam
    Dim _con As New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim _cmd As MySqlCommand

    ''' <summary>
    ''' The timercount
    ''' </summary>
    Dim _timercount As Integer  'The number of seconds
    Dim time_limit As String

    Private Sub Loadgrid()
        _con.Close()
        Try
            _con.Open()
            _cmd = New MySqlCommand("select * from results where username='" + FrmLogin.lblUsername.ToUpper + "' and status='PENDING' ", _con)
            Dim myda2 As MySqlDataAdapter = New MySqlDataAdapter(_cmd)
            Dim mydataset2 As DataSet = New DataSet
            myda2.Fill(mydataset2, "results")
            DataGridView1.DataSource = mydataset2.Tables("results").DefaultView
            DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.RowCount - 1
            DataGridView1.Rows(DataGridView1.RowCount - 1).Selected = True
            DataGridView1.CurrentCell = DataGridView1.Rows(DataGridView1.RowCount - 1).Cells(0)
            _con.Close()
        Catch ex As Exception
            _con.Close()
            ' MsgBox(ex.Message)
        End Try
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
        e6.SelectedIndex = -1
    End Sub

    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MsgBox("Your score is 90% you have passed the exam")

        Try
            _con.Open()
            _cmd = New MySqlCommand("INSERT INTO results (questionID, industry, examID, question, option1, option2, option3, answer ,username) Select questionID,industry,examID,question,option1,option2,option3,answer ,'" + FrmLogin.lblUsername.ToUpper + "' from exams WHERE industry='" + FrmLogin.industry + "' and active='ACTIVE' ", _con)
            _cmd.ExecuteReader(CommandBehavior.CloseConnection)
            _cmd.Dispose()
            _con.Close()
        Catch ex As Exception
            _cmd.Dispose()
            _con.Close()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Loadgrid()

        Dim examdate As String


        Dim SQL As String = "SELECT distinct(exam_date),time_limit FROM exams where industry ='" + FrmLogin.industry + "' and active='ACTIVE'"
        Using _cmd = New MySqlCommand(SQL, _con)
            _con.Close()
            _con.Open()
            Try
                Dim dr = _cmd.ExecuteReader()
                While dr.Read()
                    examdate = dr("exam_date").ToString()
                    time_limit = dr("time_limit").ToString()
                    _timercount = CInt(time_limit)
                End While
            Catch ex As MySqlException
                ' Do some logging or something. 
                MessageBox.Show("There was an error accessing your exam centre. DETAIL: " & ex.ToString())
            End Try
        End Using

        Timer1.Start()
    End Sub

    Private Sub SimpleButton7_Click_1(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        If e1.Text = "" Or e2.Text = "" Or e3.Text = "" Or e4.Text = "" Or e5.Text = "" Or e6.Text = "" Then
            MsgBox("missing parameters")
            Exit Sub
        End If

        If e1.Enabled = True Then

            Try
                _con.Open()
                _cmd = New MySqlCommand("update exams set question='" + e2.Text.ToString.Replace("'", "''") + "', option1='" + e3.Text.ToString.Replace("'", "''") + "',option2='" + e4.Text.ToString.Replace("'", "''") + "',option3='" + e5.Text.ToString.Replace("'", "''") + "',answer='" + e6.Text + "' where questionID='" + e0.Text + "' ", _con)
                _cmd.ExecuteReader(CommandBehavior.CloseConnection)
                _cmd.Dispose()
                _con.Close()
                MessageBox.Show("Question Updated")
                e1.Enabled = True

                clearAlltxt()
                Loadgrid()

            Catch ex As Exception
                _cmd.Dispose()
                _con.Close()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'MsgBox("Starting Exam")
        ' Panel2.Visible = True

        Label2.Text = _timercount.ToString() 'show the countdown in the label
        If _timercount = 0 Then 'Check to see if it has reached 0, if yes then stop timer and display done
            Timer2.Enabled = False
            Label2.Text = "EXAM TIME OUT"
            UpdateStats()
        Else 'If timercount is higher then 0 then subtract one from it
            _timercount -= 1
            UpdateStats()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        UpdateStats()
    End Sub
    Private Sub UpdateStats()
        Try
            'exam
            ArcScaleComponent2.MaxValue = CInt(time_limit)
            ArcScaleComponent2.Value = Double.Parse(CInt(time_limit) - _timercount)
            LabelComponent1.Text = String.Format("{0} ", (CInt(time_limit) - _timercount))
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dispose()
    End Sub

    Private Sub writeExam_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub
End Class
