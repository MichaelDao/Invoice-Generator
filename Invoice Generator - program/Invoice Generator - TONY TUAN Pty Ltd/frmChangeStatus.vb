'Invoice generator - by Michael Dao
'Form7 - Change status
'If user is changing status of 'unpaid' prompt with payment type input
'created: 24/08/2016
'last edit: 24/08/2016
'known problems: nil

Public Class frmChangeStatus
    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        'validate combobox to ensure input is available
        If cmbPayment.Text = "" Then
            MsgBox("Please select the payment method", MsgBoxStyle.Critical, "error")
        Else
            My.Forms.frmRecords.paymentchange() 'call change subroutine
            Me.Close() 'close form
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close() 'close the form
    End Sub

    Private Sub LettersOnly(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPayment.KeyPress
        'Prevents input of numerical characters, allows capitals and space
        Select Case Asc(e.KeyChar)
            Case 8, 32, 65 To 90, 97 To 122 : e.Handled = False : Case Else : e.Handled = True
        End Select
    End Sub
End Class