'Author: Leo Skingley
'Date: 22/09/22
'GitHub: Carbon16/L6th-Assingments
'Description: Loop and iteration practice prep

Imports System.Console

Module Module1

    Sub Main()
        Try
            WriteLine("----------------Task 1--------------------")
            Write("Enter password: ") : Dim pwd As String = ReadLine()
            While Not pwd = "secret"
                WriteLine("Incorrect password, try again!")
                Write("Enter password: ") : pwd = ReadLine()
            End While
            WriteLine("You are in!")

            ReadLine()

            Task2()
        Catch Ex As Exception
            WriteLine("Error!")
        End Try
        ReadLine()
    End Sub

    Sub Task2()
        WriteLine("----------------Task 1--------------------")
        Dim num, high, low As Integer : high = -1 : low = -1 : num = 0
        While Not num < 0
            If num > high Then : high = num
            ElseIf num < low AndAlso num > 0 Then : low = num
            End If
            Write("Enter number: ") : num = ReadLine()
        End While

        WriteLine("Highest number: " & high)
        WriteLine("Lowest number: " & low)

        ReadLine()
        Task3()
    End Sub

    Sub Task3()
        WriteLine("----------------Task 3--------------------")

        'COULD NOT COMPLETE, ATTEMPED IN PYHON.

        'Write("What number would you like to go up to: ") : Dim upTo As Integer = ReadLine()

        'For i As Integer
        'For i As Integer = 0 To upTo
        '    WriteLine()
        'Next

        ''Console.WriteLine("{0,-20} {1,-10} {2,-10}", "{column 1}", "{column 2}", "")
        ''Console.WriteLine("{0,-20} {1,-10} {2,-10}", "0", 0, 0)

        ReadLine()
    End Sub

End Module
