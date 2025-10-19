Imports MySql.Data.MySqlClient
Public Class HomePage
    Public Property UserID As Integer

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check if user has balance set first
        If Not HasBalanceSet() Then
            MessageBox.Show("Please set your initial balance first before using the application.", "Balance Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim balanceForm As New BalancePage()
            balanceForm.UserID = UserID
            balanceForm.Show()
            Me.Close()
            Return
        End If

        LoadBalance()
        LoadTotalIncome()
        LoadTotalExpense()
    End Sub

    Private Sub HomePage_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Refresh data when returning to this page
        LoadBalance()
        LoadTotalIncome()
        LoadTotalExpense()
    End Sub

    Private Sub LoadBalance()
        Dim connectionString As String = "Server=localhost;Database=vbprojectdbfinal;Uid=root;Pwd=;"
        Dim query As String = "SELECT currentBalance FROM Balance WHERE uid = @uid"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@uid", UserID)
                Try
                    conn.Open()
                    Dim result As Object = cmd.ExecuteScalar()
                    BalanceLabel.Text = If(result IsNot Nothing AndAlso result IsNot DBNull.Value, "RM " & Convert.ToDecimal(result).ToString("F2"), "RM 0.00")
                Catch ex As Exception
                    MessageBox.Show("Error loading balance: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub LoadTotalIncome()
        Dim connectionString As String = "Server=localhost;Database=vbprojectdbfinal;Uid=root;Pwd=;"
        Dim query As String = "SELECT COALESCE(SUM(amount), 0) AS total_income FROM Transactions WHERE uid = @uid AND type = 'Income'"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@uid", UserID)
                Try
                    conn.Open()
                    Dim result As Object = cmd.ExecuteScalar()
                    TotalIncomeLabel.Text = "RM " & Convert.ToDecimal(result).ToString("F2")
                Catch ex As Exception
                    MessageBox.Show("Error loading income: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub LoadTotalExpense()
        Dim connectionString As String = "Server=localhost;Database=vbprojectdbfinal;Uid=root;Pwd=;"
        Dim query As String = "SELECT COALESCE(SUM(amount), 0) AS total_expense FROM Transactions WHERE uid = @uid AND type = 'Expense'"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@uid", UserID)
                Try
                    conn.Open()
                    Dim result As Object = cmd.ExecuteScalar()
                    TotalExpenseLabel.Text = "RM " & Convert.ToDecimal(result).ToString("F2")
                Catch ex As Exception
                    MessageBox.Show("Error loading expense: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub AddIncomeButton_Click(sender As Object, e As EventArgs) Handles AddIncomeButton.Click
        Dim incomeForm As New IncomePage()
        incomeForm.UserID = UserID
        incomeForm.Show()
        Me.Hide()
    End Sub

    Private Sub AddExpenseButtone_Click(sender As Object, e As EventArgs) Handles AddExpenseButton.Click
        Dim expenseForm As New ExpensePage()
        expenseForm.UserID = UserID
        expenseForm.Show()
        Me.Hide()
    End Sub

    Private Sub IncomeHistoryButton_Click(sender As Object, e As EventArgs) Handles IncomeHistoryButton.Click
        Dim historyForm As New IncomeHistoryPage()
        historyForm.UserID = UserID
        historyForm.Show()
        Me.Hide()
    End Sub

    Private Sub ExpenseHistoryButtony_Click(sender As Object, e As EventArgs) Handles ExpenseHistoryButton.Click
        Dim historyForm As New ExpenseHistoryPage()
        historyForm.UserID = UserID
        historyForm.Show()
        Me.Hide()
    End Sub

    Private Sub InsertBalanceButton_Click(sender As Object, e As EventArgs) Handles InsertBalanceButton.Click
        Dim balanceForm As New BalancePage()
        balanceForm.UserID = UserID
        balanceForm.Show()
        Me.Hide()
    End Sub

    Private Sub logOutButton_Click(sender As Object, e As EventArgs) Handles logOutButton.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim launchForm As New LaunchPage()
            launchForm.Show()
            Me.Close()
        End If
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

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class