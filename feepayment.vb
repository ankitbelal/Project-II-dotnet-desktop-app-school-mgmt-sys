Imports System.Data.SqlClient
Imports System.Diagnostics.Contracts
Imports System.Net
Imports System.Security.Cryptography

Public Class feepayment

    Public tutor As Integer = 0
    Public bus As Integer = 0
    Public lab As Integer = 0
    Public library As Integer = 0
    Public exam As Integer = 0
    Public sport As Integer = 0
    Public total As Integer = 0
    Public month As Integer = 0
    Private Function IsDuplicatemonth(ByVal month As String)
        Try
            For Each row As DataGridViewRow In feedetailgrid.Rows
                If row.Cells("month").Value IsNot Nothing AndAlso row.Cells("month").Value.ToString() = month Then
                    Return True ' Found a duplicate in the DataGridView
                End If
            Next

            Return False ' No duplicate found in the DataGridView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Private Sub paybtn_Click(sender As Object, e As EventArgs) Handles paybtn.Click
        connection()

        Try
            For Each item As String In monthbox.CheckedItems
                If IsDuplicatemonth(item) Then
                    MessageBox.Show("Fee has been already paid for the month", "payment failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    GoTo Label1
                Else
                    con.Open()
                    cmd = New SqlCommand("sppayfee", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    With cmd
                        .Parameters.AddWithValue("@grade", gradebox.Text)
                        .Parameters.AddWithValue("@roll", studentrollbox.Text)
                        .Parameters.AddWithValue("@month", item)
                        .Parameters.AddWithValue("@paidamount", totalbox.Text)
                        .Parameters.AddWithValue("paiddate", SqlDbType.Date).Value = DateTime.Now.Date
                        .Parameters.AddWithValue("@tutor", tutorbox.Text)
                        .Parameters.AddWithValue("@lab", labbox.Text)
                        .Parameters.AddWithValue("@library", librarybox.Text)
                        .Parameters.AddWithValue("@bus", busfarebox.Text)
                        .Parameters.AddWithValue("@exam", exambox.Text)
                        .Parameters.AddWithValue("@sport", sportbox.Text)

                        .ExecuteNonQuery()
                    End With
                    con.Close()
                End If

            Next
            MessageBox.Show("Payment Successfull", "Fee Paid", MessageBoxButtons.OK, MessageBoxIcon.Information)
Label1:
        Catch ex As Exception
            con.Close()

            MsgBox(ex.Message)
        End Try



        seefee()


    End Sub









    Private Sub loaddata()
        connection()
        headinglabel.Text = "MONTHLY FEE STRUCTURE "





        'for showing the student roll in the combobox to select su
        Try
            con.Open()
            studentrollbox.Items.Clear()
            Using cmd = New SqlCommand("spviewstudent", con)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@grade", gradebox.Text)

                Using reader = cmd.ExecuteReader
                    While reader.Read()
                        ' Add each teacher name to the ComboBox
                        Dim roll As String = reader("rollno").ToString
                        studentrollbox.Items.Add(roll)

                    End While
                End Using

            End Using

            con.Close()


        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub gradebox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gradebox.SelectedIndexChanged
        connection()

        loaddata()











        Try
            con.Open()

            cmd = New SqlCommand("spfeebox", con)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@grade", gradebox.Text)

                Using adapter As New SqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    If dataTable.Rows.Count > 0 Then

                        tutorbox.Text = dataTable.Rows(0)("Tutor Charge").ToString()
                        librarybox.Text = dataTable.Rows(0)("Library Charge").ToString()
                        buschk.Text = dataTable.Rows(0)("Bus Fare").ToString()

                        labbox.Text = dataTable.Rows(0)("Laboratory Charge").ToString()


                        exambox.Text = dataTable.Rows(0)("Exam Fee").ToString()
                        sportbox.Text = dataTable.Rows(0)("Sports Fee").ToString()






                    Else


                        MessageBox.Show("no fee assigned to grade " + gradebox.Text, "Fee Data not found", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If
                End Using
            End With



            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try








    End Sub


    Private Sub totalbtn_Click(sender As Object, e As EventArgs) Handles totalbtn.Click



        month = monthbox.CheckedItems.Count
        total = tutor + lab + library + sport + bus

        totalbox.Text = "Rs:   " + ((month * total) + exam).ToString


    End Sub

    Private Sub studentrollbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studentrollbox.SelectedIndexChanged


        Try
            con.Open()
            Using cmd = New SqlCommand("spstudentbox", con)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd
                    .Parameters.AddWithValue("@grade", gradebox.Text)
                    .Parameters.AddWithValue("@roll", studentrollbox.Text)

                End With
                Using reader = cmd.ExecuteReader
                    While reader.Read()
                        Dim fullname As String = reader("firstname").ToString() + " " + reader("lastname").ToString()
                        studentname.Text = fullname


                    End While
                End Using
            End Using
            con.Close()

        Catch ex As Exception
            con.Close()

            MsgBox(ex.Message)
        End Try



        'this is to see the fee of student
        seefee()



    End Sub



    Private Sub studentname_TextChanged_1(sender As Object, e As EventArgs) Handles studentname.TextChanged
        headinglabel.Text = ""
        Dim text As String = "FEE OF " + studentname.Text
        headinglabel.Text = text

    End Sub



    Private Sub seefee()
        Try
            con.Open()
            Using adapter As New SqlDataAdapter("spfeedetail", con)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure
                adapter.SelectCommand.Parameters.AddWithValue("@grade", gradebox.Text)
                adapter.SelectCommand.Parameters.AddWithValue("@roll", studentrollbox.Text)
                Dim datatable As New DataTable
                adapter.Fill(datatable)
                feedetailgrid.DataSource = datatable



            End Using

            con.Close()

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub tutorchk_CheckedChanged(sender As Object, e As EventArgs) Handles tutorchk.CheckedChanged
        If tutorchk.Checked Then
            Dim text As String = tutorbox.Text.ToString()

            tutor = Integer.Parse(text)

        Else
            tutor = 0
        End If
    End Sub



    Private Sub librarychk_CheckedChanged(sender As Object, e As EventArgs) Handles librarychk.CheckedChanged


        If librarychk.Checked Then
            Dim text As String = librarybox.Text
            library = Integer.Parse(text)

        Else
            library = 0
        End If
    End Sub

    Private Sub buschk_CheckedChanged(sender As Object, e As EventArgs) Handles buschk.CheckedChanged
        If buschk.Checked Then
            Dim text As String = busfarebox.Text
            bus = Integer.Parse(text)

        Else
            bus = 0
        End If
    End Sub

    Private Sub examchk_CheckedChanged(sender As Object, e As EventArgs) Handles examchk.CheckedChanged
        If examchk.Checked Then
            Dim text As String = exambox.Text
            exam = Integer.Parse(text)

        Else
            exam = 0
        End If

    End Sub

    Private Sub labchk_CheckedChanged(sender As Object, e As EventArgs) Handles labchk.CheckedChanged
        If labchk.Checked Then
            Dim text As String = labbox.Text
            lab = Integer.Parse(text)

        Else
            lab = 0
        End If

    End Sub

    Private Sub sportchk_CheckedChanged(sender As Object, e As EventArgs) Handles sportchk.CheckedChanged
        If sportchk.Checked Then
            Dim text As String = sportbox.Text
            sport = Integer.Parse(text)

        Else
            sport = 0
        End If
    End Sub

    Private Sub feepayment_Load(sender As Object, e As EventArgs) Handles Me.Load
        loaddata()
        'for showing in the datatable
        Try
            con.Open()

            Using adapter As New SqlDataAdapter("spviewfee", con)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure

                Dim datatable As New DataTable
                adapter.Fill(datatable)
                feedetailgrid.DataSource = datatable



            End Using


            con.Close()

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)

        End Try

    End Sub
End Class