Imports System
Module validar_correo_correcto_con_manejo_de_errores
    Sub Main(args As String())
        Console.WriteLine("📧 VALIDACIÓN DE CORREO")
        Dim correo As String = PedirCorreo("Ingrese correo: ")
        Console.WriteLine("✅ Correo válido ingresado: " & correo)
        Console.ReadKey()
    End Sub
    Function PedirCorreo(mensaje As String) As String
        Dim correo As String
        While True
            Try
                Console.Write(mensaje)
                correo = Console.ReadLine().Trim().ToLower()
                If String.IsNullOrWhiteSpace(correo) Then
                    Throw New Exception("El correo no puede estar vacío.")
                End If
                If Not correo.Contains("@") Or Not correo.Contains(".") Then
                    Throw New Exception("El correo no tiene un formato válido.")
                End If
                Return correo
            Catch ex As Exception
                Console.WriteLine("❌ Error: " & ex.Message)
            End Try
        End While
        Return ""
    End Function
End Module