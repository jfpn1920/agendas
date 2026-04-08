Imports System
Module contar_contactos_registrados
    Sub Main(args As String())
        Dim contactos As New List(Of String)
        Dim opcion As String = "s"
        Do
            Console.Write("Ingrese un contacto: ")
            Dim nombre As String = Console.ReadLine()
            contactos.Add(nombre)
            Console.Write("¿Desea agregar otro contacto? (s/n): ")
            opcion = Console.ReadLine().ToLower()
        Loop While opcion = "s"
        Dim total As Integer = contactos.Count
        Console.WriteLine(vbCrLf & "Total de contactos registrados: " & total)
        Dim contador As Integer = 0
        For Each c In contactos
            contador += 1
        Next
        Console.WriteLine("Total contado con bucle: " & contador)
        Console.ReadKey()
    End Sub
End Module