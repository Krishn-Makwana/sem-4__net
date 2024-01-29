Imports System.Console
Module Module1

    Sub Main()
        Dim no As Integer = 12
        If no Mod 2 = 0 Then
            Console.WriteLine("Given no is even.")
        Else
            Console.WriteLine("Given no is odd.")
        End If
    End Sub

End Module
