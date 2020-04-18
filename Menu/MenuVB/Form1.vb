Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        If MessageBox.Show("¿Seguro que Quieres Salir?", "Salir del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then End
    End Sub

    Private Sub bClientes_Click(sender As Object, e As EventArgs) Handles bClientes.Click
        Dim cliente As New Clientes
        cliente.BackColor = Color.Red
        cliente.ShowDialog()
    End Sub

    Private Sub SistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SistemaToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MessageBox.Show("¿Seguro que Quieres Salir?", "Salir del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then End
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim cliente As New Clientes
        cliente.BackColor = Color.Red
        cliente.ShowDialog()
    End Sub
End Class
