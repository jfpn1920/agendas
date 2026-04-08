Imports System
Module validar_longitud_del_nombre_control_de_excepciones
    Sub Main(args As String())
        Console.WriteLine("👤 VALIDACIÓN DE NOMBRE")
        Dim nombre As String = PedirNombre("Ingrese nombre: ")
        Console.WriteLine("✅ Nombre válido ingresado: " & nombre)
        Console.ReadKey()
    End Sub
    Function PedirNombre(mensaje As String) As String
        Dim nombre As String
        While True
            Try
                Console.Write(mensaje)
                nombre = Console.ReadLine().Trim()
                If String.IsNullOrWhiteSpace(nombre) Then
                    Throw New Exception("El nombre no puede estar vacío.")
                End If
                If nombre.Length < 3 Then
                    Throw New Exception("El nombre debe tener al menos 3 caracteres.")
                End If
                If nombre.Length > 30 Then
                    Throw New Exception("El nombre no puede superar los 30 caracteres.")
                End If
                nombre = CapitalizarNombre(nombre)
                Return nombre
            Catch ex As Exception
                Console.WriteLine("❌ Error: " & ex.Message)
            End Try
        End While
        Return ""
    End Function
    Function CapitalizarNombre(nombre As String) As String
        Dim palabras() As String = nombre.ToLower().Split(" "c)
        For i As Integer = 0 To palabras.Length - 1
            If palabras(i).Length > 0 Then
                palabras(i) = Char.ToUpper(palabras(i)(0)) & palabras(i).Substring(1)
            End If
        Next
        Return String.Join(" ", palabras)
    End Function
End Module