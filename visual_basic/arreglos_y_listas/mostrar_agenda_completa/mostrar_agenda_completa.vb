Imports System
Module mostrar_agenda_completa
    Sub Main(args As String())
        Dim nombres As New List(Of String) From {
            "Juan", "Maria", "Carlos", "Ana"
        }
        Dim categorias As New List(Of String) From {
            "Trabajo", "Familia", "Amigos", "Trabajo"
        }
        Console.WriteLine("=== AGENDA COMPLETA ===")
        For i As Integer = 0 To nombres.Count - 1
            Console.WriteLine("Nombre: " & nombres(i))
            Console.WriteLine("Categoría: " & categorias(i))
            Console.WriteLine("----------------------")
        Next
        Console.ReadKey()
    End Sub
End Module