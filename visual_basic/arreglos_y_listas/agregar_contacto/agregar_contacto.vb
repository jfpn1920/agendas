Imports System
Module agregar_contacto
    Sub Main(args As String())
        Dim contactos As New List(Of String) From {"Juan", "Maria"}
        Console.WriteLine("=== AGREGAR CONTACTO ===")
        Console.Write("Ingrese el nombre del nuevo contacto: ")
        Dim nuevo As String = Console.ReadLine()
        If nuevo <> "" Then
            contactos.Add(nuevo)
            Console.WriteLine("Contacto agregado correctamente.")
        Else
            Console.WriteLine("No se puede agregar un nombre vacío.")
        End If
        Console.WriteLine(vbCrLf & "=== LISTA DE CONTACTOS ===")
        For Each c In contactos
            Console.WriteLine("- " & c)
        Next
        Console.ReadKey()
    End Sub
End Module