Imports System.Data.SqlClient



Module storedprocedure
        Public con As New SqlConnection
        Public cmd As New SqlCommand
        Public reader As SqlDataReader

        Public pblicrollno As String = ""
        Public pblicgrade As String = ""

    Public pblicstaffid As String = ""


    Public username As String = ""



    Public userrrole As String = ""



    Sub connection()
            With con
                .ConnectionString = "Data Source=ASUS\SQLEXPRESS;Initial Catalog=schoolmgmtsystem;Integrated Security=true"
            End With
        End Sub

End Module


