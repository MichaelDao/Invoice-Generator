<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.grpClient = New System.Windows.Forms.GroupBox()
        Me.txtClient = New System.Windows.Forms.TextBox()
        Me.grpDate = New System.Windows.Forms.GroupBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.grpPayment = New System.Windows.Forms.GroupBox()
        Me.cmbPayment = New System.Windows.Forms.ComboBox()
        Me.grpStatus = New System.Windows.Forms.GroupBox()
        Me.rdbNo = New System.Windows.Forms.RadioButton()
        Me.rdbYes = New System.Windows.Forms.RadioButton()
        Me.grpInvoice = New System.Windows.Forms.GroupBox()
        Me.txtInvNumber = New System.Windows.Forms.TextBox()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lstSearch = New System.Windows.Forms.ListBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpClient.SuspendLayout()
        Me.grpDate.SuspendLayout()
        Me.grpPayment.SuspendLayout()
        Me.grpStatus.SuspendLayout()
        Me.grpInvoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Chartreuse
        resources.ApplyResources(Me.btnEdit, "btnEdit")
        Me.btnEdit.Name = "btnEdit"
        Me.ToolTip.SetToolTip(Me.btnEdit, resources.GetString("btnEdit.ToolTip"))
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'grpClient
        '
        Me.grpClient.Controls.Add(Me.txtClient)
        resources.ApplyResources(Me.grpClient, "grpClient")
        Me.grpClient.Name = "grpClient"
        Me.grpClient.TabStop = False
        '
        'txtClient
        '
        resources.ApplyResources(Me.txtClient, "txtClient")
        Me.txtClient.Name = "txtClient"
        '
        'grpDate
        '
        Me.grpDate.Controls.Add(Me.dtpDate)
        resources.ApplyResources(Me.grpDate, "grpDate")
        Me.grpDate.Name = "grpDate"
        Me.grpDate.TabStop = False
        '
        'dtpDate
        '
        resources.ApplyResources(Me.dtpDate, "dtpDate")
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Name = "dtpDate"
        '
        'grpPayment
        '
        Me.grpPayment.Controls.Add(Me.cmbPayment)
        resources.ApplyResources(Me.grpPayment, "grpPayment")
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.TabStop = False
        '
        'cmbPayment
        '
        Me.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cmbPayment, "cmbPayment")
        Me.cmbPayment.FormattingEnabled = True
        Me.cmbPayment.Items.AddRange(New Object() {resources.GetString("cmbPayment.Items"), resources.GetString("cmbPayment.Items1"), resources.GetString("cmbPayment.Items2")})
        Me.cmbPayment.Name = "cmbPayment"
        '
        'grpStatus
        '
        Me.grpStatus.Controls.Add(Me.rdbNo)
        Me.grpStatus.Controls.Add(Me.rdbYes)
        resources.ApplyResources(Me.grpStatus, "grpStatus")
        Me.grpStatus.Name = "grpStatus"
        Me.grpStatus.TabStop = False
        '
        'rdbNo
        '
        resources.ApplyResources(Me.rdbNo, "rdbNo")
        Me.rdbNo.Checked = True
        Me.rdbNo.Name = "rdbNo"
        Me.rdbNo.TabStop = True
        Me.rdbNo.UseVisualStyleBackColor = True
        '
        'rdbYes
        '
        resources.ApplyResources(Me.rdbYes, "rdbYes")
        Me.rdbYes.Name = "rdbYes"
        Me.rdbYes.TabStop = True
        Me.rdbYes.UseVisualStyleBackColor = True
        '
        'grpInvoice
        '
        Me.grpInvoice.Controls.Add(Me.txtInvNumber)
        resources.ApplyResources(Me.grpInvoice, "grpInvoice")
        Me.grpInvoice.Name = "grpInvoice"
        Me.grpInvoice.TabStop = False
        '
        'txtInvNumber
        '
        resources.ApplyResources(Me.txtInvNumber, "txtInvNumber")
        Me.txtInvNumber.Name = "txtInvNumber"
        '
        'cmbSearch
        '
        Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cmbSearch, "cmbSearch")
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {resources.GetString("cmbSearch.Items"), resources.GetString("cmbSearch.Items1"), resources.GetString("cmbSearch.Items2"), resources.GetString("cmbSearch.Items3"), resources.GetString("cmbSearch.Items4")})
        Me.cmbSearch.Name = "cmbSearch"
        Me.ToolTip.SetToolTip(Me.cmbSearch, resources.GetString("cmbSearch.ToolTip"))
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Chartreuse
        resources.ApplyResources(Me.btnSearch, "btnSearch")
        Me.btnSearch.Name = "btnSearch"
        Me.ToolTip.SetToolTip(Me.btnSearch, resources.GetString("btnSearch.ToolTip"))
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gold
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.btnClose, "btnClose")
        Me.btnClose.Name = "btnClose"
        Me.ToolTip.SetToolTip(Me.btnClose, resources.GetString("btnClose.ToolTip"))
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lstSearch
        '
        resources.ApplyResources(Me.lstSearch, "lstSearch")
        Me.lstSearch.FormattingEnabled = True
        Me.lstSearch.Name = "lstSearch"
        '
        'frmSearch
        '
        Me.AcceptButton = Me.btnSearch
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CancelButton = Me.btnClose
        Me.ControlBox = False
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.grpClient)
        Me.Controls.Add(Me.grpDate)
        Me.Controls.Add(Me.grpPayment)
        Me.Controls.Add(Me.grpStatus)
        Me.Controls.Add(Me.grpInvoice)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lstSearch)
        Me.Name = "frmSearch"
        Me.grpClient.ResumeLayout(False)
        Me.grpClient.PerformLayout()
        Me.grpDate.ResumeLayout(False)
        Me.grpPayment.ResumeLayout(False)
        Me.grpStatus.ResumeLayout(False)
        Me.grpStatus.PerformLayout()
        Me.grpInvoice.ResumeLayout(False)
        Me.grpInvoice.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents grpClient As System.Windows.Forms.GroupBox
    Friend WithEvents txtClient As System.Windows.Forms.TextBox
    Friend WithEvents grpDate As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpPayment As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPayment As System.Windows.Forms.ComboBox
    Friend WithEvents grpStatus As System.Windows.Forms.GroupBox
    Friend WithEvents rdbNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdbYes As System.Windows.Forms.RadioButton
    Friend WithEvents grpInvoice As System.Windows.Forms.GroupBox
    Friend WithEvents txtInvNumber As System.Windows.Forms.TextBox
    Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lstSearch As System.Windows.Forms.ListBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
End Class
