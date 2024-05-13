
Imports System.Data.SqlClient
Public Class viewstudents

    Private Sub stdgradebox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles stdgradebox.SelectedIndexChanged

        studentlabel.Text = "ALL STUDENTS IN GRADE " + stdgradebox.Text
        loaddata()



    End Sub

    Private Sub studentsearchbtn_Click(sender As Object, e As EventArgs) Handles studentsearchbtn.Click

        If stdgradebox.Text = "" And stdrollno.Text = "" Then
            MsgBox("Please select the grade and roll number of student", MsgBoxStyle.Information)

        ElseIf stdgradebox.Text = "" Then
            MsgBox("please select grade", vbInformation)

        ElseIf stdrollno.Text = "" Then

            MsgBox("please enter the roll number of student", vbInformation)



        Else


            pblicrollno = stdrollno.Text
            pblicgrade = stdgradebox.Text

            Dim search As New studentprofileview With {.TopMost = True, .AutoSize = False}
            search.TopLevel = False
            search.Dock = DockStyle.Fill
            APPMAIN.appmainpanel.Controls.Add(search)


            Try
                Dim dataTable As New DataTable()
                con.Open()

                cmd = New SqlCommand("spstudentprofile", con)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@studentid", pblicrollno)
                    .Parameters.AddWithValue("@grade", pblicgrade)
                    Using adapter As New SqlDataAdapter(cmd)

                        adapter.Fill(dataTable)

                    End Using
                End With
                con.Close()

                If DataTable.Rows.Count > 0 Then
                    search.Show()
                    search.BringToFront()

                Else
                    MsgBox("Student not found.", vbCritical, vbOKOnly)

                End If
            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message, vbInformation, vbOKOnly)
            End Try


        End If





    End Sub

    Public Sub loaddata()
        Try

            con.Open()

            Using adapter As New SqlDataAdapter("spviewstudent", con)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure
                adapter.SelectCommand.Parameters.AddWithValue("@grade", stdgradebox.Text)
                Dim datatable As New DataTable
                adapter.Fill(datatable)
                stdviewDataGridView.DataSource = datatable

            End Using





            con.Close()




        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
end Sub
            End Class