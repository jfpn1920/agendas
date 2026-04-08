Imports System
Module eliminar_contacto
    Sub Main(args As String())
        Dim contactos As New List(Of String) From {"Juan", "Maria", "Pedro"}
        Console.WriteLine("=== ELIMINAR CONTACTO ===")
        Console.WriteLine("Lista de contactos:")
        For Each c In contactos
            Console.WriteLine("- " & c)
        Next
        Console.Write(vbCrLf & "Ingrese el nombre del contacto a eliminar: ")
        Dim nombre As String = Console.ReadLine()
        If contactos.Contains(nombre) Then
            contactos.Remove(nombre)
            Console.WriteLine("Contacto eliminado correctamente.")
        Else
            Console.WriteLine("El contacto no existe.")
        End If
        Console.WriteLine(vbCrLf & "=== LISTA ACTUALIZADA ===")
        For Each c In contactos
            Console.WriteLine("- " & c)
        Next
        Console.ReadKey()
    End Sub
End Module