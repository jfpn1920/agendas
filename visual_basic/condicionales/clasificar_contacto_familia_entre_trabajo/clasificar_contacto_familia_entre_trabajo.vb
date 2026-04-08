Imports System
Module clasificar_contacto_familia_entre_trabajo
    Sub Main(args As String())
        Dim nombre As String
        Dim tipo As String
        Console.Write("Ingrese el nombre del contacto: ")
        nombre = Console.ReadLine()
        Console.Write("Ingrese el tipo de contacto (familia/trabajo): ")
        tipo = Console.ReadLine()
        If tipo.ToLower() = "familia" Then
            Console.WriteLine(nombre & " es un contacto de FAMILIA 👨‍👩‍👧‍👦")
        ElseIf tipo.ToLower() = "trabajo" Then
            Console.WriteLine(nombre & " es un contacto de TRABAJO 💼")
        Else
            Console.WriteLine("Tipo de contacto no válido")
        End If
    End Sub
End Module