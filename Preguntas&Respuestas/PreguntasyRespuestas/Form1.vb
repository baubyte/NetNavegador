Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lTitulo.Click

    End Sub

    Private Sub bComenzar_Click(sender As Object, e As EventArgs) Handles bComenzar.Click
        Dim preg1 As New Pregunta1
        preg1.BackgroundImage = PreguntasyRespuestas.My.Resources.Resources.wp3638491
        preg1.Show()
        Me.Close()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
