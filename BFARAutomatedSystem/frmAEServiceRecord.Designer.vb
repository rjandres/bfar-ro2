<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAEServiceRecord
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtTo = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtSalaryGrade = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.optYes = New System.Windows.Forms.RadioButton()
        Me.optNo = New System.Windows.Forms.RadioButton()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtEmpNo = New System.Windows.Forms.TextBox()
        Me.txtService = New System.Windows.Forms.TextBox()
        Me.txtCTRL = New System.Windows.Forms.TextBox()
        Me.ckbPresent = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inclusive Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "from"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(367, 56)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "to"
        '
        'dtFrom
        '
        Me.dtFrom.CustomFormat = "MM/dd/yyyy"
        Me.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrom.Location = New System.Drawing.Point(319, 55)
        Me.dtFrom.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(17, 23)
        Me.dtFrom.TabIndex = 2
        '
        'dtTo
        '
        Me.dtTo.CustomFormat = "MM/dd/yyyy"
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo.Location = New System.Drawing.Point(534, 56)
        Me.dtTo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(16, 23)
        Me.dtTo.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 94)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Position Title :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 152)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Agency :"
        '
        'txtPosition
        '
        Me.txtPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtPosition.Location = New System.Drawing.Point(142, 94)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPosition.Multiline = True
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(414, 49)
        Me.txtPosition.TabIndex = 5
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(142, 155)
        Me.txtDepartment.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDepartment.Multiline = True
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(411, 48)
        Me.txtDepartment.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 220)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Monthly Salary :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(322, 220)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Salary Grade :"
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(144, 219)
        Me.txtSalary.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(148, 23)
        Me.txtSalary.TabIndex = 7
        '
        'txtSalaryGrade
        '
        Me.txtSalaryGrade.Location = New System.Drawing.Point(434, 221)
        Me.txtSalaryGrade.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSalaryGrade.Mask = "00-0"
        Me.txtSalaryGrade.Name = "txtSalaryGrade"
        Me.txtSalaryGrade.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtSalaryGrade.Size = New System.Drawing.Size(83, 23)
        Me.txtSalaryGrade.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 275)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(178, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Status of Appointment :"
        '
        'cbStatus
        '
        Me.cbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Regular", "Contructual", "Casual"})
        Me.cbStatus.Location = New System.Drawing.Point(198, 272)
        Me.cbStatus.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(209, 25)
        Me.cbStatus.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 19)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Gov't Service :"
        '
        'optYes
        '
        Me.optYes.AutoSize = True
        Me.optYes.Location = New System.Drawing.Point(144, 19)
        Me.optYes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.optYes.Name = "optYes"
        Me.optYes.Size = New System.Drawing.Size(53, 21)
        Me.optYes.TabIndex = 0
        Me.optYes.TabStop = True
        Me.optYes.Text = "Yes"
        Me.optYes.UseVisualStyleBackColor = True
        '
        'optNo
        '
        Me.optNo.AutoSize = True
        Me.optNo.Location = New System.Drawing.Point(206, 19)
        Me.optNo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.optNo.Name = "optNo"
        Me.optNo.Size = New System.Drawing.Size(46, 21)
        Me.optNo.TabIndex = 1
        Me.optNo.TabStop = True
        Me.optNo.Text = "No"
        Me.optNo.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Location = New System.Drawing.Point(326, 303)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(112, 31)
        Me.cmdSave.TabIndex = 11
        Me.cmdSave.Text = "SAVE"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Location = New System.Drawing.Point(447, 303)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(112, 31)
        Me.cmdCancel.TabIndex = 12
        Me.cmdCancel.Text = "CANCEL"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Location = New System.Drawing.Point(19, 421)
        Me.txtEmpNo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(69, 23)
        Me.txtEmpNo.TabIndex = 20
        Me.txtEmpNo.Visible = False
        '
        'txtService
        '
        Me.txtService.Location = New System.Drawing.Point(98, 421)
        Me.txtService.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtService.Name = "txtService"
        Me.txtService.Size = New System.Drawing.Size(62, 23)
        Me.txtService.TabIndex = 21
        Me.txtService.Visible = False
        '
        'txtCTRL
        '
        Me.txtCTRL.Location = New System.Drawing.Point(172, 421)
        Me.txtCTRL.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCTRL.Name = "txtCTRL"
        Me.txtCTRL.Size = New System.Drawing.Size(80, 23)
        Me.txtCTRL.TabIndex = 22
        Me.txtCTRL.Visible = False
        '
        'ckbPresent
        '
        Me.ckbPresent.AutoSize = True
        Me.ckbPresent.Location = New System.Drawing.Point(398, 25)
        Me.ckbPresent.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ckbPresent.Name = "ckbPresent"
        Me.ckbPresent.Size = New System.Drawing.Size(83, 21)
        Me.ckbPresent.TabIndex = 3
        Me.ckbPresent.Text = "Present"
        Me.ckbPresent.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(520, 221)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(218, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 23
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(433, 56)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 23
        '
        'frmAEServiceRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(602, 339)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ckbPresent)
        Me.Controls.Add(Me.txtCTRL)
        Me.Controls.Add(Me.txtService)
        Me.Controls.Add(Me.txtEmpNo)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.optNo)
        Me.Controls.Add(Me.optYes)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSalaryGrade)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDepartment)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtTo)
        Me.Controls.Add(Me.dtFrom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmAEServiceRecord"
        Me.Opacity = 0.0R
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Work Experience"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents txtDepartment As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtSalaryGrade As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents optYes As System.Windows.Forms.RadioButton
    Friend WithEvents optNo As System.Windows.Forms.RadioButton
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents txtEmpNo As System.Windows.Forms.TextBox
    Friend WithEvents txtService As System.Windows.Forms.TextBox
    Friend WithEvents txtCTRL As System.Windows.Forms.TextBox
    Friend WithEvents ckbPresent As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
