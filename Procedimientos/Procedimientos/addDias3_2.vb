Module addDias3_2
    Sub main()
        Dim fecha As Date
        Dim ndias As Byte

        Console.Write("Ingrese una fecha dd,mm,aaaa: ")
        fecha = Console.ReadLine()

        Console.Write("Ingrese los dias a sumar: ")
        ndias = Console.ReadLine()

        Console.WriteLine(sumaDias(fecha, ndias).ToShortDateString)

        Console.ReadKey()

    End Sub

    Public Function sumaDias(fecha As Date, dias As Byte) As Date
        Return fecha.AddDays(dias)
    End Function
End Module
