Imports System
Imports MySql.Data.MySqlClient
Module eliminar_contacto
    Sub Main()
        Dim opcion As String = ""
        Do
            Console.Clear()
            Console.WriteLine("📒 MENÚ DE CONTACTOS")
            Console.WriteLine("1. ➕ Agregar contacto")
            Console.WriteLine("2. 📋 Mostrar contactos")
            Console.WriteLine("3. ❌ Eliminar contacto por ID")
            Console.WriteLine("4. 🚪 Salir")
            Console.Write("Selecciona una opción: ")
            opcion = Console.ReadLine()
            Select Case opcion
                Case "1"
                    AgregarContacto()
                Case "2"
                    MostrarContactos()
                Case "3"
                    EliminarContacto()
                Case "4"
                    Console.WriteLine("👋 Saliendo...")
                Case Else
                    Console.WriteLine("⚠ Opción no válida")
            End Select
            If opcion <> "4" Then
                Console.WriteLine(vbCrLf & "Presiona una tecla para continuar...")
                Console.ReadKey()
            End If
        Loop While opcion <> "4"
    End Sub
    Sub AgregarContacto()
        Console.Clear()
        Console.WriteLine("➕ AGREGAR CONTACTO")
        Console.Write("Nombre: ")
        Dim nombre As String = Console.ReadLine()
        Console.Write("Teléfono: ")
        Dim telefono As String = Console.ReadLine()
        Console.Write("Correo: ")
        Dim correo As String = Console.ReadLine()
        Try
            Using conexion As MySqlConnection = ObtenerConexion()
                conexion.Open()
                Dim query As String = "INSERT INTO contactos (nombre, telefono, correo) VALUES (@nombre, @telefono, @correo)"
                Using comando As New MySqlCommand(query, conexion)
                    comando.Parameters.AddWithValue("@nombre", nombre)
                    comando.Parameters.AddWithValue("@telefono", telefono)
                    comando.Parameters.AddWithValue("@correo", correo)
                    comando.ExecuteNonQuery()
                End Using
            End Using
            Console.WriteLine("✅ Contacto guardado correctamente")
        Catch ex As Exception
            Console.WriteLine("❌ Error: " & ex.Message)
        End Try
    End Sub
    Sub MostrarContactos()
        Console.Clear()
        Console.WriteLine("📋 LISTA DE CONTACTOS")
        Console.WriteLine("------------------------")
        Try
            Using conexion As MySqlConnection = ObtenerConexion()
                conexion.Open()
                Dim query As String = "SELECT * FROM contactos"
                Using comando As New MySqlCommand(query, conexion)
                    Using lector As MySqlDataReader = comando.ExecuteReader()
                        If lector.HasRows Then
                            While lector.Read()
                                Console.WriteLine("ID: " & lector("id"))
                                Console.WriteLine("Nombre: " & lector("nombre"))
                                Console.WriteLine("Teléfono: " & lector("telefono"))
                                Console.WriteLine("Correo: " & lector("correo"))
                                Console.WriteLine("------------------------")
                            End While
                        Else
                            Console.WriteLine("⚠ No hay contactos")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("❌ Error: " & ex.Message)
        End Try
    End Sub
    Sub EliminarContacto()
        Console.Clear()
        Console.WriteLine("❌ ELIMINAR CONTACTO")
        Console.Write("Ingresa el ID del contacto: ")
        Dim id As Integer = Convert.ToInt32(Console.ReadLine())
        Try
            Using conexion As MySqlConnection = ObtenerConexion()
                conexion.Open()
                Dim query As String = "DELETE FROM contactos WHERE id = @id"
                Using comando As New MySqlCommand(query, conexion)
                    comando.Parameters.AddWithValue("@id", id)
                    Dim filasAfectadas As Integer = comando.ExecuteNonQuery()
                    If filasAfectadas > 0 Then
                        Console.WriteLine("✅ Contacto eliminado correctamente")
                    Else
                        Console.WriteLine("⚠ No se encontró el contacto")
                    End If
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("❌ Error: " & ex.Message)
        End Try
    End Sub
End Module