Imports System
Module ProgramaPrincipal
    Sub Main(args As String())
        Contactos.AgregarContacto("Sofia")
        Contactos.AgregarContacto("Luis")
        Contactos.MostrarContactos()
        Dim total As Integer = Contactos.ContarContactos()
        Console.WriteLine("Total de contactos: " & total)
        Dim existe As Boolean = Contactos.BuscarContacto("Maria")
        Console.WriteLine("¿Maria está en la agenda? " & If(existe, "Sí", "No"))
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
        Console.WriteLine("✅ Contacto agregado: " & nombre)
    End Sub
    Function ContarContactos() As Integer
        Return listaContactos.Count
    End Function
    Function BuscarContacto(ByVal nombre As String) As Boolean
        Return listaContactos.Contains(nombre)
    End Function
End Module