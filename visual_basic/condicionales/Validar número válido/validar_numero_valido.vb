Imports System
Module validar_numero_valido
    Sub Main(args As String())
        Dim entrada As String
        Dim numero As Integer
        Console.Write("Ingrese un número: ")
        entrada = Console.ReadLine()
        If Integer.TryParse(entrada, numero) Then
            Console.WriteLine("Número válido: " & numero)
        Else
            Console.WriteLine("Error: No ingresaste un número válido")
        End If
    End Sub
End Module