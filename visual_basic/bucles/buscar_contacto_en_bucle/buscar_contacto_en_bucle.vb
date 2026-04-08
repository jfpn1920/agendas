Imports System
Module buscar_contacto_en_bucle
    Sub Main(args As String())
        Dim contactos() As String = {"Juan", "Maria", "Pedro", "Ana"}
        Dim nombreBuscado As String
        Dim encontrado As Boolean = False
        Console.Write("Ingrese el nombre a buscar: ")
        nombreBuscado = Console.ReadLine()
        For i As Integer = 0 To contactos.Length - 1
            If contactos(i).ToLower() = nombreBuscado.ToLower() Then
                Console.WriteLine("Contacto encontrado en la posición: " & (i + 1))
                encontrado = True
                Exit For
            End If
        Next
        If encontrado = False Then
            Console.WriteLine("Contacto no encontrado ❌")
        End If
    End Sub
End Module