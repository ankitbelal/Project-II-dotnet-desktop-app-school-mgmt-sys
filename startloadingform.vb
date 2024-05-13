Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class startloadingform
    Private Const TotalTime As Integer = 3000 ' Total time in milliseconds (3 seconds)
    Private Const TimerInterval As Integer = 750 ' Adjust this value to control the speed

    Private Sub startloadingform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        progressbar.Minimum = 0
        progressbar.Maximum = TotalTime / TimerInterval
        Timer.Interval = TimerInterval
        Timer.Start()



    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick



        Static elapsed As Integer = 0

        If elapsed < TotalTime Then
            progressbar.Value += 1
            elapsed += TimerInterval
            loadlabel.Text = "loading... " + (elapsed / 30).ToString + "%"

        Else
            progressbar.Value = progressbar.Maximum
            Timer.Stop()
            While login.panelspace.Controls.Count > 0
                login.panelspace.Controls(0).Dispose()
            End While



            ' this Is to open form inside a pannel
            Dim log As New login_real With {.TopMost = False, .AutoSize = False}
            log.TopLevel = False
            log.Dock = DockStyle.Fill
            login.panelspace.Controls.Add(log)
            log.Show()
        End If


    End Sub


End Class