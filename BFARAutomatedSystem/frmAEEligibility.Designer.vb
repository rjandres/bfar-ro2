<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAEEligibility
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCareer = New System.Windows.Forms.TextBox()
        Me.txtRating = New System.Windows.Forms.TextBox()
        Me.dtExamDate = New System.Windows.Forms.DateTimePicker()
        Me.txtExamPlace = New System.Windows.Forms.TextBox()
        Me.txtLicense = New System.Windows.Forms.TextBox()
        Me.dtLicenseDate = New System.Windows.Forms.DateTimePicker()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtEmpNo = New System.Windows.Forms.TextBox()
        Me.txtCTRL = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(-1, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Eligibility :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rating :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(190, 71)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 103)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(279, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Place of Examination/Confernment :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 163)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "License Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 200)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Date Release"
        '
        'txtCareer
        '
        Me.txtCareer.Location = New System.Drawing.Point(93, 33)
        Me.txtCareer.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtCareer.Name = "txtCareer"
        Me.txtCareer.Size = New System.Drawing.Size(389, 24)
        Me.txtCareer.TabIndex = 0
        '
        'txtRating
        '
        Me.txtRating.Location = New System.Drawing.Point(93, 65)
        Me.txtRating.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtRating.Name = "txtRating"
        Me.txtRating.Size = New System.Drawing.Size(77, 24)
        Me.txtRating.TabIndex = 1
        '
        'dtExamDate
        '
        Me.dtExamDate.CustomFormat = "MM/dd/yyyy"
        Me.dtExamDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtExamDate.Location = New System.Drawing.Point(253, 66)
        Me.dtExamDate.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dtExamDate.Name = "dtExamDate"
        Me.dtExamDate.Size = New System.Drawing.Size(124, 24)
        Me.dtExamDate.TabIndex = 2
        '
        'txtExamPlace
        '
        Me.txtExamPlace.Location = New System.Drawing.Point(17, 125)
        Me.txtExamPlace.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtExamPlace.Name = "txtExamPlace"
        Me.txtExamPlace.Size = New System.Drawing.Size(465, 24)
        Me.txtExamPlace.TabIndex = 3
        '
        'txtLicense
        '
        Me.txtLicense.Location = New System.Drawing.Point(154, 160)
        Me.txtLicense.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtLicense.Name = "txtLicense"
        Me.txtLicense.Size = New System.Drawing.Size(324, 24)
        Me.txtLicense.TabIndex = 4
        '
        'dtLicenseDate
        '
        Me.dtLicenseDate.CustomFormat = "MM/dd/yyyy"
        Me.dtLicenseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtLicenseDate.Location = New System.Drawing.Point(133, 195)
        Me.dtLicenseDate.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dtLicenseDate.Name = "dtLicenseDate"
        Me.dtLicenseDate.Size = New System.Drawing.Size(131, 24)
        Me.dtLicenseDate.TabIndex = 5
        '
        'cmdSave
        '
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Location = New System.Drawing.Point(225, 233)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(125, 32)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "&SAVE"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Location = New System.Drawing.Point(360, 233)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(125, 32)
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.Text = "&CANCEL"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Location = New System.Drawing.Point(105, 266)
        Me.txtEmpNo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(84, 24)
        Me.txtEmpNo.TabIndex = 14
        Me.txtEmpNo.Visible = False
        '
        'txtCTRL
        '
        Me.txtCTRL.Location = New System.Drawing.Point(2, 266)
        Me.txtCTRL.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtCTRL.Name = "txtCTRL"
        Me.txtCTRL.Size = New System.Drawing.Size(91, 24)
        Me.txtCTRL.TabIndex = 21
        Me.txtCTRL.Visible = False
        '
        'frmAEEligibility
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(505, 284)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCTRL)
        Me.Controls.Add(Me.txtEmpNo)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.dtLicenseDate)
        Me.Controls.Add(Me.txtLicense)
        Me.Controls.Add(Me.txtExamPlace)
        Me.Controls.Add(Me.dtExamDate)
        Me.Controls.Add(Me.txtRating)
        Me.Controls.Add(Me.txtCareer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmAEEligibility"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Civil Service Eligibility"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCareer As System.Windows.Forms.TextBox
    Friend WithEvents txtRating As System.Windows.Forms.TextBox
    Friend WithEvents dtExamDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtExamPlace As System.Windows.Forms.TextBox
    Friend WithEvents txtLicense As System.Windows.Forms.TextBox
    Friend WithEvents dtLicenseDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents txtEmpNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCTRL As System.Windows.Forms.TextBox
End Class
