Imports System
Module funcion_para_validar_datos
    Sub Main(args As String())
        Console.WriteLine("Ingrese el nombre del contacto:")
        Dim nombre As String = Console.ReadLine()
        If ValidarDatos(nombre) Then
            Console.WriteLine("✅ Datos válidos")
        Else
            Console.WriteLine("❌ Datos inválidos")
        End If
        Console.ReadKey()
    End Sub
    Function ValidarDatos(ByVal dato As String) As Boolean
        If dato IsNot Nothing AndAlso dato.Trim() <> "" Then
            Return True
        Else
            Return False
        End If
    End Function
End Module