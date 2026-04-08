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
        Console.WriteLine("=== LISTA DE CONTACTOS ===")
        If contactos.Count = 0 Then
            Console.WriteLine("No hay contactos registrados.")
        Else
            For Each c In contactos
                Console.WriteLine("ID: " & c.Id & " | Nombre: " & c.Nombre & " | Tel: " & c.Telefono)
            Next
        End If
    End Sub
End Class
Module metodo_para_mostrar_agenda
    Sub Main(args As String())
        Dim agenda As New Agenda()
        agenda.AgregarContacto(New Contacto(1, "Juan", "12345"))
        agenda.AgregarContacto(New Contacto(2, "María", "67890"))
        agenda.MostrarAgenda()
        Console.ReadKey()
    End Sub
End Module