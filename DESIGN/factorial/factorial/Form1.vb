Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim no As Integer = TextBox1.Text
        Dim f As Integer = 1
        For i As Integer = 1 To no
            f *= i
        Next
        MessageBox.Show("your factorial is : " & f)
    End Sub
End Class
