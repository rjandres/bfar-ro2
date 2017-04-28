<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoliday
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
        Me.gbHoliday = New System.Windows.Forms.GroupBox()
        Me.lvHoliday = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbAdd = New System.Windows.Forms.GroupBox()
        Me.cbCovered = New System.Windows.Forms.ComboBox()
        Me.chkStatus = New System.Windows.Forms.CheckBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtHoliday = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHoliday = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.txtCTR = New System.Windows.Forms.TextBox()
        Me.gbHoliday.SuspendLayout()
        Me.gbAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbHoliday
        '
        Me.gbHoliday.Controls.Add(Me.lvHoliday)
        Me.gbHoliday.Location = New System.Drawing.Point(14, 185)
        Me.gbHoliday.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbHoliday.Name = "gbHoliday"
        Me.gbHoliday.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbHoliday.Size = New System.Drawing.Size(573, 296)
        Me.gbHoliday.TabIndex = 0
        Me.gbHoliday.TabStop = False
        '
        'lvHoliday
        '
        Me.lvHoliday.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvHoliday.FullRowSelect = True
        Me.lvHoliday.GridLines = True
        Me.lvHoliday.Location = New System.Drawing.Point(8, 19)
        Me.lvHoliday.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lvHoliday.Name = "lvHoliday"
        Me.lvHoliday.Size = New System.Drawing.Size(553, 267)
        Me.lvHoliday.TabIndex = 0
        Me.lvHoliday.UseCompatibleStateImageBehavior = False
        Me.lvHoliday.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ctrno"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Holiday"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Description"
        Me.ColumnHeader4.Width = 250
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Status"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Covered"
        '
        'gbAdd
        '
        Me.gbAdd.Controls.Add(Me.cbCovered)
        Me.gbAdd.Controls.Add(Me.chkStatus)
        Me.gbAdd.Controls.Add(Me.txtDesc)
        Me.gbAdd.Controls.Add(Me.Label3)
        Me.gbAdd.Controls.Add(Me.dtHoliday)
        Me.gbAdd.Controls.Add(Me.Label2)
        Me.gbAdd.Controls.Add(Me.txtHoliday)
        Me.gbAdd.Controls.Add(Me.Label1)
        Me.gbAdd.Enabled = False
        Me.gbAdd.Location = New System.Drawing.Point(14, 3)
        Me.gbAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbAdd.Name = "gbAdd"
        Me.gbAdd.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbAdd.Size = New System.Drawing.Size(432, 182)
        Me.gbAdd.TabIndex = 1
        Me.gbAdd.TabStop = False
        '
        'cbCovered
        '
        Me.cbCovered.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCovered.FormattingEnabled = True
        Me.cbCovered.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbCovered.Location = New System.Drawing.Point(226, 24)
        Me.cbCovered.Name = "cbCovered"
        Me.cbCovered.Size = New System.Drawing.Size(70, 28)
        Me.cbCovered.TabIndex = 7
        '
        'chkStatus
        '
        Me.chkStatus.AutoSize = True
        Me.chkStatus.Location = New System.Drawing.Point(310, 26)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Size = New System.Drawing.Size(105, 24)
        Me.chkStatus.TabIndex = 6
        Me.chkStatus.Text = "Whole Day"
        Me.chkStatus.UseVisualStyleBackColor = True
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(98, 117)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(324, 53)
        Me.txtDesc.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Description :"
        '
        'dtHoliday
        '
        Me.dtHoliday.CustomFormat = "MM/dd/yyyy"
        Me.dtHoliday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtHoliday.Location = New System.Drawing.Point(98, 25)
        Me.dtHoliday.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtHoliday.Name = "dtHoliday"
        Me.dtHoliday.Size = New System.Drawing.Size(120, 26)
        Me.dtHoliday.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date :"
        '
        'txtHoliday
        '
        Me.txtHoliday.Location = New System.Drawing.Point(98, 60)
        Me.txtHoliday.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtHoliday.Name = "txtHoliday"
        Me.txtHoliday.Size = New System.Drawing.Size(324, 26)
        Me.txtHoliday.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Holiday :"
        '
        'cmdAdd
        '
        Me.cmdAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.Location = New System.Drawing.Point(454, 12)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(112, 35)
        Me.cmdAdd.TabIndex = 2
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEdit.Location = New System.Drawing.Point(454, 57)
        Me.cmdEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(112, 35)
        Me.cmdEdit.TabIndex = 3
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Location = New System.Drawing.Point(454, 102)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(112, 35)
        Me.cmdDelete.TabIndex = 4
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Location = New System.Drawing.Point(456, 148)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(112, 35)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'txtCTR
        '
        Me.txtCTR.Location = New System.Drawing.Point(14, 485)
        Me.txtCTR.Name = "txtCTR"
        Me.txtCTR.Size = New System.Drawing.Size(100, 26)
        Me.txtCTR.TabIndex = 7
        Me.txtCTR.Visible = False
        '
        'frmHoliday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(596, 516)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCTR)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.gbAdd)
        Me.Controls.Add(Me.gbHoliday)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmHoliday"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbHoliday.ResumeLayout(False)
        Me.gbAdd.ResumeLayout(False)
        Me.gbAdd.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbHoliday As System.Windows.Forms.GroupBox
    Friend WithEvents lvHoliday As System.Windows.Forms.ListView
    Friend WithEvents gbAdd As System.Windows.Forms.GroupBox
    Friend WithEvents dtHoliday As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHoliday As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents txtCTR As System.Windows.Forms.TextBox
    Friend WithEvents chkStatus As System.Windows.Forms.CheckBox
    Friend WithEvents cbCovered As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
End Class
