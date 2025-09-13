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
        HomepageButton = New Button()
        UserHistoryList = New ListBox()
        UserHistoryLabel = New Label()
        SuspendLayout()
        ' 
        ' HomepageButton
        ' 
        HomepageButton.Location = New Point(617, 400)
        HomepageButton.Name = "HomepageButton"
        HomepageButton.Size = New Size(153, 29)
        HomepageButton.TabIndex = 8
        HomepageButton.Text = "Back To Homepage"
        HomepageButton.UseVisualStyleBackColor = True
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
        ' AdminPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(HomepageButton)
        Controls.Add(UserHistoryList)
        Controls.Add(UserHistoryLabel)
        Name = "AdminPage"
        Text = "AdminPage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents HomepageButton As Button
    Friend WithEvents UserHistoryList As ListBox
    Friend WithEvents UserHistoryLabel As Label
End Class
