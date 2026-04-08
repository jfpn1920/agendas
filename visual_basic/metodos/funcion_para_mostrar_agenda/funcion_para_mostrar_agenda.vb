Imports System
Module funcion_para_mostrar_agenda
    Sub Main(args As String())
        Dim contactos As New List(Of String) From {
            "Juan", "Maria", "Carlos", "Ana"
        }
        MostrarAgenda(contactos)
        Console.ReadKey()
    End Sub
    Sub MostrarAgenda(ByVal lista As List(Of String))
        Console.WriteLine("=== AGENDA ===")
        For Each contacto As String In lista
            Console.WriteLine(contacto)
        Next
    End Sub
End Module