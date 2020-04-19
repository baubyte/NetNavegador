Public Class Pregunta2
    Private Sub bA_Click(sender As Object, e As EventArgs) Handles bA.Click
        MessageBox.Show("Intentalo de Nuevo")
        Score.scores += 1
    End Sub

    Private Sub bB_Click(sender As Object, e As EventArgs) Handles bB.Click
        MessageBox.Show("Intentalo de Nuevo")
        Score.scores += 1
    End Sub

    Private Sub bC_Click(sender As Object, e As EventArgs) Handles bC.Click
        Dim preg3 As New Pregunta3
        preg3.BackgroundImage = PreguntasyRespuestas.My.Resources.Resources.wp3638491
        preg3.Show()
        Me.Close()
    End Sub
End Class