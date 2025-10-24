Imports MySql.Data.MySqlClient

Public Class DatabaseHelper
    Public Shared ReadOnly ConnectionString As String = "Server=localhost;Database=vbprojectdbfinal;Uid=root;Pwd=;"
    
    Public Shared Function TestConnection() As Boolean
        Try
            Using conn As New MySqlConnection(ConnectionString)
                conn.Open()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Database connection failed: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    
    Public Shared Function ExecuteNonQuery(query As String, ParamArray parameters() As MySqlParameter) As Integer
        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters)
                End If
                conn.Open()
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function
    
    Public Shared Function ExecuteScalar(query As String, ParamArray parameters() As MySqlParameter) As Object
        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters)
                End If
                conn.Open()
                Return cmd.ExecuteScalar()
            End Using
        End Using
    End Function
    
    Public Shared Function ExecuteReader(query As String, ParamArray parameters() As MySqlParameter) As MySqlDataReader
        Dim conn As New MySqlConnection(ConnectionString)
        Dim cmd As New MySqlCommand(query, conn)
        If parameters IsNot Nothing Then
            cmd.Parameters.AddRange(parameters)
        End If
        conn.Open()
        Return cmd.ExecuteReader()
    End Function
    
    ' Method to update a transaction
    Public Shared Function UpdateTransaction(transactionId As Integer, description As String, amount As Decimal, category As String, transactionDate As Date) As Boolean
        Try
            Dim query As String = "UPDATE transactions SET description = @description, amount = @amount, category = @category, transactionDate = @transactionDate WHERE transactionID = @transactionId"
            Dim parameters() As MySqlParameter = {
                New MySqlParameter("@description", description),
                New MySqlParameter("@amount", amount),
                New MySqlParameter("@category", category),
                New MySqlParameter("@transactionDate", transactionDate),
                New MySqlParameter("@transactionId", transactionId)
            }
            
            Dim rowsAffected As Integer = ExecuteNonQuery(query, parameters)
            Return rowsAffected > 0
        Catch ex As Exception
            MessageBox.Show("Error updating transaction: " & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    
    ' Method to delete a transaction
    Public Shared Function DeleteTransaction(transactionId As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM transactions WHERE transactionID = @transactionId"
            Dim parameters() As MySqlParameter = {
                New MySqlParameter("@transactionId", transactionId)
            }
            
            Dim rowsAffected As Integer = ExecuteNonQuery(query, parameters)
            Return rowsAffected > 0
        Catch ex As Exception
            MessageBox.Show("Error deleting transaction: " & ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    
    ' Method to get transaction details by ID
    Public Shared Function GetTransactionById(transactionId As Integer) As Dictionary(Of String, Object)
        Dim result As New Dictionary(Of String, Object)
        Try
            Dim query As String = "SELECT transactionID, description, amount, category, transactionDate, type FROM transactions WHERE transactionID = @transactionId"
            Dim parameters() As MySqlParameter = {
                New MySqlParameter("@transactionId", transactionId)
            }
            
            Using reader As MySqlDataReader = ExecuteReader(query, parameters)
                If reader.Read() Then
                    result("transactionID") = reader("transactionID")
                    result("description") = reader("description")
                    result("amount") = reader("amount")
                    result("category") = reader("category")
                    result("transactionDate") = reader("transactionDate")
                    result("type") = reader("type")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving transaction: " & ex.Message, "Retrieve Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return result
    End Function
End Class

