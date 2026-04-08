Imports MySql.Data.MySqlClient
Module conexion
    Public Function ObtenerConexion() As MySqlConnection
        Dim cadenaConexion As String = "server=localhost;user id=root;password=;database=guardar_mis_multiples_contactos"
        Dim conexion As New MySqlConnection(cadenaConexion)
        Return conexion
    End Function
End Module