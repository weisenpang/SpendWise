<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncomeHistoryPage
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
        IncomeHistoryList = New ListBox()
        IncomeHistoryLabel = New Label()
        MenuStrip1 = New MenuStrip()
        AboutUsToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' HomepageButton
        ' 
        HomepageButton.Location = New Point(617, 400)
        HomepageButton.Name = "HomepageButton"
        HomepageButton.Size = New Size(153, 29)
        HomepageButton.TabIndex = 5
        HomepageButton.Text = "Back To Homepage"
        HomepageButton.UseVisualStyleBackColor = True
        ' 
        ' IncomeHistoryList
        ' 
        IncomeHistoryList.FormattingEnabled = True
        IncomeHistoryList.Location = New Point(31, 57)
        IncomeHistoryList.Name = "IncomeHistoryList"
        IncomeHistoryList.Size = New Size(739, 324)
        IncomeHistoryList.TabIndex = 4
        ' 
        ' IncomeHistoryLabel
        ' 
        IncomeHistoryLabel.AutoSize = True
        IncomeHistoryLabel.Location = New Point(31, 34)
        IncomeHistoryLabel.Name = "IncomeHistoryLabel"
        IncomeHistoryLabel.Size = New Size(109, 20)
        IncomeHistoryLabel.TabIndex = 3
        IncomeHistoryLabel.Text = "Income History"
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
        ' IncomeHistoryPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        Controls.Add(HomepageButton)
        Controls.Add(IncomeHistoryList)
        Controls.Add(IncomeHistoryLabel)
        Name = "IncomeHistoryPage"
        Text = "View your income !"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents HomepageButton As Button
    Friend WithEvents IncomeHistoryList As ListBox
    Friend WithEvents IncomeHistoryLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
End Class
