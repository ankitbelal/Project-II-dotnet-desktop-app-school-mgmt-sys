Public Class Gradesheet
    Dim g, mg As Graphics
    Dim bmp As Bitmap
    Private Sub Gradesheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        PrintDocument1.DefaultPageSettings.Landscape = True


        ' Get the Graphics object to draw on
        Dim g As Graphics = e.Graphics

        ' Create a Bitmap to store the contents of the panel
        Dim bmp As New Bitmap(gradesheetmainpanel.Width, gradesheetmainpanel.Height)
        gradesheetmainpanel.DrawToBitmap(bmp, New Rectangle(0, 0, gradesheetmainpanel.Width, gradesheetmainpanel.Height))

        ' Draw the panel contents onto the printed page
        g.DrawImage(bmp, New Point(1, 1)) ' Adjust the location as needed
    End Sub

    Private Sub gradesheetprintbtn_Click(sender As Object, e As EventArgs) Handles gradesheetprintbtn.Click

        gradesheetprintbtn.Hide()
        PrintDocument1.DefaultPageSettings.Landscape = True

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()


        'Create a New PrintDialog instance
        Dim printDialog As New PrintDialog()
        'Show the PrintDialog()
        If printDialog.ShowDialog() = DialogResult.OK Then
            ' Set the PrintDocument's PrinterSettings to the selected printer
            PrintDocument1.PrinterSettings = printDialog.PrinterSettings

            ' Handle the PrintPage event to define what to print
            AddHandler PrintDocument1.PrintPage, AddressOf PrintDocument1_PrintPage



            ' Print the document
            PrintDocument1.Print()
            gradesheetprintbtn.Show()
        End If
    End Sub
End Class