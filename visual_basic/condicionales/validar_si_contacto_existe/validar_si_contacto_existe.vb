Imports System
Module validar_si_contacto_existe
    Sub Main(args As String())
        Dim nombre As String = "Juan Pérez"
        If nombre <> "" Then
            Console.WriteLine("El contacto existe: " & nombre)
        Else
            Console.WriteLine("El contacto no existe")
        End If
        Console.ReadLine()
    End Sub
End Module