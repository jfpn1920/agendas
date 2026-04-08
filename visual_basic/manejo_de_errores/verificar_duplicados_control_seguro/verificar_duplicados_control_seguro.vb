Imports System
Module verificar_duplicados_control_seguro
    Sub Main(args As String())
        Console.WriteLine("📒 CONTROL DE CONTACTOS (SIN DUPLICADOS)")
        Dim contactos As New List(Of Tuple(Of String, String))
        For i As Integer = 1 To 3
            Console.WriteLine(vbCrLf & "➤ Registro #" & i)
            Dim nombre As String = PedirTextoObligatorio("Nombre: ")
            Dim telefono As String = PedirTelefonoUnico("Teléfono: ", contactos)
            contactos.Add(New Tuple(Of String, String)(nombre, telefono))
            Console.WriteLine("✅ Contacto agregado correctamente.")
        Next
        Console.WriteLine(vbCrLf & "📋 LISTA DE CONTACTOS:")
        For Each c In contactos
            Console.WriteLine("Nombre: " & c.Item1 & " | Tel: " & c.Item2)
        Next
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
                    Throw New Exception("El campo es obligatorio.")
                End If
                Return valor
            Catch ex As Exception
                Console.WriteLine("❌ Error: " & ex.Message)
            End Try
        End While
        Return ""
    End Function
    Function PedirTelefonoUnico(mensaje As String, contactos As List(Of Tuple(Of String, String))) As String
        Dim telefono As String
        While True
            Try
                Console.Write(mensaje)
                telefono = Console.ReadLine()
                If telefono Is Nothing Or telefono.Trim() = "" Then
                    Throw New Exception("El teléfono es obligatorio.")
                End If
                telefono = telefono.Trim()
                For Each c In contactos
                    If c.Item2 = telefono Then
                        Throw New Exception("Este teléfono ya está registrado.")
                    End If
                Next
                Return telefono
            Catch ex As Exception
                Console.WriteLine("❌ Error: " & ex.Message)
            End Try
        End While
        Return ""
    End Function
End Module