Imports System
Module validar_agenda_vacia
    Sub Main(args As String())
        Dim contactos() As String = {}
        If contactos.Length = 0 Then
            Console.WriteLine("La agenda está vacía 📭")
        Else
            Console.WriteLine("Contactos en la agenda:")
            For Each contacto In contactos
                Console.WriteLine(contacto)
            Next
        End If
    End Sub
End Module