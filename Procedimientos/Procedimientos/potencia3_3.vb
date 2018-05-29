Module potencia3_3
    Sub main()
        Dim x As Integer
        Dim i As Byte = 2

        Console.Write("Ingrese un numero: ")
        x = Console.ReadLine()

        Do While (i <= 6)
            Console.WriteLine("{0} ^ {1} = {2}", x, i, potencia(x, i))
            i += 1
        Loop

        Console.ReadKey()

    End Sub
    Public Function potencia(num As Integer, ByRef pot As Byte) As Integer
        Return num ^ pot
    End Function
End Module
