Imports System
Module funcion_para_registrar_contacto
    Sub Main(args As String())
        Dim contactos As New List(Of String)
        RegistrarContacto(contactos)
        Console.WriteLine(vbCrLf & "=== CONTACTOS REGISTRADOS ===")
        For Each contacto As String In contactos
            Console.WriteLine(contacto)
        Next
        Console.ReadKey()
    End Sub
    Sub RegistrarContacto(ByRef lista As List(Of String))
        Console.WriteLine("Ingrese el nombre del contacto:")
        Dim nombre As String = Console.ReadLine()
        lista.Add(nombre)
        Console.WriteLine("✅ Contacto registrado")
    End Sub
End Module