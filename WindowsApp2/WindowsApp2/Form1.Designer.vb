<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_intento = New System.Windows.Forms.Label()
        Me.txt_mensaje = New System.Windows.Forms.TextBox()
        Me.lbl_computadora = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.txt_computadora = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_intentos = New System.Windows.Forms.TextBox()
        Me.btn_inicio = New System.Windows.Forms.Button()
        Me.btn_verificar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_intento
        '
        Me.lbl_intento.AutoSize = True
        Me.lbl_intento.Location = New System.Drawing.Point(55, 133)
        Me.lbl_intento.Name = "lbl_intento"
        Me.lbl_intento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_intento.Size = New System.Drawing.Size(45, 13)
        Me.lbl_intento.TabIndex = 0
        Me.lbl_intento.Text = "Intentos"
        '
        'txt_mensaje
        '
        Me.txt_mensaje.Location = New System.Drawing.Point(124, 91)
        Me.txt_mensaje.Multiline = True
        Me.txt_mensaje.Name = "txt_mensaje"
        Me.txt_mensaje.Size = New System.Drawing.Size(181, 32)
        Me.txt_mensaje.TabIndex = 1
        '
        'lbl_computadora
        '
        Me.lbl_computadora.AutoSize = True
        Me.lbl_computadora.Location = New System.Drawing.Point(25, 22)
        Me.lbl_computadora.Name = "lbl_computadora"
        Me.lbl_computadora.Size = New System.Drawing.Size(70, 13)
        Me.lbl_computadora.TabIndex = 3
        Me.lbl_computadora.Text = "Computadora"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(52, 55)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_usuario.TabIndex = 4
        Me.lbl_usuario.Text = "Usuario"
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Location = New System.Drawing.Point(56, 94)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(47, 13)
        Me.lbl_mensaje.TabIndex = 5
        Me.lbl_mensaje.Text = "Mensaje"
        '
        'txt_computadora
        '
        Me.txt_computadora.Location = New System.Drawing.Point(124, 12)
        Me.txt_computadora.Multiline = True
        Me.txt_computadora.Name = "txt_computadora"
        Me.txt_computadora.Size = New System.Drawing.Size(181, 28)
        Me.txt_computadora.TabIndex = 6
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(124, 52)
        Me.txt_usuario.Multiline = True
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(181, 28)
        Me.txt_usuario.TabIndex = 7
        '
        'txt_intentos
        '
        Me.txt_intentos.Location = New System.Drawing.Point(124, 130)
        Me.txt_intentos.Multiline = True
        Me.txt_intentos.Name = "txt_intentos"
        Me.txt_intentos.Size = New System.Drawing.Size(181, 28)
        Me.txt_intentos.TabIndex = 8
        '
        'btn_inicio
        '
        Me.btn_inicio.Location = New System.Drawing.Point(334, 31)
        Me.btn_inicio.Name = "btn_inicio"
        Me.btn_inicio.Size = New System.Drawing.Size(90, 29)
        Me.btn_inicio.TabIndex = 9
        Me.btn_inicio.Text = "Inicio"
        Me.btn_inicio.UseVisualStyleBackColor = True
        '
        'btn_verificar
        '
        Me.btn_verificar.Location = New System.Drawing.Point(334, 78)
        Me.btn_verificar.Name = "btn_verificar"
        Me.btn_verificar.Size = New System.Drawing.Size(90, 29)
        Me.btn_verificar.TabIndex = 10
        Me.btn_verificar.Text = "Verificar"
        Me.btn_verificar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 203)
        Me.Controls.Add(Me.btn_verificar)
        Me.Controls.Add(Me.btn_inicio)
        Me.Controls.Add(Me.txt_intentos)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_computadora)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.lbl_computadora)
        Me.Controls.Add(Me.txt_mensaje)
        Me.Controls.Add(Me.lbl_intento)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_intento As Label
    Friend WithEvents txt_mensaje As TextBox
    Friend WithEvents lbl_computadora As Label
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents lbl_mensaje As Label
    Friend WithEvents txt_computadora As TextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_intentos As TextBox
    Friend WithEvents btn_inicio As Button
    Friend WithEvents btn_verificar As Button
End Class
