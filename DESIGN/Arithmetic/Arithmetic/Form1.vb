Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Double = TextBox1.Text
        Dim y As Double = TextBox2.Text
        Dim z As Double
        z = x + y
        MessageBox.Show("your sum is : " & z)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As Double = TextBox1.Text
        Dim y As Double = TextBox2.Text
        Dim z As Double
        z = x - y
        MessageBox.Show("your sum is : " & z)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x As Double = TextBox1.Text
        Dim y As Double = TextBox2.Text
        Dim z As Double
        z = x * y
        MessageBox.Show("your sum is : " & z)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x As Double = TextBox1.Text
        Dim y As Double = TextBox2.Text
        Dim z As Double
        z = x / y
        MessageBox.Show("your sum is : " & z)
    End Sub


End Class
