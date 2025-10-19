<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInPage
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
        LinkLabel1 = New LinkLabel()
        UserNameTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        LogInButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(227, 139)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 20)
        Label1.TabIndex = 0
        Label1.Text = "Enter your username :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(228, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 20)
        Label2.TabIndex = 1
        Label2.Text = "Enter your password :"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(278, 320)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(227, 20)
        LinkLabel1.TabIndex = 2
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "New user ? Click here to sign up !"
        ' 
        ' UserNameTextBox
        ' 
        UserNameTextBox.Location = New Point(392, 136)
        UserNameTextBox.Name = "UserNameTextBox"
        UserNameTextBox.Size = New Size(125, 27)
        UserNameTextBox.TabIndex = 3
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Location = New Point(392, 193)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.Size = New Size(125, 27)
        PasswordTextBox.TabIndex = 4
        PasswordTextBox.UseSystemPasswordChar = True
        ' 
        ' LogInButton
        ' 
        LogInButton.Location = New Point(339, 256)
        LogInButton.Name = "LogInButton"
        LogInButton.Size = New Size(94, 29)
        LogInButton.TabIndex = 5
        LogInButton.Text = "Log In"
        LogInButton.UseVisualStyleBackColor = True
        ' 
        ' LogInPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LogInButton)
        Controls.Add(PasswordTextBox)
        Controls.Add(UserNameTextBox)
        Controls.Add(LinkLabel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "LogInPage"
        Text = "Please Log In !"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents LogInButton As Button
End Class
