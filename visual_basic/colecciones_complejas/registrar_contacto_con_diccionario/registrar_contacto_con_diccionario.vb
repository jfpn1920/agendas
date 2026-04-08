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
Module registrar_contacto_con_diccionario
    Sub Main(args As String())
        Dim agenda As New Dictionary(Of Integer, Contacto)
        Dim opcion As String
        Dim id As Integer = 1
        Do
            Console.Clear()
            Console.WriteLine("=== AGENDA CON DICCIONARIO ===")
            Console.WriteLine("1. Registrar contacto")
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
                    Dim nuevo As New Contacto(id, nombre, telefono)
                    agenda.Add(id, nuevo)
                    id += 1
                    Console.WriteLine("Contacto registrado.")
                    Console.ReadKey()
                Case "2"
                    If agenda.Count = 0 Then
                        Console.WriteLine("No hay contactos.")
                    Else
                        For Each par In agenda
                            par.Value.Mostrar()
                        Next
                    End If
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