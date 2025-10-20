<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAdminAccount
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
        CreateAdminButton = New Button()
        TestLoginButton = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' CreateAdminButton
        ' 
        CreateAdminButton.Location = New Point(50, 100)
        CreateAdminButton.Name = "CreateAdminButton"
        CreateAdminButton.Size = New Size(200, 40)
        CreateAdminButton.TabIndex = 0
        CreateAdminButton.Text = "Create Admin Account"
        CreateAdminButton.UseVisualStyleBackColor = True
        ' 
        ' TestLoginButton
        ' 
        TestLoginButton.Location = New Point(300, 100)
        TestLoginButton.Name = "TestLoginButton"
        TestLoginButton.Size = New Size(200, 40)
        TestLoginButton.TabIndex = 1
        TestLoginButton.Text = "Test Admin Login"
        TestLoginButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(50, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(283, 28)
        Label1.TabIndex = 2
        Label1.Text = "Admin Account Setup Utility"
        ' 
        ' CreateAdminAccount
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(550, 200)
        Controls.Add(Label1)
        Controls.Add(TestLoginButton)
        Controls.Add(CreateAdminButton)
        Name = "CreateAdminAccount"
        Text = "Create Admin Account"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CreateAdminButton As Button
    Friend WithEvents TestLoginButton As Button
    Friend WithEvents Label1 As Label
End Class

