Imports System.Configuration
Imports System.Net
Imports MySql.Data.MySqlClient

Public Class searchTalent
    Dim _con As New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim _cmd As MySqlCommand

    Dim cellnum As String = "zero"

    Dim output As New List(Of String)()
    Dim joinedNumbers As String = String.Empty

    Private Sub Loadgrid()
        If txtnum.Text = "" Or txtindus.Text = "" Then
            MsgBox("missing parameters")
            Exit Sub
        End If
        _con.Close()
        Try
            _con.Open()
            _cmd = New MySqlCommand("select * from result_view where industry='" + txtindus.Text + "' and percentage >='" + txtnum.Text + "' ", _con)
            Dim myda2 As MySqlDataAdapter = New MySqlDataAdapter(_cmd)
            Dim mydataset2 As DataSet = New DataSet
            myda2.Fill(mydataset2, "result_view")
            DataGridView1.DataSource = mydataset2.Tables("result_view").DefaultView
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

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            cellnum = dr.Cells(1).Value.ToString

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
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
            smsStatus = SendSMS("TalentIdentification", "dede6abd49b9985263f9517fb03a947c", cellnum, "You have been invited for an interview contact the following number for more details : " + joinedNumbers)
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

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        Loadgrid()
    End Sub
End Class
