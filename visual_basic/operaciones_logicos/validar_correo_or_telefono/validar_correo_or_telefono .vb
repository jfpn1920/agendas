Imports System
Module validar_correo_or_telefono
    Sub Main(args As String())
        Dim correo As String
        Dim telefono As String
        Console.Write("Ingrese el correo: ")
        correo = Console.ReadLine()
        Console.Write("Ingrese el teléfono: ")
        telefono = Console.ReadLine()
        If correo.Trim() <> "" Or telefono.Trim() <> "" Then
            Console.WriteLine("Dato válido ✅ (al menos uno fue ingresado)")
        Else
            Console.WriteLine("Error: Debe ingresar correo o teléfono ❌")
        End If
    End Sub
End Module