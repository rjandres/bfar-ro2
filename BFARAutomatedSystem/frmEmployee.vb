Imports MySql.Data.MySqlClient

Public Class frmEmployee
    Dim strSQL As String
    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strSQL = "SELECT empno, CONCAT(firstname,' ', Left(mi,1), '. ', surname) as Name, poscode from tbl_employees order by surname"
        callEmpData()
    End Sub

    Public Sub callEmpData()
        On Error Resume Next
        Dim i As Integer
        Dim ds As New DataSet
        Dim dr As MySqlDataReader
        Dim cmd As New MySqlCommand

        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()

        lvEmp.Items.Clear()
        Do While dr.Read()
            Dim lv As ListViewItem = lvEmp.Items.Add(dr.Item(0))
            lv.SubItems.Add(UCase(dr.Item(1)))
            lv.SubItems.Add(dr.Item(2))
        Loop
        ds.Reset()
        CONNECTION.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        strSQL = "SELECT empno, CONCAT(firstname,' ', Left(mi,1), '. ', surname) as Name, poscode from tbl_employees WHERE surname like '%" & TextBox1.Text & "%' order by surname"
        callEmpData()
    End Sub

    Private Sub lvEmp_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvEmp.MouseDoubleClick
        Button1.PerformClick()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SearchAction = "Division" Then
            frmAEDivHead.txtEmpNo.Text = lvEmp.SelectedItems(0).Text
            frmAEDivHead.txtOIC.Text = lvEmp.SelectedItems(0).SubItems(1).Text
        ElseIf SearchAction = "TO" Then
            frmAETravelOrder.txtEmpNo.Text = lvEmp.SelectedItems(0).Text
            frmAETravelOrder.txtName.Text = lvEmp.SelectedItems(0).SubItems(1).Text
            frmAETravelOrder.txtDesignation.Text = lvEmp.SelectedItems(0).SubItems(2).Text
        ElseIf SearchAction = "DUnit" Then
            frmAEDU.txtEmpNo.Text = lvEmp.SelectedItems(0).Text
            frmAEDU.txtName.Text = lvEmp.SelectedItems(0).SubItems(1).Text
        ElseIf SearchAction = "Leave" Then
            frmLeave.txtEmpNo.Text = lvEmp.SelectedItems(0).Text
            frmLeave.txtName.Text = lvEmp.SelectedItems(0).SubItems(1).Text
        End If
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class