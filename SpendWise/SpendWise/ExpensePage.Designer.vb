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
        Label1 = New Label()
        AddExpenseDescriptionTextBox = New TextBox()
        SuspendLayout()
        ' 
        ' HomepageButton
        ' 
        HomepageButton.Location = New Point(398, 276)
        HomepageButton.Name = "HomepageButton"
        HomepageButton.Size = New Size(181, 29)
        HomepageButton.TabIndex = 9
        HomepageButton.Text = "Back To Homepage"
        HomepageButton.UseVisualStyleBackColor = True
        ' 
        ' AddExpenseButton
        ' 
        AddExpenseButton.Location = New Point(230, 276)
        AddExpenseButton.Name = "AddExpenseButton"
        AddExpenseButton.Size = New Size(111, 29)
        AddExpenseButton.TabIndex = 8
        AddExpenseButton.Text = "Add Expense"
        AddExpenseButton.UseVisualStyleBackColor = True
        ' 
        ' AddExpenseTextBox
        ' 
        AddExpenseTextBox.Location = New Point(426, 158)
        AddExpenseTextBox.Name = "AddExpenseTextBox"
        AddExpenseTextBox.Size = New Size(125, 27)
        AddExpenseTextBox.TabIndex = 7
        ' 
        ' AddExpenseLabel
        ' 
        AddExpenseLabel.AutoSize = True
        AddExpenseLabel.Location = New Point(218, 165)
        AddExpenseLabel.Name = "AddExpenseLabel"
        AddExpenseLabel.Size = New Size(193, 20)
        AddExpenseLabel.TabIndex = 6
        AddExpenseLabel.Text = "Please Insert Your Expense : " & vbCrLf
        ' 
        ' ExpenseLabel
        ' 
        ExpenseLabel.AutoSize = True
        ExpenseLabel.Location = New Point(326, 110)
        ExpenseLabel.Name = "ExpenseLabel"
        ExpenseLabel.Size = New Size(126, 20)
        ExpenseLabel.TabIndex = 5
        ExpenseLabel.Text = "Insert expense list"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(218, 210)
        Label1.Name = "Label1"
        Label1.Size = New Size(182, 20)
        Label1.TabIndex = 10
        Label1.Text = "Please entera description :"
        ' 
        ' AddExpenseDescriptionTextBox
        ' 
        AddExpenseDescriptionTextBox.Location = New Point(426, 207)
        AddExpenseDescriptionTextBox.Name = "AddExpenseDescriptionTextBox"
        AddExpenseDescriptionTextBox.Size = New Size(125, 27)
        AddExpenseDescriptionTextBox.TabIndex = 11
        ' 
        ' ExpensePage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(AddExpenseDescriptionTextBox)
        Controls.Add(Label1)
        Controls.Add(HomepageButton)
        Controls.Add(AddExpenseButton)
        Controls.Add(AddExpenseTextBox)
        Controls.Add(AddExpenseLabel)
        Controls.Add(ExpenseLabel)
        Name = "ExpensePage"
        Text = "Insert your expenses here !"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents HomepageButton As Button
    Friend WithEvents AddExpenseButton As Button
    Friend WithEvents AddExpenseTextBox As TextBox
    Friend WithEvents AddExpenseLabel As Label
    Friend WithEvents ExpenseLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AddExpenseDescriptionTextBox As TextBox
End Class
