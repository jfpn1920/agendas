Imports AF = usar_alias_en_importaciones.agenda_funciones
Module UsarAliasEnImportaciones
    Sub Main()
        AF.MostrarMensaje()
        Console.WriteLine("Ingrese nombre:")
        Dim nombre As String = Console.ReadLine()
        Console.WriteLine("Ingrese teléfono:")
        Dim telefono As String = Console.ReadLine()
        AF.AgregarContacto(nombre, telefono)
        Console.WriteLine("Presione una tecla para salir...")
        Console.ReadKey()
    End Sub
End Module