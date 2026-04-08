Imports System
Module validar_contacto_activo_and_valido
    Sub Main(args As String())
        Dim nombre As String
        Dim telefono As String
        Dim activo As String
        Console.Write("Ingrese el nombre: ")
        nombre = Console.ReadLine()
        Console.Write("Ingrese el teléfono: ")
        telefono = Console.ReadLine()
        Console.Write("¿El contacto está activo? (si/no): ")
        activo = Console.ReadLine().ToLower()
        If nombre.Trim() <> "" And telefono.Trim() <> "" And activo = "si" Then
            Console.WriteLine("Contacto válido y activo ✅")
        Else
            Console.WriteLine("Contacto no válido o inactivo ❌")
        End If
    End Sub
End Module