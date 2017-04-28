<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAEOtherInfo
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtOptDesc = New System.Windows.Forms.TextBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.txtEmpNo = New System.Windows.Forms.TextBox()
        Me.txtCTRL = New System.Windows.Forms.TextBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtOption = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtOptDesc)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(453, 176)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtOptDesc
        '
        Me.txtOptDesc.Location = New System.Drawing.Point(23, 129)
        Me.txtOptDesc.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtOptDesc.Name = "txtOptDesc"
        Me.txtOptDesc.Size = New System.Drawing.Size(405, 24)
        Me.txtOptDesc.TabIndex = 3
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(23, 90)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(401, 22)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "MEMBERSHIP IN ASSOCIATION/ORGANIZATION"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(23, 58)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(405, 22)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "NON-ACADEMIC DISTINCTIONS / RECOGNITION"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(23, 26)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(242, 22)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "SPECIAL SKILLS / HOBBIES"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Location = New System.Drawing.Point(15, 208)
        Me.txtEmpNo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(55, 24)
        Me.txtEmpNo.TabIndex = 1
        Me.txtEmpNo.Visible = False
        '
        'txtCTRL
        '
        Me.txtCTRL.Location = New System.Drawing.Point(80, 208)
        Me.txtCTRL.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtCTRL.Name = "txtCTRL"
        Me.txtCTRL.Size = New System.Drawing.Size(43, 24)
        Me.txtCTRL.TabIndex = 2
        Me.txtCTRL.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Location = New System.Drawing.Point(186, 201)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(142, 36)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Location = New System.Drawing.Point(338, 202)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(135, 36)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'txtOption
        '
        Me.txtOption.Location = New System.Drawing.Point(32, 255)
        Me.txtOption.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtOption.Name = "txtOption"
        Me.txtOption.Size = New System.Drawing.Size(139, 24)
        Me.txtOption.TabIndex = 5
        '
        'frmAEOtherInfo
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(493, 245)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtOption)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtCTRL)
        Me.Controls.Add(Me.txtEmpNo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmAEOtherInfo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Other Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtEmpNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCTRL As System.Windows.Forms.TextBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents txtOption As System.Windows.Forms.TextBox
    Friend WithEvents txtOptDesc As System.Windows.Forms.TextBox
End Class
