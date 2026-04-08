Imports System
Imports System.Collections.Generic
Module validar_datos_antes_de_insertar
    Class Contacto
        Public Nombre As String
        Public Telefono As String
        Public Correo As String
    End Class
    Sub Main(args As String())
        Dim agenda As New List(Of Contacto)
        Try
            Dim nuevo As New Contacto()
            Console.Write("Ingrese nombre: ")
            nuevo.Nombre = Console.ReadLine()
            If String.IsNullOrWhiteSpace(nuevo.Nombre) Then
                Throw New Exception("El nombre no puede estar vacío.")
            End If
            Console.Write("Ingrese teléfono: ")
            Dim telefonoInput As String = Console.ReadLine()
            If Not IsNumeric(telefonoInput) Then
                Throw New Exception("El teléfono debe ser numérico.")
            End If
            nuevo.Telefono = telefonoInput
            Console.Write("Ingrese correo: ")
            nuevo.Correo = Console.ReadLine()
            If Not nuevo.Correo.Contains("@") Or Not nuevo.Correo.Contains(".") Then
                Throw New Exception("El correo no es válido.")
            End If
            agenda.Add(nuevo)
            Console.WriteLine("✅ Contacto agregado correctamente.")
        Catch ex As Exception
            Console.WriteLine("❌ Error: " & ex.Message)
        End Try
        Console.ReadKey()
    End Sub
End Module