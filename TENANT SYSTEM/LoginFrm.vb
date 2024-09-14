Imports BCrypt.Net
Imports MySql.Data.MySqlClient

Public Class LoginFrm
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialization code if needed
    End Sub

    Private Sub TxtUsername_GotFocus(sender As Object, e As EventArgs) Handles TxtUsername.GotFocus
        If TxtUsername.Text = "Username" Then
            TxtUsername.Text = ""
            TxtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtUsername_LostFocus(sender As Object, e As EventArgs) Handles TxtUsername.LostFocus
        If TxtUsername.Text = "" Then
            TxtUsername.Text = "Username"
            TxtUsername.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub TxtPassword_GotFocus(sender As Object, e As EventArgs) Handles TxtPassword.GotFocus
        If TxtPassword.Text = "Password" Then
            TxtPassword.Text = ""
            TxtPassword.PasswordChar = "*"c
            TxtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtPassword_LostFocus(sender As Object, e As EventArgs) Handles TxtPassword.LostFocus
        If TxtPassword.Text = "" Then
            TxtPassword.PasswordChar = ControlChars.NullChar
            TxtPassword.Text = "Password"
            TxtPassword.ForeColor = Color.DarkGray
        End If
    End Sub

    ' Method to verify password using BCrypt
    Private Function VerifyPassword(plainTextPassword As String, hashedPassword As String) As Boolean
        Return BCrypt.Net.BCrypt.Verify(plainTextPassword, hashedPassword)
    End Function

    ' Login button click event
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim username As String = TxtUsername.Text
        Dim password As String = TxtPassword.Text

        Try
            ' MySQL connection string (change your connection details here)
            Dim connString As String = "server=localhost;user id=root;password=;database=tenant_system"
            Dim query As String = "SELECT password FROM users WHERE username = @username"

            Using conn As New MySqlConnection(connString)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)

                    ' Get the hashed password from the database
                    Dim dbPassword As Object = cmd.ExecuteScalar()

                    If dbPassword IsNot Nothing Then
                        If VerifyPassword(password, dbPassword.ToString()) Then
                            ' Login successful
                            HomeFrm.Visible = True
                            Me.Hide() ' Hide the login form after successful login
                        Else
                            ' Login failed due to wrong password
                            MessageBox.Show("You have entered the wrong username or password",
                                            "Login Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error)
                        End If
                    Else
                        ' Username not found
                        MessageBox.Show("Username not found",
                                        "Login Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error during login: " & ex.Message)
        End Try
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?",
                                     "Exit Confirmation",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
