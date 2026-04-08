Imports System
Module validar_contacto_existe_evitar_errores_al_buscar
    Sub Main(args As String())
        Console.WriteLine("📒 BÚSQUEDA DE CONTACTO SEGURA")
        Dim contactos As New List(Of Tuple(Of String, String)) From {
            New Tuple(Of String, String)("Juan", "123"),
            New Tuple(Of String, String)("Maria", "456"),
            New Tuple(Of String, String)("Carlos", "789")
        }
        Dim nombreBuscado As String = PedirTextoObligatorio("Ingrese nombre a buscar: ")
        Try
            Dim contacto = BuscarContacto(nombreBuscado, contactos)
            Console.WriteLine("✅ Contacto encontrado:")
            Console.WriteLine("Nombre: " & contacto.Item1)
            Console.WriteLine("Teléfono: " & contacto.Item2)
        Catch ex As Exception
            Console.WriteLine("❌ Error: " & ex.Message)
        End Try
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
    Function BuscarContacto(nombre As String, contactos As List(Of Tuple(Of String, String))) As Tuple(Of String, String)
        For Each c In contactos
            If c.Item1.ToLower() = nombre.ToLower() Then
                Return c
            End If
        Next
        Throw New Exception("El contacto no existe en la agenda.")
    End Function
End Module