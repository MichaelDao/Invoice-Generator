<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerator
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
        Me.dgvPackageInvoice = New System.Windows.Forms.DataGridView()
        Me.dgvBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCust = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvGST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpInvoiceTable = New System.Windows.Forms.GroupBox()
        Me.lblxmlTitle = New System.Windows.Forms.Label()
        Me.grpCost = New System.Windows.Forms.GroupBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnRecordOpen = New System.Windows.Forms.Button()
        Me.grpTotal = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnMenuOpen = New System.Windows.Forms.Button()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.lblxml = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCompile = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.grpGST = New System.Windows.Forms.GroupBox()
        Me.lblGST = New System.Windows.Forms.Label()
        Me.grpPackageInvoice = New System.Windows.Forms.GroupBox()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.btncleartext = New System.Windows.Forms.Button()
        Me.lblSign = New System.Windows.Forms.Label()
        Me.lblBook = New System.Windows.Forms.Label()
        Me.txtBook = New System.Windows.Forms.TextBox()
        Me.lblCust = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtCust = New System.Windows.Forms.TextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtPost = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblPost = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.xmlfiledialog = New System.Windows.Forms.OpenFileDialog()
        CType(Me.dgvPackageInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInvoiceTable.SuspendLayout()
        Me.grpCost.SuspendLayout()
        Me.grpTotal.SuspendLayout()
        Me.grpGST.SuspendLayout()
        Me.grpPackageInvoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPackageInvoice
        '
        Me.dgvPackageInvoice.AllowUserToAddRows = False
        Me.dgvPackageInvoice.AllowUserToDeleteRows = False
        Me.dgvPackageInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPackageInvoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvBook, Me.dgvCust, Me.dgvAddress, Me.dgvPost, Me.dgvCost, Me.dgvGST, Me.dgvTotal})
        Me.dgvPackageInvoice.Location = New System.Drawing.Point(12, 257)
        Me.dgvPackageInvoice.Name = "dgvPackageInvoice"
        Me.dgvPackageInvoice.ReadOnly = True
        Me.dgvPackageInvoice.RowHeadersVisible = False
        Me.dgvPackageInvoice.Size = New System.Drawing.Size(610, 149)
        Me.dgvPackageInvoice.TabIndex = 37
        '
        'dgvBook
        '
        Me.dgvBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgvBook.HeaderText = "Book ID"
        Me.dgvBook.MaxInputLength = 7
        Me.dgvBook.Name = "dgvBook"
        Me.dgvBook.ReadOnly = True
        Me.dgvBook.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBook.ToolTipText = "7 digits only"
        Me.dgvBook.Width = 71
        '
        'dgvCust
        '
        Me.dgvCust.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.dgvCust.HeaderText = "Customer"
        Me.dgvCust.MaxInputLength = 50
        Me.dgvCust.MinimumWidth = 110
        Me.dgvCust.Name = "dgvCust"
        Me.dgvCust.ReadOnly = True
        Me.dgvCust.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCust.ToolTipText = "Receiving customer name"
        Me.dgvCust.Width = 110
        '
        'dgvAddress
        '
        Me.dgvAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.dgvAddress.HeaderText = "Address"
        Me.dgvAddress.MaxInputLength = 100
        Me.dgvAddress.MinimumWidth = 115
        Me.dgvAddress.Name = "dgvAddress"
        Me.dgvAddress.ReadOnly = True
        Me.dgvAddress.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAddress.Width = 115
        '
        'dgvPost
        '
        Me.dgvPost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgvPost.HeaderText = "Post code"
        Me.dgvPost.MaxInputLength = 4
        Me.dgvPost.Name = "dgvPost"
        Me.dgvPost.ReadOnly = True
        Me.dgvPost.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPost.Width = 80
        '
        'dgvCost
        '
        Me.dgvCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgvCost.HeaderText = "Cost ($)"
        Me.dgvCost.MinimumWidth = 77
        Me.dgvCost.Name = "dgvCost"
        Me.dgvCost.ReadOnly = True
        Me.dgvCost.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCost.Width = 77
        '
        'dgvGST
        '
        Me.dgvGST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgvGST.HeaderText = "GST 10%"
        Me.dgvGST.MinimumWidth = 56
        Me.dgvGST.Name = "dgvGST"
        Me.dgvGST.ReadOnly = True
        Me.dgvGST.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGST.Width = 77
        '
        'dgvTotal
        '
        Me.dgvTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgvTotal.HeaderText = "Total ($)"
        Me.dgvTotal.MinimumWidth = 77
        Me.dgvTotal.Name = "dgvTotal"
        Me.dgvTotal.ReadOnly = True
        Me.dgvTotal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTotal.Width = 77
        '
        'grpInvoiceTable
        '
        Me.grpInvoiceTable.Controls.Add(Me.lblxmlTitle)
        Me.grpInvoiceTable.Controls.Add(Me.grpCost)
        Me.grpInvoiceTable.Controls.Add(Me.btnExport)
        Me.grpInvoiceTable.Controls.Add(Me.btnRecordOpen)
        Me.grpInvoiceTable.Controls.Add(Me.grpTotal)
        Me.grpInvoiceTable.Controls.Add(Me.btnMenuOpen)
        Me.grpInvoiceTable.Controls.Add(Me.btnProcess)
        Me.grpInvoiceTable.Controls.Add(Me.lblxml)
        Me.grpInvoiceTable.Controls.Add(Me.btnClear)
        Me.grpInvoiceTable.Controls.Add(Me.btnCompile)
        Me.grpInvoiceTable.Controls.Add(Me.btnRemove)
        Me.grpInvoiceTable.Controls.Add(Me.btnOpen)
        Me.grpInvoiceTable.Controls.Add(Me.grpGST)
        Me.grpInvoiceTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInvoiceTable.Location = New System.Drawing.Point(12, 140)
        Me.grpInvoiceTable.Name = "grpInvoiceTable"
        Me.grpInvoiceTable.Size = New System.Drawing.Size(610, 108)
        Me.grpInvoiceTable.TabIndex = 1
        Me.grpInvoiceTable.TabStop = False
        '
        'lblxmlTitle
        '
        Me.lblxmlTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblxmlTitle.Location = New System.Drawing.Point(407, 12)
        Me.lblxmlTitle.Name = "lblxmlTitle"
        Me.lblxmlTitle.Size = New System.Drawing.Size(197, 23)
        Me.lblxmlTitle.TabIndex = 76
        Me.lblxmlTitle.Text = "Currently saved as:"
        Me.lblxmlTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpCost
        '
        Me.grpCost.Controls.Add(Me.lblSubtotal)
        Me.grpCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCost.Location = New System.Drawing.Point(322, 61)
        Me.grpCost.Name = "grpCost"
        Me.grpCost.Size = New System.Drawing.Size(90, 41)
        Me.grpCost.TabIndex = 6
        Me.grpCost.TabStop = False
        Me.grpCost.Text = "Subtotal"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BackColor = System.Drawing.Color.White
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(6, 17)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(78, 20)
        Me.lblSubtotal.TabIndex = 0
        Me.lblSubtotal.Text = "$0.00"
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.SpringGreen
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(129, 14)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExport.Size = New System.Drawing.Size(116, 41)
        Me.btnExport.TabIndex = 1
        Me.btnExport.Text = "Record new client invoice"
        Me.ToolTip.SetToolTip(Me.btnExport, "Record a new client invoice, must have at least one package invoice")
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'btnRecordOpen
        '
        Me.btnRecordOpen.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnRecordOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecordOpen.Location = New System.Drawing.Point(164, 61)
        Me.btnRecordOpen.Name = "btnRecordOpen"
        Me.btnRecordOpen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnRecordOpen.Size = New System.Drawing.Size(73, 41)
        Me.btnRecordOpen.TabIndex = 6
        Me.btnRecordOpen.Text = "Open Records"
        Me.ToolTip.SetToolTip(Me.btnRecordOpen, "Open the records form")
        Me.btnRecordOpen.UseVisualStyleBackColor = False
        '
        'grpTotal
        '
        Me.grpTotal.Controls.Add(Me.lblTotal)
        Me.grpTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTotal.Location = New System.Drawing.Point(514, 61)
        Me.grpTotal.Name = "grpTotal"
        Me.grpTotal.Size = New System.Drawing.Size(90, 41)
        Me.grpTotal.TabIndex = 7
        Me.grpTotal.TabStop = False
        Me.grpTotal.Text = "Total inc. GST"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(6, 17)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(78, 20)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "$0.00"
        '
        'btnMenuOpen
        '
        Me.btnMenuOpen.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnMenuOpen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMenuOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuOpen.Location = New System.Drawing.Point(243, 61)
        Me.btnMenuOpen.Name = "btnMenuOpen"
        Me.btnMenuOpen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnMenuOpen.Size = New System.Drawing.Size(73, 41)
        Me.btnMenuOpen.TabIndex = 7
        Me.btnMenuOpen.Text = "Close "
        Me.ToolTip.SetToolTip(Me.btnMenuOpen, "Close form and return to menu")
        Me.btnMenuOpen.UseVisualStyleBackColor = False
        '
        'btnProcess
        '
        Me.btnProcess.BackColor = System.Drawing.Color.SpringGreen
        Me.btnProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.Location = New System.Drawing.Point(7, 14)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(116, 41)
        Me.btnProcess.TabIndex = 0
        Me.btnProcess.Text = "Create package invoice"
        Me.ToolTip.SetToolTip(Me.btnProcess, "Create a new package invoice")
        Me.btnProcess.UseVisualStyleBackColor = False
        '
        'lblxml
        '
        Me.lblxml.BackColor = System.Drawing.Color.White
        Me.lblxml.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblxml.Location = New System.Drawing.Point(407, 33)
        Me.lblxml.Name = "lblxml"
        Me.lblxml.Size = New System.Drawing.Size(197, 23)
        Me.lblxml.TabIndex = 66
        Me.lblxml.Text = "Unsaved"
        Me.lblxml.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(85, 61)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClear.Size = New System.Drawing.Size(73, 41)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear all "
        Me.ToolTip.SetToolTip(Me.btnClear, "Clear all the package invoices")
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCompile
        '
        Me.btnCompile.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnCompile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompile.Location = New System.Drawing.Point(330, 14)
        Me.btnCompile.Name = "btnCompile"
        Me.btnCompile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCompile.Size = New System.Drawing.Size(73, 41)
        Me.btnCompile.TabIndex = 3
        Me.btnCompile.Text = "Save as xml file"
        Me.ToolTip.SetToolTip(Me.btnCompile, "Save the current package invoices as an xml file")
        Me.btnCompile.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.Location = New System.Drawing.Point(6, 61)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnRemove.Size = New System.Drawing.Size(73, 41)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Remove"
        Me.ToolTip.SetToolTip(Me.btnRemove, "Remove a selected package invoice")
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnOpen
        '
        Me.btnOpen.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpen.Location = New System.Drawing.Point(251, 14)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnOpen.Size = New System.Drawing.Size(73, 41)
        Me.btnOpen.TabIndex = 2
        Me.btnOpen.Text = "Load xml file"
        Me.ToolTip.SetToolTip(Me.btnOpen, "Load a previously generated client invoice")
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'grpGST
        '
        Me.grpGST.Controls.Add(Me.lblGST)
        Me.grpGST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGST.Location = New System.Drawing.Point(418, 61)
        Me.grpGST.Name = "grpGST"
        Me.grpGST.Size = New System.Drawing.Size(90, 41)
        Me.grpGST.TabIndex = 7
        Me.grpGST.TabStop = False
        Me.grpGST.Text = "GST (10%)"
        '
        'lblGST
        '
        Me.lblGST.BackColor = System.Drawing.Color.White
        Me.lblGST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGST.Location = New System.Drawing.Point(6, 17)
        Me.lblGST.Name = "lblGST"
        Me.lblGST.Size = New System.Drawing.Size(78, 20)
        Me.lblGST.TabIndex = 0
        Me.lblGST.Text = "$0.00"
        '
        'grpPackageInvoice
        '
        Me.grpPackageInvoice.Controls.Add(Me.btnRandom)
        Me.grpPackageInvoice.Controls.Add(Me.btncleartext)
        Me.grpPackageInvoice.Controls.Add(Me.lblSign)
        Me.grpPackageInvoice.Controls.Add(Me.lblBook)
        Me.grpPackageInvoice.Controls.Add(Me.txtBook)
        Me.grpPackageInvoice.Controls.Add(Me.lblCust)
        Me.grpPackageInvoice.Controls.Add(Me.txtCost)
        Me.grpPackageInvoice.Controls.Add(Me.txtCust)
        Me.grpPackageInvoice.Controls.Add(Me.lblCost)
        Me.grpPackageInvoice.Controls.Add(Me.lblAddress)
        Me.grpPackageInvoice.Controls.Add(Me.txtPost)
        Me.grpPackageInvoice.Controls.Add(Me.txtAddress)
        Me.grpPackageInvoice.Controls.Add(Me.lblPost)
        Me.grpPackageInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPackageInvoice.Location = New System.Drawing.Point(12, 12)
        Me.grpPackageInvoice.Name = "grpPackageInvoice"
        Me.grpPackageInvoice.Size = New System.Drawing.Size(610, 122)
        Me.grpPackageInvoice.TabIndex = 0
        Me.grpPackageInvoice.TabStop = False
        Me.grpPackageInvoice.Text = "Package Invoice"
        '
        'btnRandom
        '
        Me.btnRandom.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnRandom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRandom.ForeColor = System.Drawing.Color.Black
        Me.btnRandom.Location = New System.Drawing.Point(40, 34)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnRandom.Size = New System.Drawing.Size(76, 24)
        Me.btnRandom.TabIndex = 2
        Me.btnRandom.Text = "randomize"
        Me.ToolTip.SetToolTip(Me.btnRandom, "Randomly generate a book number")
        Me.btnRandom.UseVisualStyleBackColor = False
        '
        'btncleartext
        '
        Me.btncleartext.BackColor = System.Drawing.SystemColors.Control
        Me.btncleartext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncleartext.Location = New System.Drawing.Point(555, 89)
        Me.btncleartext.Name = "btncleartext"
        Me.btncleartext.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btncleartext.Size = New System.Drawing.Size(49, 24)
        Me.btncleartext.TabIndex = 8
        Me.btncleartext.Text = "Clear"
        Me.ToolTip.SetToolTip(Me.btncleartext, "Clear textboxes")
        Me.btncleartext.UseVisualStyleBackColor = False
        '
        'lblSign
        '
        Me.lblSign.AutoSize = True
        Me.lblSign.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSign.Location = New System.Drawing.Point(350, 91)
        Me.lblSign.Name = "lblSign"
        Me.lblSign.Size = New System.Drawing.Size(16, 18)
        Me.lblSign.TabIndex = 67
        Me.lblSign.Text = "$"
        '
        'lblBook
        '
        Me.lblBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBook.Location = New System.Drawing.Point(6, 14)
        Me.lblBook.Name = "lblBook"
        Me.lblBook.Size = New System.Drawing.Size(110, 23)
        Me.lblBook.TabIndex = 1
        Me.lblBook.Text = "Book number:"
        Me.lblBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBook
        '
        Me.txtBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBook.Location = New System.Drawing.Point(122, 23)
        Me.txtBook.MaxLength = 7
        Me.txtBook.Name = "txtBook"
        Me.txtBook.Size = New System.Drawing.Size(100, 24)
        Me.txtBook.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.txtBook, "The book number must be 7 digits")
        '
        'lblCust
        '
        Me.lblCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCust.Location = New System.Drawing.Point(242, 25)
        Me.lblCust.Name = "lblCust"
        Me.lblCust.Size = New System.Drawing.Size(124, 23)
        Me.lblCust.TabIndex = 5
        Me.lblCust.Text = "Customer name:"
        Me.lblCust.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCost
        '
        Me.txtCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(372, 86)
        Me.txtCost.MaxLength = 7
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(86, 24)
        Me.txtCost.TabIndex = 7
        Me.txtCost.Text = "0.00"
        Me.ToolTip.SetToolTip(Me.txtCost, "Shipping cost of the package")
        '
        'txtCust
        '
        Me.txtCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCust.Location = New System.Drawing.Point(372, 23)
        Me.txtCust.MaxLength = 30
        Me.txtCust.Name = "txtCust"
        Me.txtCust.Size = New System.Drawing.Size(232, 24)
        Me.txtCust.TabIndex = 4
        Me.ToolTip.SetToolTip(Me.txtCust, "Name of the customer who is receiving the package")
        '
        'lblCost
        '
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(228, 88)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(125, 23)
        Me.lblCost.TabIndex = 4
        Me.lblCost.Text = "Shipping cost:"
        Me.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAddress
        '
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(38, 57)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(78, 23)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address:"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPost
        '
        Me.txtPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPost.Location = New System.Drawing.Point(122, 87)
        Me.txtPost.MaxLength = 4
        Me.txtPost.Name = "txtPost"
        Me.txtPost.Size = New System.Drawing.Size(100, 24)
        Me.txtPost.TabIndex = 6
        Me.ToolTip.SetToolTip(Me.txtPost, "Post code of the address")
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(122, 55)
        Me.txtAddress.MaxLength = 40
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(482, 24)
        Me.txtAddress.TabIndex = 5
        Me.ToolTip.SetToolTip(Me.txtAddress, "Address the package is shipped to")
        '
        'lblPost
        '
        Me.lblPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPost.Location = New System.Drawing.Point(27, 89)
        Me.lblPost.Name = "lblPost"
        Me.lblPost.Size = New System.Drawing.Size(89, 23)
        Me.lblPost.TabIndex = 3
        Me.lblPost.Text = "Post code:"
        Me.lblPost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'xmlfiledialog
        '
        Me.xmlfiledialog.FileName = "xmlfiledialog"
        '
        'frmGenerator
        '
        Me.AcceptButton = Me.btnProcess
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.CancelButton = Me.btnMenuOpen
        Me.ClientSize = New System.Drawing.Size(632, 415)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvPackageInvoice)
        Me.Controls.Add(Me.grpInvoiceTable)
        Me.Controls.Add(Me.grpPackageInvoice)
        Me.Name = "frmGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice Generator"
        CType(Me.dgvPackageInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInvoiceTable.ResumeLayout(False)
        Me.grpCost.ResumeLayout(False)
        Me.grpTotal.ResumeLayout(False)
        Me.grpGST.ResumeLayout(False)
        Me.grpPackageInvoice.ResumeLayout(False)
        Me.grpPackageInvoice.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvPackageInvoice As System.Windows.Forms.DataGridView
    Friend WithEvents dgvBook As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvCust As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvPost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvGST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpInvoiceTable As System.Windows.Forms.GroupBox
    Friend WithEvents lblxmlTitle As System.Windows.Forms.Label
    Friend WithEvents grpCost As System.Windows.Forms.GroupBox
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnRecordOpen As System.Windows.Forms.Button
    Friend WithEvents grpTotal As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnMenuOpen As System.Windows.Forms.Button
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents lblxml As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCompile As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents grpGST As System.Windows.Forms.GroupBox
    Friend WithEvents lblGST As System.Windows.Forms.Label
    Friend WithEvents grpPackageInvoice As System.Windows.Forms.GroupBox
    Friend WithEvents btnRandom As System.Windows.Forms.Button
    Friend WithEvents btncleartext As System.Windows.Forms.Button
    Friend WithEvents lblSign As System.Windows.Forms.Label
    Friend WithEvents lblBook As System.Windows.Forms.Label
    Friend WithEvents txtBook As System.Windows.Forms.TextBox
    Friend WithEvents lblCust As System.Windows.Forms.Label
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents txtCust As System.Windows.Forms.TextBox
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtPost As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblPost As System.Windows.Forms.Label
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents xmlfiledialog As System.Windows.Forms.OpenFileDialog
End Class
