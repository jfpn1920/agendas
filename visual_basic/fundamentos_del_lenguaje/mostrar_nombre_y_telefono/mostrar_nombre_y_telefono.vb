Imports System
Module mostrar_nombre_y_telefono
    Sub Main(args As String())
        Dim nombre As String
        Dim telefono As String
        Console.Write("Ingrese el nombre: ")
        nombre = Console.ReadLine()
        Console.Write("Ingrese el teléfono: ")
        telefono = Console.ReadLine()
        Console.WriteLine(vbCrLf & "=== CONTACTO ===")
        Console.WriteLine("Nombre: " & nombre)
        Console.WriteLine("Teléfono: " & telefono)
        Console.ReadLine()
    End Sub
End Module