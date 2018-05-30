Module Volumen3_5
    Sub main()
        Dim a As Single

        Dim b As Single

        Do
            Console.Write("Ingrese el lado radio: ")
            a = Console.ReadLine()
        Loop Until (validarNum(a))

        Do
            Console.Write("Ingrese la altura: ")
            b = Console.ReadLine()
        Loop Until (validarNum(b))

        Console.WriteLine("v = π * r² * h")
        Console.WriteLine("v = {0}", calcVolumen(a, b))

        Console.ReadKey()
    End Sub

    Private Function validarNum(num As Single) As Boolean
        If num > 0 Then
            Return True
        Else
            Console.WriteLine("El numero debe ser positivo!")
            Return False
        End If
    End Function

    Private Function calcVolumen(radio As Single, altura As Single) As Single
        Return 3.14 * radio ^ 2 * altura
    End Function
End Module
