<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        UserHistoryList = New ListBox()
        UserHistoryLabel = New Label()
        LogoutButton = New Button()
        SuspendLayout()
        ' 
        ' UserHistoryList
        ' 
        UserHistoryList.FormattingEnabled = True
        UserHistoryList.Location = New Point(31, 57)
        UserHistoryList.Name = "UserHistoryList"
        UserHistoryList.Size = New Size(739, 324)
        UserHistoryList.TabIndex = 7
        ' 
        ' UserHistoryLabel
        ' 
        UserHistoryLabel.AutoSize = True
        UserHistoryLabel.Location = New Point(31, 21)
        UserHistoryLabel.Name = "UserHistoryLabel"
        UserHistoryLabel.Size = New Size(38, 20)
        UserHistoryLabel.TabIndex = 6
        UserHistoryLabel.Text = "User"
        ' 
        ' LogoutButton
        ' 
        LogoutButton.Location = New Point(12, 12)
        LogoutButton.Name = "LogoutButton"
        LogoutButton.Size = New Size(75, 29)
        LogoutButton.TabIndex = 7
        LogoutButton.Text = "Logout"
        LogoutButton.UseVisualStyleBackColor = True
        ' 
        ' AdminPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LogoutButton)
        Controls.Add(UserHistoryList)
        Controls.Add(UserHistoryLabel)
        Name = "AdminPage"
        Text = "Admin Page"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents UserHistoryList As ListBox
    Friend WithEvents UserHistoryLabel As Label
    Friend WithEvents LogoutButton As Button
End Class
