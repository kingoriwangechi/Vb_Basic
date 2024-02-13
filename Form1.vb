Public Class Form1
    Private Sub loadBtn_Click(sender As Object, e As EventArgs) Handles loadBtn.Click
        Dim objDemo As New Form2()
        objDemo.Show()

    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Application.Exit()

    End Sub
End Class
