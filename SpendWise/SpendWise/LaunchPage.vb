Public Class LaunchPage

    Private Sub StartProgramButton_Click(sender As Object, e As EventArgs) Handles StartProgramButton.Click
        ' Test database connection before proceeding
        If DatabaseHelper.TestConnection() Then
            LogInPage.Show()
            ' Optional: Hide or Close the current form (start screen)
            Me.Hide()   ' Hides current form but keeps it in memory
        Else
            MessageBox.Show("Cannot connect to database. Please ensure XAMPP MySQL is running and the database is set up correctly.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class
