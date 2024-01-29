Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim no As Integer = TextBox1.Text
        Dim i As Integer
        If no = 1 Then
            MessageBox.Show("Given no is not prime")
        End If
        For i = 2 To no - 1
            If no Mod i = 0 Then
                MessageBox.Show("Given no is not prime")
            End If
        Next i
        If i = no Then
            MessageBox.Show("Given no is prime")
        End If
    End Sub
End Class
