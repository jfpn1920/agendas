Imports System.Collections.Generic
Public Class guardar_contactos_en_memoria_en_una_lista
    Dim listaContactos As New List(Of String)
    Private Sub Form_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim margen As Integer = 20
        txtnombre.Width = Me.ClientSize.Width - txtnombre.Left - margen
        txttelefono.Width = Me.ClientSize.Width - txttelefono.Left - margen
        txtcorreo.Width = Me.ClientSize.Width - txtcorreo.Left - margen
    End Sub
    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If txtnombre.Text = "" Or txttelefono.Text = "" Or txtcorreo.Text = "" Then
            MessageBox.Show("Por favor completa todos los campos")
            Exit Sub
        End If
        Dim contacto As String = txtnombre.Text & "|" &
                                 txttelefono.Text & "|" &
                                 txtcorreo.Text
        listaContactos.Add(contacto)
        MessageBox.Show("Contacto guardado en memoria ✅")
        txtnombre.Clear()
        txttelefono.Clear()
        txtcorreo.Clear()
        txtnombre.Focus()
    End Sub
    Private Sub btnmostrar_Click(sender As Object, e As EventArgs) Handles btnmostrar.Click
        lstcontactos.Items.Clear()
        For Each contacto As String In listaContactos
            lstcontactos.Items.Add(contacto)
        Next
    End Sub
End Class