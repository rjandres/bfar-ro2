Imports MySql.Data.MySqlClient
Public Class frmSalaryGrade
    Dim bCancelEdit As Boolean
    Dim CurrentSB As ListViewItem.ListViewSubItem
    Dim CurrentItem As ListViewItem

    Public Sub loadLV()
        Dim strEmp As String

        Dim dr As MySqlDataReader

        strEmp = "SELECT * from z_stepincrement where salary_grade='" & cmbGrade.Text & "' order by step_increment"
        CONNECTION.Open()
        Dim cmd = New MySqlCommand(strEmp, CONNECTION)
        dr = cmd.ExecuteReader
        lvGrade.Items.Clear()
        Do While dr.Read
            Dim lv As ListViewItem = lvGrade.Items.Add(dr.Item(1))
            lv.SubItems.Add(dr.Item(2))
        Loop
        CONNECTION.Close()
    End Sub
    Public Sub loadCombo()
        Dim strEmp As String

        Dim dr As MySqlDataReader

        strEmp = "SELECT * from z_stepincrement group by salary_grade order by salary_grade"
        CONNECTION.Open()
        Dim cmd = New MySqlCommand(strEmp, CONNECTION)
        dr = cmd.ExecuteReader
        cmbGrade.Items.Clear()
        Do While dr.Read
            cmbGrade.Items.Add(dr.Item(0))
        Loop
        CONNECTION.Close()
    End Sub
    Public Sub search()
        Dim strEmp As String

        Dim dr As MySqlDataReader

        strEmp = "SELECT * from z_stepincrement where salary_grade='" & cmbGrade.Text & "'"
        CONNECTION.Open()
        Dim cmd = New MySqlCommand(strEmp, CONNECTION)
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            MsgBox("Duplicate entry detected, please try again!!", vbOKOnly)
            Exit Sub
        End If
        CONNECTION.Close()
    End Sub
    Private Sub lvGrade_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvGrade.MouseDoubleClick

        ' This subroutine checks where the double-clicking was performed and
        ' initiates in-line editing if user double-clicked on the right subitem

        ' check where clicked
        CurrentItem = lvGrade.GetItemAt(e.X, e.Y)     ' which listviewitem was clicked
        If CurrentItem Is Nothing Then Exit Sub
        CurrentSB = CurrentItem.GetSubItemAt(e.X, e.Y)  ' which subitem was clicked

        ' See which column has been clicked

        ' NOTE: This portion is important. Here you can define your own
        '       rules as to which column can be edited and which cannot.
        Dim iSubIndex As Integer = CurrentItem.SubItems.IndexOf(CurrentSB)
        Select Case iSubIndex
            Case 1
                ' These two columns are allowed to be edited. So continue the code
            Case Else
                ' In my example I have defined that only "Runs"
                ' and "Wickets" columns can be edited by user
                Exit Sub
        End Select

        Dim lLeft = CurrentSB.Bounds.Left + 1
        Dim lWidth As Integer = CurrentSB.Bounds.Width
        With TextBox1
            .SetBounds(lLeft + lvGrade.Left, CurrentSB.Bounds.Top + _
                       lvGrade.Top, lWidth, CurrentSB.Bounds.Height)
            .Text = CurrentSB.Text
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub LV_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles lvGrade.KeyDown
        ' This subroutine is for starting editing when keyboard shortcut is pressed (e.g. F2 key)

        If lvGrade.SelectedItems.Count = 0 Then Exit Sub

        Select Case e.KeyCode
            Case Keys.F2    ' F2 key is pressed. Initiate editing
                e.Handled = True
                BeginEditListItem(lvGrade.SelectedItems(0), 1)

        End Select
    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        ' This subroutine closes the text box

        Select Case e.KeyChar

            Case Microsoft.VisualBasic.ChrW(Keys.Return)    ' Enter key is pressed
                bCancelEdit = False ' editing completed
                e.Handled = True
                TextBox1.Hide()
                If cmdAdd.Text = "Add" Then
                    btnAction = 1
                    cmbGrade.Enabled = False
                    cmdAdd.Text = "Save"
                End If

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
                CurrentSB.Text = CInt(TextBox1.Text).ToString("#,###0.00")
                If cmdAdd.Text = "Add" Then
                    btnAction = 1
                    cmbGrade.Enabled = False
                    cmdAdd.Text = "Save"
                End If

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
        lvGrade.Focus()
    End Sub

    Private Sub BeginEditListItem(iTm As ListViewItem, SubItemIndex As Integer)
        ' This subroutine is for manually initiating editing instead of mouse double-clicks

        Dim pt As Point = iTm.SubItems(SubItemIndex).Bounds.Location
        Dim ee As New System.Windows.Forms.MouseEventArgs(Windows.Forms.MouseButtons.Left, 1, pt.X, pt.Y, 0)
        Call lvGrade_MouseDoubleClick(lvGrade, ee)
    End Sub

    Private Sub cmbGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGrade.SelectedIndexChanged
        loadLV()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        'Dim i As Integer
        If cmdAdd.Text = "Add" Then
            frmGradeInput.ShowDialog()
        ElseIf cmdAdd.Text = "Save" Then
            Dim sql As String

            For x = 0 To lvGrade.Items.Count - 1
                If btnAction = 2 Then
                    sql = "INSERT INTO z_stepincrement SET salary_grade= '" & txtGrade.Text & _
                    "', step_increment='" & lvGrade.Items(x).Text & _
                    "', salary='" & lvGrade.Items(x).SubItems(1).Text & "'"
                ElseIf btnAction = 1 Then
                    sql = "UPDATE z_stepincrement SET salary='" & lvGrade.Items(x).SubItems(1).Text & "' Where salary_grade='" & cmbGrade.Text & "' and step_increment='" & lvGrade.Items(x).Text & "'"
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

            btnAction = 1
            cmbGrade.Enabled = True
            loadCombo()
            cmdAdd.Text = "Add"
            Me.cmbGrade.SelectedIndex = txtGrade.Text - 1
        End If
    End Sub

    Private Sub frmSalaryGrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCombo()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        cmdAdd.Text = "Add"
        btnAction = 0
        cmbGrade.Enabled = True
        loadCombo()
        loadLV()
    End Sub
End Class