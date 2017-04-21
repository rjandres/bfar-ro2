Imports MySql.Data.MySqlClient
Public Class frmDesignationUnit
    Dim strSQL As String
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        frmMain.UnlockMenu()
        Me.Dispose()
        Me.Close()
    End Sub

    Public Sub callUnit()
        On Error Resume Next
        Dim dr As MySqlDataReader
        Dim cmd As New MySqlCommand

        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()

        lvUnit.Items.Clear()
        Do While dr.Read()
            Dim lv As ListViewItem = lvUnit.Items.Add(dr.Item(0))
            lv.SubItems.Add(dr.Item(1))
            lv.SubItems.Add(dr.Item(2))
            lv.SubItems.Add(dr.Item(3))
            lv.SubItems.Add(dr.Item(4))
            lv.SubItems.Add(dr.Item(5))
            lv.SubItems.Add(dr.Item(6))
            lv.SubItems.Add(dr.Item(7))
        Loop
        cmd.Dispose()
        dr.Close()
        CONNECTION.Close()
    End Sub
    Public Sub callUnitCombo()
        On Error Resume Next
        Dim strSQLCombo As String
        Dim dr As MySqlDataReader
        Dim cmd As New MySqlCommand

        strSQLCombo = "SELECT * from tbl_divoffcode order by id"
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQLCombo, CONNECTION)
        dr = cmd.ExecuteReader()

        cbUnit.Items.Clear()
        'tscbDesignation.Items.Clear()
        Do While dr.Read()
            cbUnit.Items.Add(dr.Item(2))
            'tscbDesignation.Items.Add(dr.Item(2))
        Loop
        dr.Close()
        CONNECTION.Close()
    End Sub
    Public Sub callDivCode()
        On Error Resume Next
        Dim strSQL As String

        Dim dr As MySqlDataReader
        Dim cmd As New MySqlCommand

        strSQL = "SELECT * from tbl_divoffcode Where description='" & cbUnit.Text & "' order by id"
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()

        Do While dr.Read()
            frmAEDU.txtDivCode.Text = dr.Item(1)
        Loop
        dr.Close()
        CONNECTION.Close()
    End Sub
    Public Sub SaveMove()
        On Error Resume Next
        Dim strSQL As String

        Dim dr As MySqlDataReader
        Dim cmd As New MySqlCommand
        Dim DCode, DDesc, DCtrl As String

        strSQL = "SELECT * from tbl_divoffcode Where description='" & TextBox1.Text & "' order by id"
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()

        Do While dr.Read()
            DCode = dr.Item(1)
            DDesc = dr.Item(2)
        Loop
        dr.Close()
        CONNECTION.Close()
        DCtrl = lvUnit.SelectedItems(0).Text

        
        strSQL = "UPDATE tbl_divassigned SET DivCode = '" & DCode & _
                 "', DivDesc='" & DDesc & "' WHERE ctrno = '" & DCtrl & "'"

        CONNECTION.Open()
        Dim SqlCommand As New MySqlCommand
        Dim Count As Integer
        SqlCommand.Connection = CONNECTION
        SqlCommand.CommandText = strSQL

        Count = SqlCommand.ExecuteNonQuery()
        If Count = 0 Then
            MsgBox("No record found")
            'Exit Sub
        Else
            MsgBox("Records updated")
        End If
        btnAction = 0

        SqlCommand.Dispose()
        CONNECTION.Close()
        callUnit()
    End Sub

    Private Sub frmDesignationUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdAdd.Enabled = False
        strSQL = "SELECT * from tbl_divassigned order by AssignedTask"
        callUnitCombo()
        callUnit()
        callForMenu()
    End Sub

    Private Sub cbUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUnit.SelectedIndexChanged
        strSQL = "SELECT * from tbl_divassigned where DivDesc='" & cbUnit.Text & "' order by AssignedTask"
        callUnit()
        cmdAdd.Enabled = True
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        callDivCode()
        frmAEDU.txtDiv.Text = cbUnit.Text
        btnAction = 2
        frmAEDU.ShowDialog()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If lvUnit.SelectedItems.Count <> 0 Then
            frmAEDU.txtCTRNo.Text = lvUnit.SelectedItems(0).Text
            frmAEDU.txtDivCode.Text = lvUnit.SelectedItems(0).SubItems(1).Text
            frmAEDU.txtDiv.Text = lvUnit.SelectedItems(0).SubItems(2).Text
     
            frmAEDU.txtEmpNo.Text = lvUnit.SelectedItems(0).SubItems(3).Text
            frmAEDU.txtName.Text = lvUnit.SelectedItems(0).SubItems(4).Text
            frmAEDU.txtTask.Text = lvUnit.SelectedItems(0).SubItems(5).Text
            frmAEDU.txtDesc.Text = lvUnit.SelectedItems(0).SubItems(6).Text
            frmAEDU.txtPercent.Text = lvUnit.SelectedItems(0).SubItems(7).Text
            btnAction = 1
            frmAEDU.ShowDialog()
        Else
            MsgBox("Please select Travel Order to be edit!!!", vbInformation)
        End If
    End Sub

    Private Sub lvUnit_MouseClick(sender As Object, e As MouseEventArgs) Handles lvUnit.MouseClick
        If e.Button = MouseButtons.Right Then
            If lvUnit.FocusedItem.Bounds.Contains(e.Location) = True Then
                ContextMenuStrip1.Show(Cursor.Position)
            End If
        End If
    End Sub
    Private Sub lvUnit_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvUnit.MouseDoubleClick
        cmdEdit.PerformClick()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim sqlDel As String
        If MsgBox("Are you sure you want to delte this record", vbYesNo) = MsgBoxResult.Yes Then
            sqlDel = "DELETE from tbl_divassigned WHERE ctrno = '" & lvUnit.SelectedItems(0).Text & "'"
            CONNECTION.Open()

            Dim cmd = New MySqlCommand(sqlDel, CONNECTION)
            Dim Count As Integer

            Count = cmd.ExecuteNonQuery()
            If Count = 0 Then
                MsgBox("Delete Cancel")
                CONNECTION.Close()
                Exit Sub
            Else
                MsgBox("Record Deleted")

            End If
            CONNECTION.Close()
            callDivCode()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub lvUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvUnit.SelectedIndexChanged

    End Sub

    Private Sub callForMenu()
        Dim i As Integer
        On Error Resume Next
        Dim strSQLCombo As String
        Dim dr As MySqlDataReader
        Dim cmd As New MySqlCommand

        strSQLCombo = "SELECT * from tbl_divoffcode order by id"
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQLCombo, CONNECTION)
        dr = cmd.ExecuteReader()

        MoveToolStripMenuItem.DropDown.Items.Clear()
        Do While dr.Read()
 
            Dim myMenuItem As New ToolStripMenuItem

            ' Create a new submenu item
            ' Get the submenu item number from the menu item itself
            i = Me.MoveToolStripMenuItem.DropDownItems.Count + 1

            ' Set up the label and set the tag to a value that the handler can use
            myMenuItem.Text = dr.Item(2)
            myMenuItem.Tag = i
            AddHandler myMenuItem.Click, AddressOf Me.myPrivateMenuItemHandler

            Me.MoveToolStripMenuItem.DropDownItems.Add(myMenuItem)

        Loop
        dr.Close()
        CONNECTION.Close()

    End Sub     ' miAddItem_Click

    Private Sub myPrivateMenuItemHandler(ByVal sender As Object, ByVal e As EventArgs)
        Dim i As Integer
        Dim myItem As ToolStripMenuItem

        ' Extract the tag value from the item received.
        myItem = CType(sender, ToolStripMenuItem)
        i = CInt(myItem.Tag)
        TextBox1.Text = myItem.Text
        SaveMove()
        ' Display the item number as the last item seen.
        'Me.txtLastItemViewed.Text = i.ToString

    End Sub     ' myPrivateMenuItemHandler

    Private Sub mySpecialMenuItemHandler(ByVal sender As Object, ByVal e As EventArgs)

        ' Flag the checkbox
        'Me.cbxItem3Seen.Checked = True
        'Me.cbxItem3Seen.BackColor = Color.LightCyan

    End Sub
End Class