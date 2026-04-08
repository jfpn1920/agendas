Module agenda_funciones
    Dim contactos As New List(Of String)
    Dim rnd As New Random()
    Public Sub AgregarContacto(nombre As String, telefono As String)
        Dim id As Integer = rnd.Next(1000, 9999)
        Dim registro As String = "ID: " & id & " | " & nombre & " - " & telefono
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