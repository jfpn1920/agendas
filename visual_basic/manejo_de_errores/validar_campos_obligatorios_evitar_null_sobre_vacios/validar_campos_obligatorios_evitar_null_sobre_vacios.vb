Imports System
Module validar_campos_obligatorios_evitar_null_sobre_vacios
    Sub Main(args As String())
        Console.WriteLine("📒 REGISTRO DE CONTACTO")
        Dim nombre As String = PedirTextoObligatorio("Ingrese nombre: ")
        Dim telefono As String = PedirTextoObligatorio("Ingrese teléfono: ")
        Dim correo As String = PedirTextoObligatorio("Ingrese correo: ")
        Console.WriteLine(vbCrLf & "✅ CONTACTO REGISTRADO:")
        Console.WriteLine("Nombre: " & nombre)
        Console.WriteLine("Teléfono: " & telefono)
        Console.WriteLine("Correo: " & correo)
        Console.ReadKey()
    End Sub
    Function PedirTextoObligatorio(mensaje As String) As String
        Dim valor As String
        While True
            Try
                Console.Write(mensaje)
                valor = Console.ReadLine()
                If valor Is Nothing Then
                    Throw New Exception("El campo no puede ser nulo.")
                End If
                valor = valor.Trim()
                If valor = "" Then
                    Throw New Exception("El campo es obligatorio y no puede estar vacío.")
                End If
                Return valor
            Catch ex As Exception
                Console.WriteLine("❌ Error: " & ex.Message)
            End Try
        End While
        Return ""
    End Function
End Module