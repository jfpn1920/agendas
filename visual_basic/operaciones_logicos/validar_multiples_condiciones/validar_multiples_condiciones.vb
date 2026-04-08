Imports System
Module validar_multiples_condiciones
    Sub Main(args As String())
        Dim nombre As String
        Dim telefono As String
        Dim correo As String
        Dim favorito As String
        Console.Write("Ingrese el nombre: ")
        nombre = Console.ReadLine()
        Console.Write("Ingrese el teléfono: ")
        telefono = Console.ReadLine()
        Console.Write("Ingrese el correo: ")
        correo = Console.ReadLine()
        Console.Write("¿Es favorito? (si/no): ")
        favorito = Console.ReadLine().ToLower()
        Dim datosCompletos As Boolean = nombre.Trim() <> "" And telefono.Trim() <> ""
        Dim correoValido As Boolean = correo.Contains("@") And correo.Contains(".")
        Dim esFavorito As Boolean = favorito = "si"
        If datosCompletos And (correoValido Or esFavorito) Then
            Console.WriteLine("Contacto válido ✅")
        Else
            Console.WriteLine("Contacto no cumple las condiciones ❌")
        End If
    End Sub
End Module