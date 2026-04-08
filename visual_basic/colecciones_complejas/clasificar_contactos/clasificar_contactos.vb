Imports System
Imports System.Collections.Generic
Module clasificar_contactos
    Class Contacto
        Public Nombre As String
        Public Telefono As String
        Public Correo As String
        Public Categoria As String
    End Class
    Sub Main(args As String())
        Dim agenda As New Dictionary(Of String, List(Of Contacto))
        AgregarContacto(agenda, New Contacto With {.Nombre = "Juan", .Telefono = "123", .Correo = "juan@mail.com", .Categoria = "Familia"})
        AgregarContacto(agenda, New Contacto With {.Nombre = "Maria", .Telefono = "456", .Correo = "maria@mail.com", .Categoria = "Trabajo"})
        AgregarContacto(agenda, New Contacto With {.Nombre = "Carlos", .Telefono = "789", .Correo = "carlos@mail.com", .Categoria = "Amigos"})
        AgregarContacto(agenda, New Contacto With {.Nombre = "Ana", .Telefono = "321", .Correo = "ana@mail.com", .Categoria = "Familia"})
        MostrarContactosClasificados(agenda)
        Console.ReadKey()
    End Sub
    Sub AgregarContacto(agenda As Dictionary(Of String, List(Of Contacto)), contacto As Contacto)
        If Not agenda.ContainsKey(contacto.Categoria) Then
            agenda(contacto.Categoria) = New List(Of Contacto)
        End If
        agenda(contacto.Categoria).Add(contacto)
    End Sub
    Sub MostrarContactosClasificados(agenda As Dictionary(Of String, List(Of Contacto)))
        Console.WriteLine("📒 CONTACTOS CLASIFICADOS")
        Console.WriteLine("===================================")
        For Each categoria In agenda.Keys
            Console.WriteLine("📂 Categoría: " & categoria)
            Console.WriteLine("---------------------------")
            For Each contacto In agenda(categoria)
                Console.WriteLine("Nombre: " & contacto.Nombre)
                Console.WriteLine("Teléfono: " & contacto.Telefono)
                Console.WriteLine("Correo: " & contacto.Correo)
                Console.WriteLine("---------------------------")
            Next
            Console.WriteLine()
        Next
    End Sub
End Module