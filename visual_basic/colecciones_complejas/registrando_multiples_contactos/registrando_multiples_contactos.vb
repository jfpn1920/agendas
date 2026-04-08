Imports System
Imports System.Collections.Generic
Module registrando_multiples_contactos
    Class Contacto
        Public Nombre As String
        Public Telefono As String
        Public Correo As String
    End Class
    Sub Main(args As String())
        Dim agenda As New List(Of Contacto)
        Dim continuar As String = "s"
        While continuar.ToLower() = "s"
            Dim nuevoContacto As New Contacto()
            Console.Write("Ingrese el nombre: ")
            nuevoContacto.Nombre = Console.ReadLine()
            Console.Write("Ingrese el teléfono: ")
            nuevoContacto.Telefono = Console.ReadLine()
            Console.Write("Ingrese el correo: ")
            nuevoContacto.Correo = Console.ReadLine()
            agenda.Add(nuevoContacto)
            Console.Write("¿Desea agregar otro contacto? (s/n): ")
            continuar = Console.ReadLine()
            Console.WriteLine()
        End While
        Console.WriteLine("📒 Lista de contactos registrados:")
        For Each contacto In agenda
            Console.WriteLine("------------------------")
            Console.WriteLine("Nombre: " & contacto.Nombre)
            Console.WriteLine("Teléfono: " & contacto.Telefono)
            Console.WriteLine("Correo: " & contacto.Correo)
        Next
        Console.ReadKey()
    End Sub
End Module