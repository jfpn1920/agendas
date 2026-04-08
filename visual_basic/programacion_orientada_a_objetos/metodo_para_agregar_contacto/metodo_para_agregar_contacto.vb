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
    Public Sub MostrarContactos()
        If contactos.Count = 0 Then
            Console.WriteLine("No hay contactos.")
        Else
            For Each c In contactos
                Console.WriteLine("ID: " & c.Id & " | Nombre: " & c.Nombre & " | Tel: " & c.Telefono)
            Next
        End If
    End Sub
End Class
Module metodo_para_agregar_contacto
    Sub Main(args As String())
        Dim agenda As New Agenda()
        Dim contadorId As Integer = 1
        Dim opcion As String
        Do
            Console.Clear()
            Console.WriteLine("=== AGENDA ===")
            Console.WriteLine("1. Agregar contacto")
            Console.WriteLine("2. Mostrar contactos")
            Console.WriteLine("3. Salir")
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
                    Console.WriteLine("Contacto agregado correctamente.")
                    Console.ReadKey()
                Case "2"
                    agenda.MostrarContactos()
                    Console.ReadKey()
                Case "3"
                    Console.WriteLine("Saliendo...")
                Case Else
                    Console.WriteLine("Opción inválida")
                    Console.ReadKey()
            End Select
        Loop While opcion <> "3"
    End Sub
End Module