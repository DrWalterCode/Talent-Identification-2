Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class frmReports
    Dim _con As New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim _cmd As MySqlCommand




    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loadgrid()
    End Sub


    Private Sub TabPane1_SelectedPageIndexChanged(sender As Object, e As EventArgs) _
        Handles TabPane1.SelectedPageIndexChanged
        Try
            Select Case TabPane1.SelectedPageIndex
                Case 0
                    Dim report As New resultsrepo
                    Me.DocumentViewer1.DocumentSource = report
                    report.CreateDocument(False)

                Case 1
                    Dim report As New usersrepo
                    Me.DocumentViewer2.DocumentSource = report
                    report.CreateDocument(False)
                Case 2
                    Dim report As New auditrepo
                    Me.DocumentViewer3.DocumentSource = report
                    report.CreateDocument(False)

            End Select
        Catch ex As Exception

        End Try
    End Sub



    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs)
        Dispose()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dispose()
    End Sub

End Class
