<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAEChild
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtDOB = New System.Windows.Forms.DateTimePicker()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtEmpNo = New System.Windows.Forms.TextBox()
        Me.txtHold = New System.Windows.Forms.TextBox()
        Me.txtCTRL = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Children Name :"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(165, 14)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(287, 24)
        Me.txtName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date of Birth :"
        '
        'dtDOB
        '
        Me.dtDOB.CustomFormat = "MM/dd/yyyy"
        Me.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDOB.Location = New System.Drawing.Point(165, 47)
        Me.dtDOB.Margin = New System.Windows.Forms.Padding(4)
        Me.dtDOB.Name = "dtDOB"
        Me.dtDOB.Size = New System.Drawing.Size(203, 24)
        Me.dtDOB.TabIndex = 1
        Me.dtDOB.Value = New Date(2013, 8, 1, 0, 0, 0, 0)
        '
        'cmdSave
        '
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Location = New System.Drawing.Point(189, 91)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(124, 32)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Location = New System.Drawing.Point(329, 91)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(124, 32)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Location = New System.Drawing.Point(67, 282)
        Me.txtEmpNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(57, 24)
        Me.txtEmpNo.TabIndex = 7
        '
        'txtHold
        '
        Me.txtHold.Location = New System.Drawing.Point(139, 282)
        Me.txtHold.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHold.Name = "txtHold"
        Me.txtHold.Size = New System.Drawing.Size(67, 24)
        Me.txtHold.TabIndex = 8
        '
        'txtCTRL
        '
        Me.txtCTRL.Location = New System.Drawing.Point(17, 173)
        Me.txtCTRL.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCTRL.Name = "txtCTRL"
        Me.txtCTRL.Size = New System.Drawing.Size(67, 24)
        Me.txtCTRL.TabIndex = 21
        '
        'frmAEChild
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(470, 145)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCTRL)
        Me.Controls.Add(Me.txtHold)
        Me.Controls.Add(Me.txtEmpNo)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.dtDOB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAEChild"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Children's Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents txtEmpNo As System.Windows.Forms.TextBox
    Friend WithEvents txtHold As System.Windows.Forms.TextBox
    Friend WithEvents txtCTRL As System.Windows.Forms.TextBox
End Class
