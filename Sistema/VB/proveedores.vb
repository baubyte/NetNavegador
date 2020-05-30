Public Class proveedores

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim inicio As New inicio
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim ambClientes As New clientes
        ambClientes.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.ExitThread()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class