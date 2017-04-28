Imports MySql.Data.MySqlClient

Public Class frmAEChild
    Private Sub Search()
        Dim strSQL As String = "Select * from tbl_child where empno = '" & txtEmpNo.Text & "' AND NameOfChild='" & txtName.Text & "' "
        Dim recDA As New MySqlDataAdapter(strSQL, CONNECTION)
        Dim recDS As New DataSet
        Dim rec As Integer
        recDA.Fill(recDS, "Search")
        rec = recDS.Tables("Search").Rows.Count

        If rec <> 0 Then
            MsgBox(txtName.Text & ". Already exist!!!")
            txtName.Focus()
            CONNECTION.Close()
            Exit Sub
        End If
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        On Error Resume Next
        Dim sql As String

        CONNECTION.Open()
        If txtName.Text = "" Then
            txtName.Focus()
            Exit Sub
        End If

        If btnAction = 1 Then
            If txtHold.Text <> txtName.Text Then
                Search()
            End If
            sql = "UPDATE tbl_child SET empno= '" & txtEmpNo.Text & _
            "', NameOfChild='" & txtName.Text & _
            "', DateOfBirth='" & dtDOB.Text & "' WHERE empno = '" & txtEmpNo.Text & "' AND ctrno='" & txtCTRL.Text & "'"
        ElseIf btnAction = 2 Then
            Search()

            sql = "INSERT INTO tbl_child SET empno= '" & txtEmpNo.Text & _
            "', NameOfChild='" & txtName.Text & _
            "', DateOfBirth='" & dtDOB.Text & "'"
        End If

        Dim SqlCommand As New MySqlCommand
        Dim Count As Integer
        SqlCommand.Connection = CONNECTION
        SqlCommand.CommandText = sql

        Count = SqlCommand.ExecuteNonQuery()
        If Count = 0 Then
            MsgBox("No record found")
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

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        btnAction = 0
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub frmAEChild_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CONNECTION.Close()
    End Sub
End Class