Imports modulo_de_utilidades.agenda_funciones
Imports modulo_de_utilidades.utilidades
Module MenuAgenda
    Sub Main()
        Dim opcion As Integer
        Do
            LimpiarPantalla()
            MostrarTitulo("AGENDA")
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
                    Console.WriteLine("Contacto agregado correctamente.")
                    Pausa()
                Case 2
                    MostrarTitulo("LISTA DE CONTACTOS")
                    MostrarContactos()
                    Pausa()
                Case 3
                    Console.WriteLine("Saliendo...")
                Case Else
                    Console.WriteLine("Opción inválida")
                    Pausa()
            End Select
        Loop While opcion <> 3
    End Sub
End Module