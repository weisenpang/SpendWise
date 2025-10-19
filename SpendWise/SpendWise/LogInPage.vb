Imports MySql.Data.MySqlClient
Imports BCrypt.Net
Public Class LogInPage
    Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click
        Dim username As String = UserNameTextBox.Text.Trim()
        Dim password As String = PasswordTextBox.Text.Trim()

        If String.IsNullOrEmpty(username) Then
            MessageBox.Show("Please enter a username.")
            UserNameTextBox.Focus()
            Return
        End If

        If String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter a password.")
            PasswordTextBox.Focus()
            Return
        End If

        Dim connectionString As String = "Server=localhost;Database=vbprojectdbfinal;Uid=root;Pwd=;"
        
        ' First check if it's an admin login
        Dim adminQuery As String = "SELECT adminUsername, adminPassword FROM admin WHERE adminUsername = @user"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(adminQuery, conn)
                cmd.Parameters.AddWithValue("@user", username)

                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        ' This is an admin login
                        Dim storedPassword As String = reader("adminPassword").ToString()
                        If password = storedPassword Then
                            MessageBox.Show("✅ Admin login successful!")
                            Dim adminForm As New AdminPage()
                            adminForm.UserID = 0 ' Admin doesn't have a user ID
                            adminForm.Show()
                            Me.Close()
                            Return
                        Else
                            MessageBox.Show("❌ Invalid admin password.")
                            Return
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show("❌ Error: " & ex.Message)
                    Return
                End Try
            End Using
        End Using

        ' If not admin, check regular users
        Dim userQuery As String = "SELECT uid, password_hash FROM users WHERE username = @user"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(userQuery, conn)
                cmd.Parameters.AddWithValue("@user", username)

                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        Dim storedHash As String = reader("password_hash").ToString()
                        If BCrypt.Net.BCrypt.Verify(password, storedHash) Then
                            MessageBox.Show("✅ Login successful!")
                            Dim home As New HomePage()
                            home.UserID = reader("uid")
                            home.Show()
                            Me.Close()
                        Else
                            MessageBox.Show("❌ Invalid password.")
                        End If
                    Else
                        MessageBox.Show("❌ Username not found.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("❌ Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim signUpForm As New SignUpPage()
        signUpForm.Show()
        Me.Hide()
    End Sub

End Class