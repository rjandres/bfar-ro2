<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAEReferencec
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddres = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txEmpNo = New System.Windows.Forms.TextBox()
        Me.txtCTRL = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(96, 18)
        Me.txtName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(339, 24)
        Me.txtName.TabIndex = 0
        '
        'txtAddres
        '
        Me.txtAddres.Location = New System.Drawing.Point(96, 55)
        Me.txtAddres.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtAddres.Name = "txtAddres"
        Me.txtAddres.Size = New System.Drawing.Size(339, 24)
        Me.txtAddres.TabIndex = 1
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(96, 92)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(200, 24)
        Me.txtTel.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Address :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 101)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tel. No. :"
        '
        'cmdSave
        '
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Location = New System.Drawing.Point(149, 128)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(139, 35)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Location = New System.Drawing.Point(296, 128)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(139, 35)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'txEmpNo
        '
        Me.txEmpNo.Location = New System.Drawing.Point(-52, 155)
        Me.txEmpNo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txEmpNo.Name = "txEmpNo"
        Me.txEmpNo.Size = New System.Drawing.Size(78, 24)
        Me.txEmpNo.TabIndex = 8
        Me.txEmpNo.Visible = False
        '
        'txtCTRL
        '
        Me.txtCTRL.Location = New System.Drawing.Point(40, 155)
        Me.txtCTRL.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtCTRL.Name = "txtCTRL"
        Me.txtCTRL.Size = New System.Drawing.Size(80, 24)
        Me.txtCTRL.TabIndex = 9
        Me.txtCTRL.Visible = False
        '
        'frmAEReferencec
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(455, 170)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCTRL)
        Me.Controls.Add(Me.txEmpNo)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtAddres)
        Me.Controls.Add(Me.txtName)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmAEReferencec"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "References"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddres As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents txEmpNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCTRL As System.Windows.Forms.TextBox
End Class
