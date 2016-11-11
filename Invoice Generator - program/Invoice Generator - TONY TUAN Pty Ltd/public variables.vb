'Invoice generator - by Michael Dao
'Module - Public_variables
'Module stores public variables that are used across forms
'created: 13/08/2016
'last edit: 22/08/2016
'known problems: nil

Module public_variables
    'public variables mainly used in form2 - Invoice generator
    Public Records As New List(Of Pinvoice) 'list array used for datagridview
    Public correct, changestat As Boolean 'validation
    Public bookNumb, postNumb As Integer
    Public costNumb, gstNumb, totalNumb, xmlName As String
    Public entry As New Pinvoice

    Structure Pinvoice 'creates a structure for the package invoice
        Dim Cust, Address, Cost, GST, Total, Book, Post As String
    End Structure

    'public variables mainly used in form3 - Invoice records
    Public Clients As Integer = 100 'array size
    Public pointer As Integer 'points at specific arrays
    Public signal, flag, newsave As Boolean 'used across forms as a process signal
    Public SInvNum, SwitchP, SPaid, SPayment, SDate, SClient, Scost, Sgst, STotal, SsaveName, sxmlName As String 'transfers variables across forms
    Public InvoiceNumb(Clients), paidSwitch(Clients), paid(Clients), PaymentType(Clients), myDate(Clients), ClientName(Clients), Subtotal(Clients), gstTotal(Clients), Total(Clients), saveName(Clients) As String 'Columns of the array
End Module

