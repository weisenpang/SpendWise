<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        TotalIncomeLabel = New Label()
        TotalExpenseLabel = New Label()
        AddIncomeButton = New Button()
        IncomeHistoryButton = New Button()
        InsertBalanceButton = New Button()
        AddExpenseButton = New Button()
        ExpenseHistoryButton = New Button()
        SuspendLayout()
        ' 
        ' BalanceLabel
        ' 
        BalanceLabel.AutoSize = True
        BalanceLabel.Location = New Point(373, 65)
        BalanceLabel.Name = "BalanceLabel"
        BalanceLabel.Size = New Size(61, 20)
        BalanceLabel.TabIndex = 0
        BalanceLabel.Text = "Balance"
        BalanceLabel.UseMnemonic = False
        ' 
        ' TotalIncomeLabel
        ' 
        TotalIncomeLabel.AutoSize = True
        TotalIncomeLabel.Location = New Point(159, 179)
        TotalIncomeLabel.Name = "TotalIncomeLabel"
        TotalIncomeLabel.Size = New Size(98, 20)
        TotalIncomeLabel.TabIndex = 1
        TotalIncomeLabel.Text = "Total Income:"
        ' 
        ' TotalExpenseLabel
        ' 
        TotalExpenseLabel.AutoSize = True
        TotalExpenseLabel.Location = New Point(572, 179)
        TotalExpenseLabel.Name = "TotalExpenseLabel"
        TotalExpenseLabel.Size = New Size(103, 20)
        TotalExpenseLabel.TabIndex = 2
        TotalExpenseLabel.Text = "Total Expense:"
        ' 
        ' AddIncomeButton
        ' 
        AddIncomeButton.Location = New Point(143, 243)
        AddIncomeButton.Name = "AddIncomeButton"
        AddIncomeButton.Size = New Size(137, 29)
        AddIncomeButton.TabIndex = 3
        AddIncomeButton.Text = "Add Income"
        AddIncomeButton.UseVisualStyleBackColor = True
        ' 
        ' IncomeHistoryButton
        ' 
        IncomeHistoryButton.Location = New Point(143, 310)
        IncomeHistoryButton.Name = "IncomeHistoryButton"
        IncomeHistoryButton.Size = New Size(137, 29)
        IncomeHistoryButton.TabIndex = 4
        IncomeHistoryButton.Text = "Income History"
        IncomeHistoryButton.UseVisualStyleBackColor = True
        ' 
        ' InsertBalanceButton
        ' 
        InsertBalanceButton.Location = New Point(327, 124)
        InsertBalanceButton.Name = "InsertBalanceButton"
        InsertBalanceButton.Size = New Size(150, 29)
        InsertBalanceButton.TabIndex = 5
        InsertBalanceButton.Text = "Insert Balance"
        InsertBalanceButton.UseVisualStyleBackColor = True
        ' 
        ' AddExpenseButton
        ' 
        AddExpenseButton.Location = New Point(572, 243)
        AddExpenseButton.Name = "AddExpenseButton"
        AddExpenseButton.Size = New Size(111, 29)
        AddExpenseButton.TabIndex = 6
        AddExpenseButton.Text = "Add Expense"
        AddExpenseButton.UseVisualStyleBackColor = True
        ' 
        ' ExpenseHistoryButton
        ' 
        ExpenseHistoryButton.Location = New Point(581, 326)
        ExpenseHistoryButton.Name = "ExpenseHistoryButton"
        ExpenseHistoryButton.Size = New Size(94, 29)
        ExpenseHistoryButton.TabIndex = 7
        ExpenseHistoryButton.Text = "Expense History"
        ExpenseHistoryButton.UseVisualStyleBackColor = True
        ' 
        ' HomePage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ExpenseHistoryButton)
        Controls.Add(AddExpenseButton)
        Controls.Add(InsertBalanceButton)
        Controls.Add(IncomeHistoryButton)
        Controls.Add(AddIncomeButton)
        Controls.Add(TotalExpenseLabel)
        Controls.Add(TotalIncomeLabel)
        Controls.Add(BalanceLabel)
        Name = "HomePage"
        Text = "HomePage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BalanceLabel As Label
    Friend WithEvents TotalIncomeLabel As Label
    Friend WithEvents TotalExpenseLabel As Label
    Friend WithEvents AddIncomeButton As Button
    Friend WithEvents IncomeHistoryButton As Button
    Friend WithEvents InsertBalanceButton As Button
    Friend WithEvents AddExpenseButton As Button
    Friend WithEvents ExpenseHistoryButton As Button
End Class
