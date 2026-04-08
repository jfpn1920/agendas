Imports System
Module verificar_contacto_favorito
    Sub Main(args As String())
        Dim nombre As String
        Console.Write("Ingrese el nombre del contacto: ")
        nombre = Console.ReadLine()
        If nombre.ToLower() = "juan" Then
            Console.WriteLine("Este contacto es FAVORITO ⭐")
        Else
            Console.WriteLine("Este contacto no es favorito")
        End If
    End Sub
End Module