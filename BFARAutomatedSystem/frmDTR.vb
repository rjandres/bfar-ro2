Imports MySql.Data.MySqlClient

Public Class frmDTR
    Dim VL As Double
    Dim VLBal, SLBal As Double

    Dim strEmp As String
    Dim strDTR, strTO, strL, strH, strM, strCearn As String
    Dim i, totDay As Integer
    Dim dr, drTO, drL, drLAM, drLPM, drTOAM, drTOPM, drH, drHAMPPM, drM, drCearn As MySqlDataReader
    Dim datCheck As String
    Dim dateC As String
    Dim txtText, temp, inAM, inPM, outAM, outPM As String
    Dim underMin, otMin, renMin As Integer
    Dim AMIn, AMOut, PMIn, PMOut As DateTime
    Dim RT, TT, UT, AT, OT, Sat, Sun As Integer

    Private Sub loadDays()
        On Error Resume Next
        Dim totDay, i, satCount, sunCount As Integer
        Dim dateCheck As New DateTime
        Dim datCheck As String

        i = 1
        totDay = System.DateTime.DaysInMonth(txtYear.Text, cbMonth.SelectedIndex + 1)
        Do Until i = totDay
            datCheck = (cbMonth.SelectedIndex + 1) & "/" & i & "/" & txtYear.Text
            dateCheck = Convert.ToDateTime(datCheck.ToString)
            If DateTime.Parse(datCheck).ToString("dddd") = "Saturday" Then
                satCount = satCount + 1
            End If
            If DateTime.Parse(datCheck).ToString("dddd") = "Sunday" Then
                sunCount = sunCount + 1
            End If
            i = i + 1
        Loop

        txtNumSun.Text = sunCount
        txtNumSat.Text = satCount
        txtNumDays.Text = totDay - (satCount + sunCount)
    End Sub
  

    Private Sub loadDTR()
        On Error Resume Next
        Dim StatChange As Boolean
        StatChange = True

        ' Dim reloadPart As String

