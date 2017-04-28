<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEdit
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDeductType = New System.Windows.Forms.TextBox()
        Me.txtAmt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Deduction Type :"
        '
        'txtDeductType
        '
        Me.txtDeductType.Location = New System.Drawing.Point(100, 32)
        Me.txtDeductType.Name = "txtDeductType"
        Me.txtDeductType.Size = New System.Drawing.Size(183, 20)
        Me.txtDeductType.TabIndex = 1
        '
        'txtAmt
        '
        Me.txtAmt.Location = New System.Drawing.Point(100, 58)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Size = New System.Drawing.Size(183, 20)
        Me.txtAmt.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Deduction Type :"
        '
        'cmdDone
        '
        Me.cmdDone.Location = New System.Drawing.Point(127, 90)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(75, 23)
        Me.cmdDone.TabIndex = 4
        Me.cmdDone.Text = "Done"
        Me.cmdDone.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(208, 90)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 5
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'frmAddEdit
        '
        Me.AcceptButton = Me.cmdDone
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 125)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDone)
        Me.Controls.Add(Me.txtAmt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDeductType)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAddEdit"
        Me.Text = "frmAddEdit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDeductType As System.Windows.Forms.TextBox
    Friend WithEvents txtAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdDone As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
End Class
