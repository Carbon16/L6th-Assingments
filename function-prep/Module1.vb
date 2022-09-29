Imports System.Console

Module Module1

    Sub Main()
        WriteLine("Sentence Analysis") : WriteLine() : WriteLine("Enter a sentence, then press 'Enter'") : WriteLine()
        Write("Enter a sentence: ") : Dim str As String = ReadLine() : WriteLine()

        WriteLine(WordCount(str))
        WriteLine(VowelCount(str))

        ReadLine()
    End Sub

    Function WordCount(ByVal s1 As String)
        Dim toPrint As String = "There are " & s1.Split(" ").Count & " words in this sentence."
        Return toPrint
    End Function

    Function VowelCount(ByVal s1 As String)
        Dim sa, se, si, so, su As String : sa = s1 : se = s1 : si = s1 : so = s1 : su = s1
        Dim toPrint As String = "There are " & ((sa.Split("a").Count - 1) + (se.Split("e").Count - 1) + (si.Split("i").Count - 1) + (so.Split("o").Count - 1) + (su.Split("u").Count - 1)) & " vowels in this sentence."
        Return toPrint
    End Function

End Module
