Imports modulo_random.agenda_funciones
Module modulo_random
    Sub Main()
        Dim opcion As Integer
        Do
            Console.Clear()
            Console.WriteLine("=== AGENDA CON ID ALEATORIO ===")
            Console.WriteLine("1. Agregar contacto")
            Console.WriteLine("2. Mostrar contactos")
            Console.WriteLine("3. Salir")
            Console.Write("Seleccione una opción: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                Case 1
                    Console.Write("Ingrese nombre: ")
                    Dim nombre As String = Console.ReadLine()
                    Console.Write("Ingrese teléfono: ")
                    Dim telefono As String = Console.ReadLine()
                    AgregarContacto(nombre, telefono)
                    Console.WriteLine("Contacto agregado con ID aleatorio.")
                    Console.ReadKey()
                Case 2
                    Console.WriteLine("Lista de contactos:")
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