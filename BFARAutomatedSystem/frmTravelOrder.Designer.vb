<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTravelOrder
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNameS = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtDateReturn = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtDateDep = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmpNo = New System.Windows.Forms.TextBox()
        Me.dtDateFilter = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvTO = New System.Windows.Forms.ListView()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ApproveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCopy = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNameS)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtDateReturn)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtDateDep)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtEmpNo)
        Me.GroupBox1.Controls.Add(Me.dtDateFilter)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lvTO)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 30)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1066, 401)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Travel Order Information"
        '
        'txtNameS
        '
        Me.txtNameS.Location = New System.Drawing.Point(73, 32)
        Me.txtNameS.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNameS.Name = "txtNameS"
        Me.txtNameS.Size = New System.Drawing.Size(260, 27)
        Me.txtNameS.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(800, 64)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Return"
        '
        'dtDateReturn
        '
        Me.dtDateReturn.CustomFormat = "MM/dd/yyyy"
        Me.dtDateReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateReturn.Location = New System.Drawing.Point(750, 32)
        Me.dtDateReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.dtDateReturn.Name = "dtDateReturn"
        Me.dtDateReturn.Size = New System.Drawing.Size(177, 27)
        Me.dtDateReturn.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(582, 64)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Departure"
        '
        'dtDateDep
        '
        Me.dtDateDep.CustomFormat = "MM/dd/yyyy"
        Me.dtDateDep.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateDep.Location = New System.Drawing.Point(548, 32)
        Me.dtDateDep.Margin = New System.Windows.Forms.Padding(4)
        Me.dtDateDep.Name = "dtDateDep"
        Me.dtDateDep.Size = New System.Drawing.Size(177, 27)
        Me.dtDateDep.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(353, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date Request"
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Location = New System.Drawing.Point(934, 32)
        Me.txtEmpNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(132, 27)
        Me.txtEmpNo.TabIndex = 3
        Me.txtEmpNo.Visible = False
        '
        'dtDateFilter
        '
        Me.dtDateFilter.CalendarFont = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateFilter.CustomFormat = "MM/dd/yyyy"
        Me.dtDateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateFilter.Location = New System.Drawing.Point(341, 32)
        Me.dtDateFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.dtDateFilter.Name = "dtDateFilter"
        Me.dtDateFilter.Size = New System.Drawing.Size(177, 27)
        Me.dtDateFilter.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Filter :"
        '
        'lvTO
        '
        Me.lvTO.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvTO.FullRowSelect = True
        Me.lvTO.GridLines = True
        Me.lvTO.Location = New System.Drawing.Point(12, 96)
        Me.lvTO.Margin = New System.Windows.Forms.Padding(4)
        Me.lvTO.Name = "lvTO"
        Me.lvTO.Size = New System.Drawing.Size(1046, 304)
        Me.lvTO.TabIndex = 0
        Me.lvTO.UseCompatibleStateImageBehavior = False
        Me.lvTO.View = System.Windows.Forms.View.Details
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(752, 438)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(93, 28)
        Me.cmdClose.TabIndex = 9
        Me.cmdClose.Text = "CLOSE"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Location = New System.Drawing.Point(251, 439)
        Me.cmdEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(93, 28)
        Me.cmdEdit.TabIndex = 7
        Me.cmdEdit.Text = "EDIT"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(153, 439)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(93, 28)
        Me.cmdAdd.TabIndex = 6
        Me.cmdAdd.Text = "ADD"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(17, 441)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(63, 22)
        Me.txtName.TabIndex = 10
        Me.txtName.Visible = False
        '
        'txtDesignation
        '
        Me.txtDesignation.Location = New System.Drawing.Point(89, 442)
        Me.txtDesignation.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(53, 22)
        Me.txtDesignation.TabIndex = 11
        Me.txtDesignation.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApproveToolStripMenuItem, Me.CancelToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(120, 48)
        '
        'ApproveToolStripMenuItem
        '
        Me.ApproveToolStripMenuItem.Name = "ApproveToolStripMenuItem"
        Me.ApproveToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ApproveToolStripMenuItem.Text = "Approve"
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        '
        'cmdCopy
        '
        Me.cmdCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCopy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCopy.Location = New System.Drawing.Point(447, 439)
        Me.cmdCopy.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.Size = New System.Drawing.Size(93, 28)
        Me.cmdCopy.TabIndex = 12
        Me.cmdCopy.Text = "COPY"
        Me.cmdCopy.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(545, 439)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 28)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "CANCEL T.O."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(655, 439)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(93, 28)
        Me.btnPrint.TabIndex = 14
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(348, 439)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(93, 28)
        Me.cmdDelete.TabIndex = 15
        Me.cmdDelete.Text = "DELETE"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'frmTravelOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1095, 477)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdCopy)
        Me.Controls.Add(Me.txtDesignation)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTravelOrder"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Travel Order Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lvTO As System.Windows.Forms.ListView
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents dtDateFilter As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmpNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtDateReturn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtDateDep As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ApproveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdCopy As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents txtNameS As System.Windows.Forms.TextBox
End Class
