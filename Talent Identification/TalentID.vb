Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation
Public Class TalentID
    Dim _cmd As MySqlCommand
    ReadOnly _con As MySqlConnection = New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim _timercount As Integer = 60 'The number of seconds
    Dim logindate As String
    Dim logintime As String
    Dim menuchosen As String

    Dim yearend As String

    ''' <summary>
    ''' The realco identifier
    ''' </summary>
    Public realcoID As String

    ''' <summary>
    ''' The real company name
    ''' </summary>
    Public realcompanyname As String

    ''' <summary>
    ''' The user name
    ''' </summary>
    Public username As String
    Public time_limit As String

    Private ipv4Stats As IPv4InterfaceStatistics
    Private nic As NetworkInterface
    Private startUploaded, startDownloaded As Long
    Private Sub TelOneMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            txtusergroup.Text = FrmLogin.usergroup.ToUpper
            Label6.Text = FrmLogin.industry.ToUpper
            lblUsername.Text = FrmLogin.lblUsername.ToUpper
            username = FrmLogin.lblUsername.ToUpper
        Catch ex As Exception

        End Try

        Try
            _con.Open()
            Dim logoutdate As String = "LOGGED IN"
            Dim logout As String = "LOGGED IN"
            logintime = Now.ToLongTimeString
            logindate = Now.Date.ToString("dd/MM/yyyy")
            timeIn.Text = logintime
            dateIn.Text = logindate
            _cmd =
                New MySqlCommand(
                    "INSERT into audit(loginDate,loginTime,logoutDate,logoutTime,username) values ('" +
                    logindate + "','" + logintime + "','" + logoutdate + "','" + logout + "','" + lblUsername.Text +
                    "') ", _con)
            _cmd.ExecuteReader(CommandBehavior.CloseConnection)
            _cmd.Dispose()
            _con.Close()
        Catch ex As Exception
            _cmd.Dispose()
            _con.Close()
            'MsgBox(ex.Message)
        End Try


        If txtusergroup.Text = "ADMIN" Then
            examp.Visible = True
            setexamp.Visible = True
            reportsp.Visible = True
            adminp.Visible = True
            scoutp.Visible = True
            jobadminp.Visible = True
            activateexamp.Visible = True
        End If

        If txtusergroup.Text = "CANDIDATE" Then
            examp.Visible = True
            setexamp.Visible = False
            reportsp.Visible = False
            adminp.Visible = False
            scoutp.Visible = False
            jobadminp.Visible = False
            activateexamp.Visible = False
        End If


        If txtusergroup.Text = "TEST SETTER" Then
            examp.Visible = False
            setexamp.Visible = True
            reportsp.Visible = True
            adminp.Visible = False
            scoutp.Visible = False
            jobadminp.Visible = False
            activateexamp.Visible = True
        End If


        If txtusergroup.Text = "SCOUT" Then
            examp.Visible = False
            setexamp.Visible = False
            reportsp.Visible = True
            adminp.Visible = False
            scoutp.Visible = True
            jobadminp.Visible = True
            activateexamp.Visible = False
        End If

    End Sub

    Private Sub dateIn_Click(sender As Object, e As EventArgs) Handles dateIn.Click

    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub NavigationPane1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub npstats_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TileItem4_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles adminp.ItemClick
        FrmAdmin.ShowDialog()
    End Sub

    Private Sub TileItem2_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles setexamp.ItemClick
        setExam.ShowDialog()
    End Sub

    Private Sub TileItem7_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles activateexamp.ItemClick
        activateExam.ShowDialog()
    End Sub

    Private Sub TileItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles examp.ItemClick
        Dim wroteexam As String
        Dim SQL2 As String = "SELECT wroteexam FROM users where username ='" + FrmLogin.lblUsername + "'"
        Using _cmd = New MySqlCommand(SQL2, _con)
            _con.Close()
            _con.Open()
            Try
                Dim dr = _cmd.ExecuteReader()
                If dr.HasRows() Then
                    dr.Read()
                    wroteexam = dr("wroteexam").ToString()
                Else
                End If
            Catch ex As MySqlException
                ' Do some logging or something. 
                MessageBox.Show("There was an error accessing your exam centre. DETAIL: " & ex.ToString())
            End Try
        End Using



        Dim examdate As String
        Dim SQL As String = "SELECT distinct(exam_date),time_limit FROM exams where industry ='" + FrmLogin.industry + "' and active='ACTIVE'"
        Using _cmd = New MySqlCommand(SQL, _con)
            _con.Close()
            _con.Open()
            Try
                Dim dr = _cmd.ExecuteReader()
                If dr.HasRows() Then
                    dr.Read()
                    examdate = dr("exam_date").ToString()
                    time_limit = dr("time_limit").ToString()

                    Dim date1 As Date = Date.Parse(examdate)
                    Dim date2 As Date = Now.Date
                    Dim result As Integer = DateTime.Compare(date1, date2)
                    Dim relationship As String

                    If result < 0 Then
                        MsgBox("You have no new exams")
                        Exit Sub
                    ElseIf result = 0 Then
                        MsgBox("This exam expires today")
                        Exit Sub
                    ElseIf wroteexam = "YES" Then
                        MsgBox("You have already taken this exam")
                        Exit Sub
                    Else
                        MsgBox("You have a new exam expiring on " + date1.ToString("dd MMMM yyyy") + " at " + date1.ToString("hh.mm.ss"))
                        writeExam.ShowDialog()
                    End If
                Else
                    MsgBox("You have no new exams")
                End If
            Catch ex As MySqlException
                ' Do some logging or something. 
                MessageBox.Show("There was an error accessing your exam centre. DETAIL: " & ex.ToString())
            End Try
        End Using
    End Sub

    Private Sub TileItem5_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles scoutp.ItemClick
        searchTalent.ShowDialog()
    End Sub

    Private Sub reportsp_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles reportsp.ItemClick
        frmReports.ShowDialog()
    End Sub

    Private Sub jobadminp_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles jobadminp.ItemClick
        MsgBox("Under Development")
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        _cmd.Dispose()
        _con.Close()
        Try
            _con.Open()
            Dim logout As String = Now.ToLongTimeString
            Dim logoutdate As String = Now.Date.ToString("dd/MM/yyyy")
            _cmd =
                 New MySqlCommand(
                     "UPDATE audit set logoutDate='" + logoutdate + "',logoutTime='" + logout + "' where username='" + username +
                     "' and loginDate='" + logindate + "' and loginTime='" + logintime + "'", _con)
            _cmd.ExecuteNonQuery()
            _cmd.Dispose()
            _con.Close()

            Dispose()
        Catch ex As Exception
            _cmd.Dispose()
            _con.Close()
            MsgBox(ex.Message)
        End Try
        'FrmLogin.Show()
    End Sub
End Class
