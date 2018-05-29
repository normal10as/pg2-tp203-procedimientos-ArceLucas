Module SubFun3_1

    Sub Main()
        fecha()
        Console.WriteLine(hora().ToShortTimeString)

        Console.ReadKey()
    End Sub

    Public Sub fecha()
        Console.WriteLine(Now.ToShortDateString)
    End Sub

    Public Function hora() As DateTime
        Return Now
    End Function

End Module
