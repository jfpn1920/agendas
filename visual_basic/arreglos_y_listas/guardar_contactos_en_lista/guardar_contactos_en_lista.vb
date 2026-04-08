Imports System
Module guardar_contactos_en_lista
    Sub Main(args As String())
        Dim contactos As New List(Of String)
        Dim opcion As String = "s"
        Do
            Console.Write("Ingrese el nombre del contacto: ")
            Dim nombre As String = Console.ReadLine()
            If nombre <> "" Then
                contactos.Add(nombre)
                Console.WriteLine("Contacto guardado correctamente.")
            Else
                Console.WriteLine("No se permiten nombres vacíos.")
            End If
            Console.Write("¿Desea agregar otro contacto? (s/n): ")
            opcion = Console.ReadLine().ToLower()
        Loop While opcion = "s"
        Console.WriteLine(vbCrLf & "=== CONTACTOS GUARDADOS ===")
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