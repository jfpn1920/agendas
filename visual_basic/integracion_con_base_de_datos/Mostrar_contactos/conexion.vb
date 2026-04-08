Imports MySql.Data.MySqlClient
Module conexion
    Public Function ObtenerConexion() As MySqlConnection
        Dim cadenaConexion As String = "server=localhost;user id=root;password=;database=mostrar_esos_contactos"
        Return New MySqlConnection(cadenaConexion)
    End Function
End Module