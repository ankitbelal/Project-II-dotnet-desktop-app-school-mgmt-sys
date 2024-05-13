Public Class APPMAIN
    Private Sub APPMAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'this is to close already opened forms inside menu panel

        While Me.menupanel.Controls.Count > 0
            Me.menupanel.Controls(0).Dispose()
        End While

        'this open the button option panel
        Dim com As New commom_menu With {.TopMost = False, .AutoSize = False}
        com.TopLevel = False
        com.Dock = DockStyle.Fill
        menupanel.Controls.Add(com)
        com.Show()

        'this will open the home panel at the load
        'this is to close already opened forms inside menu panel

        While Me.appmainpanel.Controls.Count > 0
            Me.appmainpanel.Controls(0).Dispose()
        End While

        Dim dash As New Dashboard With {.TopMost = False, .AutoSize = False}
        dash.TopLevel = False
        dash.Dock = DockStyle.Fill
        Me.appmainpanel.Controls.Add(dash)
        dash.Show()


    End Sub

    Private Sub appmainclosebox_Click(sender As Object, e As EventArgs) Handles appmainclosebox.Click
        Me.Dispose()
        login.Dispose()

    End Sub

    Private Sub menupanel_Paint(sender As Object, e As PaintEventArgs) Handles menupanel.Paint

    End Sub
End Class