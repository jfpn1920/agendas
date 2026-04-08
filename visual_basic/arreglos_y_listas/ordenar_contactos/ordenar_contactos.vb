Imports System
Module ordenar_contactos
    Sub Main(args As String())
        Dim contactos As New List(Of String) From {
            "Carlos",
            "Ana",
            "Juan",
            "Maria"
        }
        Console.WriteLine("=== CONTACTOS DESORDENADOS ===")
        For Each contacto As String In contactos
            Console.WriteLine(contacto)
        Next
        contactos.Sort()
        Console.WriteLine(vbCrLf & "=== CONTACTOS ORDENADOS ===")
        For Each contacto As String In contactos
            Console.WriteLine(contacto)
        Next
        Console.ReadKey()
    End Sub
End Module