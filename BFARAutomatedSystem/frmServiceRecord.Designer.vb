<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServiceRecord
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lvWorkExp = New System.Windows.Forms.ListView()
        Me.ColumnHeader30 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader51 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button16 = New System.Windows.Forms.Button()
        Me.cmdWorkUpdateCancel = New System.Windows.Forms.Button()
        Me.cmdWorkAddSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button16)
        Me.Panel1.Controls.Add(Me.cmdWorkUpdateCancel)
        Me.Panel1.Controls.Add(Me.cmdWorkAddSave)
        Me.Panel1.Location = New System.Drawing.Point(17, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(982, 68)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lvWorkExp)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(981, 519)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lvWorkExp
        '
        Me.lvWorkExp.AllowColumnReorder = True
        Me.lvWorkExp.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lvWorkExp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader30, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader1, Me.ColumnHeader19, Me.ColumnHeader2, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader51})
        Me.lvWorkExp.Dock = System.Windows.Forms.DockStyle.Top
        Me.lvWorkExp.FullRowSelect = True
        Me.lvWorkExp.GridLines = True
        Me.lvWorkExp.Location = New System.Drawing.Point(3, 17)
        Me.lvWorkExp.Margin = New System.Windows.Forms.Padding(4)
        Me.lvWorkExp.Name = "lvWorkExp"
        Me.lvWorkExp.Size = New System.Drawing.Size(975, 495)
        Me.lvWorkExp.TabIndex = 1
        Me.lvWorkExp.UseCompatibleStateImageBehavior = False
        Me.lvWorkExp.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Text = "Emp No"
        Me.ColumnHeader30.Width = 0
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "FROM"
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "TO"
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "POSITION TITLE"
        Me.ColumnHeader17.Width = 180
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "AGENCY"
        Me.ColumnHeader18.Width = 180
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "BRANCH"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "MONTHLY SALARY"
        Me.ColumnHeader19.Width = 95
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ANNUAL SALARY"
        Me.ColumnHeader2.Width = 95
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "SG & SI"
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "STATUS"
        Me.ColumnHeader21.Width = 80
        '
        'ColumnHeader51
        '
        Me.ColumnHeader51.Width = 0
        '
        'Button16
        '
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(760, 25)
        Me.Button16.Margin = New System.Windows.Forms.Padding(4)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(88, 26)
        Me.Button16.TabIndex = 19
        Me.Button16.Text = "DELETE"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'cmdWorkUpdateCancel
        '
        Me.cmdWorkUpdateCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdWorkUpdateCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWorkUpdateCancel.Location = New System.Drawing.Point(666, 25)
        Me.cmdWorkUpdateCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdWorkUpdateCancel.Name = "cmdWorkUpdateCancel"
        Me.cmdWorkUpdateCancel.Size = New System.Drawing.Size(88, 26)
        Me.cmdWorkUpdateCancel.TabIndex = 18
        Me.cmdWorkUpdateCancel.Text = "UPDATE"
        Me.cmdWorkUpdateCancel.UseVisualStyleBackColor = True
        '
        'cmdWorkAddSave
        '
        Me.cmdWorkAddSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdWorkAddSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWorkAddSave.Location = New System.Drawing.Point(572, 25)
        Me.cmdWorkAddSave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdWorkAddSave.Name = "cmdWorkAddSave"
        Me.cmdWorkAddSave.Size = New System.Drawing.Size(88, 26)
        Me.cmdWorkAddSave.TabIndex = 17
        Me.cmdWorkAddSave.Text = "ADD"
        Me.cmdWorkAddSave.UseVisualStyleBackColor = True
        '
        'frmServiceRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1013, 636)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "frmServiceRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Service Record"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lvWorkExp As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader30 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader51 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents cmdWorkUpdateCancel As System.Windows.Forms.Button
    Friend WithEvents cmdWorkAddSave As System.Windows.Forms.Button
End Class
