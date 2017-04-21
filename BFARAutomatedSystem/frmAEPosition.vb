Imports MySql.Data.MySqlClient

Public Class frmAEPosition


    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        On Error Resume Next

        Dim sql As String
        CONNECTION.Open()

        If txtPosition.Text = "" Then
            txtPosition.Focus()
            Exit Sub
        End If

        If btnAction = 1 Then

            sql = "UPDATE tbl_positioncode SET position_code= '" & txtCode.Text & _
            "', position_designation='" & txtPosition.Text & "' WHERE position_code = '" & txtCode.Text & "'"
        ElseIf btnAction = 2 Then

            sql = "INSERT INTO tbl_positioncode SET position_code= '" & txtCode.Text & _
            "', position_designation='" & txtPosition.Text & "'"
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
        btnAction = 0
        SqlCommand.Dispose()
        CONNECTION.Close()
        'Me.Dispose()
        frmPosition.callPosition()
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        btnAction = 0
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub frmAEPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CONNECTION.Close()
    End Sub
End Class