Imports MySql.Data.MySqlClient

Public Class frmLeave
    Dim strSQL As String

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        SearchAction = "Leave"
        frmEmployee.ShowDialog()
    End Sub

    Private Sub frmLeave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TOAction = "All" Then
            strSQL = "Select * from tblleave order by ctrno"
            cmdSearch.Enabled = True
        ElseIf TOAction = "Single" Then
            strSQL = "Select * from tblleave  Where EmpNo ='" & txtEmpNo.Text & "'order by ctrno"
            cmdSearch.Enabled = False
        End If
        lvAddCol()
        callLeaveData()
        callLeave()

    End Sub

    Public Sub callLeave()
        On Error Resume Next
        Dim strLeave As String

        Dim dr As MySqlDataReader
        Dim cmd As New MySqlCommand

        strLeave = "SELECT * from tbl_leave"
        CONNECTION.Open()
        cmd = New MySqlCommand(strLeave, CONNECTION)
        dr = cmd.ExecuteReader()
        cbLeave.Items.Clear()
        Do While dr.Read()
            cbLeave.Items.Add(dr.Item(2))
        Loop
        dr.Close()
        CONNECTION.Close()
    End Sub

    Private Sub callLeaveData()
        'On Error Resume Next
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()

        lvLeave.Items.Clear()
        Do While dr.Read()
            Dim lv As ListViewItem = lvLeave.Items.Add(dr.Item(0))
            lv.SubItems.Add(dr.Item(1))
            lv.SubItems.Add(dr.Item(2))
            lv.SubItems.Add(dr.Item(6))
            lv.SubItems.Add(dr.Item(7))
            lv.SubItems.Add(dr.Item(3))
            lv.SubItems.Add(dr.Item(4))
            lv.SubItems.Add(dr.Item(5))
        Loop
        CONNECTION.Close()
    End Sub
    Private Sub lvAddCol()
        lvLeave.Columns.Clear()
        If TOAction = "All" Then
            lvLeave.Columns.Add("ctrlno", 0)
            lvLeave.Columns.Add("Emp No", 0)
            lvLeave.Columns.Add("Employee Name", 200)
            lvLeave.Columns.Add("Type of Leave", 200)
            lvLeave.Columns.Add("Description", 250)
            lvLeave.Columns.Add("Start", 100)
            lvLeave.Columns.Add("End", 100)
            lvLeave.Columns.Add("Days", 50)
        Else
            lvLeave.Columns.Add("ctrlno", 0)
            lvLeave.Columns.Add("Emp No", 0)
            lvLeave.Columns.Add("Employee Name", 0)
            lvLeave.Columns.Add("Type of Leave", 200)
            lvLeave.Columns.Add("Description", 250)
            lvLeave.Columns.Add("Start", 100)
            lvLeave.Columns.Add("End", 100)
            lvLeave.Columns.Add("Days", 50)
        End If

    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim sqlSave As String
        If cmdAdd.Text = "Add" Then
            cbLeave.Text = ""
            txtDesc.Text = ""
            cbStart.Text = "AM"
            cbEnd.Text = "PM"
            'txtNum.Text = DateDiff(DateInterval.Hour, dtS.Value, dtE.Value) + 4
            gbAddEdit.Enabled = True
            cmdAdd.Text = "Save"
            cmdEdit.Text = "Cancel"
            btnAction = 2
        ElseIf cmdAdd.Text = "Save" Then

            If txtName.Text = "" Then
                MsgBox("Field is empty")
                txtName.Focus()
                Exit Sub
            End If
            If cbLeave.Text = "" Then
                MsgBox("Field is empty")
                cbLeave.Focus()
                Exit Sub
            End If
            If txtDesc.Text = "" Then
                MsgBox("Field is empty")
                txtDesc.Focus()
                Exit Sub
            End If

            If btnAction = 2 Then
                sqlSave = "INSERT INTO tblleave SET EmpNo='" & txtEmpNo.Text & _
                "', EmpName='" & txtName.Text & _
                "', TypeofLeave='" & cbLeave.Text & _
                "', DescriptionOfLeave='" & txtDesc.Text & _
                "', DateStart='" & DateTime.Parse(dtS.Text).ToString("yyyy-MM-dd HH:mm") & _
                "', DateEnd='" & DateTime.Parse(dtE.Text).ToString("yyyy-MM-dd HH:mm") & _
                "', NumDays='" & txtNum.Text & "'"
            ElseIf btnAction = 1 Then
                sqlSave = "UPDATE tblleave SET EmpNo='" & txtEmpNo.Text & _
                "', EmpName='" & txtName.Text & _
                "', TypeofLeave='" & cbLeave.Text & _
                "', DescriptionOfLeave='" & txtDesc.Text & _
                "', DateStart='" & DateTime.Parse(dtS.Text).ToString("yyyy-MM-dd HH:mm") & _
                "', DateEnd='" & DateTime.Parse(dtE.Text).ToString("yyyy-MM-dd HH:mm") & _
                "', NumDays='" & txtNum.Text & "' WHERE ctrno='" & txtCTR.Text & "'"
            End If
            CONNECTION.Open()

            Dim cmd = New MySqlCommand(sqlSave, CONNECTION)
            Dim Count As Integer

            Count = cmd.ExecuteNonQuery()
            If Count = 0 Then
                MsgBox("Updated Cancel")
                CONNECTION.Close()
                Exit Sub
            Else
                MsgBox("Record Updated")

            End If
            gbAddEdit.Enabled = False
            cmdAdd.Text = "Add"
            cmdEdit.Text = "Edit"
        End If
        CONNECTION.Close()
        callLeaveData()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If cmdAdd.Text = "Add" Then
            If lvLeave.SelectedItems.Count = 0 Then
                Exit Sub
            End If
            gbAddEdit.Enabled = True
            cmdAdd.Text = "Save"
            cmdEdit.Text = "Cancel"
            btnAction = 1
        ElseIf cmdAdd.Text = "Save" Then

            gbAddEdit.Enabled = False
            cmdAdd.Text = "Add"
            cmdEdit.Text = "Edit"
        End If
    End Sub

    'Private Sub dtS_MouseLeave(sender As Object, e As EventArgs) Handles dtS.MouseLeave
    '    If cbStart.Text = "AM" And cbEnd.Text = "PM" Then
    '        dtS.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 8:00")
    '        dtE.Value = Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 17:00")
    '    ElseIf cbStart.Text = "AM" And cbEnd.Text = "AM" Then
    '        dtS.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 8:00")
    '        dtE.Value = Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 12:00")
    '    ElseIf cbStart.Text = "PM" And cbEnd.Text = "PM" Then
    '        dtS.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 13:00")
    '        dtE.Value = Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 17:00")
    '    ElseIf cbStart.Text = "PM" And cbEnd.Text = "AM" Then
    '        dtS.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 13:00")

    '        If DateDiff(DateInterval.Hour, Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 13:00"), Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 12:00")) <= 0 Then
    '            dtE.Value = Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 12:00").AddDays(1)
    '        Else
    '            dtE.Value = Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 12:00")
    '        End If

    '    End If
    '    If DateDiff(DateInterval.Hour, dtS.Value, dtE.Value) > 4 And DateDiff(DateInterval.Hour, dtS.Value, dtE.Value) <= 9 Then
    '        txtNum.Text = DateDiff(DateInterval.Hour, dtS.Value, dtE.Value) - 1
    '    Else
    '        txtNum.Text = DateDiff(DateInterval.Hour, dtS.Value, dtE.Value)
    '    End If
    'End Sub

    'Private Sub dtS_TextChanged(sender As Object, e As EventArgs) Handles dtS.TextChanged
    '    If cbStart.Text = "AM" And cbEnd.Text = "PM" Then
    '        dtS.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 8:00")
    '        dtE.Value = Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 17:00")
    '    ElseIf cbStart.Text = "AM" And cbEnd.Text = "AM" Then
    '        dtS.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 8:00")
    '        dtE.Value = Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 12:00")
    '    ElseIf cbStart.Text = "PM" And cbEnd.Text = "PM" Then
    '        dtS.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 13:00")
    '        dtE.Value = Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 17:00")
    '    ElseIf cbStart.Text = "PM" And cbEnd.Text = "AM" Then
    '        dtS.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 13:00")

    '        If DateDiff(DateInterval.Hour, Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 13:00"), Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 12:00")) <= 0 Then
    '            dtE.Value = Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 12:00").AddDays(1)
    '        Else
    '            dtE.Value = Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 12:00")
    '        End If

    '    End If
    '    If DateDiff(DateInterval.Hour, dtS.Value, dtE.Value) > 4 And DateDiff(DateInterval.Hour, dtS.Value, dtE.Value) <= 9 Then
    '        txtNum.Text = DateDiff(DateInterval.Hour, dtS.Value, dtE.Value) - 1
    '    Else
    '        txtNum.Text = DateDiff(DateInterval.Hour, dtS.Value, dtE.Value)
    '    End If
    'End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub lvLeave_MouseClick(sender As Object, e As MouseEventArgs) Handles lvLeave.MouseClick
        txtCTR.Text = lvLeave.SelectedItems(0).Text
        txtEmpNo.Text = lvLeave.SelectedItems(0).SubItems(1).Text
        txtName.Text = lvLeave.SelectedItems(0).SubItems(2).Text
        cbLeave.Text = lvLeave.SelectedItems(0).SubItems(3).Text
        txtDesc.Text = lvLeave.SelectedItems(0).SubItems(4).Text
        dtS.Value = lvLeave.SelectedItems(0).SubItems(5).Text
        dtE.Value = lvLeave.SelectedItems(0).SubItems(6).Text
        txtNum.Text = lvLeave.SelectedItems(0).SubItems(7).Text
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub cbStart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStart.SelectedIndexChanged
        checkTime()
    End Sub

    Private Sub cbEnd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEnd.SelectedIndexChanged
       checkTime()
    End Sub

   
    Private Sub dtS_ValueChanged(sender As Object, e As EventArgs) Handles dtS.ValueChanged
       checkTime()
    End Sub

    Private Sub dtE_ValueChanged(sender As Object, e As EventArgs) Handles dtE.ValueChanged
        If DateDiff(DateInterval.Hour, Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 13:00"), Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 12:00")) >= 0 Then
            If cbStart.Text = "AM" And cbEnd.Text = "PM" Then
                dtS.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 8:00")
                dtE.Value = Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 17:00")
            ElseIf cbStart.Text = "AM" And cbEnd.Text = "AM" Then
                dtS.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 8:00")
                dtE.Value = Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 12:00")
            ElseIf cbStart.Text = "PM" And cbEnd.Text = "PM" Then
                dtS.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 13:00")
                dtE.Value = Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 17:00")
            ElseIf cbStart.Text = "PM" And cbEnd.Text = "AM" Then
                dtS.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 13:00")

                If DateDiff(DateInterval.Hour, Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 13:00"), Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 12:00")) <= 0 Then
                    dtE.Value = Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 12:00").AddDays(1)
                Else
                    dtE.Value = Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 12:00")
                End If
            End If
        Else
            If cbStart.Text = "AM" And cbEnd.Text = "PM" Then
                dtS.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 8:00")
                dtE.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 17:00")
            ElseIf cbStart.Text = "AM" And cbEnd.Text = "AM" Then
                dtS.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 8:00")
                dtE.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 12:00")
            ElseIf cbStart.Text = "PM" And cbEnd.Text = "PM" Then
                dtS.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 13:00")
                dtE.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 17:00")
            ElseIf cbStart.Text = "PM" And cbEnd.Text = "AM" Then
                dtS.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 13:00")

                If DateDiff(DateInterval.Hour, Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 13:00"), Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 12:00")) <= 0 Then
                    dtE.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 12:00").AddDays(1)
                Else
                    dtE.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 12:00")
                End If

            End If
        End If

        Dim totHour, totDay As String
        totHour = DateDiff(DateInterval.Hour, dtS.Value, dtE.Value)
        totDay = DateDiff(DateInterval.Day, dtS.Value, dtE.Value)

        If totHour > 4 And totHour <= 9 Then
            txtNum.Text = (totHour - 1) / 8
        ElseIf totHour <= 23 And totHour > 9 Then
            txtNum.Text = (totHour - 15) / 8
        ElseIf totHour > 23 Then
            If cbStart.Text = "AM" And cbEnd.Text = "PM" Then
                txtNum.Text = ((totHour - (24 * totDay)) + (8 * totDay) - 1) / 8
            ElseIf cbStart.Text = "PM" And cbEnd.Text = "AM" Then
                txtNum.Text = ((totHour - (24 * totDay)) + (8 * totDay) + 1) / 8
            ElseIf cbStart.Text = cbEnd.Text Then
                txtNum.Text = ((totHour - (24 * totDay)) + (8 * totDay)) / 8
            End If
        ElseIf totHour < 4 Then
            txtNum.Text = totHour / 8
        End If
    End Sub

    Private Sub checkTime()
        Dim totHour, totDay As Integer
        If cbStart.Text = "AM" And cbEnd.Text = "PM" Then
            dtS.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 8:00")
            dtE.Value = Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 17:00")
        ElseIf cbStart.Text = "AM" And cbEnd.Text = "AM" Then
            dtS.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 8:00")
            dtE.Value = Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 12:00")
        ElseIf cbStart.Text = "PM" And cbEnd.Text = "PM" Then
            dtS.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 13:00")
            dtE.Value = Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 17:00")
        ElseIf cbStart.Text = "PM" And cbEnd.Text = "AM" Then
            dtS.Value = Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 13:00")

            If DateDiff(DateInterval.Hour, Convert.ToDateTime(DateTime.Parse(dtS.Text).ToString("MM/dd/yyyy") & " 13:00"), Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 12:00")) <= 0 Then
                dtE.Value = Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 12:00").AddDays(1)
            Else
                dtE.Value = Convert.ToDateTime(DateTime.Parse(dtE.Text).ToString("MM/dd/yyyy") & " 12:00")
            End If
        End If

        totHour = DateDiff(DateInterval.Hour, dtS.Value, dtE.Value)
        totDay = DateDiff(DateInterval.Day, dtS.Value, dtE.Value)

        If totHour > 4 And totHour <= 9 Then
            txtNum.Text = (totHour - 1) / 8
        ElseIf totHour <= 23 And totHour > 9 Then
            txtNum.Text = (totHour - 15) / 8
        ElseIf totHour > 23 Then
            If cbStart.Text = "AM" And cbEnd.Text = "PM" Then
                txtNum.Text = ((totHour - (24 * totDay)) + (8 * totDay) - 1) / 8
            ElseIf cbStart.Text = "PM" And cbEnd.Text = "AM" Then
                txtNum.Text = ((totHour - (24 * totDay)) + (8 * totDay) + 1) / 8
            ElseIf cbStart.Text = cbEnd.Text Then
                txtNum.Text = ((totHour - (24 * totDay)) + (8 * totDay)) / 8
            End If
        ElseIf totHour < 4 Then
            txtNum.Text = totHour / 8.0
        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim sqlDel As String
        If MsgBox("Are you sure you want to delte this record", vbYesNo) = MsgBoxResult.Yes Then
            sqlDel = "DELETE from tblLeave WHERE ctrno='" & txtCTR.Text & "'"
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
            callLeaveData()
        Else
            Exit Sub
        End If
    End Sub

End Class