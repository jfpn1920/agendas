Module agenda_funciones
    Dim contactos As New List(Of String)
    Public Sub AgregarContacto(nombre As String, telefono As String)
        contactos.Add(nombre & " - " & telefono)
    End Sub
    Public Sub MostrarContactos()
        Console.WriteLine("Lista de contactos:")
        If contactos.Count = 0 Then
            Console.WriteLine("No hay contactos registrados.")
        Else
            For Each contacto In contactos
                Console.WriteLine(contacto)
            Next
        End If
    End Sub
End Module