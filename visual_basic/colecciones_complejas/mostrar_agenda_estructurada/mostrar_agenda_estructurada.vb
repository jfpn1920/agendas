Imports System
Imports System.Collections.Generic
Module mostrar_agenda_estructurada
    Class Contacto
        Public Nombre As String
        Public Telefono As String
        Public Correo As String
    End Class
    Sub Main(args As String())
        Dim agenda As New Dictionary(Of String, Contacto)
        agenda.Add("1", New Contacto With {.Nombre = "Juan", .Telefono = "123", .Correo = "juan@mail.com"})
        agenda.Add("2", New Contacto With {.Nombre = "Maria", .Telefono = "456", .Correo = "maria@mail.com"})
        agenda.Add("3", New Contacto With {.Nombre = "Carlos", .Telefono = "789", .Correo = "carlos@mail.com"})
        MostrarAgenda(agenda)
        Console.ReadKey()
    End Sub
    Sub MostrarAgenda(agenda As Dictionary(Of String, Contacto))
        Console.WriteLine("📒 AGENDA ESTRUCTURADA")
        Console.WriteLine("===================================")
        For Each item In agenda
            Console.WriteLine("ID: " & item.Key)
            Console.WriteLine("Nombre: " & item.Value.Nombre)
            Console.WriteLine("Teléfono: " & item.Value.Telefono)
            Console.WriteLine("Correo: " & item.Value.Correo)
            Console.WriteLine("-----------------------------------")
        Next
    End Sub
End Module