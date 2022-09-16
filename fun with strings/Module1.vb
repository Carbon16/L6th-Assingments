Imports System.Console

Module Module1

    Sub Main()
        WriteLine("----------------FUN WITH STRINGS----------------------")
        WriteLine("---------------------TASK 1---------------------------")
        Write("Enter name: ") : Dim fullName As String = ReadLine()

        WriteLine("Numner of letters: " & Len(Replace(fullName, " ", "")))

        ReadLine()
        Task2()
    End Sub

    Sub Task2()
        WriteLine("---------------------TASK 2---------------------------")
        Write("Enter first name: ") : Dim fName As String = ReadLine()

        WriteLine("Hello " & fName & ". Your name consists of " & Len(Replace(fName, " ", "")) & " characters and your initial is " & fName(0))

        ReadLine()
        Task3()
    End Sub

    Sub Task3()
        WriteLine("---------------------TASK 3---------------------------")

        Write("Enter password: ") : Dim pwd As String = ReadLine()
        While Len(pwd) < 6
            WriteLine("Password must be over 6 characters, please try again.")
            Write("Enter password: ") : pwd = ReadLine()
        End While : WriteLine("Password [" & pwd & "] accepted.")

        ReadLine()
        Task4()
    End Sub

    Sub Task4()
        WriteLine("---------------------TASK 4---------------------------")
        Write("Enter UK phone number: ") : Dim phoneNum As String = ReadLine()

        WriteLine("'Intl format: +44" & phoneNum.Split("0")(1))
        ReadLine()
        Task5()
    End Sub

    Sub Task5()
        WriteLine("---------------------TASK 5---------------------------")
        Write("Enter a string: ") : Dim flippityFlop As String = ReadLine()

        WriteLine(StrReverse(flippityFlop))
        ReadLine()
        Task6()
    End Sub

    Sub Task6()
        WriteLine("---------------------TASK 6---------------------------")
        Write("Enter your first and last name: ") : Dim frstLast As String = ReadLine()

        WriteLine("Your first name is " & frstLast.Split(" ")(0) & " and your second name is " & frstLast.Split(" ")(1))

        ReadLine()
        Task7()
    End Sub

    Sub Task7()
        WriteLine("---------------------TASK 7---------------------------")
        Write("Enter a sentence: ") : Dim manyWords As String = ReadLine()

        WriteLine("There are " & manyWords.Split(" ").Count & " words in this sentence.")

        ReadLine()
        WriteLine("---------------------Goodbie :)---------------------------")
    End Sub

End Module