reloadPart:
        RT = 0
        TT = 0
        UT = 0
        AT = 0
        OT = 0
        CONNECTION.Close()
        CONNECTION.Open()
        strCearn = "Select VLBal, SLBal from LeaveCredit where EmpID = '" & txtEmpNo.Text & "'"
        Dim cmdCearn = New MySqlCommand(strCearn, CONNECTION)
        drCearn = cmdCearn.ExecuteReader
        Do While drCearn.Read
            VLBal = drCearn.Item(0)
            SLBal = drCearn.Item(1)
        Loop
        cmdCearn.Dispose()
        drCearn.Close()
        CONNECTION.Close()

        inAM = "08:00:00 AM"
        inPM = "13:00:00 PM"
        outAM = "12:00:00 PM"
        outPM = "17:00:00 PM"
        'inPM = '"13:00:00 PM"
        totDay = System.DateTime.DaysInMonth(txtYear.Text, cbMonth.SelectedIndex + 1)
        lvDTR.Items.Clear()
        i = 1
        Do While i <= totDay
            datCheck = (cbMonth.SelectedIndex + 1) & "/" & i & "/" & txtYear.Text
            dateC = DateTime.Parse(datCheck).ToString("yyyy-MM-dd")

            datCheck = dateC
            If DateTime.Parse(datCheck).ToString("dddd") = "Saturday" Then
                txtText = "Saturday"
                Sat += 1
            ElseIf DateTime.Parse(datCheck).ToString("dddd") = "Sunday" Then
                txtText = "Sunday"
                Sun += 1
            Else
                txtText = " " '"Absent"
            End If
            strDTR = "SELECT * from tbl_dtr Where empno='" & txtEmpNo.Text & "'  AND date1='" & datCheck.ToString & "' "
            CONNECTION.Open()

            Dim da As New MySqlDataAdapter(strDTR, CONNECTION)
            Dim dsDTR As New DataSet
            da.Fill(dsDTR, "DTR")

            If dsDTR.Tables("DTR").Rows.Count <> 0 Then
                With dsDTR.Tables("DTR").Rows(0)
                    Dim lv As ListViewItem = lvDTR.Items.Add(DateTime.Parse(.Item(2)).ToString("dd"))
                    lv.UseItemStyleForSubItems = False

                    If .Item(3).ToString <> "" Then
                        lv.SubItems.Add(.Item(3))
                        If DateDiff(DateInterval.Minute, Convert.ToDateTime(DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & txtAMIN.Text & "'")).AddMinutes(txtTimeA.Text), Convert.ToDateTime(DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & .Item(3) & "'"))) > 0 Then
                            AMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & .Item(3) & "'")
                            AMIn = AMIn.AddMinutes(-txtTimeA.Text)
                            'AMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 00:00:00")
                        ElseIf DateDiff(DateInterval.Minute, Convert.ToDateTime(DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & txtAMIN.Text & "'")), Convert.ToDateTime(DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & .Item(3) & "'"))) <= 0 Then
                            AMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & txtAMIN.Text & "'")
                            'AMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 00:00:00")
                        End If
                        'inPM = DateDiff(DateInterval.Minute, Convert.ToDateTime(DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & inAM & "'")), Convert.ToDateTime(DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & .Item(3) & "'")))
                    Else
                        Dim strLAM As String
                        strLAM = "Select TypeOfLeave from tblleave where EmpNo = '" & txtEmpNo.Text & _
                        "' AND DateEnd >='" & DateTime.Parse(datCheck).ToString("yyyy-MM-dd 12:00:00") & _
                            "'"
                        Dim cmdLAM = New MySqlCommand(strLAM, CONNECTION)
                        drLAM = cmdLAM.ExecuteReader
                        If drLAM.HasRows Then
                            Do While drLAM.Read
                                lv.SubItems.Add(drLAM.Item(0))
                                'AMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 08:00:00")
                            Loop
                            cmdLAM.Dispose()
                            drLAM.Close()
                        Else
                            cmdLAM.Dispose()
                            drLAM.Close()
                            Dim strTOAM As String
                            strTOAM = "Select * from tbl_travelorder where EmpNo = '" & txtEmpNo.Text & _
                            "' AND ReturnD = '" & DateTime.Parse(datCheck).ToString("yyyy-MM-dd") & _
                            "' AND Status = 'Waiting'" & _
                            " AND ReturnAMPM='AM'"
                            Dim cmdTOAM = New MySqlCommand(strTOAM, CONNECTION)
                            drTOAM = cmdTOAM.ExecuteReader
                            If drTOAM.HasRows Then
                                lv.SubItems.Add("On Travel")
                                'AMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 08:00:00")
                                drTOAM.Close()
                                cmdTOAM.Dispose()
                            Else
                                drTOAM.Close()
                                cmdTOAM.Dispose()
                                strH = "Select * from tbl_holiday where " & _
                                    " HolidayDate = '" & DateTime.Parse(datCheck).ToString("MM/dd/yyyy") & "' and Status = 'No' and Covered='AM' "
                                Dim cmdH = New MySqlCommand(strH, CONNECTION)
                                drH = cmdH.ExecuteReader
                                If drH.HasRows Then
                                    Do While drH.Read
                                        lv.SubItems.Add(drH.Item(1))
                                        'AMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 08:00:00")
                                    Loop
                                    drH.Close()
                                    cmdH.Dispose()
                                Else
                                    drH.Close()
                                    cmdH.Dispose()

                                    'ddddddddddddddddddddddddddd
                                    strM = "Select * from actmeeting where " & _
                                        "EmpNo='" & txtEmpNo.Text & _
                                        "'AND Status='Yes'" & _
                                        " AND MeetingDate = '" & DateTime.Parse(datCheck).ToString("yyyy-MM-dd") & "'"
                                    Dim cmdM = New MySqlCommand(strM, CONNECTION)
                                    drM = cmdM.ExecuteReader
                                    If drM.HasRows Then
                                        Do While drM.Read
                                            lv.SubItems.Add(drM.Item(2))
                                            'AMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 08:00:00")
                                        Loop
                                        drM.Close()
                                        cmdM.Dispose()
                                    Else
                                        drM.Close()
                                        cmdM.Dispose()
                                        If datCheck <= Now Then
                                            If DateTime.Parse(datCheck).ToString("dddd") = "Saturday" Then
                                                lv.SubItems.Add("Saturday").ForeColor = Color.Blue
                                            ElseIf DateTime.Parse(datCheck).ToString("dddd") = "Sunday" Then
                                                lv.SubItems.Add("Sunday").ForeColor = Color.Blue
                                            Else
                                                lv.SubItems.Add(" ").ForeColor = Color.Red
                                                'lv.SubItems.Add("No Timein").ForeColor = Color.Red
                                            End If
                                        Else
                                            lv.SubItems.Add("-")
                                        End If
                                        'AMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 00:00:00")
                                    End If

                                End If
                            End If
                        End If
                    End If

                    If .Item(4).ToString <> "" Then
                        lv.SubItems.Add(.Item(4))
                        'fddghewyusqetuydwtyutsyuatusa
                        If DateDiff(DateInterval.Minute, Convert.ToDateTime(DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & .Item(5) & "'")), Convert.ToDateTime(DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & outAM & "'"))) > 0 Then
                            AMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & .Item(5) & "'")
                            'AMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 00:00:00")
                        ElseIf DateDiff(DateInterval.Minute, Convert.ToDateTime(DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & .Item(5) & "'")), Convert.ToDateTime(DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & outAM & "'"))) <= 0 Then
                            AMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & txtAMOut.Text & "'")
                            'AMOut = AMOut.AddMinutes(1)
                            'AMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 00:00:00")
                        End If
                    Else
                        Dim strLAM As String
                        strLAM = "Select TypeOfLeave from tblleave where EmpNo = '" & txtEmpNo.Text & _
                        "' AND DateEnd ='" & DateTime.Parse(datCheck).ToString("yyyy-MM-dd 12:00:00 PM") & _
                            "'"
                        Dim cmdLAM = New MySqlCommand(strLAM, CONNECTION)
                        drLAM = cmdLAM.ExecuteReader
                        If drLAM.HasRows Then
                            Do While drLAM.Read
                                lv.SubItems.Add(drLAM.Item(0))
                                ' AMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 12:00:00")
                            Loop
                            cmdLAM.Dispose()
                            drLAM.Close()
                        Else
                            cmdLAM.Dispose()
                            drLAM.Close()
                            Dim strTOAM As String
                            strTOAM = "Select * from tbl_travelorder where EmpNo = '" & txtEmpNo.Text & _
                            "' AND ReturnD = '" & DateTime.Parse(datCheck).ToString("yyyy-MM-dd") & _
                            "' AND Status = 'Waiting'" & _
                            " AND ReturnAMPM='AM'"
                            Dim cmdTOAM = New MySqlCommand(strTOAM, CONNECTION)
                            drTOAM = cmdTOAM.ExecuteReader
                            If drTOAM.HasRows Then
                                lv.SubItems.Add("On Travel")
                                'AMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 12:00:00")
                                drTOAM.Close()
                                cmdTOAM.Dispose()
                            Else
                                drTOAM.Close()
                                cmdTOAM.Dispose()
                                'lv.SubItems(4)
                                strH = "Select * from tbl_holiday where " & _
                                     " HolidayDate = '" & DateTime.Parse(datCheck).ToString("MM/dd/yyyy") & "' and Status = 'No' and Covered='AM' "
                                Dim cmdH = New MySqlCommand(strH, CONNECTION)
                                drH = cmdH.ExecuteReader
                                If drH.HasRows Then
                                    Do While drH.Read
                                        lv.SubItems.Add(drH.Item(1))
                                        'AMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 12:00:00")
                                    Loop
                                    drH.Close()
                                    cmdH.Dispose()
                                Else
                                    drH.Close()
                                    cmdH.Dispose()

                                    'ddddddddddddddddddddddddddd
                                    strM = "Select * from actmeeting where " & _
                                        "EmpNo='" & txtEmpNo.Text & _
                                        "'AND Status='Yes'" & _
                                        " AND MeetingDate = '" & DateTime.Parse(datCheck).ToString("yyyy-MM-dd") & "'"
                                    Dim cmdM = New MySqlCommand(strM, CONNECTION)
                                    drM = cmdM.ExecuteReader
                                    If drM.HasRows Then
                                        Do While drM.Read
                                            lv.SubItems.Add(drM.Item(2))
                                            'AMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 12:00:00")
                                        Loop
                                        drM.Close()
                                        cmdM.Dispose()
                                    Else
                                        drM.Close()
                                        cmdM.Dispose()
                                        If datCheck <= Now Then
                                            If DateTime.Parse(datCheck).ToString("dddd") = "Saturday" Then
                                                lv.SubItems.Add("Saturday").ForeColor = Color.Blue
                                            ElseIf DateTime.Parse(datCheck).ToString("dddd") = "Sunday" Then
                                                lv.SubItems.Add("Sunday").ForeColor = Color.Blue
                                            Else
                                                lv.SubItems.Add(" ").ForeColor = Color.Red
                                                'lv.SubItems.Add("No Timeout").ForeColor = Color.Red
                                            End If
                                        Else
                                            lv.SubItems.Add("-")
                                        End If
                                        'AMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 00:00:00")
                                    End If

                                End If
                            End If
                        End If
                    End If
                    'CHECK PM
                    If .Item(5).ToString <> "" Then
                        lv.SubItems.Add(.Item(5))
                        If DateDiff(DateInterval.Minute, Convert.ToDateTime(DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & txtPMIN.Text & "'")).AddMinutes(txtTimeA.Text), Convert.ToDateTime(DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & .Item(5) & "'"))) > 0 Then
                            PMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & .Item(5) & "'")
                            PMIn = PMIn.AddMinutes(txtTimeA.Text)
                            ' PMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 00:00:00")
                        ElseIf DateDiff(DateInterval.Minute, Convert.ToDateTime(DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & txtPMIN.Text & "'")).AddMinutes(txtTimeA.Text), Convert.ToDateTime(DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & .Item(5) & "'"))) <= 0 Then
                            PMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & txtPMIN.Text & "'")
                            'PMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 00:00:00")
                        End If
                    Else
                        Dim strLPM As String
                        strLPM = "Select TypeOfLeave from tblleave where EmpNo = '" & txtEmpNo.Text & _
                        "' AND DateStart ='" & DateTime.Parse(datCheck).ToString("yyyy-MM-dd 13:00:00 PM") & _
                            "'"
                        Dim cmdLPM = New MySqlCommand(strLPM, CONNECTION)
                        drLPM = cmdLPM.ExecuteReader
                        If drLPM.HasRows Then
                            Do While drLPM.Read
                                lv.SubItems.Add(drLPM.Item(0))

                                'PMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 13:00:00")
                            Loop
                            cmdLPM.Dispose()
                            drLPM.Close()
                        Else
                            cmdLPM.Dispose()
                            drLPM.Close()
                            Dim strTOPM As String
                            strTOPM = "Select * from tbl_travelorder where EmpNo = '" & txtEmpNo.Text & _
                            "' AND Departure = '" & DateTime.Parse(datCheck).ToString("yyyy-MM-dd") & _
                            "' AND Status = 'Waiting'" & _
                            " AND DeptAMPM='PM' "
                            Dim cmdTOPM = New MySqlCommand(strTOPM, CONNECTION)
                            drTOPM = cmdTOPM.ExecuteReader
                            If drTOPM.HasRows Then
                                lv.SubItems.Add("On Travel")
                                'PMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 13:00:00")
                                drTOPM.Close()
                                cmdTOPM.Dispose()
                            Else
                                drTOPM.Close()
                                cmdTOPM.Dispose()

                                drTOPM.Close()
                                cmdTOPM.Dispose()
                                'lv.SubItems(4)
                                strH = "Select * from tbl_holiday where " & _
                                     " HolidayDate = '" & DateTime.Parse(datCheck).ToString("MM/dd/yyyy") & "' and Status = 'No' and Covered='PM' "
                                Dim cmdH = New MySqlCommand(strH, CONNECTION)
                                drH = cmdH.ExecuteReader
                                If drH.HasRows Then
                                    Do While drH.Read
                                        lv.SubItems.Add(drH.Item(1))
                                        'PMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 13:00:00")
                                    Loop
                                    drH.Close()
                                    cmdH.Dispose()
                                Else
                                    drH.Close()
                                    cmdH.Dispose()

                                    strM = "Select * from actmeeting where " & _
                                        "EmpNo='" & txtEmpNo.Text & _
                                        "'AND Status='Yes'" & _
                                        " AND MeetingDate = '" & DateTime.Parse(datCheck).ToString("yyyy-MM-dd") & "'"
                                    Dim cmdM = New MySqlCommand(strM, CONNECTION)
                                    drM = cmdM.ExecuteReader
                                    If drM.HasRows Then
                                        Do While drM.Read
                                            lv.SubItems.Add(drM.Item(2))
                                            'PMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 13:00:00")
                                        Loop
                                        drM.Close()
                                        cmdM.Dispose()
                                    Else
                                        drM.Close()
                                        cmdM.Dispose()
                                        If datCheck <= Now Then
                                            If DateTime.Parse(datCheck).ToString("dddd") = "Saturday" Then
                                                lv.SubItems.Add("Saturday").ForeColor = Color.Blue
                                            ElseIf DateTime.Parse(datCheck).ToString("dddd") = "Sunday" Then
                                                lv.SubItems.Add("Sunday").ForeColor = Color.Blue
                                            Else
                                                lv.SubItems.Add(" ").ForeColor = Color.Red
                                                'lv.SubItems.Add("No Timein").ForeColor = Color.Red
                                            End If
                                        Else
                                            lv.SubItems.Add("-")
                                        End If
                                        'PMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 00:00:00")
                                    End If


                                End If
                            End If
                        End If
                    End If
                    If .Item(6).ToString <> "" Then
                        lv.SubItems.Add(.Item(6))

                        If DateDiff(DateInterval.Minute, Convert.ToDateTime(DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & .Item(6) & "'")), Convert.ToDateTime(DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & outPM & "'"))) > 0 Then
                            PMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & .Item(6) & "'")
                            'PMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 00:00:00")
                        ElseIf DateDiff(DateInterval.Minute, Convert.ToDateTime(DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & .Item(6) & "'")), Convert.ToDateTime(DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & outPM & "'"))) <= 0 Then
                            PMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & txtPMOut.Text & "'")
                            PMOut = PMOut
                            'PMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 00:00:00")
                        End If
                        'PMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & .Item(6) & "'")
                    Else
                        Dim strLPM As String
                        strLPM = "Select TypeOfLeave from tblleave where EmpNo = '" & txtEmpNo.Text & _
                        "' AND DateStart ='" & DateTime.Parse(datCheck).ToString("yyyy-MM-dd 13:00:00 PM") & "'"
                        Dim cmdLPM = New MySqlCommand(strLPM, CONNECTION)
                        drLPM = cmdLPM.ExecuteReader
                        If drLPM.HasRows Then
                            Do While drLPM.Read
                                lv.SubItems.Add(drLPM.Item(0))
                                'PMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 17:00:00")
                            Loop
                            cmdLPM.Dispose()
                            drLPM.Close()
                        Else
                            cmdLPM.Dispose()
                            drLPM.Close()
                            Dim strTOPM As String
                            strTOPM = "Select * from tbl_travelorder where EmpNo = '" & txtEmpNo.Text & _
                            "' AND Departure = '" & DateTime.Parse(datCheck).ToString("yyyy-MM-dd") & _
                            "' AND Status = 'Waiting'" & _
                            " AND DeptAMPM='PM'"
                            Dim cmdTOPM = New MySqlCommand(strTOPM, CONNECTION)
                            drTOPM = cmdTOPM.ExecuteReader
                            If drTOPM.HasRows Then
                                lv.SubItems.Add("On Travel")
                                'PMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 17:00:00")
                                drTOPM.Close()
                                cmdTOPM.Dispose()
                            Else
                                drTOPM.Close()
                                cmdTOPM.Dispose()
                                'lv.SubItems(4)
                                strH = "Select * from tbl_holiday where " & _
                                     "HolidayDate = '" & DateTime.Parse(datCheck).ToString("MM/dd/yyyy") & "' and Status = 'No' and Covered='PM'"
                                Dim cmdH = New MySqlCommand(strH, CONNECTION)
                                drH = cmdH.ExecuteReader
                                If drH.HasRows Then
                                    Do While drH.Read
                                        lv.SubItems.Add(drH.Item(1))
                                        'PMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 17:00:00")
                                    Loop
                                    drH.Close()
                                    cmdH.Dispose()
                                Else
                                    drH.Close()
                                    cmdH.Dispose()
                                    strM = "Select * from actmeeting where " & _
                                        "EmpNo='" & txtEmpNo.Text & _
                                        "'AND Status='Yes'" & _
                                        " AND MeetingDate = '" & DateTime.Parse(datCheck).ToString("yyyy-MM-dd") & "'"
                                    Dim cmdM = New MySqlCommand(strM, CONNECTION)
                                    drM = cmdM.ExecuteReader
                                    If drM.HasRows Then
                                        Do While drM.Read
                                            lv.SubItems.Add(drM.Item(2))
                                            'PMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 17:00:00")
                                        Loop
                                        drM.Close()
                                        cmdM.Dispose()
                                    Else
                                        drM.Close()
                                        cmdM.Dispose()
                                        If datCheck <= Now Then
                                            If DateTime.Parse(datCheck).ToString("dddd") = "Saturday" Then
                                                lv.SubItems.Add(" ").ForeColor = Color.Blue
                                                'lv.SubItems.Add("Saturday").ForeColor = Color.Blue
                                            ElseIf DateTime.Parse(datCheck).ToString("dddd") = "Sunday" Then
                                                lv.SubItems.Add(" ").ForeColor = Color.Blue
                                                'lv.SubItems.Add("Sunday").ForeColor = Color.Blue
                                            Else
                                                lv.SubItems.Add(" ").ForeColor = Color.Red
                                                'lv.SubItems.Add("No Timeout").ForeColor = Color.Red
                                            End If
                                        Else
                                            lv.SubItems.Add("-")
                                        End If
                                        ' PMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd '" & .Item(5) & "'")
                                        ' PMOut.AddMinutes(-10)
                                        'PMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 00:00:00")
                                    End If
                                End If
                            End If
                        End If
                    End If

                    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                    Dim strHS As String
                    Dim sqlssss As String
                    Dim drHS As MySqlDataReader

                    strHS = "Select * from tbl_holiday where " & _
                            "HolidayDate = '" & DateTime.Parse(datCheck).ToString("MM/dd/yyyy") & "' and Status = 'Yes'"
                    Dim cmdHS = New MySqlCommand(strHS, CONNECTION)
                    drHS = cmdHS.ExecuteReader
                    If drHS.HasRows Then
                        Dim TRenders As String
                        'MsgBox("Records updatedcccccccccccccccccccccccccc")
                        'TRenders = DateDiff(DateInterval.Minute, Convert.ToDateTime(txtPMIN.Text), Convert.ToDateTime(.Item(6)))
                        If .Item(8) <> .Item(12) Then

                            '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                            sqlssss = "UPDATE tbl_dtr SET tardiness_mins='" & 0 & _
                            "', undertime_mins='" & 0 & _
                            "', render_mins='" & (.Item(8) + .Item(9) + .Item(10)) & _
                            "', excess_mins='" & (.Item(8) + .Item(9) + .Item(10)) & _
                            " ' where date1='" & DateTime.Parse(datCheck).ToString("yyyy-MM-dd") & "' and empno='" & txtEmpNo.Text & "'"
                            CONNECTION.Close()
                            CONNECTION.Open()

                            Dim SqlCommand1 As New MySqlCommand
                            Dim Count1 As Integer
                            SqlCommand1.Connection = CONNECTION
                            SqlCommand1.CommandText = sqlssss

                            Count1 = SqlCommand1.ExecuteNonQuery()

                            If Count1 = 0 Then
                                'StatChange = True
                                'MsgBox("No record found")
                            Else
                                'MsgBox("Records updated")
                                'StatChange = False
                            End If
                            'MsgBox("Records updated")
                            SqlCommand1.Dispose()

                            CONNECTION.Close()
                            CONNECTION.Open()
                            GoTo reloadPart
                        End If
                        drHS.Close()
                        cmdHS.Dispose()
                    End If
                    'CONNECTION.Close()
                    'CONNECTION.Open()
                    drHS.Close()
                    cmdHS.Dispose()
                    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

                    Dim strHS1 As String
                    Dim sql1 As String
                    Dim drHS1 As MySqlDataReader

                    strHS1 = "Select * from tbl_holiday where " & _
                            "HolidayDate = '" & DateTime.Parse(datCheck).ToString("MM/dd/yyyy") & "' and Status = 'No' and Covered='PM'"
                    Dim cmdHS1 = New MySqlCommand(strHS1, CONNECTION)
                    drHS1 = cmdHS1.ExecuteReader
                    If drHS1.HasRows Then
                        Dim OTRender, T, U As String
                        OTRender = DateDiff(DateInterval.Minute, Convert.ToDateTime(txtPMIN.Text), Convert.ToDateTime(.Item(6)))
                        If OTRender <> .Item(12) Then
                            If DateDiff(DateInterval.Minute, Convert.ToDateTime(txtAMIN.Text), Convert.ToDateTime(.Item(3))) > txtTimeA.Text Then
                                T = (DateDiff(DateInterval.Minute, Convert.ToDateTime(txtAMIN.Text), Convert.ToDateTime(.Item(3))) - txtTimeA.Text)
                            Else
                                T = 0
                            End If
                            If DateDiff(DateInterval.Minute, Convert.ToDateTime(.Item(4)), Convert.ToDateTime(txtAMOut.Text)) > 0 Then
                                U = DateDiff(DateInterval.Minute, Convert.ToDateTime(.Item(4)), Convert.ToDateTime(txtAMOut.Text))
                            Else
                                U = 0
                            End If

                            '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                            sql1 = "UPDATE tbl_dtr SET tardiness_mins='" & T & _
                            "', undertime_mins='" & U & _
                            "', render_mins='" & (240 - (T - U)) + OTRender & _
                            "', excess_mins='" & OTRender & _
                            " ' where date1='" & DateTime.Parse(datCheck).ToString("yyyy-MM-dd") & "' and empno='" & txtEmpNo.Text & "'"
                            CONNECTION.Close()
                            CONNECTION.Open()

                            Dim SqlCommand1 As New MySqlCommand
                            Dim Count1 As Integer
                            SqlCommand1.Connection = CONNECTION
                            SqlCommand1.CommandText = sql1
                            'MsgBox("Records updatedcccccccccccccccccccccccccc")
                            Count1 = SqlCommand1.ExecuteNonQuery()

                            If Count1 = 0 Then
                                'StatChange = True
                                'MsgBox("No record found")
                            Else
                                'MsgBox("Records updated")
                                'StatChange = False
                            End If
                            'MsgBox("Records updated")
                            SqlCommand1.Dispose()

                            CONNECTION.Close()
                            CONNECTION.Open()
                            GoTo reloadPart
                        End If
                        drHS1.Close()
                        cmdHS1.Dispose()
                    End If
                    'CONNECTION.Close()
                    'CONNECTION.Open()
                    drHS1.Close()
                    cmdHS1.Dispose()





                    'MsgBox("Records updatedcccccccccccccccccccccccccc")
                    'If (.Item(3) = "" Or .Item(4) = "") Or (.Item(5) = "" Or .Item(6) = "") Then
                    '    If txtText = "Saturday" Or txtText = "Sunday" Then
                    '        temp = ""
                    '    ElseIf (DateDiff(DateInterval.Hour, AMIn, AMOut) = 0) Then
                    '        temp = "4"
                    '    ElseIf (DateDiff(DateInterval.Hour, PMIn, PMOut) = 0) Then
                    '        temp = "4"
                    '    Else
                    '        temp = "0"
                    '    End If
                    'End If

                    'If DateDiff(DateInterval.Hour, AMIn, AMOut) > 0 And DateDiff(DateInterval.Hour, PMIn, PMOut) > 0 Then
                    lv.SubItems.Add(((.Item(8)) / 60) - (((.Item(8)) Mod 60) / 60))
                    lv.SubItems.Add((.Item(8)) Mod 60)
                    RT += .Item(8)
                    OT += .Item(12)
                    'ElseIf IsDate(.Item(4)) = False And IsDate(.Item(5)) = False And IsDate(.Item(3)) = True And IsDate(.Item(6)) = True Then
                    'lv.SubItems.Add(((.Item(8)) / 60) - (((.Item(8)) Mod 60) / 60))
                    'lv.SubItems.Add((.Item(8)) Mod 60)
                    'RT += .Item(8)
                    'Else
                    'lv.SubItems.Add(((.Item(8)) / 60) - (((.Item(8)) Mod 60) / 60))
                    'lv.SubItems.Add((.Item(8)) Mod 60)
                    'RT += (.Item(8))
                    'End If

                    If txtText = "Saturday" Or txtText = "Sunday" Then
                        lv.SubItems.Add(0)
                        lv.SubItems.Add(0)
                        lv.SubItems.Add(0)
                    Else
                        lv.SubItems.Add(.Item(9))
                        lv.SubItems.Add(.Item(10))
                        lv.SubItems.Add(temp)
                    End If

                    lv.SubItems.Add((.Item(12) / 60) - (.Item(12) Mod 60) / 60)
                    lv.SubItems.Add(.Item(12) Mod 60)

                    TT += .Item(9)
                    UT += .Item(10)
                    AT += temp
                    dsDTR.Dispose()
                End With
            Else
                strTO = "Select * from tbl_travelorder where EmpNo = '" & txtEmpNo.Text & _
                            "' AND Departure <= '" & DateTime.Parse(datCheck).ToString("yyyy-MM-dd") & _
                            "' AND Status = 'Waiting'" & _
                            " AND ReturnD >='" & DateTime.Parse(datCheck).ToString("yyyy-MM-dd") & "' "
                Dim cmdTO = New MySqlCommand(strTO, CONNECTION)
                drTO = cmdTO.ExecuteReader
                If drTO.HasRows Then

                    Dim lv1 As ListViewItem = lvDTR.Items.Add(DateTime.Parse(datCheck).ToString("dd"))
                    
                    lv1.SubItems.Add("On Travel")
                    lv1.SubItems.Add("On Travel")
                    lv1.SubItems.Add("On Travel")
                    lv1.SubItems.Add("On Travel")
                    AMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 08:00:00")
                    AMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 12:00:00")
                    PMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 13:00:00")
                    PMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 17:00:00")
                    lv1.SubItems.Add("8")
                    lv1.SubItems.Add("0")
                    lv1.SubItems.Add("0")
                    lv1.SubItems.Add("0")
                    lv1.SubItems.Add("0")

                    drTO.Close()
                    cmdTO.Dispose()

                    If txtText = "Saturday" Or txtText = "Sunday" Then
                        OT += 480
                        lv1.SubItems.Add("8")
                    Else
                        strH = "Select * from tbl_holiday where " & _
        " HolidayDate = '" & DateTime.Parse(datCheck).ToString("MM/dd/yyyy") & "'"
                        Dim cmdH = New MySqlCommand(strH, CONNECTION)
                        drH = cmdH.ExecuteReader
                        If drH.HasRows Then
                            OT += 480
                            lv1.SubItems.Add("8")
                        Else
                            lv1.SubItems.Add("0")
                        End If
                        drH.Close()
                        cmdH.Dispose()

                    End If

                    lv1.SubItems.Add("0")
                    RT += 480
                Else
                    drH.Close()
                    drTO.Close()
                    cmdTO.Dispose()
                    strL = "Select TypeOfLeave from tblleave where EmpNo = '" & txtEmpNo.Text & _
                            "' AND DateStart <= '" & DateTime.Parse(datCheck).AddDays(1).ToString("yyyy-MM-dd") & _
                            "' AND DateEnd >='" & DateTime.Parse(datCheck).ToString("yyyy-MM-dd") & "' "
                    Dim cmdL = New MySqlCommand(strL, CONNECTION)
                    drL = cmdL.ExecuteReader
                    If drL.HasRows Then
                        Do While drL.Read
                            Dim lv As ListViewItem = lvDTR.Items.Add(DateTime.Parse(datCheck).ToString("dd"))
                            lv.SubItems.Add(drL.Item(0))
                            lv.SubItems.Add(drL.Item(0))
                            lv.SubItems.Add(drL.Item(0))
                            lv.SubItems.Add(drL.Item(0))
                            AMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 08:00:00")
                            AMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 12:00:00")
                            PMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 13:00:00")
                            PMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 17:00:00")
                            lv.SubItems.Add(DateDiff(DateInterval.Hour, AMIn, AMOut) + DateDiff(DateInterval.Hour, PMIn, PMOut))
                            lv.SubItems.Add(((DateDiff(DateInterval.Minute, AMIn, AMOut) + DateDiff(DateInterval.Minute, PMIn, PMOut)) Mod 60))
                            lv.SubItems.Add("0")
                            lv.SubItems.Add("0")
                            lv.SubItems.Add("0")
                            lv.SubItems.Add("0")
                            lv.SubItems.Add("0")
                        Loop
                        drL.Close()
                        cmdL.Dispose()
                    Else
                        drL.Close()
                        cmdL.Dispose()
                        strH = "Select * from tbl_holiday where " & _
                            " HolidayDate = '" & DateTime.Parse(datCheck).ToString("MM/dd/yyyy") & "'"
                        Dim cmdH = New MySqlCommand(strH, CONNECTION)
                        drH = cmdH.ExecuteReader
                        If drH.HasRows Then
                            Do While drH.Read
                                Dim lv As ListViewItem = lvDTR.Items.Add(DateTime.Parse(datCheck).ToString("dd"))
                                Dim AMText, PMText As String
                                If drH.Item(5) = "Whole" Then
                                    AMText = drH.Item(1)
                                    PMText = drH.Item(1)
                                    AMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 08:00:00")
                                    AMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 12:00:00")
                                    PMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 13:00:00")
                                    PMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 17:00:00")
                                ElseIf drH.Item(5) = "AM" Then
                                    AMText = drH.Item(1)
                                    PMText = "Absent"
                                    AMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 08:00:00")
                                    AMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 12:00:00")
                                    PMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 00:00:00")
                                    PMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 00:00:00")
                                ElseIf drH.Item(5) = "PM" Then
                                    AMText = "Absent"
                                    PMText = drH.Item(1)
                                    AMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 00:00:00")
                                    AMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 00:00:00")
                                    PMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 13:00:00")
                                    PMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 17:00:00")
                                End If
                                lv.SubItems.Add(AMText)
                                lv.SubItems.Add(AMText)
                                lv.SubItems.Add(PMText)
                                lv.SubItems.Add(PMText)

                                lv.SubItems.Add("0")
                                lv.SubItems.Add("0")
                                lv.SubItems.Add("0")
                                lv.SubItems.Add("0")
                                lv.SubItems.Add("0")
                                lv.SubItems.Add("0")
                                lv.SubItems.Add("0")
                                AMText = ""
                                PMText = ""
                            Loop

                            drH.Close()
                            cmdH.Dispose()
                        Else
                            If datCheck > Now Then
                                txtText = "-"
                            End If
                            Dim lv As ListViewItem = lvDTR.Items.Add(DateTime.Parse(datCheck).ToString("dd"))
                            lv.UseItemStyleForSubItems = False
                            If txtText = "Absent" Then
                                lv.SubItems.Add(txtText).ForeColor = Color.Red
                                lv.SubItems.Add(txtText).ForeColor = Color.Red
                                lv.SubItems.Add(txtText).ForeColor = Color.Red
                                lv.SubItems.Add(txtText).ForeColor = Color.Red
                            Else
                                lv.SubItems.Add(txtText).ForeColor = Color.Blue
                                lv.SubItems.Add(txtText).ForeColor = Color.Blue
                                lv.SubItems.Add(txtText).ForeColor = Color.Blue
                                lv.SubItems.Add(txtText).ForeColor = Color.Blue
                            End If

                            AMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 00:00:00")
                            AMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 00:00:00")
                            PMIn = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 00:00:00")
                            PMOut = DateTime.Parse(datCheck).ToString("yyyy-MM-dd 00:00:00")
                            lv.SubItems.Add(DateDiff(DateInterval.Hour, AMIn, AMOut) + DateDiff(DateInterval.Hour, PMIn, PMOut))
                            lv.SubItems.Add(((DateDiff(DateInterval.Minute, AMIn, AMOut) + DateDiff(DateInterval.Minute, PMIn, PMOut)) Mod 60))


                            If datCheck > Now Then
                                temp = "0"

                            ElseIf txtText = "Saturday" Or txtText = "Sunday" Then
                                temp = "0"

                            ElseIf txtText = "Absent" Then
                                temp = "8"
                            End If

                            AT += temp
                            'TextBox3.Text = temp
                            lv.SubItems.Add("0")
                            lv.SubItems.Add("0")
                            lv.SubItems.Add("0")
                            lv.SubItems.Add("0")
                            lv.SubItems.Add(temp)

                        End If
                        drH.Close()
                        cmdH.Dispose()
                    End If
                End If
            End If
            'dr.Close()
            'cmd.Dispose()
            CONNECTION.Close()
            temp = "0"
            i = i + 1
        Loop

        'Dim x As String

        'VSLEM = New Double(59) {0.002, 0.004, 0.006, 0.008, 0.01, 0.012, 0.015, 0.017, 0.019, 0.021, _
        '                     0.023, 0.025, 0.027, 0.029, 0.031, 0.033, 0.035, 0.037, 0.04, 0.042, _
        '                     0.044, 0.046, 0.048, 0.05, 0.052, 0.054, 0.056, 0.058, 0.06, 0.062, _
        '                     0.065, 0.067, 0.069, 0.071, 0.073, 0.075, 0.077, 0.079, 0.081, 0.083, _
        '                     0.085, 0.087, 0.09, 0.092, 0.094, 0.096, 0.098, 0.1, 0.102, 0.104, _
        '                     0.106, 0.108, 0.11, 0.112, 0.015, 0.117, 0.119, 0.121, 0.123, 0.125}


        'Dim VLA, VLT, VLU, VLTE, VLUE As Double
        'Dim iCount As Integer
        'If AT <> 0 Then
        '    VLA = AT * 0.125
        '    If VLA >= VLBal Then
        '        VL = VLBal
        '        VLBal = "0.000"
        '        AT = (VLA - VLBal) / 0.125
        '    Else
        '        AT = 0
        '        If TT <> 0 Then
        '            VLBal = VLBal - VLA
        '            VLT = ((((TT / 60) - ((TT Mod 60) / 60)) * 0.125) + VSLEM(TT Mod 60) - 1)
        '            If VLT >= VLBal Then
        '                VL = VLBal
        '                VLBal = "0.000"
        '                iCount = 0
        '                Do While iCount >= 59
        '                    If Format((VLT - VLBal) Mod 0.125, "0.000") = VSLEM(iCount) Then
        '                        VLTE = iCount + 1
        '                        Exit Do
        '                    End If
        '                Loop
        '                TT = (((VLT - VLBal) / 0.125) * 60) + VLTE
        '            Else
        '                TT = 0
        '                VLBal = VLBal - VLT
        '                VLU = ((((UT / 60) - ((UT Mod 60) / 60)) * 0.125) + VSLEM(UT Mod 60) - 1)
        '                If VLU >= VLBal Then
        '                    VL = VLBal
        '                    VLBal = "0.000"
        '                    iCount = 0
        '                    Do While iCount >= 59
        '                        If Format((VLU - VLBal) Mod 0.125, "0.000") = VSLEM(iCount) Then
        '                            VLUE = iCount + 1
        '                            Exit Do
        '                        End If
        '                    Loop
        '                    UT = (((VLU - VLBal) / 0.125) * 60) + VLUE
        '                Else
        '                    UT = 0

        '                End If
        '            End If

        '        Else
        '            If TT <> 0 Then
        '                VLBal = VLBal - VLA
        '                VLT = ((((TT / 60) - ((TT Mod 60) / 60)) * 0.125) + VSLEM(TT Mod 60) - 1)
        '                If VLT >= VLBal Then
        '                    VL = VLBal
        '                    VLBal = "0.000"
        '                    iCount = 0
        '                    Do While iCount >= 59
        '                        If Format((VLT - VLBal) Mod 0.125, "0.000") = VSLEM(iCount) Then
        '                            VLTE = iCount + 1
        '                            Exit Do
        '                        End If
        '                    Loop
        '                    TT = (((VLT - VLBal) / 0.125) * 60) + VLTE
        '                Else
        '                    TT = 0
        '                    VLBal = VLBal - VLT
        '                    VLU = ((((UT / 60) - ((UT Mod 60) / 60)) * 0.125) + VSLEM(UT Mod 60) - 1)
        '                    If VLU >= VLBal Then
        '                        VL = VLBal
        '                        VLBal = "0.000"
        '                        iCount = 0
        '                        Do While iCount >= 59
        '                            If Format((VLU - VLBal) Mod 0.125, "0.000") = VSLEM(iCount) Then
        '                                VLUE = iCount + 1
        '                                Exit Do
        '                            End If
        '                        Loop
        '                        UT = (((VLU - VLBal) / 0.125) * 60) + VLUE
        '                    Else
        '                        UT = 0

        '                    End If
        '                End If
        '            End If
        '            End If
        '        End If
        'End If
        'VL = VLA + VLT + VLU
       

        'VL = ((((txtTotUnder.Text / 60) - ((txtTotUnder.Text Mod 60) / 60)) * 0.125) + (((txtTotUnder.Text Mod 60) * 0.002) + x))
        'MsgBox("YYYYYYYYYYYYYYYYYYYYYY")

        txtRHrs.Text = (((RT + 1) - OT) / 60) - ((((RT + 1) - OT) Mod 60) / 60)
        txtRMins.Text = ((RT + 1) - OT) Mod 60

        txtTHrs.Text = (TT / 60) - ((TT Mod 60) / 60)
        txtTMins.Text = TT Mod 60

        txtUHrs.Text = (UT / 60) - ((UT Mod 60) / 60)
        txtUMins.Text = UT Mod 60

        txtOTH.Text = (OT / 60) - ((OT Mod 60) / 60)
        txtOTM.Text = OT Mod 60

        txtAbsent.Text = AT
        txtTotUnder.Text = ((AT * 60) + TT + UT)
        txtTotUnder.Text = ((AT * 60) + TT + UT)
        txtReg.Text = txtNumDays.Text
        txtSat.Text = txtNumSat.Text
        LeaveCredits()
        SaveDTR()
    End Sub

    Private Sub frmDTR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbMonth.Text = Now.AddMonths(-1).ToString("MMMM")

        If Now.ToString("MMMM") = "January" Then
            txtYear.Value = Now.AddYears(-1).ToString("yyyy")
        Else
            txtYear.Value = Now.ToString("yyyy")
        End If
        strEmp = "SELECT empno, CONCAT(firstname,' ', Left(mi,1), '. ', surname) as Name, AMIN, AMOUT, PMIN, PMOUT, TIMEALLOWANCE from tbl_employees Where status=1 order by empno"
        lvDTR.Items.Clear()
        callEmp()
        callTimeSet()
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        strEmp = "SELECT empno, CONCAT(firstname,' ', Left(mi,1), '. ', surname) as Name, AMIN, AMOUT, PMIN, PMOUT, TIMEALLOWANCE from tbl_employees Where surname like '%" & TextBox4.Text & "%' and status=1 order by empno"
        Button4.Enabled = True
        callEmp()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        strEmp = "SELECT empno, CONCAT(firstname,' ', Left(mi,1), '. ', surname) as Name, AMIN, AMOUT, PMIN, PMOUT, TIMEALLOWANCE from tbl_employees Where status=1 order by empno"
        callEmp()
        Button4.Enabled = False
        TextBox4.Text = ""
    End Sub
   
    Private Sub callEmp()
        On Error Resume Next
        Dim i As Integer
        Dim dr As MySqlDataReader
        CONNECTION.Close()
        CONNECTION.Open()
        Dim cmd = New MySqlCommand(strEmp, CONNECTION)
        dr = cmd.ExecuteReader
        lvEmp.Items.Clear()
        Do While dr.Read
            Dim lv As ListViewItem = lvEmp.Items.Add(i + 1)
            lv.SubItems.Add(dr.Item(0))
            lv.SubItems.Add(UCase(dr.Item(1)))
            lv.SubItems.Add(dr.Item("AMIN"))
            lv.SubItems.Add(dr.Item("AMOUT"))
            lv.SubItems.Add(dr.Item("PMIN"))
            lv.SubItems.Add(dr.Item("PMOUT"))
            lv.SubItems.Add(dr.Item("TIMEALLOWANCE"))
            i = i + 1
        Loop
        dr.Close()
        cmd.Dispose()
        CONNECTION.Close()
    End Sub

    Private Sub lvEmp_KeyDown(sender As Object, e As KeyEventArgs) Handles lvEmp.KeyDown
        txtEmpNo.Text = lvEmp.SelectedItems(0).SubItems(1).Text
        txtName.Text = lvEmp.SelectedItems(0).SubItems(2).Text
        txtAMIN.Text = lvEmp.SelectedItems(0).SubItems(3).Text
        txtAMOut.Text = lvEmp.SelectedItems(0).SubItems(4).Text
        txtPMIN.Text = lvEmp.SelectedItems(0).SubItems(5).Text
        txtPMOut.Text = lvEmp.SelectedItems(0).SubItems(6).Text
        txtTimeA.Text = lvEmp.SelectedItems(0).SubItems(7).Text
        loadDays()
        loadDTR()
    End Sub

    Private Sub lvEmp_KeyUp(sender As Object, e As KeyEventArgs) Handles lvEmp.KeyUp
        txtEmpNo.Text = lvEmp.SelectedItems(0).SubItems(1).Text
        txtName.Text = lvEmp.SelectedItems(0).SubItems(2).Text
        txtAMIN.Text = lvEmp.SelectedItems(0).SubItems(3).Text
        txtAMOut.Text = lvEmp.SelectedItems(0).SubItems(4).Text
        txtPMIN.Text = lvEmp.SelectedItems(0).SubItems(5).Text
        txtPMOut.Text = lvEmp.SelectedItems(0).SubItems(6).Text
        txtTimeA.Text = lvEmp.SelectedItems(0).SubItems(7).Text
        loadDays()
        loadDTR()
    End Sub

    Private Sub lvEmp_MouseClick(sender As Object, e As MouseEventArgs) Handles lvEmp.MouseClick
        On Error Resume Next
        If lvEmp.Enabled = False Then
            MsgBox("Please click ""DONE"" to exit editing... ", vbInformation, vbOKOnly)
        Else
            txtEmpNo.Text = lvEmp.SelectedItems(0).SubItems(1).Text
            txtName.Text = lvEmp.SelectedItems(0).SubItems(2).Text
            txtAMIN.Text = lvEmp.SelectedItems(0).SubItems(3).Text
            txtAMOut.Text = lvEmp.SelectedItems(0).SubItems(4).Text
            txtPMIN.Text = lvEmp.SelectedItems(0).SubItems(5).Text
            txtPMOut.Text = lvEmp.SelectedItems(0).SubItems(6).Text
            txtTimeA.Text = lvEmp.SelectedItems(0).SubItems(7).Text
            loadDays()
            loadDTR()
        End If
    End Sub

    'Private Sub lvDTR_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvDTR.MouseDoubleClick
    '    frmTimeCheck.txtEmpID.Text = txtEmpNo.Text
    '    frmTimeCheck.txtName.Text = txtName.Text
    '    frmTimeCheck.txtDate.Text = (cbMonth.SelectedIndex + 1) & "/" & lvDTR.SelectedItems(0).Text & "/" & txtYear.Text

    '    Dim a, b, c, d As DateTime

    '    If Not DateTime.TryParseExact( _
    '    lvDTR.SelectedItems(0).SubItems(1).Text, "HH:mm:ss", Nothing, _
    '    Globalization.DateTimeStyles.None, a) Then
    '        frmTimeCheck.mtxtAMIN.Text = ""
    '    Else
    '        frmTimeCheck.mtxtAMIN.Text = Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(1).Text).ToString("HHmmss")
    '        frmTimeCheck.mtxtAMIN.ReadOnly = True
    '    End If

    '    If Not DateTime.TryParseExact( _
    '    lvDTR.SelectedItems(0).SubItems(2).Text, "HH:mm:ss", Nothing, _
    '    Globalization.DateTimeStyles.None, b) Then

    '        frmTimeCheck.mtxtAMOUT.Text = ""
    '    Else
    '        frmTimeCheck.mtxtAMOUT.Text = Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(2).Text).ToString("HHmmss")
    '        frmTimeCheck.mtxtAMOUT.ReadOnly = True
    '    End If

    '    If Not DateTime.TryParseExact( _
    '    lvDTR.SelectedItems(0).SubItems(3).Text, "HH:mm:ss", Nothing, _
    '    Globalization.DateTimeStyles.None, c) Then

    '        frmTimeCheck.mtxtPMIN.Text = ""
    '    Else
    '        frmTimeCheck.mtxtPMIN.Text = Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(3).Text).ToString("HHmmss")
    '        frmTimeCheck.mtxtPMIN.ReadOnly = True
    '    End If

    '    If Not DateTime.TryParseExact( _
    '   lvDTR.SelectedItems(0).SubItems(4).Text, "HH:mm:ss", Nothing, _
    '   Globalization.DateTimeStyles.None, d) Then

    '        frmTimeCheck.mtxtPMOUT.Text = ""
    '    Else
    '        frmTimeCheck.mtxtPMOUT.Text = Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(4).Text).ToString("HHmmss")
    '        frmTimeCheck.mtxtPMOUT.ReadOnly = True
    '    End If

    '    frmTimeCheck.ShowDialog()
    'End Sub

    Private Sub btnOT_Click(sender As Object, e As EventArgs) Handles btnOT.Click
        frmOT.ShowDialog()
    End Sub

    Public Sub LeaveCredits()
        txtVL.Text = VLBal
        txtSL.Text = SLBal
    End Sub


    Public Sub SaveDTR()
        Dim sqlSave, sqlSearch, x, remain As String
        Dim drSearch As MySqlDataReader
        Dim cmdSearch As MySqlCommand
 
        sqlSearch = "Select * from tblDTR where EmpNo='" & txtEmpNo.Text & "'"
        CONNECTION.Open()
        cmdSearch = New MySqlCommand(sqlSearch, CONNECTION)
        drSearch = cmdSearch.ExecuteReader

        If drSearch.HasRows Then
            sqlSave = "Update tblDTR SET " & _
                "RenderHrs='" & txtRHrs.Text & _
                "', RenderMins='" & txtRMins.Text & _
                "', TardHrs='" & txtTHrs.Text & _
                "', TardMins='" & txtTMins.Text & _
                "', UnderHrs='" & txtUHrs.Text & _
                "', UnderMins='" & txtUMins.Text & _
                "', Absent='" & txtAbsent.Text & _
                "', CreditUsed='" & VL & _
                "' Where EmpNo='" & txtEmpNo.Text & "' AND Month='" & cbMonth.Text & "' AND Year='" & txtYear.Value & "'"
        Else
            sqlSave = "INSERT INTO tblDTR SET " & _
               "RenderHrs='" & txtRHrs.Text & _
               "', RenderMins='" & txtRMins.Text & _
               "', TardHrs='" & txtTHrs.Text & _
               "', TardMins='" & txtTMins.Text & _
               "', UnderHrs='" & txtUHrs.Text & _
               "', UnderMins='" & txtUMins.Text & _
               "', Absent='" & txtAbsent.Text & _
               "', CreditUsed='" & VL & _
               "', EmpNo='" & txtEmpNo.Text & "' , Month='" & cbMonth.Text & "', Year='" & txtYear.Value & "'"
        End If

        'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        cmdSearch.Dispose()
        drSearch.Close()
        'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

        Dim cmdSave = New MySqlCommand(sqlSave, CONNECTION)
        Dim count = cmdSave.ExecuteNonQuery
        If count = 0 Then
            'MsgBox("Not Save")
        Else
            'MsgBox("Record Updated")
        End If
        cmdSave.Dispose()


        Dim strTotVL As String
        strTotVL = "Select SUM(CreditUsed) from tblDTR where EmpNo='" & txtEmpNo.Text & "' AND Year = '" & txtYear.Value & "'"
        Dim cmdTotVL = New MySqlCommand(strTotVL, CONNECTION)
        Dim drTotVL As MySqlDataReader
        Dim txt As String
        drTotVL = cmdTotVL.ExecuteReader

        Do While drTotVL.Read
            txt = drTotVL.Item(0).ToString
            'MsgBox("xxxxxxxxxxxxxxxxxxxx")
        Loop
        drTotVL.Close()
        cmdTotVL.Dispose()

        Dim strLC As String
        strLC = "Update tbllcearned SET VLUsed = '" & txt & "' Where EmpID='" & txtEmpNo.Text & "'"
        Dim cmdLC = New MySqlCommand(strLC, CONNECTION)
        cmdLC.ExecuteNonQuery()
        'MsgBox("xxxxxxxxxxxxxxxxxxxx")
        'txt = 0
        cmdLC.Dispose()

        CONNECTION.Close()
    End Sub

    Public Sub PrintToDS()
        On Error Resume Next
        Dim x, y As Integer
        'Dim dsDTRPrint As DataSet = New DataSet("DTR")
        Dim tblDTR = New DataTable
        tblDTR.Columns.Add("EmpID")
        tblDTR.Columns.Add("Name")
        tblDTR.Columns.Add("Month")
        tblDTR.Columns.Add("Year")
        tblDTR.Columns.Add("RegDay")
        tblDTR.Columns.Add("Sat")
        tblDTR.Columns.Add("Sun")
        tblDTR.Columns.Add("Date")
        tblDTR.Columns.Add("AMIn")
        tblDTR.Columns.Add("AMOut")
        tblDTR.Columns.Add("PMIn")
        tblDTR.Columns.Add("PMOut")
        tblDTR.Columns.Add("UTH")
        tblDTR.Columns.Add("UTM")
        tblDTR.Columns.Add("TU")
        tblDTR.Columns.Add("S1")
        tblDTR.Columns.Add("P1")
        tblDTR.Columns.Add("S2")
        tblDTR.Columns.Add("P2")



        x = 0
        txtRHrs.Text = lvEmp.Items.Count
        Do Until x = lvEmp.Items.Count
            Dim SP1, S1, SP2, S2 As String

            lvEmp.Items(x).Selected = True
            lvEmp.Select()
            txtEmpNo.Text = lvEmp.SelectedItems(0).Text
            txtName.Text = lvEmp.SelectedItems(0).SubItems(2).Text
            loadDays()
            loadDTR()
            y = 0
            Do Until y = lvDTR.Items.Count
                lvDTR.Items(y).Selected = True
                lvDTR.Select()
                If txtEmpNo.Text = "0002" Then
                    S1 = "MILAGROS C. MORALES"
                    SP1 = "Training Center Director"
                    S2 = ""
                    SP2 = ""
                ElseIf txtEmpNo.Text = "0001" Then
                    S1 = "DELIA P. GUZMAN"
                    SP1 = "Chief, Administrative Unit"
                    S2 = ""
                    SP2 = ""
                Else
                    S1 = "DELIA P. GUZMAN"
                    SP1 = "Chief, Administrative Unit"
                    S2 = "MILAGROS C. MORALES"
                    SP2 = "Training Center Director"
                End If
                'tblDTR.Rows.Add(txtEmpNo.Text, txtName.Text, cbMonth.Text, txtYear.Value, txtReg.Text, txtSat.Text, 2, lvDTR.SelectedItems(0).Text, lvDTR.SelectedItems(0).SubItems(1).Text, lvDTR.SelectedItems(0).SubItems(2).Text, lvDTR.SelectedItems(0).SubItems(3).Text, lvDTR.SelectedItems(0).SubItems(4).Text, Int((Val(lvDTR.SelectedItems(0).SubItems(7).Text) + Val(lvDTR.SelectedItems(0).SubItems(8).Text)) / 60), ((Val(lvDTR.SelectedItems(0).SubItems(7).Text) + Val(lvDTR.SelectedItems(0).SubItems(8).Text)) Mod 60), txtTotUnder.Text, S1, SP1, S2, SP2)
                tblDTR.Rows.Add(txtEmpNo.Text, txtName.Text, cbMonth.Text, txtYear.Value, txtReg.Text, txtSat.Text, 2, lvDTR.SelectedItems(0).Text, lvDTR.SelectedItems(0).SubItems(1).Text, lvDTR.SelectedItems(0).SubItems(2).Text, lvDTR.SelectedItems(0).SubItems(3).Text, lvDTR.SelectedItems(0).SubItems(4).Text, Int((Val(lvDTR.SelectedItems(0).SubItems(5).Text))), Val(lvDTR.SelectedItems(0).SubItems(6).Text), txtTotUnder.Text, S1, SP1, S2, SP2)

                lvDTR.Items(y).Selected = False
                y += 1
            Loop
            lvEmp.Items(x).Selected = False
            x += 1
        Loop

        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New DTR
        rptDoc.SetDataSource(tblDTR)

        Form2.CrystalReportViewer1.ReportSource = rptDoc
        Form2.ShowDialog()
        Form2.Dispose()
        'dsDTRPrint.Tables.Add(tblDTR)

    End Sub
    Public Sub PrintIndividual()
        On Error Resume Next
        Dim x, y As Integer
        'Dim dsDTRPrint As DataSet = New DataSet("DTR")
        Dim tblDTR = New DataTable
        tblDTR.Columns.Add("EmpID")
        tblDTR.Columns.Add("Name")
        tblDTR.Columns.Add("Month")
        tblDTR.Columns.Add("Year")
        tblDTR.Columns.Add("RegDay")
        tblDTR.Columns.Add("Sat")
        tblDTR.Columns.Add("Sun")
        tblDTR.Columns.Add("Date")
        tblDTR.Columns.Add("AMIn")
        tblDTR.Columns.Add("AMOut")
        tblDTR.Columns.Add("PMIn")
        tblDTR.Columns.Add("PMOut")
        tblDTR.Columns.Add("UTH")
        tblDTR.Columns.Add("UTM")
        tblDTR.Columns.Add("TU")
        tblDTR.Columns.Add("S1")
        tblDTR.Columns.Add("P1")
        tblDTR.Columns.Add("S2")
        tblDTR.Columns.Add("P2")

        y = 0
        Do Until y = lvDTR.Items.Count
            Dim SP1, S1, SP2, S2 As String
            lvDTR.Items(y).Selected = True
            lvDTR.Select()
            If txtEmpNo.Text = "0002" Then
                S1 = "MILAGROS C. MORALES"
                SP1 = "Training Center Director"
                S2 = ""
                SP2 = ""
            ElseIf txtEmpNo.Text = "0001" Then
                S1 = "DELIA P. GUZMAN"
                SP1 = "Chief, Administrative Unit"
                S2 = ""
                SP2 = ""
            Else
                S1 = "DELIA P. GUZMAN"
                SP1 = "Chief, Administrative Unit"
                S2 = "MILAGROS C. MORALES"
                SP2 = "Training Center Director"
            End If
            tblDTR.Rows.Add(txtEmpNo.Text, txtName.Text, cbMonth.Text, txtYear.Value, txtReg.Text, txtSat.Text, 2, lvDTR.SelectedItems(0).Text, lvDTR.SelectedItems(0).SubItems(1).Text, lvDTR.SelectedItems(0).SubItems(2).Text, lvDTR.SelectedItems(0).SubItems(3).Text, lvDTR.SelectedItems(0).SubItems(4).Text, Int((Val(lvDTR.SelectedItems(0).SubItems(5).Text))), Val(lvDTR.SelectedItems(0).SubItems(6).Text), txtTotUnder.Text, S1, SP1, S2, SP2)
            'tblDTR.Rows.Add(txtEmpNo.Text, txtName.Text, cbMonth.Text, txtYear.Value, txtReg.Text, txtSat.Text, 2, lvDTR.SelectedItems(0).Text, lvDTR.SelectedItems(0).SubItems(1).Text, lvDTR.SelectedItems(0).SubItems(2).Text, lvDTR.SelectedItems(0).SubItems(3).Text, lvDTR.SelectedItems(0).SubItems(4).Text, Int((Val(lvDTR.SelectedItems(0).SubItems(7).Text) + Val(lvDTR.SelectedItems(0).SubItems(8).Text)) / 60), ((Val(lvDTR.SelectedItems(0).SubItems(7).Text) + Val(lvDTR.SelectedItems(0).SubItems(8).Text)) Mod 60), txtTotUnder.Text, S1, SP1, S2, SP2)
            lvDTR.Items(y).Selected = False
            y += 1
        Loop

        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New DTR
        rptDoc.SetDataSource(tblDTR)

        Form2.CrystalReportViewer1.ReportSource = rptDoc
        Form2.ShowDialog()
        Form2.Dispose()
        'dsDTRPrint.Tables.Add(tblDTR)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintToDS()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintIndividual()
    End Sub

    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    Dim bCancelEdit As Boolean
    Dim CurrentSB As ListViewItem.ListViewSubItem
    Dim CurrentItem As ListViewItem
    Private Sub lvlvDTR_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvDTR.MouseDoubleClick

        ' This subroutine checks where the double-clicking was performed and
        ' initiates in-line editing if user double-clicked on the right subitem

        ' check where clicked
        CurrentItem = lvDTR.GetItemAt(e.X, e.Y)     ' which listviewitem was clicked
        If CurrentItem Is Nothing Then Exit Sub
        CurrentSB = CurrentItem.GetSubItemAt(e.X, e.Y)  ' which subitem was clicked

        ' See which column has been clicked

        ' NOTE: This portion is important. Here you can define your own
        '       rules as to which column can be edited and which cannot.
        Dim iSubIndex As Integer = CurrentItem.SubItems.IndexOf(CurrentSB)
        Select Case iSubIndex
            Case 1, 2, 3, 4
                ' These two columns are allowed to be edited. So continue the code
            Case Else
                ' In my example I have defined that only "Runs"
                ' and "Wickets" columns can be edited by user
                Exit Sub
        End Select
        'If CurrentSB.Text <> "Saturday" And CurrentSB.Text <> "Sunday" And CurrentSB.Text <> "On Travel" Then
        Dim lLeft = CurrentSB.Bounds.Left + 1
        Dim lWidth As Integer = CurrentSB.Bounds.Width
        With TextBox1
            .SetBounds(lLeft + lvDTR.Left, CurrentSB.Bounds.Top + _
                       lvDTR.Top, lWidth, CurrentSB.Bounds.Height)
            .Text = CurrentSB.Text
            .Show()
            .Focus()
        End With
        cmdDone.Enabled = True
        lvEmp.Enabled = False
        cbMonth.Enabled = False
        txtYear.Enabled = False
        'End If
    End Sub

    'Private Sub LV_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles lvDTR.KeyDown
    '    ' This subroutine is for starting editing when keyboard shortcut is pressed (e.g. F2 key)
    '    Dim i As Integer
    '    If lvDTR.SelectedItems.Count = 0 Then Exit Sub

    '    Select Case e.KeyCode
    '        Case Keys.F2    ' F2 key is pressed. Initiate editing
    '            e.Handled = True
    '            BeginEditListItem(lvDTR.SelectedItems(0), 1)
    '    End Select
    'End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        ' This subroutine closes the text box

        Select Case e.KeyChar

            Case Microsoft.VisualBasic.ChrW(Keys.Return)    ' Enter key is pressed
                bCancelEdit = False ' editing completed
                e.Handled = True
                TextBox1.Hide()
                'If cmdAdd.Text = "Add" Then
                '    btnAction = 1
                '    cmbGrade.Enabled = False
                '    cmdAdd.Text = "Save"
                'End If
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)    ' Escape key is pressed
                bCancelEdit = True  ' editing was cancelled
                e.Handled = True
                TextBox1.Hide()
        End Select
    End Sub
    Public Sub callTimeSet()
        On Error Resume Next
        Dim strSQL As String
        Dim dr As MySqlDataReader
        Dim cmd As New MySqlCommand

        strSQL = "SELECT * from tbl_time"
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()

        Do While dr.Read()
            txtTimeInAM.Text = dr.Item(0).ToString
            txtTimeOutAM.Text = dr.Item(1).ToString
            txtTimeInPM.Text = dr.Item(2).ToString
            txtTimeOutPM.Text = dr.Item(3).ToString
            txtAllowance.Text = dr.Item(4).ToString
        Loop
        dr.Close()
        cmd.Dispose()
        CONNECTION.Close()

    End Sub

    Public Sub HollidayChange()
        '    Dim strHS As String
        '    Dim sql As String
        '    Dim drHS As MySqlDataReader

        '    strHS = "Select * from tbl_holiday where " & _
        '         "HolidayDate = '" & DateTime.Parse(datCheck).ToString("MM/dd/yyyy") & "' and Status = 'Yes'"
        '    Dim cmdHS = New MySqlCommand(strHS, CONNECTION)
        '    drHS = cmdHS.ExecuteReader
        '    If drHS.HasRows Then
        '        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

        '        sql = "UPDATE tbl_dtr SET " & fieldData & "='" & CurrentSB.Text & _
        '        "', tardiness_mins='" & lateAM + latePM & _
        '        "', undertime_mins='" & underAM + underPM & _
        '        "', render_mins='" & (TRender - (underAM + underPM + lateAM + latePM)) & _
        '        "', excess_mins='" & OT & _
        '        " ' where date1='" & DateTime.Parse(datCheck).ToString("yyyy-MM-dd") & "' and empno='" & txtEmpNo.Text & "'"
        '    End If
    End Sub

    Public Sub saveChanges()
        On Error Resume Next
        Dim cDateInAM, cDateOutAM, cDateInPM, cDateOutPM As DateTime
        Dim TRender, amTIN, amTOut, pmTIN, pmTOut, OT As String
        cDateInAM = Convert.ToDateTime(txtTimeInAM.Text).AddDays(-1)
        cDateOutAM = Convert.ToDateTime(txtTimeOutAM.Text)
        cDateInPM = Convert.ToDateTime(txtTimeInPM.Text)
        cDateOutPM = Convert.ToDateTime(txtTimeOutPM.Text)
        Dim sql, sqlSearch, fieldData As String
        Dim Dates As String
        Dates = txtYear.Text & "-" & (cbMonth.SelectedIndex + 1) & "-" & lvDTR.SelectedItems(0).Text

        If CurrentItem.SubItems.IndexOf(CurrentSB) = 1 Then
            fieldData = "timein_am"
        ElseIf CurrentItem.SubItems.IndexOf(CurrentSB) = 2 Then
            fieldData = "timeout_am"
        ElseIf CurrentItem.SubItems.IndexOf(CurrentSB) = 3 Then
            fieldData = "timein_pm"
        ElseIf CurrentItem.SubItems.IndexOf(CurrentSB) = 4 Then
            fieldData = "timeout_pm"
        End If

        d1.Text = IsDate(lvDTR.SelectedItems(0).SubItems(1).Text)
        d2.Text = IsDate(lvDTR.SelectedItems(0).SubItems(2).Text)
        d3.Text = IsDate(lvDTR.SelectedItems(0).SubItems(3).Text)
        d4.Text = IsDate(lvDTR.SelectedItems(0).SubItems(4).Text)

        Dim dr As MySqlDataReader
        Dim lateAM, latePM, underAM, underPM As Integer
        sqlSearch = "SELECT * from tbl_dtr where date1='" & DateTime.Parse(Dates).ToString("yyyy-MM-dd") & "' and empno='" & txtEmpNo.Text & "'"
        CONNECTION.Close()
        CONNECTION.Open()
        Dim cmd = New MySqlCommand(sqlSearch, CONNECTION)
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            Do While dr.Read
                If IsDate(lvDTR.SelectedItems(0).SubItems(1).Text) = True And IsDate(lvDTR.SelectedItems(0).SubItems(2).Text) = True And IsDate(lvDTR.SelectedItems(0).SubItems(3).Text) = True And IsDate(lvDTR.SelectedItems(0).SubItems(4).Text) = True Then
                    If DateTime.Parse(Dates).ToString("dddd") = "Monday" Then
                        If DateDiff(DateInterval.Minute, Convert.ToDateTime(txtAMIN.Text), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(1).Text)) > 0 Then
                            lateAM = (DateDiff(DateInterval.Minute, Convert.ToDateTime(txtAMIN.Text), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(1).Text)))
                            amTIN = lvDTR.SelectedItems(0).SubItems(1).Text
                        Else
                            lateAM = 0
                            amTIN = txtAMIN.Text
                        End If
                    Else
                        If DateDiff(DateInterval.Minute, Convert.ToDateTime(txtAMIN.Text), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(1).Text)) > txtTimeA.Text Then
                            lateAM = (DateDiff(DateInterval.Minute, Convert.ToDateTime(txtAMIN.Text), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(1).Text)) - txtTimeA.Text)
                            amTIN = lvDTR.SelectedItems(0).SubItems(1).Text
                        Else
                            lateAM = 0
                            amTIN = txtAMIN.Text
                        End If
                    End If
                    If DateDiff(DateInterval.Minute, Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(2).Text), Convert.ToDateTime(txtAMOut.Text)) > 0 Then
                        underAM = DateDiff(DateInterval.Minute, Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(2).Text), Convert.ToDateTime(txtAMOut.Text))
                        amTOut = lvDTR.SelectedItems(0).SubItems(2).Text
                    Else
                        underAM = 0
                        amTOut = txtAMOut.Text
                    End If
                    If DateDiff(DateInterval.Minute, Convert.ToDateTime(txtPMIN.Text), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(3).Text)) > txtTimeA.Text Then
                        latePM = (DateDiff(DateInterval.Minute, Convert.ToDateTime(txtPMIN.Text), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(3).Text)) - txtTimeA.Text)
                        pmTIN = lvDTR.SelectedItems(0).SubItems(3).Text
                    Else
                        latePM = 0
                        pmTIN = txtPMIN.Text
                    End If

                    If DateDiff(DateInterval.Minute, Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(4).Text), Convert.ToDateTime(txtAMOut.Text)) > 0 Then
                        underPM = DateDiff(DateInterval.Minute, Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(4).Text), Convert.ToDateTime(txtPMOut.Text))
                    Else
                        underPM = 0
                    End If
                    TRender = DateDiff(DateInterval.Minute, Convert.ToDateTime(amTIN), Convert.ToDateTime(amTOut)) + DateDiff(DateInterval.Minute, Convert.ToDateTime(pmTIN), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(4).Text))
                    OT = DateDiff(DateInterval.Minute, Convert.ToDateTime(txtPMOut.Text), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(4).Text))
                    If DateTime.Parse(Dates).ToString("dddd") = "Saturday" Or DateTime.Parse(Dates).ToString("dddd") = "Sunday" Then
                        lateAM = 0
                        latePM = 0
                        underAM = 0
                        underPM = 0
                        OT = TRender
                    End If
                    ' (underAM + underPM + lateAM + latePM)
                    sql = "UPDATE tbl_dtr SET " & fieldData & "='" & CurrentSB.Text & _
                        "', tardiness_mins='" & lateAM + latePM & _
                        "', undertime_mins='" & underAM + underPM & _
                        "', render_mins='" & (TRender) & _
                        "', excess_mins='" & OT & _
                        " ' where date1='" & DateTime.Parse(Dates).ToString("yyyy-MM-dd") & "' and empno='" & txtEmpNo.Text & "'"
                Else
                    If (IsDate(lvDTR.SelectedItems(0).SubItems(1).Text) = True And IsDate(lvDTR.SelectedItems(0).SubItems(2).Text) = True) Then

                        If DateDiff(DateInterval.Minute, Convert.ToDateTime(txtAMIN.Text), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(1).Text)) > txtTimeA.Text Then
                            lateAM = (DateDiff(DateInterval.Minute, Convert.ToDateTime(txtAMIN.Text), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(1).Text)) - txtTimeA.Text)
                            amTIN = lvDTR.SelectedItems(0).SubItems(1).Text
                        Else
                            lateAM = 0
                            amTIN = txtAMIN.Text
                        End If
                        If DateDiff(DateInterval.Minute, Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(2).Text), Convert.ToDateTime(txtAMOut.Text)) > 0 Then
                            underAM = DateDiff(DateInterval.Minute, Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(2).Text), Convert.ToDateTime(txtAMOut.Text))
                            amTOut = lvDTR.SelectedItems(0).SubItems(2).Text
                        Else
                            underAM = 0
                            amTOut = txtAMOut.Text
                        End If
                        'OT = DateDiff(DateInterval.Minute, Convert.ToDateTime(txtPMOut.Text), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(4).Text))
                        TRender = DateDiff(DateInterval.Minute, Convert.ToDateTime(amTIN), Convert.ToDateTime(amTOut))
                        If DateTime.Parse(Dates).ToString("dddd") = "Saturday" Or DateTime.Parse(Dates).ToString("dddd") = "Sunday" Then
                            lateAM = 0
                            underAM = 0
                            TRender = DateDiff(DateInterval.Minute, Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(1).Text), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(2).Text))
                            OT = TRender
                        End If
                        ' - (underAM + lateAM)
                        sql = "UPDATE tbl_dtr SET " & fieldData & "='" & CurrentSB.Text & _
                            "', tardiness_mins='" & lateAM & _
                            "', undertime_mins='" & underAM & _
                            "', render_mins='" & (TRender) & _
                            "', excess_mins='" & OT & _
                            " ' where date1='" & DateTime.Parse(Dates).ToString("yyyy-MM-dd") & "' and empno='" & txtEmpNo.Text & "'"

                    ElseIf (IsDate(lvDTR.SelectedItems(0).SubItems(3).Text) = True And IsDate(lvDTR.SelectedItems(0).SubItems(4).Text) = True) Then
                        If DateDiff(DateInterval.Minute, Convert.ToDateTime(txtPMIN.Text), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(3).Text)) > txtTimeA.Text Then
                            latePM = (DateDiff(DateInterval.Minute, Convert.ToDateTime(txtPMIN.Text), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(3).Text)) - txtTimeA.Text)
                            pmTIN = lvDTR.SelectedItems(0).SubItems(3).Text
                        Else
                            latePM = 0
                            pmTIN = txtPMIN.Text
                        End If
                        If DateDiff(DateInterval.Minute, Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(4).Text), cDateOutPM) > 360 Then
                            underPM = DateDiff(DateInterval.Minute, Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(4).Text), cDateOutPM) - 360
                        Else
                            underPM = 0
                        End If
                        TRender = DateDiff(DateInterval.Minute, Convert.ToDateTime(pmTIN), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(4).Text))
                        OT = DateDiff(DateInterval.Minute, Convert.ToDateTime(txtPMOut.Text), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(4).Text))
                        If DateTime.Parse(Dates).ToString("dddd") = "Saturday" Or DateTime.Parse(Dates).ToString("dddd") = "Sunday" Then
                            latePM = 0
                            underPM = 0
                            OT = TRender
                        End If
                        ' - (underPM + latePM)
                        sql = "UPDATE tbl_dtr SET " & fieldData & "='" & CurrentSB.Text & _
                            "', tardiness_mins='" & latePM & _
                            "', undertime_mins='" & underPM & _
                            "', render_mins='" & (TRender) & _
                            "', excess_mins='" & OT & _
                            " ' where date1='" & DateTime.Parse(Dates).ToString("yyyy-MM-dd") & "' and empno='" & txtEmpNo.Text & "'"
                    ElseIf (IsDate(lvDTR.SelectedItems(0).SubItems(1).Text) = True And IsDate(lvDTR.SelectedItems(0).SubItems(4).Text) = True) And (IsDate(lvDTR.SelectedItems(0).SubItems(2).Text) = False And IsDate(lvDTR.SelectedItems(0).SubItems(3).Text) = False) Then
                        If DateDiff(DateInterval.Minute, Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(4).Text), cDateOutPM) > 360 Then
                            underPM = DateDiff(DateInterval.Minute, Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(4).Text), cDateOutPM) - 360
                        Else
                            underPM = 0
                        End If
                        If DateTime.Parse(Dates).ToString("dddd") = "Monday" Then
                            If DateDiff(DateInterval.Minute, Convert.ToDateTime(txtAMIN.Text), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(1).Text)) > 0 Then
                                lateAM = (DateDiff(DateInterval.Minute, Convert.ToDateTime(txtAMIN.Text), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(1).Text)))
                                amTIN = lvDTR.SelectedItems(0).SubItems(1).Text
                            Else
                                lateAM = 0
                                amTIN = txtAMIN.Text
                            End If
                        Else
                            If DateDiff(DateInterval.Minute, Convert.ToDateTime(txtAMIN.Text), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(1).Text)) > txtTimeA.Text Then
                                lateAM = (DateDiff(DateInterval.Minute, Convert.ToDateTime(txtAMIN.Text), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(1).Text)) - txtTimeA.Text)
                                amTIN = lvDTR.SelectedItems(0).SubItems(1).Text
                            Else
                                lateAM = 0
                                amTIN = txtAMIN.Text
                            End If
                        End If
                        TRender = DateDiff(DateInterval.Minute, Convert.ToDateTime(amTIN), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(4).Text))
                        OT = DateDiff(DateInterval.Minute, Convert.ToDateTime(txtPMOut.Text), Convert.ToDateTime(lvDTR.SelectedItems(0).SubItems(4).Text))
                        If DateTime.Parse(Dates).ToString("dddd") = "Saturday" Or DateTime.Parse(Dates).ToString("dddd") = "Sunday" Then
                            lateAM = 0
                            underPM = 0
                            OT = TRender
                        End If
                        ' - (underPM + lateAM)
                        sql = "UPDATE tbl_dtr SET " & fieldData & "='" & CurrentSB.Text & _
                            "', tardiness_mins='" & lateAM & _
                            "', undertime_mins='" & underPM & _
                            "', render_mins='" & (TRender) - 60 & _
                            "', excess_mins='" & OT & _
                            " ' where date1='" & DateTime.Parse(Dates).ToString("yyyy-MM-dd") & "' and empno='" & txtEmpNo.Text & "'"
                    Else
                        sql = "UPDATE tbl_dtr SET " & fieldData & "='" & CurrentSB.Text & _
                            "', tardiness_mins='" & 0 & _
                            "', undertime_mins='" & 0 & _
                            "', render_mins='" & 0 & _
                            " ' where date1='" & DateTime.Parse(Dates).ToString("yyyy-MM-dd") & "' and empno='" & txtEmpNo.Text & "'"
                    End If
                End If
            Loop
            btnAction = 1
            'MsgBox("No record found1")
        Else
            sql = "INSERT tbl_dtr SET " & fieldData & "='" & CurrentSB.Text & "', empno='" & txtEmpNo.Text & "', date1='" & DateTime.Parse(Dates).ToString("yyyy-MM-dd") & "'"
            btnAction = 2
            'MsgBox("Records updated1")
        End If
        dr.Close()
        cmd.Dispose()
        CONNECTION.Close()


        CONNECTION.Open()
        Dim SqlCommand As New MySqlCommand
        Dim Count As Integer
        SqlCommand.Connection = CONNECTION
        SqlCommand.CommandText = sql

        Count = SqlCommand.ExecuteNonQuery()
        If Count = 0 Then
            'MsgBox("No record found")
        Else
            'MsgBox("Records updated")
        End If
        SqlCommand.Dispose()
        CONNECTION.Close()
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox1.LostFocus

        TextBox1.Hide()

        If bCancelEdit = False Then

            If TextBox1.Text.Trim <> "" Then

                ' NOTE: You can define your validation rules here. In my example I've
                '       set that only numbers can be entered in "Runs" and "Wickets" column

                ' Validate
                'TextBox2.Text = CurrentItem.SubItems.IndexOf(CurrentSB)
                If IsNumeric(TextBox1.Text) = False Then
                    CurrentSB.Text = TextBox1.Text
                Else
                    CurrentSB.Text = CInt(TextBox1.Text).ToString("##:##:##")
                End If
                If IsDate(CurrentSB.Text) = True Then
                    saveChanges()
                End If
                ' update listviewitem

                'If cmdAdd.Text = "Add" Then
                '    btnAction = 1
                '    cmbGrade.Enabled = False
                '    cmdAdd.Text = "Save"
                'End If

                ' save changes so that next time you load this XML document the changes are there.
                Dim iSubIndex As Integer = CurrentItem.SubItems.IndexOf(CurrentSB)
                Dim szPropertyName As String

                If iSubIndex = 2 Then
                    szPropertyName = "Runs"
                Else
                    szPropertyName = "Wickets"
                End If

            End If
        Else
            ' Editing was cancelled by user
            bCancelEdit = False
        End If
        lvDTR.Focus()
    End Sub
    Private Sub BeginEditListItem(iTm As ListViewItem, SubItemIndex As Integer)
        ' This subroutine is for manually initiating editing instead of mouse double-clicks

        Dim pt As Point = iTm.SubItems(SubItemIndex).Bounds.Location
        Dim ee As New System.Windows.Forms.MouseEventArgs(Windows.Forms.MouseButtons.Left, 1, pt.X, pt.Y, 0)
        Call lvlvDTR_MouseDoubleClick(lvDTR, ee)
    End Sub
    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click
        cmdDone.Enabled = False
        lvEmp.Enabled = True
        cbMonth.Enabled = True
        txtYear.Enabled = True
        loadDTR()
    End Sub

    Private Sub cbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMonth.SelectedIndexChanged
        If txtEmpNo.Text.Trim = "" Then
            Exit Sub
        Else
            loadDays()
            loadDTR()
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.Text <> "Clear" Then
            lvEmp.CheckBoxes = True
            Button5.Text = "Clear"
        Else
            lvEmp.CheckBoxes = False
            Button5.Text = "Select Employee"
        End If
    End Sub
End Class