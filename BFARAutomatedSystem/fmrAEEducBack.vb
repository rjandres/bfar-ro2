Imports MySql.Data.MySqlClient
Public Class fmrAEEducBack

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        On Error Resume Next
        Dim sql As String
        If cbLevel.Text = "" Then
            MsgBox("Please fill-up Level...")
            cbLevel.Focus()
            Exit Sub
        End If
        If txtSchool.Text = "" Then
            MsgBox("Please fill-up School Name...")
            txtSchool.Focus()
            Exit Sub
        End If
        If txtCourse.Text = "" Then
            MsgBox("Please fill-up Degree Course....")
            txtCourse.Focus()
            Exit Sub
        End If
        If txtYearGraduate.Text = "" Then
            MsgBox("Please fill-up Year Graduated...")
            txtYearGraduate.Focus()
            Exit Sub
        End If
        If txtUnitEarned.Text = "" Then
            MsgBox("Please fill-up Highest Grade/Level/Units Earned...")
            txtUnitEarned.Focus()
            Exit Sub
        End If
        If txtFrom.Text = "" Then
            txtFrom.Text = "N/A"
            'MsgBox("Please fill-up Inclusive Dates of Attendance From/To...")
            'txtFrom.Focus()
            'Exit Sub
        End If
        If txtTo.Text = "" Then
            txtTo.Text = "N/A"
            'MsgBox("Please fill-up Inclusive Dates of Attendance From/To...")
            'txtTo.Focus()
            'Exit Sub
        End If
        If txtHonor.Text = "" Then
            MsgBox("Please fill-up Scholarship/Academic Honors Received")
            txtHonor.Focus()
            Exit Sub
        End If

        CONNECTION.Open()
        If btnAction = 1 Then
            sql = "UPDATE tbl_educational SET empno= '" & txtEmpNo.Text & _
            "', Level='" & cbLevel.Text & _
            "', NameOfSchool='" & txtSchool.Text & _
            "', DegreeCourse='" & txtCourse.Text & _
            "', YearGraduated='" & txtYearGraduate.Text & _
            "', HighestGrade='" & txtUnitEarned.Text & _
            "', InclusiveFrom='" & txtFrom.Text & _
            "', InclusiveTo='" & txtTo.Text & _
            "', Academichonor='" & txtHonor.Text & "' WHERE ctrno='" & txtCTRL.Text & "'"
        ElseIf btnAction = 2 Then
            sql = "INSERT INTO tbl_educational SET empno= '" & txtEmpNo.Text & _
            "', Level='" & cbLevel.Text & _
            "', NameOfSchool='" & txtSchool.Text & _
            "', DegreeCourse='" & txtCourse.Text & _
            "', YearGraduated='" & txtYearGraduate.Text & _
            "', HighestGrade='" & txtUnitEarned.Text & _
            "', InclusiveFrom='" & txtFrom.Text & _
            "', InclusiveTo='" & txtTo.Text & _
            "', Academichonor='" & txtHonor.Text & "'"
        End If

        Dim SqlCommand As New MySqlCommand
        Dim Count As Integer
        SqlCommand.Connection = CONNECTION
        SqlCommand.CommandText = sql

        Count = SqlCommand.ExecuteNonQuery()
        If Count = 0 Then
            MsgBox("No record found")
            Exit Sub
        Else
            MsgBox("Records updated")
        End If
        btnAction = 0
        SqlCommand.Dispose()
        CONNECTION.Close()
        PersonalInfo.callPersonalInfo()
        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub txtYearGraduate_TextChanged(sender As Object, e As EventArgs) Handles txtYearGraduate.TextChanged
        If txtYearGraduate.Text = "" Or IsNumeric(txtYearGraduate.Text) = False Then
            txtYearGraduate.Text = "N/A"
            txtYearGraduate.SelectAll()
            txtFrom.Text = "N/A"
            txtTo.Text = "N/A"
            txtFrom.ReadOnly = False
            txtTo.ReadOnly = False
            Exit Sub
        End If

        txtFrom.Text = txtYearGraduate.Text - 4
        txtTo.Text = txtYearGraduate.Text
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        btnAction = 0
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub fmrAEEducBack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CONNECTION.Close()
    End Sub
End Class