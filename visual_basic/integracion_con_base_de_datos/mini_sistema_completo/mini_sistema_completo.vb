Imports System
Imports MySql.Data.MySqlClient
Module mini_sistema_completo
    Sub Main()
        Dim opcion As String = ""
        Do
            Console.Clear()
            Console.WriteLine("📒 MINI SISTEMA DE CONTACTOS")
            Console.WriteLine("1. ➕ Agregar contacto")
            Console.WriteLine("2. 📋 Mostrar contactos")
            Console.WriteLine("3. 🔍 Buscar contacto")
            Console.WriteLine("4. 📊 Ordenar contactos")
            Console.WriteLine("5. ❌ Eliminar contacto")
            Console.WriteLine("6. 🚪 Salir")
            Console.Write("Seleccione: ")
            opcion = Console.ReadLine()
            Select Case opcion
                Case "1"
                    AgregarContacto()
                Case "2"
                    MostrarContactos()
                Case "3"
                    BuscarContacto()
                Case "4"
                    MenuOrdenar()
                Case "5"
                    EliminarContacto()
                Case "6"
                    Console.WriteLine("👋 Saliendo...")
                Case Else
                    Console.WriteLine("⚠ Opción inválida")
            End Select
            If opcion <> "6" Then
                Console.WriteLine(vbCrLf & "Presiona una tecla...")
                Console.ReadKey()
            End If
        Loop While opcion <> "6"
    End Sub
    Sub AgregarContacto()
        Console.Clear()
        Console.Write("Nombre: ")
        Dim nombre = Console.ReadLine()
        Console.Write("Apellido: ")
        Dim apellido = Console.ReadLine()
        Console.Write("Teléfono: ")
        Dim telefono = Console.ReadLine()
        Console.Write("Correo: ")
        Dim correo = Console.ReadLine()
        Console.Write("Dirección: ")
        Dim direccion = Console.ReadLine()
        Console.Write("Ciudad: ")
        Dim ciudad = Console.ReadLine()
        Console.Write("Fecha (YYYY-MM-DD): ")
        Dim fecha = Console.ReadLine()
        Try
            Using con = ObtenerConexion()
                con.Open()
                Dim query = "INSERT INTO contactos (nombre, apellido, telefono, correo, direccion, ciudad, fecha_nacimiento) VALUES (@n, @a, @t, @c, @d, @ci, @f)"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@n", nombre)
                    cmd.Parameters.AddWithValue("@a", apellido)
                    cmd.Parameters.AddWithValue("@t", telefono)
                    cmd.Parameters.AddWithValue("@c", correo)
                    cmd.Parameters.AddWithValue("@d", direccion)
                    cmd.Parameters.AddWithValue("@ci", ciudad)
                    cmd.Parameters.AddWithValue("@f", fecha)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Console.WriteLine("✅ Agregado")
        Catch ex As Exception
            Console.WriteLine("❌ Error: " & ex.Message)
        End Try
    End Sub
    Sub MostrarContactos()
        Console.Clear()
        Try
            Using con = ObtenerConexion()
                con.Open()
                Dim query = "SELECT * FROM contactos"
                Using cmd As New MySqlCommand(query, con)
                    Using dr = cmd.ExecuteReader()
                        While dr.Read()
                            Console.WriteLine($"{dr("id")} - {dr("nombre")} {dr("apellido")} - {dr("telefono")} - {dr("ciudad")}")
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("❌ " & ex.Message)
        End Try
    End Sub
    Sub BuscarContacto()
        Console.Clear()
        Console.Write("Nombre a buscar: ")
        Dim nombre = Console.ReadLine()
        Try
            Using con = ObtenerConexion()
                con.Open()
                Dim query = "SELECT * FROM contactos WHERE nombre LIKE @nombre"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@nombre", "%" & nombre & "%")
                    Using dr = cmd.ExecuteReader()
                        While dr.Read()
                            Console.WriteLine($"{dr("id")} - {dr("nombre")} {dr("apellido")} - {dr("telefono")}")
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("❌ " & ex.Message)
        End Try
    End Sub
    Sub MenuOrdenar()
        Console.Clear()
        Console.WriteLine("1. Nombre ASC")
        Console.WriteLine("2. Nombre DESC")
        Console.WriteLine("3. Ciudad")
        Dim op = Console.ReadLine()
        Dim orden As String = "nombre ASC"
        If op = "2" Then orden = "nombre DESC"
        If op = "3" Then orden = "ciudad ASC"
        Try
            Using con = ObtenerConexion()
                con.Open()
                Dim query = "SELECT * FROM contactos ORDER BY " & orden
                Using cmd As New MySqlCommand(query, con)
                    Using dr = cmd.ExecuteReader()
                        While dr.Read()
                            Console.WriteLine($"{dr("nombre")} - {dr("ciudad")}")
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("❌ " & ex.Message)
        End Try
    End Sub
    Sub EliminarContacto()
        Console.Clear()
        Console.Write("ID a eliminar: ")
        Dim id = Console.ReadLine()
        Try
            Using con = ObtenerConexion()
                con.Open()
                Dim query = "DELETE FROM contactos WHERE id=@id"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Console.WriteLine("✅ Eliminado")
        Catch ex As Exception
            Console.WriteLine("❌ " & ex.Message)
        End Try
    End Sub
End Module