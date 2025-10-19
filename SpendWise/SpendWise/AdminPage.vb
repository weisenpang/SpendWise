Imports MySql.Data.MySqlClient
Public Class AdminPage
    Public Property UserID As Integer

    Private Sub AdminPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserList()
    End Sub

    Private Sub LoadUserList()
        Dim connectionString As String = "Server=localhost;Database=vbprojectdbfinal;Uid=root;Pwd=;"
        Dim query As String = "SELECT uid, username, created_at FROM users ORDER BY created_at DESC"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    UserHistoryList.Items.Clear()

                    While reader.Read()
                        Dim uid As Integer = Convert.ToInt32(reader("uid"))
                        Dim username As String = reader("username").ToString()
                        Dim createdDate As DateTime = Convert.ToDateTime(reader("created_at"))
                        
                        Dim item As String = $"ID: {uid} | Username: {username} | Created: {createdDate:yyyy-MM-dd HH:mm}"
                        UserHistoryList.Items.Add(item)
                    End While
                Catch ex As Exception
                    MessageBox.Show("Error loading user list: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub UserHistoryList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UserHistoryList.SelectedIndexChanged

    End Sub

    Private Sub HomepageButton_Click(sender As Object, e As EventArgs)
        Dim home As New HomePage
        home.UserID = UserID
        home.Show
        Close
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim launchForm As New LaunchPage()
            launchForm.Show()
            Me.Close()
        End If
    End Sub
End Class