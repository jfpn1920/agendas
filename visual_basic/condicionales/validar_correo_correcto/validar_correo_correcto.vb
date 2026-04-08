Imports System
Module validar_correo_correcto
    Sub Main(args As String())
        Dim correo As String
        Console.Write("Ingrese el correo electrónico: ")
        correo = Console.ReadLine()
        If correo.Contains("@") And correo.Contains(".") Then
            Console.WriteLine("Correo válido ✅")
        Else
            Console.WriteLine("Correo inválido ❌")
        End If
    End Sub
End Module