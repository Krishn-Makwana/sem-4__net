Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim string1 As String = TextBox1.Text
        Dim string2 As String = TextBox2.Text
        MessageBox.Show(String.Concat(string1, string2))
    End Sub
End Class
