Imports MySql.Data.MySqlClient
Public Class IncomePage
    Public Property UserID As Integer

    Private Sub AddIncomeButton_Click(sender As Object, e As EventArgs) Handles AddIncomeButton.Click
        ' Check if user has balance set first
        If Not HasBalanceSet() Then
            MessageBox.Show("Please set your initial balance first before adding income.", "Balance Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim balanceForm As New BalancePage()
            balanceForm.UserID = UserID
            balanceForm.Show()
            Me.Close()
            Return
        End If

        Dim amount As Decimal
        If Not Decimal.TryParse(AddIncomeTextBox.Text, amount) Then
            MessageBox.Show("Please enter a valid amount.")
            AddIncomeTextBox.Focus()
            Return
        End If

        Dim description As String = AddIncomeDescriptionTextBox.Text.Trim()
        If String.IsNullOrEmpty(description) Then
            MessageBox.Show("Please enter a description.")
            AddIncomeDescriptionTextBox.Focus()
            Return
        End If

        Dim category As String = "Income" ' Default category

        Dim connectionString As String = "Server=localhost;Database=vbprojectdbfinal;Uid=root;Pwd=;"
        Dim insertQuery As String = "INSERT INTO Transactions (uid, description, amount, category, transactionDate, type) VALUES (@uid, @desc, @amt, @cat, @date, 'Income')"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("@uid", UserID)
                cmd.Parameters.AddWithValue("@desc", description)
                cmd.Parameters.AddWithValue("@amt", amount)
                cmd.Parameters.AddWithValue("@cat", category)
                cmd.Parameters.AddWithValue("@date", DateTime.Now.Date)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()

                    ' Update Balance
                    Dim updateQuery As String = "UPDATE Balance SET currentBalance = currentBalance + @amt WHERE uid = @uid"
                    Using updateCmd As New MySqlCommand(updateQuery, conn)
                        updateCmd.Parameters.AddWithValue("@amt", amount)
                        updateCmd.Parameters.AddWithValue("@uid", UserID)
                        updateCmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("✅ Income added!")
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

    Private Sub HomepageButton_Click(sender As Object, e As EventArgs) Handles HomepageButton.Click
        Dim home As New HomePage()
        home.UserID = UserID
        home.Show()
        Me.Close()
    End Sub

    Private Function HasBalanceSet() As Boolean
        Dim connectionString As String = "Server=localhost;Database=vbprojectdbfinal;Uid=root;Pwd=;"
        Dim query As String = "SELECT COUNT(*) FROM balance WHERE uid = @uid"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@uid", UserID)
                Try
                    conn.Open()
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                Catch ex As Exception
                    Return False
                End Try
            End Using
        End Using
    End Function

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub
End Class