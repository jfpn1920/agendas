Imports System
Module validar_nombre_and_telefono
    Sub Main(args As String())
        Dim nombre As String
        Dim telefono As String
        Console.Write("Ingrese el nombre: ")
        nombre = Console.ReadLine()
        Console.Write("Ingrese el teléfono: ")
        telefono = Console.ReadLine()
        If nombre.Trim() <> "" And telefono.Trim() <> "" Then
            Console.WriteLine("Datos válidos ✅")
            Console.WriteLine("Nombre: " & nombre)
            Console.WriteLine("Teléfono: " & telefono)
        Else
            Console.WriteLine("Error: Debe completar nombre y teléfono ❌")
        End If
    End Sub
End Module