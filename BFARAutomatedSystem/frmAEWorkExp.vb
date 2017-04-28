Option Explicit On
Imports MySql.Data.MySqlClient
Public Class frmAEWorkExp
    Public WithEvents bsStatus As New BindingSource

    Dim MySourcePos As New AutoCompleteStringCollection()
    Dim MySourceComp As New AutoCompleteStringCollection()


    Dim toDate As String


    Public Function callAllItems() As DataTable
        Dim dt As New DataTable
        Using cn As New MySql.Data.MySqlClient.MySqlConnection With
            {
                .ConnectionString = Builder.ConnectionString
            }
            Using cmd As New MySql.Data.MySqlClient.MySqlCommand With
                {
                    .Connection = cn,
                    .CommandText = "SELECT status from tbl_emp_experience group by status"
                }
                cn.Open()
                dt.Load(cmd.ExecuteReader)
            End Using
        End Using
        Return dt

    End Function
    Private Sub callCombo()
        ' On Error Resume Next
        bsStatus.DataSource = callAllItems()
        cbStatus.DisplayMember = "status" '& & "DivDesc
        cbStatus.DataSource = bsStatus
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtService.Text = "" Then
            MsgBox("Please select Yes/No")
            optYes.Focus()
            Exit Sub
        End If
        If dtFrom.Text = "" Then
            MsgBox("Please fill-up Inclusive Date")
            dtFrom.Focus()
            Exit Sub
        End If
        If toDate = "" Then
            MsgBox("Please fill-up Inclusive Date")
            dtTo.Focus()
            Exit Sub
        End If
        If txtPosition.Text = "" Then
            MsgBox("Please fill-up Position Title")
            txtPosition.Focus()
            Exit Sub
        End If
        If txtDepartment.Text = "" Then
            MsgBox("Please fill-up Department/Agency/Office/Company")
            txtDepartment.Focus()
            Exit Sub
        End If
        If txtSalary.Text = "" Then
            MsgBox("Please fill-up Monthly Salary")
            txtSalary.Focus()
            Exit Sub
        End If
        If txtSalaryGrade.Text = "" Then
            MsgBox("Please fill-up Salary Grade & Step Increment")
            txtSalaryGrade.Focus()
            Exit Sub
        End If
        If cbStatus.Text = "" Then
            MsgBox("Please select Status of Appointment")
            txtDepartment.Focus()
            Exit Sub
        End If


        On Error Resume Next

        If ckbPresent.Checked = True Then
            toDate = ckbPresent.Text
            dtTo.Enabled = False
        Else
            dtTo.Enabled = True
            toDate = dtTo.Text
        End If

        Dim sql As String
        CONNECTION.Open()
        If btnAction = 1 Then
            sql = "UPDATE tbl_emp_experience SET empno= '" & txtEmpNo.Text & _
            "', InclusiveFrom='" & dtFrom.Text & _
            "', InclusiveTo='" & toDate & _
            "', position='" & txtPosition.Text & _
            "', department='" & txtDepartment.Text & _
            "', monthlysalary='" & txtSalary.Text & _
            "', salgrade='" & txtSalaryGrade.Text & _
            "', status='" & cbStatus.Text & _
            "', govtservice='" & txtService.Text & "' WHERE ctrno='" & txtCTRL.Text & "'"
        ElseIf btnAction = 2 Then
            sql = "INSERT INTO tbl_emp_experience SET empno= '" & txtEmpNo.Text & _
            "', InclusiveFrom='" & dtFrom.Text & _
            "', InclusiveTo='" & toDate & _
            "', position='" & txtPosition.Text & _
            "', department='" & txtDepartment.Text & _
            "', monthlysalary='" & txtSalary.Text & _
            "', salgrade='" & txtSalaryGrade.Text & _
            "', status='" & cbStatus.Text & _
            "', govtservice='" & txtService.Text & "'"
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
        MySourcePos.Add(txtPosition.Text)
        MySourceComp.Add(txtDepartment.Text)

        With txtPosition
            .AutoCompleteCustomSource = MySourcePos
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With

        With txtDepartment
            .AutoCompleteCustomSource = MySourceComp
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With

        txtSalary.Text = ""

        optYes.Focus()
    End Sub

    Private Sub optYes_CheckedChanged(sender As Object, e As EventArgs) Handles optYes.CheckedChanged
        txtService.Text = "Yes"
    End Sub

    Private Sub optNo_CheckedChanged(sender As Object, e As EventArgs) Handles optNo.CheckedChanged
        txtService.Text = "No"
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        btnAction = 0
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub frmAEWorkExp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        CONNECTION.Close()
        If ckbPresent.Checked = True Then
            toDate = ckbPresent.Text
            dtTo.Enabled = False
        Else
            dtTo.Enabled = True
            toDate = dtTo.Text
        End If
        callCombo()
        cbStatus.Text = PersonalInfo.lvWorkExp.SelectedItems(0).SubItems(7).Text

        

    End Sub

    Private Sub ckbPresent_CheckedChanged(sender As Object, e As EventArgs) Handles ckbPresent.CheckedChanged
        If ckbPresent.Checked = True Then
            toDate = ckbPresent.Text
            dtTo.Enabled = False
        Else
            dtTo.Enabled = True
            toDate = dtTo.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmSelectGrade.ShowDialog()
    End Sub

    Private Sub btnSaveClose_Click(sender As Object, e As EventArgs) Handles btnSaveClose.Click
        If txtService.Text = "" Then
            MsgBox("Please select Yes/No")
            optYes.Focus()
            Exit Sub
        End If
        If dtFrom.Text = "" Then
            MsgBox("Please fill-up Inclusive Date")
            dtFrom.Focus()
            Exit Sub
        End If
        If toDate = "" Then
            MsgBox("Please fill-up Inclusive Date")
            dtTo.Focus()
            Exit Sub
        End If
        If txtPosition.Text = "" Then
            MsgBox("Please fill-up Position Title")
            txtPosition.Focus()
            Exit Sub
        End If
        If txtDepartment.Text = "" Then
            MsgBox("Please fill-up Department/Agency/Office/Company")
            txtDepartment.Focus()
            Exit Sub
        End If
        If txtSalary.Text = "" Then
            MsgBox("Please fill-up Monthly Salary")
            txtSalary.Focus()
            Exit Sub
        End If
        If txtSalaryGrade.Text = "" Then
            MsgBox("Please fill-up Salary Grade & Step Increment")
            txtSalaryGrade.Focus()
            Exit Sub
        End If
        If cbStatus.Text = "" Then
            MsgBox("Please select Status of Appointment")
            txtDepartment.Focus()
            Exit Sub
        End If


        On Error Resume Next

        If ckbPresent.Checked = True Then
            toDate = ckbPresent.Text
            dtTo.Enabled = False
        Else
            dtTo.Enabled = True
            toDate = dtTo.Text
        End If

        Dim sql As String
        CONNECTION.Open()
        If btnAction = 1 Then
            sql = "UPDATE tbl_emp_experience SET empno= '" & txtEmpNo.Text & _
            "', InclusiveFrom='" & dtFrom.Text & _
            "', InclusiveTo='" & toDate & _
            "', position='" & txtPosition.Text & _
            "', department='" & txtDepartment.Text & _
            "', monthlysalary='" & txtSalary.Text & _
            "', salgrade='" & txtSalaryGrade.Text & _
            "', status='" & cbStatus.Text & _
            "', govtservice='" & txtService.Text & "' WHERE ctrno='" & txtCTRL.Text & "'"
        ElseIf btnAction = 2 Then
            sql = "INSERT INTO tbl_emp_experience SET empno= '" & txtEmpNo.Text & _
            "', InclusiveFrom='" & dtFrom.Text & _
            "', InclusiveTo='" & toDate & _
            "', position='" & txtPosition.Text & _
            "', department='" & txtDepartment.Text & _
            "', monthlysalary='" & txtSalary.Text & _
            "', salgrade='" & txtSalaryGrade.Text & _
            "', status='" & cbStatus.Text & _
            "', govtservice='" & txtService.Text & "'"
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
        MySourcePos.Add(txtPosition.Text)
        MySourceComp.Add(txtDepartment.Text)

        With txtPosition
            .AutoCompleteCustomSource = MySourcePos
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With

        With txtDepartment
            .AutoCompleteCustomSource = MySourceComp
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With

        Me.Dispose()
        Me.Close()
    End Sub
End Class