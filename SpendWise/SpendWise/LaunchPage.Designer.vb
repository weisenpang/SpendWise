<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LaunchPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        SpendWisePictureBox = New PictureBox()
        SpendWiseLogoPictureBox = New PictureBox()
        StartProgramButton = New Button()
        CType(SpendWisePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(SpendWiseLogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SpendWisePictureBox
        ' 
        SpendWisePictureBox.Image = My.Resources.Resources.SpendWisePictureBox
        SpendWisePictureBox.Location = New Point(265, 71)
        SpendWisePictureBox.Name = "SpendWisePictureBox"
        SpendWisePictureBox.Size = New Size(247, 60)
        SpendWisePictureBox.SizeMode = PictureBoxSizeMode.AutoSize
        SpendWisePictureBox.TabIndex = 0
        SpendWisePictureBox.TabStop = False
        ' 
        ' SpendWiseLogoPictureBox
        ' 
        SpendWiseLogoPictureBox.Image = My.Resources.Resources.SpendWiseLogoPictureBox
        SpendWiseLogoPictureBox.Location = New Point(353, 176)
        SpendWiseLogoPictureBox.Name = "SpendWiseLogoPictureBox"
        SpendWiseLogoPictureBox.Size = New Size(82, 82)
        SpendWiseLogoPictureBox.SizeMode = PictureBoxSizeMode.AutoSize
        SpendWiseLogoPictureBox.TabIndex = 1
        SpendWiseLogoPictureBox.TabStop = False
        ' 
        ' StartProgramButton
        ' 
        StartProgramButton.Location = New Point(271, 301)
        StartProgramButton.Name = "StartProgramButton"
        StartProgramButton.Size = New Size(244, 80)
        StartProgramButton.TabIndex = 2
        StartProgramButton.Text = "Start Program"
        StartProgramButton.UseVisualStyleBackColor = True
        ' 
        ' LaunchPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(800, 450)
        Controls.Add(StartProgramButton)
        Controls.Add(SpendWiseLogoPictureBox)
        Controls.Add(SpendWisePictureBox)
        Name = "LaunchPage"
        Text = "Welcome to SpendWise !"
        CType(SpendWisePictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(SpendWiseLogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SpendWisePictureBox As PictureBox
    Friend WithEvents SpendWiseLogoPictureBox As PictureBox
    Friend WithEvents StartProgramButton As Button

End Class
