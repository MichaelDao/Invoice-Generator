'Invoice generator - by Michael Dao
'Form6 - record
'The user provides input about the client who made the order to be recorded in the next form
'created: 21/08/2016
'last edit: 24/08/2016
'known problems: nil

Imports System.Xml 'import for xml saving

Public Class frmRecordClient
    'declare global variables
    Dim passcheck As Boolean

    Private Sub record_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbPayment.Enabled = False 'disable combobox on form load
        cmbPayment.Text = "-"
    End Sub

    Private Sub rdbYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbYes.CheckedChanged
        'if yes is selected, enable combobox
        If rdbYes.Checked Then
            cmbPayment.Enabled = True
            cmbPayment.Text = "Cash"
        Else 'if no is selected, lock combobox and reset to default
            cmbPayment.Text = "-"
            cmbPayment.Enabled = False
        End If
    End Sub

    Private Sub btnRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandom.Click
        'declare local variables
        Dim Rnd As New Random : Dim stringbuild As New System.Text.StringBuilder : Dim Temp As Integer

        'Generate a random book number
        Dim Letters As New List(Of Integer)
        For i As Integer = 48 To 57  'add ASCII codes for numbers
            Letters.Add(i)
        Next
        'select 7 random numbers and display in textbox
        For count As Integer = 1 To 11
            Temp = Rnd.Next(0, Letters.Count)
            stringbuild.Append(Chr(Letters(Temp)))
        Next
        txtInvoiceNumb.Text = stringbuild.ToString 'display generated number
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Dim xmlname As Boolean = True 'declare boolean
        'validate the client and invoice number textboxes
        If txtClient.Text = "" Then
            MsgBox("Please enter the client name", MsgBoxStyle.Critical, "error")
        ElseIf cmbPayment.Text = "" Then
            MsgBox("Please select the payment method", MsgBoxStyle.Critical, "error")
        ElseIf txtInvoiceNumb.Text = "" Or Not Len(txtInvoiceNumb.Text) = 11 Then
            MsgBox("The Invoice ID must be 11 digits long", MsgBoxStyle.Critical, "error")
        Else : xmlsaver() 'call

            If passcheck = True Then 'if all checks pass
                'case statement to see which radio button was checked
                Select Case rdbYes.Checked
                    Case Is = True 'set 'yes' values
                        SPaid = "Paid"
                        SwitchP = 1
                    Case Is = False 'set 'no' values
                        SPaid = "Unpaid"
                        SwitchP = 0
                End Select

                'transfers data in current form across over to frmRecords
                SInvNum = txtInvoiceNumb.Text
                SClient = txtClient.Text
                SPayment = cmbPayment.Text
                SDate = dtpDate.Text
                Scost = My.Forms.frmGenerator.subtotal
                Sgst = My.Forms.frmGenerator.totalGST
                STotal = My.Forms.frmGenerator.AllTotal
                SsaveName = My.Forms.frmGenerator.lblxml.Text
                signal = True 'signal for next form

                'open frmRecords, hide current form
                Me.Hide() : frmGenerator.Hide() : frmRecords.Show()
                My.Forms.frmRecords.ClientInvoice()
            End If
        End If
    End Sub

    Private Sub xmlsaver() 'saves the new invoice
        'setup local variables
        Dim savestring As String = ""
        passcheck = True

        'if current array is not saved, prompt user to define xml file name
        If My.Forms.frmGenerator.lblxml.Text = "Unsaved" Then
            Dim newxmlstring As String = InputBox("This set of data is not saved, please state the '.xml' file name, it will be saved in 'bin/debug'", "xml file creator")
            Dim illegalChar As String = "\/:?*|<>""" 'illegal characters for file names

            'validation of the input box
            If newxmlstring = "" Then 'if blank, cancel
                MsgBox("Please enter a file name for the xml document")
                passcheck = False
            ElseIf illegalChar.Contains(newxmlstring) Then 'if contains illegal characters, cancel
                MsgBox("A file name cannot contain any of the following characters \ / : ? * | < >")
                passcheck = False
            Else 'if all checks have passed, display new file name
                My.Forms.frmGenerator.lblxml.Text = newxmlstring & ".xml"
            End If
        End If

        'grab the file name from the label
        savestring = My.Forms.frmGenerator.lblxml.Text

        If passcheck = True Then
            Dim saveFile As New SaveFileDialog
            saveFile.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*" 'set filter
            saveFile.FilterIndex = 2 'select xml

            'Create XmlWriterSettings
            Dim settings As XmlWriterSettings = New XmlWriterSettings()
            settings.Indent = True

            'Setup XmlWriter with defined xml name - [(xmlstring) & ".xml"] -
            Using writer As XmlWriter = XmlWriter.Create(savestring, settings)
                'Begin writing
                writer.WriteStartDocument()
                writer.WriteStartElement("Package_Invoices") 'Root

                'Loop over entries in array
                For Each entry As Pinvoice In Records
                    writer.WriteStartElement("Invoice")
                    writer.WriteElementString("Book_ID", entry.Book.ToString)
                    writer.WriteElementString("Customer", entry.Cust)
                    writer.WriteElementString("Address", entry.Address)
                    writer.WriteElementString("Post_Code", entry.Post.ToString)
                    writer.WriteElementString("Cost", entry.Cost.ToString)
                    writer.WriteElementString("GST", entry.GST.ToString)
                    writer.WriteElementString("Total", entry.Total.ToString)
                    writer.WriteEndElement()
                Next
                'End document
                writer.WriteEndElement()
                writer.WriteEndDocument()
            End Using
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close() 'close the form
    End Sub

    Private Sub NumbersOnly(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInvoiceNumb.KeyPress
        'prevents the input of non numerical characters
        Select Case Asc(e.KeyChar)
            Case 8, 48 To 57 : e.Handled = False : Case Else : e.Handled = True
        End Select
    End Sub

    Private Sub LettersOnly(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClient.KeyPress, cmbPayment.KeyPress
        'Prevents input of numerical characters, allows capitals and space
        Select Case Asc(e.KeyChar)
            Case 8, 32, 65 To 90, 97 To 122 : e.Handled = False : Case Else : e.Handled = True
        End Select
    End Sub
End Class