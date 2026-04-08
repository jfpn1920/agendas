Imports System
Module validar_criterios_combinados
    Sub Main(args As String())
        Dim nombre As String
        Dim telefono As String
        Dim favorito As String
        Dim disponible As String
        Console.Write("Ingrese el nombre: ")
        nombre = Console.ReadLine()
        Console.Write("Ingrese el teléfono: ")
        telefono = Console.ReadLine()
        Console.Write("¿Es favorito? (si/no): ")
        favorito = Console.ReadLine().ToLower()
        Console.Write("¿Está disponible? (si/no): ")
        disponible = Console.ReadLine().ToLower()
        Dim datosCompletos As Boolean = nombre.Trim() <> "" And telefono.Trim() <> ""
        Dim esFavorito As Boolean = favorito = "si"
        Dim estaDisponible As Boolean = disponible = "si"
        If datosCompletos And (esFavorito Or estaDisponible) Then
            Console.WriteLine("Contacto cumple los criterios ✅")
        Else
            Console.WriteLine("Contacto no cumple los criterios ❌")
        End If
    End Sub
End Module