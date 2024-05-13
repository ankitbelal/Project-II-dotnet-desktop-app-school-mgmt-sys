Public Class commom_menu
    Private Sub commonstudentbtn_Click(sender As Object, e As EventArgs) Handles commonstudentbtn.Click

        'this is to close already opened forms inside menu panel

        While APPMAIN.menupanel.Controls.Count > 0
            APPMAIN.menupanel.Controls(0).Dispose()

        End While



        'this is to open form inside a pannel
        Dim std As New studentmenu With {.TopMost = False, .AutoSize = False}
        std.TopLevel = False
        std.Dock = DockStyle.Fill
        APPMAIN.menupanel.Controls.Add(std)
        std.Show()



    End Sub

    Private Sub commonteacherbtn_Click(sender As Object, e As EventArgs) Handles commonteacherbtn.Click
        'this is to close already opened forms inside menu panel

        While APPMAIN.menupanel.Controls.Count > 0
            APPMAIN.menupanel.Controls(0).Dispose()

        End While



        'this is to open form inside a pannel
        Dim teacher As New teachermenu With {.TopMost = False, .AutoSize = False}
        teacher.TopLevel = False
        teacher.Dock = DockStyle.Fill
        APPMAIN.menupanel.Controls.Add(teacher)
        teacher.Show()


    End Sub

    Private Sub commonsubjectbtn_Click(sender As Object, e As EventArgs) Handles commonsubjectbtn.Click
        commonfeebtn.FillColor = Color.Transparent
        commonpaymentbtn.FillColor = Color.Transparent
        commonhomebtn.FillColor = Color.Transparent 'this is to close already opened forms inside menu panel

        commonsubjectbtn.FillColor = Color.Tomato
        While APPMAIN.appmainpanel.Controls.Count > 0
            APPMAIN.appmainpanel.Controls(0).Dispose()

        End While



        'this is to open form inside a pannel
        Dim subject As New Subject With {.TopMost = False, .AutoSize = False}
        subject.TopLevel = False
        subject.Dock = DockStyle.Fill
        APPMAIN.appmainpanel.Controls.Add(subject)
        subject.Show()
    End Sub

    Private Sub comlogoutbtn_Click(sender As Object, e As EventArgs) Handles comlogoutbtn.Click
        APPMAIN.Dispose()
        login.Show()


    End Sub

    Private Sub commonhomebtn_Click(sender As Object, e As EventArgs) Handles commonhomebtn.Click
        commonhomebtn.FillColor = Color.Tomato
        commonsubjectbtn.FillColor = Color.Transparent
        commonfeebtn.FillColor = Color.Transparent
        commonpaymentbtn.FillColor = Color.Transparent
        'this is to close already opened forms inside menu panel

        While APPMAIN.appmainpanel.Controls.Count > 0
            APPMAIN.appmainpanel.Controls(0).Dispose()

        End While



        'this is to open form inside a pannel
        Dim dash As New Dashboard With {.TopMost = False, .AutoSize = False}
        dash.TopLevel = False
        dash.Dock = DockStyle.Fill
        APPMAIN.appmainpanel.Controls.Add(dash)
        dash.Show()
    End Sub

    Private Sub manageuser_Click(sender As Object, e As EventArgs) Handles manageuser.Click
        commonhomebtn.FillColor = Color.Transparent

        While APPMAIN.appmainpanel.Controls.Count > 0
            APPMAIN.appmainpanel.Controls(0).Dispose()

        End While



        'this is to open form inside a pannel
        Dim mg As New manage_user With {.TopMost = False, .AutoSize = False}
        mg.TopLevel = False
        mg.Dock = DockStyle.Fill
        APPMAIN.appmainpanel.Controls.Add(mg)
        mg.Show()
    End Sub

    Private Sub commonpaymentbtn_Click(sender As Object, e As EventArgs) Handles commonpaymentbtn.Click
        commonhomebtn.FillColor = Color.Transparent
        commonfeebtn.FillColor = Color.Transparent
        commonsubjectbtn.FillColor = Color.Transparent
        commonpaymentbtn.FillColor = Color.Tomato
        While APPMAIN.appmainpanel.Controls.Count > 0
            APPMAIN.appmainpanel.Controls(0).Dispose()

        End While
        'this is to open form inside a pannel
        Dim fee As New fee_section With {.TopMost = False, .AutoSize = False}
        fee.TopLevel = False
        fee.Dock = DockStyle.Fill
        APPMAIN.appmainpanel.Controls.Add(fee)
        fee.Show()

    End Sub

    Private Sub commom_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If userrrole = "admin" Then
            manageuser.Show()

        Else
            manageuser.Hide()

        End If
    End Sub

    Private Sub commonfeebtn_Click(sender As Object, e As EventArgs) Handles commonfeebtn.Click
        commonsubjectbtn.FillColor = Color.Transparent
        commonpaymentbtn.FillColor = Color.Transparent
        commonhomebtn.FillColor = Color.Transparent
        commonfeebtn.FillColor = Color.Tomato
        While APPMAIN.appmainpanel.Controls.Count > 0
            APPMAIN.appmainpanel.Controls(0).Dispose()

        End While
        'this is to open form inside a pannel
        Dim fee As New feepayment With {.TopMost = False, .AutoSize = False}
        fee.TopLevel = False
        fee.Dock = DockStyle.Fill
        APPMAIN.appmainpanel.Controls.Add(fee)
        fee.Show()


        'this is to close already opened forms inside menu panel


    End Sub


End Class