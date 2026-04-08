Imports System
Module validar_contacto_favorito_and_existente
    Sub Main(args As String())
        Dim contactos() As String = {"juan", "maria", "pedro"}
        Dim favoritos() As Boolean = {True, False, True}
        Dim nombre As String
        Dim existe As Boolean = False
        Dim esFavorito As Boolean = False
        Console.Write("Ingrese el nombre del contacto: ")
        nombre = Console.ReadLine().ToLower()
        For i As Integer = 0 To contactos.Length - 1
            If contactos(i) = nombre Then
                existe = True
                esFavorito = favoritos(i)
                Exit For
            End If
        Next
        If existe And esFavorito Then
            Console.WriteLine("El contacto existe y es favorito ⭐✅")
        Else
            Console.WriteLine("El contacto no existe o no es favorito ❌")
        End If
    End Sub
End Module