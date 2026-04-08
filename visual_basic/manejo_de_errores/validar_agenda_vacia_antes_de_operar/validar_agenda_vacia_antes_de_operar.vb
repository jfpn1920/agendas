Imports System
Module validar_agenda_vacia_antes_de_operar
    Sub Main(args As String())
        Console.WriteLine("📒 VALIDAR AGENDA ANTES DE OPERAR")
        Dim contactos As New List(Of Tuple(Of String, String))
        Try
            VerificarAgenda(contactos)
            Console.WriteLine(vbCrLf & "📋 LISTA DE CONTACTOS:")
            For Each c In contactos
                Console.WriteLine("Nombre: " & c.Item1 & " | Tel: " & c.Item2)
            Next
        Catch ex As Exception
            Console.WriteLine("❌ Error: " & ex.Message)
        End Try
        Console.ReadKey()
    End Sub
    Sub VerificarAgenda(contactos As List(Of Tuple(Of String, String)))
        If contactos Is Nothing Then
            Throw New Exception("La agenda no está inicializada.")
        End If
        If contactos.Count = 0 Then
            Throw New Exception("La agenda está vacía. No hay contactos para mostrar.")
        End If
    End Sub
End Module