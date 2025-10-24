<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditTransactionDialog
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
        DescriptionLabel = New Label()
        DescriptionTextBox = New TextBox()
        AmountLabel = New Label()
        AmountTextBox = New TextBox()
        CategoryLabel = New Label()
        CategoryTextBox = New TextBox()
        DateLabel = New Label()
        TransactionDatePicker = New DateTimePicker()
        SaveButton = New Button()
        CancelBtn = New Button()
        SuspendLayout()
        ' 
        ' DescriptionLabel
        ' 
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New Point(12, 15)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New Size(85, 20)
        DescriptionLabel.TabIndex = 0
        DescriptionLabel.Text = "Description:"
        ' 
        ' DescriptionTextBox
        ' 
        DescriptionTextBox.Location = New Point(103, 12)
        DescriptionTextBox.Name = "DescriptionTextBox"
        DescriptionTextBox.Size = New Size(300, 27)
        DescriptionTextBox.TabIndex = 1
        ' 
        ' AmountLabel
        ' 
        AmountLabel.AutoSize = True
        AmountLabel.Location = New Point(12, 48)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New Size(66, 20)
        AmountLabel.TabIndex = 2
        AmountLabel.Text = "Amount:"
        ' 
        ' AmountTextBox
        ' 
        AmountTextBox.Location = New Point(103, 45)
        AmountTextBox.Name = "AmountTextBox"
        AmountTextBox.Size = New Size(300, 27)
        AmountTextBox.TabIndex = 3
        ' 
        ' CategoryLabel
        ' 
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New Point(12, 81)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New Size(73, 20)
        CategoryLabel.TabIndex = 4
        CategoryLabel.Text = "Category:"
        ' 
        ' CategoryTextBox
        ' 
        CategoryTextBox.Location = New Point(103, 78)
        CategoryTextBox.Name = "CategoryTextBox"
        CategoryTextBox.Size = New Size(300, 27)
        CategoryTextBox.TabIndex = 5
        ' 
        ' DateLabel
        ' 
        DateLabel.AutoSize = True
        DateLabel.Location = New Point(12, 114)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New Size(45, 20)
        DateLabel.TabIndex = 6
        DateLabel.Text = "Date:"
        ' 
        ' TransactionDatePicker
        ' 
        TransactionDatePicker.Location = New Point(103, 111)
        TransactionDatePicker.Name = "TransactionDatePicker"
        TransactionDatePicker.Size = New Size(300, 27)
        TransactionDatePicker.TabIndex = 7
        ' 
        ' SaveButton
        ' 
        SaveButton.Location = New Point(103, 150)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(100, 30)
        SaveButton.TabIndex = 8
        SaveButton.Text = "Save"
        SaveButton.UseVisualStyleBackColor = True
        ' 
        ' CancelBtn
        ' 
        CancelBtn.Location = New Point(220, 150)
        CancelBtn.Name = "CancelBtn"
        CancelBtn.Size = New Size(100, 30)
        CancelBtn.TabIndex = 9
        CancelBtn.Text = "Cancel"
        CancelBtn.UseVisualStyleBackColor = True
        ' 
        ' EditTransactionDialog
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(420, 200)
        Controls.Add(CancelBtn)
        Controls.Add(SaveButton)
        Controls.Add(TransactionDatePicker)
        Controls.Add(DateLabel)
        Controls.Add(CategoryTextBox)
        Controls.Add(CategoryLabel)
        Controls.Add(AmountTextBox)
        Controls.Add(AmountLabel)
        Controls.Add(DescriptionTextBox)
        Controls.Add(DescriptionLabel)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "EditTransactionDialog"
        StartPosition = FormStartPosition.CenterParent
        Text = "Edit Transaction"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents AmountLabel As Label
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents CategoryLabel As Label
    Friend WithEvents CategoryTextBox As TextBox
    Friend WithEvents DateLabel As Label
    Friend WithEvents TransactionDatePicker As DateTimePicker
    Friend WithEvents SaveButton As Button
    Friend WithEvents CancelBtn As Button
End Class
