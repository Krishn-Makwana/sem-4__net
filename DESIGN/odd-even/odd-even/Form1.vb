Imports System.ComponentModel.Design

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim no As Integer = TextBox1.Text
        If no Mod 2 = 0 Then
            MessageBox.Show("Given no is even")
        Else
            MessageBox.Show("Given no is odd")
        End If

    End Sub
End Class
