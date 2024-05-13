Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing

Public Class Subject
    Private Sub subgradebox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subgradebox.SelectedIndexChanged
        studentlabel.Text = "ALL SUBJECTS IN GRADE " + subgradebox.Text

        'for showing the data in the gridview


        Try
            con.Open()
            Using adapter As New SqlDataAdapter("spviewsubject", con)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure
                adapter.SelectCommand.Parameters.AddWithValue("@grade", subgradebox.Text)
                Dim datatable As New DataTable
                adapter.Fill(datatable)
                subdetailgrid.DataSource = datatable



            End Using


            con.Close()

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub addbutton_Click(sender As Object, e As EventArgs) Handles addbutton.Click
        headinglabel.Text = "ADD SUBJECTS "
        teacherid.Show()
        teachercombobox.Show()
        authorname.Show()
        savebtn.Show()
        Cancelbtn.Show()
        teacherlabel.Show()
        updatesavebtn.Hide()




    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        If subgradebox.Text = "" And Subcode.Text = "" Then
            MsgBox("Please Select the Grade and Subject code first !")


        ElseIf Subcode.Text = "" Then
            MsgBox("Please enter the Subject code!")

        Else
            headinglabel.Text = "UPDATE SUBJECTS"

            updatesavebtn.Show()

            teacherid.Show()
            teachercombobox.Show()
            authorname.Show()
            savebtn.Hide()

            Cancelbtn.Show()
            teacherlabel.Show()

        End If






    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        con.Close()

        headinglabel.Text = "DELETE SUBJECT"
        If subgradebox.Text = "" Or Subcode.Text = "" Or Subcode.Text = "Subject Code*" Then
            MessageBox.Show("Please enter both Grade and Subject Code to delete subject", "Fields Required!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result As DialogResult = MessageBox.Show("Are you sure to delete this record?", "Delete student Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then

                Try
                    con.Open()
                    cmd = New SqlCommand("spdeletesubject", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@grade", subgradebox.Text)
                    cmd.Parameters.AddWithValue("@code", Subcode.Text)
                    cmd.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output

                    cmd.ExecuteNonQuery()
                    If CInt(cmd.Parameters("@result").Value = 1) Then
                        MessageBox.Show("Record deleted Successfully", "Delete record", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        MessageBox.Show("Record not found", "Delete record", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If


                    con.Close()



                    loaddata()

                Catch ex As Exception

                    con.Close()
                    MsgBox(ex.Message)

                End Try
            End If
        End If
    End Sub

    Private Sub Subject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()



    End Sub

    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        headinglabel.Text = "SUBJECT DETAILS"

        savebtn.Hide()
        teacherid.Hide()
        teachercombobox.Hide()
        authorname.Hide()
        Cancelbtn.Hide()
        teacherlabel.Hide()


    End Sub
    Private Sub loaddata()

        teacherid.Hide()
        teachercombobox.Hide()
        authorname.Hide()
        savebtn.Hide()
        Cancelbtn.Hide()
        teacherlabel.Hide()
        updatesavebtn.Hide()





        'for showing the teachers name in the combobox to select the subject teacher
        Try
            con.Open()
            teachercombobox.Items.Clear()
            Using cmd = New SqlCommand("spviewstaff", con)
                cmd.CommandType = CommandType.StoredProcedure
                Using reader = cmd.ExecuteReader
                    While reader.Read()
                        ' Add each teacher name to the ComboBox


                        Dim fullname As String = reader("First Name").ToString() + " " + reader("Last Name").ToString()
                        teachercombobox.Items.Add(fullname)
                    End While
                End Using

            End Using

            con.Close()


        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)

        End Try


        'for showing the data in the gridview



        Try
            con.Open()
            Using adapter As New SqlDataAdapter("spviewsubject", con)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure
                adapter.SelectCommand.Parameters.AddWithValue("@grade", subgradebox.Text)
                Dim datatable As New DataTable
                adapter.Fill(datatable)
                subdetailgrid.DataSource = datatable



            End Using


            con.Close()

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try







    End Sub

    Private Sub teachercombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles teachercombobox.SelectedIndexChanged
        Try
            con.Open()
            Using cmd = New SqlCommand("spfindsubteacher", con)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd
                    .Parameters.AddWithValue("@fullname", teachercombobox.Text)

                End With
                Using reader = cmd.ExecuteReader
                    While reader.Read()
                        teacherid.Text = reader("ID").ToString()
                        teacherid.ReadOnly = True

                    End While
                End Using
            End Using
            con.Close()

        Catch ex As Exception

        End Try
    End Sub


    Private Function IsDuplicatet5(ByVal subid As String, ByVal grade As String)
        Try
            For Each row As DataGridViewRow In subdetailgrid.Rows
                If row.Cells("Subject Code").Value IsNot Nothing AndAlso row.Cells("Subject Code").Value.ToString() = subid And row.Cells("Grade").Value IsNot Nothing AndAlso row.Cells("Grade").Value.ToString() = grade Then

                    Return True ' Found a duplicate in the DataGridView
                End If
            Next

            Return False ' No duplicate found in the DataGridView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click

        If subgradebox.Text = "" Or subjectname.Text = "" Or subjectname.Text = "Subject Name*" Or Subcode.Text = "" Or Subcode.Text = "Subject Code*" Or teachercombobox.Text = "" Or teacherid.Text = "" Or teacherid.Text = "Teacher ID*" Then
            MessageBox.Show("All fields required", "Cant Update!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf IsDuplicatet5(Subcode.Text, subgradebox.text) Then

            MessageBox.Show("Subject of this code to this grade already exist", "Duplicate Record!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                con.Open()
                cmd = New SqlCommand("spaddsubject", con)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd
                    .Parameters.AddWithValue("@code", Subcode.Text)
                    .Parameters.AddWithValue("@name", subjectname.Text)
                    .Parameters.AddWithValue("@grade", subgradebox.Text)
                    .Parameters.AddWithValue("@authorname", authorname.Text)
                    .Parameters.AddWithValue("@teacherid", teacherid.Text)

                    .ExecuteNonQuery()

                End With
                MessageBox.Show("Subject Added Successfully", "Save successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                con.Close()

            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message)




            End Try
            loaddata()
        End If
    End Sub

    Private Sub updatesavebtn_Click(sender As Object, e As EventArgs) Handles updatesavebtn.Click
        If subgradebox.Text = "" Or subjectname.Text = "" Or subjectname.Text = "Subject Name*" Or Subcode.Text = "" Or Subcode.Text = "Subject Code*" Or teachercombobox.Text = "" Or teacherid.Text = "" Or teacherid.Text = "Teacher ID*" Then
            MessageBox.Show("All fields required", "Cant Update!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else


            Try

                con.Open()
                cmd = New SqlCommand("speditsubject", con)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd
                    .Parameters.AddWithValue("@subcode", Subcode.Text)
                    .Parameters.AddWithValue("@name", subjectname.Text)
                    .Parameters.AddWithValue("@author", authorname.Text)
                    .Parameters.AddWithValue("@teacherid", teacherid.Text)
                    .Parameters.AddWithValue("@grade", subgradebox.Text)
                    .Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output
                    .ExecuteNonQuery()

                End With
                con.Close()
                If CInt(cmd.Parameters("@IsDefault").Value = 1) Then
                    MessageBox.Show("subject updated successfully", "Details Upddated!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record doesnt found", "Update dailed!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message)
            End Try
            loaddata()
        End If
    End Sub


End Class