Imports System.Console

Module Module1

    Sub Main()
        EvenMoreThings()
        Things()
        MoreThings()
        Dim treasure(9, 9) As Integer
        Dim x, y, ux, uy As Integer
        Dim count As Integer = 0
        Dim done As Boolean = False

        Randomize()
        x = Int(Rnd() * 10)
        y = Int(Rnd() * 10)

        treasure(x, y) = 1
        While done = False
            Try
                Do
                    Write("Enter the x coordinate: ") : ux = ReadLine()
                    Write("Enter the y coordinate: ") : uy = ReadLine()

                    If x > 9 Or y > 9 Then
                        WriteLine("The coordinates are invalid")
                    ElseIf x = ux And y = uy Then
                        WriteLine("You have found the treasure")
                        Exit Do
                    Else
                        If x > ux Then
                            WriteLine("The treasure is to the east")
                        ElseIf x < ux Then
                            WriteLine("The treasure is to the west")
                        ElseIf uy > y Then
                            WriteLine("The treasure is to the south")
                        ElseIf uy < y Then
                            WriteLine("The treasure is to the north")
                        End If
                    End If

                    count += 1
                    If count = 10 Then
                        WriteLine("Game over")
                        Exit Do
                    End If

                Loop
                done = True
            Catch Ex As Exception
                WriteLine(Ex)
                done = False
            End Try
        End While

        ReadLine()

    End Sub

    Sub Things()
        'menu message box
        Dim msg As String = "Would you like to play again?"
        Dim title As String = "Menu"
        Dim style As MsgBoxStyle = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question
        Dim response As MsgBoxResult

        response = MsgBox(msg, style, title)

        If response = MsgBoxResult.Yes Then
            Main()
        ElseIf response = MsgBoxResult.No Then
            MsgBox("Bie :)")
        End If
    End Sub

    Sub MoreThings()
        'Input box
        Dim name As String
        Dim msg As String = "What is your name?"
        Dim title As String = "Name"
        Dim defaultResponse As String = "Enter name here"

        Dim myStyle As MsgBoxStyle = MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question
        Dim myResponse As MsgBoxResult

        myResponse = MsgBox(msg, myStyle, title)

        If myResponse = MsgBoxResult.Ok Then
            name = InputBox(msg, title, defaultResponse)
            WriteLine("Hello " & name)
        ElseIf myResponse = MsgBoxResult.Cancel Then
            End
        End If
    End Sub

    Sub EvenMoreThings()
        'message box
        Dim msg As String = "You have found the treasure"
        Dim title As String = "Treasure"
        Dim style As MsgBoxStyle = MsgBoxStyle.OkOnly Or MsgBoxStyle.Information
        Dim response As MsgBoxResult

        response = MsgBox(msg, style, title)

        If response = MsgBoxResult.Ok Then
            End
        End If
    End Sub
    Sub Buttons()
        'A message box with a grid of 9x9 buttons
        Dim msg As String = "Click the treasure"
        Dim title As String = "Treasure"
        Dim style As MsgBoxStyle = MsgBoxStyle.OkOnly Or MsgBoxStyle.Information
        Dim response As MsgBoxResult

        response = MsgBox(msg, style, title)
        Dim buttons As New List(Of Button)
        Dim button As Button
        Dim i As Integer = 0

        For i = 0 To 9
            button = New Button()
            button.Name = "button" & i
            button.Text = "button" & i
            button.Location = New Point(10 + i * 20, 10 + i * 20)
            buttons.Add(button)
        Next
    End Sub
End Module
