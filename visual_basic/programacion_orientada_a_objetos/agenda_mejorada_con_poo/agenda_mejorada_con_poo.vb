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
        Console.WriteLine($"ID: {Id} | Nombre: {Nombre} | Tel: {Telefono}")
    End Sub
End Class
Public Class Agenda
    Private contactos As New List(Of Contacto)
    Public Sub Agregar(contacto As Contacto)
        If String.IsNullOrWhiteSpace(contacto.Nombre) OrElse String.IsNullOrWhiteSpace(contacto.Telefono) Then
            Console.WriteLine("Datos inválidos.")
            Return
        End If
        contactos.Add(contacto)
        Console.WriteLine("Contacto agregado correctamente.")
    End Sub
    Public Sub MostrarTodos()
        Console.WriteLine("=== CONTACTOS ===")
        If contactos.Count = 0 Then
            Console.WriteLine("No hay contactos.")
        Else
            For Each c In contactos
                c.Mostrar()
            Next
        End If
    End Sub
    Public Function Buscar(id As Integer) As Contacto
        Return contactos.Find(Function(c) c.Id = id)
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
    Public Sub Editar(id As Integer, nombre As String, telefono As String)
        Dim c = Buscar(id)
        If c IsNot Nothing Then
            If String.IsNullOrWhiteSpace(nombre) OrElse String.IsNullOrWhiteSpace(telefono) Then
                Console.WriteLine("Datos inválidos.")
                Return
            End If
            c.Nombre = nombre
            c.Telefono = telefono
            Console.WriteLine("Contacto actualizado.")
        Else
            Console.WriteLine("No encontrado.")
        End If
    End Sub
End Class
Module agenda_mejorada_con_poo
    Sub Main(args As String())
        Dim agenda As New Agenda()
        Dim opcion As String
        Dim id As Integer = 1
        Do
            Console.Clear()
            MostrarMenu()
            opcion = Console.ReadLine()
            Select Case opcion
                Case "1"
                    Console.Write("Nombre: ")
                    Dim nombre = Console.ReadLine()
                    Console.Write("Teléfono: ")
                    Dim telefono = Console.ReadLine()
                    agenda.Agregar(New Contacto(id, nombre, telefono))
                    id += 1
                    Pausa()
                Case "2"
                    agenda.MostrarTodos()
                    Pausa()
                Case "3"
                    Console.Write("ID a buscar: ")
                    Dim idBuscar = Convert.ToInt32(Console.ReadLine())
                    Dim c = agenda.Buscar(idBuscar)
                    If c IsNot Nothing Then
                        c.Mostrar()
                    Else
                        Console.WriteLine("No encontrado.")
                    End If
                    Pausa()
                Case "4"
                    Console.Write("ID a eliminar: ")
                    Dim idEliminar = Convert.ToInt32(Console.ReadLine())
                    agenda.Eliminar(idEliminar)
                    Pausa()
                Case "5"
                    Console.Write("ID a editar: ")
                    Dim idEditar = Convert.ToInt32(Console.ReadLine())
                    Console.Write("Nuevo nombre: ")
                    Dim nuevoNombre = Console.ReadLine()
                    Console.Write("Nuevo teléfono: ")
                    Dim nuevoTelefono = Console.ReadLine()
                    agenda.Editar(idEditar, nuevoNombre, nuevoTelefono)
                    Pausa()
                Case "6"
                    Console.WriteLine("Saliendo...")
                Case Else
                    Console.WriteLine("Opción inválida")
                    Pausa()
            End Select
        Loop While opcion <> "6"
    End Sub
    Sub MostrarMenu()
        Console.WriteLine("=== AGENDA MEJORADA ===")
        Console.WriteLine("1. Agregar")
        Console.WriteLine("2. Mostrar")
        Console.WriteLine("3. Buscar")
        Console.WriteLine("4. Eliminar")
        Console.WriteLine("5. Editar")
        Console.WriteLine("6. Salir")
        Console.Write("Seleccione: ")
    End Sub
    Sub Pausa()
        Console.WriteLine("Presione una tecla para continuar...")
        Console.ReadKey()
    End Sub
End Module