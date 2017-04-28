<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageDivisionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageDesignationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TypeOfLeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalaryGradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HolidaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransaction = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TravelOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeavesInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DTRToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ActivitiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuTransaction})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(640, 29)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageDivisionToolStripMenuItem, Me.NewToolStripMenuItem, Me.ManageDesignationToolStripMenuItem, Me.TypeOfLeaveToolStripMenuItem, Me.SalaryGradeToolStripMenuItem, Me.HolidaysToolStripMenuItem, Me.ActivitiesToolStripMenuItem, Me.TimeSetupToolStripMenuItem, Me.ToolStripSeparator5, Me.ExitToolStripMenuItem})
        Me.mnuFile.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(46, 25)
        Me.mnuFile.Text = "&File"
        '
        'ManageDivisionToolStripMenuItem
        '
        Me.ManageDivisionToolStripMenuItem.Name = "ManageDivisionToolStripMenuItem"
        Me.ManageDivisionToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ManageDivisionToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.ManageDivisionToolStripMenuItem.Text = "Manage &Division"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.NewToolStripMenuItem.Text = "Manage &Position"
        '
        'ManageDesignationToolStripMenuItem
        '
        Me.ManageDesignationToolStripMenuItem.Name = "ManageDesignationToolStripMenuItem"
        Me.ManageDesignationToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.ManageDesignationToolStripMenuItem.Text = "Manage Designation"
        '
        'TypeOfLeaveToolStripMenuItem
        '
        Me.TypeOfLeaveToolStripMenuItem.Name = "TypeOfLeaveToolStripMenuItem"
        Me.TypeOfLeaveToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.TypeOfLeaveToolStripMenuItem.Text = "Type of Leaves"
        '
        'SalaryGradeToolStripMenuItem
        '
        Me.SalaryGradeToolStripMenuItem.Name = "SalaryGradeToolStripMenuItem"
        Me.SalaryGradeToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.SalaryGradeToolStripMenuItem.Text = "Salary Grade"
        '
        'HolidaysToolStripMenuItem
        '
        Me.HolidaysToolStripMenuItem.Name = "HolidaysToolStripMenuItem"
        Me.HolidaysToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.HolidaysToolStripMenuItem.Text = "Holidays"
        '
        'TimeSetupToolStripMenuItem
        '
        Me.TimeSetupToolStripMenuItem.Name = "TimeSetupToolStripMenuItem"
        Me.TimeSetupToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.TimeSetupToolStripMenuItem.Text = "Time Set-up"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(250, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'mnuTransaction
        '
        Me.mnuTransaction.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeInformationToolStripMenuItem, Me.TravelOrderToolStripMenuItem, Me.LeavesInfoToolStripMenuItem, Me.DTRToolStripMenuItem1})
        Me.mnuTransaction.Name = "mnuTransaction"
        Me.mnuTransaction.Size = New System.Drawing.Size(102, 25)
        Me.mnuTransaction.Text = "Transaction"
        '
        'EmployeeInformationToolStripMenuItem
        '
        Me.EmployeeInformationToolStripMenuItem.Name = "EmployeeInformationToolStripMenuItem"
        Me.EmployeeInformationToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.EmployeeInformationToolStripMenuItem.Text = "Employee Information"
        '
        'TravelOrderToolStripMenuItem
        '
        Me.TravelOrderToolStripMenuItem.Name = "TravelOrderToolStripMenuItem"
        Me.TravelOrderToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.TravelOrderToolStripMenuItem.Text = "Travel Order"
        '
        'LeavesInfoToolStripMenuItem
        '
        Me.LeavesInfoToolStripMenuItem.Name = "LeavesInfoToolStripMenuItem"
        Me.LeavesInfoToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.LeavesInfoToolStripMenuItem.Text = "Leave's Info"
        '
        'DTRToolStripMenuItem1
        '
        Me.DTRToolStripMenuItem1.Name = "DTRToolStripMenuItem1"
        Me.DTRToolStripMenuItem1.Size = New System.Drawing.Size(234, 26)
        Me.DTRToolStripMenuItem1.Text = "DTR Details"
        '
        'StatusStrip
        '
        Me.StatusStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 423)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(640, 30)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 25)
        Me.ToolStripStatusLabel.Text = "User"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.ToolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(118, 25)
        Me.ToolStripStatusLabel1.Text = "aaaaaaaaaaaaa"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(79, 25)
        Me.ToolStripStatusLabel2.Text = "User Type"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(166, 25)
        Me.ToolStripStatusLabel3.Text = "ToolStripStatusLabel3"
        '
        'ActivitiesToolStripMenuItem
        '
        Me.ActivitiesToolStripMenuItem.Name = "ActivitiesToolStripMenuItem"
        Me.ActivitiesToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.ActivitiesToolStripMenuItem.Text = "Activities"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMain"
        Me.Text = "BFAR-RFTC 02 AUTOMATED SYSTEM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuTransaction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TravelOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageDivisionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageDesignationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeavesInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DTRToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SalaryGradeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TypeOfLeaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HolidaysToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActivitiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
