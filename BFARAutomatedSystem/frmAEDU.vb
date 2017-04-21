Imports MySql.Data.MySqlClient

Public Class frmAEDU

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        SearchAction = "DUnit"
        frmEmployee.ShowDialog()
    End Sub

    Private Sub frmAEDU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Focus()
    End Sub
   
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        On Error Resume Next
        Dim strSQL As String

        If txtName.Text = "" Then
            MsgBox("Please select employee....")
            txtName.Focus()
            Exit Sub
        End If

        If txtTask.Text = "" Then
            MsgBox("Please assign task")
            txtTask.Focus()
            Exit Sub
        End If
        If txtDesc.Text = "" Then
            MsgBox("Please give description to the task given")
            txtDesc.Focus()
            Exit Sub
        End If

        If IsNumeric(txtPercent.Text) = False Then
            MsgBox("Please enter percent...")
            txtPercent.Focus()
            Exit Sub
        End If

        If btnAction = 2 Then
            strSQL = "Insert into tbl_divassigned SET DivCode = '" & txtDivCode.Text & _
                     "', DivDesc='" & txtDiv.Text & _
                     "', EmpNo='" & txtEmpNo.Text & _
                     "', EmpName='" & txtName.Text & _
                     "', AssignedTask='" & txtTask.Text & _
                     "', Description='" & txtDesc.Text & _
                     "', AssignedPercent='" & txtPercent.Text & "'"
        ElseIf btnAction = 1 Then
            strSQL = "UPDATE tbl_divassigned SET DivCode = '" & txtDivCode.Text & _
                     "', DivDesc='" & txtDiv.Text & _
                     "', EmpNo='" & txtEmpNo.Text & _
                     "', EmpName='" & txtName.Text & _
                     "', AssignedTask='" & txtTask.Text & _
                     "', Description='" & txtDesc.Text & _
                     "', AssignedPercent='" & txtPercent.Text & "' WHERE ctrno = '" & txtCTRNo.Text & "'"
        End If

        CONNECTION.Open()

        Dim SqlCommand As New MySqlCommand
        Dim Count As Integer
        SqlCommand.Connection = CONNECTION
        SqlCommand.CommandText = strSQL

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
        frmDesignationUnit.callUnit()
        Me.Dispose()
        Me.Close()
    End Sub
End Class