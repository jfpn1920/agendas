Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnagregar.Left = (Me.ClientSize.Width - btnagregar.Width) \ 2
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        btnagregar.Left = (Me.ClientSize.Width - btnagregar.Width) \ 2
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If txtnombre.Text = "" Or txttelefono.Text = "" Or txtcorreo.Text = "" Then
            MessageBox.Show("Por favor completa todos los campos")
            Exit Sub
        End If
        Dim contacto As String = "Nombre: " & txtnombre.Text &
                                 " | Tel: " & txttelefono.Text &
                                 " | Correo: " & txtcorreo.Text
        lstcontactos.Items.Add(contacto)
        txtnombre.Clear()
        txttelefono.Clear()
        txtcorreo.Clear()
        txtnombre.Focus()
        MessageBox.Show("Contacto agregado correctamente ✅")
    End Sub
End Class