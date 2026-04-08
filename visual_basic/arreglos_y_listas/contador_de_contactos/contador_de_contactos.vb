Imports System
Module contador_de_contactos
    Sub Main(args As String())
        Dim contactos As New List(Of String) From {
            "Juan",
            "Maria",
            "Carlos",
            "Ana"
        }
        Console.WriteLine("=== CONTADOR DE CONTACTOS ===")
        Dim total As Integer = contactos.Count
        Console.WriteLine("Total de contactos: " & total)
        Console.ReadKey()
    End Sub
End Module