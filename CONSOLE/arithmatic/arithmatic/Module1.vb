Imports System.Runtime.CompilerServices
Imports System.Threading

Module Module1
    Sub Main()
        Dim a As Integer = 20
        Dim b As Integer = 10
        Dim c As Integer
        c = a + b
        Console.WriteLine("your addition  is : " & c)
        c = a - b
        Console.WriteLine("your subtraction is : " & c)
        c = a * b
        Console.WriteLine("your multiplication is : " & c)
        c = a / b
        Console.WriteLine("your division is : " & c)
        Console.ReadLine()
    End Sub

End Module
