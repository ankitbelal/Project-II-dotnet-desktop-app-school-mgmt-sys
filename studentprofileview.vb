
Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class studentprofileview
    Private Sub studentprofileview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Stdprofiledobbox.MaxDate = DateTime.Today




        connection()


        stdsaverbtn.Hide()
        ' to show the data in profile format while searching student 
        Try

            con.Open()

            cmd = New SqlCommand("spstudentprofile", con)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@studentid", pblicrollno)
                .Parameters.AddWithValue("@grade", pblicgrade)
                Using adapter As New SqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    If dataTable.Rows.Count > 0 Then

                        Stdprofilefnamebox.Text = dataTable.Rows(0)("firstname").ToString()
                        Stdprofilelnamebox.Text = dataTable.Rows(0)("lastname").ToString()
                        stdprofileaddressbox.Text = dataTable.Rows(0)("saddress").ToString()

                        Stdprofilerollbox.Text = dataTable.Rows(0)("rollno").ToString()


                        stdprofilegenderbox.Text = dataTable.Rows(0)("gender").ToString()
                        Stdprofiledobbox.Text = dataTable.Rows(0)("dob").ToString()
                        Stdprofileparentnamebox.Text = dataTable.Rows(0)("parentname").ToString()
                        Stdprofileemailbox.Text = dataTable.Rows(0)("email").ToString

                        Stdprofilecontactbox.Text = dataTable.Rows(0)("contact").ToString()
                        Stdprofilegradebox.Text = dataTable.Rows(0)("grade").ToString()


                        'this is to display the photo from the path stored in the database



                        Dim photo As String = dataTable.Rows(0)("photo").ToString()
                        Using fs As New System.IO.FileStream(photo, IO.FileMode.Open)
                            stdprofilebox.Image = New Bitmap(Image.FromStream(fs))

                        End Using

                    Else
                        MsgBox("Student not found.", vbCritical, vbOKOnly)

                    End If
                End Using
            End With








            con.Close()




        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

        Stdprofilefnamebox.ReadOnly = True
        Stdprofilelnamebox.ReadOnly = True
        stdprofileaddressbox.ReadOnly = True
        Stdprofilerollbox.ReadOnly = True
        stdprofilegenderbox.ReadOnly = True
        Stdprofileparentnamebox.ReadOnly = True
        Stdprofileemailbox.ReadOnly = True
        Stdprofilecontactbox.ReadOnly = True




    End Sub

    Private Sub stdeditbtn_Click(sender As Object, e As EventArgs) Handles stdeditbtn.Click

        stdsaverbtn.Show()



        Stdprofilerollbox.ReadOnly = False
        Stdprofilefnamebox.ReadOnly = False
        Stdprofilelnamebox.ReadOnly = False
        stdprofileaddressbox.ReadOnly = False
        Stdprofilerollbox.ReadOnly = False
        stdprofilegenderbox.ReadOnly = False
        Stdprofileparentnamebox.ReadOnly = False
        Stdprofileemailbox.ReadOnly = False
        Stdprofilecontactbox.ReadOnly = False
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



            If cmd.Parameters("@result").Value IsNot DBNull.Value AndAlso CInt(cmd.Parameters("@result").Value) = 1 And Stdprofilegradebox.Text <> pblicgrade AndAlso Stdprofilerollbox.Text <> pblicrollno Then
                Return True
            Else
                Return False
            End If










        Catch ex As Exception

            con.Close()
            MsgBox(ex.Message)

        End Try



    End Function

    Private Sub stdsaverbtn_Click(sender As Object, e As EventArgs) Handles stdsaverbtn.Click
        If Stdprofilefnamebox.Text = "" Or Stdprofilelnamebox.Text = "" Or stdprofileaddressbox.Text = "" Or Stdprofilerollbox.Text = "" Or Stdprofilegradebox.Text = "" Or stdprofilegenderbox.Text = "" Or Stdprofiledobbox.Text = "" Or Stdprofilecontactbox.Text = "" Then
            MessageBox.Show("Please Update all necessary fields ", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf IsDuplicatet5(Stdprofilerollbox.Text, Stdprofilegradebox.Text) Then
            MessageBox.Show("Roll Number Already assigned to elseone in this grade", "Update failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try


                con.Open()
                cmd = New SqlCommand("spupdatestudent", con)

                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@grade", pblicgrade)
                    .Parameters.AddWithValue("@rollno", pblicrollno)

                    .Parameters.AddWithValue("@newroll", Stdprofilerollbox.Text)
                    .Parameters.AddWithValue("@newgrade", Stdprofilegradebox.Text)
                    .Parameters.AddWithValue("@email", Stdprofileemailbox.Text)
                    .Parameters.AddWithValue("@firstname", Stdprofilefnamebox.Text)
                    .Parameters.AddWithValue("@lastname", Stdprofilelnamebox.Text)
                    .Parameters.AddWithValue("@address", stdprofileaddressbox.Text)

                    .Parameters.AddWithValue("@dob", Stdprofiledobbox.Text)
                    .Parameters.AddWithValue("@parentname", Stdprofileparentnamebox.Text)
                    .Parameters.AddWithValue("@contact", Stdprofilecontactbox.Text)
                    .Parameters.AddWithValue("@gender", stdprofilegenderbox.Text)




                    '.Parameters.AddWithValue("@photo", path)










                    .ExecuteNonQuery()



                End With
                con.Close()

                MessageBox.Show("Record Updated Successfully", "Update success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message, vbCritical)
            End Try

        End If


    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        con.Close()

        Dim result As DialogResult = MessageBox.Show("Are you sure to delete this record?", "Delete student Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                con.Open()
                cmd = New SqlCommand("spdeletestudent", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@roll", Stdprofilerollbox.Text)
                cmd.Parameters.AddWithValue("@grade", pblicgrade)
                cmd.ExecuteNonQuery()


                con.Close()

                MessageBox.Show("Record deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()


                viewstudents.stdviewDataGridView.Refresh()

            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message)





            End Try
        End If
    End Sub



    Private Sub Stdprofilecontactbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Stdprofilecontactbox.KeyPress
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If

        ' Check if the total number of digits is greater than or equal to 10
        If Stdprofilecontactbox.Text.Length >= 10 AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the total number of digits is already 10, suppress the keypress
            e.Handled = True
        End If
    End Sub


    Private Sub Stdprofilerollbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Stdprofilerollbox.KeyPress
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If
    End Sub
End Class