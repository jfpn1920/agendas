Imports System
Module funcion_para_buscar_contacto
    Sub Main(args As String())
        Dim contactos As New List(Of String) From {
            "Juan", "Maria", "Carlos", "Ana"
        }
        BuscarContacto(contactos)
        Console.ReadKey()
    End Sub
    Sub BuscarContacto(ByVal lista As List(Of String))
        Console.WriteLine("Ingrese el nombre del contacto a buscar:")
        Dim nombre As String = Console.ReadLine()
        Dim encontrado As Boolean = False
        For Each contacto As String In lista
            If contacto.ToLower() = nombre.ToLower() Then
                encontrado = True
                Exit For
            End If
        Next
        If encontrado Then
            Console.WriteLine("✅ Contacto encontrado")
        Else
            Console.WriteLine("❌ Contacto no encontrado")
        End If
    End Sub
End Module