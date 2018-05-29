Module Hipotenusa3_4
    Sub main()
        Dim a As Single
        Dim b As Single

        Do
            Console.Write("Ingrese el lado A: ")
            a = Console.ReadLine()
        Loop Until (validarNum(a))

        Do
            Console.Write("Ingrese el lado B: ")
            b = Console.ReadLine()
        Loop Until (validarNum(b))

        Console.WriteLine("El cuadrado de la hipotenusa(C): c² = a² + b²")
        Console.WriteLine("c² = {0}", calcHipotenusa(a, b))

        Console.ReadKey()
    End Sub

    Private Function validarNum(num As Single) As Boolean
        If num > 0 Then
            If (num Mod 1) > 0 Then
                Console.WriteLine("El numero debe ser entero!")
                Return False
            Else
                Return True
            End If
        Else
            Console.WriteLine("El numero debe ser positivo!")
            Return False
        End If
    End Function

    Private Function calcHipotenusa(a As Integer, b As Integer) As Integer
        Return a ^ 2 + b ^ 2
    End Function
End Module
