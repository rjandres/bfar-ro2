Imports MySql.Data.MySqlClient
Public Class frmDivHead

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim a As String
        If Len(txtHCode.Text) = 2 Then
            a = "0" & txtHCode.Text + 1
        ElseIf Len(txtHCode.Text) = 1 Then
            a = "00" & txtHCode.Text + 1
        Else
            a = txtHCode.Text
        End If
        frmAEDivHead.txtCode.Text = a
        btnAction = 2
        frmAEDivHead.ShowDialog()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If lvDiv.SelectedItems.Count <> 0 Then
            frmAEDivHead.txtCTRNo.Text = lvDiv.SelectedItems(0).Text
            frmAEDivHead.txtCode.Text = lvDiv.SelectedItems(0).SubItems(1).Text
            frmAEDivHead.txtDiv.Text = lvDiv.SelectedItems(0).SubItems(2).Text
            frmAEDivHead.txtOIC.Text = lvDiv.SelectedItems(0).SubItems(3).Text
            frmAEDivHead.txtEmpNo.Text = lvDiv.SelectedItems(0).SubItems(4).Text
            btnAction = 1
            frmAEDivHead.ShowDialog()
        Else
            MsgBox("Please select Position to update.", vbInformation)
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        frmMain.UnlockMenu()
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub frmPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        callDivision()
    End Sub

    Public Sub callDivision()
        On Error Resume Next
        Dim i As Integer
        Dim strSQL As String
        Dim ds As New DataSet
        Dim dr As MySqlDataReader
        Dim cmd As New MySqlCommand

        strSQL = "SELECT * from tbl_divoffcode order by code"
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()

        lvDiv.Items.Clear()
        Do While dr.Read()
            Dim lv As ListViewItem = lvDiv.Items.Add(dr.Item(0))
            lv.SubItems.Add(dr.Item(1))
            lv.SubItems.Add(dr.Item(2))
            lv.SubItems.Add(dr.Item(3))
            lv.SubItems.Add(dr.Item(4))
        Loop
        txtHCode.Text = Val(dr.Item(1))
        ds.Reset()
        CONNECTION.Close()
    End Sub


    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim sqlDel As String
        If MsgBox("Are you sure you want to delte this record", vbYesNo) = MsgBoxResult.Yes Then
            sqlDel = "DELETE from tbl_divoffcode WHERE ctrno = '" & lvDiv.SelectedItems(0).Text & "'"
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
            callDivision()
        Else
            Exit Sub
        End If
    End Sub
End Class