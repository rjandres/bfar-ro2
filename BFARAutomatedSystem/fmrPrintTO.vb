Imports System.Drawing.Printing

Public Class fmrPrintTO
    Public Property PrinterSettings As PrinterSettings
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintForm1.PrinterSettings.Copies = 1
        Button1.Visible = False
        If PrintForm1.PrinterSettings.IsValid Then
            With Me.PrintForm1
                .PrintAction = Printing.PrintAction.PrintToPrinter

                Dim MyMargins As New Margins
                With MyMargins
                    .Left = 0
                    .Right = 0
                    .Top = 0
                    .Bottom = 0
                End With
                .PrinterSettings.DefaultPageSettings.Margins = MyMargins
                .Print(Me, PowerPacks.Printing.PrintForm.PrintOption.CompatibleModeClientAreaOnly)

            End With
        End If
        Button1.Visible = True

    End Sub


    Private Sub fmrPrintTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Me.ReportViewer1.RefreshReport()
    End Sub
End Class