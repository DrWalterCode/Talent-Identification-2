Imports System.Configuration
Imports System.Net
Imports MySql.Data.MySqlClient

Public Class activateExam
    Dim _con As New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim _cmd As MySqlCommand

    Dim output As New List(Of String)()
    Dim joinedNumbers As String = String.Empty

    Private Sub TileItem3_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Loadgrid()
        _con.Close()
        Try
            _con.Open()
            _cmd = New MySqlCommand("select distinct(examID),industry,exam_date,time_limit from exams where industry='" + FrmLogin.industry.ToUpper + "' and active='Pending' ", _con)
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
                SmsStatusMsg = "Successfully Recovered Password"
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
    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        If e1.Text = "" Or e2.Text = "" Or e3.Text = "" Then
            MsgBox("missing parameters")
            Exit Sub
        End If

        If e1.Enabled = False Then

            Try
                _con.Open()
                _cmd = New MySqlCommand("update exams set active='ACTIVE', exam_date='" + e3.Text + "',time_limit='" + e2.Text + "' where examID='" + e1.Text + "' ", _con)
                _cmd.ExecuteReader(CommandBehavior.CloseConnection)
                _cmd.Dispose()
                _con.Close()
                MessageBox.Show("Exam now ACTIVE")
                clearAlltxt()
                Loadgrid()
                TabPane2.SelectedPageIndex = 1

                getListOfIndustryNumbers()


                Dim str As String
                For Each str In output
                    If joinedNumbers = "" Then
                        joinedNumbers = str
                    Else
                        joinedNumbers = joinedNumbers + "," + str

                    End If


                Next

                Dim smsStatus As String
                smsStatus = SendSMS("TalentIdentification", "dede6abd49b9985263f9517fb03a947c", joinedNumbers, "Please check you account there is a new exam  due on : " + e3.Text)
                MessageBox.Show(smsStatus)
                Dispose()

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

            e1.Text = dr.Cells(0).Value.ToString
            e2.Text = dr.Cells(3).Value.ToString
            e3.Text = dr.Cells(2).Value.ToString
            e1.Enabled = False
            SimpleButton7.Enabled = True
            TabPane2.SelectedPageIndex = 0
        Catch ex As Exception

        End Try
    End Sub
    Private Sub clearAlltxt()
        e1.Text = ""
        e2.Text = ""
        e2.Text = ""

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
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Function getListOfIndustryNumbers() As List(Of String)
        Dim SQL As String = "SELECT phone FROM users where industry ='" + FrmLogin.industry + "'"
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
End Class
