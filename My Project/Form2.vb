Public Class Form2
    Private Sub DisplayText_Enter(sender As Object, e As EventArgs) Handles DisplayText.Enter

    End Sub


    Private Sub GaramondBtn_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Font_Enter(sender As Object, e As EventArgs) Handles GaramondBtn.CheckedChanged, MagnetoBtn.CheckedChanged, TahomaBtn.CheckedChanged

        Dim selectedRadioButton As RadioButton = DirectCast(sender, RadioButton)
        If selectedRadioButton.Checked Then
            Select Case selectedRadioButton.Text
                Case "Garamond"
                    SampleText.Font = New Font("Garamond", 12)
                Case "Magneto"
                    SampleText.Font = New Font("Magneto", 12)
                Case "Tahoma"
                    SampleText.Font = New Font("Tahoma", 12)
            End Select
        End If

    End Sub

    Private Sub FontStyleBox_Enter(sender As Object, e As EventArgs) Handles ItalicBox.CheckedChanged, BoldBox.CheckedChanged, BoldItalicBox.CheckedChanged
        Dim fontStyle As FontStyle = FontStyle.Regular

        If ItalicBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Italic
        End If

        If BoldBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Bold
        End If

        If BoldItalicBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Bold Or FontStyle.Italic
        End If

        SampleText.Font = New Font(SampleText.Font.FontFamily, SampleText.Font.Size, fontStyle)


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FontColorBox_Enter(sender As Object, e As EventArgs) Handles GreenBtn.CheckedChanged, BlueBtn.CheckedChanged, RedBtn.CheckedChanged

        Dim selectedColor As Color = Color.Black

        If GreenBtn.Checked Then
            selectedColor = Color.Green
        ElseIf BlueBtn.Checked Then
            selectedColor = Color.Blue
        ElseIf RedBtn.Checked Then
            selectedColor = Color.Red
        End If


        SampleText.ForeColor = selectedColor
    End Sub

    Private Sub LoadPicBtn_Click(sender As Object, e As EventArgs) Handles LoadPicBtn.Click

        Dim OpenFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files (*.*)|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                PictureBox1.Image = Image.FromFile(OpenFileDialog.FileName)
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub FontColorBox_Enter_1(sender As Object, e As EventArgs) Handles FontColorBox.Enter

    End Sub
End Class