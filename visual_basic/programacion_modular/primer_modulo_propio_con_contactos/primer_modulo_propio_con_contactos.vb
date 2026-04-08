Imports System
Module primer_modulo_propio_con_contactos
    Sub Main(args As String())
        Contactos.MostrarContactos()
        Contactos.AgregarContacto("Sofia")
        Contactos.MostrarContactos()
        Console.ReadKey()
    End Sub
End Module
Module Contactos
    Dim listaContactos As New List(Of String) From {"Juan", "Maria", "Carlos", "Ana"}
    Sub MostrarContactos()
        Console.WriteLine("=== CONTACTOS ===")
        For Each contacto As String In listaContactos
            Console.WriteLine(contacto)
        Next
        Console.WriteLine()
    End Sub
    Sub AgregarContacto(ByVal nombre As String)
        listaContactos.Add(nombre)
        Console.WriteLine("✅ Contacto agregado: " & nombre & vbCrLf)
    End Sub
End Module