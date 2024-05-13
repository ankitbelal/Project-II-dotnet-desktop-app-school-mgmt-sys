Imports System.Data.SqlClient
Imports System.Security.Cryptography
Public Class fee_section


    Private Sub savebutton_Click(sender As Object, e As EventArgs) Handles savebutton.Click

        con.Close()

        If gradebox.Text = "" Or tutorchargebox.Text = "" Or busfarebox.Text = "" Or examfeebox.Text = "" Or sportfeebox.Text = "" Or labchargebox.Text = "" Or librarychargebox.Text = "" Then
            MessageBox.Show("All fields are required!", "Fields required", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf IsDuplicategraade(gradebox.text) Then
            MessageBox.Show("The Fee data Already Exists!", "Can't add fee", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try
                con.Open()
                cmd = New SqlCommand("spaddfee", con)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd
                    .Parameters.AddWithValue("@tutor", tutorchargebox.Text)
                    .Parameters.AddWithValue("@sport", sportfeebox.Text)
                    .Parameters.AddWithValue("@library", librarychargebox.Text)
                    .Parameters.AddWithValue("@lab", labchargebox.Text)
                    .Parameters.AddWithValue("@bus", busfarebox.Text)
                    .Parameters.AddWithValue("@exam", examfeebox.Text)
                    .Parameters.AddWithValue("@grade", gradebox.Text)

                    .ExecuteNonQuery()


                End With

                con.Close()


                MessageBox.Show("Fee Added Successfully!", "save successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message)
            End Try
            loaddata()
        End If

    End Sub

    Private Sub addfeebtn_Click(sender As Object, e As EventArgs) Handles addfeebtn.Click
        headinglabel.Text = "ADD FEE"
        clearbutton.Show()
        savebutton.Show()
        tutorchargelabel.Show()
        lablabel.Show()
        buslabel.Show()
        examlabel.Show()
        sportslabel.Show()
        librarylabel.Show()
        updatefeebtn.Hide()
        tutorchargebox.Show()
        examfeebox.Show()
        busfarebox.Show()
        labchargebox.Show()
        librarychargebox.Show()
        sportfeebox.Show()
        updatefeebtn.Hide()
        deletefeebtn.Hide()



    End Sub

    Private Sub updatefeebtn_Click(sender As Object, e As EventArgs) Handles updatefeebtn.Click
        headinglabel.Text = "UPDATE FEE"

        clearbutton.Show()
        savebutton.Hide()
        tutorchargelabel.Show()
        lablabel.Show()
        buslabel.Show()
        examlabel.Show()
        sportslabel.Show()
        librarylabel.Show()
        updatefeebtn.Show()
        tutorchargebox.Show()
        examfeebox.Show()
        busfarebox.Show()
        labchargebox.Show()
        librarychargebox.Show()
        sportfeebox.Show()
        addfeebtn.Hide()
        deletefeebtn.Hide()
        updatesavebtn.Show()


    End Sub

    Private Sub clearbutton_Click(sender As Object, e As EventArgs) Handles clearbutton.Click
        loaddata()

    End Sub
    Private Sub loaddata()
        addfeebtn.Show()
        updatefeebtn.Show()
        deletefeebtn.Show()

        clearbutton.Hide()
        savebutton.Hide()
        tutorchargelabel.Hide()
        lablabel.Hide()
        buslabel.Hide()
        examlabel.Hide()
        sportslabel.Hide()
        librarylabel.Hide()
        updatesavebtn.Hide()
        tutorchargebox.Hide()
        examfeebox.Hide()
        busfarebox.Hide()
        labchargebox.Hide()
        librarychargebox.Hide()
        sportfeebox.Hide()

        Try
            con.Open()

            Using adapter As New SqlDataAdapter("spviewfee", con)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure

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

    Private Sub fee_section_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()

    End Sub
    Private Function IsDuplicategraade(ByVal grade As String)
        Try
            For Each row As DataGridViewRow In subdetailgrid.Rows
                If row.Cells("Grade").Value IsNot Nothing AndAlso row.Cells("Grade").Value.ToString() = grade Then
                    Return True ' Found a duplicate in the DataGridView
                End If
            Next

            Return False ' No duplicate found in the DataGridView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Private Sub updatesavebtn_Click(sender As Object, e As EventArgs) Handles updatesavebtn.Click
        con.Close()

        If gradebox.Text = "" Or tutorchargebox.Text = "" Or busfarebox.Text = "" Or examfeebox.Text = "" Or sportfeebox.Text = "" Or labchargebox.Text = "" Or librarychargebox.Text = "" Then
            MessageBox.Show("All fields are required!", "Fields required", MessageBoxButtons.OK, MessageBoxIcon.Error)



        Else

            Try
                con.Open()
                cmd = New SqlCommand("spupdatefee", con)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd
                    .Parameters.AddWithValue("@tutor", tutorchargebox.Text)
                    .Parameters.AddWithValue("@lab", labchargebox.Text)
                    .Parameters.AddWithValue("@exam", examfeebox.Text)
                    .Parameters.AddWithValue("@library", librarychargebox.Text)
                    .Parameters.AddWithValue("@bus", busfarebox.Text)
                    .Parameters.AddWithValue("@sport", sportfeebox.Text)
                    .Parameters.AddWithValue("@grade", gradebox.Text)
                    .Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output
                    .ExecuteNonQuery()

                End With
                con.Close()
                If CInt(cmd.Parameters("@result").Value = 1) Then
                    MessageBox.Show("Fee updated successfully", "Update Fee", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("record doesn't found", "Update Fee", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If


            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message)

            End Try
            loaddata()
        End If

    End Sub

    Private Sub deletefeebtn_Click(sender As Object, e As EventArgs) Handles deletefeebtn.Click
        If gradebox.Text = "" Then
            MessageBox.Show("Select Grade to delete fee", "Delete Fee", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Dim result As DialogResult = MessageBox.Show("Are you sure to delete this record?", "Delete Fee", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Try
                    con.Open()
                    cmd = New SqlCommand("spdeletefee", con)
                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@grade", gradebox.Text)
                    cmd.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output
                    cmd.ExecuteNonQuery()


                    con.Close()
                    If CInt(cmd.Parameters("@result").Value = 1) Then
                        MessageBox.Show("Fee removed Succcessfully", "Delete Fee", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        MessageBox.Show("Can't find record", "Delete Fee", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If


                    loaddata()

                Catch ex As Exception

                    con.Close()
                    MsgBox(ex.Message)

                End Try
            End If
        End If
    End Sub



    Private Sub tutorchargebox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tutorchargebox.KeyPress
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If

    End Sub


    Private Sub sportfeebox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sportfeebox.KeyPress
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If
    End Sub


    Private Sub librarychargebox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles librarychargebox.KeyPress
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If
    End Sub


    Private Sub labchargebox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles labchargebox.KeyPress
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If
    End Sub



    Private Sub busfarebox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles busfarebox.KeyPress
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If
    End Sub


    Private Sub examfeebox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles examfeebox.KeyPress
        ' Check if the entered key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the entered key is not a digit or a control key, suppress the keypress
            e.Handled = True
        End If
    End Sub
End Class