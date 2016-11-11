'Invoice generator - by Michael Dao
'Form5 - Search
'This form allows the user to search for specific strings in the client listbox in form3
'created: 12/08/2016
'last edit: 23/08/2016
'known problems: nil

Public Class frmSearch
    'declare global variable
    Dim i As Integer = 0

    Private Sub frmSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'hide all groupboxes on form load
        grpInvoice.Hide() : grpStatus.Hide() : grpPayment.Hide() : grpDate.Hide() : grpClient.Hide()
    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearch.SelectedIndexChanged
        'automatically hide all groupboxes
        grpInvoice.Hide() : grpStatus.Hide() : grpPayment.Hide() : grpDate.Hide() : grpClient.Hide()

        'when choosing combobox item, show corresponding groupbox
        Select Case cmbSearch.Text
            Case Is = "Invoice number"
                grpInvoice.Show()
            Case Is = "Payment status"
                grpStatus.Show()
            Case Is = "Payment method"
                grpPayment.Show()
            Case Is = "Date"
                grpDate.Show()
            Case Is = "Client name"
                grpClient.Show()
        End Select
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'declare local variables
        Dim correct As Boolean = True
        Dim found As Boolean = False
        Dim SearchId As String = ""
        i = 0

        'ensure that an item from the combobox is selected
        If cmbSearch.Text = "" Then
            MsgBox("Please select an item to search", MsgBoxStyle.Critical, "error")
        Else
            'load user input into searchID, validate it with this select case statement
            Select Case cmbSearch.Text
                Case Is = "Invoice number"
                    If txtInvNumber.Text = "" Or Not Len(txtInvNumber.Text) = 11 Then 'must be 11 digits
                        MsgBox("The Invoice ID must be 11 digits long", MsgBoxStyle.Critical, "error") : correct = False
                    Else : SearchId = txtInvNumber.Text
                    End If
                Case Is = "Payment status"
                    If rdbYes.Checked Then : SearchId = "Paid" 'search id is based on one of two radio buttons
                    Else : SearchId = "Unpaid"
                    End If
                Case Is = "Payment method"
                    If cmbPayment.Text = "" Then 'prompt if blank
                        MsgBox("Please select the payment method", MsgBoxStyle.Critical, "error") : correct = False
                    Else : SearchId = cmbPayment.Text
                    End If
                Case Is = "Date"
                    SearchId = dtpDate.Text 'take in the date, no validation required
                Case Is = "Client name"
                    If txtClient.Text = "" Then 'ensure client textbox is not blank
                        MsgBox("Please enter the client name", MsgBoxStyle.Critical, "error") : correct = False
                    Else : SearchId = txtClient.Text
                    End If
            End Select

            If correct = True Then
                'define pointer then clear list
                Dim listrowcount As String = My.Forms.frmRecords.lstClients.Items.Count
                lstSearch.Items.Clear()
                'Use a linear search to loop through the listbox and find specific variables
                Do Until i = listrowcount
                    'stop when the input matches the string in an array
                    Select Case cmbSearch.Text
                        Case Is = "Invoice number"
                            If SearchId = InvoiceNumb(i) Then
                                found = True : listentry() 'call
                            End If
                        Case Is = "Payment status"
                            If SearchId = paid(i) Then
                                found = True : listentry() 'call
                            End If
                        Case Is = "Payment method"
                            If SearchId = PaymentType(i) Then
                                found = True : listentry() 'call
                            End If
                        Case Is = "Date"
                            If SearchId = myDate(i) Then
                                found = True : listentry() 'call
                            End If
                        Case Is = "Client name"
                            If SearchId = ClientName(i) Then
                                found = True : listentry() 'call
                            End If
                    End Select
                    i = i + 1 'move to next array
                Loop
                'if the value has not been found, prompt user
                If found = False Then
                    MsgBox(SearchId & " could not be found", , "Search")
                End If
            End If
        End If
    End Sub

    Private Sub listentry() 'enters the selected array into the list, subroutine prevents repetition in code
        lstSearch.Items.Add("|Invoice ID|: " & InvoiceNumb(i) & "  |Status|: " & paid(i) & "  |Payment|: " & PaymentType(i) & "  |Date|: " & myDate(i) & "  |Client|: " & ClientName(i) & "  |Subtotal|: " & Subtotal(i) & "  |GST|: " & gstTotal(i) & "  |Total inc. GST|: " & Total(i))
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'if nothing selected, prompt user
        sxmlName = ""
        If lstSearch.SelectedItem = "" Then
            MsgBox("Please select a client invoice")
        Else
            'find row count of list to determing array position
            Dim rowCount As Integer = lstSearch.SelectedIndex
            sxmlName = saveName(rowCount)
            flag = True

            'open form2 and initiate loadxml subroutine
            Me.Hide() : frmRecords.Hide() : frmGenerator.Show()
            My.Forms.frmGenerator.Loadxml()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close() 'close form
    End Sub

    Private Sub NumbersOnly(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInvNumber.KeyPress
        'prevents the input of non numerical characters
        Select Case Asc(e.KeyChar)
            Case 8, 48 To 57 : e.Handled = False
            Case Else : e.Handled = True
        End Select
    End Sub

    Private Sub LettersOnly(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClient.KeyPress
        'Prevents input of numerical characters, allows capitals and space
        Select Case Asc(e.KeyChar)
            Case 8, 32, 65 To 90, 97 To 122 : e.Handled = False
            Case Else : e.Handled = True
        End Select
    End Sub
End Class
