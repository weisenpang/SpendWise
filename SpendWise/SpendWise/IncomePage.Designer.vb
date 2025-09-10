<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncomePage
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
        IncomeLabel = New Label()
        AddIncomeLabel = New Label()
        AddIncomeTextBox = New TextBox()
        AddIncomeButton = New Button()
        HomepageButton = New Button()
        SuspendLayout()
        ' 
        ' IncomeLabel
        ' 
        IncomeLabel.AutoSize = True
        IncomeLabel.Location = New Point(391, 78)
        IncomeLabel.Name = "IncomeLabel"
        IncomeLabel.Size = New Size(61, 20)
        IncomeLabel.TabIndex = 0
        IncomeLabel.Text = "Income:"
        ' 
        ' AddIncomeLabel
        ' 
        AddIncomeLabel.AutoSize = True
        AddIncomeLabel.Location = New Point(214, 185)
        AddIncomeLabel.Name = "AddIncomeLabel"
        AddIncomeLabel.Size = New Size(180, 20)
        AddIncomeLabel.TabIndex = 1
        AddIncomeLabel.Text = "Please Insert Your Income:"
        ' 
        ' AddIncomeTextBox
        ' 
        AddIncomeTextBox.Location = New Point(460, 185)
        AddIncomeTextBox.Name = "AddIncomeTextBox"
        AddIncomeTextBox.Size = New Size(125, 27)
        AddIncomeTextBox.TabIndex = 2
        ' 
        ' AddIncomeButton
        ' 
        AddIncomeButton.Location = New Point(236, 267)
        AddIncomeButton.Name = "AddIncomeButton"
        AddIncomeButton.Size = New Size(111, 29)
        AddIncomeButton.TabIndex = 3
        AddIncomeButton.Text = "Add Income"
        AddIncomeButton.UseVisualStyleBackColor = True
        ' 
        ' HomepageButton
        ' 
        HomepageButton.Location = New Point(428, 267)
        HomepageButton.Name = "HomepageButton"
        HomepageButton.Size = New Size(181, 29)
        HomepageButton.TabIndex = 4
        HomepageButton.Text = "Go Back To Homepage"
        HomepageButton.UseVisualStyleBackColor = True
        ' 
        ' IncomePage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(HomepageButton)
        Controls.Add(AddIncomeButton)
        Controls.Add(AddIncomeTextBox)
        Controls.Add(AddIncomeLabel)
        Controls.Add(IncomeLabel)
        Name = "IncomePage"
        Text = "IncomePage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents IncomeLabel As Label
    Friend WithEvents AddIncomeLabel As Label
    Friend WithEvents AddIncomeTextBox As TextBox
    Friend WithEvents AddIncomeButton As Button
    Friend WithEvents HomepageButton As Button
End Class
