Module Sobrecarga3_7
    Enum operaciones
        suma = 1
        resta
        multiplicacion
        division
    End Enum

    Sub main()

        Console.WriteLine(calcular(5, 7))
        Console.WriteLine(calcular(operaciones.resta, 5, 7, 10))
        Console.WriteLine(calcular(operaciones.resta, 15, 5, 7, 10))

        Console.ReadKey()
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

    Private Function calcular(operador As operaciones, w As Single, x As Single, y As Single, z As Single) As Single
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
