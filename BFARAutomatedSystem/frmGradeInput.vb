Imports MySql.Data.MySqlClient
Public Class frmGradeInput

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        Dim strEmp As String
        'MsgBox("Please enter salary grade you want to add", vb)
        Dim dr As MySqlDataReader

        strEmp = "SELECT * from z_stepincrement where salary_grade='" & txtGrade.Text & "'"
        CONNECTION.Open()
        Dim cmd = New MySqlCommand(strEmp, CONNECTION)
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            MsgBox("Duplicate entry detected, please try again!!", vbOKOnly)
            txtGrade.Text = ""
            CONNECTION.Close()
            Exit Sub
        Else
            frmSalaryGrade.txtGrade.Text = txtGrade.Text
            Me.Hide()
        End If
        CONNECTION.Close()
        Dim i As Integer
        frmSalaryGrade.lvGrade.Items.Clear()
        Do Until i = 8
            Dim lv As ListViewItem = frmSalaryGrade.lvGrade.Items.Add(i + 1)
            lv.SubItems.Add("0.00")
            i = i + 1
            btnAction = 2
            frmSalaryGrade.cmdAdd.Text = "Save"
            frmSalaryGrade.cmbGrade.Enabled = False
            'Label2.Text = lvGrade.Items.Count - 1
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class