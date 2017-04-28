Imports MySql.Data.MySqlClient

Public Class frmDTRSetup


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmMain.UnlockMenu()
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub frmDTRSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CallTime()
    End Sub
    Private Sub CallTime()
        Dim strSQL As String
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader

        On Error Resume Next
        strSQL = "SELECT * from tbl_time;"
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()
        Do While dr.Read()
            mtxtAMIN.Text = dr.Item(0).ToString
            mtxtAMOUT.Text = dr.Item(1).ToString
            mtxtPMIN.Text = dr.Item(2).ToString
            mtxtPMOUT.Text = dr.Item(3).ToString
        Loop
        CONNECTION.Close()
    End Sub


End Class