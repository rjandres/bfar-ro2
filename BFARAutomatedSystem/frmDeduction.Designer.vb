<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeduction
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lvDeduction = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ctrn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.lvDeduction)
        Me.GroupBox1.Location = New System.Drawing.Point(359, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 624)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(187, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(78, 26)
        Me.TextBox1.TabIndex = 1
        '
        'lvDeduction
        '
        Me.lvDeduction.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.ctrn, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvDeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDeduction.FullRowSelect = True
        Me.lvDeduction.Location = New System.Drawing.Point(6, 19)
        Me.lvDeduction.Name = "lvDeduction"
        Me.lvDeduction.Size = New System.Drawing.Size(316, 599)
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
        'ColumnHeader1
        '
        Me.ColumnHeader1.DisplayIndex = 1
        Me.ColumnHeader1.Text = "Deduction Type"
        Me.ColumnHeader1.Width = 180
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.DisplayIndex = 2
        Me.ColumnHeader2.Text = "Amount"
        Me.ColumnHeader2.Width = 100
        '
        'frmDeduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(699, 648)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDeduction"
        Me.Text = "frmDeduction"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lvDeduction As System.Windows.Forms.ListView
    Friend WithEvents ctrn As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
