Module Sobrecarga3_8
    Enum operaciones
        suma = 1
        resta
        multiplicacion
        division
    End Enum

    Sub main()

        resultado(5, 7)
        resultado(operaciones.suma, 6, 5, 7)
        resultado(operaciones.resta, 50, 9, 3)
        resultado(operaciones.multiplicacion, 17, 9, 7)
        resultado(operaciones.division, 500, 5, 3, 2)

        Console.ReadKey()
    End Sub

    Private Sub resultado(x As Single, y As Single)
        Console.WriteLine("{0} + {1} = {2}", x, y, calcular(x, y))
    End Sub

    Private Sub resultado(operador As operaciones, x As Single, y As Single, z As Single)
        If operador = 1 Then
            Console.WriteLine("{0} + {1} + {2} = {3}", x, y, z, calcular(operador, x, y, z))
        ElseIf operador = 2 Then
            Console.WriteLine("{0} - {1} - {2} = {3}", x, y, z, calcular(operador, x, y, z))
        ElseIf operador = 3 Then
            Console.WriteLine("{0} * {1} * {2} = {3}", x, y, z, calcular(operador, x, y, z))
        Else
            Console.WriteLine("{0} / {1} / {2} = {3}", x, y, z, calcular(operador, x, y, z))
        End If
    End Sub

    Private Sub resultado(operador As operaciones, x As Single, y As Single, z As Single, w As Single)
        If operador = 1 Then
            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", x, y, z, w, calcular(operador, x, y, z, w))
        ElseIf operador = 2 Then
            Console.WriteLine("{0} - {1} - {2} - {3} = {4}", x, y, z, w, calcular(operador, x, y, z, w))
        ElseIf operador = 3 Then
            Console.WriteLine("{0} * {1} * {2} * {3} = {4}", x, y, z, w, calcular(operador, x, y, z, w))
        Else
            Console.WriteLine("{0} / {1} / {2} / {3} = {4}", x, y, z, w, calcular(operador, x, y, z, w))
        End If
    End Sub

    Private Function calcular(x As Single, y As Single) As Single
        Return x + y
    End Function

    Private Function calcular(operador As operaciones, x As Single, y As Single, z As Single) As Single
        If operador = 1 Then
            Return x + y + z
        ElseIf operador = 2 Then
            Return x - y - z
        ElseIf operador = 3 Then
            Return x * y * z
        Else
            Return x / y / z
        End If
    End Function

    Private Function calcular(operador As operaciones, x As Single, y As Single, z As Single, w As Single) As Single
        If operador = 1 Then
            Return x + y + z + w
        ElseIf operador = 2 Then
            Return x - y - z - w
        ElseIf operador = 3 Then
            Return x * y * z * w
        Else
            Return x / y / z / w
        End If
    End Function
End Module
