'Clases para ADO, para la Conexion con la DB
Imports System.Data.SqlClient
Public Class BuscarProveedor
    Dim ar As String
    Dim connection As New SqlConnection("" & LeerConfig(ar) & "")
    'Para Buscar los Clientes
    Sub buscar(ByVal condicion As String)
        Dim dataAdapter As New SqlDataAdapter("SELECT TOP (100) PERCENT NProveedor, ApeYNom, CUIT FROM ProveedoresBusqueda WHERE " & condicion & " ORDER BY ApeYNom", connection)
        Dim dataSet As New DataSet
        dataAdapter.Fill(dataSet, "proveedores")
        If dataSet.Tables("proveedores").Rows.Count = 0 Then
            gridProveedores.Visible = False
        Else
            gridProveedores.DataSource = dataSet.Tables("proveedores")
            gridProveedores.Refresh()
            gridProveedores.Visible = True
        End If

    End Sub

    Private Sub BuscarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar(" ApeYNom LIKE '" & tBuscar.Text & "%' ")
    End Sub

    Private Sub gridProveedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridProveedores.CellDoubleClick
        Dim productos As productos = CType(Owner, productos)
        productos.lIdProveedor.Text = gridProveedores.CurrentRow.Cells(0).Value.ToString()
        productos.tProveedor.Text = gridProveedores.CurrentRow.Cells(1).Value.ToString()
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar(" ApeYNom LIKE '" & tBuscar.Text & "%' ")
    End Sub
End Class