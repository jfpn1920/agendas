Imports System
Module mostrar_lista_fija_de_contactos
    Sub Main(args As String())
        Dim contactos() As String = {"Juan", "Maria", "Carlos", "Ana"}
        Console.WriteLine("=== LISTA FIJA DE CONTACTOS ===")
        For Each contacto As String In contactos
            Console.WriteLine(contacto)
        Next
        Console.ReadKey()
    End Sub
End Module