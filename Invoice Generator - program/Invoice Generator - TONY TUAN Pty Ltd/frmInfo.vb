'Invoice generator - by Michael Dao
'Form8 - Information
'Provides a brief introduction to the program
'created: 30/08/2016
'last edit: 30/08/2016
'known problems: nil

Public Class frmInfo
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        frmIntro.Show() : Me.Hide() 'close the form 
    End Sub
End Class