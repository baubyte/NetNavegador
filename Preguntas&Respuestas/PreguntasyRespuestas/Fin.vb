Public Class Fin
    Private Sub bComenzar_Click(sender As Object, e As EventArgs) Handles bComenzar.Click
        Dim formPrincipal As New Form1
        formPrincipal.BackgroundImage = PreguntasyRespuestas.My.Resources.Resources.wp3638491
        formPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        End
    End Sub
End Class