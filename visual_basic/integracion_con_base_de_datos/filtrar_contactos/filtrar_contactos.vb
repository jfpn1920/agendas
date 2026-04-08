Imports System
Imports MySql.Data.MySqlClient
Module filtrar_contactos
    Sub Main()
        Dim opcion As String = ""
        Do
            Console.Clear()
            Console.WriteLine("📒 SISTEMA DE CONTACTOS (FILTROS)")
            Console.WriteLine("1. ➕ Agregar contacto")
            Console.WriteLine("2. 🔍 Filtrar por ciudad")
            Console.WriteLine("3. 📅 Filtrar por rango de fechas")
            Console.WriteLine("4. 🔎 Filtrar por nombre y ciudad")
            Console.WriteLine("5. 📋 Mostrar todos")
            Console.WriteLine("6. 🚪 Salir")
            Console.Write("Seleccione: ")
            opcion = Console.ReadLine()
            Select Case opcion
                Case "1"
                    AgregarContacto()
                Case "2"
                    FiltrarPorCiudad()
                Case "3"
                    FiltrarPorFechas()
                Case "4"
                    FiltrarNombreCiudad()
                Case "5"
                    MostrarTodos()
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
        Console.WriteLine("➕ AGREGAR CONTACTO")
        Console.Write("Nombre: ")
        Dim nombre = Console.ReadLine()
        Console.Write("Apellido: ")
        Dim apellido = Console.ReadLine()
        Console.Write("Teléfono: ")
        Dim telefono = Console.ReadLine()
        Console.Write("Correo: ")
        Dim correo = Console.ReadLine()
        Console.Write("Ciudad: ")
        Dim ciudad = Console.ReadLine()
        Console.Write("Fecha nacimiento (YYYY-MM-DD): ")
        Dim fecha = Console.ReadLine()
        Try
            Using con = ObtenerConexion()
                con.Open()
                Dim query = "INSERT INTO contactos (nombre, apellido, telefono, correo, ciudad, fecha_nacimiento) VALUES (@n, @a, @t, @c, @ci, @f)"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@n", nombre)
                    cmd.Parameters.AddWithValue("@a", apellido)
                    cmd.Parameters.AddWithValue("@t", telefono)
                    cmd.Parameters.AddWithValue("@c", correo)
                    cmd.Parameters.AddWithValue("@ci", ciudad)
                    cmd.Parameters.AddWithValue("@f", fecha)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Console.WriteLine("✅ Contacto agregado")
        Catch ex As Exception
            Console.WriteLine("❌ Error: " & ex.Message)
        End Try
    End Sub
    Sub FiltrarPorCiudad()
        Console.Write("Ciudad: ")
        Dim ciudad = Console.ReadLine()
        Dim query = "SELECT * FROM contactos WHERE ciudad = @ciudad"
        EjecutarConsulta(query, Sub(cmd) cmd.Parameters.AddWithValue("@ciudad", ciudad))
    End Sub
    Sub FiltrarPorFechas()
        Console.Write("Fecha inicio (YYYY-MM-DD): ")
        Dim f1 = Console.ReadLine()
        Console.Write("Fecha fin (YYYY-MM-DD): ")
        Dim f2 = Console.ReadLine()
        Dim query = "SELECT * FROM contactos WHERE fecha_nacimiento BETWEEN @f1 AND @f2"
        EjecutarConsulta(query, Sub(cmd)
                                    cmd.Parameters.AddWithValue("@f1", f1)
                                    cmd.Parameters.AddWithValue("@f2", f2)
                                End Sub)
    End Sub
    Sub FiltrarNombreCiudad()
        Console.Write("Nombre: ")
        Dim nombre = Console.ReadLine()
        Console.Write("Ciudad: ")
        Dim ciudad = Console.ReadLine()
        Dim query = "SELECT * FROM contactos WHERE nombre LIKE @nombre AND ciudad = @ciudad"
        EjecutarConsulta(query, Sub(cmd)
                                    cmd.Parameters.AddWithValue("@nombre", "%" & nombre & "%")
                                    cmd.Parameters.AddWithValue("@ciudad", ciudad)
                                End Sub)
    End Sub
    Sub MostrarTodos()
        Dim query = "SELECT * FROM contactos"
        EjecutarConsulta(query, Nothing)
    End Sub
    Sub EjecutarConsulta(query As String, configurar As Action(Of MySqlCommand))
        Try
            Using con = ObtenerConexion()
                con.Open()
                Using cmd As New MySqlCommand(query, con)
                    If configurar IsNot Nothing Then
                        configurar(cmd)
                    End If
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            While dr.Read()
                                Console.WriteLine($"{dr("id")} - {dr("nombre")} {dr("apellido")} - {dr("ciudad")} - {dr("fecha_nacimiento")}")
                            End While
                        Else
                            Console.WriteLine("⚠ No hay resultados")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("❌ Error: " & ex.Message)
        End Try
    End Sub
End Module