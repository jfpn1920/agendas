Imports System
Module recorrer_lista_de_contactos
    Sub Main(args As String())
        Dim contactos As New List(Of String) From {
            "Juan", "Maria", "Pedro", "Luisa"
        }
        Console.WriteLine("=== LISTA DE CONTACTOS ===")
        For Each contacto As String In contactos
            Console.WriteLine(contacto)
        Next
        Console.ReadKey()
    End Sub
End Module