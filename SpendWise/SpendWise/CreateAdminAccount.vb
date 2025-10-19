Imports MySql.Data.MySqlClient
Imports BCrypt.Net

Public Class CreateAdminAccount

    Private Sub CreateAdminButton_Click(sender As Object, e As EventArgs) Handles CreateAdminButton.Click
        Dim username As String = "adminSpendWise"
        Dim password As String = "admin123#"
        
        ' Hash the password
        Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(password)
        
        Dim connectionString As String = "Server=localhost;Database=vbprojectdbfinal;Uid=root;Pwd=;"
        
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                
                ' Insert user
                Dim userQuery As String = "INSERT INTO users (username, password_hash) VALUES (@username, @password_hash) ON DUPLICATE KEY UPDATE password_hash = @password_hash"
                Using userCmd As New MySqlCommand(userQuery, conn)
                    userCmd.Parameters.AddWithValue("@username", username)
                    userCmd.Parameters.AddWithValue("@password_hash", hashedPassword)
                    userCmd.ExecuteNonQuery()
                End Using
                
                ' Get user ID
                Dim getUserIdQuery As String = "SELECT uid FROM users WHERE username = @username"
                Dim userId As Integer
                Using getUserIdCmd As New MySqlCommand(getUserIdQuery, conn)
                    getUserIdCmd.Parameters.AddWithValue("@username", username)
                    userId = Convert.ToInt32(getUserIdCmd.ExecuteScalar())
                End Using
                
                ' Insert admin record
                Dim adminQuery As String = "INSERT INTO admin (adminUsername, adminPassword, uid) VALUES (@adminUsername, @adminPassword, @uid) ON DUPLICATE KEY UPDATE adminPassword = @adminPassword"
                Using adminCmd As New MySqlCommand(adminQuery, conn)
                    adminCmd.Parameters.AddWithValue("@adminUsername", username)
                    adminCmd.Parameters.AddWithValue("@adminPassword", password)
                    adminCmd.Parameters.AddWithValue("@uid", userId)
                    adminCmd.ExecuteNonQuery()
                End Using
                
                MessageBox.Show("✅ Admin account created successfully!" & vbCrLf & 
                              "Username: adminSpendWise" & vbCrLf & 
                              "Password: admin123#", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                              
            End Using
        Catch ex As Exception
            MessageBox.Show("❌ Error creating admin account: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TestLoginButton_Click(sender As Object, e As EventArgs) Handles TestLoginButton.Click
        Dim username As String = "adminSpendWise"
        Dim password As String = "admin123#"
        
        Dim connectionString As String = "Server=localhost;Database=vbprojectdbfinal;Uid=root;Pwd=;"
        Dim query As String = "SELECT uid, password_hash FROM users WHERE username = @username"
        
        Try
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    conn.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    
                    If reader.Read() Then
                        Dim storedHash As String = reader("password_hash").ToString()
                        If BCrypt.Net.BCrypt.Verify(password, storedHash) Then
                            MessageBox.Show("✅ Admin login test successful!", "Test Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("❌ Password verification failed!", "Test Result", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("❌ Admin user not found!", "Test Result", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("❌ Error testing login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

