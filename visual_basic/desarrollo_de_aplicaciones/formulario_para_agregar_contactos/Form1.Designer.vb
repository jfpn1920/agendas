<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtnombre = New TextBox()
        txttelefono = New TextBox()
        txtcorreo = New TextBox()
        Label4 = New Label()
        btnagregar = New Button()
        lstcontactos = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(17, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nombre:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 20)
        Label2.TabIndex = 1
        Label2.Text = "Telefono:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(24, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 20)
        Label3.TabIndex = 2
        Label3.Text = "Correo:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtnombre
        ' 
        txtnombre.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtnombre.BorderStyle = BorderStyle.FixedSingle
        txtnombre.Location = New Point(85, 36)
        txtnombre.Name = "txtnombre"
        txtnombre.Size = New Size(235, 23)
        txtnombre.TabIndex = 3
        ' 
        ' txttelefono
        ' 
        txttelefono.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txttelefono.BorderStyle = BorderStyle.FixedSingle
        txttelefono.Location = New Point(85, 73)
        txttelefono.Name = "txttelefono"
        txttelefono.Size = New Size(235, 23)
        txttelefono.TabIndex = 4
        ' 
        ' txtcorreo
        ' 
        txtcorreo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtcorreo.BorderStyle = BorderStyle.FixedSingle
        txtcorreo.Location = New Point(85, 113)
        txtcorreo.Name = "txtcorreo"
        txtcorreo.Size = New Size(235, 23)
        txtcorreo.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.Dock = DockStyle.Top
        Label4.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ImageAlign = ContentAlignment.MiddleLeft
        Label4.Location = New Point(0, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(332, 23)
        Label4.TabIndex = 6
        Label4.Text = "Formulario para agregar contactos"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnagregar
        ' 
        btnagregar.Anchor = AnchorStyles.Top
        btnagregar.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnagregar.Location = New Point(73, 151)
        btnagregar.Name = "btnagregar"
        btnagregar.Size = New Size(194, 33)
        btnagregar.TabIndex = 7
        btnagregar.Text = "Agregar contacto"
        btnagregar.UseVisualStyleBackColor = True
        ' 
        ' lstcontactos
        ' 
        lstcontactos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lstcontactos.FormattingEnabled = True
        lstcontactos.Location = New Point(12, 199)
        lstcontactos.Name = "lstcontactos"
        lstcontactos.Size = New Size(308, 229)
        lstcontactos.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(332, 441)
        Controls.Add(lstcontactos)
        Controls.Add(btnagregar)
        Controls.Add(Label4)
        Controls.Add(txtcorreo)
        Controls.Add(txttelefono)
        Controls.Add(txtnombre)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Formulario para agregar contactos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnagregar As Button
    Friend WithEvents lstcontactos As ListBox

End Class
