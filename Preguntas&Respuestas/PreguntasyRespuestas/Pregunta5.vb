Public Class Pregunta5
    Private Sub bC_Click(sender As Object, e As EventArgs) Handles bC.Click
        Dim preg6 As New Pregunta6
        preg6.BackgroundImage = PreguntasyRespuestas.My.Resources.Resources.wp3638491
        preg6.Show()
        Me.Close()
    End Sub

    Private Sub bA_Click(sender As Object, e As EventArgs) Handles bA.Click
        MessageBox.Show("Intentalo de Nuevo")
        Score.scores += 1
    End Sub

    Private Sub bB_Click(sender As Object, e As EventArgs) Handles bB.Click
        MessageBox.Show("Intentalo de Nuevo")
        Score.scores += 1
    End Sub
End Class