Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection.Metadata
Public Class student
    Dim gender As String

    Private Sub student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        Stddobbox.MaxDate = DateTime.Today

    End Sub

    Private Sub loaddata()
        profilebox.Image = BackgroundImage
        imageholderstudent.Hide()

        Try
            con.Open()

            Using adapter As New SqlDataAdapter("sprecentstudent", con)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure

                Dim datatable As New DataTable
                adapter.Fill(datatable)
                recentdatagrid.DataSource = datatable

            End Using
            con.Close()

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try
    End Sub




    Private Function IsDuplicatet5(ByVal roll As String, ByVal grade As String)
        con.Close()
        Try
            con.Open()
            cmd = New SqlCommand("spcheckstudent", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@grade", grade)
            cmd.Parameters.AddWithValue("@roll", roll)
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

    Private Sub stdsaverbtn_Click_1(sender As Object, e As EventArgs) Handles stdsaverbtn.Click

        If Stdfnamebox.Text = "" Or Stdlnamebox.Text = "" Or stdaddressbox.Text = "" Or Stdrollbox.Text = "" Or Stdgradebox.Text = "" Or gender = "" Or Stddobbox.Text = "" Or Stdcontactbox.Text = "" Then
            MessageBox.Show("Please Update all necessary fields ", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf IsDuplicatet5(Stdrollbox.Text, Stdgradebox.Text) Then
            MessageBox.Show("Roll Number Already assigned to elseone in this grade", "Cant Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim path As String = "C:\Users\ankit\source\repos\schoolmgmtsytem\bin\Debug\net8.0-windows\smsphoto" & Stdfnamebox.Text + Stdlnamebox.Text & ".jpg"
                If profilebox.Image Is Nothing Then
                    profilebox.BackgroundImage.Save(path)
                Else
                    profilebox.Image.Save(path)
                End If

                con.Open()
                cmd = New SqlCommand("spaddstudent", con)

                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@rollno", Stdrollbox.Text)
                    .Parameters.AddWithValue("@email", Stdemailbox.Text)
                    .Parameters.AddWithValue("@firstname", Stdfnamebox.Text)
                    .Parameters.AddWithValue("@lastname", Stdlnamebox.Text)
                    .Parameters.AddWithValue("@address", stdaddressbox.Text)
                    .Parameters.AddWithValue("@grade", Stdgradebox.Text)
                    .Parameters.AddWithValue("@dob", Stddobbox.Text)
                    .Parameters.AddWithValue("@parentname", Stdparentnamebox.Text)
                    .Parameters.AddWithValue("@contact", Stdcontactbox.Text)
                    .Parameters.AddWithValue("@gender", gender)
                    .Parameters.AddWithValue("@addeddate", SqlDbType.Date).Value = DateTime.Now.Date
                    .Parameters.AddWithValue("@photo", path)


                    .ExecuteNonQuery()



                End With
                con.Close()
                MessageBox.Show("Record saved Successfully", "Student added", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message, vbCritical)
            End Try
            loaddata()
        End If
    End Sub

    Private Sub stdtxtclearbtn_Click_1(sender As Object, e As EventArgs) Handles stdtxtclearbtn.Click
        Stdfnamebox.ResetText()
        Stdlnamebox.ResetText()
        stdaddressbox.ResetText()
        Stdcontactbox.ResetText()
        Stddobbox.ResetText()
        Stdemailbox.ResetText()
        profilebox.Image = profilebox.BackgroundImage

        Stdparentnamebox.ResetText()
        Stdrollbox.ResetText()
    End Sub

    Private Sub grnderotherbtn_CheckedChanged_1(sender As Object, e As EventArgs) Handles grnderotherbtn.CheckedChanged
        If grnderotherbtn.Checked = True Then
            gender = "OTHER"


        End If
    End Sub

    Private Sub genderfmalebtn_CheckedChanged_1(sender As Object, e As EventArgs) Handles genderfmalebtn.CheckedChanged
        If genderfmalebtn.Checked = True Then
            gender = "FEMALE"

        End If
    End Sub

    Private Sub gendermalebtn_CheckedChanged_1(sender As Object, e As EventArgs) Handles gendermalebtn.CheckedChanged
        If gendermalebtn.Checked = True Then
            gender = "MALE"


        End If

    End Sub

    Private Sub profilebox_Click(sender As Object, e As EventArgs) Handles profilebox.Click
        profilebox.Image = BackgroundImage

        OpenFileDialog1.ShowDialog()
        imageholderstudent.Text = OpenFileDialog1.FileName
        If IO.File.Exists(imageholderstudent.Text) Then
            profilebox.Image = Image.FromFile(imageholderstudent.Text)



        End If
    End Sub


    Private Sub Stdcontactbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Stdcontactbox.KeyPress
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If

        ' Check if the total number of digits is greater than or equal to 10
        If Stdcontactbox.Text.Length >= 10 AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the total number of digits is already 10, suppress the keypress
            e.Handled = True
        End If
    End Sub



    Private Sub Stdrollbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Stdrollbox.KeyPress
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If


    End Sub


End Class