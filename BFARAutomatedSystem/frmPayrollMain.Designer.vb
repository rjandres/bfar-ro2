<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayrollMain))
        Me.grpEmp = New System.Windows.Forms.GroupBox()
        Me.lvEmp = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNHT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNHR = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtReg = New System.Windows.Forms.TextBox()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.txtEmpNo = New System.Windows.Forms.TextBox()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.empPic = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdDeduction = New System.Windows.Forms.Button()
        Me.txtTotaDeduct = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpDeduction = New System.Windows.Forms.GroupBox()
        Me.cmdCancel1 = New System.Windows.Forms.Button()
        Me.cmdSave1 = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lvDeduction = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ctrn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbMonth = New System.Windows.Forms.ComboBox()
        Me.txtYear = New System.Windows.Forms.NumericUpDown()
        Me.cmdCompute = New System.Windows.Forms.Button()
        Me.grpEmp.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.empPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grpDeduction.SuspendLayout()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpEmp
        '
        Me.grpEmp.Controls.Add(Me.lvEmp)
        Me.grpEmp.Location = New System.Drawing.Point(13, 3)
        Me.grpEmp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpEmp.Name = "grpEmp"
        Me.grpEmp.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpEmp.Size = New System.Drawing.Size(376, 686)
        Me.grpEmp.TabIndex = 12
        Me.grpEmp.TabStop = False
        '
        'lvEmp
        '
        Me.lvEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lvEmp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader1})
        Me.lvEmp.FullRowSelect = True
        Me.lvEmp.GridLines = True
        Me.lvEmp.Location = New System.Drawing.Point(8, 18)
        Me.lvEmp.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.lvEmp.Name = "lvEmp"
        Me.lvEmp.Size = New System.Drawing.Size(358, 659)
        Me.lvEmp.TabIndex = 0
        Me.lvEmp.UseCompatibleStateImageBehavior = False
        Me.lvEmp.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "EmpNo"
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "No."
        Me.ColumnHeader10.Width = 30
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Employee Name"
        Me.ColumnHeader11.Width = 300
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Pci"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtNHT)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtNHR)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtRate)
        Me.GroupBox2.Controls.Add(Me.txtReg)
        Me.GroupBox2.Controls.Add(Me.txtDesignation)
        Me.GroupBox2.Controls.Add(Me.txtEmpNo)
        Me.GroupBox2.Controls.Add(Me.txtEmpName)
        Me.GroupBox2.Controls.Add(Me.empPic)
        Me.GroupBox2.Location = New System.Drawing.Point(396, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(479, 193)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(156, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Tardiness :"
        '
        'txtNHT
        '
        Me.txtNHT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNHT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNHT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNHT.Location = New System.Drawing.Point(265, 160)
        Me.txtNHT.Name = "txtNHT"
        Me.txtNHT.Size = New System.Drawing.Size(205, 20)
        Me.txtNHT.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 20)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "No. of Hours Rendered :"
        '
        'txtNHR
        '
        Me.txtNHR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNHR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNHR.Location = New System.Drawing.Point(343, 134)
        Me.txtNHR.Name = "txtNHR"
        Me.txtNHR.Size = New System.Drawing.Size(127, 20)
        Me.txtNHR.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(156, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Rate/Month :"
        '
        'txtRate
        '
        Me.txtRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtRate.Location = New System.Drawing.Point(265, 108)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(205, 20)
        Me.txtRate.TabIndex = 46
        '
        'txtReg
        '
        Me.txtReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtReg.Location = New System.Drawing.Point(154, 74)
        Me.txtReg.Name = "txtReg"
        Me.txtReg.Size = New System.Drawing.Size(316, 20)
        Me.txtReg.TabIndex = 45
        '
        'txtDesignation
        '
        Me.txtDesignation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesignation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDesignation.Location = New System.Drawing.Point(154, 48)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(316, 20)
        Me.txtDesignation.TabIndex = 44
        '
        'txtEmpNo
        '
        Me.txtEmpNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmpNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtEmpNo.Location = New System.Drawing.Point(7, 159)
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(140, 20)
        Me.txtEmpNo.TabIndex = 43
        Me.txtEmpNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmpName
        '
        Me.txtEmpName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtEmpName.Location = New System.Drawing.Point(154, 22)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(316, 20)
        Me.txtEmpName.TabIndex = 42
        '
        'empPic
        '
        Me.empPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.empPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.empPic.ErrorImage = CType(resources.GetObject("empPic.ErrorImage"), System.Drawing.Image)
        Me.empPic.Location = New System.Drawing.Point(6, 16)
        Me.empPic.Name = "empPic"
        Me.empPic.Size = New System.Drawing.Size(142, 140)
        Me.empPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.empPic.TabIndex = 41
        Me.empPic.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.cmdDeduction)
        Me.GroupBox3.Controls.Add(Me.txtTotaDeduct)
        Me.GroupBox3.Location = New System.Drawing.Point(396, 474)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(475, 171)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Deductions"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 20)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Deductions :"
        '
        'cmdDeduction
        '
        Me.cmdDeduction.Location = New System.Drawing.Point(307, 134)
        Me.cmdDeduction.Name = "cmdDeduction"
        Me.cmdDeduction.Size = New System.Drawing.Size(162, 28)
        Me.cmdDeduction.TabIndex = 0
        Me.cmdDeduction.Text = "Manage Deduction"
        Me.cmdDeduction.UseVisualStyleBackColor = True
        '
        'txtTotaDeduct
        '
        Me.txtTotaDeduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotaDeduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotaDeduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTotaDeduct.Location = New System.Drawing.Point(118, 35)
        Me.txtTotaDeduct.Name = "txtTotaDeduct"
        Me.txtTotaDeduct.Size = New System.Drawing.Size(205, 20)
        Me.txtTotaDeduct.TabIndex = 48
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Location = New System.Drawing.Point(396, 298)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(475, 174)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Allowance"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(307, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Manage Allowance"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grpDeduction
        '
        Me.grpDeduction.Controls.Add(Me.cmdCancel1)
        Me.grpDeduction.Controls.Add(Me.cmdSave1)
        Me.grpDeduction.Controls.Add(Me.cmdCancel)
        Me.grpDeduction.Controls.Add(Me.cmdSave)
        Me.grpDeduction.Controls.Add(Me.TextBox1)
        Me.grpDeduction.Controls.Add(Me.lvDeduction)
        Me.grpDeduction.Location = New System.Drawing.Point(882, 12)
        Me.grpDeduction.Name = "grpDeduction"
        Me.grpDeduction.Size = New System.Drawing.Size(334, 651)
        Me.grpDeduction.TabIndex = 16
        Me.grpDeduction.TabStop = False
        Me.grpDeduction.Visible = False
        '
        'cmdCancel1
        '
        Me.cmdCancel1.Location = New System.Drawing.Point(247, 616)
        Me.cmdCancel1.Name = "cmdCancel1"
        Me.cmdCancel1.Size = New System.Drawing.Size(75, 26)
        Me.cmdCancel1.TabIndex = 5
        Me.cmdCancel1.Text = "Close"
        Me.cmdCancel1.UseVisualStyleBackColor = True
        '
        'cmdSave1
        '
        Me.cmdSave1.Location = New System.Drawing.Point(166, 616)
        Me.cmdSave1.Name = "cmdSave1"
        Me.cmdSave1.Size = New System.Drawing.Size(75, 26)
        Me.cmdSave1.TabIndex = 4
        Me.cmdSave1.Text = "Save"
        Me.cmdSave1.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(247, 18)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 26)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "Close"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(166, 18)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 26)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(9, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(78, 26)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Visible = False
        '
        'lvDeduction
        '
        Me.lvDeduction.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lvDeduction.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.ctrn, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvDeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDeduction.FullRowSelect = True
        Me.lvDeduction.GridLines = True
        Me.lvDeduction.Location = New System.Drawing.Point(6, 48)
        Me.lvDeduction.Name = "lvDeduction"
        Me.lvDeduction.Size = New System.Drawing.Size(316, 561)
        Me.lvDeduction.TabIndex = 0
        Me.lvDeduction.UseCompatibleStateImageBehavior = False
        Me.lvDeduction.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.DisplayIndex = 3
        Me.ID.Text = "ID"
        Me.ID.Width = 0
        '
        'ctrn
        '
        Me.ctrn.DisplayIndex = 0
        Me.ctrn.Text = "ctrn"
        Me.ctrn.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.DisplayIndex = 1
        Me.ColumnHeader2.Text = "Deduction Type"
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DisplayIndex = 2
        Me.ColumnHeader3.Text = "Amount"
        Me.ColumnHeader3.Width = 100
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(399, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 20)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Date Covered :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(460, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 20)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Month :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(471, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Year :"
        '
        'cbMonth
        '
        Me.cbMonth.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonth.FormattingEnabled = True
        Me.cbMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cbMonth.Location = New System.Drawing.Point(529, 35)
        Me.cbMonth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbMonth.Name = "cbMonth"
        Me.cbMonth.Size = New System.Drawing.Size(154, 28)
        Me.cbMonth.TabIndex = 53
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(529, 68)
        Me.txtYear.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtYear.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txtYear.Name = "txtYear"
        Me.txtYear.ReadOnly = True
        Me.txtYear.Size = New System.Drawing.Size(120, 26)
        Me.txtYear.TabIndex = 54
        Me.txtYear.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'cmdCompute
        '
        Me.cmdCompute.Location = New System.Drawing.Point(728, 30)
        Me.cmdCompute.Name = "cmdCompute"
        Me.cmdCompute.Size = New System.Drawing.Size(118, 28)
        Me.cmdCompute.TabIndex = 55
        Me.cmdCompute.Text = "Compute"
        Me.cmdCompute.UseVisualStyleBackColor = True
        '
        'frmPayrollMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(1240, 700)
        Me.Controls.Add(Me.cmdCompute)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.cbMonth)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grpDeduction)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpEmp)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmPayrollMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPayrollMain"
        Me.grpEmp.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.empPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.grpDeduction.ResumeLayout(False)
        Me.grpDeduction.PerformLayout()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpEmp As System.Windows.Forms.GroupBox
    Friend WithEvents lvEmp As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents empPic As System.Windows.Forms.PictureBox
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtEmpNo As System.Windows.Forms.TextBox
    Friend WithEvents txtReg As System.Windows.Forms.TextBox
    Friend WithEvents txtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNHT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNHR As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdDeduction As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents grpDeduction As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lvDeduction As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ctrn As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdCancel1 As System.Windows.Forms.Button
    Friend WithEvents cmdSave1 As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents txtYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdCompute As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotaDeduct As System.Windows.Forms.TextBox
End Class
