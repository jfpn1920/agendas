Imports System
Imports System.Collections.Generic
Module buscar_por_clave
    Class Contacto
        Public Nombre As String
        Public Telefono As String
        Public Correo As String
    End Class
    Sub Main(args As String())
        Dim agenda As New Dictionary(Of String, Contacto)
        agenda.Add("juan", New Contacto With {.Nombre = "Juan", .Telefono = "123", .Correo = "juan@mail.com"})
        agenda.Add("maria", New Contacto With {.Nombre = "Maria", .Telefono = "456", .Correo = "maria@mail.com"})
        agenda.Add("carlos", New Contacto With {.Nombre = "Carlos", .Telefono = "789", .Correo = "carlos@mail.com"})
        Console.Write("Ingrese la clave (nombre) del contacto a buscar: ")
        Dim clave As String = Console.ReadLine().ToLower()
        If agenda.ContainsKey(clave) Then
            Dim contacto As Contacto = agenda(clave)
            Console.WriteLine("✅ Contacto encontrado:")
            Console.WriteLine("------------------------")
            Console.WriteLine("Nombre: " & contacto.Nombre)
            Console.WriteLine("Teléfono: " & contacto.Telefono)
            Console.WriteLine("Correo: " & contacto.Correo)
        Else
            Console.WriteLine("❌ Contacto no encontrado.")
        End If
        Console.ReadKey()
    End Sub
End Module