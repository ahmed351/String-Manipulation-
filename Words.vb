Module Words

    Sub Main()
        Dim S1, S2, firstword, secword As String
        Dim SP As Integer

        S1 = ""
        S2 = ""
        SP = 0
        firstword = ""
        secword = ""
        Console.Write("Fill First String: ")
        S1 = Console.ReadLine
        Console.Write("Fill Second String: ")
        S2 = Console.ReadLine

        SP = InStr(S1, " ")
        firstword = Left(S1, SP - 1)

        SP = InStr(S2, " ")
        secword = Right(S2, Len(S2) - SP)

        Console.Write("Final Sring = " & firstword & " " & secword)

        Console.ReadKey()







    End Sub

End Module
