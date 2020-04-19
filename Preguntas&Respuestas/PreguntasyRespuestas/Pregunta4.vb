Public Class Pregunta4
    Private Sub bA_Click(sender As Object, e As EventArgs) Handles bA.Click
        Dim preg5 As New Pregunta5
        preg5.BackgroundImage = PreguntasyRespuestas.My.Resources.Resources.wp3638491
        preg5.Show()
        Me.Close()
    End Sub

    Private Sub bB_Click(sender As Object, e As EventArgs) Handles bB.Click
        MessageBox.Show("Intentalo de Nuevo")
        Score.scores += 1
    End Sub

    Private Sub bC_Click(sender As Object, e As EventArgs) Handles bC.Click
        MessageBox.Show("Intentalo de Nuevo")
        Score.scores += 1
    End Sub
End Class