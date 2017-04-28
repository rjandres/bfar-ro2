Imports MySql.Data.MySqlClient

Public Class frmAEVoluntary
    Dim dateTo As String
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        On Error Resume Next
        Dim sql, sqlSearch As String
        If txtName.Text = "" Then
            MsgBox("Please fill-up Title of Seminar...")
            txtName.Focus()
            Exit Sub
        End If
        If txtPosition.Text = "" Then
            MsgBox("Please fill-up Conducted/Sponsored...")
            txtPosition.Focus()
            Exit Sub
        End If
        If txtHours.Text = "" Then
            MsgBox("Please fill-up Hours....")
            txtHours.Focus()
            Exit Sub
        End If

        If ckbPresent.Checked = True Then
            dtTo.Enabled = False
            dateTo = "Present"
        Else
            dtTo.Enabled = True
            dateTo = dtTo.Text
        End If

        CONNECTION.Open()
        If btnAction = 1 Then
            sql = "UPDATE tbl_voluntarywork SET empno= '" & txtEmpNo.Text & _
            "', nameaddress='" & txtName.Text & _
            "', InclusiveDatesFrom='" & dtFrom.Text & _
            "', InclusiveDatesTo='" & dateTo & _
            "', nhours='" & txtHours.Text & _
            "', position='" & txtPosition.Text & "' WHERE empno = '" & txtEmpNo.Text & "' AND ctrno='" & txtCTRL.Text & "'"
        ElseIf btnAction = 2 Then
            sql = "INSERT INTO tbl_voluntarywork SET empno= '" & txtEmpNo.Text & _
            "', nameaddress='" & txtName.Text & _
            "', InclusiveDatesFrom='" & dtFrom.Text & _
            "', InclusiveDatesTo='" & dateTo & _
            "', nhours='" & txtHours.Text & _
            "', position='" & txtPosition.Text & "'"
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
        PersonalInfo.callPersonalInfo()
        btnAction = 0
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        btnAction = 0
        Me.Hide()
    End Sub

    Private Sub frmAEVoluntary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CONNECTION.Close()

    End Sub

    Private Sub ckbPresent_CheckedChanged(sender As Object, e As EventArgs) Handles ckbPresent.CheckedChanged
        If ckbPresent.Checked = True Then
            dtTo.Enabled = False
            dateTo = "Present"
        Else
            dtTo.Enabled = True
            dateTo = dtTo.Text
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub txtPosition_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPosition.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
End Class