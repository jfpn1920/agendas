Imports System
Module mostrar_agenda_basica
    Sub Main(args As String())
        Dim nombre1 As String = "Juan Pérez"
        Dim telefono1 As String = "3001234567"
        Dim nombre2 As String = "María López"
        Dim telefono2 As String = "3019876543"
        Console.WriteLine("=== AGENDA BÁSICA ===")
        Console.WriteLine("Contacto 1:")
        Console.WriteLine("Nombre: " & nombre1)
        Console.WriteLine("Teléfono: " & telefono1)
        Console.WriteLine()
        Console.WriteLine("Contacto 2:")
        Console.WriteLine("Nombre: " & nombre2)
        Console.WriteLine("Teléfono: " & telefono2)
        Console.ReadLine()
    End Sub
End Module