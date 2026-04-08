Module validaciones
    Public Function ValidarNombre(nombre As String) As Boolean
        If nombre.Trim() = "" Then
            Console.WriteLine("El nombre no puede estar vacío.")
            Return False
        End If
        Return True
    End Function
    Public Function ValidarTelefono(telefono As String) As Boolean
        If telefono.Trim() = "" Then
            Console.WriteLine("El teléfono no puede estar vacío.")
            Return False
        End If
        If Not IsNumeric(telefono) Then
            Console.WriteLine("El teléfono debe contener solo números.")
            Return False
        End If
        Return True
    End Function
End Module