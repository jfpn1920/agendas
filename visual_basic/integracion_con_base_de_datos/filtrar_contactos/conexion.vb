Imports MySql.Data.MySqlClient
Module conexion
    Public Function ObtenerConexion() As MySqlConnection
        Dim cadena As String = "server=localhost;user=root;password=;database=filtrar_contactos;"
        Return New MySqlConnection(cadena)
    End Function
End Module