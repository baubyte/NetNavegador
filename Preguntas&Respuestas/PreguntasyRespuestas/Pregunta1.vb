Public Class Pregunta1
    Private Sub lTitulo_Click(sender As Object, e As EventArgs) Handles lTitulo.Click
        MessageBox.Show("Intentalo de Nuevo")
        Score.scores += 1
    End Sub

    Private Sub bB_Click(sender As Object, e As EventArgs) Handles bB.Click
        MessageBox.Show("Intentalo de Nuevo")
        Score.scores += 1
    End Sub

    Private Sub bA_Click(sender As Object, e As EventArgs) Handles bA.Click
        Dim preg2 As New Pregunta2
        preg2.BackgroundImage = PreguntasyRespuestas.My.Resources.Resources.wp3638491
        preg2.Show()
        Me.Close()
    End Sub
End Class