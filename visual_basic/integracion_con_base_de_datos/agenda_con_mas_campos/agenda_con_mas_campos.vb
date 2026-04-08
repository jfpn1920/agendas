Imports System
Imports MySql.Data.MySqlClient
Module agenda_con_mas_campos
    Sub Main()
        Dim opcion As String = ""
        Do
            Console.Clear()
            Console.WriteLine("📒 AGENDA AVANZADA")
            Console.WriteLine("1. ➕ Agregar contacto")
            Console.WriteLine("2. 📋 Mostrar contactos")
            Console.WriteLine("3. ✏️ Actualizar contacto")
            Console.WriteLine("4. ❌ Eliminar contacto")
            Console.WriteLine("5. 🚪 Salir")
            Console.Write("Selecciona una opción: ")
            opcion = Console.ReadLine()
            Select Case opcion
                Case "1"
                    AgregarContacto()
                Case "2"
                    MostrarContactos()
                Case "3"
                    ActualizarContacto()
                Case "4"
                    EliminarContacto()
                Case "5"
                    Console.WriteLine("👋 Saliendo...")
                Case Else
                    Console.WriteLine("⚠ Opción no válida")
            End Select
            If opcion <> "5" Then
                Console.WriteLine(vbCrLf & "Presiona una tecla para continuar...")
                Console.ReadKey()
            End If
        Loop While opcion <> "5"
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
        Console.Write("Dirección: ")
        Dim direccion As String = Console.ReadLine()
        Console.Write("Ciudad: ")
        Dim ciudad As String = Console.ReadLine()
        Console.Write("Fecha de nacimiento (YYYY-MM-DD): ")
        Dim fecha As String = Console.ReadLine()
        Try
            Using conexion As MySqlConnection = ObtenerConexion()
                conexion.Open()
                Dim query As String = "INSERT INTO contactos (nombre, telefono, correo, direccion, ciudad, fecha_nacimiento) VALUES (@nombre, @telefono, @correo, @direccion, @ciudad, @fecha)"
                Using comando As New MySqlCommand(query, conexion)
                    comando.Parameters.AddWithValue("@nombre", nombre)
                    comando.Parameters.AddWithValue("@telefono", telefono)
                    comando.Parameters.AddWithValue("@correo", correo)
                    comando.Parameters.AddWithValue("@direccion", direccion)
                    comando.Parameters.AddWithValue("@ciudad", ciudad)
                    comando.Parameters.AddWithValue("@fecha", fecha)
                    comando.ExecuteNonQuery()
                End Using
            End Using
            Console.WriteLine("✅ Contacto agregado correctamente")
        Catch ex As Exception
            Console.WriteLine("❌ Error: " & ex.Message)
        End Try
    End Sub
    Sub MostrarContactos()
        Console.Clear()
        Console.WriteLine("📋 LISTA DE CONTACTOS")
        Console.WriteLine("--------------------------------------------------")
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
                                Console.WriteLine("Dirección: " & lector("direccion"))
                                Console.WriteLine("Ciudad: " & lector("ciudad"))
                                Console.WriteLine("Nacimiento: " & lector("fecha_nacimiento"))
                                Console.WriteLine("--------------------------------------------------")
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
    Sub ActualizarContacto()
        Console.Clear()
        Console.WriteLine("✏️ ACTUALIZAR CONTACTO")
        MostrarContactos()
        Console.Write("ID a actualizar: ")
        Dim id As Integer = Convert.ToInt32(Console.ReadLine())
        Console.Write("Nuevo nombre: ")
        Dim nombre As String = Console.ReadLine()
        Console.Write("Nuevo teléfono: ")
        Dim telefono As String = Console.ReadLine()
        Console.Write("Nuevo correo: ")
        Dim correo As String = Console.ReadLine()
        Console.Write("Nueva dirección: ")
        Dim direccion As String = Console.ReadLine()
        Console.Write("Nueva ciudad: ")
        Dim ciudad As String = Console.ReadLine()
        Console.Write("Nueva fecha (YYYY-MM-DD): ")
        Dim fecha As String = Console.ReadLine()
        Try
            Using conexion As MySqlConnection = ObtenerConexion()
                conexion.Open()
                Dim query As String = "UPDATE contactos SET nombre=@nombre, telefono=@telefono, correo=@correo, direccion=@direccion, ciudad=@ciudad, fecha_nacimiento=@fecha WHERE id=@id"
                Using comando As New MySqlCommand(query, conexion)
                    comando.Parameters.AddWithValue("@nombre", nombre)
                    comando.Parameters.AddWithValue("@telefono", telefono)
                    comando.Parameters.AddWithValue("@correo", correo)
                    comando.Parameters.AddWithValue("@direccion", direccion)
                    comando.Parameters.AddWithValue("@ciudad", ciudad)
                    comando.Parameters.AddWithValue("@fecha", fecha)
                    comando.Parameters.AddWithValue("@id", id)
                    Dim filas As Integer = comando.ExecuteNonQuery()
                    If filas > 0 Then
                        Console.WriteLine("✅ Actualizado correctamente")
                    Else
                        Console.WriteLine("⚠ No encontrado")
                    End If
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("❌ Error: " & ex.Message)
        End Try
    End Sub
    Sub EliminarContacto()
        Console.Clear()
        Console.WriteLine("❌ ELIMINAR CONTACTO")
        MostrarContactos()
        Console.Write("ID a eliminar: ")
        Dim id As Integer = Convert.ToInt32(Console.ReadLine())
        Try
            Using conexion As MySqlConnection = ObtenerConexion()
                conexion.Open()
                Dim query As String = "DELETE FROM contactos WHERE id=@id"
                Using comando As New MySqlCommand(query, conexion)
                    comando.Parameters.AddWithValue("@id", id)
                    Dim filas As Integer = comando.ExecuteNonQuery()
                    If filas > 0 Then
                        Console.WriteLine("✅ Eliminado correctamente")
                    Else
                        Console.WriteLine("⚠ No encontrado")
                    End If
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("❌ Error: " & ex.Message)
        End Try
    End Sub
End Module