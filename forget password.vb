Imports System.Net
Imports System.Net.Mail
Imports System.Data.SqlClient
Imports Microsoft.EntityFrameworkCore.ChangeTracking.Internal
Imports System.Text.RegularExpressions

Public Class forget_password
    Dim verrificationcode As String = "asdfgh"


    Dim username As String = "ankitswarswati@gmail.com"
    Dim password As String = "oiby ysxt nwhu wmpg"
    Dim emailhold As String


    Private Sub forget_password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        changepasswordpanel.Hide()


    End Sub

    Private Sub verifyotpbtn_Click(sender As Object, e As EventArgs) Handles verifyotpbtn.Click
        Dim code As String = verrificationcode

        If otpbox1.Text = "" Or otpbox2.Text = "" Or otpbox3.Text = "" Or otpbox4.Text = "" Or otpbox5.Text = "" Or otpbox6.Text = "" Then
            MessageBox.Show("Please Enter the OTP to change the password", "OTP required !", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            If code = otpbox1.Text + otpbox2.Text + otpbox3.Text + otpbox4.Text + otpbox5.Text + otpbox6.Text Then
                verrificationcode = "asdfgh"

                otpbox1.ResetText()
                otpbox2.ResetText()
                otpbox3.ResetText()
                otpbox4.ResetText()
                otpbox5.ResetText()
                otpbox6.ResetText()

                changepasswordpanel.Show()

            Else

                MessageBox.Show("Please Enter the Valid Code", "OTP Doesn't Match!", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If


        End If




    End Sub

    Private Sub backtologinbtn_Click(sender As Object, e As EventArgs) Handles backtologinbtn.Click


        While login.panelspace.Controls.Count > 0
            login.panelspace.Controls(0).Dispose()
        End While



        'this is to open form inside a pannel
        Dim log As New login_real With {.TopMost = False, .AutoSize = False}
        log.TopLevel = False
        log.Dock = DockStyle.Fill
        login.panelspace.Controls.Add(log)
        log.Show()
    End Sub

    Private Sub cancelpasschangebtn_Click(sender As Object, e As EventArgs) Handles cancelpasschangebtn.Click
        forgetpassmainpanel.Show()
        changepasswordpanel.Hide()
    End Sub

    Private Sub emailbox_Enter(sender As Object, e As EventArgs) Handles emailbox.Enter
        If emailbox.Text = "Email_Address" Then
            emailbox.ForeColor = Color.Black
            emailbox.Text = ""
        End If
    End Sub

    Private Sub emailbox_Leave(sender As Object, e As EventArgs) Handles emailbox.Leave
        If emailbox.Text = "" Then
            emailbox.ForeColor = Color.DarkGray
            emailbox.Text = "Email_Address"
        End If
    End Sub



    Private Sub getcodebtn_Click(sender As Object, e As EventArgs) Handles getcodebtn.Click
        If emailbox.Text = "" Or emailbox.Text = "Email_Address" Then
            MessageBox.Show("Please Enter the Email Address", "Email required !", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else


            Try

                con.Open()
                cmd = New SqlCommand("spemailverify", con)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@email", emailbox.Text)

                    .Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output

                    .ExecuteScalar()

                    If CInt(.Parameters("@result").Value = 1) Then
                        emailhold = emailbox.Text

                        Dim rand As New Random()
                        verrificationcode = rand.Next(1000000).ToString("D6")
                        Try


                            Dim fromaddress As New MailAddress("noreply@saraswatisoftware.com", "Saraswati Software")
                            Dim toaddress As New MailAddress(emailbox.Text)
                            Dim subject As String = "Verify your email address to change the password"
                            Dim body As String = String.Format("Please use the following code to verify your email: {0}     
                                for more contact at aankitbelal@gmail.com", verrificationcode)

                            Dim smtp As New SmtpClient()
                            smtp.Host = "smtp.gmail.com"
                            smtp.Port = 587
                            smtp.EnableSsl = True
                            smtp.Credentials = New NetworkCredential(username, password)
                            Dim message As New MailMessage(fromaddress, toaddress)
                            message.Subject = subject
                            message.Body = body
                            smtp.Send(message)
                            MsgBox("OTP sent successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                            otpbox1.Focus()

                        Catch ex As Exception

                            MessageBox.Show("faild to send the verrification email", "Unable to send mail!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End Try


                    Else
                        MsgBox("please enter the registered email", vbCritical, MsgBoxStyle.OkOnly)
                        emailbox.ForeColor = Color.DarkGray
                        emailbox.Text = "Email_Address"
                    End If

                End With
                con.Close()

            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message, vbCritical)
            End Try
        End If




    End Sub


    Private Sub otpbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles otpbox1.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            otpbox1.Text = e.KeyChar.ToString()
            e.Handled = True
            otpbox2.Focus()
        ElseIf e.KeyChar = ChrW(Keys.Back) Then
            ' Handle backspace to go to the previous textbox
            otpbox1.Text = ""
            otpbox1.Focus()
        End If
    End Sub




    Private Sub otpbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles otpbox2.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            otpbox2.Text = e.KeyChar.ToString()
            e.Handled = True
            otpbox3.Focus()
        ElseIf e.KeyChar = ChrW(Keys.Back) Then
            ' Handle backspace to go to the previous textbox
            otpbox2.Text = ""
            otpbox1.Focus()
        End If
    End Sub


    Private Sub otpbox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles otpbox3.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            otpbox3.Text = e.KeyChar.ToString()
            e.Handled = True
            otpbox4.Focus()
        ElseIf e.KeyChar = ChrW(Keys.Back) Then
            ' Handle backspace to go to the previous textbox
            otpbox3.Text = ""
            otpbox2.Focus()
        End If
    End Sub


    Private Sub otpbox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles otpbox4.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            otpbox4.Text = e.KeyChar.ToString()
            e.Handled = True
            otpbox5.Focus()
        ElseIf e.KeyChar = ChrW(Keys.Back) Then
            ' Handle backspace to go to the previous textbox
            otpbox4.Text = ""
            otpbox3.Focus()
        End If
    End Sub


    Private Sub otpbox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles otpbox5.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            otpbox5.Text = e.KeyChar.ToString()
            e.Handled = True
            otpbox6.Focus()
        ElseIf e.KeyChar = ChrW(Keys.Back) Then
            ' Handle backspace to go to the previous textbox
            otpbox5.Text = ""
            otpbox4.Focus()
        End If
    End Sub


    Private Sub otpbox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles otpbox6.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            otpbox6.Text = e.KeyChar.ToString()
            e.Handled = True
            otpbox6.Focus()
        ElseIf e.KeyChar = ChrW(Keys.Back) Then
            ' Handle backspace to go to the previous textbox
            otpbox6.Text = ""
            otpbox5.Focus()
        End If
    End Sub



    Private Sub confirmpassbtn_Click(sender As Object, e As EventArgs) Handles confirmpassbtn.Click

        Dim validationErrors As List(Of String) = ValidatePasswordAndEmail(changepassbox.Text, confirmnewpasschange.Text)

        If validationErrors.Count = 0 Then


            Try

                con.Open()
                cmd = New SqlCommand("spforgetpass", con)
                With cmd
                    .CommandType = CommandType.StoredProcedure

                    .Parameters.AddWithValue("@newpassword", confirmnewpasschange.Text)
                    .Parameters.AddWithValue("@email", emailbox.Text)

                    .ExecuteNonQuery()

                End With
                con.Close()
                MessageBox.Show("Password changed succesfully", "Save Successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information)


                While login.panelspace.Controls.Count > 0
                    login.panelspace.Controls(0).Dispose()
                End While



                'this is to open form inside a pannel
                Dim log As New login_real With {.TopMost = False, .AutoSize = False}
                log.TopLevel = False
                log.Dock = DockStyle.Fill
                login.panelspace.Controls.Add(log)
                log.Show()

            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message, vbCritical)
            End Try

        Else
            Dim errorMessage As String = "Fix the following issues before changing the password:" & vbCrLf & String.Join(vbCrLf, validationErrors)
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If



    End Sub




    Private Function ValidatePasswordAndEmail(newPassword As String, confirmPassword As String) As List(Of String)
        ' Define the regular expressions for lowercase, uppercase, digit, and special character

        Dim uppercaseRegex As New Regex("[A-Z]")

        Dim specialCharacterRegex As New Regex("[!@#$%^&*(),.?"":{}|<>0123456789]")

        ' Define the regular expression for a valid email address
        Dim emailRegex As New Regex("^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$")

        ' Collect validation errors
        Dim validationErrors As New List(Of String)

        ' Check for empty fields


        If String.IsNullOrEmpty(newPassword) Then
            validationErrors.Add("- New password is required.")
        End If

        If String.IsNullOrEmpty(confirmPassword) Then
            validationErrors.Add("- Confirm password is required.")
        End If


        ' Check if the new password meets the criteria

        If Not uppercaseRegex.IsMatch(newPassword) Then
            validationErrors.Add("- At least 1 uppercase letter is required.")
        End If

        If Not specialCharacterRegex.IsMatch(newPassword) Then

            validationErrors.Add("- At least number or special character is required.")
        End If


        ' Add your additional criteria, e.g., minimum length
        If newPassword.Length < 8 Then
            validationErrors.Add("- Minimum length of 8 characters is required.")
        End If

        ' Check if the new password and confirm password match
        If newPassword <> confirmPassword Then
            validationErrors.Add("- New password and confirm password do not match.")
        End If

        Return validationErrors
    End Function

End Class