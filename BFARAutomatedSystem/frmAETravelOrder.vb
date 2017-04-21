Imports MySql.Data.MySqlClient

Public Class frmAETravelOrder
    Dim strSQL As String

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If MsgBox("Are you sure you want to cancel the transaction", vbYesNo, vbInformation) = vbYes Then
            btnAction = 0
            Me.Dispose()
            Me.Close()
        Else
            Exit Sub
        End If

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim strSQL As String
        Dim dr As MySqlDataReader
        'Dim specialCharacters As String
        

        CONNECTION.Open()
        If btnAction = 2 Then
            strSQL = "Insert into tbl_travelorder SET " & _
                     "TONo='" & txtTONo.Text & _
                     "', empno='" & txtEmpNo.Text & _
                     "', RequestDate='" & dtRequest.Text.ToString & _
                     "', Name='" & txtName.Text & _
                     "', Designation='" & txtDesignation.Text & _
                     "', Station='" & txtStation.Text & _
                     "', Destination='" & txtDestination.Text & _
                     "', Transportation='" & txtTranspo.Text & _
                     "', Purpose='" & txtPurpose.Text & _
                     "', Departure='" & DateTime.Parse(dtDeparture.Text).ToString("yyyy-MM-dd") & _
                     "', DeptAMPM='" & cbDeparture.Text & _
                     "', ReturnD='" & DateTime.Parse(dtReturn.Text).ToString("yyyy-MM-dd") & _
                     "', Status='Waiting'" & _
                     ", ReturnAMPM='" & cbReturn.Text & "'"
        ElseIf btnAction = 1 Then
            strSQL = "UPDATE tbl_travelorder SET " & _
          "TONo='" & txtTONo.Text & _
          "', empno='" & txtEmpNo.Text & _
          "', RequestDate='" & dtRequest.Text.ToString & _
          "', Name='" & txtName.Text & _
          "', Designation='" & txtDesignation.Text & _
          "', Station='" & txtStation.Text & _
          "', Destination='" & txtDestination.Text & _
          "', Transportation='" & txtTranspo.Text & _
          "', Purpose='" & txtPurpose.Text & _
          "', Departure='" & DateTime.Parse(dtDeparture.Text).ToString("yyyy-MM-dd") & _
          "', DeptAMPM='" & cbDeparture.Text & _
          "', ReturnD='" & DateTime.Parse(dtReturn.Text).ToString("yyyy-MM-dd") & _
          "', ReturnAMPM='" & cbReturn.Text & "' WHERE ctrno='" & txtCTRL.Text & "'"
        End If

        Dim SqlCommand As New MySqlCommand
        Dim Count As Integer
        SqlCommand.Connection = CONNECTION
        SqlCommand.CommandText = strSQL
        Count = SqlCommand.ExecuteNonQuery()
        'Count = SqlCommand.ExecuteNonQuery()
        If Count = 0 Then
            MsgBox("No record found")
        Else
            MsgBox("Records updated")
        End If
        btnAction = 0
        strSQL = "SELECT * from tbl_travelorder order by ctrno"
        'strSQL = "SELECT * from tbl_travelorder where empno = '" & txtEmpNo.Text & "'order by ctrno"
        CONNECTION.Close()
        frmTravelOrder.callTravelOrder()
        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        SearchAction = "TO"
        frmEmployee.ShowDialog()
    End Sub

    Private Sub frmAETravelOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TOAction = "Single" Then
            cmdSearch.Enabled = False
        Else
            cmdSearch.Enabled = True
        End If
    End Sub
End Class