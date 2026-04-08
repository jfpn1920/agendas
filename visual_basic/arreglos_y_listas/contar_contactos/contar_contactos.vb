Imports System
Module contar_contactos
    Sub Main(args As String())
        Dim contactos() As String = {"Juan", "Maria", "Carlos", "Ana"}
        Console.WriteLine("=== CONTAR CONTACTOS ===")
        Dim total As Integer = contactos.Length
        Console.WriteLine("Total de contactos: " & total)
        Console.ReadKey()
    End Sub
End Module