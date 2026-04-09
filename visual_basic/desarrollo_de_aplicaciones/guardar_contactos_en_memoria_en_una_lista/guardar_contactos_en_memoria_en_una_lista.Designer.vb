<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class guardar_contactos_en_memoria_en_una_lista
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtnombre = New TextBox()
        btnmostrar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txttelefono = New TextBox()
        Label4 = New Label()
        txtcorreo = New TextBox()
        lstcontactos = New ListBox()
        btnagregar = New Button()
        SuspendLayout()
        ' 
        ' txtnombre
        ' 
        txtnombre.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtnombre.BorderStyle = BorderStyle.FixedSingle
        txtnombre.Location = New Point(116, 49)
        txtnombre.Name = "txtnombre"
        txtnombre.Size = New Size(231, 23)
        txtnombre.TabIndex = 0
        ' 
        ' btnmostrar
        ' 
        btnmostrar.Anchor = AnchorStyles.Top
        btnmostrar.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnmostrar.Location = New Point(177, 163)
        btnmostrar.Name = "btnmostrar"
        btnmostrar.Size = New Size(169, 36)
        btnmostrar.TabIndex = 9
        btnmostrar.Text = "Mostrar lista"
        btnmostrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(335, 19)
        Label1.TabIndex = 2
        Label1.Text = "Guardar contactos en memoria en una lista"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 14.24F, FontStyle.Bold)
        Label2.Location = New Point(20, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 22)
        Label2.TabIndex = 3
        Label2.Text = "Nombre:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 14.24F, FontStyle.Bold)
        Label3.Location = New Point(12, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 22)
        Label3.TabIndex = 5
        Label3.Text = "Telefono:"
        ' 
        ' txttelefono
        ' 
        txttelefono.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txttelefono.BorderStyle = BorderStyle.FixedSingle
        txttelefono.Location = New Point(116, 86)
        txttelefono.Name = "txttelefono"
        txttelefono.Size = New Size(231, 23)
        txttelefono.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 14.24F, FontStyle.Bold)
        Label4.Location = New Point(28, 125)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 22)
        Label4.TabIndex = 7
        Label4.Text = "Correo:"
        ' 
        ' txtcorreo
        ' 
        txtcorreo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtcorreo.BorderStyle = BorderStyle.FixedSingle
        txtcorreo.Location = New Point(116, 125)
        txtcorreo.Name = "txtcorreo"
        txtcorreo.Size = New Size(231, 23)
        txtcorreo.TabIndex = 6
        ' 
        ' lstcontactos
        ' 
        lstcontactos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lstcontactos.FormattingEnabled = True
        lstcontactos.Location = New Point(12, 214)
        lstcontactos.Name = "lstcontactos"
        lstcontactos.Size = New Size(335, 214)
        lstcontactos.TabIndex = 8
        ' 
        ' btnagregar
        ' 
        btnagregar.Anchor = AnchorStyles.Top
        btnagregar.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnagregar.Location = New Point(12, 163)
        btnagregar.Name = "btnagregar"
        btnagregar.Size = New Size(159, 36)
        btnagregar.TabIndex = 10
        btnagregar.Text = "agregar contacto"
        btnagregar.UseVisualStyleBackColor = True
        ' 
        ' guardar_contactos_en_memoria_en_una_lista
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(358, 441)
        Controls.Add(btnagregar)
        Controls.Add(lstcontactos)
        Controls.Add(Label4)
        Controls.Add(txtcorreo)
        Controls.Add(Label3)
        Controls.Add(txttelefono)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnmostrar)
        Controls.Add(txtnombre)
        Name = "guardar_contactos_en_memoria_en_una_lista"
        Text = "Guardar contactos en memoria en una lista"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents btnmostrar As Button
    Friend WithEvents lstcontactos As ListBox
    Friend WithEvents btnagregar As Button

End Class
