Imports System
Module validar_numero_valido_reutilizado_con_try_y_catch
    Sub Main(args As String())
        Console.WriteLine("📞 VALIDACIÓN DE NÚMERO")
        Dim telefono As Long = PedirNumero("Ingrese teléfono: ")
        Console.WriteLine("✅ Número válido ingresado: " & telefono)
        Console.ReadKey()
    End Sub
    Function PedirNumero(mensaje As String) As Long
        Dim numero As Long
        While True
            Try
                Console.Write(mensaje)
                numero = Convert.ToInt64(Console.ReadLine())
                Return numero
            Catch ex As Exception
                Console.WriteLine("❌ Error: Debe ingresar un número válido.")
            End Try
        End While
        Return 0
    End Function
End Module