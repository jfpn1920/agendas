Imports MySql.Data.MySqlClient
Module conexion
    Public Function ObtenerConexion() As MySqlConnection
        Dim cadenaConexion As String = "server=localhost;user id=root;password=;database=buscar_el_contacto_por_nombre"
        Return New MySqlConnection(cadenaConexion)
    End Function
End Module