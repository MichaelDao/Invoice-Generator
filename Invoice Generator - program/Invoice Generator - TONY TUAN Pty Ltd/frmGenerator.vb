'Invoice generator - by Michael Dao
'Form2 - Tax invoice generator
'This form will generate package invoices that contribute towards the client invoice for the next form, can also be saved as xml 
'created: 27/06/2016
'last edit: 26/08/2016
'known problems: - remove button does not remove loop - 

'import variables
Imports System.Xml
Imports System.Text

Public Class frmGenerator
    'declare public variables
    Public subtotal, totalGST, AllTotal As Double

    Private Sub btnRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandom.Click
        'declare local variables
        Dim Rnd As New Random : Dim stringbuild As New System.Text.StringBuilder : Dim Temp As Integer

        'Generate a random book number
        Dim Letters As New List(Of Integer)
        For i As Integer = 48 To 57  'add ASCII codes for numbers
            Letters.Add(i)
        Next
        'select 7 random numbers and display in textbox
        For count As Integer = 1 To 7
            Temp = Rnd.Next(0, Letters.Count)
            stringbuild.Append(Chr(Letters(Temp)))
        Next
        txtBook.Text = stringbuild.ToString 'display generated number
    End Sub

    Private Sub btnRecordOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecordOpen.Click
        frmRecords.Show() : Me.Hide() 'close current form and open records
        My.Forms.frmRecordClient.Hide()
    End Sub

    Private Sub btnMenuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuOpen.Click
        frmIntro.Show() : Me.Hide() 'close current form and open menu
        My.Forms.frmRecordClient.Hide()
    End Sub

    Private Sub btncleartext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncleartext.Click
        'reset all textboxes for package invoice
        txtCost.Text = "0.00" : txtBook.Text = "" : txtCust.Text = ""
        txtAddress.Text = "" : txtPost.Text = ""
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'prompt user, if yes, then reset datagridview and labels
        If MsgBox("Are you sure you want to clear all invoices?", MsgBoxStyle.YesNo, "Invoice generator") = vbYes Then
            lblSubtotal.Text = "$0.00" : lblTotal.Text = "$0.00" : lblGST.Text = "$0.00" : lblxml.Text = "Unsaved"
            dgvPackageInvoice.Rows.Clear()
            Records.Clear()
        End If
    End Sub

    Private Sub validation()
        'prepare variables used in validation
        bookNumb = Val(txtBook.Text) : postNumb = Val(txtPost.Text) : costNumb = Val(txtCost.Text)
        correct = True

        'if correct becomes false, cancel the process
        If bookNumb <= 0 Or Not Len(txtBook.Text) = 7 Then
            MsgBox("The book number must be 7 digits long", MsgBoxStyle.Critical, "error") : correct = False
        ElseIf txtCust.Text = "" Then
            MsgBox("Please enter the customer name", MsgBoxStyle.Critical, "error") : correct = False
        ElseIf txtAddress.Text = "" Then
            MsgBox("Please enter the shipping address", MsgBoxStyle.Critical, "error") : correct = False
        ElseIf postNumb <= 0 Or Not Len(txtPost.Text) = 4 Then
            MsgBox("Please enter the post code", MsgBoxStyle.Critical, "error") : correct = False
        ElseIf costNumb <= 0 Then
            MsgBox("Please enter the shipping cost", MsgBoxStyle.Critical, "error") : correct = False
        End If
    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        validation() 'call subroutine to validate inputs

        'setup variables for the array
        bookNumb = Val(txtBook.Text) : postNumb = Val(txtPost.Text)
        costNumb = Format(Val(txtCost.Text), "0.00")
        gstNumb = Format((costNumb * 0.1), "0.00")
        totalNumb = Format((costNumb * 1.1), "0.00")

        'if validation checks out, prepare array for invoice generation
        If correct = True Then
            entry.Book = bookNumb
            entry.Cust = txtCust.Text
            entry.Address = txtAddress.Text
            entry.Post = postNumb
            entry.Cost = costNumb
            entry.GST = gstNumb
            entry.Total = totalNumb
            Generate() 'call subroutine for invoice adding
        End If
    End Sub

    Private Sub Generate()
        'add array then clear the datagridview
        Records.Add(entry) : dgvPackageInvoice.Rows.Clear()
        subtotal = 0 : totalGST = 0 : AllTotal = 0

        'loops until all the invoices are entered
        For Each d As Pinvoice In Records
            dgvPackageInvoice.Rows.Add(d.Book, d.Cust, d.Address, d.Post, d.Cost, d.GST, d.Total)
        Next
        'grab shipping cost from each array and add them up
        For i As Integer = 0 To dgvPackageInvoice.RowCount - 1
            subtotal += dgvPackageInvoice.Rows(i).Cells(4).Value
            totalGST += dgvPackageInvoice.Rows(i).Cells(5).Value
            AllTotal += dgvPackageInvoice.Rows(i).Cells(6).Value
        Next
        'display calculated value in label as currency format
        lblSubtotal.Text = Format(Val(subtotal), "Currency")
        lblGST.Text = Format(Val(totalGST), "Currency")
        lblTotal.Text = Format(Val(AllTotal), "Currency")
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        'check to see if the dataset is saved or not
        newsave = False
        If lblxml.Text = "Unsaved" Then
            newsave = True
        End If
        'Check that at least one array is present
        If lblSubtotal.Text = "$0.00" Then
            MsgBox("Please create at least one package invoice", MsgBoxStyle.Critical, "error")
        Else
            My.Forms.frmRecordClient.Show() 'open the client record form
        End If
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Loadxml() 'call subroutine
    End Sub

    Public Sub Loadxml()
        Try 'filter xml files for openfile
            xmlFileDialog.Filter = "Files (*.xml) | *.xml"
            If flag = True Then 'if loading from records
                xmlName = sxmlName
                flag = False 'if loading from button
            ElseIf xmlFileDialog.ShowDialog() = DialogResult.OK Then 'use variable from openfiledialog
                xmlName = System.IO.Path.GetFileName(xmlFileDialog.FileName) 'grab xml file name 
            End If

            'load the xml, if error encountered, stop process
            If Not xmlName = "" Then
                Dim xmlDoc As New XmlDocument()
                xmlDoc.Load(CStr(xmlName))
                lblxml.Text = xmlName 'display file name in label

                'clear datagridview and arrays
                lblSubtotal.Text = "$0.00" : lblTotal.Text = "$0.00" : lblGST.Text = "$0.00"
                frmRecordClient.Close()
                Records.Clear()
                dgvPackageInvoice.Rows.Clear()

                'Begin looking at nodes within xml file that contains the user data
                Dim nodes As XmlNodeList = xmlDoc.DocumentElement.SelectNodes("/Package_Invoices/Invoice")
                For Each node As XmlNode In nodes
                    Dim xBook As String = node.SelectSingleNode("Book_ID").InnerText
                    Dim xCust As String = node.SelectSingleNode("Customer").InnerText
                    Dim xAddress As String = node.SelectSingleNode("Address").InnerText
                    Dim xPost As String = node.SelectSingleNode("Post_Code").InnerText
                    Dim xCost As String = node.SelectSingleNode("Cost").InnerText
                    Dim xGst As String = node.SelectSingleNode("GST").InnerText
                    Dim xTotal As String = node.SelectSingleNode("Total").InnerText

                    'prepare array for invoice generation
                    entry.Book = xBook
                    entry.Cust = xCust
                    entry.Address = xAddress
                    entry.Post = xPost
                    entry.Cost = xCost
                    entry.GST = xGst
                    entry.Total = xTotal
                    Generate() 'run subroutine
                Next
            End If
        Catch ex As Exception 'If error found, stop and prompt error
            MsgBox("The xml file has been corrupted or is the wrong type", , "xml loader")
        End Try
    End Sub

    Private Sub btnCompile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCompile.Click
        'Prompt user with input box, will define the xml file name
        Dim xmlstring As String = InputBox("Please enter a name for this set of package invoices, the '.xml' will be saved in 'bin/debug'", "xml file creator")
        Dim xmlName As Boolean = True
        Dim illegalChar As String = "\/:?*|<>""" 'illegal characters for file names

        'validation of the input box
        If xmlstring = "" Then
            MsgBox("Please enter a file name for the xml document")
            xmlName = False
        ElseIf illegalChar.Contains(xmlstring) Then
            MsgBox("A file name cannot contain any of the following characters \ / : ? * | < >")
            xmlName = False
        ElseIf lblSubtotal.Text = "$0.00" Then
            MsgBox("Please create at least one package invoice")
            xmlName = False
        Else 'when checks pass, create file name
            lblxml.Text = xmlstring & ".xml"
        End If

        If xmlName = True Then 'begin setup
            Dim saveFile As New SaveFileDialog
            saveFile.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*" 'set filter
            saveFile.FilterIndex = 2 'select xml

            'Create XmlWriterSettings
            Dim settings As XmlWriterSettings = New XmlWriterSettings()
            settings.Indent = True

            'Setup XmlWriter with defined xml name - [(xmlstring) & ".xml"] -
            Using writer As XmlWriter = XmlWriter.Create(xmlstring & ".xml", settings)
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
            MsgBox("The file '" & xmlstring & ".xml' has been created in bin/debug") 'prompt user
        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        'ensure that an inovice has been selected
        If dgvPackageInvoice.Rows.IndexOf(dgvPackageInvoice.CurrentRow) Then
            MsgBox("Please select a package invoice")
        Else 'remove the row from the list
            dgvPackageInvoice.Rows.Remove(dgvPackageInvoice.CurrentRow)
        End If
    End Sub

    Private Sub NumbersOnly(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPost.KeyPress, txtBook.KeyPress
        'prevents the input of non numerical characters
        Select Case Asc(e.KeyChar)
            Case 8, 48 To 57 : e.Handled = False : Case Else : e.Handled = True
        End Select
    End Sub

    Private Sub txtCost_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtCost.KeyPress
        'prevents the input of non numerical characters, includes the decimal point for currency
        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 57 : e.Handled = False : Case Else : e.Handled = True
        End Select
    End Sub

    Private Sub LettersOnly(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCust.KeyPress
        'Prevents input of numerical characters, allows capitals and space
        Select Case Asc(e.KeyChar)
            Case 8, 32, 65 To 90, 97 To 122 : e.Handled = False : Case Else : e.Handled = True
        End Select
    End Sub

    'The button colour changes when the mouse hovers over it, will revert to old colour after mouse leaves
    Private Sub HbtnRemove() Handles btnRemove.MouseHover
        btnRemove.BackColor = Color.Tomato
    End Sub
    Private Sub HbtnClear() Handles btnClear.MouseHover
        btnClear.BackColor = Color.Tomato
    End Sub
    Private Sub HbtnRecordopen() Handles btnRecordOpen.MouseHover
        btnRecordOpen.BackColor = Color.Gold
    End Sub
    Private Sub HbtnMenuopen() Handles btnMenuOpen.MouseHover
        btnMenuOpen.BackColor = Color.Gold
    End Sub
    Private Sub HbtnProcess() Handles btnProcess.MouseHover
        btnProcess.BackColor = Color.Chartreuse
    End Sub
    Private Sub Hbtnclient() Handles btnExport.MouseHover
        btnExport.BackColor = Color.Chartreuse
    End Sub
    Private Sub HbtnOpen() Handles btnOpen.MouseHover
        btnOpen.BackColor = Color.MediumPurple
    End Sub
    Private Sub HbtnCompile() Handles btnCompile.MouseHover
        btnCompile.BackColor = Color.MediumPurple
    End Sub
    Private Sub defaultcolour() Handles btnRemove.MouseLeave, btnClear.MouseLeave, btnRecordOpen.MouseLeave, btnMenuOpen.MouseLeave, btnProcess.MouseLeave, btnExport.MouseLeave, btnOpen.MouseLeave, btnCompile.MouseLeave
        'return all buttons back to original colour 
        btnRemove.BackColor = Color.MediumTurquoise
        btnClear.BackColor = Color.MediumTurquoise
        btnRecordOpen.BackColor = Color.MediumTurquoise
        btnMenuOpen.BackColor = Color.MediumTurquoise
        btnProcess.BackColor = Color.SpringGreen
        btnExport.BackColor = Color.SpringGreen
        btnOpen.BackColor = Color.MediumTurquoise
        btnCompile.BackColor = Color.MediumTurquoise
    End Sub
End Class
