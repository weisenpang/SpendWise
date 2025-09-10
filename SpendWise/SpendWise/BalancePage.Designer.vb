<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BalancePage
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
        BalanceLabel = New Label()
        AddBalanceLabel = New Label()
        AddBalanceTextBox = New TextBox()
        AddBalanceButton = New Button()
        HomePageButton = New Button()
        SuspendLayout()
        ' 
        ' BalanceLabel
        ' 
        BalanceLabel.AutoSize = True
        BalanceLabel.Location = New Point(369, 127)
        BalanceLabel.Name = "BalanceLabel"
        BalanceLabel.Size = New Size(61, 20)
        BalanceLabel.TabIndex = 0
        BalanceLabel.Text = "Balance"
        ' 
        ' AddBalanceLabel
        ' 
        AddBalanceLabel.AutoSize = True
        AddBalanceLabel.Location = New Point(198, 203)
        AddBalanceLabel.Name = "AddBalanceLabel"
        AddBalanceLabel.Size = New Size(183, 20)
        AddBalanceLabel.TabIndex = 1
        AddBalanceLabel.Text = "Please Insert Your Balance:"
        ' 
        ' AddBalanceTextBox
        ' 
        AddBalanceTextBox.Location = New Point(450, 200)
        AddBalanceTextBox.Name = "AddBalanceTextBox"
        AddBalanceTextBox.Size = New Size(125, 27)
        AddBalanceTextBox.TabIndex = 2
        ' 
        ' AddBalanceButton
        ' 
        AddBalanceButton.Location = New Point(210, 293)
        AddBalanceButton.Name = "AddBalanceButton"
        AddBalanceButton.Size = New Size(156, 29)
        AddBalanceButton.TabIndex = 3
        AddBalanceButton.Text = "Add Balance"
        AddBalanceButton.UseVisualStyleBackColor = True
        ' 
        ' HomePageButton
        ' 
        HomePageButton.Location = New Point(422, 293)
        HomePageButton.Name = "HomePageButton"
        HomePageButton.Size = New Size(183, 29)
        HomePageButton.TabIndex = 4
        HomePageButton.Text = "Back To Homepage"
        HomePageButton.UseVisualStyleBackColor = True
        ' 
        ' BalancePage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(HomePageButton)
        Controls.Add(AddBalanceButton)
        Controls.Add(AddBalanceTextBox)
        Controls.Add(AddBalanceLabel)
        Controls.Add(BalanceLabel)
        Name = "BalancePage"
        Text = "BalancePage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BalanceLabel As Label
    Friend WithEvents AddBalanceLabel As Label
    Friend WithEvents AddBalanceTextBox As TextBox
    Friend WithEvents AddBalanceButton As Button
    Friend WithEvents HomePageButton As Button
End Class
