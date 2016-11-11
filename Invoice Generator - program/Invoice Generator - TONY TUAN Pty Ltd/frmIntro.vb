'Invoice generator - by Michael Dao
'Form1 - Intro menu
'Provides the user with various buttons for navigation around the program
'created: 27/06/2016
'last edit: 8/08/2016
'known problems: nil

Public Class frmIntro
    Private Sub btnGenerator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerator.Click
        frmGenerator.Show() : Me.Hide() 'close current form and open generator
    End Sub

    Private Sub btnRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecords.Click
        frmRecords.Show() : Me.Hide() 'close current form and open records
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        frmLogin.Show() : Me.Hide() 'go back to login form
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End 'terminate the program
    End Sub

    Private Sub btnInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfo.Click
        frmInfo.Show() : Me.Hide() 'open the info from
    End Sub
End Class