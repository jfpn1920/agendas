Module agenda_funciones
    Dim contactos As New List(Of String)
    Public Sub AgregarContacto(nombre As String, telefono As String)
        Dim fecha As DateTime = DateTime.Now
        Dim registro As String = nombre & " - " & telefono & " - " & fecha.ToString("dd/MM/yyyy HH:mm:ss")
        contactos.Add(registro)
    End Sub
    Public Sub MostrarContactos()
        If contactos.Count = 0 Then
            Console.WriteLine("No hay contactos registrados.")
        Else
            For Each contacto In contactos
                Console.WriteLine(contacto)
            Next
        End If
    End Sub
End Module