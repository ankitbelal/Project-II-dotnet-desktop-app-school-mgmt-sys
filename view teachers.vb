Imports System.Data.SqlClient

Public Class view_teachers


    Private Sub loaddata()
        Try
            con.Open()

            Using adapter As New SqlDataAdapter("spviewstaff", con)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim datatable As New DataTable
                adapter.Fill(datatable)
                staffviewgrid.DataSource = datatable



            End Using

            con.Close()

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub view_teachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()

    End Sub

    Private Sub searchstaffbtn_Click(sender As Object, e As EventArgs) Handles searchstaffbtn.Click






        If searchstaffid.Text = "" Then
            MsgBox("Please Enter the Staff ID", MsgBoxStyle.Information)



        Else

            pblicstaffid = searchstaffid.Text
            Dim search As New teacherprofileview With {.TopMost = True, .AutoSize = False}
            search.TopLevel = False
            search.Dock = DockStyle.Fill
            APPMAIN.appmainpanel.Controls.Add(search)


            Try
                Dim dataTable As New DataTable()
                con.Open()

                cmd = New SqlCommand("spstaffprofile", con)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@staffid", pblicstaffid)


                    Using adapter As New SqlDataAdapter(cmd)

                        adapter.Fill(dataTable)

                    End Using
                End With
                con.Close()

                If dataTable.Rows.Count > 0 Then
                    search.Show()
                    search.BringToFront()

                Else
                    MsgBox("No Staff found For this ID. Please Enter the Valid Staff ID !", vbCritical, vbOKOnly)

                End If
            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message, vbInformation, vbOKOnly)
            End Try


        End If


    End Sub
End Class