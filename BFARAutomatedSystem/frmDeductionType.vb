Imports MySql.Data.MySqlClient
Public Class frmDeductionType

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        On Error Resume Next

        Dim sql As String
        CONNECTION.Open()

        If cmdAdd.Text = "ADD" Then
            Me.gbAdd.Text = "Add Deduction Type"
            Me.cmdEdit.Text = "CANCEL"
            Me.cmdAdd.Text = "SAVE"
            Me.cmdClose.Enabled = False
            Me.cmdDelete.Enabled = False
            Me.gbDetails.Enabled = False
            Me.gbAdd.Visible = True
            txtType.Text = ""
            txtAgency.Text = ""
            btnAction = 2
        Else
            If btnAction = 1 Then

                sql = "UPDATE tbl_deductioninfo SET Types= '" & txtType.Text & _
                 "', Agency='" & txtAgency.Text & "' WHERE ID = '" & txtCode.Text & "'"
            Else : btnAction = 2
                sql = "INSERT INTO tbl_deductioninfo SET Types= '" & txtType.Text & _
                "', Agency='" & txtAgency.Text & "'"
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
                Me.cmdEdit.Text = "EDIT"
                Me.cmdAdd.Text = "ADD"
                Me.cmdClose.Enabled = True
                Me.cmdDelete.Enabled = True
                Me.gbDetails.Enabled = True
                Me.gbAdd.Visible = False
                callDeduction()
                MsgBox("Records updated")
            End If
            btnAction = 0
            SqlCommand.Dispose()
            CONNECTION.Close()
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If cmdEdit.Text = "CANCEL" Then
            Me.cmdEdit.Text = "EDIT"
            Me.cmdAdd.Text = "ADD"
            Me.cmdClose.Enabled = True
            Me.cmdDelete.Enabled = True
            Me.gbDetails.Enabled = True
            Me.gbAdd.Visible = False
        Else
            If lvDeduct.SelectedItems.Count <> 0 Then
                Me.txtCode.Text = lvDeduct.SelectedItems(0).Text
                Me.txtType.Text = lvDeduct.SelectedItems(0).SubItems(1).Text
                Me.txtAgency.Text = lvDeduct.SelectedItems(0).SubItems(2).Text

                Me.gbAdd.Text = "Add Deduction Type"
                Me.cmdEdit.Text = "CANCEL"
                Me.cmdAdd.Text = "SAVE"
                Me.cmdClose.Enabled = False
                Me.cmdDelete.Enabled = False
                Me.gbDetails.Enabled = False
                Me.gbAdd.Visible = True

                btnAction = 1
            Else
                MsgBox("Please select Type of Deduction to update.", vbInformation)
            End If
        End If
    End Sub
    Public Sub callDeduction()
        On Error Resume Next
        Dim i As Integer
        Dim strSQL As String
        Dim ds As New DataSet
        Dim dr As MySqlDataReader
        Dim cmd As New MySqlCommand


        strSQL = "SELECT * from tbl_deductioninfo order by ID"
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()

        lvDeduct.Items.Clear()
        Do While dr.Read()
            Dim lv As ListViewItem = lvDeduct.Items.Add(dr.Item(0))
            lv.SubItems.Add(dr.Item(1))
            lv.SubItems.Add(dr.Item(2))
        Loop
        'txtHCode.Text = Val(dr.Item(1))
        ds.Reset()
        CONNECTION.Close()
    End Sub

    Private Sub frmDeductionType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        callDeduction()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Hide()
    End Sub
End Class