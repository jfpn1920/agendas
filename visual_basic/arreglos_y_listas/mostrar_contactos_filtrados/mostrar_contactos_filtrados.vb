Imports System
Module mostrar_contactos_filtrados
    Sub Main(args As String())
        Dim nombres() As String = {"Juan", "Maria", "Carlos", "Ana"}
        Dim categorias() As String = {"Trabajo", "Familia", "Trabajo", "Amigos"}
        Console.WriteLine("=== FILTRAR CONTACTOS ===")
        Console.WriteLine("Ingrese la categoría:")
        Dim categoriaBuscar As String = Console.ReadLine()
        Console.WriteLine(vbCrLf & "=== RESULTADOS ===")
        For i As Integer = 0 To nombres.Length - 1
            If categorias(i).ToLower() = categoriaBuscar.ToLower() Then
                Console.WriteLine(nombres(i))
            End If
        Next
        Console.ReadKey()
    End Sub
End Module