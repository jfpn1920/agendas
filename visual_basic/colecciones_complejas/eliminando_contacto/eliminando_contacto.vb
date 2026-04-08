Imports System
Imports System.Collections.Generic
Module eliminando_contacto
    Class Contacto
        Public Nombre As String
        Public Telefono As String
        Public Correo As String
    End Class
    Sub Main(args As String())
        Dim agenda As New List(Of Contacto)
        agenda.Add(New Contacto With {.Nombre = "Juan", .Telefono = "123", .Correo = "juan@mail.com"})
        agenda.Add(New Contacto With {.Nombre = "Maria", .Telefono = "456", .Correo = "maria@mail.com"})
        agenda.Add(New Contacto With {.Nombre = "Carlos", .Telefono = "789", .Correo = "carlos@mail.com"})
        Console.WriteLine("📒 CONTACTOS ACTUALES:")
        MostrarContactos(agenda)
        Console.WriteLine()
        Console.Write("Ingrese el nombre del contacto a eliminar: ")
        Dim nombreEliminar As String = Console.ReadLine()
        Dim eliminado As Boolean = False
        For Each contacto In agenda
            If contacto.Nombre.ToLower() = nombreEliminar.ToLower() Then
                agenda.Remove(contacto)
                eliminado = True
                Console.WriteLine("🗑️ Contacto eliminado correctamente.")
                Exit For
            End If
        Next
        If Not eliminado Then
            Console.WriteLine("❌ Contacto no encontrado.")
        End If
        Console.WriteLine()
        Console.WriteLine("📒 CONTACTOS ACTUALIZADOS:")
        MostrarContactos(agenda)
        Console.ReadKey()
    End Sub
    Sub MostrarContactos(lista As List(Of Contacto))
        For Each contacto In lista
            Console.WriteLine("------------------------")
            Console.WriteLine("Nombre: " & contacto.Nombre)
            Console.WriteLine("Teléfono: " & contacto.Telefono)
            Console.WriteLine("Correo: " & contacto.Correo)
        Next
    End Sub

End Module