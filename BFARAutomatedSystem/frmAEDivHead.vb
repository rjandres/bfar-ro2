Imports MySql.Data.MySqlClient

Public Class frmAEDivHead

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        On Error Resume Next
        Dim sql As String

        CONNECTION.Open()
        If txtDiv.Text = "" Then
            txtDiv.Focus()
            Exit Sub
        End If
        If txtOIC.Text = "" Then
            txtOIC.Focus()
            Exit Sub
        End If

        If btnAction = 1 Then

            sql = "UPDATE tbl_divoffcode SET code= '" & txtCode.Text & _
            "', description='" & txtDiv.Text & _
            "', oic='" & txtOIC.Text & _
            "', oicid='" & txtEmpNo.Text & "' WHERE id = '" & txtCTRNo.Text & "'"
        ElseIf btnAction = 2 Then
            sql = "INSERT INTO tbl_divoffcode SET code= '" & txtCode.Text & _
            "', description='" & txtDiv.Text & _
            "', oic='" & txtOIC.Text & _
            "', oicid='" & txtEmpNo.Text & "'"
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
        frmUnits.callDivision()
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        btnAction = 0
        Me.Dispose()
        Me.Close()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        SearchAction = "Division"
        frmEmployee.ShowDialog()
    End Sub
End Class