Imports System
Module funcion_para_actualizar_contacto
    Sub Main(args As String())
        Dim contactos As New List(Of String) From {
            "Juan", "Maria", "Carlos", "Ana"
        }
        ActualizarContacto(contactos)
        Console.WriteLine(vbCrLf & "=== LISTA ACTUALIZADA ===")
        For Each contacto As String In contactos
            Console.WriteLine(contacto)
        Next
        Console.ReadKey()
    End Sub
    Sub ActualizarContacto(ByRef lista As List(Of String))
        Console.WriteLine("Ingrese el nombre del contacto a actualizar:")
        Dim nombre As String = Console.ReadLine()
        Dim indice As Integer = -1
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ToLower() = nombre.ToLower() Then
                indice = i
                Exit For
            End If
        Next
        If indice <> -1 Then
            Console.WriteLine("Ingrese el nuevo nombre:")
            Dim nuevoNombre As String = Console.ReadLine()
            lista(indice) = nuevoNombre
            Console.WriteLine("✅ Contacto actualizado")
        Else
            Console.WriteLine("❌ Contacto no encontrado")
        End If
    End Sub
End Module