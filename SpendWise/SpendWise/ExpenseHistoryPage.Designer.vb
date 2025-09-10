<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpenseHistoryPage
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
        ExpenseHistoryLabel = New Label()
        ExpenseHistoryList = New ListBox()
        HomepageButton = New Button()
        SuspendLayout()
        ' 
        ' ExpenseHistoryLabel
        ' 
        ExpenseHistoryLabel.AutoSize = True
        ExpenseHistoryLabel.Location = New Point(33, 21)
        ExpenseHistoryLabel.Name = "ExpenseHistoryLabel"
        ExpenseHistoryLabel.Size = New Size(114, 20)
        ExpenseHistoryLabel.TabIndex = 0
        ExpenseHistoryLabel.Text = "Expense History"
        ' 
        ' ExpenseHistoryList
        ' 
        ExpenseHistoryList.FormattingEnabled = True
        ExpenseHistoryList.Location = New Point(33, 57)
        ExpenseHistoryList.Name = "ExpenseHistoryList"
        ExpenseHistoryList.Size = New Size(739, 324)
        ExpenseHistoryList.TabIndex = 1
        ' 
        ' HomepageButton
        ' 
        HomepageButton.Location = New Point(619, 400)
        HomepageButton.Name = "HomepageButton"
        HomepageButton.Size = New Size(153, 29)
        HomepageButton.TabIndex = 2
        HomepageButton.Text = "Back To Homepage"
        HomepageButton.UseVisualStyleBackColor = True
        ' 
        ' ExpenseHistoryPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(HomepageButton)
        Controls.Add(ExpenseHistoryList)
        Controls.Add(ExpenseHistoryLabel)
        Name = "ExpenseHistoryPage"
        Text = "ExpenseHistoryPage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ExpenseHistoryLabel As Label
    Friend WithEvents ExpenseHistoryList As ListBox
    Friend WithEvents HomepageButton As Button
End Class
