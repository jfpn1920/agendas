Imports System
Module validar_longitud_del_nombre
    Sub Main(args As String())
        Dim nombre As String
        Console.Write("Ingrese el nombre: ")
        nombre = Console.ReadLine()
        If nombre.Trim().Length >= 3 Then
            Console.WriteLine("Nombre válido ✅")
        Else
            Console.WriteLine("Error: El nombre debe tener al menos 3 caracteres ❌")
        End If
    End Sub
End Module