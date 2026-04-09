Imports System.Collections.Generic

Public Class eliminar_contacto

    ' Lista en memoria
    Dim listaContactos As New List(Of String)

    ' Evento Resize para hacer los TextBox adaptables
    Private Sub Form_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim margen As Integer = 20

        txtnombre.Width = Me.ClientSize.Width - txtnombre.Left - margen
        txttelefono.Width = Me.ClientSize.Width - txttelefono.Left - margen
        txtcorreo.Width = Me.ClientSize.Width - txtcorreo.Left - margen
    End Sub

    ' Botón agregar
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

    ' Botón mostrar
    Private Sub btnmostrar_Click(sender As Object, e As EventArgs) Handles btnmostrar.Click

        lstcontactos.Items.Clear()

        For Each contacto As String In listaContactos
            lstcontactos.Items.Add(contacto)
        Next

    End Sub

    ' 🔴 Botón eliminar (NUEVO)
    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

        ' Verificar si hay selección
        If lstcontactos.SelectedIndex = -1 Then
            MessageBox.Show("Selecciona un contacto para eliminar")
            Exit Sub
        End If

        ' Obtener posición del elemento
        Dim indice As Integer = lstcontactos.SelectedIndex

        ' Eliminar de la lista en memoria
        listaContactos.RemoveAt(indice)

        ' Eliminar del ListBox
        lstcontactos.Items.RemoveAt(indice)

        MessageBox.Show("Contacto eliminado correctamente ❌")

    End Sub

End Class