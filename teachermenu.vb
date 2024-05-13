Public Class teachermenu
    Private Sub teachermenuform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub teachermenuteachebtn_Click(sender As Object, e As EventArgs) Handles teachermenuhidebtn.Click
        'this is to close already opened forms inside menu panel
        teachermenuhidebtn.FillColor = Color.Tomato

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

    Private Sub teachermenuaddbtn_Click(sender As Object, e As EventArgs) Handles teachermenuaddbtn.Click
        'this is to close already opened forms

        While APPMAIN.appmainpanel.Controls.Count > 0
            APPMAIN.appmainpanel.Controls(0).Dispose()

        End While



        'this is to open form inside a pannel
        Dim teacher As New Teacher With {.TopMost = False, .AutoSize = False}
        teacher.TopLevel = False
        teacher.Dock = DockStyle.Fill
        APPMAIN.appmainpanel.Controls.Add(teacher)
        teacher.Show()
    End Sub

    Private Sub teachermenustudentbtn_Click(sender As Object, e As EventArgs) Handles teachermenustudentbtn.Click
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

    Private Sub teachermenulogoutbtn_Click(sender As Object, e As EventArgs) Handles teachermenulogoutbtn.Click
        APPMAIN.Dispose()
        login.Show()

    End Sub



    Private Sub teachermenuviewbtn_Click(sender As Object, e As EventArgs) Handles teachermenuviewbtn.Click
        'this is to close already opened forms inside menu panel

        While APPMAIN.appmainpanel.Controls.Count > 0
            APPMAIN.appmainpanel.Controls(0).Dispose()

        End While



        'this is to open form inside a pannel
        Dim view As New view_teachers With {.TopMost = False, .AutoSize = False}
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




        'this Is to open form inside a pannel
        While APPMAIN.menupanel.Controls.Count > 0
            APPMAIN.menupanel.Controls(0).Dispose()
        End While
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



        'this Is to open form inside a pannel
        While APPMAIN.menupanel.Controls.Count > 0
            APPMAIN.menupanel.Controls(0).Dispose()
        End While
        Dim com As New commom_menu With {.TopMost = False, .AutoSize = False}
        com.commonpaymentbtn.FillColor = Color.Tomato
        com.commonhomebtn.FillColor = Color.Transparent
        com.TopLevel = False
        com.Dock = DockStyle.Fill
        APPMAIN.menupanel.Controls.Add(com)
        com.Show()


    End Sub

    Private Sub teachermenuhomebtn_Click(sender As Object, e As EventArgs) Handles teachermenuhomebtn.Click
        'this Is to open form inside a pannel
        While APPMAIN.menupanel.Controls.Count > 0
            APPMAIN.menupanel.Controls(0).Dispose()
        End While
        Dim com As New commom_menu With {.TopMost = False, .AutoSize = False}
        com.commonhomebtn.FillColor = Color.Tomato

        com.TopLevel = False
        com.Dock = DockStyle.Fill
        APPMAIN.menupanel.Controls.Add(com)
        com.Show()


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

    Private Sub teachermenusubjectbtn_Click(sender As Object, e As EventArgs) Handles teachermenusubjectbtn.Click

        While APPMAIN.appmainpanel.Controls.Count > 0
            APPMAIN.appmainpanel.Controls(0).Dispose()

        End While



        'this is to open form inside a pannel
        Dim subject As New Subject With {.TopMost = False, .AutoSize = False}
        subject.TopLevel = False
        subject.Dock = DockStyle.Fill
        APPMAIN.appmainpanel.Controls.Add(subject)
        subject.Show()





        'this Is to open form inside a pannel
        While APPMAIN.menupanel.Controls.Count > 0
            APPMAIN.menupanel.Controls(0).Dispose()
        End While
        Dim com As New commom_menu With {.TopMost = False, .AutoSize = False}
        com.commonhomebtn.FillColor = Color.Transparent
        com.commonsubjectbtn.FillColor = Color.Tomato

        com.TopLevel = False
        com.Dock = DockStyle.Fill
        APPMAIN.menupanel.Controls.Add(com)
        com.Show()
    End Sub
End Class