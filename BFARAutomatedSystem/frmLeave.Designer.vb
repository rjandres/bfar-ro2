<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeave
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
        Me.lvLeave = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtStart = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbAddEdit = New System.Windows.Forms.GroupBox()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.cbEnd = New System.Windows.Forms.ComboBox()
        Me.cbStart = New System.Windows.Forms.ComboBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtE = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtS = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbLeave = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.txtEmpNo = New System.Windows.Forms.TextBox()
        Me.txtCTR = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.gbAddEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvLeave
        '
        Me.lvLeave.FullRowSelect = True
        Me.lvLeave.GridLines = True
        Me.lvLeave.Location = New System.Drawing.Point(22, 65)
        Me.lvLeave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lvLeave.Name = "lvLeave"
        Me.lvLeave.Size = New System.Drawing.Size(741, 303)
        Me.lvLeave.TabIndex = 0
        Me.lvLeave.UseCompatibleStateImageBehavior = False
        Me.lvLeave.View = System.Windows.Forms.View.Details
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtEnd)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtStart)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtLast)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lvLeave)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 196)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(778, 376)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'dtEnd
        '
        Me.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEnd.Location = New System.Drawing.Point(579, 29)
        Me.dtEnd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtEnd.Name = "dtEnd"
        Me.dtEnd.Size = New System.Drawing.Size(140, 26)
        Me.dtEnd.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(525, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "End"
        '
        'dtStart
        '
        Me.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtStart.Location = New System.Drawing.Point(363, 29)
        Me.dtStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.Size = New System.Drawing.Size(140, 26)
        Me.dtStart.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Start"
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(120, 29)
        Me.txtLast.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(178, 26)
        Me.txtLast.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Emp No :"
        '
        'gbAddEdit
        '
        Me.gbAddEdit.Controls.Add(Me.txtDay)
        Me.gbAddEdit.Controls.Add(Me.cbEnd)
        Me.gbAddEdit.Controls.Add(Me.cbStart)
        Me.gbAddEdit.Controls.Add(Me.txtNum)
        Me.gbAddEdit.Controls.Add(Me.Label9)
        Me.gbAddEdit.Controls.Add(Me.dtE)
        Me.gbAddEdit.Controls.Add(Me.Label8)
        Me.gbAddEdit.Controls.Add(Me.dtS)
        Me.gbAddEdit.Controls.Add(Me.Label7)
        Me.gbAddEdit.Controls.Add(Me.txtDesc)
        Me.gbAddEdit.Controls.Add(Me.Label6)
        Me.gbAddEdit.Controls.Add(Me.cbLeave)
        Me.gbAddEdit.Controls.Add(Me.Label5)
        Me.gbAddEdit.Controls.Add(Me.cmdSearch)
        Me.gbAddEdit.Controls.Add(Me.txtName)
        Me.gbAddEdit.Controls.Add(Me.Label4)
        Me.gbAddEdit.Enabled = False
        Me.gbAddEdit.Location = New System.Drawing.Point(18, 8)
        Me.gbAddEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbAddEdit.Name = "gbAddEdit"
        Me.gbAddEdit.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbAddEdit.Size = New System.Drawing.Size(643, 194)
        Me.gbAddEdit.TabIndex = 2
        Me.gbAddEdit.TabStop = False
        '
        'txtDay
        '
        Me.txtDay.Location = New System.Drawing.Point(566, 118)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(65, 26)
        Me.txtDay.TabIndex = 15
        '
        'cbEnd
        '
        Me.cbEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEnd.FormattingEnabled = True
        Me.cbEnd.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbEnd.Location = New System.Drawing.Point(586, 79)
        Me.cbEnd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbEnd.Name = "cbEnd"
        Me.cbEnd.Size = New System.Drawing.Size(51, 28)
        Me.cbEnd.TabIndex = 14
        '
        'cbStart
        '
        Me.cbStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStart.FormattingEnabled = True
        Me.cbStart.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbStart.Location = New System.Drawing.Point(586, 44)
        Me.cbStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbStart.Name = "cbStart"
        Me.cbStart.Size = New System.Drawing.Size(51, 28)
        Me.cbStart.TabIndex = 13
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(483, 118)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.ReadOnly = True
        Me.txtNum.Size = New System.Drawing.Size(80, 26)
        Me.txtNum.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(369, 116)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "No. of Days :"
        '
        'dtE
        '
        Me.dtE.CustomFormat = "MM/dd/yyyy HH:mm"
        Me.dtE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtE.Location = New System.Drawing.Point(420, 80)
        Me.dtE.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtE.Name = "dtE"
        Me.dtE.Size = New System.Drawing.Size(162, 26)
        Me.dtE.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(370, 85)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "End :"
        '
        'dtS
        '
        Me.dtS.CustomFormat = "MM/dd/yyyy HH:mm"
        Me.dtS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtS.Location = New System.Drawing.Point(419, 44)
        Me.dtS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtS.Name = "dtS"
        Me.dtS.Size = New System.Drawing.Size(163, 26)
        Me.dtS.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(369, 49)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Start :"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(149, 115)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(213, 69)
        Me.txtDesc.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 118)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Description :"
        '
        'cbLeave
        '
        Me.cbLeave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLeave.FormattingEnabled = True
        Me.cbLeave.Location = New System.Drawing.Point(149, 72)
        Me.cbLeave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbLeave.Name = "cbLeave"
        Me.cbLeave.Size = New System.Drawing.Size(212, 28)
        Me.cbLeave.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 78)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Type of Leave :"
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(310, 43)
        Me.cmdSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(51, 28)
        Me.cmdSearch.TabIndex = 2
        Me.cmdSearch.Text = "...."
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(52, 43)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(255, 26)
        Me.txtName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 17)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Employee Name :"
        '
        'cmdDelete
        '
        Me.cmdDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Location = New System.Drawing.Point(669, 110)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(127, 35)
        Me.cmdDelete.TabIndex = 13
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEdit.Location = New System.Drawing.Point(669, 65)
        Me.cmdEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(127, 35)
        Me.cmdEdit.TabIndex = 12
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.Location = New System.Drawing.Point(669, 20)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(127, 35)
        Me.cmdAdd.TabIndex = 11
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Location = New System.Drawing.Point(669, 157)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(127, 35)
        Me.cmdClose.TabIndex = 14
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Location = New System.Drawing.Point(32, 669)
        Me.txtEmpNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(148, 26)
        Me.txtEmpNo.TabIndex = 15
        '
        'txtCTR
        '
        Me.txtCTR.Location = New System.Drawing.Point(174, 669)
        Me.txtCTR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCTR.Name = "txtCTR"
        Me.txtCTR.Size = New System.Drawing.Size(148, 26)
        Me.txtCTR.TabIndex = 16
        '
        'frmLeave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(811, 577)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCTR)
        Me.Controls.Add(Me.txtEmpNo)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.gbAddEdit)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdAdd)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmLeave"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbAddEdit.ResumeLayout(False)
        Me.gbAddEdit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvLeave As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLast As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbAddEdit As System.Windows.Forms.GroupBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbLeave As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents dtE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtS As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents txtEmpNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCTR As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents cbEnd As System.Windows.Forms.ComboBox
    Friend WithEvents cbStart As System.Windows.Forms.ComboBox
    Friend WithEvents txtDay As System.Windows.Forms.TextBox
End Class
