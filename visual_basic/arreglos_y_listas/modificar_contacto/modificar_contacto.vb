Imports System
Module modificar_contacto
    Sub Main(args As String())
        Dim contactos As New List(Of String) From {
            "Juan",
            "Maria",
            "Carlos"
        }
        Console.WriteLine("=== LISTA DE CONTACTOS ===")
        For i As Integer = 0 To contactos.Count - 1
            Console.WriteLine((i + 1) & ". " & contactos(i))
        Next
        Console.WriteLine(vbCrLf & "Ingrese el número del contacto a modificar:")
        Dim opcion As Integer = Convert.ToInt32(Console.ReadLine())
        If opcion >= 1 And opcion <= contactos.Count Then
            Console.WriteLine("Ingrese el nuevo nombre:")
            Dim nuevoNombre As String = Console.ReadLine()
            contactos(opcion - 1) = nuevoNombre
            Console.WriteLine(vbCrLf & "✅ Contacto modificado correctamente")
        Else
            Console.WriteLine("❌ Opción inválida")
        End If
        Console.WriteLine(vbCrLf & "=== LISTA ACTUALIZADA ===")
        For Each contacto As String In contactos
            Console.WriteLine(contacto)
        Next
        Console.ReadKey()
    End Sub
End Module