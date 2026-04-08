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
End Class
Module clase_agenda
    Sub Main(args As String())
        Dim agenda As New Agenda()
        Dim c1 As New Contacto(1, "Juan", "12345")
        Dim c2 As New Contacto(2, "María", "67890")
        agenda.Agregar(c1)
        agenda.Agregar(c2)
        agenda.MostrarTodos()
        Console.ReadKey()
    End Sub
End Module