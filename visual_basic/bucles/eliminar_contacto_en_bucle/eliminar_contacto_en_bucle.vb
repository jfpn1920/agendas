Imports System
Module eliminar_contacto_en_bucle
    Sub Main(args As String())
        Dim contactos As New List(Of String) From {
            "Juan", "Maria", "Pedro", "Luisa"
        }
        Dim opcion As String = ""
        Do
            Console.Clear()
            Console.WriteLine("=== AGENDA DE CONTACTOS ===")
            Console.WriteLine("Lista de contactos:")
            For Each contacto In contactos
                Console.WriteLine("- " & contacto)
            Next
            Console.WriteLine()
            Console.Write("Ingrese el nombre del contacto a eliminar: ")
            Dim nombre As String = Console.ReadLine()
            If contactos.Contains(nombre) Then
                contactos.Remove(nombre)
                Console.WriteLine("Contacto eliminado correctamente.")
            Else
                Console.WriteLine("El contacto no existe.")
            End If
            Console.WriteLine()
            Console.Write("¿Desea eliminar otro contacto? (s/n): ")
            opcion = Console.ReadLine().ToLower()
        Loop While opcion = "s"
        Console.WriteLine("Programa finalizado.")
        Console.ReadKey()
    End Sub
End Module