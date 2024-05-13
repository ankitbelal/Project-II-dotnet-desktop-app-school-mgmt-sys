Imports System.Data.SqlClient

Public Class teacherprofileview


    Dim gender As String



    Private Sub stdeditbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        tdob.Hide()
        tgenderbox.Hide()

        tdobbox.Show()
        malelabel.Show()
        femalelabel.Show()
        otherlabel.Show()
        tgenderfemale.Show()
        tgendermale.Show()
        tgederother.Show()
        savebtn.Show()




        tid.ReadOnly = False
        tfname.ReadOnly = False

        tlname.ReadOnly = False
        taddress.ReadOnly = False
        tcontact.ReadOnly = False
        temail.ReadOnly = False
        tfathername.ReadOnly = False
        tgenderbox.ReadOnly = False
        tdob.ReadOnly = False
        tqualification.ReadOnly = False
        tpost.ReadOnly = False
        tsalary.ReadOnly = False


    End Sub
    Private Function IsDuplicatets(ByVal id As String)
        con.Close()
        Try
            con.Open()
            cmd = New SqlCommand("spcheckstaff", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)

            cmd.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output

            cmd.ExecuteNonQuery()



            con.Close()


            If cmd.Parameters("@result").Value IsNot DBNull.Value AndAlso CInt(cmd.Parameters("@result").Value) = 1 And tid.Text <> pblicstaffid Then
                Return True
            Else
                Return False
            End If



            'Dim resultValue As Object = cmd.Parameters("@result").Value
            'If resultValue IsNot DBNull.Value Then
            '    Dim result As Integer = Convert.ToInt32(resultValue)
            '    If result = 1 AndAlso tid.Text <> pblicstaffid Then
            '        Return True
            '    ElseIf result = 1 And tid.Text = pblicstaffid Then
            '        Return False
            '    End If

            'End If

            'Return False


        Catch ex As Exception

            con.Close()
            MsgBox(ex.Message)

        End Try



    End Function
    Private Sub teacherprofileview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tdobbox.MaxDate = DateTime.Today

        con.Close()

        tdob.Show()
        tgenderbox.Show()

        tdobbox.Hide()
        malelabel.Hide()
        femalelabel.Hide()
        otherlabel.Hide()
        tgenderfemale.Hide()
        tgendermale.Hide()
        tgederother.Hide()
        savebtn.Hide()
        Try
            con.Open()

            cmd = New SqlCommand("spstaffprofile", con)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@staffid", pblicstaffid)

                Using adapter As New SqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    If dataTable.Rows.Count > 0 Then

                        tid.Text = dataTable.Rows(0)("ID").ToString()
                        tfname.Text = dataTable.Rows(0)("First Name").ToString()
                        tlname.Text = dataTable.Rows(0)("Last Name").ToString()

                        taddress.Text = dataTable.Rows(0)("Address").ToString()


                        tgenderbox.Text = dataTable.Rows(0)("Gender").ToString()
                        tdob.Text = dataTable.Rows(0)("DOB").ToString()
                        tqualification.Text = dataTable.Rows(0)("Quallification").ToString()
                        temail.Text = dataTable.Rows(0)("Email").ToString

                        tcontact.Text = dataTable.Rows(0)("Contact").ToString()
                        tpost.Text = dataTable.Rows(0)("Post").ToString()
                        tsalary.Text = dataTable.Rows(0)("Salary").ToString()
                        tfathername.Text = dataTable.Rows(0)("Father Name").ToString()




                        'this is to display the photo from the path stored in the database




                        Dim photo As String = dataTable.Rows(0)("Photo").ToString()
                        Using fs As New System.IO.FileStream(photo, IO.FileMode.Open)
                            profilebox.Image = New Bitmap(Image.FromStream(fs))

                        End Using
                        profilelabel.Text = "PROFILE OF " + tfname.Text + " " + tlname.Text

                    Else
                        MsgBox("Teacher not found.", vbCritical, vbOKOnly)

                    End If
                End Using
            End With



            con.Close()



        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try

        tid.ReadOnly = True
        tfname.ReadOnly = True

        tlname.ReadOnly = True
        taddress.ReadOnly = True
        tcontact.ReadOnly = True
        temail.ReadOnly = True
        tfathername.ReadOnly = True
        tgenderbox.ReadOnly = True
        tdob.ReadOnly = True
        tqualification.ReadOnly = True
        tpost.ReadOnly = True
        tsalary.ReadOnly = True

        'Stdprofilecontactbox.ReadOnly = True

    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        If tfname.Text = "" Or tlname.Text = "" Or taddress.Text = "" Or tid.Text = "" Or gender = "" Or tdobbox.Text = "" Or tcontact.Text = "" Or tsalary.Text = "" Or tqualification.Text = "" Or tpost.Text = "" Then
            MessageBox.Show("Please Update all necessary fields ", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf IsDuplicatets(tid.Text) Then
            MessageBox.Show("Duplicate record for this Id", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try
                con.Open()
                cmd = New SqlCommand("speditstaff", con)
                With cmd
                    cmd.CommandType = CommandType.StoredProcedure

                    .Parameters.AddWithValue("@staffid", pblicstaffid)

                    .Parameters.AddWithValue("@newstaffid", tid.Text)
                    .Parameters.AddWithValue("@firstname", tfname.Text)
                    .Parameters.AddWithValue("@lastname", tlname.Text)
                    .Parameters.AddWithValue("@email", temail.Text)
                    .Parameters.AddWithValue("@contact", tcontact.Text)
                    .Parameters.AddWithValue("@address", taddress.Text)

                    .Parameters.AddWithValue("@dob", tdobbox.Text)
                    .Parameters.AddWithValue("@fathername", tfathername.Text)
                    .Parameters.AddWithValue("@gender", gender)
                    .Parameters.AddWithValue("@quallification", tqualification.Text)
                    .Parameters.AddWithValue("@salary", tsalary.Text)
                    .Parameters.AddWithValue("@post", tpost.Text)




                    .ExecuteNonQuery()
                End With


                con.Close()
                MessageBox.Show("Record Updated Successfully", "Update success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message)

            End Try

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

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        con.Close()

        Dim result As DialogResult = MessageBox.Show("Are you sure to delete this record?", "Delete student Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                con.Open()
                cmd = New SqlCommand("spdeletestaff", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", pblicstaffid)

                cmd.ExecuteNonQuery()


                con.Close()

                MessageBox.Show("Record deleted Successfully", "Delete record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()



            Catch ex As Exception

                con.Close()
                MsgBox(ex.Message)

            End Try
        End If
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
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If


    End Sub
End Class