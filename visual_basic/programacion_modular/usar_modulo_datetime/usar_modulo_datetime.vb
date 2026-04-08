Imports usar_modulo_datetime.agenda_funciones
Module usar_modulo_datetime
    Sub Main()
        Dim opcion As Integer
        Do
            Console.Clear()
            Dim ahora As DateTime = DateTime.Now
            Console.WriteLine("Fecha actual: " & ahora.ToString("dd/MM/yyyy"))
            Console.WriteLine("Hora actual: " & ahora.ToString("HH:mm:ss"))
            Console.WriteLine("==============================")
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
                    Console.WriteLine("Contacto agregado con fecha y hora.")
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