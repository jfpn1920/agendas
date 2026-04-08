Imports System
Module mostrar_agenda_en_bucle
    Sub Main(args As String())
        Dim contactos() As String = {"Juan", "Maria", "Pedro", "Ana"}
        Console.WriteLine("=== AGENDA DE CONTACTOS ===")
        For i As Integer = 0 To contactos.Length - 1
            Console.WriteLine((i + 1) & ". " & contactos(i))
        Next
    End Sub
End Module