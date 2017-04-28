<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeductionType
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
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.gbDetails = New System.Windows.Forms.GroupBox()
        Me.lvDeduct = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Agency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.gbAdd = New System.Windows.Forms.GroupBox()
        Me.txtAgency = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.gbDetails.SuspendLayout()
        Me.gbAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAdd
        '
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.Location = New System.Drawing.Point(37, 247)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(72, 31)
        Me.cmdAdd.TabIndex = 0
        Me.cmdAdd.Text = "ADD"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'gbDetails
        '
        Me.gbDetails.Controls.Add(Me.lvDeduct)
        Me.gbDetails.Location = New System.Drawing.Point(37, 21)
        Me.gbDetails.Name = "gbDetails"
        Me.gbDetails.Size = New System.Drawing.Size(605, 220)
        Me.gbDetails.TabIndex = 1
        Me.gbDetails.TabStop = False
        Me.gbDetails.Text = "Deduction Type Details"
        '
        'lvDeduct
        '
        Me.lvDeduct.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Type, Me.Agency})
        Me.lvDeduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDeduct.FullRowSelect = True
        Me.lvDeduct.Location = New System.Drawing.Point(13, 21)
        Me.lvDeduct.Name = "lvDeduct"
        Me.lvDeduct.Size = New System.Drawing.Size(579, 188)
        Me.lvDeduct.TabIndex = 0
        Me.lvDeduct.UseCompatibleStateImageBehavior = False
        Me.lvDeduct.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Width = 0
        '
        'Type
        '
        Me.Type.Text = "Type"
        Me.Type.Width = 150
        '
        'Agency
        '
        Me.Agency.Text = "Agency"
        Me.Agency.Width = 150
        '
        'cmdEdit
        '
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEdit.Location = New System.Drawing.Point(115, 247)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(72, 31)
        Me.cmdEdit.TabIndex = 2
        Me.cmdEdit.Text = "EDIT"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Location = New System.Drawing.Point(570, 247)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(72, 31)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "CLOSE"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'gbAdd
        '
        Me.gbAdd.Controls.Add(Me.txtAgency)
        Me.gbAdd.Controls.Add(Me.txtType)
        Me.gbAdd.Controls.Add(Me.Label2)
        Me.gbAdd.Controls.Add(Me.Label1)
        Me.gbAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAdd.Location = New System.Drawing.Point(177, 24)
        Me.gbAdd.Name = "gbAdd"
        Me.gbAdd.Size = New System.Drawing.Size(376, 159)
        Me.gbAdd.TabIndex = 4
        Me.gbAdd.TabStop = False
        Me.gbAdd.Visible = False
        '
        'txtAgency
        '
        Me.txtAgency.Location = New System.Drawing.Point(18, 100)
        Me.txtAgency.Name = "txtAgency"
        Me.txtAgency.Size = New System.Drawing.Size(352, 23)
        Me.txtAgency.TabIndex = 3
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(18, 41)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(352, 23)
        Me.txtType.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Agency"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type of Deduction"
        '
        'cmdDelete
        '
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Location = New System.Drawing.Point(195, 247)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(72, 31)
        Me.cmdDelete.TabIndex = 5
        Me.cmdDelete.Text = " DELETE"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(310, 248)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(92, 20)
        Me.txtCode.TabIndex = 6
        '
        'frmDeductionType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(682, 285)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.gbAdd)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.gbDetails)
        Me.Controls.Add(Me.cmdAdd)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "frmDeductionType"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deduction Type"
        Me.gbDetails.ResumeLayout(False)
        Me.gbAdd.ResumeLayout(False)
        Me.gbAdd.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents gbDetails As System.Windows.Forms.GroupBox
    Friend WithEvents gbAdd As System.Windows.Forms.GroupBox
    Friend WithEvents txtAgency As System.Windows.Forms.TextBox
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvDeduct As System.Windows.Forms.ListView
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Type As System.Windows.Forms.ColumnHeader
    Friend WithEvents Agency As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
End Class
