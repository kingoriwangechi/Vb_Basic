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
        DisplayText = New GroupBox()
        SampleText = New Label()
        FontBox = New GroupBox()
        TahomaBtn = New RadioButton()
        MagnetoBtn = New RadioButton()
        GaramondBtn = New RadioButton()
        FontStyleBox = New GroupBox()
        BoldItalicBox = New CheckBox()
        BoldBox = New CheckBox()
        ItalicBox = New CheckBox()
        FontColorBox = New GroupBox()
        RedBtn = New RadioButton()
        BlueBtn = New RadioButton()
        GreenBtn = New RadioButton()
        DateTimePicker1 = New DateTimePicker()
        PictureBox1 = New PictureBox()
        LoadPicBtn = New Button()
        ExitButton = New Button()
        DisplayText.SuspendLayout()
        FontBox.SuspendLayout()
        FontStyleBox.SuspendLayout()
        FontColorBox.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DisplayText
        ' 
        DisplayText.Controls.Add(SampleText)
        DisplayText.Location = New Point(41, 42)
        DisplayText.Name = "DisplayText"
        DisplayText.Size = New Size(282, 105)
        DisplayText.TabIndex = 0
        DisplayText.TabStop = False
        DisplayText.Text = "Display Text"
        ' 
        ' SampleText
        ' 
        SampleText.AutoSize = True
        SampleText.Location = New Point(25, 58)
        SampleText.Name = "SampleText"
        SampleText.Size = New Size(169, 41)
        SampleText.TabIndex = 0
        SampleText.Text = "SampleText"
        ' 
        ' FontBox
        ' 
        FontBox.Controls.Add(TahomaBtn)
        FontBox.Controls.Add(MagnetoBtn)
        FontBox.Controls.Add(GaramondBtn)
        FontBox.Location = New Point(429, 46)
        FontBox.Name = "FontBox"
        FontBox.Size = New Size(776, 134)
        FontBox.TabIndex = 1
        FontBox.TabStop = False
        FontBox.Text = "Font"
        ' 
        ' TahomaBtn
        ' 
        TahomaBtn.AutoSize = True
        TahomaBtn.Location = New Point(467, 61)
        TahomaBtn.Name = "TahomaBtn"
        TahomaBtn.Size = New Size(159, 45)
        TahomaBtn.TabIndex = 2
        TahomaBtn.TabStop = True
        TahomaBtn.Text = "Tahoma"
        TahomaBtn.UseVisualStyleBackColor = True
        ' 
        ' MagnetoBtn
        ' 
        MagnetoBtn.AutoSize = True
        MagnetoBtn.Location = New Point(265, 56)
        MagnetoBtn.Name = "MagnetoBtn"
        MagnetoBtn.Size = New Size(176, 45)
        MagnetoBtn.TabIndex = 1
        MagnetoBtn.TabStop = True
        MagnetoBtn.Text = "Magneto"
        MagnetoBtn.UseVisualStyleBackColor = True
        ' 
        ' GaramondBtn
        ' 
        GaramondBtn.AutoSize = True
        GaramondBtn.Location = New Point(48, 61)
        GaramondBtn.Name = "GaramondBtn"
        GaramondBtn.Size = New Size(195, 45)
        GaramondBtn.TabIndex = 0
        GaramondBtn.TabStop = True
        GaramondBtn.Text = "Garamond"
        GaramondBtn.UseVisualStyleBackColor = True
        ' 
        ' FontStyleBox
        ' 
        FontStyleBox.Controls.Add(BoldItalicBox)
        FontStyleBox.Controls.Add(BoldBox)
        FontStyleBox.Controls.Add(ItalicBox)
        FontStyleBox.Location = New Point(452, 189)
        FontStyleBox.Name = "FontStyleBox"
        FontStyleBox.Size = New Size(296, 281)
        FontStyleBox.TabIndex = 2
        FontStyleBox.TabStop = False
        FontStyleBox.Text = "Font Style"
        ' 
        ' BoldItalicBox
        ' 
        BoldItalicBox.AutoSize = True
        BoldItalicBox.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BoldItalicBox.Location = New Point(48, 151)
        BoldItalicBox.Name = "BoldItalicBox"
        BoldItalicBox.Size = New Size(192, 45)
        BoldItalicBox.TabIndex = 2
        BoldItalicBox.Text = "Bold Italic"
        BoldItalicBox.UseVisualStyleBackColor = True
        ' 
        ' BoldBox
        ' 
        BoldBox.AutoSize = True
        BoldBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BoldBox.Location = New Point(48, 100)
        BoldBox.Name = "BoldBox"
        BoldBox.Size = New Size(121, 45)
        BoldBox.TabIndex = 1
        BoldBox.Text = "Bold"
        BoldBox.UseVisualStyleBackColor = True
        ' 
        ' ItalicBox
        ' 
        ItalicBox.AutoSize = True
        ItalicBox.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ItalicBox.Location = New Point(48, 49)
        ItalicBox.Name = "ItalicBox"
        ItalicBox.Size = New Size(119, 45)
        ItalicBox.TabIndex = 0
        ItalicBox.Text = "Italic"
        ItalicBox.UseVisualStyleBackColor = True
        ' 
        ' FontColorBox
        ' 
        FontColorBox.Controls.Add(RedBtn)
        FontColorBox.Controls.Add(BlueBtn)
        FontColorBox.Controls.Add(GreenBtn)
        FontColorBox.Location = New Point(888, 200)
        FontColorBox.Name = "FontColorBox"
        FontColorBox.Size = New Size(270, 284)
        FontColorBox.TabIndex = 3
        FontColorBox.TabStop = False
        FontColorBox.Text = "Font Color"
        ' 
        ' RedBtn
        ' 
        RedBtn.AutoSize = True
        RedBtn.Location = New Point(17, 172)
        RedBtn.Name = "RedBtn"
        RedBtn.Size = New Size(106, 45)
        RedBtn.TabIndex = 2
        RedBtn.TabStop = True
        RedBtn.Text = "Red"
        RedBtn.UseVisualStyleBackColor = True
        ' 
        ' BlueBtn
        ' 
        BlueBtn.AutoSize = True
        BlueBtn.Location = New Point(17, 108)
        BlueBtn.Name = "BlueBtn"
        BlueBtn.Size = New Size(112, 45)
        BlueBtn.TabIndex = 1
        BlueBtn.TabStop = True
        BlueBtn.Text = "Blue"
        BlueBtn.UseVisualStyleBackColor = True
        ' 
        ' GreenBtn
        ' 
        GreenBtn.AutoSize = True
        GreenBtn.Location = New Point(17, 57)
        GreenBtn.Name = "GreenBtn"
        GreenBtn.Size = New Size(135, 45)
        GreenBtn.TabIndex = 0
        GreenBtn.TabStop = True
        GreenBtn.Text = "Green"
        GreenBtn.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(0, 0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(500, 47)
        DateTimePicker1.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(41, 169)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(282, 301)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' LoadPicBtn
        ' 
        LoadPicBtn.Location = New Point(82, 511)
        LoadPicBtn.Name = "LoadPicBtn"
        LoadPicBtn.Size = New Size(279, 75)
        LoadPicBtn.TabIndex = 6
        LoadPicBtn.Text = "Load  Picture"
        LoadPicBtn.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(1107, 518)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(156, 56)
        ExitButton.TabIndex = 7
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1334, 592)
        Controls.Add(ExitButton)
        Controls.Add(LoadPicBtn)
        Controls.Add(PictureBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(FontColorBox)
        Controls.Add(FontStyleBox)
        Controls.Add(FontBox)
        Controls.Add(DisplayText)
        Name = "Form2"
        Text = "Object Demonstrations"
        DisplayText.ResumeLayout(False)
        DisplayText.PerformLayout()
        FontBox.ResumeLayout(False)
        FontBox.PerformLayout()
        FontStyleBox.ResumeLayout(False)
        FontStyleBox.PerformLayout()
        FontColorBox.ResumeLayout(False)
        FontColorBox.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DisplayText As GroupBox
    Friend WithEvents SampleText As Label
    Friend WithEvents FontBox As GroupBox
    Friend WithEvents TahomaBtn As RadioButton
    Friend WithEvents MagnetoBtn As RadioButton
    Friend WithEvents GaramondBtn As RadioButton
    Friend WithEvents FontStyleBox As GroupBox
    Friend WithEvents ItalicBox As CheckBox
    Friend WithEvents BoldItalicBox As CheckBox
    Friend WithEvents BoldBox As CheckBox
    Friend WithEvents FontColorBox As GroupBox
    Friend WithEvents BlueBtn As RadioButton
    Friend WithEvents GreenBtn As RadioButton
    Friend WithEvents RedBtn As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LoadPicBtn As Button
    Friend WithEvents ExitButton As Button
End Class
