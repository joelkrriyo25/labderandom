Public Class Form1
    'Dim Intentos As Integer
    Private Sub btn_numero_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_inicio_Click(sender As Object, e As EventArgs) Handles btn_inicio.Click
        Dim rnd As System.Random = New System.Random()
        txt_computadora.Text = rnd.Next(1, 101)

    End Sub

    Private Sub btn_verificar_Click(sender As Object, e As EventArgs) Handles btn_verificar.Click

        'MsgBox(txt_computadora.Text)

        If CInt(txt_usuario.Text) > CInt(txt_computadora.Text) Then

            txt_mensaje.Text = "Muy Alto"

        Else
            If CInt(txt_usuario.Text) < CInt(txt_computadora.Text) Then
                txt_mensaje.Text = "Muy Bajo"
            Else
                txt_mensaje.Text = "Correcto"
            End If
        End If

        'Intentos = Intentos + 1
        txt_intentos.Text = Val(txt_intentos.Text) + 1
    End Sub
End Class
