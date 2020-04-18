Public Class Pregunta5
    Private Sub bC_Click(sender As Object, e As EventArgs) Handles bC.Click
        Dim fin As New Fin
        fin.BackgroundImage = PreguntasyRespuestas.My.Resources.Resources.wp3638491
        fin.Show()
        Me.Close()
    End Sub

    Private Sub bA_Click(sender As Object, e As EventArgs) Handles bA.Click
        MessageBox.Show("Intentalo de Nuevo")
    End Sub

    Private Sub bB_Click(sender As Object, e As EventArgs) Handles bB.Click
        MessageBox.Show("Intentalo de Nuevo")
    End Sub
End Class