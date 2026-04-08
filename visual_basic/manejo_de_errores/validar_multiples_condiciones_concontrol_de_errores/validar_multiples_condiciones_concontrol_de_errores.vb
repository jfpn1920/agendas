Imports System
Imports System.Text.RegularExpressions
Module validar_multiples_condiciones_concontrol_de_errores
    Sub Main(args As String())
        Console.WriteLine("📒 VALIDACIÓN COMPLETA DE CONTACTO")
        Try
            Dim nombre As String = PedirNombre("Nombre: ")
            Dim telefono As String = PedirTelefono("Teléfono: ")
            Dim correo As String = PedirCorreo("Correo: ")
            Console.WriteLine(vbCrLf & "✅ CONTACTO VÁLIDO:")
            Console.WriteLine("Nombre: " & nombre)
            Console.WriteLine("Teléfono: " & telefono)
            Console.WriteLine("Correo: " & correo)
        Catch ex As Exception
            Console.WriteLine("❌ Error general: " & ex.Message)
        End Try
        Console.ReadKey()
    End Sub
    Function PedirNombre(mensaje As String) As String
        While True
            Try
                Console.Write(mensaje)
                Dim nombre As String = Console.ReadLine().Trim()
                If nombre = "" Then
                    Throw New Exception("El nombre es obligatorio.")
                End If
                If nombre.Length < 3 Or nombre.Length > 30 Then
                    Throw New Exception("El nombre debe tener entre 3 y 30 caracteres.")
                End If
                Return nombre
            Catch ex As Exception
                Console.WriteLine("❌ Error: " & ex.Message)
            End Try
        End While
        Return ""
    End Function
    Function PedirTelefono(mensaje As String) As String
        While True
            Try
                Console.Write(mensaje)
                Dim telefono As String = Console.ReadLine().Trim()
                If telefono = "" Then
                    Throw New Exception("El teléfono es obligatorio.")
                End If
                If Not IsNumeric(telefono) Then
                    Throw New Exception("El teléfono debe ser numérico.")
                End If
                If telefono.Length < 7 Then
                    Throw New Exception("El teléfono debe tener al menos 7 dígitos.")
                End If
                Return telefono
            Catch ex As Exception
                Console.WriteLine("❌ Error: " & ex.Message)
            End Try
        End While
        Return ""
    End Function
    Function PedirCorreo(mensaje As String) As String
        While True
            Try
                Console.Write(mensaje)
                Dim correo As String = Console.ReadLine().Trim().ToLower()
                If correo = "" Then
                    Throw New Exception("El correo es obligatorio.")
                End If
                If Not Regex.IsMatch(correo, "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
                    Throw New Exception("Formato de correo inválido.")
                End If
                Return correo
            Catch ex As Exception
                Console.WriteLine("❌ Error: " & ex.Message)
            End Try
        End While
        Return ""
    End Function
End Module