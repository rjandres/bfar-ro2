<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAEDU
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
        Me.txtDiv = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtCTRNo = New System.Windows.Forms.TextBox()
        Me.txtDivCode = New System.Windows.Forms.TextBox()
        Me.txtEmpNo = New System.Windows.Forms.TextBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtPercent = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtDiv
        '
        Me.txtDiv.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDiv.Location = New System.Drawing.Point(167, 8)
        Me.txtDiv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDiv.Name = "txtDiv"
        Me.txtDiv.ReadOnly = True
        Me.txtDiv.Size = New System.Drawing.Size(331, 26)
        Me.txtDiv.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(167, 49)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(285, 26)
        Me.txtName.TabIndex = 1
        '
        'txtTask
        '
        Me.txtTask.Location = New System.Drawing.Point(167, 91)
        Me.txtTask.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(326, 26)
        Me.txtTask.TabIndex = 2
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(167, 143)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(331, 95)
        Me.txtDesc.TabIndex = 3
        '
        'txtCTRNo
        '
        Me.txtCTRNo.Location = New System.Drawing.Point(32, 417)
        Me.txtCTRNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCTRNo.Name = "txtCTRNo"
        Me.txtCTRNo.Size = New System.Drawing.Size(148, 26)
        Me.txtCTRNo.TabIndex = 5
        '
        'txtDivCode
        '
        Me.txtDivCode.Location = New System.Drawing.Point(32, 458)
        Me.txtDivCode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDivCode.Name = "txtDivCode"
        Me.txtDivCode.Size = New System.Drawing.Size(148, 26)
        Me.txtDivCode.TabIndex = 6
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Location = New System.Drawing.Point(32, 500)
        Me.txtEmpNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(148, 26)
        Me.txtEmpNo.TabIndex = 7
        '
        'cmdSearch
        '
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Location = New System.Drawing.Point(456, 49)
        Me.cmdSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(38, 27)
        Me.cmdSearch.TabIndex = 8
        Me.cmdSearch.Text = "...."
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Divsion/Unit :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Employee Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Assign Task :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(162, 119)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Description :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 246)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Percentage :"
        '
        'cmdSave
        '
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Location = New System.Drawing.Point(290, 249)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(100, 27)
        Me.cmdSave.TabIndex = 14
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Location = New System.Drawing.Point(398, 250)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(100, 27)
        Me.cmdCancel.TabIndex = 15
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'txtPercent
        '
        Me.txtPercent.Location = New System.Drawing.Point(167, 247)
        Me.txtPercent.Name = "txtPercent"
        Me.txtPercent.Size = New System.Drawing.Size(37, 26)
        Me.txtPercent.TabIndex = 16
        Me.txtPercent.Text = "100"
        '
        'frmAEDU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(514, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtPercent)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.txtEmpNo)
        Me.Controls.Add(Me.txtDivCode)
        Me.Controls.Add(Me.txtCTRNo)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtTask)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtDiv)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmAEDU"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAEDU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDiv As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtTask As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtCTRNo As System.Windows.Forms.TextBox
    Friend WithEvents txtDivCode As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpNo As System.Windows.Forms.TextBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents txtPercent As System.Windows.Forms.TextBox
End Class
