Imports System.console
Module Module1

    Public Sub Main()
        Write("Enter a message: ")
        Dim message As String = ReadLine()
        Write("Enter a key: ")
        Dim key As String = ReadLine()
        WriteLine(swapPairs(message, key))
        ReadLine()
    End Sub

    Function swapPairs(message As String, key As Integer) As String
        If message.Length < key Then
            Return message
        Else
            Return message(1) & message(0) & swapPairs(message.Substring(key), key)
        End If
    End Function

End Module