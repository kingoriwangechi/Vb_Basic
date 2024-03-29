<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GradeForm
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
        Panel1 = New Panel()
        CalculateBtn = New Button()
        S4TextBox = New TextBox()
        S3TextBox = New TextBox()
        S2TextBox = New TextBox()
        S1TextBox = New TextBox()
        Sub4Label = New Label()
        Sub3Label = New Label()
        Sub2Label = New Label()
        Sub1Label = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(CalculateBtn)
        Panel1.Controls.Add(S4TextBox)
        Panel1.Controls.Add(S3TextBox)
        Panel1.Controls.Add(S2TextBox)
        Panel1.Controls.Add(S1TextBox)
        Panel1.Controls.Add(Sub4Label)
        Panel1.Controls.Add(Sub3Label)
        Panel1.Controls.Add(Sub2Label)
        Panel1.Controls.Add(Sub1Label)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(20, 20)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(50)
        Panel1.Size = New Size(760, 841)
        Panel1.TabIndex = 0
        ' 
        ' CalculateBtn
        ' 
        CalculateBtn.BackColor = Color.Gray
        CalculateBtn.FlatAppearance.BorderColor = Color.Silver
        CalculateBtn.FlatAppearance.BorderSize = 3
        CalculateBtn.FlatStyle = FlatStyle.Flat
        CalculateBtn.Font = New Font("Garamond", 9F, FontStyle.Bold)
        CalculateBtn.Location = New Point(236, 549)
        CalculateBtn.Name = "CalculateBtn"
        CalculateBtn.Size = New Size(239, 58)
        CalculateBtn.TabIndex = 8
        CalculateBtn.Text = "Calculate"
        CalculateBtn.UseVisualStyleBackColor = False
        ' 
        ' S4TextBox
        ' 
        S4TextBox.Location = New Point(236, 386)
        S4TextBox.Name = "S4TextBox"
        S4TextBox.Size = New Size(250, 47)
        S4TextBox.TabIndex = 7
        ' 
        ' S3TextBox
        ' 
        S3TextBox.Location = New Point(236, 302)
        S3TextBox.Name = "S3TextBox"
        S3TextBox.Size = New Size(250, 47)
        S3TextBox.TabIndex = 6
        ' 
        ' S2TextBox
        ' 
        S2TextBox.Location = New Point(236, 205)
        S2TextBox.Name = "S2TextBox"
        S2TextBox.Size = New Size(250, 47)
        S2TextBox.TabIndex = 5
        ' 
        ' S1TextBox
        ' 
        S1TextBox.Location = New Point(236, 107)
        S1TextBox.Name = "S1TextBox"
        S1TextBox.Size = New Size(250, 47)
        S1TextBox.TabIndex = 4
        ' 
        ' Sub4Label
        ' 
        Sub4Label.AutoSize = True
        Sub4Label.Font = New Font("Garamond", 9F, FontStyle.Bold)
        Sub4Label.Location = New Point(33, 379)
        Sub4Label.Name = "Sub4Label"
        Sub4Label.Padding = New Padding(10)
        Sub4Label.Size = New Size(151, 54)
        Sub4Label.TabIndex = 3
        Sub4Label.Text = "Subject 4"
        ' 
        ' Sub3Label
        ' 
        Sub3Label.AutoSize = True
        Sub3Label.Font = New Font("Garamond", 9F, FontStyle.Bold)
        Sub3Label.Location = New Point(33, 295)
        Sub3Label.Name = "Sub3Label"
        Sub3Label.Padding = New Padding(10)
        Sub3Label.Size = New Size(151, 54)
        Sub3Label.TabIndex = 2
        Sub3Label.Text = "Subject 3"
        ' 
        ' Sub2Label
        ' 
        Sub2Label.AutoSize = True
        Sub2Label.Font = New Font("Garamond", 9F, FontStyle.Bold)
        Sub2Label.Location = New Point(33, 198)
        Sub2Label.Name = "Sub2Label"
        Sub2Label.Padding = New Padding(10)
        Sub2Label.Size = New Size(151, 54)
        Sub2Label.TabIndex = 1
        Sub2Label.Text = "Subject 2"
        ' 
        ' Sub1Label
        ' 
        Sub1Label.AutoSize = True
        Sub1Label.Font = New Font("Garamond", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Sub1Label.Location = New Point(33, 100)
        Sub1Label.Name = "Sub1Label"
        Sub1Label.Padding = New Padding(10)
        Sub1Label.Size = New Size(149, 54)
        Sub1Label.TabIndex = 0
        Sub1Label.Text = "Subject 1"
        ' 
        ' GradeForm
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(800, 881)
        Controls.Add(Panel1)
        Name = "GradeForm"
        Padding = New Padding(20)
        StartPosition = FormStartPosition.CenterScreen
        Text = "Grade Form"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents S4TextBox As TextBox
    Friend WithEvents S3TextBox As TextBox
    Friend WithEvents S2TextBox As TextBox
    Friend WithEvents S1TextBox As TextBox
    Friend WithEvents Sub4Label As Label
    Friend WithEvents Sub3Label As Label
    Friend WithEvents Sub2Label As Label
    Friend WithEvents Sub1Label As Label
    Friend WithEvents CalculateBtn As Button

End Class
