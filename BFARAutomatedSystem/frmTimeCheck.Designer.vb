<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeCheck
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.mtxtPMOUT = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtPMIN = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtxtAMOUT = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtAMIN = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdEditSave = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mtxtPMOUT)
        Me.GroupBox2.Controls.Add(Me.mtxtPMIN)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 50)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PM"
        '
        'mtxtPMOUT
        '
        Me.mtxtPMOUT.Location = New System.Drawing.Point(175, 16)
        Me.mtxtPMOUT.Mask = "##:##:##"
        Me.mtxtPMOUT.Name = "mtxtPMOUT"
        Me.mtxtPMOUT.PromptChar = Global.Microsoft.VisualBasic.ChrW(64)
        Me.mtxtPMOUT.Size = New System.Drawing.Size(86, 20)
        Me.mtxtPMOUT.TabIndex = 5
        '
        'mtxtPMIN
        '
        Me.mtxtPMIN.Location = New System.Drawing.Point(46, 16)
        Me.mtxtPMIN.Mask = "##:##:##"
        Me.mtxtPMIN.Name = "mtxtPMIN"
        Me.mtxtPMIN.PromptChar = Global.Microsoft.VisualBasic.ChrW(64)
        Me.mtxtPMIN.Size = New System.Drawing.Size(86, 20)
        Me.mtxtPMIN.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "OUT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "IN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mtxtAMOUT)
        Me.GroupBox1.Controls.Add(Me.mtxtAMIN)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 49)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AM"
        '
        'mtxtAMOUT
        '
        Me.mtxtAMOUT.Location = New System.Drawing.Point(175, 16)
        Me.mtxtAMOUT.Mask = "##:##:##"
        Me.mtxtAMOUT.Name = "mtxtAMOUT"
        Me.mtxtAMOUT.PromptChar = Global.Microsoft.VisualBasic.ChrW(64)
        Me.mtxtAMOUT.Size = New System.Drawing.Size(86, 20)
        Me.mtxtAMOUT.TabIndex = 5
        '
        'mtxtAMIN
        '
        Me.mtxtAMIN.Location = New System.Drawing.Point(46, 16)
        Me.mtxtAMIN.Mask = "##:##:##"
        Me.mtxtAMIN.Name = "mtxtAMIN"
        Me.mtxtAMIN.PromptChar = Global.Microsoft.VisualBasic.ChrW(64)
        Me.mtxtAMIN.Size = New System.Drawing.Size(86, 20)
        Me.mtxtAMIN.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "OUT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "IN"
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(250, 240)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 25)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmdEditSave
        '
        Me.cmdEditSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEditSave.Location = New System.Drawing.Point(181, 241)
        Me.cmdEditSave.Name = "cmdEditSave"
        Me.cmdEditSave.Size = New System.Drawing.Size(63, 24)
        Me.cmdEditSave.TabIndex = 4
        Me.cmdEditSave.Text = "Save"
        Me.cmdEditSave.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDate)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtEmpID)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtName)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(288, 104)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(61, 64)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(95, 20)
        Me.txtDate.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Date :"
        '
        'txtEmpID
        '
        Me.txtEmpID.Location = New System.Drawing.Point(60, 12)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.ReadOnly = True
        Me.txtEmpID.Size = New System.Drawing.Size(78, 20)
        Me.txtEmpID.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "EmpID :"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(60, 38)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(222, 20)
        Me.txtName.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Name :"
        '
        'frmTimeCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(322, 272)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdEditSave)
        Me.Name = "frmTimeCheck"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents mtxtPMOUT As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtPMIN As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mtxtAMOUT As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtAMIN As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdEditSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
