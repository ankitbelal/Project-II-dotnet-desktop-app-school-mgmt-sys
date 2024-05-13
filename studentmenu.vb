Public Class studentmenu
    Private Sub studentmenuaddbtn_Click(sender As Object, e As EventArgs) Handles studentmenuaddbtn.Click
        'this is to close already opened forms

        While APPMAIN.appmainpanel.Controls.Count > 0
            APPMAIN.appmainpanel.Controls(0).Dispose()

        End While



        'this is to open form inside a pannel
        Dim std As New student With {.TopMost = False, .AutoSize = False}
        std.TopLevel = False
        std.Dock = DockStyle.Fill
        APPMAIN.appmainpanel.Controls.Add(std)
        std.Show()


    End Sub

    Private Sub studentmenuhidebtn_Click(sender As Object, e As EventArgs) Handles studentmenuhidebtn.Click
        'this is to close already opened forms inside menu panel

        While APPMAIN.menupanel.Controls.Count > 0
            APPMAIN.menupanel.Controls(0).Dispose()

        End While


        'this Is to open form inside a pannel

        Dim com As New commom_menu With {.TopMost = False, .AutoSize = False}
        com.commonhomebtn.FillColor = Color.Transparent
        com.TopLevel = False
        com.Dock = DockStyle.Fill
        APPMAIN.menupanel.Controls.Add(com)
        com.Show()



    End Sub



    Private Sub studentmenuteacherbtn_Click(sender As Object, e As EventArgs) Handles studentmenuteacherbtn.Click
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

    Private Sub studentmenulogoutbtn_Click(sender As Object, e As EventArgs) Handles studentmenulogoutbtn.Click
        APPMAIN.Dispose()
        login.Show()

    End Sub

    Private Sub studentmenuviewbtn_Click(sender As Object, e As EventArgs) Handles studentmenuviewbtn.Click
        'this is to close already opened forms inside menu panel

        While APPMAIN.appmainpanel.Controls.Count > 0
            APPMAIN.appmainpanel.Controls(0).Dispose()

        End While



        'this is to open form inside a pannel
        Dim view As New viewstudents With {.TopMost = False, .AutoSize = False}
        view.TopLevel = False
        view.Dock = DockStyle.Fill
        APPMAIN.appmainpanel.Controls.Add(view)
        view.Show()
    End Sub

    Private Sub commonfeebtn_Click(sender As Object, e As EventArgs) Handles commonfeebtn.Click

        While APPMAIN.appmainpanel.Controls.Count > 0
            APPMAIN.appmainpanel.Controls(0).Dispose()

        End While
        'this is to open form inside a pannel
        Dim fee As New feepayment With {.TopMost = False, .AutoSize = False}
        fee.TopLevel = False
        fee.Dock = DockStyle.Fill
        APPMAIN.appmainpanel.Controls.Add(fee)
        fee.Show()



        While APPMAIN.menupanel.Controls.Count > 0
            APPMAIN.menupanel.Controls(0).Dispose()

        End While


        'this Is to open form inside a pannel

        Dim com As New commom_menu With {.TopMost = False, .AutoSize = False}
        com.commonfeebtn.FillColor = Color.Tomato
        com.commonhomebtn.FillColor = Color.Transparent
        com.TopLevel = False
        com.Dock = DockStyle.Fill
        APPMAIN.menupanel.Controls.Add(com)
        com.Show()
    End Sub

    Private Sub commonpaymentbtn_Click(sender As Object, e As EventArgs) Handles commonpaymentbtn.Click
        While APPMAIN.appmainpanel.Controls.Count > 0
            APPMAIN.appmainpanel.Controls(0).Dispose()

        End While
        'this is to open form inside a pannel
        Dim fee As New fee_section With {.TopMost = False, .AutoSize = False}
        fee.TopLevel = False
        fee.Dock = DockStyle.Fill
        APPMAIN.appmainpanel.Controls.Add(fee)
        fee.Show()




        While APPMAIN.menupanel.Controls.Count > 0
            APPMAIN.menupanel.Controls(0).Dispose()

        End While


        'this Is to open form inside a pannel

        Dim com As New commom_menu With {.TopMost = False, .AutoSize = False}
        com.commonpaymentbtn.FillColor = Color.Tomato
        com.commonhomebtn.FillColor = Color.Transparent
        com.TopLevel = False
        com.Dock = DockStyle.Fill
        APPMAIN.menupanel.Controls.Add(com)
        com.Show()
    End Sub

    Private Sub Studentmenuhomebtn_Click(sender As Object, e As EventArgs) Handles Studentmenuhomebtn.Click
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


        While APPMAIN.menupanel.Controls.Count > 0
            APPMAIN.menupanel.Controls(0).Dispose()

        End While


        'this Is to open form inside a pannel

        Dim com As New commom_menu With {.TopMost = False, .AutoSize = False}
        com.commonhomebtn.FillColor = Color.Tomato
        com.TopLevel = False
        com.Dock = DockStyle.Fill
        APPMAIN.menupanel.Controls.Add(com)
        com.Show()
    End Sub

    Private Sub Studentmenusubjectbtn_Click(sender As Object, e As EventArgs) Handles Studentmenusubjectbtn.Click
        'this is to close already opened forms inside menu panel

        While APPMAIN.appmainpanel.Controls.Count > 0
            APPMAIN.appmainpanel.Controls(0).Dispose()

        End While



        'this is to open form inside a pannel
        Dim subject As New Subject With {.TopMost = False, .AutoSize = False}
        subject.TopLevel = False
        subject.Dock = DockStyle.Fill
        APPMAIN.appmainpanel.Controls.Add(subject)
        subject.Show()



        'this is to close already opened forms inside menu panel

        While APPMAIN.menupanel.Controls.Count > 0
            APPMAIN.menupanel.Controls(0).Dispose()

        End While


        'this Is to open form inside a pannel

        Dim com As New commom_menu With {.TopMost = False, .AutoSize = False}
        com.commonhomebtn.FillColor = Color.Transparent
        com.commonsubjectbtn.FillColor = Color.Tomato

        com.TopLevel = False
        com.Dock = DockStyle.Fill
        APPMAIN.menupanel.Controls.Add(com)
        com.Show()
    End Sub
End Class