Imports MySql.Data.MySqlClient
Public Class frmSelectGrade
    Dim sql, sql2 As String
    Dim dr, dr2 As MySqlDataReader
    Public Sub LoadGrade()
        Dim dr As MySqlDataReader
        CONNECTION.Open()
        Dim cmd = New MySqlCommand(sql, CONNECTION)
        dr = cmd.ExecuteReader()
        lvGrade.Items.Clear()
        Do While dr.Read()
            Dim lv As ListViewItem = lvGrade.Items.Add(dr.Item(0) & "-" & dr.Item(1))
            lv.SubItems.Add(dr.Item(2))
        Loop
        CONNECTION.Close()
    End Sub

    Private Sub frmSelectGrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dr2 As MySqlDataReader
        sql = "SELECT salary_grade, step_increment, salary from z_stepincrement order by salary_grade, step_increment"
        LoadGrade()

        sql2 = "SELECT salary_grade from z_stepincrement group by salary_grade order by salary_grade"
        CONNECTION.Open()
        Dim cmd1 = New MySqlCommand(sql2, CONNECTION)
        dr2 = cmd1.ExecuteReader
        If dr2.HasRows = True Then
            cmbGrade.Items.Clear()
            Do While dr2.Read
                cmbGrade.Items.Add(dr2.Item(0))
            Loop
        End If
        CONNECTION.Close()

    End Sub

    Private Sub cmbGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGrade.SelectedIndexChanged
        sql = "SELECT salary_grade, step_increment, salary from z_stepincrement where salary_grade='" & cmbGrade.Text & "' order by salary_grade, step_increment"
        LoadGrade()
    End Sub

    Private Sub lvGrade_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvGrade.MouseDoubleClick
        frmAEWorkExp.txtSalaryGrade.Text = lvGrade.SelectedItems(0).Text
        frmAEWorkExp.txtSalary.Text = lvGrade.SelectedItems(0).SubItems(1).Text
        Me.Hide()
    End Sub
End Class