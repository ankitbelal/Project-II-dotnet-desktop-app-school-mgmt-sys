Imports Microsoft.VisualBasic.ApplicationServices

Imports System.Data.SqlClient
Public Class Dashboard

    Private gen As Gradesheet
    Private certificate As certificate






    Private Sub generategradesheetpnl_Click(sender As Object, e As EventArgs) Handles generategradesheetpnl.Click



        If gen Is Nothing OrElse gen.IsDisposed Then
            gen = New Gradesheet


        End If
        gen.Show()
    End Sub

    Private Sub generatecertificatepnl_Click(sender As Object, e As EventArgs) Handles generatecertificatepnl.Click
        If certificate Is Nothing OrElse certificate.IsDisposed Then
            certificate = New certificate


        End If
        certificate.Show()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Close()
        rolelabel.Text = userrrole


        Try
            con.Open()
            cmd = New SqlCommand("spcountstudent", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim count As Integer = cmd.ExecuteScalar()
            numberofstudentlabel.Text = count


            con.Close()

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)

        End Try


        con.Close()

        Try
            con.Open()
            cmd = New SqlCommand("spcountstaff", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim count As Integer = cmd.ExecuteScalar()
            numberofstafflabel.Text = count
            con.Close()

        Catch ex As Exception

        End Try
    End Sub




End Class