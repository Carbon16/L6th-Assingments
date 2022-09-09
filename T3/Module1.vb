Imports System.Console

Module Module1
    Sub Main()
        'PROBLEM A
        WriteLine("----------------PROBLEM A----------------")
        Dim length As Integer, width As Integer, height As Integer, area As Integer, volume As Integer
        Write("Please enter the length of the cuboid: ") : length = ReadLine() : WriteLine()
        Write("Please enter the width of the cuboid: ") : width = ReadLine() : WriteLine()
        Write("Please enter the height of the cuboid: ") : height = ReadLine() : WriteLine()

        area = length * width : volume = area * height

        WriteLine("The area is: " & area)
        WriteLine("The volume is: " & volume)
        ReadLine()

        ProblemB()
    End Sub

    Sub ProblemB()
        'PROBLEM B
        WriteLine("----------------PROBLEM B----------------")
        Dim speed As Integer, time As Integer, distance As Integer
        Write("Please enter the average speed of the car in M/S: ") : speed = ReadLine() : WriteLine()
        Write("Please enter the time the car was moving in seconds: ") : time = ReadLine() : WriteLine()

        distance = speed * time

        WriteLine("The car travelled " & distance & " meters.")
        ReadLine()

        ProblemC()
    End Sub

    Sub ProblemC()
        'PROBLEM C
        WriteLine("----------------PROBLEM C----------------")

        Write("Please enter your date of birth: ")
        Dim dateEntered As String = ReadLine()
        Dim dateThen As Date = Date.Parse(dateEntered)
        Dim dateNow As Date = Now

        Dim days As Long = DateDiff(DateInterval.Day, dateThen, dateNow)

        Write("You have been alive for: " & days & " days.")

        ReadLine()

        ProblemD()
    End Sub

    Sub ProblemD()
        'PROBLEM D
        WriteLine("----------------PROBLEM D----------------")

        Const ton As Integer = 18
        Dim area As Decimal, tot As Decimal
        Write("Please enter area of farm in acres, up to 2dp:") : area = ReadLine()

        tot = area * ton

        WriteLine("The farm can produce " & tot & " tonnes of corn.")
        ReadLine()
        WriteLine() : WriteLine("------------END OF TASKS-------------") : WriteLine("Godbye :) [ANY KEY TO EXIT]")
        ReadLine()
    End Sub
End Module