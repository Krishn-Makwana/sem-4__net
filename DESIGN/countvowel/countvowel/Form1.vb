Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vowels As String = "AEIOUaeiou"
        Dim i As Integer
        Dim instring As String = TextBox1.Text
        Dim count As Integer = 0
        For i = 1 To Len(instring)
            If InStr(vowels, Mid(instring, i, 1)) Then
                count += 1
            End If
        Next i
        MsgBox("your string vowel is : " & count)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
