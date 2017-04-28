Imports MySql.Data.MySqlClient

Public Class frmMeeting
    Dim strMA As String
    Dim strM As String
    Dim str, allowCheck As String
    Dim strS, temp, tempDate As String
    Private Sub frmMeeting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshMeeting()

    End Sub
    Public Sub refreshMAttendance()
        strMA = "Select * from tbl_mattendance where Mctrno='" & lvMeeting.SelectedItems(0).Text & "'"
        loadMAttendance()
    End Sub
    Public Sub refreshMAttendance1()
        strMA = "Select * from tbl_mattendance where Mctrno='" & temp & "'"
        loadMAttendance()
    End Sub
    Public Sub loadMAttendance()
        On Error Resume Next
        Dim cmdMA As MySqlCommand
        Dim drMA As MySqlDataReader
        'Dim i As Integer
        CONNECTION.Open()
        cmdMA = New MySqlCommand(strMA, CONNECTION)
        drMA = cmdMA.ExecuteReader
        'i = 0
        lvEmp.Items.Clear()
        Do While drMA.Read
            
            Dim lv As ListViewItem = lvEmp.Items.Add("Involve?")
            lv.SubItems.Add(drMA.Item(2))
            lv.SubItems.Add(drMA.Item(3))
            lv.SubItems.Add(drMA.Item(0))
            If drMA.Item(1) = "Yes" Then
                lv.Checked = True
            End If

        Loop
        cmdMA.Dispose()
        drMA.Close()
        CONNECTION.Close()

    End Sub
    Public Sub RefreshMeeting()
        strM = "Select * from tbl_meeting"
        loadMeeting()
    End Sub


    Public Sub loadMeeting()
        Dim cmdM As MySqlCommand
        Dim drM As MySqlDataReader
        'Dim i As Integer
        CONNECTION.Open()
        cmdM = New MySqlCommand(strM, CONNECTION)
        drM = cmdM.ExecuteReader
        'i = 0
        lvMeeting.Items.Clear()
        Do While drM.Read

            Dim lv As ListViewItem = lvMeeting.Items.Add(drM.Item(0))
            lv.SubItems.Add(drM.Item(3))
            lv.SubItems.Add(drM.Item(1))
            lv.SubItems.Add(drM.Item(2))
        Loop
        cmdM.Dispose()
        drM.Close()
        CONNECTION.Close()

    End Sub

    Private Sub lvMeeting_MouseClick(sender As Object, e As MouseEventArgs) Handles lvMeeting.MouseClick
        refreshMAttendance()
        dtDate.Value = lvMeeting.SelectedItems(0).SubItems(1).Text
        txtMeeting.Text = lvMeeting.SelectedItems(0).SubItems(2).Text
        txtDesc.Text = lvMeeting.SelectedItems(0).SubItems(3).Text
        temp = lvMeeting.SelectedItems(0).Text
        allowCheck = "No"
    End Sub

    Private Sub lvMeeting_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvMeeting.MouseDoubleClick
        refreshMAttendance()
        dtDate.Value = lvMeeting.SelectedItems(0).SubItems(1).Text
        txtMeeting.Text = lvMeeting.SelectedItems(0).SubItems(2).Text
        txtDesc.Text = lvMeeting.SelectedItems(0).SubItems(3).Text
        tempDate =
        temp = lvMeeting.SelectedItems(0).Text
    End Sub
 

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strAEM, strAEA, att As String
        Dim drS As MySqlDataReader
        'Dim drAtt As MySqlDataReader
        Dim i As Integer
        i = 0
        If btnAdd.Text = "ADD" Then
            btnAdd.Text = "SAVE"
            btnEdit.Text = "CANCEL"
            btnDel.Enabled = False
            btnEditA.Enabled = False
            dtDate.Value = Now
            txtDesc.Text = ""
            txtMeeting.Text = ""
            grpInfo.Enabled = True

            btnAction = 2
        Else
            If btnAction = 2 Then
                strAEM = "INSERT INTO tbl_meeting SET " & _
                    "meeting='" & txtMeeting.Text & _
                    "', description='" & txtDesc.Text & _
                    "', MeetingDate='" & DateTime.Parse(dtDate.Text).ToString("yyyy-MM-dd") & "'"
            ElseIf btnAction = 1 Then
                strAEM = "UPDATE tbl_meeting SET " & _
                    "meeting='" & txtMeeting.Text & _
                    "', description='" & txtDesc.Text & _
                    "', MeetingDate='" & DateTime.Parse(dtDate.Text).ToString("yyyy-MM-dd") & "' WHERE ctrno='" & temp & "'"
            End If
            CONNECTION.Open()
            Dim cmdM As New MySqlCommand(strAEM, CONNECTION)
            Dim Count = cmdM.ExecuteNonQuery
            If Count = 0 Then
                MsgBox("dfsfgfhfhgfh")
                CONNECTION.Close()
                Exit Sub
            End If
            If btnAction = 2 Then
                Me.Cursor = Cursors.WaitCursor
                str = "Select empno, CONCAT( surname,', ',firstname,' ', LEFT(mi,1), '.' ) as Name from tbl_employees order by surname"
                Dim da As New MySqlDataAdapter(str, CONNECTION)
                Dim ds As New DataSet
                da.Fill(ds, "emp")

                strS = "Select ctrno from tbl_meeting order by ctrno desc limit 1"
                Dim cmd As New MySqlCommand(strS, CONNECTION)
                drS = cmd.ExecuteReader

                Do While drS.Read
                    temp = drS.Item(0)
                Loop
                drS.Close()

                ' MsgBox(" dfgf '" & temp & "' '" & ds.Tables("emp").Rows.Count & "'")
                Do While i < ds.Tables("emp").Rows.Count
                    With ds.Tables("emp").Rows(i)
                        Dim cmdAtt As New MySqlCommand("Select * from Attendance where empno='" & .Item(0) & "' AND date1='" & DateTime.Parse(dtDate.Text).ToString("yyyy-MM-dd") & "'", CONNECTION)
                        Dim drAtt As MySqlDataReader
                        drAtt = cmdAtt.ExecuteReader
                        If drAtt.HasRows Then
                            att = "Yes"
                        Else
                            att = "No"
                        End If
                        cmdAtt.Dispose()
                        drAtt.Close()
                        strAEA = "INSERT INTO tbl_mattendance SET " & _
                            " Attendance='" & att & "'" & _
                            ", EmpNo='" & .Item(0) & _
                            "', EmpName='" & UCase(.Item(1)) & _
                            "', Mctrno = '" & temp & "'"
                        Dim cmdAEA As New MySqlCommand(strAEA, CONNECTION)
                        Dim CountA = cmdAEA.ExecuteNonQuery
                    End With
                    i = i + 1
                Loop
                Me.Cursor = Cursors.Default
            End If
            CONNECTION.Close()

            btnAdd.Text = "ADD"
            btnEdit.Text = "EDIT"
            btnDel.Enabled = True
            btnEditA.Enabled = True
            dtDate.Value = Now
            txtDesc.Text = ""
            txtMeeting.Text = ""
            grpInfo.Enabled = False
            btnAction = 0

            RefreshMeeting()
            refreshMAttendance1()
            End If

    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lvMeeting.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If btnAdd.Text = "ADD" Then
            'txtCTR.Text = lvMeeting.SelectedItems(0).Text
            btnAdd.Text = "SAVE"
            btnEdit.Text = "CANCEL"
            btnDel.Enabled = False
            btnEditA.Enabled = False
            grpInfo.Enabled = True
            btnAction = 1
        Else
            btnAdd.Text = "ADD"
            btnEdit.Text = "EDIT"
            btnDel.Enabled = True
            btnEditA.Enabled = True
            grpInfo.Enabled = False
            btnAction = 0

        End If
    End Sub

    Private Sub btnEditA_Click(sender As Object, e As EventArgs) Handles btnEditA.Click
        Dim i As Integer
        Dim strU As String
        If lvEmp.Items.Count = 0 Then
            Exit Sub
        End If
        If btnEditA.Text <> "SAVE" Then
            'lvEmp.Enabled = True
            btnEditA.Text = "SAVE"
            btnAdd.Enabled = False
            btnEdit.Enabled = False
            btnDel.Enabled = False
            lvMeeting.Enabled = False
            loadMAttendance()
            allowCheck = "Yes"
        Else
            Me.Cursor = Cursors.WaitCursor
            Dim ans As String
            CONNECTION.Open()
            Do While i < lvEmp.Items.Count
                If lvEmp.Items(i).Checked = True Then
                    ans = "Yes"
                Else
                    ans = "No"
                End If
                strU = "UPDATE tbl_mattendance SET " & _
                    " Attendance='" & ans & "'" & _
                   " WHERE Mctrno = '" & temp & "' AND ctrno='" & lvEmp.Items(i).SubItems(3).Text & "'"

                Dim cmdU As New MySqlCommand(strU, CONNECTION)
                Dim CountU = cmdU.ExecuteNonQuery

                i = i + 1
            Loop
            Me.Cursor = Cursors.Default
            CONNECTION.Close()

            btnEditA.Text = "EDIT ATTENDANCE"
            btnAdd.Enabled = True
            btnEdit.Enabled = True
            btnDel.Enabled = True
            lvMeeting.Enabled = True
            'lvEmp.Enabled = False
            allowCheck = "No"
        End If
    End Sub

  

    Private Sub lvEmp_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lvEmp.ItemChecked
       
    End Sub
End Class