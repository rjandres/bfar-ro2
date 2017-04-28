<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAETravelOrder
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
        Me.txtTONo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtRequest = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmpNo = New System.Windows.Forms.TextBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTranspo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtDeparture = New System.Windows.Forms.DateTimePicker()
        Me.cbDeparture = New System.Windows.Forms.ComboBox()
        Me.cbReturn = New System.Windows.Forms.ComboBox()
        Me.dtReturn = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtStation = New System.Windows.Forms.TextBox()
        Me.txtCTRL = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Travel Order No. :"
        '
        'txtTONo
        '
        Me.txtTONo.Location = New System.Drawing.Point(184, 12)
        Me.txtTONo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTONo.Name = "txtTONo"
        Me.txtTONo.ReadOnly = True
        Me.txtTONo.Size = New System.Drawing.Size(78, 24)
        Me.txtTONo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(298, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date :"
        '
        'dtRequest
        '
        Me.dtRequest.CustomFormat = "MM/dd/yyyy"
        Me.dtRequest.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtRequest.Location = New System.Drawing.Point(367, 12)
        Me.dtRequest.Margin = New System.Windows.Forms.Padding(4)
        Me.dtRequest.Name = "dtRequest"
        Me.dtRequest.Size = New System.Drawing.Size(158, 24)
        Me.dtRequest.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 56)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name :"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(118, 52)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(368, 24)
        Me.txtName.TabIndex = 5
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Location = New System.Drawing.Point(530, 52)
        Me.txtEmpNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.ReadOnly = True
        Me.txtEmpNo.Size = New System.Drawing.Size(138, 24)
        Me.txtEmpNo.TabIndex = 6
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(488, 50)
        Me.cmdSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(40, 32)
        Me.cmdSearch.TabIndex = 7
        Me.cmdSearch.Text = "..."
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 92)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Designation :"
        '
        'txtDesignation
        '
        Me.txtDesignation.Location = New System.Drawing.Point(168, 92)
        Me.txtDesignation.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.ReadOnly = True
        Me.txtDesignation.Size = New System.Drawing.Size(357, 24)
        Me.txtDesignation.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 168)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Destination :"
        '
        'txtDestination
        '
        Me.txtDestination.Location = New System.Drawing.Point(168, 168)
        Me.txtDestination.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(357, 24)
        Me.txtDestination.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 214)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(203, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Means of Transportation :"
        '
        'txtTranspo
        '
        Me.txtTranspo.Location = New System.Drawing.Point(272, 204)
        Me.txtTranspo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTranspo.Name = "txtTranspo"
        Me.txtTranspo.Size = New System.Drawing.Size(252, 24)
        Me.txtTranspo.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 280)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Date :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(100, 280)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 18)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Departure :"
        '
        'dtDeparture
        '
        Me.dtDeparture.CustomFormat = "MM/dd/yyyy"
        Me.dtDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDeparture.Location = New System.Drawing.Point(212, 280)
        Me.dtDeparture.Margin = New System.Windows.Forms.Padding(4)
        Me.dtDeparture.Name = "dtDeparture"
        Me.dtDeparture.Size = New System.Drawing.Size(164, 24)
        Me.dtDeparture.TabIndex = 16
        '
        'cbDeparture
        '
        Me.cbDeparture.FormattingEnabled = True
        Me.cbDeparture.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbDeparture.Location = New System.Drawing.Point(372, 280)
        Me.cbDeparture.Margin = New System.Windows.Forms.Padding(4)
        Me.cbDeparture.Name = "cbDeparture"
        Me.cbDeparture.Size = New System.Drawing.Size(62, 26)
        Me.cbDeparture.TabIndex = 17
        Me.cbDeparture.Text = "AM"
        '
        'cbReturn
        '
        Me.cbReturn.FormattingEnabled = True
        Me.cbReturn.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbReturn.Location = New System.Drawing.Point(372, 316)
        Me.cbReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.cbReturn.Name = "cbReturn"
        Me.cbReturn.Size = New System.Drawing.Size(62, 26)
        Me.cbReturn.TabIndex = 20
        Me.cbReturn.Text = "PM"
        '
        'dtReturn
        '
        Me.dtReturn.CustomFormat = "MM/dd/yyyy"
        Me.dtReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtReturn.Location = New System.Drawing.Point(212, 316)
        Me.dtReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.dtReturn.Name = "dtReturn"
        Me.dtReturn.Size = New System.Drawing.Size(164, 24)
        Me.dtReturn.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(124, 316)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Return :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 245)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 18)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Purpose :"
        '
        'cmdSave
        '
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdSave.Location = New System.Drawing.Point(253, 353)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(124, 32)
        Me.cmdSave.TabIndex = 22
        Me.cmdSave.Text = "SAVE"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdCancel.Location = New System.Drawing.Point(404, 353)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(124, 32)
        Me.cmdCancel.TabIndex = 23
        Me.cmdCancel.Text = "CANCEL"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'txtPurpose
        '
        Me.txtPurpose.Location = New System.Drawing.Point(130, 245)
        Me.txtPurpose.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(394, 24)
        Me.txtPurpose.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 136)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 18)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Station :"
        '
        'txtStation
        '
        Me.txtStation.Location = New System.Drawing.Point(168, 132)
        Me.txtStation.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStation.Name = "txtStation"
        Me.txtStation.Size = New System.Drawing.Size(237, 24)
        Me.txtStation.TabIndex = 26
        Me.txtStation.Text = "BFAR-RFTC 02"
        '
        'txtCTRL
        '
        Me.txtCTRL.Location = New System.Drawing.Point(13, 357)
        Me.txtCTRL.Name = "txtCTRL"
        Me.txtCTRL.Size = New System.Drawing.Size(90, 24)
        Me.txtCTRL.TabIndex = 27
        '
        'frmAETravelOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(539, 387)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCTRL)
        Me.Controls.Add(Me.txtStation)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPurpose)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbReturn)
        Me.Controls.Add(Me.dtReturn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbDeparture)
        Me.Controls.Add(Me.dtDeparture)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTranspo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDestination)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDesignation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.txtEmpNo)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtRequest)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTONo)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAETravelOrder"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Travel Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTONo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtRequest As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpNo As System.Windows.Forms.TextBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDestination As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTranspo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtDeparture As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbDeparture As System.Windows.Forms.ComboBox
    Friend WithEvents cbReturn As System.Windows.Forms.ComboBox
    Friend WithEvents dtReturn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtStation As System.Windows.Forms.TextBox
    Friend WithEvents txtCTRL As System.Windows.Forms.TextBox
End Class
