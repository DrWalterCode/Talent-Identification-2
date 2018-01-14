Imports System.Configuration
Imports System.Net
Imports MySql.Data.MySqlClient

Public Class writeExam
    Dim _con As New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim _cmd As MySqlCommand
    Dim examID As String

    ''' <summary>
    ''' The timercount
    ''' </summary>
    Dim _timercount As Integer  'The number of seconds
    Dim time_limit As String

    Dim examquestions As String
    Dim correct As String
    Dim wrong As String
    Dim percentage As Double

    Dim output As New List(Of String)()
    Dim joinedNumbers As String = String.Empty

    Private Sub Loadgrid()
        _con.Close()
        Try
            _con.Open()
            _cmd = New MySqlCommand("select * from results_view where username='" + FrmLogin.lblUsername.ToUpper + "' and status='PENDING' ", _con)
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
            e0.Text = dr.Cells(3).Value.ToString
            examID = dr.Cells(3).Value.ToString
            e1.Text = dr.Cells(0).Value.ToString
            e2.Text = dr.Cells(4).Value.ToString
            e3.Text = dr.Cells(5).Value.ToString
            e4.Text = dr.Cells(6).Value.ToString
            e5.Text = dr.Cells(7).Value.ToString
            e6.Properties.Items.Clear()
            e6.Properties.Items.Add(dr.Cells(5).Value.ToString)
            e6.Properties.Items.Add(dr.Cells(6).Value.ToString)
            e6.Properties.Items.Add(dr.Cells(7).Value.ToString)
            'e6.Text = dr.Cells(7).Value.ToString
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
            _con.Close()
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



        Try
            _con.Close()
            _con.Open()
            _cmd = New MySqlCommand("update results set myanswer='" + e6.Text + "', status='ANSWERED' where examtakenID='" + e1.Text + "' ", _con)
            _cmd.ExecuteReader(CommandBehavior.CloseConnection)
            _cmd.Dispose()
            _con.Close()
            MessageBox.Show("Question Answered")
            clearAlltxt()
            Loadgrid()

        Catch ex As Exception
            _cmd.Dispose()
            _con.Close()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'MsgBox("Starting Exam")
        ' Panel2.Visible = True

        Label2.Text = _timercount.ToString() 'show the countdown in the label
        If _timercount = 0 Then 'Check to see if it has reached 0, if yes then stop timer and display done
            Timer2.Enabled = False
            Label2.Text = "EXAM TIME OUT"
            UpdateStats()
            Timer1.Stop()
            markexam()

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

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        markexam()

    End Sub

    Private Sub markexam()
        Try
            Try
                _con.Close()
                _con.Open()
                _cmd = New MySqlCommand("update users set WroteExam='YES' where industry='" + FrmLogin.industry + "' and username='" & FrmLogin.lblUsername & "' ", _con)
                _cmd.ExecuteReader(CommandBehavior.CloseConnection)
                _cmd.Dispose()
                _con.Close()
            Catch ex As Exception
                _cmd.Dispose()
                _con.Close()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


            _con.Close()
            _con.Open()
            _cmd = New MySqlCommand("Select count(*) As examquestions,sum(answer = myanswer) As correct,sum(answer!= myanswer) As wrong,(sum(answer = myanswer)/count(*))*100 as percentage From results where username='" & FrmLogin.lblUsername.ToUpper & "' and examID='" & examID & "'  ", _con)
            Dim dr As MySqlDataReader = _cmd.ExecuteReader()
            While dr.Read()
                Dim str As String = dr.GetString("examquestions").ToString()
                Dim str2 As String = dr.GetString("correct").ToString()
                Dim str3 As String = dr.GetString("wrong").ToString()
                Dim str4 As String = dr.GetString("percentage").ToString()
                If String.IsNullOrEmpty(str) Then
                Else
                    examquestions = str
                    correct = str2
                    wrong = str3
                    percentage = CDbl(str4)
                End If
            End While
            _cmd.Dispose()
            _con.Close()
        Catch ex As Exception
            '         _cmd.Dispose()
            _con.Close()
        End Try


        Try
            _con.Close()
            _con.Open()
            _cmd = New MySqlCommand("INSERT INTO results_marks (username,percentage,examID) values ('" + FrmLogin.lblUsername.ToUpper + "','" + percentage.ToString + "','" + examID + "') ", _con)
            _cmd.ExecuteReader(CommandBehavior.CloseConnection)
            _cmd.Dispose()
            _con.Close()
        Catch ex As Exception
            _cmd.Dispose()
            _con.Close()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        getListOfIndustryNumbers()


        Dim str5 As String
        For Each str5 In output
            If joinedNumbers = "" Then
                joinedNumbers = str5
            Else
                joinedNumbers = joinedNumbers + "," + str5

            End If


        Next

        Try
            Dim smsStatus As String
            smsStatus = SendSMS("TalentIdentification", "dede6abd49b9985263f9517fb03a947c", joinedNumbers, "Exam ID : " + examID + " Exam Questions :" + examquestions + " Correct : " + correct + " Wrong : " + wrong + " Percentage : " + percentage.ToString())
            MessageBox.Show(smsStatus)
            Dispose()
        Catch ex As Exception

        End Try

    End Sub

    Public Function getListOfIndustryNumbers() As List(Of String)
        Dim SQL As String = "SELECT phone FROM users where username ='" + FrmLogin.lblUsername.ToUpper + "'"
        Using _cmd = New MySqlCommand(SQL, _con)
            _con.Open()

            Try
                Dim dr = _cmd.ExecuteReader()
                While dr.Read()
                    output.Add(dr("phone").ToString())
                End While
            Catch e As MySqlException
                ' Do some logging or something. 
                MessageBox.Show("There was an error accessing your phone numbers. DETAIL: " & e.ToString())
            End Try
        End Using
        Return output
    End Function


    ''' <summary>
    ''' 'Function send Http request and returns the status of the message
    ''' </summary>
    ''' <param name="username">Account username </param>
    ''' <param name="webservicesToken">Webservices token. To get the web services token, login to the Bulk SMS system. Got To “My Account”, Then Click On “User Configuration”, And For the screen that comes up, copy the Webservices token.</param>
    ''' <param name="receipientMobileNumber">Receipient Mobile Number. You can put multiple number separated by comma</param>
    ''' <param name="SMSMessage">SMS Message </param>
    ''' <returns></returns>
    Private Function SendSMS(ByVal username As String, ByVal webservicesToken As String, ByVal receipientMobileNumbers As String, ByVal SMSMessage As String) As String

        Dim SmsStatusMsg As String = String.Empty
        Try
            'Sending SMS To User
            Dim client As WebClient = New WebClient()
            Dim URL As String = "http://portal.zimtext.co.zw/index.php?app=ws&u=" & username & "&h=" & webservicesToken & " &op=pv&to=" & receipientMobileNumbers & "&msg=" & SMSMessage
            SmsStatusMsg = client.DownloadString(URL)
            If SmsStatusMsg.Contains(“""status"":""OK""”) Then
                SmsStatusMsg = "Successfully Notified Student"
            Else
                If SmsStatusMsg.Contains(“""error"":""100""”) Then
                    SmsStatusMsg = "authentication failed"
                ElseIf SmsStatusMsg.Contains(“""error"":""101""”) Then
                    SmsStatusMsg = "type of action is invalid or unknown"
                ElseIf SmsStatusMsg.Contains(“""error"":""102""”) Then
                    SmsStatusMsg = "one or more field empty"
                ElseIf SmsStatusMsg.Contains(“""error"":""103""”) Then
                    SmsStatusMsg = "not enough credit for this operation"
                ElseIf SmsStatusMsg.Contains(“""error"":""104""”) Then
                    SmsStatusMsg = "webservice token is not available"
                ElseIf SmsStatusMsg.Contains(“""error"":""105""”) Then
                    SmsStatusMsg = "webservice token not enable for this user"
                ElseIf SmsStatusMsg.Contains(“""error"":""106""”) Then
                    SmsStatusMsg = "webservice token not allowed from this IP address"
                ElseIf SmsStatusMsg.Contains(“""error"":""200""”) Then
                    SmsStatusMsg = "send message failed"
                ElseIf SmsStatusMsg.Contains(“""error"":""201""”) Then
                    SmsStatusMsg = "destination number or message is empty"
                ElseIf SmsStatusMsg.Contains(“""error"":""400""”) Then
                    SmsStatusMsg = "no delivery status available"
                ElseIf SmsStatusMsg.Contains(“""error"":""401""”) Then
                    SmsStatusMsg = "no delivery status retrieved and SMS still in queue"
                ElseIf SmsStatusMsg.Contains(“""error"":""402""”) Then
                    SmsStatusMsg = "no delivery status retrieved and SMS has been processed from queue"
                ElseIf SmsStatusMsg.Contains(“""error"":""501""”) Then
                    SmsStatusMsg = "no data returned or result is empty"
                ElseIf SmsStatusMsg.Contains(“""error"":""600""”) Then
                    SmsStatusMsg = "admin level authentication failed"
                ElseIf SmsStatusMsg.Contains(“""error"":""601""”) Then
                    SmsStatusMsg = "inject message failed"
                ElseIf SmsStatusMsg.Contains(“""error"":""602""”) Then
                    SmsStatusMsg = "sender id or message is empty"
                ElseIf SmsStatusMsg.Contains(“""error"":""603""”) Then
                    SmsStatusMsg = "account addition failed due to missing data"
                End If

            End If
        Catch e1 As WebException
            SmsStatusMsg = e1.Message
        Catch e2 As Exception
            SmsStatusMsg = e2.Message
        End Try
        Return SmsStatusMsg
    End Function

End Class
