'Invoice generator - by Michael Dao
'Form3 - Invoice records
'The Client invoice from form2 will be input and sorted onto this new database, can produce xml document, can edit/save database, display total value of client invoices.
'created: 27/06/2016
'last edit: 26/08/2016
'known problems: nil

Imports System.IO 'import for list save function

Public Class frmRecords
    'declare global variables
    Dim subT, gstT, allT As Double
    Dim rowselect As Integer 'determine index of selected item

    Private Sub frmRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listloader() 'call load subroutine
    End Sub

    Private Sub btnInvoices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvoices.Click
        frmGenerator.Show() : Me.Hide() : frmSearch.Hide() : frmChangeStatus.Close() 'close current form and open Form2
        listSaver() 'save listbox
    End Sub

    Private Sub btnMenuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuOpen.Click
        frmIntro.Show() : Me.Hide() : frmSearch.Hide() : frmChangeStatus.Close() 'close current form and open Form1
        listSaver() 'save listbox
    End Sub

    Public Sub listloader()
        'declare local variables for loading procedure
        Dim listRead As StreamReader = File.OpenText("ClientList.txt")
        Dim arrayRead As StreamReader = File.OpenText("Arrays.txt")
        Dim i As Integer = 0
        Dim reader As String = ""
        Dim splits(9) As String 'splits the arrays

        'writes the saved string onto the listbox
        Do While listRead.Peek <> -1
            lstClients.Items.Add(listRead.ReadLine())
        Loop
        listRead.Close()

        'split all items up seperately with commas during load procedure
        Do While i < lstClients.Items.Count
            reader = arrayRead.ReadLine()
            splits = reader.Split(",")

            'split each array by "," 
            InvoiceNumb(i) = splits(0) : ClientName(i) = splits(1)
            paidSwitch(i) = splits(2) : paid(i) = splits(3)
            PaymentType(i) = splits(4) : myDate(i) = splits(5)
            Subtotal(i) = splits(6) : gstTotal(i) = splits(7)
            Total(i) = splits(8) : saveName(i) = splits(9)

            'move pointer down
            pointer = pointer + 1
            i = i + 1
        Loop
        arrayRead.Close() 'close acess
        selectionSort() 'call sort
    End Sub

    Public Sub listSaver()
        'declare local variables
        Dim listWrite As StreamWriter = File.CreateText("ClientList.txt") 'listbox
        Dim arrayWrite As StreamWriter = File.CreateText("Arrays.txt") 'array
        Dim save As String = "" 'writes array into textfile
        Dim i As Integer = 0

        'start writing lines onto "ClientList.txt"
        For Each Name As Object In lstClients.Items
            listWrite.WriteLine(Name)
        Next
        listWrite.Close()

        'start writing arrays into "Arrays.txt" and split each array with the comma ","
        Do While i < lstClients.Items.Count
            save = InvoiceNumb(i) & "," & ClientName(i) & "," & paidSwitch(i) & "," & paid(i) & "," & PaymentType(i) & "," & myDate(i) & "," & Subtotal(i) & "," & gstTotal(i) & "," & Total(i) & "," & saveName(i)
            arrayWrite.WriteLine(save)
            i = i + 1 'move to next array
        Loop
        arrayWrite.Close()
    End Sub

    Public Sub ClientInvoice()
        'add entry only if 'signal' has been activated by previous form
        If signal = True Then
            pointer = 0
            Dim overwrite As Boolean = False
            'linear search until array found
            Do Until pointer = lstClients.Items.Count
                If SsaveName = saveName(pointer) Then 'overwrite when array found
                    insert() 'call subroutine
                    overwrite = True
                    MsgBox(SsaveName & " has been overwritten", , "Invoice records")
                End If
                pointer = pointer + 1
            Loop

            If overwrite = False Then 'if no need to overwrite, move to end of list and add array
                pointer = lstClients.Items.Count
                insert() 'call subroutine
                lstClients.Items.Add("|Invoice ID|: " & InvoiceNumb(pointer) & "  |Status|: " & paid(pointer) & "  |Payment|: " & PaymentType(pointer) & "  |Date|: " & myDate(pointer) & "  |Client|: " & ClientName(pointer) & "  |Subtotal|: $" & Subtotal(pointer) & "  |GST|: $" & gstTotal(pointer) & "  |Total|: $" & Total(pointer))
                pointer = pointer + 1
            End If
            signal = False ' turn off the signal
            selectionSort() 'call sort
        End If
    End Sub

    Private Sub insert()
        'Transfer data from form2 over to the variables in this form 
        InvoiceNumb(pointer) = SInvNum
        ClientName(pointer) = SClient
        paid(pointer) = SPaid : paidSwitch(pointer) = SwitchP
        PaymentType(pointer) = SPayment
        myDate(pointer) = SDate
        Subtotal(pointer) = Format(Val(Scost), "0.00")
        gstTotal(pointer) = Format(Val(Sgst), "0.00")
        Total(pointer) = Format(Val(STotal), "0.00")
        saveName(pointer) = SsaveName
    End Sub

    Private Sub Rewrite()
        'This subroutine will erase the list and rewrite the arrays back on
        Dim count As Integer = lstClients.Items.Count 'hold count value before it is erased
        lstClients.Items.Clear() : pointer = 0 : subT = 0 : gstT = 0 : allT = 0 'clear list, reset pointers
        lblSubtotal.Text = "$0.00" : lblGST.Text = "$0.00" : lblTotal.Text = "$0.00" 'reset labels

        'loop to end of list, rewriting each array
        Do Until pointer = count
            lstClients.Items.Add("|Invoice ID|: " & InvoiceNumb(pointer) & "  |Status|: " & paid(pointer) & "  |Payment|: " & PaymentType(pointer) & "  |Date|: " & myDate(pointer) & "  |Client|: " & ClientName(pointer) & "  |Subtotal|: $" & Subtotal(pointer) & "  |GST|: $" & gstTotal(pointer) & "  |Total|: $" & Total(pointer))

            'add on the shipping costs
            subT += Subtotal(pointer) : gstT += gstTotal(pointer) : allT += Total(pointer)
            pointer = pointer + 1 'move to next array
        Loop

        'display the total sums in the labels
        lblSubtotal.Text = Format(Val(subT), "Currency")
        lblGST.Text = Format(Val(gstT), "Currency")
        lblTotal.Text = Format(Val(allT), "Currency")
    End Sub

    Private Sub selectionSort()
        'declare local variables
        Dim srtInvNum, srtStatus, srtPaid, srtPayment, srtDate, srtName, srtCost, srtGST, srtTotal, srtSaveName As String 'holds temporary values
        Dim small, Point1, Point2 As Integer 'pointers used for selection sort

        'selection sort 
        For Point1 = 0 To lstClients.Items.Count - 1
            small = Point1 'small will hold the smallest vlue
            'point2 will move to the next array
            For Point2 = Point1 + 1 To lstClients.Items.Count - 1
                If paidSwitch(Point2) > paidSwitch(small) Then 'if point2 value is larger than small value (1 > 0)
                    small = Point2 'assign the value of point2 to small
                End If
            Next

            'temporary variable holds the strings of the small array
            srtInvNum = InvoiceNumb(small)
            srtName = ClientName(small)
            srtStatus = paidSwitch(small) : srtPaid = paid(small)
            srtPayment = PaymentType(small)
            srtDate = myDate(small)
            srtCost = Subtotal(small)
            srtGST = gstTotal(small)
            srtTotal = Total(small)
            srtSaveName = saveName(small)

            'move the point1 array down to the small array position
            InvoiceNumb(small) = InvoiceNumb(Point1)
            ClientName(small) = ClientName(Point1)
            paidSwitch(small) = paidSwitch(Point1) : paid(small) = paid(Point1)
            PaymentType(small) = PaymentType(Point1)
            myDate(small) = myDate(Point1)
            Subtotal(small) = Subtotal(Point1)
            gstTotal(small) = gstTotal(Point1)
            Total(small) = Total(Point1)
            saveName(small) = saveName(Point1)

            'finish the swap by assigning the temporary string to Point1 array
            InvoiceNumb(Point1) = srtInvNum
            ClientName(Point1) = srtName
            paidSwitch(Point1) = srtStatus : paid(Point1) = srtPaid
            PaymentType(Point1) = srtPayment
            myDate(Point1) = srtDate
            Subtotal(Point1) = srtCost
            gstTotal(Point1) = srtGST
            Total(Point1) = srtTotal
            saveName(Point1) = srtSaveName
        Next
        Rewrite() 'rewrite arrays onto listbox 
    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        'prompt user to pick an item
        If lstClients.SelectedItem = "" Then
            MsgBox("Please select a client invoice")
        Else
            'determine index of the selected item
            rowselect = lstClients.SelectedIndex
            Select Case paidSwitch(rowselect)
                Case Is = 0 'if unpaid
                    My.Forms.frmChangeStatus.Show() 'open form
                Case Is = 1 'if paid
                    paidSwitch(rowselect) = 0
                    paid(rowselect) = "Unpaid"
                    PaymentType(rowselect) = "-"
                    selectionSort() 'call sort
            End Select
        End If
    End Sub

    Public Sub paymentchange()
        'changes the values of the selected array
        PaymentType(rowselect) = My.Forms.frmChangeStatus.cmbPayment.Text
        paidSwitch(rowselect) = 1
        paid(rowselect) = "Paid"
        selectionSort() 'call
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'if nothing selected, prompt user
        sxmlName = ""
        If lstClients.SelectedItem = "" Then
            MsgBox("Please select a client invoice")
        Else
            'find row count of list to determing array position
            Dim rowCount As Integer = lstClients.SelectedIndex
            sxmlName = saveName(rowCount)
            flag = True
            
            'open form2 and initiate loadxml subroutine
            Me.Hide() : frmGenerator.Show() : frmSearch.Hide() : frmChangeStatus.Close()
            My.Forms.frmGenerator.Loadxml()
            MsgBox(sxmlName & " has been loaded", , "Invoice records")
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        frmSearch.Show() 'open the search form
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        'remove selected item in listbox
        For i As Integer = 0 To lstClients.SelectedIndices.Count - 1
            lstClients.Items.RemoveAt(lstClients.SelectedIndex)
        Next
        Rewrite() 'call
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'prompt user before clearing all arrays
        If MsgBox("Are you sure you want to clear all invoices?", MsgBoxStyle.YesNo, "Invoice Records") = vbYes Then
            Dim i As Integer = 0
            lstClients.Items.Clear() 'clear listbox
            lblGST.Text = "$0.00" : lblSubtotal.Text = "$0.00" : lblTotal.Text = "$0.00"
            'erase all records until a blank spot is reached
            Do Until paidSwitch(i) = ""
                InvoiceNumb(i) = "" : ClientName(i) = "" : paidSwitch(i) = "" : paid(i) = "" : PaymentType(i) = "" : myDate(i) = "" : Subtotal(i) = "" : gstTotal(i) = "" : Total(i) = "" : saveName(i) = ""
                i = i + 1
            Loop
            pointer = 0 'reset pointer for new entries
        End If
    End Sub

    'The button colour changes when the mouse hovers over it, will revert to old colour after mouse leaves
    Private Sub HbtnRemove() Handles btnRemove.MouseHover
        btnRemove.BackColor = Color.Tomato
    End Sub
    Private Sub HbtnClear() Handles btnClear.MouseHover
        btnClear.BackColor = Color.Tomato
    End Sub
    Private Sub HbtnPay() Handles btnPay.MouseHover
        btnPay.BackColor = Color.Chartreuse
    End Sub
    Private Sub HbtnEdit() Handles btnEdit.MouseHover
        btnEdit.BackColor = Color.Chartreuse
    End Sub
    Private Sub HbtnSearch() Handles btnSearch.MouseHover
        btnSearch.BackColor = Color.Chartreuse
    End Sub
    Private Sub HbtnInvoices() Handles btnInvoices.MouseHover
        btnInvoices.BackColor = Color.Gold
    End Sub
    Private Sub HbtnMenuopen() Handles btnMenuOpen.MouseHover
        btnMenuOpen.BackColor = Color.Gold
    End Sub
    Private Sub defaultcolour() Handles btnRemove.MouseLeave, btnClear.MouseLeave, btnSearch.MouseLeave, btnEdit.MouseLeave, btnPay.MouseLeave, btnInvoices.MouseLeave, btnMenuOpen.MouseLeave
        'return all buttons back to original colour 
        btnRemove.BackColor = Color.MediumTurquoise
        btnClear.BackColor = Color.MediumTurquoise
        btnPay.BackColor = Color.SpringGreen
        btnEdit.BackColor = Color.SpringGreen
        btnSearch.BackColor = Color.SpringGreen
        btnInvoices.BackColor = Color.MediumTurquoise
        btnMenuOpen.BackColor = Color.MediumTurquoise
    End Sub
End Class