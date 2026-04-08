Imports System
Imports MySql.Data.MySqlClient
Module mostrar_contactos
    Sub Main()
        Dim opcion As String = ""
        Do
            Console.Clear()
            Console.WriteLine("📒 MENÚ DE CONTACTOS")
            Console.WriteLine("1. ➕ Agregar contacto")
            Console.WriteLine("2. 📋 Mostrar todos los contactos")
            Console.WriteLine("3. 🔍 Buscar contacto por nombre")
            Console.WriteLine("4. ❌ Salir")
            Console.Write("Selecciona una opción: ")
            opcion = Console.ReadLine()
            Select Case opcion
                Case "1"
                    AgregarContacto()
                Case "2"
                    MostrarContactos()
                Case "3"
                    BuscarContacto()
                Case "4"
                    Console.WriteLine("👋 Saliendo del programa...")
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
                            Console.WriteLine("⚠ No hay contactos registrados")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("❌ Error: " & ex.Message)
        End Try
    End Sub
    Sub BuscarContacto()
        Console.Clear()
        Console.WriteLine("🔍 BUSCAR CONTACTO")
        Console.Write("Ingresa el nombre: ")
        Dim nombreBuscar As String = Console.ReadLine()
        Try
            Using conexion As MySqlConnection = ObtenerConexion()
                conexion.Open()
                Dim query As String = "SELECT * FROM contactos WHERE nombre LIKE @nombre"
                Using comando As New MySqlCommand(query, conexion)
                    comando.Parameters.AddWithValue("@nombre", "%" & nombreBuscar & "%")
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
                            Console.WriteLine("⚠ No se encontraron resultados")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("❌ Error: " & ex.Message)
        End Try
    End Sub
End Module