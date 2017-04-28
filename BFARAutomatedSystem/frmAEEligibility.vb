Imports MySql.Data.MySqlClient
Public Class frmAEEligibility
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        On Error Resume Next
        Dim sql As String

        If txtCareer.Text = "" Then
            MsgBox("Please fill-up the Career Service/RA 1080 (Board/BAR) Under Special Laws/CES/CSEE")
            txtCareer.Focus()
            Exit Sub
        End If
        If txtRating.Text = "" Then
            MsgBox("Please fill-up RATING")
            txtRating.Focus()
            Exit Sub
        End If
        If txtExamPlace.Text = "" Then
            MsgBox("Please fill-up PLACE OF EXAMINATION / CONFERMENT")
            txtExamPlace.Focus()
            Exit Sub
        End If
        If txtLicense.Text = "" Then
            MsgBox("Please fill-up LICENSE NUMBER")
            txtLicense.Focus()
            Exit Sub
        End If

        CONNECTION.Open()
        If btnAction = 1 Then
            sql = "UPDATE tbl_eligibility SET empno= '" & txtEmpNo.Text & _
            "', CareerService='" & txtCareer.Text & _
            "', Rating='" & txtRating.Text & _
            "', DateofExamination='" & dtExamDate.Text & _
            "', PlaceofExamination='" & txtExamPlace.Text & _
            "', LicenseNo='" & txtLicense.Text & _
            "', LicenseDateRelease='" & dtLicenseDate.Text & "' WHERE empno = '" & txtEmpNo.Text & "' AND ctrno='" & txtCTRL.Text & "'"
        ElseIf btnAction = 2 Then
            sql = "INSERT INTO tbl_eligibility SET empno= '" & txtEmpNo.Text & _
           "', CareerService='" & txtCareer.Text & _
            "', Rating='" & txtRating.Text & _
            "', DateofExamination='" & dtExamDate.Text & _
            "', PlaceofExamination='" & txtExamPlace.Text & _
            "', LicenseNo='" & txtLicense.Text & _
            "', LicenseDateRelease='" & dtLicenseDate.Text & "'"
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

        SqlCommand.Dispose()
        CONNECTION.Close()
        PersonalInfo.callPersonalInfo()
        btnAction = 0
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        btnAction = 0
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub frmAEEligibility_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CONNECTION.Close()
    End Sub
End Class