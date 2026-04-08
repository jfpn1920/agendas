Module utilidades
    Public Sub LimpiarPantalla()
        Console.Clear()
    End Sub
    Public Sub Pausa()
        Console.WriteLine("Presione una tecla para continuar...")
        Console.ReadKey()
    End Sub
    Public Sub MostrarTitulo(titulo As String)
        Console.WriteLine("===================================")
        Console.WriteLine(titulo)
        Console.WriteLine("===================================")
    End Sub
End Module