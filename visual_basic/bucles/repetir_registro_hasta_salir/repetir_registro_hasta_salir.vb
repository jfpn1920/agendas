Imports System
Module repetir_registro_hasta_salir
    Sub Main(args As String())
        Dim contactos As New List(Of String)
        Dim opcion As String = "s"
        Do
            Console.Clear()
            Console.WriteLine("=== REGISTRO DE CONTACTOS ===")
            Console.Write("Ingrese el nombre del contacto: ")
            Dim nombre As String = Console.ReadLine()
            contactos.Add(nombre)
            Console.WriteLine("Contacto guardado correctamente.")
            Console.WriteLine()
            Console.Write("¿Desea registrar otro contacto? (s/n): ")
            opcion = Console.ReadLine().ToLower()
        Loop While opcion = "s"
        Console.Clear()
        Console.WriteLine("=== CONTACTOS REGISTRADOS ===")
        If contactos.Count = 0 Then
            Console.WriteLine("No hay contactos.")
        Else
            For Each c In contactos
                Console.WriteLine("- " & c)
            Next
        End If
        Console.ReadKey()
    End Sub
End Module