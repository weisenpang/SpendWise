Imports MySql.Data.MySqlClient
Imports BCrypt.Net
Public Class SignUpPage

    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click
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

        Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(password)
        Dim connectionString As String = "Server=localhost;Database=vbprojectdbfinal;Uid=root;Pwd=;"

        Dim query As String = "INSERT INTO Users (username, password_hash) VALUES (@user, @pass)"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user", username)
                cmd.Parameters.AddWithValue("@pass", hashedPassword)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("✅ Account created successfully!")

                    Dim loginForm As New LogInPage()
                    loginForm.Show()
                    Me.Close()
                Catch ex As Exception
                    If ex.Message.Contains("Duplicate entry") Then
                        MessageBox.Show("❌ Username already exists.")
                    Else
                        MessageBox.Show("❌ Error: " & ex.Message)
                    End If
                End Try
            End Using
        End Using
    End Sub

    Private Sub LogInPageLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LogInPageLabel.LinkClicked
        Dim loginForm As New LogInPage()
        loginForm.Show()
        Me.Hide()
    End Sub

End Class