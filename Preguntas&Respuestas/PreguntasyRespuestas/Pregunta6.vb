Public Class Pregunta6
    Private Sub bB_Click(sender As Object, e As EventArgs) Handles bB.Click
        Dim fin As New Fin
        fin.BackgroundImage = PreguntasyRespuestas.My.Resources.Resources.wp3638491
        fin.Show()
        Me.Close()
    End Sub

    Private Sub bA_Click(sender As Object, e As EventArgs) Handles bA.Click
        MessageBox.Show("Intentalo de Nuevo")
        Score.scores += 1
    End Sub

    Private Sub bC_Click(sender As Object, e As EventArgs) Handles bC.Click
        MessageBox.Show("Intentalo de Nuevo")
        Score.scores += 1
    End Sub
End Class