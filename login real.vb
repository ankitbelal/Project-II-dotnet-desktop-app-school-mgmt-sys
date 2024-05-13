Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions
Imports Microsoft.IdentityModel.Protocols.OpenIdConnect



Public Class login_real
    'while the login panel loads

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection()
        defaultpasspanel.Visible = False
        If defaultpasspanel.Visible = False Then
            Me.AcceptButton = loginbtn

        Else
            Me.AcceptButton = confirmchangepassbtn
        End If
        useremailbox.ForeColor = Color.Black
        useremailbox.PlaceholderForeColor = Color.DarkGray

    End Sub

    'is for the login button function
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click

        If usernamebox.Text = "username" Or passwordbox.Text = "password" Then
            MessageBox.Show("Please update All fields", "All fields required !", MessageBoxButtons.OK, MessageBoxIcon.Error)
            usernamebox.Focus()




        Else
            Try

                con.Open()
                cmd = New SqlCommand("splogin", con)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@username", usernamebox.Text)
                    .Parameters.AddWithValue("@password", passwordbox.Text)
                    .Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output
                    .Parameters.AddWithValue("@IsDefault", SqlDbType.Int).Direction = ParameterDirection.Output
                    .ExecuteScalar()

                    If CInt(.Parameters("@IsDefault").Value = 1) Then

                        If CInt(.Parameters("@result").Value = 1) Then

                            defaultpasspanel.Visible = True
                            username = usernamebox.Text
                            defaultpasspanel.Show()
                            usernamebox.ForeColor = Color.DarkGray
                            usernamebox.Text = "username"
                            passwordbox.ForeColor = Color.DarkGray
                            passwordbox.PasswordChar = ""
                            passwordbox.Text = "password"

                        Else

                            MessageBox.Show("Invalid username or password", "Check your credentials!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            usernamebox.ForeColor = Color.DarkGray
                            usernamebox.Text = "username"
                            passwordbox.ForeColor = Color.DarkGray
                            passwordbox.PasswordChar = ""
                            passwordbox.Text = "password"
                        End If

                    Else
                        If CInt(.Parameters("@result").Value = 1) Then

                            login.Hide()
                            getrole(usernamebox.Text, passwordbox.Text)


                            APPMAIN.Show()

                            usernamebox.ForeColor = Color.DarkGray
                            usernamebox.Text = "username"
                            passwordbox.ForeColor = Color.DarkGray
                            passwordbox.PasswordChar = ""
                            passwordbox.Text = "password"


                        Else
                            MessageBox.Show("Invalid username or password", "Check your credentials!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            usernamebox.ForeColor = Color.DarkGray
                            usernamebox.Text = "username"
                            passwordbox.ForeColor = Color.DarkGray
                            passwordbox.PasswordChar = ""
                            passwordbox.Text = "password"
                        End If
                    End If

                End With
                con.Close()


            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message, vbCritical)
            End Try



        End If





    End Sub

    Private Function getrole(ByVal username As String, ByVal password As String)
        con.Close()
        Try
            con.Open()
            cmd = New SqlCommand("spgetuserrole", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            reader = cmd.ExecuteReader()
            If reader.Read() Then
                userrrole = reader.GetString(0)
            End If


            con.Close()

        Catch ex As Exception

            con.Close()
            MsgBox(ex.Message)
        End Try
    End Function
    'for designing the username textbox behave like real
    Private Sub usernamebox_Enter(sender As Object, e As EventArgs) Handles usernamebox.Enter
        If usernamebox.Text = "username" Then
            usernamebox.ForeColor = Color.Black
            usernamebox.Text = ""
        End If

    End Sub

    Private Sub usernamebox_Leave(sender As Object, e As EventArgs) Handles usernamebox.Leave
        If usernamebox.Text = "" Then
            usernamebox.ForeColor = Color.DarkGray
            usernamebox.Text = "username"
        End If

    End Sub

    'to design the password textbox behave like real
    Private Sub passwordbox_Leave(sender As Object, e As EventArgs) Handles passwordbox.Leave
        If passwordbox.Text = "" Then
            passwordbox.ForeColor = Color.DarkGray
            passwordbox.Text = "password"
            passwordbox.PasswordChar = ""
        End If
    End Sub

    Private Sub passwordbox_Enter(sender As Object, e As EventArgs) Handles passwordbox.Enter
        If passwordbox.Text = "password" Then
            passwordbox.ForeColor = Color.Black
            passwordbox.Text = ""
            passwordbox.PasswordChar = "*"
            hidepassbtn.Hide()
            showpassbtn.Show()

        End If
    End Sub

    'for hiding and showing password with eye icon

    Private Sub showpassbtn_Click(sender As Object, e As EventArgs) Handles showpassbtn.Click

        passwordbox.PasswordChar = ""
        showpassbtn.Hide()
        hidepassbtn.Show()

    End Sub
    Private Sub hidepassbtn_Click(sender As Object, e As EventArgs) Handles hidepassbtn.Click
        passwordbox.PasswordChar = "*"
        hidepassbtn.Hide()
        showpassbtn.Show()
    End Sub

    'when the username box load 
    Private Sub usernamebox_Load(sender As Object, e As EventArgs) Handles usernamebox.Load
        usernamebox.ForeColor = Color.DarkGray
        usernamebox.Text = "username"
    End Sub

    'when the password box load
    Private Sub passwordbox_Load(sender As Object, e As EventArgs) Handles passwordbox.Load
        passwordbox.ForeColor = Color.DarkGray
        passwordbox.Text = "password"
    End Sub

    'for the pannel of default password change

    'make the username box in default password change panel behave like real
    Private Sub changeusernamebox_Leave(sender As Object, e As EventArgs) Handles changeusernamebox.Leave
        If changeusernamebox.Text = "" Then
            changeusernamebox.ForeColor = Color.DarkGray
            changeusernamebox.Text = "New_username"

        End If

    End Sub

    Private Sub changeusernamebox_Enter(sender As Object, e As EventArgs) Handles changeusernamebox.Enter
        If changeusernamebox.Text = "New_username" Then
            changeusernamebox.ForeColor = Color.Black
            changeusernamebox.Text = ""
        End If
    End Sub

    'what to show when usernamebox load
    Private Sub changeusernamebox_Load(sender As Object, e As EventArgs) Handles changeusernamebox.Load
        changeusernamebox.ForeColor = Color.DarkGray
        changeusernamebox.Text = "New_username"
    End Sub


    'for what to show when password box loads
    Private Sub changepasswordbox_Load(sender As Object, e As EventArgs) Handles changepasswordbox.Load
        changepasswordbox.ForeColor = Color.DarkGray
        changepasswordbox.Text = "New_password"

    End Sub

    'makes password box behave like real
    Private Sub changepasswordbox_Enter(sender As Object, e As EventArgs) Handles changepasswordbox.Enter
        If changepasswordbox.Text = "New_password" Then
            changepasswordbox.ForeColor = Color.Black
            changepasswordbox.Text = ""
        End If
    End Sub

    Private Sub changepasswordbox_Leave(sender As Object, e As EventArgs) Handles changepasswordbox.Leave
        If changepasswordbox.Text = "" Then
            changepasswordbox.ForeColor = Color.DarkGray
            changepasswordbox.Text = "New_password"
        End If
    End Sub


    'same for repeat password box
    Private Sub changepassbox2_Load(sender As Object, e As EventArgs) Handles changepasswordbox2.Load
        changepasswordbox2.ForeColor = Color.DarkGray
        changepasswordbox2.Text = "Repeat_password"

    End Sub

    Private Sub changepasswordbox2_Enter(sender As Object, e As EventArgs) Handles changepasswordbox2.Enter
        If changepasswordbox.Text = "Repeat_password" Then

            changepasswordbox2.Text = ""
            changepasswordbox2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub changepasswordbox2_Leave(sender As Object, e As EventArgs) Handles changepasswordbox2.Leave
        If changepasswordbox2.Text = "" Then
            changepasswordbox2.ForeColor = Color.DarkGray
            changepasswordbox2.Text = "Repeat_password"
        End If
    End Sub

    'to make the text in password box autohide
    Private Sub changepassbox2_GotFocus(sender As Object, e As EventArgs) Handles changepasswordbox2.GotFocus
        changepasswordbox2.ForeColor = Color.Black
        changepasswordbox2.Text = ""
    End Sub

    Private Sub forgetpassword_Click(sender As Object, e As EventArgs) Handles forgetpassword.Click


        While login.panelspace.Controls.Count > 0
            login.panelspace.Controls(0).Dispose()
        End While



        'this is to open form inside a pannel
        Dim forg As New forget_password With {.TopMost = False, .AutoSize = False}
        forg.TopLevel = False
        forg.Dock = DockStyle.Fill
        login.panelspace.Controls.Add(forg)
        forg.Show()

    End Sub

    Private Sub useremailbox_Enter(sender As Object, e As EventArgs) Handles useremailbox.Enter
        useremailbox.PlaceholderText = ""

    End Sub

    Private Sub useremailbox_Leave(sender As Object, e As EventArgs) Handles useremailbox.Leave
        useremailbox.PlaceholderText = "email_address"
    End Sub

    Private Sub confirmchangepassbtn_Click(sender As Object, e As EventArgs) Handles confirmchangepassbtn.Click






        Dim newPassword As String = changepasswordbox.Text
        Dim confirmPassword As String = changepasswordbox2.Text
        Dim email As String = useremailbox.Text

        Dim validationErrors As List(Of String) = ValidatePasswordAndEmail(newPassword, confirmPassword, email)

        If validationErrors.Count = 0 Then
            Try

                con.Open()
                cmd = New SqlCommand("spdefaultpass", con)
                With cmd

                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@oldusername", username)
                    .Parameters.AddWithValue("@username", changeusernamebox.Text)
                    .Parameters.AddWithValue("@newpassword", changepasswordbox.Text)
                    .Parameters.AddWithValue("@email", useremailbox.Text)


                    .ExecuteNonQuery()

                End With
                con.Close()

                MessageBox.Show("Default username and Password changes succesfully", "Save Successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                defaultpasspanel.Hide()


            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message, vbCritical)
            End Try
        Else
            Dim errorMessage As String = "Fix the following issues before changing the password:" & vbCrLf & String.Join(vbCrLf, validationErrors)
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If
    End Sub





    Private Function ValidatePasswordAndEmail(newPassword As String, confirmPassword As String, email As String) As List(Of String)
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

        If String.IsNullOrEmpty(email) Then
            validationErrors.Add("- Email is required.")
        ElseIf Not emailRegex.IsMatch(email) Then
            validationErrors.Add("- Invalid email format.")
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

