Imports MySql.Data.MySqlClient
Public Class frmDeduction

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

    Private Sub frmDeduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTypes()
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
                CurrentSB.Text = CInt(TextBox1.Text).ToString("#,###0.00")

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
End Class