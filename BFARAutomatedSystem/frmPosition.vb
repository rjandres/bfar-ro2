Imports MySql.Data.MySqlClient
Public Class frmPosition


    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim a As String
        If Len(txtHCode.Text) = 2 Then
            a = "0" & txtHCode.Text + 1
        ElseIf Len(txtHCode.Text) = 1 Then
            a = "00" & txtHCode.Text + 1
        Else
            a = txtHCode.Text
        End If
        frmAEPosition.txtCode.Text = a
        btnAction = 2
        frmAEPosition.ShowDialog()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If lvPosition.SelectedItems.Count <> 0 Then
            frmAEPosition.txtCode.Text = lvPosition.SelectedItems(0).SubItems(1).Text
            frmAEPosition.txtPosition.Text = lvPosition.SelectedItems(0).SubItems(2).Text
            btnAction = 1
            frmAEPosition.ShowDialog()
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
        callPosition()
    End Sub

    Public Sub callPosition()
        On Error Resume Next
        Dim i As Integer
        Dim strSQL As String
        Dim ds As New DataSet
        Dim dr As MySqlDataReader
        Dim cmd As New MySqlCommand


        strSQL = "SELECT * from tbl_positioncode order by position_code"
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()

        lvPosition.Items.Clear()
        Do While dr.Read()
            Dim lv As ListViewItem = lvPosition.Items.Add(dr.Item(0))
            lv.SubItems.Add(dr.Item(1))
            lv.SubItems.Add(dr.Item(2))
        Loop
        txtHCode.Text = Val(dr.Item(1))
        ds.Reset()
        CONNECTION.Close()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim sqlDel As String
        If MsgBox("Are you sure you want to delte this record", vbYesNo) = MsgBoxResult.Yes Then
            sqlDel = "DELETE from tbl_positioncode WHERE ctrno = '" & lvPosition.SelectedItems(0).Text & "'"
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
            callPosition()
        Else
            Exit Sub
        End If
    End Sub
End Class