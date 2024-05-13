Imports System.Text

Public Class certificate
    Dim g, mg As Graphics
    Dim bmp As Bitmap
    Private Sub schoolpicturebox_Click(sender As Object, e As EventArgs) Handles schoolpicturebox.Click
        schoolpicturebox.Image = BackgroundImage
        OpenFileDialog1.ShowDialog()
        imageholderbox.Text = OpenFileDialog1.FileName
        If (System.IO.File.Exists(imageholderbox.Text)) Then
            schoolpicturebox.Image = Image.FromFile(imageholderbox.Text)



        End If
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles schoolnamebox.TextChanged
        schoolname.Text = schoolnamebox.Text
        'schoolname.ForeColor = Color.Red ' Set font color to red
        'schoolname.Font = New Font("Arial", 18, FontStyle.Bold) ' Use Arial font with bold style
        'schoolname.TextAlign = ContentAlignment.MiddleCenter ' Center text within the label

        '' Continue with the code to format the label text
        'Dim maxLengthPerLine As Integer = 40 ' Set a maximum length for each line

        '' Split the school name into words
        'Dim words() As String = schoolname.Text.Split(" "c)

        '' Build lines based on maxLengthPerLine
        'Dim lines As New List(Of String)
        'Dim currentLine As New StringBuilder()

        'For Each word As String In words
        '    If currentLine.Length + word.Length + 1 <= maxLengthPerLine Then
        '        ' Add the word to the current line
        '        currentLine.Append(word & " ")
        '    Else
        '        ' Start a new line
        '        lines.Add(currentLine.ToString().Trim())
        '        currentLine = New StringBuilder(word & " ")
        '    End If
        'Next

        '' Add the last line
        'lines.Add(currentLine.ToString().Trim())

        '' Set the label text to the formatted lines
        'schoolname.Text = String.Join(Environment.NewLine, lines)

        '' Set the location of the label to the top center of the form
        'schoolname.Location = New Point((Me.Width - schoolname.Width) \ 2, 10)



        ' Assuming there's a list to keep track of existing controls on the form
        Dim existingControls As New List(Of Control)

        ' Set the label properties
        schoolname.ForeColor = Color.Red ' Set font color to red
        schoolname.Font = New Font("Arial", 18, FontStyle.Bold) ' Use Arial font with bold style
        schoolname.TextAlign = ContentAlignment.MiddleCenter ' Center text within the label
        schoolname.BackColor = Color.Transparent


        ' Continue with the code to format the label text
        Dim maxLengthPerLine As Integer = 40 ' Set a maximum length for each line

        ' Split the school name into words
        Dim words() As String = schoolname.Text.Split(" "c)

        ' Build lines based on maxLengthPerLine
        Dim lines As New List(Of String)
        Dim currentLine As New StringBuilder()

        For Each word As String In words
            If currentLine.Length + word.Length + 1 <= maxLengthPerLine Then
                ' Add the word to the current line
                currentLine.Append(word & " ")
            Else
                ' Start a new line
                lines.Add(currentLine.ToString().Trim())
                currentLine = New StringBuilder(word & " ")
            End If
        Next

        ' Add the last line
        lines.Add(currentLine.ToString().Trim())

        ' Set the label text to the formatted lines
        schoolname.Text = String.Join(Environment.NewLine, lines)

        ' Check for collisions and move the text to the next line if needed
        Dim nextLine As Integer = 1 ' Start checking from the second line
        While IntersectsOtherControls(schoolname, existingControls)
            ' Move the text to the next line
            schoolname.Text = String.Join(Environment.NewLine, lines.Skip(nextLine))

            ' Update the next line counter
            nextLine += 1
        End While

        ' Set the location of the label to the top center of the form
        schoolname.Location = New Point((Me.Width - schoolname.Width) \ 2, 10)

        ' Helper function to check if the control intersects with other controls


    End Sub

    Private Function IntersectsOtherControls(control As Control, controlsList As List(Of Control)) As Boolean
        For Each existingControl As Control In controlsList
            If control.Bounds.IntersectsWith(existingControl.Bounds) Then
                Return True
            End If
        Next
        Return False
    End Function




    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        PrintDocument1.DefaultPageSettings.Landscape = True


        ' Get the Graphics object to draw on
        Dim g As Graphics = e.Graphics

        ' Create a Bitmap to store the contents of the panel
        Dim bmp As New Bitmap(certificatemainpanel.Width, certificatemainpanel.Height)
        certificatemainpanel.DrawToBitmap(bmp, New Rectangle(0, 0, certificatemainpanel.Width, certificatemainpanel.Height))

        ' Draw the panel contents onto the printed page
        g.DrawImage(bmp, New Point(10, 10)) ' Adjust the location as needed
    End Sub

    Private Sub certificateprintbtn_Click(sender As Object, e As EventArgs) Handles certificateprintbtn.Click

        certificateprintbtn.Hide()
        PrintDocument1.DefaultPageSettings.Landscape = True

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()


        'Create a New PrintDialog instance
        Dim printDialog As New PrintDialog
        'Show the PrintDialog()
        If printDialog.ShowDialog = DialogResult.OK Then
            ' Set the PrintDocument's PrinterSettings to the selected printer
            PrintDocument1.PrinterSettings = printDialog.PrinterSettings

            ' Handle the PrintPage event to define what to print
            AddHandler PrintDocument1.PrintPage, AddressOf PrintDocument1_PrintPage



            ' Print the document
            PrintDocument1.Print()
            certificateprintbtn.Show()
        End If
    End Sub
End Class