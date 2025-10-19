Imports MySql.Data.MySqlClient
Public Class ExpensePage
    Public Property UserID As Integer

    Private Sub AddExpenseButton_Click(sender As Object, e As EventArgs) Handles AddExpenseButton.Click
        ' Check if user has balance set first
        If Not HasBalanceSet() Then
            MessageBox.Show("Please set your initial balance first before adding expenses.", "Balance Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim balanceForm As New BalancePage()
            balanceForm.UserID = UserID
            balanceForm.Show()
            Me.Close()
            Return
        End If

        Dim amount As Decimal
        If Not Decimal.TryParse(AddExpenseTextBox.Text, amount) Then
            MessageBox.Show("Please enter a valid amount.")
            AddExpenseTextBox.Focus()
            Return
        End If
        
        ' Check if expense exceeds current balance
        Dim currentBalance As Decimal = GetCurrentBalance()
        If amount > currentBalance Then
            MessageBox.Show($"❌ Expense exceeds balance!" & vbCrLf & 
                          $"Current Balance: RM {currentBalance:F2}" & vbCrLf & 
                          $"Expense Amount: RM {amount:F2}" & vbCrLf & 
                          $"Shortfall: RM {amount - currentBalance:F2}", 
                          "Insufficient Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            AddExpenseTextBox.Focus()
            Return
        End If
        
        Dim description As String = AddExpenseDescriptionTextBox.Text.Trim()
        If String.IsNullOrEmpty(description) Then
            MessageBox.Show("Please enter a description.")
            AddExpenseDescriptionTextBox.Focus()
            Return
        End If
        
        Dim category As String = "Expense" ' Default category

        Dim connectionString As String = "Server=localhost;Database=vbprojectdbfinal;Uid=root;Pwd=;"
        Dim insertQuery As String = "INSERT INTO Transactions (uid, description, amount, category, transactionDate, type) VALUES (@uid, @desc, @amt, @cat, @date, 'Expense')"

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
                    Dim updateQuery As String = "UPDATE Balance SET currentBalance = currentBalance - @amt WHERE uid = @uid"
                    Using updateCmd As New MySqlCommand(updateQuery, conn)
                        updateCmd.Parameters.AddWithValue("@amt", amount)
                        updateCmd.Parameters.AddWithValue("@uid", UserID)
                        updateCmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show($"✅ Expense added successfully!" & vbCrLf & 
                                  $"Amount: RM {amount:F2}" & vbCrLf & 
                                  $"Description: {description}" & vbCrLf & 
                                  $"New Balance: RM {currentBalance - amount:F2}", 
                                  "Expense Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Function GetCurrentBalance() As Decimal
        Dim connectionString As String = "Server=localhost;Database=vbprojectdbfinal;Uid=root;Pwd=;"
        Dim query As String = "SELECT currentBalance FROM balance WHERE uid = @uid"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@uid", UserID)
                Try
                    conn.Open()
                    Dim result As Object = cmd.ExecuteScalar()
                    Return If(result IsNot Nothing AndAlso result IsNot DBNull.Value, Convert.ToDecimal(result), 0)
                Catch ex As Exception
                    Return 0
                End Try
            End Using
        End Using
    End Function
End Class