<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpPage
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
        Label1 = New Label()
        Label2 = New Label()
        UserNameTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        SignUpButton = New Button()
        LogInPageLabel = New LinkLabel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(242, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 20)
        Label1.TabIndex = 0
        Label1.Text = "Enter your username :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(241, 191)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 20)
        Label2.TabIndex = 1
        Label2.Text = "Enter your password :"
        ' 
        ' UserNameTextBox
        ' 
        UserNameTextBox.Location = New Point(412, 139)
        UserNameTextBox.Name = "UserNameTextBox"
        UserNameTextBox.Size = New Size(125, 27)
        UserNameTextBox.TabIndex = 2
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Location = New Point(412, 188)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "•"c
        PasswordTextBox.Size = New Size(125, 27)
        PasswordTextBox.TabIndex = 3
        ' 
        ' SignUpButton
        ' 
        SignUpButton.Location = New Point(346, 246)
        SignUpButton.Name = "SignUpButton"
        SignUpButton.Size = New Size(94, 29)
        SignUpButton.TabIndex = 4
        SignUpButton.Text = "Sign Up"
        SignUpButton.UseVisualStyleBackColor = True
        ' 
        ' LogInPageLabel
        ' 
        LogInPageLabel.AutoSize = True
        LogInPageLabel.Location = New Point(286, 310)
        LogInPageLabel.Name = "LogInPageLabel"
        LogInPageLabel.Size = New Size(211, 20)
        LogInPageLabel.TabIndex = 5
        LogInPageLabel.TabStop = True
        LogInPageLabel.Text = "Signed up before ? Click here !"
        ' 
        ' SignUpPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LogInPageLabel)
        Controls.Add(SignUpButton)
        Controls.Add(PasswordTextBox)
        Controls.Add(UserNameTextBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "SignUpPage"
        Text = "Please sign up !"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents SignUpButton As Button
    Friend WithEvents LogInPageLabel As LinkLabel
End Class
