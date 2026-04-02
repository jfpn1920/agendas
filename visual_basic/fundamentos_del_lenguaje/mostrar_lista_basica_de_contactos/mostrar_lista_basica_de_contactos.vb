Imports System
Module mostrar_lista_basica_de_contactos
    Sub Main(args As String())
        Dim nombre1 As String = "Juan Pérez"
        Dim telefono1 As String = "3001234567"
        Dim nombre2 As String = "María López"
        Dim telefono2 As String = "3019876543"
        Dim nombre3 As String = "Carlos Gómez"
        Dim telefono3 As String = "3025558899"
        Console.WriteLine("=== LISTA DE CONTACTOS ===")
        Console.WriteLine("Contacto 1: " & nombre1 & " - " & telefono1)
        Console.WriteLine("Contacto 2: " & nombre2 & " - " & telefono2)
        Console.WriteLine("Contacto 3: " & nombre3 & " - " & telefono3)
        Console.ReadLine()
    End Sub
End Module