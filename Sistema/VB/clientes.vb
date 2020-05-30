Imports System.Runtime.InteropServices
'Clases para ADO, para la Conexion con la DB
Imports System.Data.SqlClient

Public Class clientes
    Dim ar As String
    Dim connection As New SqlConnection("" & LeerConfig(ar) & "")
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
    Private Sub pTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTitulo.MouseDown
        If e.Button = MouseButtons.Left Then
            moverForm()
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.ExitThread()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Dim inicio As New inicio
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar(" ApeYNom LIKE '" & tBuscar.Text & "%' ")
    End Sub
    'Para Buscar los Clientes
    Sub buscar(ByVal condicion As String)
        Dim dataAdapter As New SqlDataAdapter("SELECT TOP (100) PERCENT NCliente, ApeYNom, CUIT FROM ClientesBusqueda WHERE " & condicion & " ORDER BY ApeYNom", connection)
        Dim dataSet As New DataSet
        dataAdapter.Fill(dataSet, "clientes")
        If dataSet.Tables("clientes").Rows.Count = 0 Then

            gridClientes.Visible = False
            pCampos.Visible = False
            lIdCliente.Visible = False
            pCampos.Visible = False
            btnGuardar.Visible = False
            btnBorrar.Visible = False
            Panel1.Visible = False
            Panel3.Visible = False
        Else
            gridClientes.DataSource = dataSet.Tables("clientes")
            gridClientes.Refresh()
            gridClientes.Visible = True
            lIdCliente.Visible = True
            btnGuardar.Visible = True
            btnBorrar.Visible = True
            Panel1.Visible = True
            Panel3.Visible = True
        End If

    End Sub

    Private Sub clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar(" ApeYNom LIKE '" & tBuscar.Text & "%' ")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If SqlAccion("INSERT INTO Clientes (ApellidoCliente ,NombreCliente ,DocumentoCliente ,CuitCliente ,UsuarioCliente ,ClaveCliente ,DomicilioCliente ,PostalCliente ,LocalidadCliente ,ProvinciaCliente ,TelefonoCliente ,FechaNacimientoCliente ,ComentariosCliente ,EMailCliente ,Estado) VALUES ('*****', '*****','','','', '', '', '', '', '','', getdate(), '', '', 1)  ") Then
            buscar(" ApeYNom LIKE '****%' ")
            MsgBox("Se ha Creado un Nuevo Registro para el Cliente que Desea Ingresar, Seleccione la Línea Nueva, Cargue los Datos y Luego Confirme con el Botón 'Guardar Cambios'.", MsgBoxStyle.Information, "Nuevo Cliente")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If MessageBox.Show("Está por ELIMINAR definitivamente el Cliente: " & tApellido.Text.Trim.ToUpper & " " & tNombre.Text.Trim.ToUpper & ",. Es algo EXTREMO. Está SEGURO?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        'Ejecutamos el Delete
        If SqlAccion("DELETE FROM Clientes  WHERE  NCliente=" & Val(lIdCliente.Text)) = False Then
            MsgBox("Hubo un Error al intentar Borrar el Cliente, Reintente, y Si el Error Persiste, Anote Todos los Datos que Quizo Ingresar y Comuníquese con el Programador (Otra Vez).", MsgBoxStyle.Information, "Eliminar Cliente")
        Else
            buscar(" NCliente=" & Val(lIdCliente.Text))
            MsgBox("El Cliente fue ELIMINADO de la Base de Datos.")
        End If
    End Sub
    'Filtro al Hacer Click en una fila
    Private Sub gridClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridClientes.CellContentClick
        FilaClick(e)
    End Sub
    'Filtro al Dar Enter en una fila
    Private Sub gridClientes_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles gridClientes.RowEnter
        FilaClick(e)
    End Sub
    'Filtro de la Fila Seleccionada
    Sub FilaClick(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String

        If IsNothing(gridClientes.Rows(fila).Cells(0).Value) Then
            lIdCliente.Text = "0"
            btnGuardar.Visible = False
            btnBorrar.Visible = False
            btnNuevo.Visible = False
            pCampos.Visible = False
            Panel1.Visible = False
            Panel2.Visible = False
            Panel3.Visible = False
            Exit Sub
        Else
            tfila = gridClientes.Rows(fila).Cells(0).Value
            lIdCliente.Text = tfila.ToString()
            CargarCamposClientes()
        End If
    End Sub
    'Carga los Datos del Cliente seleccionado en los campos
    Sub CargarCamposClientes()
        If Val(lIdCliente.Text) = 0 Then
            pCampos.Visible = False
            Exit Sub
        Else
            pCampos.Visible = True
            Dim dataAdapter As New SqlDataAdapter("SELECT UPPER(LTRIM(RTRIM(ISNULL(ApellidoCliente,'****')))) AS ApellidoCliente, 
		                                                  UPPER(LTRIM(RTRIM(ISNULL(NombreCliente,'****')))) AS NombreCliente, 
		                                                    LTRIM(RTRIM(ISNULL(DocumentoCliente,''))) AS DocumentoCliente, 
		                                                    LTRIM(RTRIM(ISNULL(CuitCliente,''))) AS CuitCliente, 
		                                                    LTRIM(RTRIM(ISNULL(UsuarioCliente,''))) AS UsuarioCliente, 
		                                                    LTRIM(RTRIM(ISNULL(ClaveCliente,''))) AS ClaveCliente, 
		                                                    LTRIM(RTRIM(ISNULL(DomicilioCliente,''))) AS DomicilioCliente, 
		                                                    LTRIM(RTRIM(ISNULL(PostalCliente,''))) AS PostalCliente, 
		                                                    LTRIM(RTRIM(ISNULL(LocalidadCliente,''))) AS LocalidadCliente, 
		                                                    LTRIM(RTRIM(ISNULL(ProvinciaCliente,''))) AS ProvinciaCliente, 
		                                                    LTRIM(RTRIM(ISNULL(TelefonoCliente,''))) TelefonoCliente, 
		                                                    FechaNacimientoCliente, 
		                                                    LTRIM(RTRIM(ISNULL(ComentariosCliente,''))) AS ComentariosCliente, 
		                                                    LTRIM(RTRIM(ISNULL(EMailCliente,''))) AS EMailCliente, 
		                                                    isnull(Estado,0) AS Estado
                                                     FROM Clientes WHERE NCliente=" & Val(lIdCliente.Text), connection)
            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "clientes")
            tApellido.Text = dataSet.Tables("clientes").Rows(0)("ApellidoCliente")
            tNombre.Text = dataSet.Tables("clientes").Rows(0)("NombreCliente")
            tDNI.Text = dataSet.Tables("clientes").Rows(0)("DocumentoCliente")
            DateTimePicker1.Value = dataSet.Tables("clientes").Rows(0)("FechaNacimientoCliente")
            CheckBox1.Checked = IIf(dataSet.Tables("clientes").Rows(0)("Estado") = 0, False, True)
            tCUIT.Text = dataSet.Tables("clientes").Rows(0)("CuitCliente")
            tUsuario.Text = dataSet.Tables("clientes").Rows(0)("UsuarioCliente")
            tClave.Text = dataSet.Tables("clientes").Rows(0)("ClaveCliente")
            tDireccion.Text = dataSet.Tables("clientes").Rows(0)("DomicilioCliente")
            tLocalidad.Text = dataSet.Tables("clientes").Rows(0)("LocalidadCliente")
            tCP.Text = dataSet.Tables("clientes").Rows(0)("PostalCliente")
            tProvincia.Text = dataSet.Tables("clientes").Rows(0)("ProvinciaCliente")
            tTelefono.Text = dataSet.Tables("clientes").Rows(0)("TelefonoCliente")
            tEmail.Text = dataSet.Tables("clientes").Rows(0)("EMailCliente")
            tComentario.Text = dataSet.Tables("clientes").Rows(0)("ComentariosCliente")
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub
End Class