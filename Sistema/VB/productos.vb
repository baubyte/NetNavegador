Imports System.Runtime.InteropServices
'Clases para ADO, para la Conexion con la DB
Imports System.Data.SqlClient
Public Class productos
    Dim ar As String
    Dim connection As New SqlConnection("" & LeerConfig(ar) & "")
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim clientes As New clientes
        clientes.Show()
        Me.Close()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Dim inicio As New inicio
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim proveedores As New proveedores
        proveedores.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim login As New login
        login.Show()
        Me.Close()
    End Sub

    Private Sub pCerrar_Click(sender As Object, e As EventArgs) Handles pCerrar.Click
        Application.ExitThread()
    End Sub

    Private Sub pRestaurar_Click(sender As Object, e As EventArgs) Handles pRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        pRestaurar.Visible = False
        pMaxi.Visible = True
    End Sub

    Private Sub pMaxi_Click(sender As Object, e As EventArgs) Handles pMaxi.Click
        Me.WindowState = FormWindowState.Maximized
        pMaxi.Visible = False
        pRestaurar.Visible = True
    End Sub

    Private Sub pMini_Click(sender As Object, e As EventArgs) Handles pMini.Click
        WindowState = FormWindowState.Minimized
    End Sub
    'Funciones para mover la ventana sin la barra de titulo
    Private Const WM_SYSCOMMAND As Integer = &H112&
    Private Const MOUSE_MOVE As Integer = &HF012&

    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    '
    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(
        ByVal hWnd As System.IntPtr, ByVal wMsg As Integer,
        ByVal wParam As Integer, ByVal lParam As Integer
        )
    End Sub

    'función privada usada para mover el formulario actual
    Private Sub moverForm()
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0)
    End Sub
    Private Sub pnlTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTitulo.MouseDown
        If e.Button = MouseButtons.Left Then
            moverForm()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar(" Producto LIKE '" & tBuscar.Text & "%' ")
    End Sub
    'Para Buscar los Productos
    Sub buscar(ByVal condicion As String)
        Dim dataAdapter As New SqlDataAdapter("SELECT TOP (100) PERCENT NProducto,CodigoProducto , Producto, PrecioVenta FROM ProductosBusqueda WHERE " + condicion + " ORDER BY Producto", connection)
        Dim dataSet As New DataSet
        dataAdapter.Fill(dataSet, "productos")
        If dataSet.Tables("productos").Rows.Count = 0 Then

            gridProductos.Visible = False
            pCampos.Visible = False
            lIdProveedor.Visible = False
            btnGuardar.Visible = False
            btnBorrar.Visible = False
            Panel1.Visible = False
            Panel3.Visible = False
        Else
            gridProductos.DataSource = dataSet.Tables("productos")
            gridProductos.Refresh()
            gridProductos.Visible = True
            lIdProveedor.Visible = True
            btnGuardar.Visible = True
            btnBorrar.Visible = True
            Panel1.Visible = True
            Panel3.Visible = True
        End If

    End Sub

    Private Sub productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar(" Producto LIKE '" & tBuscar.Text & "%' ")
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If SqlAccion("INSERT INTO Productos (NombreProducto,CodigoProducto,MarcaProducto,DescripcionProducto,PrecioProducto,PrecioCostoProducto,StockProducto,NProveedor,CategoriaProducto,Estado) VALUES ('*****', '*****','****','','','', '', '','', 1) ") Then
            buscar(" Producto LIKE '****%' ")
            MsgBox("Se ha Creado un Nuevo Registro para el Producto que Desea Ingresar, Seleccione la Línea Nueva, Cargue los Datos y Luego Confirme con el Botón 'Guardar Cambios'.", MsgBoxStyle.Information, "Nuevo Producto")
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If MessageBox.Show("Está por ELIMINAR definitivamente el Producto: " & tNombreProducto.Text.Trim.ToUpper & " " & tCodProducto.Text.Trim.ToUpper & ",. Es algo EXTREMO. Está SEGURO?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        'Ejecutamos el Delete
        If SqlAccion("DELETE FROM Productos  WHERE  NProducto=" & Val(lIdProducto.Text)) = False Then
            MsgBox("Hubo un Error al intentar Borrar el Producto, Reintente, y Si el Error Persiste, Anote Todos los Datos que Quizo Ingresar y Comuníquese con el Programador (Otra Vez).", MsgBoxStyle.Information, "Eliminar Producto")
        Else
            buscar(" NProducto=" & Val(lIdProducto.Text))
            MsgBox("El Producto fue ELIMINADO de la Base de Datos.", MsgBoxStyle.Information, "Eliminar Producto")
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim errores As String = ""
        Dim enter As String = Constants.vbCrLf

        If tNombreProducto.Text.Trim().Length < 3 Then
            errores += "Debe Completar el Nombre del Producto." & enter
        End If

        tCodProducto.Text = Val(tCodProducto.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "").Replace("-", ""))

        If tCodProducto.Text.Trim().Length < 4 Or tCodProducto.Text.IndexOf("11111") > -1 Or tCodProducto.Text.IndexOf("12345") > -1 Or tCodProducto.Text.IndexOf("000000") > -1 Then
            errores += "Debe completar CORRECTAMENTE el Código del Producto." & enter
        End If
        If Routines.YaExisteSql("SELECT CodigoProducto FROM Productos WHERE CodigoProducto =" & Routines.Vnum(tCodProducto.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "")) & " AND NProducto != " & Routines.Vnum(lIdProducto.Text)) = True Then
            errores += "El Código del Producto Ingresado ya Existe." & enter
        End If

        tPrecioVenta.Text = tPrecioVenta.Text.Trim().Replace("-", "")

        If tPrecioVenta.Text.IndexOf("11111") > -1 Or tPrecioVenta.Text.IndexOf("12345") > -1 Or tPrecioVenta.Text.IndexOf("000000") > -1 Or Routines.Vnum(tPrecioVenta.Text) <= 0 Then
            errores += "Debe completar CORRECTAMENTE el Precio de Venta." & enter
        End If

        tPrecioCosto.Text = tPrecioCosto.Text.Trim().Replace("-", "")

        If tPrecioCosto.Text.IndexOf("11111") > -1 Or tPrecioCosto.Text.IndexOf("12345") > -1 Or tPrecioCosto.Text.IndexOf("000000") > -1 Or Routines.Vnum(tPrecioCosto.Text) <= 0 Then
            errores += "Debe completar CORRECTAMENTE el Precio de Costo." & enter
        End If

        tStock.Text = tStock.Text.Trim().Replace("-", "")

        If tStock.Text.IndexOf("11111") > -1 Or tStock.Text.IndexOf("12345") > -1 Or tStock.Text.IndexOf("000000") > -1 Or Routines.Vnum(tStock.Text) <= 0 Then
            errores += "Debe completar CORRECTAMENTE el Stock del Producto." & enter
        End If

        If tProveedor.Text.Trim().Length < 3 Then
            errores += "Debe Completar el Nombre del Proveedor." & enter
        End If

        If cmbCategoria.SelectedIndex = 0 Then
            errores += "Debe Sellecionar una Categoria." & enter
        End If

        If errores.Length > 0 Then
            MessageBox.Show("Hubo errores, Por Favor Verifique y Corrija Antes de Intentar de Nuevo:" & enter & enter & errores, "Errores", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If Routines.SqlAccion("UPDATE Productos SET Estado =" & (If(CheckBox1.Checked, 1, 0)) & ", NombreProducto='" & tNombreProducto.Text.Trim().ToUpper().Replace("'", "´") & "' , MarcaProducto='" & tMarcaProducto.Text.Trim().ToUpper().Replace("'", "´") & "', CodigoProducto=" & Conversion.Val(tCodProducto.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "")) & ", PrecioProducto =" & Routines.NumSql(tPrecioVenta.Text.Trim().Replace(" ", "")) & ", DescripcionProducto='" & tDescripcionProducto.Text.Trim().ToUpper().Replace("'", "´") & "', CategoriaProducto='" & cmbCategoria.SelectedItem & "', PrecioCostoProducto='" & Routines.NumSql(tPrecioCosto.Text.Trim().Replace(" ", "")) & "', StockProducto='" & Routines.NumSql(tStock.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "")) & "', NProveedor='" & Conversion.Val(lIdProveedor.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "")) & "' WHERE NProducto=" & Routines.Vnum(lIdProducto.Text)) = True Then
            MessageBox.Show("Cambios Realizados Correctamente.", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            buscar(" NProducto=" & Routines.Vnum(lIdProducto.Text))
        Else
            MessageBox.Show("Se Produjo un Error al Querer Guardar los Datos del Producto, Reintente, y si el Error Persiste, Anote Todos los Datos que Quizo Ingresar y Comuníquese con el Programador (Otra Vez).", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub gridProductos_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles gridProductos.RowEnter
        FilaClick(e)
    End Sub
    'Filtro de la Fila Seleccionada
    Sub FilaClick(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String
        If IsNothing(gridProductos.Rows(fila).Cells(0).Value) Then
            lIdProducto.Text = "0"
            btnGuardar.Visible = False
            btnBorrar.Visible = False
            btnNuevo.Visible = False
            pCampos.Visible = False
            Panel1.Visible = False
            Panel2.Visible = False
            Panel3.Visible = False
            Exit Sub
        Else
            tfila = gridProductos.Rows(fila).Cells(0).Value
            lIdProducto.Text = tfila.ToString()
            btnGuardar.Visible = True
            btnBorrar.Visible = True
            btnNuevo.Visible = True
            pCampos.Visible = True
            Panel1.Visible = True
            Panel2.Visible = True
            Panel3.Visible = True
            CargarCamposProductos()
        End If
    End Sub
    'Carga los Datos del Producto seleccionado en los campos
    Sub CargarCamposProductos()
        If Val(lIdProducto.Text) = 0 Then
            pCampos.Visible = False
            Exit Sub
        Else
            pCampos.Visible = True
            Dim dataAdapter As New SqlDataAdapter("SELECT TOP (100) PERCENT dbo.Productos.NProducto, UPPER(LTRIM(RTRIM(ISNULL(dbo.Productos.NombreProducto,'****')))) AS NombreProducto, LTRIM(RTRIM(ISNULL(dbo.Productos.CodigoProducto, ''))) AS CodigoProducto, UPPER(LTRIM(RTRIM(ISNULL(dbo.Productos.MarcaProducto, '*')))) AS MarcaProducto, UPPER(LTRIM(RTRIM(ISNULL(dbo.Productos.DescripcionProducto, '****')))) AS DescripcionProducto, LTRIM(RTRIM(ISNULL(dbo.Productos.PrecioProducto, ''))) AS PrecioProducto, LTRIM(RTRIM(ISNULL(dbo.Productos.PrecioCostoProducto, ''))) AS PrecioCostoProducto, LTRIM(RTRIM(ISNULL(dbo.Productos.StockProducto, ''))) AS StockProducto, UPPER(LTRIM(dbo.Proveedores.NombreProveedor) + ', ' + LTRIM(dbo.Proveedores.ApellidoProveedor)) AS Proveedor, LTRIM(RTRIM(ISNULL(dbo.Productos.CategoriaProducto, ''))) AS CategoriaProducto, ISNULL(dbo.Productos.Estado, 0) AS Estado, dbo.Proveedores.NProveedor AS NProveedor FROM dbo.Productos LEFT JOIN dbo.Proveedores ON dbo.Productos.NProveedor = dbo.Proveedores.NProveedor WHERE dbo.Productos.NProducto = " & Val(lIdProducto.Text), connection)
            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "productos")
            tNombreProducto.Text = dataSet.Tables("productos").Rows(0)("NombreProducto").ToString()
            tCodProducto.Text = dataSet.Tables("productos").Rows(0)("CodigoProducto").ToString()
            tMarcaProducto.Text = dataSet.Tables("productos").Rows(0)("MarcaProducto").ToString()
            tDescripcionProducto.Text = dataSet.Tables("productos").Rows(0)("DescripcionProducto").ToString()
            tPrecioCosto.Text = dataSet.Tables("productos").Rows(0)("PrecioCostoProducto").ToString()
            tPrecioVenta.Text = dataSet.Tables("productos").Rows(0)("PrecioProducto").ToString()
            tStock.Text = dataSet.Tables("productos").Rows(0)("StockProducto").ToString()
            CheckBox1.Checked = IIf(dataSet.Tables("productos").Rows(0)("Estado") = 0, False, True)
            tProveedor.Text = dataSet.Tables("productos").Rows(0)("Proveedor").ToString()
            cmbCategoria.SelectedIndex = cmbCategoria.FindString(dataSet.Tables("productos").Rows(0)("CategoriaProducto").ToString())
            'ID del Proveedor Actual
            lIdProveedor.Text = dataSet.Tables("productos").Rows(0)("NProveedor").ToString()
        End If
    End Sub

    Private Sub btnAddProveedor_Click(sender As Object, e As EventArgs) Handles btnAddProveedor.Click
        Dim buscarProveedor As New BuscarProveedor
        AddOwnedForm(buscarProveedor)
        buscarProveedor.ShowDialog()
    End Sub
End Class