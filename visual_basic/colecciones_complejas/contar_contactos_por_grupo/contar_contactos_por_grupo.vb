Imports System
Imports System.Collections.Generic
Module contar_contactos_por_grupo
    Class Contacto
        Public Nombre As String
        Public Telefono As String
        Public Correo As String
    End Class
    Sub Main(args As String())
        Dim agenda As New Dictionary(Of String, List(Of Contacto))
        AgregarContacto(agenda, "Familia", New Contacto With {.Nombre = "Juan", .Telefono = "123", .Correo = "juan@mail.com"})
        AgregarContacto(agenda, "Familia", New Contacto With {.Nombre = "Ana", .Telefono = "321", .Correo = "ana@mail.com"})
        AgregarContacto(agenda, "Trabajo", New Contacto With {.Nombre = "Maria", .Telefono = "456", .Correo = "maria@mail.com"})
        AgregarContacto(agenda, "Amigos", New Contacto With {.Nombre = "Carlos", .Telefono = "789", .Correo = "carlos@mail.com"})
        AgregarContacto(agenda, "Amigos", New Contacto With {.Nombre = "Luis", .Telefono = "654", .Correo = "luis@mail.com"})
        ContarContactos(agenda)
        Console.ReadKey()
    End Sub
    Sub AgregarContacto(agenda As Dictionary(Of String, List(Of Contacto)), categoria As String, contacto As Contacto)
        If Not agenda.ContainsKey(categoria) Then
            agenda(categoria) = New List(Of Contacto)
        End If
        agenda(categoria).Add(contacto)
    End Sub
    Sub ContarContactos(agenda As Dictionary(Of String, List(Of Contacto)))
        Console.WriteLine("📊 CONTACTOS POR GRUPO")
        Console.WriteLine("===================================")
        For Each categoria In agenda.Keys
            Dim cantidad As Integer = agenda(categoria).Count
            Console.WriteLine("Categoría: " & categoria & " → " & cantidad & " contacto(s)")
        Next
    End Sub
End Module