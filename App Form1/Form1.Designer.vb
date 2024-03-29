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
        loadBtn = New Button()
        ExitBtn = New Button()
        SuspendLayout()
        ' 
        ' loadBtn
        ' 
        loadBtn.BackColor = SystemColors.Control
        loadBtn.Location = New Point(129, 124)
        loadBtn.Name = "loadBtn"
        loadBtn.Size = New Size(277, 58)
        loadBtn.TabIndex = 0
        loadBtn.Text = "Load Object Demo"
        loadBtn.UseVisualStyleBackColor = False
        ' 
        ' ExitBtn
        ' 
        ExitBtn.Location = New Point(494, 124)
        ExitBtn.Name = "ExitBtn"
        ExitBtn.Size = New Size(189, 56)
        ExitBtn.TabIndex = 1
        ExitBtn.Text = "EXIT"
        ExitBtn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Red
        ClientSize = New Size(800, 450)
        Controls.Add(ExitBtn)
        Controls.Add(loadBtn)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents loadBtn As Button
    Friend WithEvents ExitBtn As Button

End Class
