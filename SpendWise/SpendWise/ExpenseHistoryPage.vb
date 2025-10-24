Imports MySql.Data.MySqlClient
Public Class ExpenseHistoryPage
    Public Property UserID As Integer
    Private transactionIds As New List(Of Integer)

    Private Sub ExpenseHistoryPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check if user has balance set first
        If Not HasBalanceSet() Then
            MessageBox.Show("Please set your initial balance first before viewing history.", "Balance Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim balanceForm As New BalancePage()
            balanceForm.UserID = UserID
            balanceForm.Show()
            Me.Close()
            Return
        End If

        LoadExpenseHistory()
    End Sub

    Private Sub LoadExpenseHistory()
        Dim connectionString As String = "Server=localhost;Database=vbprojectdbfinal;Uid=root;Pwd=;"
        Dim query As String = "SELECT transactionID, description, amount, category, transactionDate FROM Transactions WHERE uid = @uid AND type = 'Expense' ORDER BY transactionDate DESC"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@uid", UserID)
                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    ExpenseHistoryList.Items.Clear()
                    transactionIds.Clear()

                    While reader.Read()
                        Dim transactionId As Integer = Convert.ToInt32(reader("transactionID"))
                        Dim description As String = reader("description").ToString()
                        Dim amount As Decimal = Convert.ToDecimal(reader("amount"))
                        Dim category As String = reader("category").ToString()
                        Dim transactionDate As DateTime = Convert.ToDateTime(reader("transactionDate"))

                        Dim item As String = $"{transactionDate:yyyy-MM-dd} | {category} | {description} | RM {amount:F2}"
                        ExpenseHistoryList.Items.Add(item)
                        transactionIds.Add(transactionId)
                    End While
                Catch ex As Exception
                    MessageBox.Show("Error loading expense history: " & ex.Message)
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

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If ExpenseHistoryList.SelectedIndex = -1 Then
            MessageBox.Show("Please select an expense to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedIndex As Integer = ExpenseHistoryList.SelectedIndex
        Dim transactionId As Integer = transactionIds(selectedIndex)

        Dim editDialog As New EditTransactionDialog()
        editDialog.TransactionId = transactionId
        editDialog.UserId = UserID
        editDialog.ShowDialog()

        If editDialog.IsUpdated Then
            LoadExpenseHistory() ' Refresh the list
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If ExpenseHistoryList.SelectedIndex = -1 Then
            MessageBox.Show("Please select an expense to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this expense? This action cannot be undone.", 
                                                   "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        
        If result = DialogResult.Yes Then
            Dim selectedIndex As Integer = ExpenseHistoryList.SelectedIndex
            Dim transactionId As Integer = transactionIds(selectedIndex)

            If DatabaseHelper.DeleteTransaction(transactionId) Then
                MessageBox.Show("Expense deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadExpenseHistory() ' Refresh the list
            Else
                MessageBox.Show("Failed to delete expense.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class