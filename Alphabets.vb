Module Alphabets

    Sub Main()
        Dim Str1 As String
        Dim counter, alpha, Noalpha As Integer
        Dim letter As String


        Str1 = ""
        letter = ""
        counter = 0
        alpha = 0
        Noalpha = 0

        Console.Write("Input String: ")
        Str1 = Console.ReadLine


        For counter = 1 To Len(Str1)
            letter = Mid(Str1, counter, 1)
            If LCase(letter) < "a" Or LCase(letter) > "z" Then
                Noalpha = Noalpha + 1
            Else
                alpha = alpha + 1
            End If
        Next

        Console.WriteLine(alpha, "Alphabets")
        Console.WriteLine(Noalpha, "Non Alphabets")
        Console.ReadKey()

    End Sub

End Module
