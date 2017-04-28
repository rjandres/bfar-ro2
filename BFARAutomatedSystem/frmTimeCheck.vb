Imports MySql.Data.MySqlClient

Public Class frmTimeCheck

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub cmdEditSave_Click(sender As Object, e As EventArgs) Handles cmdEditSave.Click
        On Error Resume Next
        Dim strSQL, strSQL2 As String
        Dim dr As MySqlDataReader
        Dim cmd As New MySqlCommand
        Dim cDateInAM, cDateOutAM, cDateNow, cDateInPM, cDateOutPM As DateTime
        Dim a, aa, bb, cc As String

        

        cDateInAM = Convert.ToDateTime(mtxtAMIN.Text).AddDays(-1)
        cDateOutAM = Convert.ToDateTime(mtxtAMOUT.Text)
        cDateInPM = Convert.ToDateTime(mtxtPMIN.Text)
        cDateOutPM = Convert.ToDateTime(mtxtPMOUT.Text)
        'time in  778 min
        cDateNow = Convert.ToDateTime(Now)

        'Dim count, count2 As Integer
        strSQL = "SELECT * from tbl_dtr where empno='" & txtEmpID.Text & "' AND date1='" & txtDate.Text & "' ORDER BY date1 desc limit 1"
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()

        If (dr.HasRows) Then
            Do While dr.Read()
                a = dr.Item(3).ToString()
                aa = dr.Item(4).ToString()
                bb = dr.Item(5).ToString()
                cc = dr.Item(6).ToString()
            Loop

            If a <> "" And aa = "" And bb = "" And cc = "" Then

                If DateDiff(DateInterval.Minute, cDateNow, cDateOutAM) > 0 Then
                    strSQL2 = "UPDATE tbl_dtr SET timeout_am ='" & mtxtAMIN.Text.ToString & _
                        "', undertime_mins = '" & DateDiff(DateInterval.Minute, cDateNow, cDateOutAM.AddMinutes(1)) + dr.Item(10) & _
                        "' WHERE empno='" & txtEmpID.Text & "' AND date1='" & txtDate.Text & "'"
                    'MsgBox("AM OUT")
                Else
                    strSQL2 = "UPDATE tbl_dtr SET timeout_am ='" & mtxtAMOUT.Text.ToString & _
                        "', undertime_mins = '" & dr.Item(10) & "'" & _
                        " WHERE empno='" & txtEmpID.Text & "' AND date1='" & txtDate.Text & "'"
                End If
                'End If
                dr.Close()
            End If

            If a <> "" And aa <> "" And bb = "" And cc = "" Then

                If DateDiff(DateInterval.Minute, cDateInPM, cDateNow) > 11 Then
                    strSQL2 = "UPDATE tbl_dtr SET timein_pm ='" & mtxtPMIN.Text.ToString & _
                                "', undertime_mins = '" & (DateDiff(DateInterval.Minute, cDateInPM, cDateNow) - 9) + dr.Item(10) & _
                                "' WHERE empno='" & txtEmpID.Text & "' AND date1='" & txtDate.Text & _
                                 "'"
                    'MsgBox("AM OUT")
                Else
                    strSQL2 = "UPDATE tbl_dtr SET timein_pm ='" & mtxtPMIN.Text.ToString & _
                        "', undertime_mins = '" & dr.Item(10) & "'" & _
                        " WHERE empno='" & txtEmpID.Text & "' AND date1='" & txtDate.Text & "'"
                End If
                dr.Close()
                ' MsgBox("PM IN")
            End If

            If a <> "" And aa <> "" And bb <> "" And cc = "" Then
                If DateDiff(DateInterval.Minute, cDateNow, cDateOutPM) > 360 Then
                    strSQL2 = "UPDATE tbl_dtr SET timeout_pm ='" & mtxtPMOUT.Text.ToString & _
                            "', undertime_mins = '" & (DateDiff(DateInterval.Minute, cDateNow, cDateOutPM) - 360) + dr.Item(10) & _
                            "' WHERE empno='" & txtEmpID.Text & "' AND date1='" & txtDate.Text & "'"
                Else
                    strSQL2 = "UPDATE tbl_dtr SET timeout_pm ='" & mtxtPMOUT.Text.ToString & _
                            "', undertime_mins = '" & dr.Item(10) & "'" & _
                            "' WHERE empno='" & txtEmpID.Text & "' AND date1='" & txtDate.Text & "'"
                    ' MsgBox("PM OUT")
                End If
                dr.Close()
                'End If
            End If

            If a = "" And aa = "" And bb <> "" And cc = "" Then

                If DateDiff(DateInterval.Minute, cDateNow, cDateOutPM) > 360 Then
                    strSQL2 = "UPDATE tbl_dtr SET timeout_pm ='" & mtxtPMOUT.Text.ToString & _
                            "', undertime_mins = '" & (DateDiff(DateInterval.Minute, cDateNow, cDateOutPM) - 360) + dr.Item(10) & _
                            "' WHERE empno='" & txtEmpID.Text & "' AND date1='" & txtDate.Text & "'"
                Else
                    strSQL2 = "UPDATE tbl_dtr SET timeout_pm ='" & mtxtPMOUT.Text.ToString & _
                            "', undertime_mins = '" & dr.Item(10) & "'" & _
                            "' WHERE empno='" & txtEmpID.Text & "' AND date1='" & txtDate.Text & "'"
                    ' MsgBox("PM OUT")
                End If
                dr.Close()
                'MsgBox("PM OUT")
            End If
        Else
            'If no record for the day
            If DateDiff(DateInterval.Minute, cDateInAM, cDateNow) < 778 Then
                'Time in for AM

                If DateDiff(DateInterval.Minute, cDateInAM, cDateNow) > 550 Then
                    strSQL2 = "insert into tbl_dtr set empno ='" & txtEmpID.Text & _
                   "', date1 ='" & txtDate.Text.ToString & _
                   "', timein_am ='" & mtxtAMIN.Text.ToString & _
                   "', undertime_mins = '" & DateDiff(DateInterval.Minute, cDateInAM, cDateNow) - 549 & "'"
                Else
                    strSQL2 = "insert into tbl_dtr set empno ='" & txtEmpID.Text & _
                  "', date1 ='" & txtDate.Text.ToString & _
                  "', timein_am ='" & mtxtAMIN.Text.ToString & _
                  "', undertime_mins = 0"
                End If
                dr.Close()
            ElseIf DateDiff(DateInterval.Minute, cDateInAM, cDateNow) >= 778 Then
                'Time in for PM, if no Time in and Time out for AM

                If DateDiff(DateInterval.Minute, cDateInPM, cDateNow) > 11 Then
                    strSQL2 = "insert into tbl_dtr set empno ='" & txtEmpID.Text & _
                   "', date1 ='" & txtDate.Text.ToString & _
                   "', timein_pm ='" & mtxtPMIN.Text.ToString & _
                    "', undertime_mins = '" & DateDiff(DateInterval.Minute, cDateInPM, cDateNow) - 11 & "'"
                Else
                    strSQL2 = "insert into tbl_dtr set empno ='" & txtEmpID.Text & _
                    "', date1 ='" & txtDate.Text.ToString & _
                    "', timein_pm ='" & mtxtPMIN.Text.ToString & _
                     "', undertime_mins = 0"
                End If
                dr.Close()
            End If
        End If

        Dim SqlCommand As New MySqlCommand
        Dim Count As Integer
        SqlCommand.Connection = CONNECTION
        SqlCommand.CommandText = strSQL2
        Count = SqlCommand.ExecuteNonQuery()
        dr.Close()
        cmd.Dispose()

        CONNECTION.Close()
    End Sub

    Private Sub frmTimeCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If mtxtAMIN.ReadOnly = True And mtxtAMOUT.ReadOnly = True And mtxtPMIN.ReadOnly = True And mtxtPMOUT.ReadOnly = True Then
            cmdEditSave.Enabled = False
        Else
            cmdEditSave.Enabled = True
        End If
    End Sub
End Class