Imports System
Module registrar_contactos_con_for
    Sub Main(args As String())
        Dim cantidad As Integer
        Console.Write("¿Cuántos contactos desea registrar?: ")
        cantidad = Convert.ToInt32(Console.ReadLine())
        Dim contactos(cantidad - 1) As String
        For i As Integer = 0 To cantidad - 1
            Console.Write("Ingrese el nombre del contacto #" & (i + 1) & ": ")
            contactos(i) = Console.ReadLine()
        Next
        Console.WriteLine(vbCrLf & "=== CONTACTOS REGISTRADOS ===")
        For i As Integer = 0 To cantidad - 1
            Console.WriteLine((i + 1) & ". " & contactos(i))
        Next
    End Sub
End Module