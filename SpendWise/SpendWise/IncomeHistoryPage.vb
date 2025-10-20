Imports MySql.Data.MySqlClient
Public Class IncomeHistoryPage
    Public Property UserID As Integer

    Private Sub IncomeHistoryPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check if user has balance set first
        If Not HasBalanceSet() Then
            MessageBox.Show("Please set your initial balance first before viewing history.", "Balance Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim balanceForm As New BalancePage()
            balanceForm.UserID = UserID
            balanceForm.Show()
            Me.Close()
            Return
        End If

        LoadIncomeHistory()
    End Sub

    Private Sub LoadIncomeHistory()
        Dim connectionString As String = "Server=localhost;Database=vbprojectdbfinal;Uid=root;Pwd=;"
        Dim query As String = "SELECT description, amount, category, transactionDate FROM Transactions WHERE uid = @uid AND type = 'Income' ORDER BY transactionDate DESC"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@uid", UserID)
                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    IncomeHistoryList.Items.Clear()

                    While reader.Read()
                        Dim description As String = reader("description").ToString()
                        Dim amount As Decimal = Convert.ToDecimal(reader("amount"))
                        Dim category As String = reader("category").ToString()
                        Dim transactionDate As DateTime = Convert.ToDateTime(reader("transactionDate"))

                        Dim item As String = $"{transactionDate:yyyy-MM-dd} | {category} | {description} | RM {amount:F2}"
                        IncomeHistoryList.Items.Add(item)
                    End While
                Catch ex As Exception
                    MessageBox.Show("Error loading income history: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub IncomeHistoryList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IncomeHistoryList.SelectedIndexChanged

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