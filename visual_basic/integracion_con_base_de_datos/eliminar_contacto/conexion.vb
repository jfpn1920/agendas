Imports MySql.Data.MySqlClient
Module conexion
    Public Function ObtenerConexion() As MySqlConnection
        Dim cadenaConexion As String = "server=localhost;user id=root;password=;database=eliminar_ese_contacto"
        Return New MySqlConnection(cadenaConexion)
    End Function
End Module