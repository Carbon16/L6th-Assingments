Imports System.Console

Module Module1
    Sub Task1()
        'PROBLEM 1
        WriteLine("----------------PROBLEM 1----------------")
        Dim len, deep, shall, wid, vol As Integer
        WriteLine("Enter all measurments in Meters")
        Write("Enter length: ") : len = ReadLine()
        Write("Enter length of deep end: ") : deep = ReadLine()
        Write("Enter depth of shallow end: ") : shall = ReadLine()
        Write("Enter width: ") : wid = ReadLine()

        vol = (((((deep * shall) * 0.5) * len) * wid) * 1000)

        WriteLine("The swimming pool holds " & vol & " litres.")
        ReadLine()
    End Sub

    Sub Main()
        Task1()
        'PROBLEM 4
        WriteLine("----------------PROBLEM 4----------------")

        Write("Please enter your date of birth: ")
        Dim dateEntered As String = ReadLine()
        Dim dateThen As Date = Date.Parse(dateEntered)
        Dim isLeap As String, leep As Boolean = Date.IsLeapYear(dateThen.Year)

        Select Case leep
            Case True : isLeap = " was "
            Case False : isLeap = " was not "
            Case Else : isLeap = " INVALID "
        End Select

        WriteLine(dateThen.Year & isLeap & "a leap year.")

        ReadLine()
        Task5()
    End Sub

    Sub Task5()
        'PROBLEM 5
        WriteLine("----------------PROBLEM 5-----------------")
        Write("Enter string: ") : Dim inputString As String = ReadLine()

        WriteLine("Length: " & Len(Replace(inputString, " ", "")))
        ReadLine()

        Task6()
    End Sub

    Sub Task6()
        'Task 6
        WriteLine("----------------PROBLEM 6-----------------")
        Write("Enter string: ") : Dim inputString As String = ReadLine()
        Dim toPrint As String, sliceAndDice() As String = Split(inputString, " ")

        For Each item In sliceAndDice
            toPrint += " " & StrReverse(item)
        Next

        WriteLine(toPrint)
        ReadLine()
    End Sub

End Module
