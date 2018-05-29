Module area3_9
    Sub main()
        Dim lado, baseMenor, baseMayor, altura As Single
        Dim opcion As Byte

        Console.WriteLine("Para calcular el area elija una opcion:")
        Console.WriteLine("1- Un cuadrado:")
        Console.WriteLine("2- Un rectangulo:")
        Console.WriteLine("3- Un trapecio:")
        opcion = Console.ReadLine()

        If opcion = 1 Then
            Console.Write("Ingrese solo el lado: ")
            lado = Console.ReadLine()

            Console.WriteLine("A = lado * lado = " & calcular_area(lado))
        ElseIf opcion = 2 Then
            Console.Write("Ingrese Base: ")
            baseMayor = Console.ReadLine()
            Console.Write("Ingrese altura: ")
            altura = Console.ReadLine()

            Console.WriteLine("A = Base * altura = " & calcular_area(baseMayor, altura))
        Else
            Console.Write("Ingrese B: ")
            baseMayor = Console.ReadLine()
            Console.Write("Ingrese b: ")
            baseMenor = Console.ReadLine()
            Console.Write("Ingrese altura: ")
            altura = Console.ReadLine()

            Console.WriteLine("A = (B + b / 2) * altura = " & calcular_area(baseMayor, baseMenor, altura))
        End If

        Console.ReadKey()
    End Sub

    Private Function calcular_area(lado As Single) As Single
        Return lado * lado
    End Function

    Private Function calcular_area(base As Single, altura As Single) As Single
        Return base * altura
    End Function

    Private Function calcular_area(baseMayor As Single, baseMenor As Single, altura As Single) As Single
        Return ((baseMenor + baseMayor) / 2) * altura
    End Function
End Module
