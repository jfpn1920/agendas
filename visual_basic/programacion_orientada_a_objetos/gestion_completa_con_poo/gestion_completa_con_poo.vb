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
    Public Sub Mostrar()
        Console.WriteLine("ID: " & Id & " | Nombre: " & Nombre & " | Tel: " & Telefono)
    End Sub
End Class
Public Class Agenda
    Private contactos As New List(Of Contacto)
    Public Sub Agregar(contacto As Contacto)
        contactos.Add(contacto)
    End Sub
    Public Sub MostrarTodos()
        If contactos.Count = 0 Then
            Console.WriteLine("No hay contactos.")
        Else
            For Each c In contactos
                c.Mostrar()
            Next
        End If
    End Sub
    Public Function Buscar(id As Integer) As Contacto
        For Each c In contactos
            If c.Id = id Then
                Return c
            End If
        Next
        Return Nothing
    End Function
    Public Sub Eliminar(id As Integer)
        Dim c = Buscar(id)
        If c IsNot Nothing Then
            contactos.Remove(c)
            Console.WriteLine("Contacto eliminado.")
        Else
            Console.WriteLine("No encontrado.")
        End If
    End Sub
    Public Sub Editar(id As Integer, nuevoNombre As String, nuevoTelefono As String)
        Dim c = Buscar(id)
        If c IsNot Nothing Then
            c.Nombre = nuevoNombre
            c.Telefono = nuevoTelefono
            Console.WriteLine("Contacto actualizado.")
        Else
            Console.WriteLine("No encontrado.")
        End If
    End Sub
End Class
Module gestion_completa_con_poo
    Sub Main(args As String())
        Dim agenda As New Agenda()
        Dim opcion As String
        Dim id As Integer = 1
        Do
            Console.Clear()
            Console.WriteLine("=== AGENDA POO COMPLETA ===")
            Console.WriteLine("1. Agregar contacto")
            Console.WriteLine("2. Mostrar contactos")
            Console.WriteLine("3. Buscar contacto")
            Console.WriteLine("4. Eliminar contacto")
            Console.WriteLine("5. Editar contacto")
            Console.WriteLine("6. Salir")
            Console.Write("Seleccione: ")
            opcion = Console.ReadLine()
            Select Case opcion
                Case "1"
                    Console.Write("Nombre: ")
                    Dim nombre = Console.ReadLine()
                    Console.Write("Teléfono: ")
                    Dim telefono = Console.ReadLine()
                    agenda.Agregar(New Contacto(id, nombre, telefono))
                    id += 1
                    Console.WriteLine("Agregado correctamente.")
                    Console.ReadKey()
                Case "2"
                    agenda.MostrarTodos()
                    Console.ReadKey()
                Case "3"
                    Console.Write("ID a buscar: ")
                    Dim idBuscar = Convert.ToInt32(Console.ReadLine())
                    Dim c = agenda.Buscar(idBuscar)
                    If c IsNot Nothing Then
                        c.Mostrar()
                    Else
                        Console.WriteLine("No encontrado.")
                    End If
                    Console.ReadKey()
                Case "4"
                    Console.Write("ID a eliminar: ")
                    Dim idEliminar = Convert.ToInt32(Console.ReadLine())
                    agenda.Eliminar(idEliminar)
                    Console.ReadKey()
                Case "5"
                    Console.Write("ID a editar: ")
                    Dim idEditar = Convert.ToInt32(Console.ReadLine())
                    Console.Write("Nuevo nombre: ")
                    Dim nuevoNombre = Console.ReadLine()
                    Console.Write("Nuevo teléfono: ")
                    Dim nuevoTelefono = Console.ReadLine()
                    agenda.Editar(idEditar, nuevoNombre, nuevoTelefono)
                    Console.ReadKey()
                Case "6"
                    Console.WriteLine("Saliendo del sistema...")
                Case Else
                    Console.WriteLine("Opción inválida")
                    Console.ReadKey()
            End Select
        Loop While opcion <> "6"
    End Sub
End Module