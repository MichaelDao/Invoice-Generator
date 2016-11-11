<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecords
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.grpCost = New System.Windows.Forms.GroupBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.grpTotal = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.grpGST = New System.Windows.Forms.GroupBox()
        Me.lblGST = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnInvoices = New System.Windows.Forms.Button()
        Me.btnMenuOpen = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.lstClients = New System.Windows.Forms.ListBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpCost.SuspendLayout()
        Me.grpTotal.SuspendLayout()
        Me.grpGST.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(368, 192)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClear.Size = New System.Drawing.Size(81, 41)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear all"
        Me.ToolTip.SetToolTip(Me.btnClear, "Clear all client invoices")
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(281, 192)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnRemove.Size = New System.Drawing.Size(81, 41)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove"
        Me.ToolTip.SetToolTip(Me.btnRemove, "Remove the selected client invoice")
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'grpCost
        '
        Me.grpCost.Controls.Add(Me.lblSubtotal)
        Me.grpCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCost.Location = New System.Drawing.Point(629, 192)
        Me.grpCost.Name = "grpCost"
        Me.grpCost.Size = New System.Drawing.Size(108, 41)
        Me.grpCost.TabIndex = 71
        Me.grpCost.TabStop = False
        Me.grpCost.Text = "Subtotal"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BackColor = System.Drawing.Color.White
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(6, 15)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(102, 20)
        Me.lblSubtotal.TabIndex = 0
        Me.lblSubtotal.Text = "$0.00"
        '
        'grpTotal
        '
        Me.grpTotal.Controls.Add(Me.lblTotal)
        Me.grpTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTotal.Location = New System.Drawing.Point(851, 192)
        Me.grpTotal.Name = "grpTotal"
        Me.grpTotal.Size = New System.Drawing.Size(108, 41)
        Me.grpTotal.TabIndex = 73
        Me.grpTotal.TabStop = False
        Me.grpTotal.Text = "Total inc. GST"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(6, 15)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(102, 20)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "$0.00"
        '
        'grpGST
        '
        Me.grpGST.Controls.Add(Me.lblGST)
        Me.grpGST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGST.Location = New System.Drawing.Point(740, 192)
        Me.grpGST.Name = "grpGST"
        Me.grpGST.Size = New System.Drawing.Size(108, 41)
        Me.grpGST.TabIndex = 72
        Me.grpGST.TabStop = False
        Me.grpGST.Text = "GST (10%)"
        '
        'lblGST
        '
        Me.lblGST.BackColor = System.Drawing.Color.White
        Me.lblGST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGST.Location = New System.Drawing.Point(6, 15)
        Me.lblGST.Name = "lblGST"
        Me.lblGST.Size = New System.Drawing.Size(102, 20)
        Me.lblGST.TabIndex = 0
        Me.lblGST.Text = "$0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 16)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Client Invoice Records"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.SpringGreen
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(194, 192)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSearch.Size = New System.Drawing.Size(81, 41)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search records"
        Me.ToolTip.SetToolTip(Me.btnSearch, "Search the records list for a specific client invoice")
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnInvoices
        '
        Me.btnInvoices.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnInvoices.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvoices.Location = New System.Drawing.Point(455, 192)
        Me.btnInvoices.Name = "btnInvoices"
        Me.btnInvoices.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnInvoices.Size = New System.Drawing.Size(81, 41)
        Me.btnInvoices.TabIndex = 5
        Me.btnInvoices.Text = "Open Generator"
        Me.ToolTip.SetToolTip(Me.btnInvoices, "Open the generator form")
        Me.btnInvoices.UseVisualStyleBackColor = False
        '
        'btnMenuOpen
        '
        Me.btnMenuOpen.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnMenuOpen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMenuOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuOpen.Location = New System.Drawing.Point(542, 192)
        Me.btnMenuOpen.Name = "btnMenuOpen"
        Me.btnMenuOpen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnMenuOpen.Size = New System.Drawing.Size(81, 41)
        Me.btnMenuOpen.TabIndex = 6
        Me.btnMenuOpen.Text = "Close"
        Me.ToolTip.SetToolTip(Me.btnMenuOpen, "Close form and return to menu")
        Me.btnMenuOpen.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.SpringGreen
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(94, 192)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEdit.Size = New System.Drawing.Size(94, 41)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Load and open invoice"
        Me.ToolTip.SetToolTip(Me.btnEdit, "Select a client invoice then load it onto the generator")
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.SpringGreen
        Me.btnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(7, 192)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPay.Size = New System.Drawing.Size(81, 41)
        Me.btnPay.TabIndex = 0
        Me.btnPay.Text = "Change paid status"
        Me.ToolTip.SetToolTip(Me.btnPay, "Select a client invoice and change its paid status")
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'lstClients
        '
        Me.lstClients.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstClients.FormattingEnabled = True
        Me.lstClients.ItemHeight = 16
        Me.lstClients.Location = New System.Drawing.Point(7, 22)
        Me.lstClients.Name = "lstClients"
        Me.lstClients.Size = New System.Drawing.Size(952, 164)
        Me.lstClients.TabIndex = 69
        '
        'frmRecords
        '
        Me.AcceptButton = Me.btnEdit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CancelButton = Me.btnMenuOpen
        Me.ClientSize = New System.Drawing.Size(964, 238)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.grpCost)
        Me.Controls.Add(Me.grpTotal)
        Me.Controls.Add(Me.grpGST)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnInvoices)
        Me.Controls.Add(Me.btnMenuOpen)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.lstClients)
        Me.Name = "frmRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice Records"
        Me.grpCost.ResumeLayout(False)
        Me.grpTotal.ResumeLayout(False)
        Me.grpGST.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents grpCost As System.Windows.Forms.GroupBox
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents grpTotal As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents grpGST As System.Windows.Forms.GroupBox
    Friend WithEvents lblGST As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnInvoices As System.Windows.Forms.Button
    Friend WithEvents btnMenuOpen As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnPay As System.Windows.Forms.Button
    Friend WithEvents lstClients As System.Windows.Forms.ListBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
End Class
