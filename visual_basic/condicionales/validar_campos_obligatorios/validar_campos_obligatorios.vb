Imports System
Module validar_campos_obligatorios
    Sub Main(args As String())
        Dim nombre As String
        Dim telefono As String
        Console.Write("Ingrese el nombre: ")
        nombre = Console.ReadLine()
        Console.Write("Ingrese el teléfono: ")
        telefono = Console.ReadLine()
        If nombre = "" Or telefono = "" Then
            Console.WriteLine("Error: Todos los campos son obligatorios ⚠️")
        Else
            Console.WriteLine("Datos guardados correctamente ✅")
            Console.WriteLine("Nombre: " & nombre)
            Console.WriteLine("Teléfono: " & telefono)
        End If
    End Sub
End Module