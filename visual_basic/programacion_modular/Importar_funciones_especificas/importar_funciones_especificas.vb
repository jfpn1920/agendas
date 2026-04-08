Imports Importar_funciones_especificas.agenda_funciones
Module importar_funciones_especificas
    Sub Main()
        MostrarMensaje()
        Console.WriteLine("Ingrese nombre:")
        Dim nombre As String = Console.ReadLine()
        Console.WriteLine("Ingrese teléfono:")
        Dim telefono As String = Console.ReadLine()
        AgregarContacto(nombre, telefono)
        Console.WriteLine("Presione una tecla para salir...")
        Console.ReadKey()
    End Sub
End Module