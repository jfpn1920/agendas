Imports System
Module validar_agenda_vacia_con_bucle
    Sub Main(args As String())
        Dim contactos As New List(Of String)
        Do While contactos.Count = 0
            Console.WriteLine("La agenda está vacía.")
            Console.Write("Ingrese un contacto para comenzar: ")
            Dim nombre As String = Console.ReadLine()
            If nombre <> "" Then
                contactos.Add(nombre)
                Console.WriteLine("Contacto agregado correctamente.")
            Else
                Console.WriteLine("No puede ingresar un nombre vacío.")
            End If
            Console.WriteLine()
        Loop
        Console.WriteLine("=== CONTACTOS EN LA AGENDA ===")
        For Each c In contactos
            Console.WriteLine("- " & c)
        Next
        Console.ReadKey()
    End Sub
End Module