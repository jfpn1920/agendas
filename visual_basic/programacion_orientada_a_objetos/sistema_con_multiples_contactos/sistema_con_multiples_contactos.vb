Imports System
Imports System.Collections.Generic
Public Class Contacto
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Telefono As String
    Public Sub New(id As Integer, nombre As String, telefono As String)
        Me.Id = id
        Me.Nombre = nombre
        Me.Telefono = telefono
    End Sub
End Class
Public Class Agenda
    Private contactos As New List(Of Contacto)
    Public Sub AgregarContacto(contacto As Contacto)
        contactos.Add(contacto)
    End Sub
    Public Sub MostrarAgenda()
        Console.WriteLine("=== CONTACTOS ===")
        If contactos.Count = 0 Then
            Console.WriteLine("No hay contactos.")
        Else
            For Each c In contactos
                Console.WriteLine("ID: " & c.Id & " | Nombre: " & c.Nombre & " | Tel: " & c.Telefono)
            Next
        End If
    End Sub
    Public Sub BuscarContacto(id As Integer)
        Dim encontrado As Contacto = Nothing
        For Each c In contactos
            If c.Id = id Then
                encontrado = c
                Exit For
            End If
        Next
        If encontrado IsNot Nothing Then
            Console.WriteLine("Encontrado:")
            Console.WriteLine("ID: " & encontrado.Id & " | Nombre: " & encontrado.Nombre & " | Tel: " & encontrado.Telefono)
        Else
            Console.WriteLine("Contacto no encontrado.")
        End If
    End Sub
    Public Sub EliminarContacto(id As Integer)
        Dim encontrado As Contacto = Nothing
        For Each c In contactos
            If c.Id = id Then
                encontrado = c
                Exit For
            End If
        Next
        If encontrado IsNot Nothing Then
            contactos.Remove(encontrado)
            Console.WriteLine("Contacto eliminado.")
        Else
            Console.WriteLine("Contacto no encontrado.")
        End If
    End Sub
End Class
Module sistema_con_multiples_contactos
    Sub Main(args As String())
        Dim agenda As New Agenda()
        Dim opcion As String
        Dim contadorId As Integer = 1
        Do
            Console.Clear()
            Console.WriteLine("=== SISTEMA DE AGENDA ===")
            Console.WriteLine("1. Agregar contacto")
            Console.WriteLine("2. Mostrar contactos")
            Console.WriteLine("3. Buscar contacto")
            Console.WriteLine("4. Eliminar contacto")
            Console.WriteLine("5. Salir")
            Console.Write("Seleccione: ")
            opcion = Console.ReadLine()
            Select Case opcion
                Case "1"
                    Console.Write("Nombre: ")
                    Dim nombre As String = Console.ReadLine()
                    Console.Write("Teléfono: ")
                    Dim telefono As String = Console.ReadLine()
                    Dim nuevo As New Contacto(contadorId, nombre, telefono)
                    agenda.AgregarContacto(nuevo)
                    contadorId += 1
                    Console.WriteLine("Contacto agregado.")
                    Console.ReadKey()
                Case "2"
                    agenda.MostrarAgenda()
                    Console.ReadKey()
                Case "3"
                    Console.Write("Ingrese ID: ")
                    Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                    agenda.BuscarContacto(idBuscar)
                    Console.ReadKey()
                Case "4"
                    Console.Write("Ingrese ID a eliminar: ")
                    Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                    agenda.EliminarContacto(idEliminar)
                    Console.ReadKey()
                Case "5"
                    Console.WriteLine("Saliendo del sistema...")
                Case Else
                    Console.WriteLine("Opción inválida")
                    Console.ReadKey()
            End Select
        Loop While opcion <> "5"
    End Sub
End Module