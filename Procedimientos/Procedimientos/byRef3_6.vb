Module byRef3_6
    Sub main()
        Dim a As Single
        Dim sum As Integer

        Do
            Console.Write("Ingrese un numero: ")
            a = Console.ReadLine()
        Loop Until (validarNum(a))

        sumatoria(a, sum)

        Console.WriteLine("La sumatoria de los cuadrados es: " & sum)

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

    Private Sub sumatoria(n As Integer, ByRef sum As Integer)
        For i As Int16 = 1 To n Step +1
            sum += i ^ 2
        Next
    End Sub
End Module
