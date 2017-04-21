Imports MySql.Data.MySqlClient
Public Class frmUnits

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
        If lvPosition.SelectedItems.Count <> 0 Then
            frmAEDivHead.txtCode.Text = lvPosition.SelectedItems(0).SubItems(1).Text
            frmAEDivHead.txtName.Text = lvPosition.SelectedItems(0).SubItems(2).Text
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


        strSQL = "SELECT * from tbl_divisioncode order by divcode"
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()

        lvPosition.Items.Clear()
        Do While dr.Read()
            Dim lv As ListViewItem = lvPosition.Items.Add(dr.Item(0))
            lv.SubItems.Add(dr.Item(1))
            lv.SubItems.Add(dr.Item(2))
            lv.SubItems.Add(dr.Item(3))
        Loop
        txtHCode.Text = Val(dr.Item(1))
        ds.Reset()
        CONNECTION.Close()
    End Sub

End Class