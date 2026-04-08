Imports crear_modulo_de_validaciones.agenda_funciones
Imports crear_modulo_de_validaciones.validaciones
Module MenuAgenda
    Sub Main()
        Dim opcion As Integer
        Do
            Console.Clear()
            Console.WriteLine("=== AGENDA ===")
            Console.WriteLine("1. Agregar contacto")
            Console.WriteLine("2. Mostrar contactos")
            Console.WriteLine("3. Salir")
            Console.Write("Seleccione una opción: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                Case 1
                    Console.Write("Ingrese nombre: ")
                    Dim nombre As String = Console.ReadLine()
                    If Not ValidarNombre(nombre) Then
                        Console.ReadKey()
                        Continue Do
                    End If
                    Console.Write("Ingrese teléfono: ")
                    Dim telefono As String = Console.ReadLine()
                    If Not ValidarTelefono(telefono) Then
                        Console.ReadKey()
                        Continue Do
                    End If
                    AgregarContacto(nombre, telefono)
                    Console.WriteLine("Contacto agregado correctamente.")
                    Console.ReadKey()
                Case 2
                    MostrarContactos()
                    Console.ReadKey()
                Case 3
                    Console.WriteLine("Saliendo...")
                Case Else
                    Console.WriteLine("Opción inválida")
                    Console.ReadKey()
            End Select
        Loop While opcion <> 3
    End Sub
End Module