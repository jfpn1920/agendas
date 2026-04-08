Module agenda_funciones
    Public Sub MostrarMensaje()
        Console.WriteLine("Bienvenido a la agenda modular")
    End Sub
    Public Sub AgregarContacto(nombre As String, telefono As String)
        Console.WriteLine("Contacto agregado:")
        Console.WriteLine("Nombre: " & nombre)
        Console.WriteLine("Teléfono: " & telefono)
    End Sub
End Module