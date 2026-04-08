Imports System
Module mostrar_menu_interactivo
    Sub Main(args As String())
        Dim contactos As New List(Of String)
        Dim opcion As Integer = 0
        Do
            Console.Clear()
            Console.WriteLine("=== AGENDA DE CONTACTOS ===")
            Console.WriteLine("1. Ver contactos")
            Console.WriteLine("2. Agregar contacto")
            Console.WriteLine("3. Eliminar contacto")
            Console.WriteLine("4. Salir")
            Console.Write("Seleccione una opción: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                Case 1
                    Console.WriteLine(vbCrLf & "Lista de contactos:")
                    If contactos.Count = 0 Then
                        Console.WriteLine("No hay contactos.")
                    Else
                        For Each c In contactos
                            Console.WriteLine("- " & c)
                        Next
                    End If
                    Console.ReadKey()
                Case 2
                    Console.Write(vbCrLf & "Ingrese nombre del contacto: ")
                    Dim nuevo As String = Console.ReadLine()
                    contactos.Add(nuevo)
                    Console.WriteLine("Contacto agregado.")
                    Console.ReadKey()
                Case 3
                    Console.Write(vbCrLf & "Ingrese contacto a eliminar: ")
                    Dim eliminar As String = Console.ReadLine()

                    If contactos.Contains(eliminar) Then
                        contactos.Remove(eliminar)
                        Console.WriteLine("Contacto eliminado.")
                    Else
                        Console.WriteLine("El contacto no existe.")
                    End If
                    Console.ReadKey()
                Case 4
                    Console.WriteLine("Saliendo del programa...")
                Case Else
                    Console.WriteLine("Opción inválida.")
                    Console.ReadKey()
            End Select
        Loop While opcion <> 4
    End Sub
End Module