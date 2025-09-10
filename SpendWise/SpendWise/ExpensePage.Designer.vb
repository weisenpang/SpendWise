<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpensePage
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
        AddExpenseButton = New Button()
        AddExpenseTextBox = New TextBox()
        AddExpenseLabel = New Label()
        ExpenseLabel = New Label()
        SuspendLayout()
        ' 
        ' HomepageButton
        ' 
        HomepageButton.Location = New Point(417, 305)
        HomepageButton.Name = "HomepageButton"
        HomepageButton.Size = New Size(181, 29)
        HomepageButton.TabIndex = 9
        HomepageButton.Text = "Back To Homepage"
        HomepageButton.UseVisualStyleBackColor = True
        ' 
        ' AddExpenseButton
        ' 
        AddExpenseButton.Location = New Point(225, 305)
        AddExpenseButton.Name = "AddExpenseButton"
        AddExpenseButton.Size = New Size(111, 29)
        AddExpenseButton.TabIndex = 8
        AddExpenseButton.Text = "Add Expense"
        AddExpenseButton.UseVisualStyleBackColor = True
        ' 
        ' AddExpenseTextBox
        ' 
        AddExpenseTextBox.Location = New Point(449, 223)
        AddExpenseTextBox.Name = "AddExpenseTextBox"
        AddExpenseTextBox.Size = New Size(125, 27)
        AddExpenseTextBox.TabIndex = 7
        ' 
        ' AddExpenseLabel
        ' 
        AddExpenseLabel.AutoSize = True
        AddExpenseLabel.Location = New Point(203, 223)
        AddExpenseLabel.Name = "AddExpenseLabel"
        AddExpenseLabel.Size = New Size(182, 40)
        AddExpenseLabel.TabIndex = 6
        AddExpenseLabel.Text = "Please Insert Your Expense" & vbCrLf & ":"
        ' 
        ' ExpenseLabel
        ' 
        ExpenseLabel.AutoSize = True
        ExpenseLabel.Location = New Point(380, 116)
        ExpenseLabel.Name = "ExpenseLabel"
        ExpenseLabel.Size = New Size(66, 20)
        ExpenseLabel.TabIndex = 5
        ExpenseLabel.Text = "Expense:"
        ' 
        ' ExpensePage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(HomepageButton)
        Controls.Add(AddExpenseButton)
        Controls.Add(AddExpenseTextBox)
        Controls.Add(AddExpenseLabel)
        Controls.Add(ExpenseLabel)
        Name = "ExpensePage"
        Text = "ExpensePage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents HomepageButton As Button
    Friend WithEvents AddExpenseButton As Button
    Friend WithEvents AddExpenseTextBox As TextBox
    Friend WithEvents AddExpenseLabel As Label
    Friend WithEvents ExpenseLabel As Label
End Class
