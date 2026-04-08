Imports System
Imports MySql.Data.MySqlClient
Module ordenar_contactos
    Sub Main()
        Dim opcion As String = ""
        Do
            Console.Clear()
            Console.WriteLine("📒 AGENDA CON ORDENAMIENTO")
            Console.WriteLine("1. ➕ Agregar contacto")
            Console.WriteLine("2. 📋 Ver contactos ordenados")
            Console.WriteLine("3. 🚪 Salir")
            Console.Write("Seleccione una opción: ")
            opcion = Console.ReadLine()
            Select Case opcion
                Case "1"
                    AgregarContacto()
                Case "2"
                    MenuOrdenamiento()
                Case "3"
                    Console.WriteLine("👋 Saliendo...")
                Case Else
                    Console.WriteLine("⚠ Opción inválida")
            End Select
            If opcion <> "3" Then
                Console.WriteLine(vbCrLf & "Presiona una tecla...")
                Console.ReadKey()
            End If
        Loop While opcion <> "3"
    End Sub
    Sub AgregarContacto()
        Console.Clear()
        Console.WriteLine("➕ AGREGAR CONTACTO")
        Console.Write("Nombre: ")
        Dim nombre As String = Console.ReadLine()
        Console.Write("Apellido: ")
        Dim apellido As String = Console.ReadLine()
        Console.Write("Teléfono: ")
        Dim telefono As String = Console.ReadLine()
        Console.Write("Correo: ")
        Dim correo As String = Console.ReadLine()
        Console.Write("Ciudad: ")
        Dim ciudad As String = Console.ReadLine()
        Console.Write("Fecha nacimiento (YYYY-MM-DD): ")
        Dim fecha As String = Console.ReadLine()
        Try
            Using conexion As MySqlConnection = ObtenerConexion()
                conexion.Open()
                Dim query As String = "INSERT INTO contactos (nombre, apellido, telefono, correo, ciudad, fecha_nacimiento) VALUES (@nombre, @apellido, @telefono, @correo, @ciudad, @fecha)"
                Using comando As New MySqlCommand(query, conexion)
                    comando.Parameters.AddWithValue("@nombre", nombre)
                    comando.Parameters.AddWithValue("@apellido", apellido)
                    comando.Parameters.AddWithValue("@telefono", telefono)
                    comando.Parameters.AddWithValue("@correo", correo)
                    comando.Parameters.AddWithValue("@ciudad", ciudad)
                    comando.Parameters.AddWithValue("@fecha", fecha)
                    comando.ExecuteNonQuery()
                End Using
            End Using
            Console.WriteLine("✅ Contacto agregado")
        Catch ex As Exception
            Console.WriteLine("❌ Error: " & ex.Message)
        End Try
    End Sub
    Sub MenuOrdenamiento()
        Dim opcion As String = ""
        Do
            Console.Clear()
            Console.WriteLine("📋 ORDENAR CONTACTOS")
            Console.WriteLine("1. Nombre (A-Z)")
            Console.WriteLine("2. Nombre (Z-A)")
            Console.WriteLine("3. Fecha de nacimiento")
            Console.WriteLine("4. Ciudad")
            Console.WriteLine("5. Volver")
            Console.Write("Seleccione: ")
            opcion = Console.ReadLine()
            Select Case opcion
                Case "1"
                    MostrarContactos("nombre ASC")
                Case "2"
                    MostrarContactos("nombre DESC")
                Case "3"
                    MostrarContactos("fecha_nacimiento ASC")
                Case "4"
                    MostrarContactos("ciudad ASC")
            End Select
            If opcion <> "5" Then
                Console.WriteLine(vbCrLf & "Presiona una tecla...")
                Console.ReadKey()
            End If
        Loop While opcion <> "5"
    End Sub
    Sub MostrarContactos(orden As String)
        Console.Clear()
        Console.WriteLine("📊 CONTACTOS ORDENADOS")
        Console.WriteLine("------------------------------------")
        Try
            Using conexion As MySqlConnection = ObtenerConexion()
                conexion.Open()
                Dim query As String = "SELECT * FROM contactos ORDER BY " & orden
                Using comando As New MySqlCommand(query, conexion)
                    Using lector As MySqlDataReader = comando.ExecuteReader()
                        If lector.HasRows Then
                            While lector.Read()
                                Console.WriteLine("ID: " & lector("id"))
                                Console.WriteLine("Nombre: " & lector("nombre") & " " & lector("apellido"))
                                Console.WriteLine("Teléfono: " & lector("telefono"))
                                Console.WriteLine("Correo: " & lector("correo"))
                                Console.WriteLine("Ciudad: " & lector("ciudad"))
                                Console.WriteLine("Nacimiento: " & lector("fecha_nacimiento"))
                                Console.WriteLine("------------------------------------")
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
End Module