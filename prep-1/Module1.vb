Imports System.Console

'Author: Leo Skingley
'Date: 21/09/22 | 2241
'GitHub: Carbon16/L6th-Assingments
'Description: General purpose command line utility tool to perform basic tasks and operations

Module Module1

    Sub Main()
        Dim leave As Boolean = False
        While leave = False
            Try
                Clear()
                WriteLine("1. Check if number is even or odd    2. Number of letters and number of 'a's     3. Find the number of words in a sentence       4. Do a calculation     5. Exit")
                Dim menuSelect As Integer = ReadLine()
                Select Case menuSelect
                    Case 1 : evOd()
                    Case 2 : charCount()
                    Case 3 : wordCount()
                    Case 4 : cal()
                    Case 5 : WriteLine("Goodbie!") : leave = True
                End Select
            Catch Ex As Exception
                Clear()
                WriteLine("Error!")
            End Try

            ReadLine()
        End While
    End Sub

    Sub evOd()
        Clear()
        Write("Number one: ") : Dim num1 As Integer = ReadLine()

        If num1 Mod 2 = 0 Then : WriteLine("Number is even!")
        Else : WriteLine("Number is odd!")
        End If

        ReadLine()

    End Sub

    Sub charCount()
        Clear()
        Write("Enter sentence: ")
        Dim sentence As String = ReadLine()

        WriteLine("Sentence has " & Len(sentence) & " chars.")
        WriteLine("Sentence has " & sentence.Split("a").Length - 1 & " a chars.")

        ReadLine()
    End Sub

    Sub wordCount()
        Clear()
        Write("Enter a sentence: ") : Dim manyWords As String = ReadLine()

        WriteLine("There are " & manyWords.Split(" ").Count & " words in this sentence.")
        ReadLine()
    End Sub

    Sub cal()
        Clear()
        Write("Enter an operator: ") : Dim operand As String = ReadLine()
        Write("Enter a number: ") : Dim num1 As Integer = ReadLine()
        Write("Enter another number: ") : Dim num2 As Integer = ReadLine()

        Select Case operand
            Case "*" : WriteLine("Result: " & num1 * num2)
            Case "/" : WriteLine("Result: " & num1 / num2)
            Case "+" : WriteLine("Result: " & num1 + num2)
            Case "-" : WriteLine("Result: " & num1 - num2)
            Case Else : WriteLine("Invalid!")
        End Select

        ReadLine()
    End Sub
End Module