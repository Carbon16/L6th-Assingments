Imports System.Console

Module Module1

    Sub Main()
        Dim score As Integer

        Write("Enter score: ") : score = ReadLine()

        Select Case score
            Case >= 90 : WriteLine("A*")
            Case >= 80 : WriteLine("A")
            Case >= 70 : WriteLine("B")
            Case >= 60 : WriteLine("C")
            Case >= 50 : WriteLine("D")
            Case >= 40 : WriteLine("E")
            Case Else : WriteLine("U")
        End Select

        ReadLine()
    End Sub

End Module
