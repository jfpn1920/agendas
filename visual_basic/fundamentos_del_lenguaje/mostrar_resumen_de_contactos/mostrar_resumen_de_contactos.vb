Imports System
Module mostrar_resumen_de_contactos
    Sub Main(args As String())
        Dim nombre1 As String = "Juan Pérez"
        Dim nombre2 As String = "María López"
        Dim nombre3 As String = "Carlos Gómez"
        Dim totalContactos As Integer = 3
        Console.WriteLine("=== RESUMEN DE CONTACTOS ===")
        Console.WriteLine("Total de contactos: " & totalContactos)
        Console.WriteLine("Contactos:")
        Console.WriteLine("- " & nombre1)
        Console.WriteLine("- " & nombre2)
        Console.WriteLine("- " & nombre3)
        Console.ReadLine()
    End Sub
End Module