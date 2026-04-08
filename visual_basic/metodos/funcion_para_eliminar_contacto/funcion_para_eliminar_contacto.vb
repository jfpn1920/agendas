Imports System
Module funcion_para_eliminar_contacto
    Sub Main(args As String())
        Dim contactos As New List(Of String) From {
            "Juan", "Maria", "Carlos", "Ana"
        }
        EliminarContacto(contactos)
        Console.WriteLine(vbCrLf & "=== LISTA ACTUALIZADA ===")
        For Each contacto As String In contactos
            Console.WriteLine(contacto)
        Next
        Console.ReadKey()
    End Sub
    Sub EliminarContacto(ByRef lista As List(Of String))
        Console.WriteLine("Ingrese el nombre del contacto a eliminar:")
        Dim nombre As String = Console.ReadLine()
        If lista.Contains(nombre) Then
            lista.Remove(nombre)
            Console.WriteLine("✅ Contacto eliminado")
        Else
            Console.WriteLine("❌ Contacto no encontrado")
        End If
    End Sub
End Module