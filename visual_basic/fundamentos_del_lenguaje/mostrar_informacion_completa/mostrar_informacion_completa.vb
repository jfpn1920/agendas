Imports System
Module mostrar_informacion_completa
    Sub Main(args As String())
        Dim nombre As String = "Juan Pérez"
        Dim telefono As String = "3001234567"
        Dim correo As String = "juan@email.com"
        Dim direccion As String = "Calle 123 #45-67"
        Console.WriteLine("=== INFORMACIÓN COMPLETA ===")
        Console.WriteLine("Nombre: " & nombre)
        Console.WriteLine("Teléfono: " & telefono)
        Console.WriteLine("Correo: " & correo)
        Console.WriteLine("Dirección: " & direccion)
        Console.ReadLine()

    End Sub
End Module