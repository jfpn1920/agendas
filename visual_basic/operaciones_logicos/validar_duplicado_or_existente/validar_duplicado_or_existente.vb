Imports System
Module validar_duplicado_or_existente
    Sub Main(args As String())
        Dim contactos() As String = {"juan", "maria", "pedro"}
        Dim nuevo As String
        Dim existe As Boolean = False
        Dim duplicado As Boolean = False
        Console.Write("Ingrese el nombre del contacto: ")
        nuevo = Console.ReadLine().ToLower()
        For Each contacto In contactos
            If contacto = nuevo Then
                existe = True
                duplicado = True
                Exit For
            End If
        Next
        If existe Or duplicado Then
            Console.WriteLine("Error: El contacto ya existe o está duplicado ❌")
        Else
            Console.WriteLine("Contacto válido, se puede agregar ✅")
        End If
    End Sub
End Module