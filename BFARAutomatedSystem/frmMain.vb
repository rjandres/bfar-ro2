Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmMain

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click
        LockMenu()
        frmPosition.ShowDialog()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub


    Private Sub LockMenu()
        mnuFile.Enabled = False
        mnuTransaction.Enabled = False
        'mnuReport.Enabled = False
        'mnuHelp.Enabled = False
    End Sub
    Public Sub UnlockMenu()
        mnuFile.Enabled = True
        mnuTransaction.Enabled = True
        ' mnuReport.Enabled = True
        'mnuHelp.Enabled = True
    End Sub
    Private Sub EmployeeInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeInformationToolStripMenuItem.Click
        LockMenu()
        PersonalInfo.ShowDialog()
    End Sub

    Private Sub TimeSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeSetupToolStripMenuItem.Click
        LockMenu()
        frmDTRSetup.ShowDialog()
    End Sub

    Private Sub ManageDivisionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageDivisionToolStripMenuItem.Click
        LockMenu()
        frmDivHead.ShowDialog()
    End Sub

    Private Sub TravelOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TravelOrderToolStripMenuItem.Click
        LockMenu()
        TOAction = "All"
        frmTravelOrder.ShowDialog()
    End Sub

    Private Sub ManageDesignationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageDesignationToolStripMenuItem.Click
        LockMenu()
        frmDesignationUnit.ShowDialog()
    End Sub

    

    Private Sub LeavesInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeavesInfoToolStripMenuItem.Click
        TOAction = "All"
        frmLeave.ShowDialog()
    End Sub

    Private Sub DTRToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DTRToolStripMenuItem1.Click
        frmDTR.ShowDialog()
    End Sub

   

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        On Error Resume Next
        Dim strReg, strJO, strEmp, strCheck As String
        Dim maxRows, i As Integer
        Dim cmdEmp As MySqlCommand
        Dim drChk As MySqlDataReader
        CONNECTION.Open()

        strEmp = "Select empno from tbl_employees where empcode='Permanent'"
        Dim daEmp As New MySqlDataAdapter(strEmp, CONNECTION)
        Dim dsEmp As New DataSet
        daEmp.Fill(dsEmp, "Emp")
        i = 0
        maxRows = dsEmp.Tables("Emp").Rows.Count
        Do While i <= maxRows
            With dsEmp.Tables("Emp").Rows(i)

                strCheck = "Select * from tbllcearned where EmpID='" & .Item(0) & "'"
                Dim cmdChk = New MySqlCommand(strCheck, CONNECTION)
                drChk = cmdChk.ExecuteReader

                If drChk.HasRows Then
                    strReg = "Update tbllcearned Set VLEarned='" & DateTime.Parse(Now).ToString("MM") * 1.25 & _
                        "', SLEarned='" & DateTime.Parse(Now).ToString("MM") * 1.25 & _
                        "' WHERE EmpID='" & .Item(0) & "'"
                Else
                    strReg = "INSERT INTO tbllcearned Set VLEarned='" & DateTime.Parse(Now).ToString("MM") * 1.25 & _
                        "', SLEarned='" & DateTime.Parse(Now).ToString("MM") * 1.25 & "', EmpID='" & .Item(0) & "'"
                End If
                drChk.Close()
                cmdChk.Dispose()
                Dim cmdSave = New MySqlCommand(strReg, CONNECTION)

                cmdSave.ExecuteNonQuery()
                cmdSave.Dispose()
            End With
            i += 1
        Loop
        CONNECTION.Close()
    End Sub

    Private Sub MangeDeductionToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmDeductionType.ShowDialog()
    End Sub

    Private Sub PayrollToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        frmPayrollMain.ShowDialog()
    End Sub

    Private Sub SalaryGradeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryGradeToolStripMenuItem.Click
        frmSalaryGrade.ShowDialog()
    End Sub

    Private Sub TypeOfLeaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TypeOfLeaveToolStripMenuItem.Click
        LockMenu()
        frmLeaveLib.ShowDialog()
    End Sub

    Private Sub HolidaysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HolidaysToolStripMenuItem.Click
        LockMenu()
        frmHoliday.ShowDialog()
    End Sub

    Private Sub ActivitiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivitiesToolStripMenuItem.Click
        LockMenu()
        frmMeeting.ShowDialog()
    End Sub
End Class
