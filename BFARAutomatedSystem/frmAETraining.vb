Imports MySql.Data.MySqlClient
Public Class frmAETraining
    Public WithEvents bsType As New BindingSource
    Public Function callAllItems() As DataTable
        Dim dt As New DataTable
        Using cn As New MySql.Data.MySqlClient.MySqlConnection With
            {
                .ConnectionString = Builder.ConnectionString
            }
            Using cmd As New MySql.Data.MySqlClient.MySqlCommand With
                {
                    .Connection = cn,
                    .CommandText = "SELECT TypeofTraining from tbl_trainings group by TypeofTraining"
                }
                cn.Open()
                dt.Load(cmd.ExecuteReader)
            End Using
        End Using
        Return dt

    End Function
    Private Sub callCombo()
        ' On Error Resume Next
        Dim tempCB As String

        tempCB = cbType.Text

        bsType.DataSource = callAllItems()
        cbType.DisplayMember = "TypeofTraining" '& & "DivDesc
        cbType.DataSource = bsType
        cbType.Text = tempCB
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        On Error Resume Next
        Dim sql, sqlSearch As String
        Dim SqlCommand As New MySqlCommand
        Dim Count As Integer

        If txtTitle.Text = "" Then
            MsgBox("Please fill-up Title of Seminar...")
            txtTitle.Focus()
            Exit Sub
        End If
        If txtConduct.Text = "" Then
            MsgBox("Please fill-up Conducted/Sponsored...")
            txtConduct.Focus()
            Exit Sub
        End If
        If txtHours.Text = "" Then
            MsgBox("Please fill-up Hours....")
            txtHours.Focus()
            Exit Sub
        End If

        CONNECTION.Open()
        If btnAction = 1 Then
            sql = "UPDATE tbl_trainings SET empno= '" & txtEmpNo.Text & _
            "', TitleofSeminar='" & txtTitle.Text & _
            "', InclusiveDatesFrom='" & dtFrom.Text & _
            "', InclusiveDatesTo='" & dtTo.Text & _
            "', NumberOfHours='" & txtHours.Text & _
            "', TypeofTraining='" & cbType.Text & _
            "', ConductedSponsoredBy='" & txtConduct.Text & "' WHERE empno = '" & txtEmpNo.Text & "' AND ctrno='" & txtCTRL.Text & "'"

        ElseIf btnAction = 2 Then
            sql = "INSERT INTO tbl_trainings SET empno= '" & txtEmpNo.Text & _
            "', TitleofSeminar='" & txtTitle.Text & _
            "', InclusiveDatesFrom='" & dtFrom.Text & _
            "', InclusiveDatesTo='" & dtTo.Text & _
            "', NumberOfHours='" & txtHours.Text & _
            "', TypeofTraining='" & cbType.Text & _
            "', ConductedSponsoredBy='" & txtConduct.Text & "'"
        End If
        SqlCommand.Connection = CONNECTION
        SqlCommand.CommandText = sql

        Count = SqlCommand.ExecuteNonQuery()
        If Count = 0 Then
            MsgBox("No record found")
            CONNECTION.Close()
            Exit Sub
        Else
            MsgBox("Records updated")
        End If
        SqlCommand.Dispose()

        btnAction = 0
        CONNECTION.Close()
        Call PersonalInfo.callPersonalInfo()
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        btnAction = 0
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub frmAETraining_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CONNECTION.Close()
        callCombo()
        'cbType.Text = PersonalInfo.lvTrainings.SelectedItems(0).SubItems(7).Text
    End Sub

    Private Sub dtFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtFrom.ValueChanged
        dtTo.Value = dtFrom.Value
        txtHours.Text = (DateDiff(DateInterval.Day, dtFrom.Value, dtTo.Value) + 1) * 8
    End Sub

    Private Sub dtTo_ValueChanged(sender As Object, e As EventArgs) Handles dtTo.ValueChanged
        If dtFrom.Value > dtTo.Value Then
            dtTo.Value = dtFrom.Value
            dtTo.Focus()
        End If
        txtHours.Text = (DateDiff(DateInterval.Day, dtFrom.Value, dtTo.Value) + 1) * 8
    End Sub
End Class