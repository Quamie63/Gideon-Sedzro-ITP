<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        StepsTextBox = New TextBox()
        ReturnButton = New Button()
        SuspendLayout()
        ' 
        ' StepsTextBox
        ' 
        StepsTextBox.Location = New Point(28, 27)
        StepsTextBox.Multiline = True
        StepsTextBox.Name = "StepsTextBox"
        StepsTextBox.Size = New Size(419, 381)
        StepsTextBox.TabIndex = 0
        ' 
        ' ReturnButton
        ' 
        ReturnButton.Location = New Point(28, 440)
        ReturnButton.Name = "ReturnButton"
        ReturnButton.Size = New Size(419, 76)
        ReturnButton.TabIndex = 1
        ReturnButton.Text = "Return"
        ReturnButton.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(479, 540)
        Controls.Add(ReturnButton)
        Controls.Add(StepsTextBox)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StepsTextBox As TextBox
    Friend WithEvents ReturnButton As Button
End Class
