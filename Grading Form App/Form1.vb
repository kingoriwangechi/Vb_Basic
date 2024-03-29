Public Class GradeForm

    Private Sub Calculate_Clickbtn(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        ' Declare variables to store marks for the 4 subjects
        Dim mark1, mark2, mark3, mark4 As Integer

        ' Parse marks from textboxes
        Integer.TryParse(S1TextBox.Text, mark1)
        Integer.TryParse(S2TextBox.Text, mark2)
        Integer.TryParse(S3TextBox.Text, mark3)
        Integer.TryParse(S4TextBox.Text, mark4)

        ' Calculate average mark
        Dim averageMark As Integer = (mark1 + mark2 + mark3 + mark4) / 4

        ' Determine grade
        Dim grade As String
        If averageMark >= 75 Then
            grade = "A"
        ElseIf averageMark >= 65 Then
            grade = "B"
        ElseIf averageMark >= 50 Then
            grade = "C"
        Else
            grade = "Fail"
        End If

        ' Display grade using MessageBox
        MessageBox.Show("The average grade is: " & grade, "Grade")
    End Sub
End Class



