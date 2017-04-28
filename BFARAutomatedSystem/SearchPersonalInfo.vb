Imports MySql.Data.MySqlClient

Public Class frmSearchPersonalInfo
    Public strSQL1 As String
    Public ds1 As New DataSet
    Public dr1 As MySqlDataReader
    Public cmd1 As MySqlCommand
    Public strSQL As String

    Private Sub frmSearchPersonalInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strSQL1 = "Select empno, CONCAT( firstname,' ', LEFT(mi,1), '. ', surname) as Name from tbl_employees order by surname"
        FillData1()
    End Sub

    Private Sub FillData1()
        On Error Resume Next
        CONNECTION.Open()
        cmd1 = New MySqlCommand(strSQL1, CONNECTION)
        dr1 = cmd1.ExecuteReader()
        lvEmployees.Items.Clear()
        Do While dr1.Read()
            Dim lv As ListViewItem = lvEmployees.Items.Add(dr1.Item(0))
            lv.SubItems.Add(UCase(dr1.Item(1)))
            'lv.SubItems.Add(UCase(dr1.Item(2)))
            'lv.SubItems.Add(UCase(dr1.Item(3)))
        Loop
        cmd1.Dispose()
        dr1.Close()
        CONNECTION.Close()
    End Sub

    Private Sub txtEmpNo_TextChanged(sender As Object, e As EventArgs) Handles txtEmpNo.TextChanged
        strSQL1 = "Select empno, CONCAT( firstname,' ', LEFT(mi,1), '. ', surname) as Name from tbl_employees where empno like '%" & txtEmpNo.Text.ToString & "%'order by surname"
        If txtEmpNo.Text <> "" Then
            txtLastName.Enabled = False
        Else
            txtLastName.Enabled = True
        End If
        FillData1()
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        strSQL1 = "Select empno, CONCAT( firstname,' ', LEFT(mi,1), '. ', surname) as Name from tbl_employees where surname like '%" & txtLastName.Text.ToString & "%'order by surname"
        If txtLastName.Text <> "" Then
            txtEmpNo.Enabled = False
        Else
            txtEmpNo.Enabled = True
        End If
        FillData1()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PersonalInfo.Button20.PerformClick()
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub lvEmployees_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvEmployees.DoubleClick
        Button1.PerformClick()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

   
End Class