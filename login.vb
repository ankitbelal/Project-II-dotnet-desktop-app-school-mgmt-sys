Imports Guna.UI2.WinForms.Enums

Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        While Me.panelspace.Controls.Count > 0
            Me.panelspace.Controls(0).Dispose()
        End While



        'this is to open form inside a pannel
        Dim start As New startloadingform With {.TopMost = False, .AutoSize = False}
        start.TopLevel = False
        start.Dock = DockStyle.Fill
        Me.panelspace.Controls.Add(start)
        start.Show()



    End Sub


End Class

