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
        EditButton = New Button()
        DeleteButton = New Button()
        MenuStrip1 = New MenuStrip()
        AboutUsToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ExpenseHistoryLabel
        ' 
        ExpenseHistoryLabel.AutoSize = True
        ExpenseHistoryLabel.Location = New Point(33, 28)
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
        ' EditButton
        ' 
        EditButton.Location = New Point(33, 400)
        EditButton.Name = "EditButton"
        EditButton.Size = New Size(100, 29)
        EditButton.TabIndex = 3
        EditButton.Text = "Edit Selected"
        EditButton.UseVisualStyleBackColor = True
        ' 
        ' DeleteButton
        ' 
        DeleteButton.Location = New Point(150, 400)
        DeleteButton.Name = "DeleteButton"
        DeleteButton.Size = New Size(100, 29)
        DeleteButton.TabIndex = 4
        DeleteButton.Text = "Delete Selected"
        DeleteButton.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AboutUsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 13
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AboutUsToolStripMenuItem
        ' 
        AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        AboutUsToolStripMenuItem.Size = New Size(84, 24)
        AboutUsToolStripMenuItem.Text = "About Us"
        ' 
        ' ExpenseHistoryPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        Controls.Add(DeleteButton)
        Controls.Add(EditButton)
        Controls.Add(HomepageButton)
        Controls.Add(ExpenseHistoryList)
        Controls.Add(ExpenseHistoryLabel)
        Name = "ExpenseHistoryPage"
        Text = "View your expenses here !"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ExpenseHistoryLabel As Label
    Friend WithEvents ExpenseHistoryList As ListBox
    Friend WithEvents HomepageButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
End Class
