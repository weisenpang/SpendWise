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
End Class

