<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDTRSetup
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDTRSetup))
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.cmdEditSave = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtxtAMOUT = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtAMIN = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.mtxtPMOUT = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtPMIN = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'cmdEditSave
        '
        Me.cmdEditSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEditSave.Location = New System.Drawing.Point(169, 131)
        Me.cmdEditSave.Name = "cmdEditSave"
        Me.cmdEditSave.Size = New System.Drawing.Size(63, 24)
        Me.cmdEditSave.TabIndex = 0
        Me.cmdEditSave.Text = "Save"
        Me.cmdEditSave.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(238, 130)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 25)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mtxtAMOUT)
        Me.GroupBox1.Controls.Add(Me.mtxtAMIN)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 49)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AM"
        '
        'mtxtAMOUT
        '
        Me.mtxtAMOUT.Location = New System.Drawing.Point(175, 16)
        Me.mtxtAMOUT.Mask = "00:00:00"
        Me.mtxtAMOUT.Name = "mtxtAMOUT"
        Me.mtxtAMOUT.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.mtxtAMOUT.Size = New System.Drawing.Size(86, 22)
        Me.mtxtAMOUT.TabIndex = 5
        '
        'mtxtAMIN
        '
        Me.mtxtAMIN.Location = New System.Drawing.Point(46, 16)
        Me.mtxtAMIN.Mask = "00:00:00"
        Me.mtxtAMIN.Name = "mtxtAMIN"
        Me.mtxtAMIN.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.mtxtAMIN.Size = New System.Drawing.Size(86, 22)
        Me.mtxtAMIN.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "OUT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "IN"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mtxtPMOUT)
        Me.GroupBox2.Controls.Add(Me.mtxtPMIN)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 50)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PM"
        '
        'mtxtPMOUT
        '
        Me.mtxtPMOUT.Location = New System.Drawing.Point(175, 16)
        Me.mtxtPMOUT.Mask = "00:00:00"
        Me.mtxtPMOUT.Name = "mtxtPMOUT"
        Me.mtxtPMOUT.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.mtxtPMOUT.Size = New System.Drawing.Size(86, 22)
        Me.mtxtPMOUT.TabIndex = 5
        '
        'mtxtPMIN
        '
        Me.mtxtPMIN.Location = New System.Drawing.Point(46, 16)
        Me.mtxtPMIN.Mask = "00:00:00"
        Me.mtxtPMIN.Name = "mtxtPMIN"
        Me.mtxtPMIN.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.mtxtPMIN.Size = New System.Drawing.Size(86, 22)
        Me.mtxtPMIN.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "OUT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "IN"
        '
        'frmDTRSetup
        '
        Me.AcceptButton = Me.cmdEditSave
        Me.AutoScrollMargin = New System.Drawing.Size(0, 1262)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(311, 164)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdEditSave)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "frmDTRSetup"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Time Setup"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdEditSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtxtPMOUT As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtPMIN As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtAMOUT As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtAMIN As System.Windows.Forms.MaskedTextBox
    '   Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    '    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    '    Friend WithEvents Personal1 As BFARAutomatedSystem.Personal
    '    Friend WithEvents CrystalReportViewer3 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
