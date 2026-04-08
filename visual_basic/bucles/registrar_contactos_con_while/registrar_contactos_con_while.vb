Imports System
Module registrar_contactos_con_while
    Sub Main(args As String())
        Dim cantidad As Integer
        Dim i As Integer = 0
        Console.Write("¿Cuántos contactos desea registrar?: ")
        cantidad = Convert.ToInt32(Console.ReadLine())
        Dim contactos(cantidad - 1) As String
        While i < cantidad
            Console.Write("Ingrese el nombre del contacto #" & (i + 1) & ": ")
            contactos(i) = Console.ReadLine()
            i += 1
        End While
        Console.WriteLine(vbCrLf & "=== CONTACTOS REGISTRADOS ===")
        i = 0
        While i < cantidad
            Console.WriteLine((i + 1) & ". " & contactos(i))
            i += 1
        End While
    End Sub
End Module