Imports MySql.Data.MySqlClient
Public Class frmAEOtherInfo

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        txtOption.Text = 33
        txtOptDesc.Text = RadioButton1.Text
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        txtOption.Text = 34
        txtOptDesc.Text = RadioButton2.Text
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        txtOption.Text = 35
        txtOptDesc.Text = RadioButton3.Text
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        On Error Resume Next

        Dim sql As String
        CONNECTION.Open()

        If txtOptDesc.Text = "" Then
            txtOptDesc.Focus()
            Exit Sub
        End If

        If btnAction = 1 Then
            sql = "UPDATE tbl_otherinfo SET desc1='" & txtOptDesc.Text & "' WHERE empno = '" & txtEmpNo.Text & "' AND ctrno='" & txtCTRL.Text & "'"
        ElseIf btnAction = 2 Then
            sql = "INSERT INTO tbl_otherinfo SET empno= '" & txtEmpNo.Text & _
            "', part1='" & txtOption.Text & _
            "', desc1='" & txtOptDesc.Text & "'"
        End If

        Dim SqlCommand As New MySqlCommand
        Dim Count As Integer
        SqlCommand.Connection = CONNECTION
        SqlCommand.CommandText = sql

        Count = SqlCommand.ExecuteNonQuery()
        If Count = 0 Then
            MsgBox("No record found")
            'Exit Sub
        Else
            MsgBox("Records updated")

        End If
        SqlCommand.Dispose()
        CONNECTION.Close()
        btnAction = 0
        Me.Dispose()
        Me.Close()
        PersonalInfo.callPersonalInfo()


    End Sub
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        btnAction = 0
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub frmAEOtherInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CONNECTION.Close()
    End Sub
End Class