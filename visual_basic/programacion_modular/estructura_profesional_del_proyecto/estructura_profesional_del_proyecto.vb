Imports estructura_profesional_del_proyecto.agenda_funciones
Module estructura_profesional_del_proyecto
    Sub Main()
        EjecutarMenu()
    End Sub
    Sub EjecutarMenu()
        Dim opcion As Integer
        Do
            MostrarMenu()
            opcion = LeerOpcion()
            Select Case opcion
                Case 1
                    Agregar()
                Case 2
                    Mostrar()
                Case 3
                    Salir()
                Case Else
                    Mensaje("Opción inválida")
            End Select
        Loop While opcion <> 3
    End Sub
    Sub MostrarMenu()
        Console.Clear()
        Console.WriteLine("===== AGENDA PROFESIONAL =====")
        Console.WriteLine("1. Agregar contacto")
        Console.WriteLine("2. Mostrar contactos")
        Console.WriteLine("3. Salir")
        Console.Write("Seleccione: ")
    End Sub
    Function LeerOpcion() As Integer
        Return Convert.ToInt32(Console.ReadLine())
    End Function
    Sub Agregar()
        Console.Write("Nombre: ")
        Dim nombre As String = Console.ReadLine()
        Console.Write("Teléfono: ")
        Dim telefono As String = Console.ReadLine()
        agenda_funciones.AgregarContacto(nombre, telefono)
        Mensaje("Contacto agregado correctamente")
    End Sub
    Sub Mostrar()
        Dim lista = agenda_funciones.ObtenerContactos()
        If lista.Count = 0 Then
            Console.WriteLine("No hay contactos.")
        Else
            For Each contacto In lista
                Console.WriteLine(contacto)
            Next
        End If
        Console.ReadKey()
    End Sub
    Sub Salir()
        Console.WriteLine("Saliendo del sistema...")
    End Sub
    Sub Mensaje(texto As String)
        Console.WriteLine(texto)
        Console.ReadKey()
    End Sub
End Module