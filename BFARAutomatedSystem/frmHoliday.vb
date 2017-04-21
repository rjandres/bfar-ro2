Imports MySql.Data.MySqlClient
Public Class frmHoliday

    Public Sub callHoliday()
        On Error Resume Next
        Dim strSQL As String
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader

        strSQL = "Select * from tbl_holiday order by HolidayDate"
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader
        lvHoliday.Items.Clear()
        Do While dr.Read()
            Dim lv As ListViewItem = lvHoliday.Items.Add(dr.Item(0))
            lv.SubItems.Add(dr.Item(3))
            lv.SubItems.Add(dr.Item(1))
            lv.SubItems.Add(dr.Item(2))
            lv.SubItems.Add(dr.Item(4))
            lv.SubItems.Add(dr.Item(5))
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


    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim strSQL As String
        If cmdAdd.Text = "Add" Then
            txtCTR.Text = ""
            dtHoliday.Value = Now
            txtHoliday.Text = ""
            txtDesc.Text = ""

            gbAdd.Enabled = True
            gbHoliday.Enabled = False
            cmdDelete.Enabled = False
            cmdClose.Enabled = False
            cmdAdd.Text = "Save"
            cmdEdit.Text = "Cancel"
            btnAction = 2
        ElseIf cmdAdd.Text = "Save" Then
            If txtHoliday.Text = "" Then
                MsgBox("Field is empty...")
                txtHoliday.Focus()
                Exit Sub
            End If
            If txtDesc.Text = "" Then
                MsgBox("Field is empty...")
                txtDesc.Focus()
                Exit Sub
            End If
            Dim stat, covered As String
            If chkStatus.Checked = True Then
                stat = "Yes"
                covered = "Whole"
            Else
                stat = "No"
                covered = cbCovered.Text
            End If

            If btnAction = 2 Then
                strSQL = "INSERT INTO tbl_holiday SET Holiday='" & txtHoliday.Text & _
                    "', HolidayDesc='" & txtDesc.Text & _
                    "', HolidayDate='" & dtHoliday.Text & _
                    "', Status='" & stat & _
                    "', Covered='" & covered & "'"
            ElseIf btnAction = 1 Then
                strSQL = "UPDATE tbl_holiday SET Holiday='" & txtHoliday.Text & _
                   "', HolidayDesc='" & txtDesc.Text & _
                   "', HolidayDate='" & dtHoliday.Text & _
                   "', Status='" & stat & _
                    "', Covered='" & covered & "' WHERE ctrno='" & txtCTR.Text & "'"
            End If
            CONNECTION.Open()
            Dim cmd As New MySqlCommand(strSQL, CONNECTION)
            Dim Count = cmd.ExecuteNonQuery
            If Count = 0 Then
                MsgBox("Record canceled")
                CONNECTION.Close()
                Exit Sub
            Else
                MsgBox("Record Saved")
            End If

            gbAdd.Enabled = False
            gbHoliday.Enabled = True
            cmdDelete.Enabled = True
            cmdClose.Enabled = True
            cmdAdd.Text = "Add"
            cmdEdit.Text = "Edit"
            btnAction = 0
        End If
        CONNECTION.Close()
        callHoliday()
    End Sub

    Private Sub lvHoliday_KeyDown(sender As Object, e As KeyEventArgs) Handles lvHoliday.KeyDown
        On Error Resume Next
        txtCTR.Text = lvHoliday.SelectedItems(0).Text
        dtHoliday.Value = lvHoliday.SelectedItems(0).SubItems(1).Text
        txtHoliday.Text = lvHoliday.SelectedItems(0).SubItems(2).Text
        txtDesc.Text = lvHoliday.SelectedItems(0).SubItems(3).Text
        If lvHoliday.SelectedItems(0).SubItems(4).Text = "Yes" Then
            chkStatus.Checked = True
            cbCovered.Enabled = False
            cbCovered.Text = ""
        Else
            chkStatus.Checked = False
            cbCovered.Enabled = True
            cbCovered.Text = lvHoliday.SelectedItems(0).SubItems(5).Text
        End If

    End Sub

    Private Sub lvHoliday_KeyUp(sender As Object, e As KeyEventArgs) Handles lvHoliday.KeyUp
        On Error Resume Next
        txtCTR.Text = lvHoliday.SelectedItems(0).Text
        dtHoliday.Value = lvHoliday.SelectedItems(0).SubItems(1).Text
        txtHoliday.Text = lvHoliday.SelectedItems(0).SubItems(2).Text
        txtDesc.Text = lvHoliday.SelectedItems(0).SubItems(3).Text
        If lvHoliday.SelectedItems(0).SubItems(4).Text = "Yes" Then
            chkStatus.Checked = True
            cbCovered.Enabled = False
            cbCovered.Text = ""
        Else
            chkStatus.Checked = False
            cbCovered.Enabled = True
            cbCovered.Text = lvHoliday.SelectedItems(0).SubItems(5).Text
        End If
    End Sub

   

    Private Sub lvHoliday_MouseClick(sender As Object, e As MouseEventArgs) Handles lvHoliday.MouseClick
        On Error Resume Next
        txtCTR.Text = lvHoliday.SelectedItems(0).Text
        dtHoliday.Value = lvHoliday.SelectedItems(0).SubItems(1).Text
        txtHoliday.Text = lvHoliday.SelectedItems(0).SubItems(2).Text
        txtDesc.Text = lvHoliday.SelectedItems(0).SubItems(3).Text
        If lvHoliday.SelectedItems(0).SubItems(4).Text = "Yes" Then
            chkStatus.Checked = True
            cbCovered.Enabled = False
            cbCovered.Text = ""
        Else
            chkStatus.Checked = False
            cbCovered.Enabled = True
            cbCovered.Text = lvHoliday.SelectedItems(0).SubItems(5).Text
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
       
        If cmdAdd.Text = "Add" Then
            If lvHoliday.SelectedItems.Count = 0 Then
                MsgBox("Please select holiday")
                Exit Sub
            End If

            gbAdd.Enabled = True
            gbHoliday.Enabled = False
            cmdDelete.Enabled = False
            cmdClose.Enabled = False
            cmdAdd.Text = "Save"
            cmdEdit.Text = "Cancel"
            btnAction = 1
        ElseIf cmdAdd.Text = "Save" Then

            gbAdd.Enabled = False
            gbHoliday.Enabled = True
            cmdDelete.Enabled = True
            cmdClose.Enabled = True
            cmdAdd.Text = "Add"
            cmdEdit.Text = "Edit"
            btnAction = 0

        End If
    End Sub

    Private Sub frmHoliday_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        callHoliday()
    End Sub

    Private Sub chkStatus_CheckedChanged(sender As Object, e As EventArgs) Handles chkStatus.CheckedChanged
        If chkStatus.Checked = True Then
            cbCovered.Enabled = False
        Else
            cbCovered.Enabled = True
        End If
    End Sub
End Class