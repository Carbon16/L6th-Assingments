Imports System.Console

Module Module1

    Sub Main()
        'PROBLEM A
        WriteLine("----------------TASK 2---------------")

        Write("Please enter your date of birth: ")
        Dim dateEntered As String = ReadLine()
        Dim dateThen As Date = Date.Parse(dateEntered)
        Dim dateNow As Date = Now
        WriteLine("You were born on the " & dateThen.Day & " of the " & dateThen.Month & "th month of " & dateThen.Year)

        ReadLine()


        Task3()
    End Sub

    Sub Task3()
        'PROBLEM A
        WriteLine("----------------TASK 2---------------")

        Write("Please enter your date of birth: ")
        Dim dateEntered As String = ReadLine()
        Dim dateThen As Date = Date.Parse(dateEntered)
        Dim dateNow As Date = Now
        Dim mth As String

        Select Case dateThen.Month
            Case 1 : mth = "January"
            Case 2 : mth = "Febuary"
            Case 3 : mth = "March"
            Case 4 : mth = "April"
            Case 5 : mth = "May"
            Case 6 : mth = "June"
            Case 7 : mth = "July"
            Case 8 : mth = "August"
            Case 9 : mth = "September"
            Case 10 : mth = "October"
            Case 11 : mth = "November"
            Case 12 : mth = "December"
            Case Else : mth = "invalid"
        End Select

        WriteLine("You were born on the " & dateThen.Day & "th of " & mth & " in " & dateThen.Year)
        ReadLine()

    End Sub

End Module