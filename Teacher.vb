
Imports System.Data.SqlClient
Public Class Teacher


    Dim gender As String


    Private Function IsDuplicatet5(ByVal id As String)
        con.Close()
        Try
            con.Open()
            cmd = New SqlCommand("spcheckstaff", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)

            cmd.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output

            cmd.ExecuteNonQuery()



            con.Close()


            If cmd.Parameters("@result").Value IsNot DBNull.Value AndAlso CInt(cmd.Parameters("@result").Value) = 1 Then
                Return True
            Else
                Return False
            End If





        Catch ex As Exception

            con.Close()
            MsgBox(ex.Message)

        End Try



    End Function
    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        If tfname.Text = "" Or tlname.Text = "" Or taddress.Text = "" Or tid.Text = "" Or gender = "" Or tdobbox.Text = "" Or tcontact.Text = "" Or tsalary.Text = "" Or tqualification.Text = "" Or tpost.Text = "" Then
            MessageBox.Show("Please Update all necessary fields ", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf IsDuplicatet5(tid.Text) Then
            MessageBox.Show("Duplicate record for this Id", "can't save", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try

                Dim path As String = "C:\Users\ankit\source\repos\schoolmgmtsytem\bin\Debug\net8.0-windows\smsphoto" & tid.Text + tfname.Text + tlname.Text & ".jpg"
                If profilebox.Image Is Nothing Then
                    profilebox.BackgroundImage.Save(path)
                Else
                    profilebox.Image.Save(path)
                End If


                con.Open()
                cmd = New SqlCommand("spaddstaff", con)

                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@id", tid.Text)

                    .Parameters.AddWithValue("@firstname", tfname.Text)
                    .Parameters.AddWithValue("@lastname", tlname.Text)
                    .Parameters.AddWithValue("@address", taddress.Text)
                    .Parameters.AddWithValue("@email", temail.Text)
                    .Parameters.AddWithValue("@quallification", tqualification.Text)
                    .Parameters.AddWithValue("@dob", tdobbox.Text)
                    .Parameters.AddWithValue("@fathername", tfathername.Text)
                    .Parameters.AddWithValue("@contact", tcontact.Text)
                    .Parameters.AddWithValue("@gender", gender)
                    .Parameters.AddWithValue("@joineddate", SqlDbType.Date).Value = DateTime.Now.Date
                    .Parameters.AddWithValue("@salary", tsalary.Text)
                    .Parameters.AddWithValue("@post", tpost.Text)
                    .Parameters.AddWithValue("@photo", path)









                    .ExecuteNonQuery()



                End With



                con.Close()

                MessageBox.Show("Staff Added Successfully ", "Save Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message)
            End Try

            loaddata()
        End If

    End Sub

    Private Sub tgendermale_CheckedChanged(sender As Object, e As EventArgs) Handles tgendermale.CheckedChanged
        gender = "Male"

    End Sub

    Private Sub tgenderfemale_CheckedChanged(sender As Object, e As EventArgs) Handles tgenderfemale.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub tgederother_CheckedChanged(sender As Object, e As EventArgs) Handles tgederother.CheckedChanged
        gender = "Other"
    End Sub

    Private Sub profilebox_Click(sender As Object, e As EventArgs) Handles profilebox.Click
        profilebox.Image = BackgroundImage

        OpenFileDialog1.ShowDialog()
        teacherimageholder.Text = OpenFileDialog1.FileName
        If IO.File.Exists(teacherimageholder.Text) Then
            profilebox.Image = Image.FromFile(teacherimageholder.Text)



        End If
    End Sub

    Private Sub Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()

    End Sub
    Private Sub loaddata()
        profilebox.Image = BackgroundImage
        teacherimageholder.Hide()

        Try
            con.Open()

            Using adapter As New SqlDataAdapter("sprecentstaff", con)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure

                Dim datatable As New DataTable
                adapter.Fill(datatable)
                recentstaff.DataSource = datatable

            End Using
            con.Close()

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try


    End Sub



    Private Sub tcontact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcontact.KeyPress
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If

        ' Check if the total number of digits is greater than or equal to 10
        If tcontact.Text.Length >= 10 AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the total number of digits is already 10, suppress the keypress
            e.Handled = True
        End If
    End Sub



    Private Sub tid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tid.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If
    End Sub



    Private Sub tsalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tsalary.KeyPress
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If
    End Sub
End Class