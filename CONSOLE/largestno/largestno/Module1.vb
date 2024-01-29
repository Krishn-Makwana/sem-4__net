Imports System.Runtime.Remoting.Messaging

Module Module1

    Sub Main()
        Dim a As Integer = 10
        Dim b As Integer = 40
        Dim c As Integer = 30

        If a > b Then
            If a > c Then
                MsgBox("a is max")
            Else
                MsgBox("c is max")
            End If
        Else
            If b > c Then
                MsgBox("b is max")
            Else
                MsgBox("c is max")
            End If
        End If
    End Sub

End Module
