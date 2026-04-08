Imports System
Module buscar_contacto
    Sub Main(args As String())
        Dim contactos As New List(Of String) From {
            "Juan",
            "Maria",
            "Carlos",
            "Ana"
        }
        Console.WriteLine("=== BUSCAR CONTACTO ===")
        Console.WriteLine("Ingrese el nombre a buscar:")
        Dim nombreBuscar As String = Console.ReadLine()
        Dim encontrado As Boolean = False
        For Each contacto As String In contactos
            If contacto.ToLower() = nombreBuscar.ToLower() Then
                encontrado = True
                Exit For
            End If
        Next
        If encontrado Then
            Console.WriteLine("✅ Contacto encontrado")
        Else
            Console.WriteLine("❌ Contacto no encontrado")
        End If
        Console.ReadKey()
    End Sub
End Module