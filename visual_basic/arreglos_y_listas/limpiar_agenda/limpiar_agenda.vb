Imports System
Module limpiar_agenda
    Sub Main(args As String())
        Dim contactos As New List(Of String) From {
            "Juan",
            "Maria",
            "Carlos",
            "Ana"
        }
        Console.WriteLine("=== AGENDA ANTES DE LIMPIAR ===")
        For Each contacto As String In contactos
            Console.WriteLine(contacto)
        Next
        contactos.Clear()
        Console.WriteLine(vbCrLf & "=== AGENDA LIMPIA ===")
        Console.WriteLine("Cantidad de contactos: " & contactos.Count)
        Console.ReadKey()
    End Sub
End Module