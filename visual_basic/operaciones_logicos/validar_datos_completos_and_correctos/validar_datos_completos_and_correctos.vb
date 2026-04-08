Imports System
Module validar_datos_completos_and_correctos
    Sub Main(args As String())
        Dim nombre As String
        Dim telefono As String
        Dim correo As String
        Console.Write("Ingrese el nombre: ")
        nombre = Console.ReadLine()
        Console.Write("Ingrese el teléfono: ")
        telefono = Console.ReadLine()
        Console.Write("Ingrese el correo: ")
        correo = Console.ReadLine()
        Dim nombreValido As Boolean = nombre.Trim() <> ""
        Dim telefonoValido As Boolean = telefono.Trim() <> ""
        Dim correoValido As Boolean = correo.Contains("@") And correo.Contains(".")
        If nombreValido And telefonoValido And correoValido Then
            Console.WriteLine("Datos completos y correctos ✅")
        Else
            Console.WriteLine("Error: Datos incompletos o incorrectos ❌")
        End If
    End Sub
End Module