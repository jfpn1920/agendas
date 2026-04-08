Imports System
Module funcion_para_filtrar_contactos
    Sub Main(args As String())
        Dim nombres As New List(Of String) From {"Juan", "Maria", "Carlos", "Ana"}
        Dim categorias As New List(Of String) From {"Trabajo", "Familia", "Amigos", "Trabajo"}
        Console.WriteLine("Ingrese la categoría a filtrar:")
        Dim categoriaBuscar As String = Console.ReadLine()
        FiltrarContactos(nombres, categorias, categoriaBuscar)
        Console.ReadKey()
    End Sub
    Sub FiltrarContactos(ByVal nombres As List(Of String), ByVal categorias As List(Of String), ByVal categoria As String)
        Console.WriteLine(vbCrLf & "=== RESULTADOS FILTRADOS ===")
        Dim encontrado As Boolean = False
        For i As Integer = 0 To nombres.Count - 1
            If categorias(i).ToLower() = categoria.ToLower() Then
                Console.WriteLine(nombres(i))
                encontrado = True
            End If
        Next
        If Not encontrado Then
            Console.WriteLine("❌ No se encontraron contactos en esa categoría")
        End If
    End Sub
End Module