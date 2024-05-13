Imports System.Data.SqlClient


Public Class manage_user

    Private Sub manage_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userdatagrid.Text = "ALL SYSTEM USERS"
        savebtn.Hide()
        Cancelbtn.Hide()
        userrole.Hide()
        username.Hide()
        useremail.Hide()

        loaddata()


    End Sub

    Private Sub addbutton_Click(sender As Object, e As EventArgs) Handles addbutton.Click
        con.Close()

        headinglabel.Text = "ADD USER"
        savebtn.Show()
        Cancelbtn.Show()
        userrole.Show()
        username.Show()
        useremail.Show()

        deletebtn.Hide()




        'for showing the teachers name in the combobox to select user from staff while adding user
        Try
            connection()

            con.Open()
            usercombo.Items.Clear()
            Using cmd = New SqlCommand("spviewstaff", con)
                cmd.CommandType = CommandType.StoredProcedure
                Using reader = cmd.ExecuteReader
                    While reader.Read()
                        ' Add each staff name to the ComboBox


                        Dim fullname As String = reader("First Name").ToString() + " " + reader("Last Name").ToString()
                        usercombo.Items.Add(fullname)
                    End While
                End Using

            End Using

            con.Close()


        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)

        End Try




    End Sub



    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        userdatagrid.Text = "ALL SYSTEM USERS"
        savebtn.Hide()
        Cancelbtn.Hide()
        userrole.Hide()
        username.Hide()
        useremail.Hide()

        deletebtn.Show()
        addbutton.Show()



    End Sub


    Private Sub loaddata()

        con.Close()

        Try
            con.Open()
            Using adapter As New SqlDataAdapter("spviewuser", con)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure

                Dim datatable As New DataTable
                adapter.Fill(datatable)
                userdatagrid.DataSource = datatable



            End Using


            con.Close()

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try



    End Sub
    Private Function IsDuplicateEmail(ByVal email As String)
        Try
            For Each row As DataGridViewRow In userdatagrid.Rows
                If row.Cells("Email").Value IsNot Nothing AndAlso row.Cells("Email").Value.ToString() = email Then
                    Return True ' Found a duplicate in the DataGridView
                End If
            Next

            Return False ' No duplicate found in the DataGridView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Private Function IsDuplicateid(ByVal id As String)
        Try
            For Each row As DataGridViewRow In userdatagrid.Rows
                If row.Cells("Email").Value IsNot Nothing AndAlso row.Cells("Userid").Value.ToString() = id Then
                    Return True ' Found a duplicate in the DataGridView
                End If
            Next

            Return False ' No duplicate found in the DataGridView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Function IsDuplicateusername(ByVal username As String)
        Try
            For Each row As DataGridViewRow In userdatagrid.Rows
                If row.Cells("Username").Value IsNot Nothing AndAlso row.Cells("Username").Value.ToString() = username Then
                    Return True ' Found a duplicate in the DataGridView
                End If
            Next

            Return False ' No duplicate found in the DataGridView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click

        con.Close()


        If usercombo.Text = "" Or staffid.Text = "" Or userrole.Text = "" Or useremail.Text = "" Or username.Text = "" Then
            MessageBox.Show("All feelds are required", "Failed to add user", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf IsDuplicateEmail(useremail.text) Then
            MessageBox.Show("Email already assigned to user", "can't create user", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf IsDuplicateid(staffid.text) Then
            MessageBox.Show("User already exists", "can't create user", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf IsDuplicateusername(username.text) Then
            MessageBox.Show("Username already exists", "can't create user", MessageBoxButtons.OK, MessageBoxIcon.Error)




        Else

            Try
                con.Open()
                cmd = New SqlCommand("spadduser", con)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd
                    .Parameters.AddWithValue("@userid", staffid.Text)
                    .Parameters.AddWithValue("@role", userrole.Text)
                    .Parameters.AddWithValue("username", username.Text)
                    .Parameters.AddWithValue("@email", useremail.Text)
                    .ExecuteNonQuery()

                End With
                con.Close()

                MessageBox.Show("User Created Successfully", "User Created", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message)
            End Try
            loaddata()

        End If

    End Sub



    Private Sub usercombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles usercombo.SelectedIndexChanged
        con.Close()

        Try
            con.Open()
            Using cmd = New SqlCommand("spfindsubteacher", con)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd
                    .Parameters.AddWithValue("@fullname", usercombo.Text)

                End With
                Using reader = cmd.ExecuteReader
                    While reader.Read()
                        staffid.Text = reader("ID").ToString()
                        staffid.ReadOnly = True

                    End While
                End Using
            End Using
            con.Close()

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        con.Close()

        If staffid.Text = "" Or staffid.Text = "Staff ID*" Then
            MessageBox.Show("Please enter staff id to delete user", "Fields Required!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result As DialogResult = MessageBox.Show("Are you sure to delete this record?", "Delete user", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Try
                    con.Open()
                    cmd = New SqlCommand("spdeleteuser", con)
                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@id", staffid.Text)
                    cmd.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output

                    cmd.ExecuteNonQuery()
                    If CInt(cmd.Parameters("@result").Value = 1) Then
                        MessageBox.Show("User Removed Successfully", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    Else
                        MessageBox.Show("User doesn't found!", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
End Class