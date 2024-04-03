<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        AlgorithmComboBox = New ComboBox()
        FilePathTextBox = New TextBox()
        BrowseButton = New Button()
        ItemToSearchTextBox = New TextBox()
        FileRadioButton = New RadioButton()
        RandomRadioButton = New RadioButton()
        StartButton = New Button()
        SuspendLayout()
        ' 
        ' AlgorithmComboBox
        ' 
        AlgorithmComboBox.FormattingEnabled = True
        AlgorithmComboBox.Location = New Point(182, 70)
        AlgorithmComboBox.Name = "AlgorithmComboBox"
        AlgorithmComboBox.Size = New Size(257, 33)
        AlgorithmComboBox.TabIndex = 0
        AlgorithmComboBox.Text = "Select Algorithm"
        ' 
        ' FilePathTextBox
        ' 
        FilePathTextBox.Location = New Point(182, 143)
        FilePathTextBox.Name = "FilePathTextBox"
        FilePathTextBox.Size = New Size(150, 31)
        FilePathTextBox.TabIndex = 1
        ' 
        ' BrowseButton
        ' 
        BrowseButton.Location = New Point(338, 143)
        BrowseButton.Name = "BrowseButton"
        BrowseButton.Size = New Size(101, 34)
        BrowseButton.TabIndex = 2
        BrowseButton.Text = "Browse"
        BrowseButton.UseVisualStyleBackColor = True
        ' 
        ' ItemToSearchTextBox
        ' 
        ItemToSearchTextBox.Location = New Point(182, 226)
        ItemToSearchTextBox.Name = "ItemToSearchTextBox"
        ItemToSearchTextBox.PlaceholderText = "Enter Valid Value To Search"
        ItemToSearchTextBox.Size = New Size(257, 31)
        ItemToSearchTextBox.TabIndex = 3
        ' 
        ' FileRadioButton
        ' 
        FileRadioButton.AutoSize = True
        FileRadioButton.Location = New Point(376, 306)
        FileRadioButton.Name = "FileRadioButton"
        FileRadioButton.Size = New Size(63, 29)
        FileRadioButton.TabIndex = 4
        FileRadioButton.TabStop = True
        FileRadioButton.Text = "File"
        FileRadioButton.UseVisualStyleBackColor = True
        ' 
        ' RandomRadioButton
        ' 
        RandomRadioButton.AutoSize = True
        RandomRadioButton.Location = New Point(182, 306)
        RandomRadioButton.Name = "RandomRadioButton"
        RandomRadioButton.Size = New Size(105, 29)
        RandomRadioButton.TabIndex = 5
        RandomRadioButton.TabStop = True
        RandomRadioButton.Text = "Random"
        RandomRadioButton.UseVisualStyleBackColor = True
        ' 
        ' StartButton
        ' 
        StartButton.Location = New Point(182, 373)
        StartButton.Name = "StartButton"
        StartButton.Size = New Size(257, 74)
        StartButton.TabIndex = 6
        StartButton.Text = "Start"
        StartButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(632, 543)
        Controls.Add(StartButton)
        Controls.Add(RandomRadioButton)
        Controls.Add(FileRadioButton)
        Controls.Add(ItemToSearchTextBox)
        Controls.Add(BrowseButton)
        Controls.Add(FilePathTextBox)
        Controls.Add(AlgorithmComboBox)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AlgorithmComboBox As ComboBox
    Friend WithEvents FilePathTextBox As TextBox
    Friend WithEvents BrowseButton As Button
    Friend WithEvents ItemToSearchTextBox As TextBox
    Friend WithEvents FileRadioButton As RadioButton
    Friend WithEvents RandomRadioButton As RadioButton
    Friend WithEvents StartButton As Button

End Class
