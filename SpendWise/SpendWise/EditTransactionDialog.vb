Imports MySql.Data.MySqlClient

Public Class EditTransactionDialog
    Public Property TransactionId As Integer
    Public Property TransactionType As String
    Public Property UserId As Integer
    Public Property IsUpdated As Boolean = False

    Private Sub EditTransactionDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTransactionData()
    End Sub

    Private Sub LoadTransactionData()
        Dim transactionData As Dictionary(Of String, Object) = DatabaseHelper.GetTransactionById(TransactionId)
        
        If transactionData.Count > 0 Then
            DescriptionTextBox.Text = transactionData("description").ToString()
            AmountTextBox.Text = transactionData("amount").ToString()
            CategoryTextBox.Text = transactionData("category").ToString()
            TransactionDatePicker.Value = Convert.ToDateTime(transactionData("transactionDate"))
            TransactionType = transactionData("type").ToString()
            
            ' Update form title based on transaction type
            Me.Text = $"Edit {TransactionType}"
        Else
            MessageBox.Show("Transaction not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        ' Validate input
        Dim amount As Decimal
        If Not Decimal.TryParse(AmountTextBox.Text, amount) Then
            MessageBox.Show("Please enter a valid amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            AmountTextBox.Focus()
            Return
        End If

        Dim description As String = DescriptionTextBox.Text.Trim()
        If String.IsNullOrEmpty(description) Then
            MessageBox.Show("Please enter a description.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DescriptionTextBox.Focus()
            Return
        End If

        Dim category As String = CategoryTextBox.Text.Trim()
        If String.IsNullOrEmpty(category) Then
            MessageBox.Show("Please enter a category.", "Missing Category", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CategoryTextBox.Focus()
            Return
        End If

        ' Update transaction
        If DatabaseHelper.UpdateTransaction(TransactionId, description, amount, category, TransactionDatePicker.Value.Date) Then
            MessageBox.Show("Transaction updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            IsUpdated = True
            Me.Close()
        Else
            MessageBox.Show("Failed to update transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub
End Class
