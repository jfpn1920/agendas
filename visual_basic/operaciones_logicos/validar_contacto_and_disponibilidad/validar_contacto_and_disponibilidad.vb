Imports System
Module validar_contacto_and_disponibilidad
    Sub Main(args As String())
        Dim contactos() As String = {"juan", "maria", "pedro"}
        Dim disponibilidad() As Boolean = {True, False, True}
        Dim nombre As String
        Dim existe As Boolean = False
        Dim disponible As Boolean = False
        Console.Write("Ingrese el nombre del contacto: ")
        nombre = Console.ReadLine().ToLower()
        For i As Integer = 0 To contactos.Length - 1
            If contactos(i) = nombre Then
                existe = True
                disponible = disponibilidad(i)
                Exit For
            End If
        Next
        If existe And disponible Then
            Console.WriteLine("El contacto existe y está disponible ✅")
        Else
            Console.WriteLine("El contacto no existe o no está disponible ❌")
        End If
    End Sub
End Module