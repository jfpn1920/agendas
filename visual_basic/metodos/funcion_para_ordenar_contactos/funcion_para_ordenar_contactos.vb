Imports System
Module funcion_para_ordenar_contactos
    Sub Main(args As String())
        Dim contactos As New List(Of String) From {"Juan", "Maria", "Carlos", "Ana"}
        OrdenarContactos(contactos)
        Console.WriteLine("=== CONTACTOS ORDENADOS ===")
        For Each contacto As String In contactos
            Console.WriteLine(contacto)
        Next
        Console.ReadKey()
    End Sub
    Sub OrdenarContactos(ByRef lista As List(Of String))
        lista.Sort()
    End Sub
End Module