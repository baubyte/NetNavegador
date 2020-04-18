Public Class Pregunta3
    Private Sub bB_Click(sender As Object, e As EventArgs) Handles bB.Click
        Dim preg4 As New Pregunta4
        preg4.BackgroundImage = PreguntasyRespuestas.My.Resources.Resources.wp3638491
        preg4.Show()
        Me.Close()
    End Sub

    Private Sub bA_Click(sender As Object, e As EventArgs) Handles bA.Click
        MessageBox.Show("Intentalo de Nuevo")
    End Sub

    Private Sub bC_Click(sender As Object, e As EventArgs) Handles bC.Click
        MessageBox.Show("Intentalo de Nuevo")
    End Sub
End Class