Imports System
Module funcion_reutilizable_de_agenda
    Sub Main(args As String())
        Dim contactos As New List(Of String) From {"Juan", "Maria", "Carlos", "Ana"}
        MostrarAgenda(contactos)
        Console.WriteLine()
        AgregarContacto(contactos, "Sofia")
        MostrarAgenda(contactos)
        Console.WriteLine()
        EliminarContacto(contactos, "Carlos")
        MostrarAgenda(contactos)
        Console.ReadKey()
    End Sub
    Sub MostrarAgenda(ByVal lista As List(Of String))
        Console.WriteLine("=== AGENDA ===")
        For Each contacto As String In lista
            Console.WriteLine(contacto)
        Next
    End Sub
    Sub AgregarContacto(ByRef lista As List(Of String), ByVal nombre As String)
        lista.Add(nombre)
        Console.WriteLine("✅ Contacto agregado: " & nombre)
    End Sub
    Sub EliminarContacto(ByRef lista As List(Of String), ByVal nombre As String)
        If lista.Contains(nombre) Then
            lista.Remove(nombre)
            Console.WriteLine("✅ Contacto eliminado: " & nombre)
        Else
            Console.WriteLine("❌ Contacto no encontrado: " & nombre)
        End If
    End Sub
End Module