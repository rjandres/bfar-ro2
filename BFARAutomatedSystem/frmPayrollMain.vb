Imports MySql.Data.MySqlClient
Public Class frmPayrollMain
    Dim itemchange As Integer
    Private Sub callEmp()
        Dim strEmp As String
        Dim i As Integer
        Dim dr As MySqlDataReader

        strEmp = "SELECT empno, CONCAT(firstname,' ', Left(mi,1), '. ', surname) as Name from tbl_employees where Status=1 order by empno"
        CONNECTION.Open()
        Dim cmd = New MySqlCommand(strEmp, CONNECTION)
        dr = cmd.ExecuteReader
        lvEmp.Items.Clear()
        Do While dr.Read
            Dim lv As ListViewItem = lvEmp.Items.Add(dr.Item(0))
            lv.SubItems.Add(i + 1)
            lv.SubItems.Add(UCase(dr.Item(1)))
            i = i + 1
        Loop
        CONNECTION.Close()
    End Sub

    Private Sub loadEmpInfo()
        On Error Resume Next
        Dim arrImage() As Byte
        Dim strEmp, strEmpS As String
        'Dim i As Integer
        Dim dr, drS As MySqlDataReader

        strEmp = "SELECT empno, CONCAT(firstname,' ', Left(mi,1), '. ', surname) as Name, Pic, poscode, permanent from tbl_employees WHERE EmpNo='" & lvEmp.SelectedItems(0).SubItems(0).Text & "' order by empno"
        CONNECTION.Open()
        Dim cmd = New MySqlCommand(strEmp, CONNECTION)
        dr = cmd.ExecuteReader
        'lvEmp.Items.Clear()
        Do While dr.Read
            txtEmpName.Text = UCase("Employee Name : " & dr.Item(1))
            txtEmpNo.Text = dr.Item(0)
            txtDesignation.Text = UCase("Designation : " & dr.Item(3))
            txtReg.Text = UCase("Regular? : " & dr.Item(4))
            arrImage = dr.Item("Pic")

            If arrImage.Length = 0 Then
                Me.empPic.ImageLocation = "D:\BFAR Automated System\BFARAutomatedSystem\Picture\blank.jpeg"
            Else
                Dim mstream As New System.IO.MemoryStream(arrImage)
                empPic.Image = Image.FromStream(mstream)
            End If
        Loop
        CONNECTION.Close()

        strEmpS = "SELECT monthlysalary from tbl_emp_experience WHERE EmpNo='" & lvEmp.SelectedItems(0).SubItems(0).Text & "' and InclusiveTo='Present'"
        CONNECTION.Open()
        Dim cmdS = New MySqlCommand(strEmpS, CONNECTION)
        drS = cmdS.ExecuteReader
        'lvEmp.Items.Clear()
        Do While drS.Read
            txtRate.Text = drS.Item(0)
        Loop
        CONNECTION.Close()
    End Sub

    Private Sub frmPayrollMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        '    axDeduction.Row = 1
        '    axDeduction.Col = 1
        '    axDeduction.Text = "Try"
        cbMonth.Text = Now.AddMonths(-1).ToString("MMMM")

        If Now.ToString("MMMM") = "January" Then
            txtYear.Value = Now.AddYears(-1).ToString("yyyy")
        Else
            txtYear.Value = Now.ToString("yyyy")
        End If
        callEmp()
    End Sub

    Private Sub lvEmp_KeyDown(sender As Object, e As KeyEventArgs) Handles lvEmp.KeyDown
        loadEmpInfo()
    End Sub

    Private Sub lvEmp_KeyUp(sender As Object, e As KeyEventArgs) Handles lvEmp.KeyUp
        loadEmpInfo()
    End Sub

    Private Sub lvEmp_MouseClick(sender As Object, e As MouseEventArgs) Handles lvEmp.MouseClick
        loadEmpInfo()
    End Sub

    Private Sub cmdDeduction_Click(sender As Object, e As EventArgs) Handles cmdDeduction.Click
        Dim strDed As String
        Dim strMY As String
        Dim i As Integer
        Dim dr As MySqlDataReader
        If txtEmpNo.Text = "" Then
            MsgBox("Please select employee...", vbInformation)
            Exit Sub
        End If
        strMY = cbMonth.Text & "-" & txtYear.Value
        strDed = "Select * from deduction_info where empno='" & txtEmpNo.Text & "' and month_year='" & strMY & "' order by crtn"
        CONNECTION.Open()
        Dim cmd = New MySqlCommand(strDed, CONNECTION)
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            lvDeduction.Items.Clear()
            Do While dr.Read
                Dim lv As ListViewItem = lvDeduction.Items.Add(dr.Item(0))
                lv.SubItems.Add(dr.Item(0))
                lv.SubItems.Add(dr.Item(5))
                lv.SubItems.Add(dr.Item(6))
                i = i + 1
            Loop
            CONNECTION.Close()
            btnAction = 1
        Else
            CONNECTION.Close()
            loadTypes()
            btnAction = 2
        End If
        grpEmp.Enabled = False
        grpDeduction.Visible = True
    End Sub

    Dim bCancelEdit As Boolean

    Dim CurrentSB As ListViewItem.ListViewSubItem
    Dim CurrentItem As ListViewItem

    Public Sub loadTypes()
        Dim strEmp As String
        Dim i As Integer
        Dim dr As MySqlDataReader

        strEmp = "SELECT * from tbl_deductioninfo order by id"
        CONNECTION.Open()
        Dim cmd = New MySqlCommand(strEmp, CONNECTION)
        dr = cmd.ExecuteReader
        lvDeduction.Items.Clear()
        Do While dr.Read
            Dim lv As ListViewItem = lvDeduction.Items.Add(dr.Item(0))
            lv.SubItems.Add(dr.Item(0))
            lv.SubItems.Add(dr.Item(1))
            lv.SubItems.Add("0.00")
            i = i + 1
        Loop
        CONNECTION.Close()
    End Sub

    Private Sub lvDeduction_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvDeduction.MouseDoubleClick

        ' This subroutine checks where the double-clicking was performed and
        ' initiates in-line editing if user double-clicked on the right subitem

        ' check where clicked
        CurrentItem = lvDeduction.GetItemAt(e.X, e.Y)     ' which listviewitem was clicked
        If CurrentItem Is Nothing Then Exit Sub
        CurrentSB = CurrentItem.GetSubItemAt(e.X, e.Y)  ' which subitem was clicked

        ' See which column has been clicked

        ' NOTE: This portion is important. Here you can define your own
        '       rules as to which column can be edited and which cannot.
        Dim iSubIndex As Integer = CurrentItem.SubItems.IndexOf(CurrentSB)
        Select Case iSubIndex
            Case 2, 3
                ' These two columns are allowed to be edited. So continue the code
            Case Else
                ' In my example I have defined that only "Runs"
                ' and "Wickets" columns can be edited by user
                Exit Sub
        End Select

        Dim lLeft = CurrentSB.Bounds.Left + 3
        Dim lWidth As Integer = CurrentSB.Bounds.Width
        With TextBox1
            .SetBounds(lLeft + lvDeduction.Left, CurrentSB.Bounds.Top + _
                       lvDeduction.Top, lWidth, CurrentSB.Bounds.Height)
            .Text = CurrentSB.Text
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub LV_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles lvDeduction.KeyDown
        ' This subroutine is for starting editing when keyboard shortcut is pressed (e.g. F2 key)

        If lvDeduction.SelectedItems.Count = 0 Then Exit Sub

        Select Case e.KeyCode
            Case Keys.F2    ' F2 key is pressed. Initiate editing
                e.Handled = True
                BeginEditListItem(lvDeduction.SelectedItems(0), 3)

            Case Keys.Insert    ' F2 key is pressed. Initiate editing
                e.Handled = True
                BeginEditListItem(lvDeduction.SelectedItems(0), 3)
        End Select

    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        ' This subroutine closes the text box

        Select Case e.KeyChar

            Case Microsoft.VisualBasic.ChrW(Keys.Return)    ' Enter key is pressed
                bCancelEdit = False ' editing completed
                e.Handled = True
                TextBox1.Hide()

            Case Microsoft.VisualBasic.ChrW(Keys.Escape)    ' Escape key is pressed
                bCancelEdit = True  ' editing was cancelled
                e.Handled = True
                TextBox1.Hide()

        End Select

    End Sub


    Private Sub TextBox1_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox1.LostFocus

        TextBox1.Hide()

        If bCancelEdit = False Then

            If TextBox1.Text.Trim <> "" Then

                ' NOTE: You can define your validation rules here. In my example I've
                '       set that only numbers can be entered in "Runs" and "Wickets" column

                ' Validate
                If IsNumeric(TextBox1.Text) = False Then
                    MsgBox("Please enter a numeric value in this field.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                ' update listviewitem
                CurrentSB.Text = CDbl(TextBox1.Text).ToString("N2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))
                itemchange = 1
                ' save changes so that next time you load this XML document the changes are there.
                Dim iSubIndex As Integer = CurrentItem.SubItems.IndexOf(CurrentSB)
                Dim szPropertyName As String
                If iSubIndex = 2 Then
                    szPropertyName = "Runs"
                Else
                    szPropertyName = "Wickets"
                End If
                'SaveXMLChanges(CurrentItem.Text, szPropertyName, CurrentSB.Text)

                ' Recalculate last column
                'CalculateAverage()

            End If

        Else

            ' Editing was cancelled by user
            bCancelEdit = False

        End If

        lvDeduction.Focus()

    End Sub

    Private Sub BeginEditListItem(iTm As ListViewItem, SubItemIndex As Integer)
        ' This subroutine is for manually initiating editing instead of mouse double-clicks

        Dim pt As Point = iTm.SubItems(SubItemIndex).Bounds.Location
        Dim ee As New System.Windows.Forms.MouseEventArgs(Windows.Forms.MouseButtons.Left, 3, pt.X, pt.Y, 0)
        Call lvDeduction_MouseDoubleClick(lvDeduction, ee)
    End Sub



    Private Sub cmdCancel1_Click(sender As Object, e As EventArgs) Handles cmdCancel1.Click
        cmdCancel.PerformClick()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If itemchange = 1 Then
            Dim msg = MsgBox("The data had been change, do you want to save the changes?", vbYesNoCancel, vbQuestion)
            If msg = vbCancel Then
                Exit Sub
            ElseIf msg = vbNo Then
                grpDeduction.Visible = False
                itemchange = 0
                MsgBox("Record not save....", vbOKOnly, vbInformation)

            Else
                grpDeduction.Visible = False
                itemchange = 0
                MsgBox("Record save....", vbOKOnly, vbInformation)
            End If
        Else
            grpEmp.Enabled = True
            grpDeduction.Visible = False
        End If
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sql As String
        Dim strMY As String
        strMY = cbMonth.Text & "-" & txtYear.Value

        For x = 0 To lvDeduction.Items.Count - 1
            If btnAction = 2 Then
                sql = "INSERT INTO tbl_deductions SET empno= '" & txtEmpNo.Text & _
                 "', ded_code='" & lvDeduction.Items(x).Text & _
                 "', amt='" & lvDeduction.Items(x).SubItems(3).Text & _
                 "', month_year='" & strMY & "'"
            Else
                sql = "UPDATE tbl_deductions SET amt='" & lvDeduction.Items(x).SubItems(3).Text & _
                 "' WHERE crtn='" & lvDeduction.Items(x).SubItems(1).Text & "'"
            End If

            CONNECTION.Open()
            Dim SqlCommand As New MySqlCommand
            Dim Count As Integer
            SqlCommand.Connection = CONNECTION
            SqlCommand.CommandText = sql

            Count = SqlCommand.ExecuteNonQuery()
            If Count = 0 Then
                'MsgBox("No record found")
            Else
                'MsgBox("Records updated")
            End If
            SqlCommand.Dispose()
            CONNECTION.Close()
        Next
        Dim strDed As String
        Dim dr As MySqlDataReader
        Dim i As Integer
        strMY = cbMonth.Text & "-" & txtYear.Value
        strDed = "Select * from deduction_info where empno='" & txtEmpNo.Text & "' and month_year='" & strMY & "' order by crtn"
        CONNECTION.Open()
        Dim cmd = New MySqlCommand(strDed, CONNECTION)
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            lvDeduction.Items.Clear()
            Do While dr.Read
                Dim lv As ListViewItem = lvDeduction.Items.Add(dr.Item(0))
                lv.SubItems.Add(dr.Item(0))
                lv.SubItems.Add(dr.Item(5))
                lv.SubItems.Add(dr.Item(6))
                i = i + 1
            Loop
            CONNECTION.Close()
        End If
        btnAction = 1
        MsgBox("Record save...")
        itemchange = 0
    End Sub


    Private Sub cbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMonth.SelectedIndexChanged
        If grpDeduction.Visible = True And grpEmp.Enabled = False Then
            cmdDeduction.PerformClick()
        End If
    End Sub

    Private Sub txtYear_ValueChanged(sender As Object, e As EventArgs) Handles txtYear.ValueChanged
        If grpDeduction.Visible = True And grpEmp.Enabled = False Then
            cmdDeduction.PerformClick()
        End If
    End Sub

    Private Sub cmdCompute_Click(sender As Object, e As EventArgs) Handles cmdCompute.Click
        On Error Resume Next

        Dim strDed As String
        Dim strMY As String
        Dim dr As MySqlDataReader
        strMY = cbMonth.Text & "-" & txtYear.Value
        strDed = "Select sum(amt) as amt from deduction_info where empno='" & txtEmpNo.Text & "' and month_year='" & strMY & "' order by crtn"
        CONNECTION.Open()
        Dim cmd = New MySqlCommand(strDed, CONNECTION)
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            Do While dr.Read
                If dr.Item(0) = 0 Then
                    txtTotaDeduct.Text = "0.00"
                Else
                    txtTotaDeduct.Text = CDbl(dr.Item(0)).ToString("N2")
                End If

            Loop
            CONNECTION.Close()
        End If
    End Sub
End Class