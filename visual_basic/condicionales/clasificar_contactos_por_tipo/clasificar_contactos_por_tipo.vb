Imports System
Module clasificar_contactos_por_tipo
    Sub Main(args As String())
        Dim nombres() As String = {"Juan", "Maria", "Pedro", "Ana"}
        Dim tipos() As String = {"familia", "trabajo", "familia", "trabajo"}
        Console.WriteLine("=== CONTACTOS DE FAMILIA ===")
        For i As Integer = 0 To nombres.Length - 1
            If tipos(i).ToLower() = "familia" Then
                Console.WriteLine(nombres(i))
            End If
        Next
        Console.WriteLine(vbCrLf & "=== CONTACTOS DE TRABAJO ===")
        For i As Integer = 0 To nombres.Length - 1
            If tipos(i).ToLower() = "trabajo" Then
                Console.WriteLine(nombres(i))
            End If
        Next
    End Sub
End Module