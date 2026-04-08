Imports System
Public Class contacto
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Telefono As String
    Public Sub New(id As Integer, nombre As String, telefono As String)
        Me.Id = id
        Me.Nombre = nombre
        Me.Telefono = telefono
    End Sub
    Public Sub Mostrar()
        Console.WriteLine("ID: " & Id)
        Console.WriteLine("Nombre: " & Nombre)
        Console.WriteLine("Teléfono: " & Telefono)
    End Sub
End Class
Module clase_contacto
    Sub Main(args As String())
        Dim contacto1 As New contacto(1, "Juan", "12345")
        contacto1.Mostrar()
        Console.ReadKey()
    End Sub
End Module