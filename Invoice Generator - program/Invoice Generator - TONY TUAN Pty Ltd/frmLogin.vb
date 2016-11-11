'Invoice generator - by Michael Dao
'Form4 - Login
'User enters login details before proceeding to the main form, creates form security.
'created: 1/08/2016
'last edit: 1/08/2016
'known problems: nil

Public Class frmLogin
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        'if the user and pass are correct, open menu form
        If txtUsername.Text = "admin" And txtPassword.Text = "pass" Then
            frmIntro.Show() : Me.Hide()
            txtUsername.Text = "" : txtPassword.Text = ""

            'validate the textboxes, deny entry if false
        ElseIf txtUsername.Text <> "admin" Then 'if user is false
            MsgBox("Wrong login, please try again", , "Login")
            txtUsername.Clear() : txtPassword.Clear()
        ElseIf txtPassword.Text <> "pass" Then 'if pass is false
            MsgBox("Wrong login, please try again", , "Login")
            txtUsername.Clear() : txtPassword.Clear()
        ElseIf txtUsername.Text = "" Then 'if blank
            MsgBox("Please enter a username", , "Login")
        ElseIf txtPassword.Text = "" Then 'if blank
            MsgBox("Please enter the password", , "Login")
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End 'quit the program
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmIntro.Show() : Me.Hide()
    End Sub
End Class