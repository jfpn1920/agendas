Module agenda_funciones
    Private contactos As New List(Of String)
    Private rnd As New Random()
    Public Sub AgregarContacto(nombre As String, telefono As String)
        Dim id As Integer = rnd.Next(1000, 9999)
        Dim fecha As DateTime = DateTime.Now
        Dim registro As String = "ID: " & id &
                                " | Nombre: " & nombre &
                                " | Tel: " & telefono &
                                " | Fecha: " & fecha.ToString("dd/MM/yyyy HH:mm:ss")
        contactos.Add(registro)
    End Sub
    Public Function ObtenerContactos() As List(Of String)
        Return contactos
    End Function
End Module