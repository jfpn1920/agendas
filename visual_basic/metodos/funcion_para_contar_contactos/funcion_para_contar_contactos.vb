Imports System
Module funcion_para_contar_contactos
    Sub Main(args As String())
        Dim contactos As New List(Of String) From {
            "Juan", "Maria", "Carlos", "Ana"
        }
        Dim total As Integer = ContarContactos(contactos)
        Console.WriteLine("Total de contactos: " & total)
        Console.ReadKey()
    End Sub
    Function ContarContactos(ByVal lista As List(Of String)) As Integer
        Return lista.Count
    End Function
End Module