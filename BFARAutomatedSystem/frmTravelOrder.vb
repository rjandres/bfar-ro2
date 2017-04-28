Imports MySql.Data.MySqlClient


Public Class frmTravelOrder
    Dim strSQL As String
    Dim cmdTO As MySqlCommand
    Dim drTO As MySqlDataReader

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        If TOAction = "Single" Then
            frmAETravelOrder.txtName.Text = UCase(txtName.Text)
            frmAETravelOrder.txtDesignation.Text = txtDesignation.Text
            frmAETravelOrder.txtEmpNo.Text = txtEmpNo.Text

            'frmAETravelOrder.Label2.Visible = False
            'frmAETravelOrder.dtRequest.Visible = False
        End If
        frmAETravelOrder.Label1.Visible = False
        frmAETravelOrder.txtTONo.Visible = False
        btnAction = 2
        frmAETravelOrder.ShowDialog()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If lvTO.SelectedItems.Count <> 0 Then
            frmAETravelOrder.txtName.Text = UCase(lvTO.SelectedItems(0).SubItems(6).Text)
            frmAETravelOrder.txtDesignation.Text = lvTO.SelectedItems(0).SubItems(7).Text
            frmAETravelOrder.txtEmpNo.Text = lvTO.SelectedItems(0).SubItems(5).Text

            frmAETravelOrder.txtCTRL.Text = lvTO.SelectedItems(0).Text
            frmAETravelOrder.txtTONo.Text = lvTO.SelectedItems(0).SubItems(1).Text
            frmAETravelOrder.dtRequest.Text = lvTO.SelectedItems(0).SubItems(2).Text
            frmAETravelOrder.dtDeparture.Value = Convert.ToDateTime(lvTO.SelectedItems(0).SubItems(3).Text).ToString("MM/dd/yyyy")
            frmAETravelOrder.dtReturn.Value = Convert.ToDateTime(lvTO.SelectedItems(0).SubItems(4).Text).ToString("MM/dd/yyyy")

            frmAETravelOrder.cbDeparture.Text = Convert.ToDateTime(lvTO.SelectedItems(0).SubItems(3).Text).ToString("tt")
            frmAETravelOrder.cbReturn.Text = Convert.ToDateTime(lvTO.SelectedItems(0).SubItems(4).Text).ToString("tt")

            frmAETravelOrder.txtStation.Text = lvTO.SelectedItems(0).SubItems(8).Text
            frmAETravelOrder.txtDestination.Text = lvTO.SelectedItems(0).SubItems(9).Text
            frmAETravelOrder.txtTranspo.Text = lvTO.SelectedItems(0).SubItems(10).Text
            frmAETravelOrder.txtPurpose.Text = lvTO.SelectedItems(0).SubItems(11).Text
            btnAction = 1
            frmAETravelOrder.ShowDialog()

        Else
            MsgBox("Please select Travel Order to be edit!!!", vbInformation)
        End If

    End Sub

    Private Sub frmTravelOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TOAction = "All" Then
            strSQL = "SELECT * from tbl_travelorder order by ctrno desc"
        ElseIf TOAction = "Single" Then
            strSQL = "SELECT * from tbl_travelorder where empno = '" & PersonalInfo.txtEmpNo.Text & "'order by ctrno desc"
        End If
        lvAddCol()
        callTravelOrder()
    End Sub

    Public Sub callTravelOrder()
        On Error Resume Next
        Dim i As Integer
        CONNECTION.Open()
        cmdTO = New MySqlCommand(strSQL, CONNECTION)
        drTO = cmdTO.ExecuteReader()

        lvTO.Items.Clear()
        Do While drTO.Read()
            Dim lv As ListViewItem = lvTO.Items.Add(drTO.Item(0))
            If drTO.Item(1).ToString = "" Then
                lv.SubItems.Add(" ")
            Else
                lv.SubItems.Add(drTO.Item(1))
            End If
            lv.SubItems.Add(drTO.Item(2))
            lv.SubItems.Add(drTO.Item(10) & " " & drTO.Item(11))
            lv.SubItems.Add(drTO.Item(12) & " " & drTO.Item(13))
            lv.SubItems.Add(drTO.Item(3))
            lv.SubItems.Add(drTO.Item(4))
            lv.SubItems.Add(drTO.Item(5))
            lv.SubItems.Add(drTO.Item(6))
            lv.SubItems.Add(drTO.Item(7))
            lv.SubItems.Add(drTO.Item(8))

            lv.SubItems.Add(drTO.Item(9))
            lv.SubItems.Add(drTO.Item(14))
        Loop
        cmdTO.Dispose()
        drTO.Close()
        CONNECTION.Close()
    End Sub

    Private Sub lvAddCol()
        lvTO.Columns.Clear()
        If TOAction = "All" Then
            lvTO.Columns.Add("ctrlno", 0)
            lvTO.Columns.Add("TO No", 60)
            lvTO.Columns.Add("Request Date", 100)
            lvTO.Columns.Add("Departure", 120)
            lvTO.Columns.Add("Return", 120)
            lvTO.Columns.Add("EmpNo", 0)
            lvTO.Columns.Add("Name", 250)
            lvTO.Columns.Add("Designation", 0)
            lvTO.Columns.Add("Station", 150)
            lvTO.Columns.Add("Destination", 250)
            lvTO.Columns.Add("Transpo", 250)
            lvTO.Columns.Add("Purpose", 250)
            lvTO.Columns.Add("Status", 100)
        Else
            lvTO.Columns.Add("ctrlno", 0)
            lvTO.Columns.Add("TO No", 60)
            lvTO.Columns.Add("Request Date", 100)
            lvTO.Columns.Add("Departure", 120)
            lvTO.Columns.Add("Return", 120)
            lvTO.Columns.Add("EmpNo", 0)
            lvTO.Columns.Add("Name", 0)
            lvTO.Columns.Add("Designation", 0)
            lvTO.Columns.Add("Station", 150)
            lvTO.Columns.Add("Destination", 250)
            lvTO.Columns.Add("Transpo", 250)
            lvTO.Columns.Add("Purpose", 250)
            lvTO.Columns.Add("Status", 100)
        End If

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        frmMain.UnlockMenu()
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub dtDateFilter_ValueChanged(sender As Object, e As EventArgs) Handles dtDateFilter.ValueChanged
        If TOAction = "All" Then
            strSQL = "SELECT * from tbl_travelorder WHERE RequestDate='" & dtDateFilter.Text & "' order by ctrno desc"
        ElseIf TOAction = "Single" Then
            strSQL = "SELECT * from tbl_travelorder where empno = '" & PersonalInfo.txtEmpNo.Text & "' AND RequestDate='" & dtDateFilter.Text & "' order by ctrno desc"
        End If
        lvAddCol()
        callTravelOrder()
    End Sub

    Private Sub cmdCopy_Click(sender As Object, e As EventArgs) Handles cmdCopy.Click
        If lvTO.SelectedItems.Count <> 0 Then
            'frmAETravelOrder.txtName.Text = UCase(lvTO.SelectedItems(0).SubItems(6).Text)
            'frmAETravelOrder.txtDesignation.Text = lvTO.SelectedItems(0).SubItems(7).Text
            'frmAETravelOrder.txtEmpNo.Text = lvTO.SelectedItems(0).SubItems(5).Text

            frmAETravelOrder.txtCTRL.Text = lvTO.SelectedItems(0).Text
            frmAETravelOrder.txtTONo.Text = lvTO.SelectedItems(0).SubItems(1).Text
            frmAETravelOrder.dtRequest.Text = lvTO.SelectedItems(0).SubItems(2).Text
            frmAETravelOrder.dtDeparture.Value = Convert.ToDateTime(lvTO.SelectedItems(0).SubItems(3).Text).ToString("MM/dd/yyyy")
            frmAETravelOrder.dtReturn.Value = Convert.ToDateTime(lvTO.SelectedItems(0).SubItems(4).Text).ToString("MM/dd/yyyy")

            frmAETravelOrder.cbDeparture.Text = Convert.ToDateTime(lvTO.SelectedItems(0).SubItems(3).Text).ToString("tt")
            frmAETravelOrder.cbReturn.Text = Convert.ToDateTime(lvTO.SelectedItems(0).SubItems(4).Text).ToString("tt")

            frmAETravelOrder.txtStation.Text = lvTO.SelectedItems(0).SubItems(8).Text
            frmAETravelOrder.txtDestination.Text = lvTO.SelectedItems(0).SubItems(9).Text
            frmAETravelOrder.txtTranspo.Text = lvTO.SelectedItems(0).SubItems(10).Text
            frmAETravelOrder.txtPurpose.Text = lvTO.SelectedItems(0).SubItems(11).Text
            btnAction = 2
            frmAETravelOrder.ShowDialog()
        Else
            MsgBox("Please select Travel Order to be copy!!!", vbInformation)
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim tblTO = New DataTable
        tblTO.Columns.Add("ID")
        tblTO.Columns.Add("Date")
        tblTO.Columns.Add("Name")
        tblTO.Columns.Add("Designation")
        tblTO.Columns.Add("Station")
        tblTO.Columns.Add("Destination")
        tblTO.Columns.Add("Transportation")
        tblTO.Columns.Add("Departure")
        tblTO.Columns.Add("Arrival")
        tblTO.Columns.Add("Purpose")
        tblTO.Columns.Add("RecommendingApproval")
        tblTO.Columns.Add("Position")

        If lvTO.SelectedItems.Count <> 0 Then

            If lvTO.SelectedItems(0).SubItems(1).Text <> " " Then
                MsgBox("aaaaaaaaaaaaaaaaaaaaaaa", vbInformation)
            Else
                'fmrPrintTO.txtName.Text = UCase(lvTO.SelectedItems(0).SubItems(6).Text)
                'fmrPrintTO.txtDesignation.Text = lvTO.SelectedItems(0).SubItems(7).Text
                ''fmrPrintTO.txtEmpNo.Text = lvTO.SelectedItems(0).SubItems(5).Text

                ''fmrPrintTO.txtCTRL.Text = lvTO.SelectedItems(0).Text
                'fmrPrintTO.txtTONo.Text = lvTO.SelectedItems(0).SubItems(1).Text
                'fmrPrintTO.txtRequest.Text = lvTO.SelectedItems(0).SubItems(2).Text
                'fmrPrintTO.txtDep.Text = Convert.ToDateTime(lvTO.SelectedItems(0).SubItems(3).Text).ToString("MM/dd/yyyy tt")
                'fmrPrintTO.txtReturn.Text = Convert.ToDateTime(lvTO.SelectedItems(0).SubItems(4).Text).ToString("MM/dd/yyyy tt")

                ''fmrPrintTO.cbDeparture.Text = Convert.ToDateTime(lvTO.SelectedItems(0).SubItems(3).Text).ToString("tt")
                ''fmrPrintTO.cbReturn.Text = Convert.ToDateTime(lvTO.SelectedItems(0).SubItems(4).Text).ToString("tt")

                'fmrPrintTO.txtStation.Text = lvTO.SelectedItems(0).SubItems(8).Text
                'fmrPrintTO.txtDestination.Text = lvTO.SelectedItems(0).SubItems(9).Text
                'fmrPrintTO.txtTranspo.Text = lvTO.SelectedItems(0).SubItems(10).Text
                'fmrPrintTO.txtPurpose.Text = lvTO.SelectedItems(0).SubItems(11).Text

                'fmrPrintTO.txtSignName.Text = UCase(lvTO.SelectedItems(0).SubItems(6).Text)
                'fmrPrintTO.txtSignDesignation.Text = lvTO.SelectedItems(0).SubItems(7).Text
                Dim x As Integer



                Dim strSign As String
                Dim cmd As MySqlCommand
                Dim dr As MySqlDataReader
                strSign = "SELECT * from unitsign WHERE Empno='" & lvTO.SelectedItems(0).SubItems(5).Text & "' order by Assigned desc limit 1"
                CONNECTION.Open()
                cmd = New MySqlCommand(strSign, CONNECTION)
                dr = cmd.ExecuteReader()
                Dim strUH, strUHP As String

                Do While dr.Read()
                    If dr.Item(6) = UCase(lvTO.SelectedItems(0).SubItems(6).Text) Then
                        strUH = "N/A"
                        strUHP = "N/A"
                    Else
                        strUH = dr.Item(6)
                        strUHP = dr.Item(5) & ", Chief"
                    End If
                    tblTO.Rows.Add(lvTO.SelectedItems(0).SubItems(1).Text, lvTO.SelectedItems(0).SubItems(2).Text, UCase(lvTO.SelectedItems(0).SubItems(6).Text), lvTO.SelectedItems(0).SubItems(7).Text, lvTO.SelectedItems(0).SubItems(8).Text, lvTO.SelectedItems(0).SubItems(9).Text, lvTO.SelectedItems(0).SubItems(10).Text, Convert.ToDateTime(lvTO.SelectedItems(0).SubItems(3).Text).ToString("MM/dd/yyyy tt"), Convert.ToDateTime(lvTO.SelectedItems(0).SubItems(4).Text).ToString("MM/dd/yyyy tt"), lvTO.SelectedItems(0).SubItems(11).Text, strUH, strUHP)
                Loop

                    cmd.Dispose()
                    dr.Close()
                    CONNECTION.Close()

                    Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                    rptDoc = New rptTO
                    rptDoc.SetDataSource(tblTO)

                    Form2.CrystalReportViewer1.ReportSource = rptDoc
                    Form2.ShowDialog()
                    Form2.Dispose()

                    'btnAction = 2
                    'fmrPrintTO.ShowDialog()
            End If
        Else
            MsgBox("Please select Travel Order to be copy!!!", vbInformation)
        End If
    End Sub

    Private Sub dtDateDep_ValueChanged(sender As Object, e As EventArgs) Handles dtDateDep.ValueChanged
        If TOAction = "All" Then
            strSQL = "SELECT * from tbl_travelorder WHERE Departure='" & dtDateDep.Text & "' order by ctrno desc"
        ElseIf TOAction = "Single" Then
            strSQL = "SELECT * from tbl_travelorder where empno = '" & PersonalInfo.txtEmpNo.Text & "' AND Departure='" & dtDateDep.Text & "' order by ctrno desc"
        End If
        lvAddCol()
        callTravelOrder()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim sqlDel As String
        If MsgBox("Are you sure you want to delte this record", vbYesNo) = MsgBoxResult.Yes Then
            sqlDel = "DELETE from tbl_travelorder WHERE EmpNo='" & lvTO.SelectedItems(0).SubItems(5).Text & "'"
            CONNECTION.Open()

            Dim cmd = New MySqlCommand(sqlDel, CONNECTION)
            Dim Count As Integer

            Count = cmd.ExecuteNonQuery()
            If Count = 0 Then
                MsgBox("Delete Cancel")
                CONNECTION.Close()
                Exit Sub
            Else
                MsgBox("Record Deleted")

            End If
            CONNECTION.Close()
            callTravelOrder()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub dtDateReturn_ValueChanged(sender As Object, e As EventArgs) Handles dtDateReturn.ValueChanged
        If TOAction = "All" Then
            strSQL = "SELECT * from tbl_travelorder WHERE ReturnD='" & dtDateReturn.Text & "' order by ctrno desc"
        ElseIf TOAction = "Single" Then
            strSQL = "SELECT * from tbl_travelorder where empno = '" & PersonalInfo.txtEmpNo.Text & "' AND ReturnD='" & dtDateReturn.Text & "' order by ctrno desc"
        End If
        lvAddCol()
        callTravelOrder()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNameS.TextChanged
        strSQL = "SELECT * from tbl_travelorder WHERE Name like '%" & txtNameS.Text & "%' order by ctrno desc"
        callTravelOrder()
    End Sub
End Class