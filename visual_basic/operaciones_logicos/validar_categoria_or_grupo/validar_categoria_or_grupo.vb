Imports System
Module validar_categoria_or_grupo
    Sub Main(args As String())
        Dim categoria As String
        Dim grupo As String
        Console.Write("Ingrese la categoría: ")
        categoria = Console.ReadLine()
        Console.Write("Ingrese el grupo: ")
        grupo = Console.ReadLine()
        If categoria.Trim() <> "" Or grupo.Trim() <> "" Then
            Console.WriteLine("Dato válido ✅ (categoría o grupo ingresado)")
        Else
            Console.WriteLine("Error: Debe ingresar categoría o grupo ❌")
        End If
    End Sub
End Module