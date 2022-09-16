Imports System.Console

Module Module1

    Sub Main()
        Dim inputOK As Boolean = False
        'FOR LOOP EXAMPLE

        'For i = 1 To 5
        '    WriteLine(i + 5)
        'Next

        'Write("Times table to complete: ") : Dim val As Integer = ReadLine()
        'For i = 0 To 12
        '    WriteLine(val & " X " & i & " = " & (val * i))
        'Next

        'Write("Name: ") : Dim name As String = ReadLine()

        'While name = ""
        '    Write("Name cannot be empty: ") : name = ReadLine()
        'End While
        While inputOK = False
            Try
                Write("From: ") : Dim from As Integer = ReadLine() : Write("To: ") : Dim toNum As Integer = ReadLine()
                If toNum < from Then : WriteLine("Invalid input, from must be > to!") : Else inputOK = True : End If
                For i = (from + 1) To (toNum - 1)
                    WriteLine(i)
                Next
            Catch ex As Exception
                WriteLine(ex)
                WriteLine()
                WriteLine()
                WriteLine("-------------------------------Invalid Input!-------------------------------------")
            End Try
        End While
        ReadLine()
    End Sub

End Module
