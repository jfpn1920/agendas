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
        btnsaludar = New Button()
        lblmensaje = New Label()
        SuspendLayout()
        ' 
        ' btnsaludar
        ' 
        btnsaludar.Location = New Point(300, 231)
        btnsaludar.Name = "btnsaludar"
        btnsaludar.Size = New Size(191, 45)
        btnsaludar.TabIndex = 0
        btnsaludar.Text = "saludar"
        btnsaludar.UseVisualStyleBackColor = True
        ' 
        ' lblmensaje
        ' 
        lblmensaje.Font = New Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblmensaje.Location = New Point(123, 110)
        lblmensaje.Name = "lblmensaje"
        lblmensaje.Size = New Size(558, 33)
        lblmensaje.TabIndex = 1
        lblmensaje.Text = "Hola mundo"
        lblmensaje.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblmensaje)
        Controls.Add(btnsaludar)
        Name = "Form1"
        Text = "primera_app"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnsaludar As Button
    Friend WithEvents lblmensaje As Label

End Class
