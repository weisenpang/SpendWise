Imports MySql.Data.MySqlClient
Public Class BalancePage
    Public Property UserID As Integer

    Private Sub AddBalanceButton_Click(sender As Object, e As EventArgs) Handles AddBalanceButton.Click
        Dim initialBalance As Decimal
        If Not Decimal.TryParse(AddBalanceTextBox.Text, initialBalance) Then
            MessageBox.Show("Please enter a valid balance amount.")
            AddBalanceTextBox.Focus()
            Return
        End If

        Dim connectionString As String = "Server=localhost;Database=vbprojectdbfinal;Uid=root;Pwd=;"
        Dim query As String = "INSERT INTO Balance (uid, currentBalance) VALUES (@uid, @balance) ON DUPLICATE KEY UPDATE currentBalance = @balance"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@uid", UserID)
                cmd.Parameters.AddWithValue("@balance", initialBalance)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("✅ Balance saved!")
                    Dim home As New HomePage()
                    home.UserID = UserID
                    home.Show()
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("❌ Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub HomePageButton_Click(sender As Object, e As EventArgs) Handles HomePageButton.Click
        Dim home As New HomePage()
        home.UserID = UserID
        home.Show()
        Me.Close()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub
End Class