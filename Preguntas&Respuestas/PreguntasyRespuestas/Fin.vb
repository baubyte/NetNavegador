Public Class Fin
    Private Sub bComenzar_Click(sender As Object, e As EventArgs) Handles bComenzar.Click
        Dim formPrincipal As New Form1
        formPrincipal.BackgroundImage = PreguntasyRespuestas.My.Resources.Resources.wp3638491
        formPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lText.Click

    End Sub

    Private Sub Fin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lPuntaje.Text = Score.scores
    End Sub

    Private Sub lTitulo_Click(sender As Object, e As EventArgs) Handles lTitulo.Click
    End Sub
End Class