Imports System
Module verificar_duplicados
    Sub Main(args As String())
        Dim contactos() As String = {"juan", "maria", "pedro"}
        Dim nuevoContacto As String
        Dim existe As Boolean = False
        Console.Write("Ingrese el nombre del nuevo contacto: ")
        nuevoContacto = Console.ReadLine().ToLower()
        For Each contacto In contactos
            If contacto = nuevoContacto Then
                existe = True
            End If
        Next
        If existe Then
            Console.WriteLine("El contacto ya existe ❌")
        Else
            Console.WriteLine("Contacto agregado correctamente ✅")
        End If
    End Sub
End Module