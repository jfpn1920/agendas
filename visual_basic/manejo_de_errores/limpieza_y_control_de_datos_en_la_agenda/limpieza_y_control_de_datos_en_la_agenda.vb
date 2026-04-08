Imports System
Imports System.Collections.Generic
Module limpieza_y_control_de_datos_en_la_agenda
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
            nuevo.Nombre = Console.ReadLine().Trim()
            If String.IsNullOrWhiteSpace(nuevo.Nombre) Then
                Throw New Exception("El nombre no puede estar vacío.")
            End If
            nuevo.Nombre = CapitalizarNombre(nuevo.Nombre)
            Console.Write("Ingrese teléfono: ")
            Dim telefonoInput As String = Console.ReadLine().Trim()
            If Not IsNumeric(telefonoInput) Then
                Throw New Exception("El teléfono debe ser numérico.")
            End If
            nuevo.Telefono = telefonoInput
            Console.Write("Ingrese correo: ")
            nuevo.Correo = Console.ReadLine().Trim().ToLower()
            If Not nuevo.Correo.Contains("@") Or Not nuevo.Correo.Contains(".") Then
                Throw New Exception("El correo no es válido.")
            End If
            For Each c In agenda
                If c.Nombre.ToLower() = nuevo.Nombre.ToLower() Then
                    Throw New Exception("El contacto ya existe.")
                End If
            Next
            agenda.Add(nuevo)
            Console.WriteLine("✅ Contacto agregado correctamente.")
        Catch ex As Exception
            Console.WriteLine("❌ Error: " & ex.Message)
        End Try
        Console.WriteLine()
        Console.WriteLine("📒 AGENDA:")
        For Each c In agenda
            Console.WriteLine("----------------------")
            Console.WriteLine("Nombre: " & c.Nombre)
            Console.WriteLine("Teléfono: " & c.Telefono)
            Console.WriteLine("Correo: " & c.Correo)
        Next
        Console.ReadKey()
    End Sub
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