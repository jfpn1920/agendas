Imports System
Imports MySql.Data.MySqlClient
Module guardar_un_contacto_basico
    Sub Main()
        Console.WriteLine("📒 GUARDAR CONTACTO EN BASE DE DATOS")
        Console.Write("Nombre: ")
        Dim nombre As String = Console.ReadLine()
        Console.Write("Teléfono: ")
        Dim telefono As String = Console.ReadLine()
        Console.Write("Correo: ")
        Dim correo As String = Console.ReadLine()
        Try
            Dim conexion As MySqlConnection = ObtenerConexion()
            conexion.Open()
            Dim query As String = "INSERT INTO contactos (nombre, telefono, correo) VALUES (@nombre, @telefono, @correo)"
            Dim comando As New MySqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@nombre", nombre)
            comando.Parameters.AddWithValue("@telefono", telefono)
            comando.Parameters.AddWithValue("@correo", correo)
            comando.ExecuteNonQuery()
            Console.WriteLine("✅ Contacto guardado correctamente")
            conexion.Close()
        Catch ex As Exception
            Console.WriteLine("❌ Error: " & ex.Message)
        End Try
        Console.ReadKey()
    End Sub
End Module