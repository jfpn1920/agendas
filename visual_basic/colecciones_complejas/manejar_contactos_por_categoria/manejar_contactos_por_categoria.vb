Imports System
Imports System.Collections.Generic
Module manejar_contactos_por_categoria
    Class Contacto
        Public Nombre As String
        Public Telefono As String
        Public Correo As String
    End Class
    Sub Main(args As String())
        Dim agenda As New Dictionary(Of String, List(Of Contacto))
        Dim opcion As Integer
        Do
            Console.WriteLine("📒 MENÚ AGENDA POR CATEGORÍA")
            Console.WriteLine("1. Agregar contacto")
            Console.WriteLine("2. Mostrar contactos por categoría")
            Console.WriteLine("3. Mostrar todas las categorías")
            Console.WriteLine("4. Salir")
            Console.Write("Seleccione una opción: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()
            Select Case opcion
                Case 1
                    AgregarContacto(agenda)
                Case 2
                    MostrarPorCategoria(agenda)
                Case 3
                    MostrarCategorias(agenda)
                Case 4
                    Console.WriteLine("👋 Saliendo del programa...")
                Case Else
                    Console.WriteLine("❌ Opción inválida.")
            End Select
            Console.WriteLine()
        Loop While opcion <> 4
    End Sub
    Sub AgregarContacto(agenda As Dictionary(Of String, List(Of Contacto)))
        Console.Write("Ingrese categoría: ")
        Dim categoria As String = Console.ReadLine()
        Console.Write("Nombre: ")
        Dim nombre As String = Console.ReadLine()
        Console.Write("Teléfono: ")
        Dim telefono As String = Console.ReadLine()
        Console.Write("Correo: ")
        Dim correo As String = Console.ReadLine()
        Dim nuevo As New Contacto With {
            .Nombre = nombre,
            .Telefono = telefono,
            .Correo = correo
        }
        If Not agenda.ContainsKey(categoria) Then
            agenda(categoria) = New List(Of Contacto)
        End If
        agenda(categoria).Add(nuevo)
        Console.WriteLine("✅ Contacto agregado correctamente.")
    End Sub
    Sub MostrarPorCategoria(agenda As Dictionary(Of String, List(Of Contacto)))
        Console.Write("Ingrese la categoría a mostrar: ")
        Dim categoria As String = Console.ReadLine()
        If agenda.ContainsKey(categoria) Then
            Console.WriteLine("📂 Categoría: " & categoria)
            Console.WriteLine("--------------------------")
            For Each contacto In agenda(categoria)
                Console.WriteLine("Nombre: " & contacto.Nombre)
                Console.WriteLine("Teléfono: " & contacto.Telefono)
                Console.WriteLine("Correo: " & contacto.Correo)
                Console.WriteLine("--------------------------")
            Next
        Else
            Console.WriteLine("❌ Categoría no encontrada.")
        End If
    End Sub
    Sub MostrarCategorias(agenda As Dictionary(Of String, List(Of Contacto)))
        If agenda.Count = 0 Then
            Console.WriteLine("⚠️ No hay categorías registradas.")
        Else
            Console.WriteLine("📂 Categorías disponibles:")
            For Each categoria In agenda.Keys
                Console.WriteLine("- " & categoria)
            Next
        End If
    End Sub
End Module