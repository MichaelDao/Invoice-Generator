<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntro
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.btnGenerator = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Gold
        Me.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(16, 140)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(84, 42)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Logout"
        Me.ToolTip.SetToolTip(Me.btnLogout, "Logout of your account")
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.OrangeRed
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(106, 140)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 42)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.ToolTip.SetToolTip(Me.btnExit, "Exit the program")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnRecords
        '
        Me.btnRecords.BackColor = System.Drawing.Color.LimeGreen
        Me.btnRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecords.Location = New System.Drawing.Point(16, 92)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(84, 42)
        Me.btnRecords.TabIndex = 1
        Me.btnRecords.Text = "Invoice records"
        Me.ToolTip.SetToolTip(Me.btnRecords, "Load all the recorded client invoices")
        Me.btnRecords.UseVisualStyleBackColor = False
        '
        'btnGenerator
        '
        Me.btnGenerator.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnGenerator.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerator.Location = New System.Drawing.Point(61, 44)
        Me.btnGenerator.Name = "btnGenerator"
        Me.btnGenerator.Size = New System.Drawing.Size(84, 42)
        Me.btnGenerator.TabIndex = 0
        Me.btnGenerator.Text = "Invoice generator"
        Me.ToolTip.SetToolTip(Me.btnGenerator, "Open the invoice generator")
        Me.btnGenerator.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(4, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(198, 37)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Invoice generator"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.LimeGreen
        Me.btnInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.Location = New System.Drawing.Point(106, 92)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(84, 42)
        Me.btnInfo.TabIndex = 7
        Me.btnInfo.Text = "Info"
        Me.ToolTip.SetToolTip(Me.btnInfo, "Load the form information")
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'frmIntro
        '
        Me.AcceptButton = Me.btnGenerator
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnLogout
        Me.ClientSize = New System.Drawing.Size(208, 195)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRecords)
        Me.Controls.Add(Me.btnGenerator)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmIntro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnRecords As System.Windows.Forms.Button
    Friend WithEvents btnGenerator As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents btnInfo As System.Windows.Forms.Button
End Class
