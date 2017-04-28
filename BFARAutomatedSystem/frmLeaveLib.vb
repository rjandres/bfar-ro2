Imports MySql.Data.MySqlClient
Public Class frmLeaveLib

    Private Sub frmLeaveLib_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        callLeave()
    End Sub

    Private Sub callLeave()
        On Error Resume Next
        Dim strSQL As String
        Dim dr As MySqlDataReader

        strSQL = "Select * from tbl_leave Order by ctrno"
        CONNECTION.Open()

        Dim cmd As New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()
        lvLeave.Items.Clear()
        Do While dr.Read()
            Dim lv As ListViewItem = lvLeave.Items.Add(dr.Item(0))
            lv.SubItems.Add(dr.Item(1))
            lv.SubItems.Add(dr.Item(2))
        Loop
        dr.Close()
        cmd.Dispose()
        CONNECTION.Close()
    End Sub
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        frmMain.UnlockMenu()
        Me.Dispose()
        Me.Close()
    End Sub
    Private Sub lvLeave_MouseClick(sender As Object, e As MouseEventArgs) Handles lvLeave.MouseClick
        On Error Resume Next
        txtCTR.Text = lvLeave.SelectedItems(0).Text.ToString
        txtLeave.Text = lvLeave.SelectedItems(0).SubItems(1).Text.ToString
        txtDesc.Text = lvLeave.SelectedItems(0).SubItems(2).Text.ToString
    End Sub
    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim strSQL As String
        If cmdAdd.Text = "Add" Then
            txtLeave.Text = ""
            txtDesc.Text = ""
            txtCTR.Text = ""
            txtLeave.ReadOnly = False
            txtDesc.ReadOnly = False
            cmdAdd.Text = "Save"
            cmdEdit.Text = "Cancel"
            cmdDelete.Enabled = False
            lvLeave.Enabled = False
            cmdClose.Enabled = False
            btnAction = 2
        ElseIf cmdAdd.Text = "Save" Then
            If txtLeave.Text = "" Then
                MsgBox("Field is empty")
                txtLeave.Focus()
                Exit Sub
            End If
            If txtDesc.Text = "" Then
                MsgBox("Field is empty")
                txtDesc.Focus()
                Exit Sub
            End If

            If btnAction = 2 Then
                strSQL = "INSERT INTO tbl_leave SET leaves='" & txtLeave.Text & "', Description='" & txtDesc.Text & "'"
            ElseIf btnAction = 1 Then
                strSQL = "UPDATE tbl_leave SET leaves='" & txtLeave.Text & "', Description='" & txtDesc.Text & "' WHERE ctrno='" & txtCTR.Text & "'"
            End If
            CONNECTION.Open()

            Dim cmd = New MySqlCommand(strSQL, CONNECTION)
            Dim Count As Integer

            Count = cmd.ExecuteNonQuery()
            If Count = 0 Then
                MsgBox("dsfhjhfdkkjfdjkgjkdfk")
                Exit Sub
            Else
                MsgBox("Record Updated")
            End If
            txtLeave.ReadOnly = True
            txtDesc.ReadOnly = True

            cmdAdd.Text = "Add"
            cmdEdit.Text = "Edit"
            cmdDelete.Enabled = True
            lvLeave.Enabled = True
            cmdClose.Enabled = True
            txtLeave.Text = ""
            txtDesc.Text = ""
            txtCTR.Text = ""

            btnAction = 0
            CONNECTION.Close()
            callLeave()
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If cmdEdit.Text = "Edit" Then
            txtLeave.ReadOnly = False
            txtDesc.ReadOnly = False
            cmdAdd.Text = "Save"
            cmdEdit.Text = "Cancel"
            cmdDelete.Enabled = False
            lvLeave.Enabled = False
            cmdClose.Enabled = False
            btnAction = 1
        ElseIf cmdEdit.Text = "Cancel" Then
            txtLeave.ReadOnly = True
            txtDesc.ReadOnly = True
            cmdAdd.Text = "Add"
            cmdEdit.Text = "Edit"
            cmdDelete.Enabled = True
            lvLeave.Enabled = True
            cmdClose.Enabled = True
            txtLeave.Text = ""
            txtDesc.Text = ""
            txtCTR.Text = ""
            btnAction = 0
        End If
    End Sub

    Private Sub lvLeave_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvLeave.MouseDoubleClick
        cmdEdit.PerformClick()
    End Sub
End Class
