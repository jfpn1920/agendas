Imports System
Module filtrar_contactos_por_categoria
    Structure Contacto
        Dim Nombre As String
        Dim Categoria As String
    End Structure
    Sub Main(args As String())
        Dim contactos As New List(Of Contacto) From {
            New Contacto With {.Nombre = "Juan", .Categoria = "Trabajo"},
            New Contacto With {.Nombre = "Maria", .Categoria = "Familia"},
            New Contacto With {.Nombre = "Carlos", .Categoria = "Amigos"},
            New Contacto With {.Nombre = "Ana", .Categoria = "Trabajo"}
        }
        Console.WriteLine("Ingrese la categoría:")
        Dim categoriaBuscar As String = Console.ReadLine()
        Dim encontrado As Boolean = False
        For Each c As Contacto In contactos
            If c.Categoria.ToLower() = categoriaBuscar.ToLower() Then
                Console.WriteLine("Nombre: " & c.Nombre)
                encontrado = True
            End If
        Next
        If Not encontrado Then
            Console.WriteLine("❌ No hay resultados")
        End If
        Console.ReadKey()
    End Sub
End Module