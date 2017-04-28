<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAEDivHead

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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtDiv = New System.Windows.Forms.TextBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtOIC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtEmpNo = New System.Windows.Forms.TextBox()
        Me.txtCTRNo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Division :"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(104, 12)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(88, 24)
        Me.txtCode.TabIndex = 2
        '
        'txtDiv
        '
        Me.txtDiv.Location = New System.Drawing.Point(104, 48)
        Me.txtDiv.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtDiv.Name = "txtDiv"
        Me.txtDiv.Size = New System.Drawing.Size(263, 24)
        Me.txtDiv.TabIndex = 3
        '
        'cmdSave
        '
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Location = New System.Drawing.Point(203, 114)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(77, 27)
        Me.cmdSave.TabIndex = 4
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Location = New System.Drawing.Point(290, 114)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(77, 27)
        Me.cmdCancel.TabIndex = 5
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'txtOIC
        '
        Me.txtOIC.Location = New System.Drawing.Point(104, 80)
        Me.txtOIC.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtOIC.Name = "txtOIC"
        Me.txtOIC.Size = New System.Drawing.Size(231, 24)
        Me.txtOIC.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 80)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "OIC :"
        '
        'cmdSearch
        '
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearch.Location = New System.Drawing.Point(329, 80)
        Me.cmdSearch.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(36, 26)
        Me.cmdSearch.TabIndex = 8
        Me.cmdSearch.Text = "..."
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Location = New System.Drawing.Point(25, 117)
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(69, 24)
        Me.txtEmpNo.TabIndex = 9
        '
        'txtCTRNo
        '
        Me.txtCTRNo.Location = New System.Drawing.Point(104, 117)
        Me.txtCTRNo.Name = "txtCTRNo"
        Me.txtCTRNo.Size = New System.Drawing.Size(63, 24)
        Me.txtCTRNo.TabIndex = 10
        '
        'frmAEDivHead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(381, 148)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCTRNo)
        Me.Controls.Add(Me.txtEmpNo)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.txtOIC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtDiv)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmAEDivHead"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Division Setting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents txtDiv As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOIC As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents txtEmpNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCTRNo As System.Windows.Forms.TextBox
End Class
