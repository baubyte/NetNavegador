<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(productos))
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSistema = New System.Windows.Forms.Label()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.pnlContenido = New System.Windows.Forms.Panel()
        Me.lIdProducto = New System.Windows.Forms.Label()
        Me.pCampos = New System.Windows.Forms.Panel()
        Me.label8 = New System.Windows.Forms.Label()
        Me.tMarcaProducto = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.tCodProducto = New System.Windows.Forms.TextBox()
        Me.lIdProveedor = New System.Windows.Forms.Label()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.tStock = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.tPrecioCosto = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tProveedor = New System.Windows.Forms.TextBox()
        Me.tPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tNombreProducto = New System.Windows.Forms.TextBox()
        Me.gridProductos = New System.Windows.Forms.DataGridView()
        Me.NProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tBuscar = New System.Windows.Forms.TextBox()
        Me.menuClientes = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddProveedor = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pRestaurar = New System.Windows.Forms.PictureBox()
        Me.pMini = New System.Windows.Forms.PictureBox()
        Me.pMaxi = New System.Windows.Forms.PictureBox()
        Me.pCerrar = New System.Windows.Forms.PictureBox()
        Me.pnlMenu.SuspendLayout()
        Me.pnlTitulo.SuspendLayout()
        Me.pnlContenido.SuspendLayout()
        Me.pCampos.SuspendLayout()
        CType(Me.gridProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuClientes.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaxi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.Panel3)
        Me.pnlMenu.Controls.Add(Me.btnBorrar)
        Me.pnlMenu.Controls.Add(Me.Panel2)
        Me.pnlMenu.Controls.Add(Me.btnNuevo)
        Me.pnlMenu.Controls.Add(Me.Panel1)
        Me.pnlMenu.Controls.Add(Me.btnGuardar)
        Me.pnlMenu.Controls.Add(Me.lblSistema)
        Me.pnlMenu.Controls.Add(Me.PictureBox1)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 35)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(200, 615)
        Me.pnlMenu.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(3, 325)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(8, 64)
        Me.Panel3.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(3, 253)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(8, 64)
        Me.Panel2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(3, 179)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(8, 64)
        Me.Panel1.TabIndex = 3
        '
        'lblSistema
        '
        Me.lblSistema.AutoSize = True
        Me.lblSistema.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSistema.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSistema.ForeColor = System.Drawing.Color.White
        Me.lblSistema.Location = New System.Drawing.Point(101, 3)
        Me.lblSistema.Name = "lblSistema"
        Me.lblSistema.Size = New System.Drawing.Size(93, 81)
        Me.lblSistema.TabIndex = 0
        Me.lblSistema.Text = "Sistema " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gestion"
        Me.lblSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.pRestaurar)
        Me.pnlTitulo.Controls.Add(Me.pMini)
        Me.pnlTitulo.Controls.Add(Me.pMaxi)
        Me.pnlTitulo.Controls.Add(Me.pCerrar)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(1300, 35)
        Me.pnlTitulo.TabIndex = 2
        '
        'pnlContenido
        '
        Me.pnlContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.pnlContenido.Controls.Add(Me.lIdProducto)
        Me.pnlContenido.Controls.Add(Me.pCampos)
        Me.pnlContenido.Controls.Add(Me.gridProductos)
        Me.pnlContenido.Controls.Add(Me.Label2)
        Me.pnlContenido.Controls.Add(Me.Panel4)
        Me.pnlContenido.Controls.Add(Me.Label1)
        Me.pnlContenido.Controls.Add(Me.btnBuscar)
        Me.pnlContenido.Controls.Add(Me.tBuscar)
        Me.pnlContenido.Controls.Add(Me.menuClientes)
        Me.pnlContenido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenido.Location = New System.Drawing.Point(200, 35)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Size = New System.Drawing.Size(1100, 615)
        Me.pnlContenido.TabIndex = 4
        '
        'lIdProducto
        '
        Me.lIdProducto.AutoSize = True
        Me.lIdProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lIdProducto.ForeColor = System.Drawing.Color.White
        Me.lIdProducto.Location = New System.Drawing.Point(57, 90)
        Me.lIdProducto.Name = "lIdProducto"
        Me.lIdProducto.Size = New System.Drawing.Size(15, 16)
        Me.lIdProducto.TabIndex = 95
        Me.lIdProducto.Text = "0"
        '
        'pCampos
        '
        Me.pCampos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pCampos.Controls.Add(Me.btnAddProveedor)
        Me.pCampos.Controls.Add(Me.label8)
        Me.pCampos.Controls.Add(Me.tMarcaProducto)
        Me.pCampos.Controls.Add(Me.label7)
        Me.pCampos.Controls.Add(Me.tCodProducto)
        Me.pCampos.Controls.Add(Me.lIdProveedor)
        Me.pCampos.Controls.Add(Me.cmbCategoria)
        Me.pCampos.Controls.Add(Me.label6)
        Me.pCampos.Controls.Add(Me.tStock)
        Me.pCampos.Controls.Add(Me.label5)
        Me.pCampos.Controls.Add(Me.tPrecioCosto)
        Me.pCampos.Controls.Add(Me.label13)
        Me.pCampos.Controls.Add(Me.Label15)
        Me.pCampos.Controls.Add(Me.CheckBox1)
        Me.pCampos.Controls.Add(Me.Label3)
        Me.pCampos.Controls.Add(Me.Label16)
        Me.pCampos.Controls.Add(Me.tDescripcionProducto)
        Me.pCampos.Controls.Add(Me.Label10)
        Me.pCampos.Controls.Add(Me.tProveedor)
        Me.pCampos.Controls.Add(Me.tPrecioVenta)
        Me.pCampos.Controls.Add(Me.Label4)
        Me.pCampos.Controls.Add(Me.tNombreProducto)
        Me.pCampos.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pCampos.ForeColor = System.Drawing.Color.White
        Me.pCampos.Location = New System.Drawing.Point(20, 109)
        Me.pCampos.Name = "pCampos"
        Me.pCampos.Size = New System.Drawing.Size(568, 399)
        Me.pCampos.TabIndex = 58
        '
        'label8
        '
        Me.label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label8.AutoSize = True
        Me.label8.ForeColor = System.Drawing.Color.White
        Me.label8.Location = New System.Drawing.Point(28, 121)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(138, 23)
        Me.label8.TabIndex = 193
        Me.label8.Text = "Marca Producto:"
        '
        'tMarcaProducto
        '
        Me.tMarcaProducto.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tMarcaProducto.Location = New System.Drawing.Point(179, 114)
        Me.tMarcaProducto.MaxLength = 30
        Me.tMarcaProducto.Name = "tMarcaProducto"
        Me.tMarcaProducto.Size = New System.Drawing.Size(359, 30)
        Me.tMarcaProducto.TabIndex = 194
        '
        'label7
        '
        Me.label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label7.AutoSize = True
        Me.label7.ForeColor = System.Drawing.Color.White
        Me.label7.Location = New System.Drawing.Point(22, 77)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(138, 23)
        Me.label7.TabIndex = 191
        Me.label7.Text = "Código Producto:"
        '
        'tCodProducto
        '
        Me.tCodProducto.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tCodProducto.Location = New System.Drawing.Point(178, 74)
        Me.tCodProducto.MaxLength = 30
        Me.tCodProducto.Name = "tCodProducto"
        Me.tCodProducto.Size = New System.Drawing.Size(359, 30)
        Me.tCodProducto.TabIndex = 192
        '
        'lIdProveedor
        '
        Me.lIdProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lIdProveedor.AutoSize = True
        Me.lIdProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lIdProveedor.ForeColor = System.Drawing.Color.White
        Me.lIdProveedor.Location = New System.Drawing.Point(495, 306)
        Me.lIdProveedor.Name = "lIdProveedor"
        Me.lIdProveedor.Size = New System.Drawing.Size(20, 23)
        Me.lIdProveedor.TabIndex = 190
        Me.lIdProveedor.Text = "0"
        '
        'cmbCategoria
        '
        Me.cmbCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Items.AddRange(New Object() {"Seleccione Categoria", "Alimentos", "Panaderia", "Art. Limpieza", "Bebidas", "Fiambres", "Art. Varios"})
        Me.cmbCategoria.Location = New System.Drawing.Point(179, 343)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(359, 31)
        Me.cmbCategoria.TabIndex = 189
        '
        'label6
        '
        Me.label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label6.AutoSize = True
        Me.label6.ForeColor = System.Drawing.Color.White
        Me.label6.Location = New System.Drawing.Point(22, 269)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(144, 23)
        Me.label6.TabIndex = 188
        Me.label6.Text = "Stock Disponible:"
        '
        'tStock
        '
        Me.tStock.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tStock.Location = New System.Drawing.Point(178, 266)
        Me.tStock.MaxLength = 10
        Me.tStock.Name = "tStock"
        Me.tStock.Size = New System.Drawing.Size(99, 30)
        Me.tStock.TabIndex = 187
        '
        'label5
        '
        Me.label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label5.AutoSize = True
        Me.label5.ForeColor = System.Drawing.Color.White
        Me.label5.Location = New System.Drawing.Point(295, 238)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(137, 23)
        Me.label5.TabIndex = 186
        Me.label5.Text = "Precio de Costo:"
        '
        'tPrecioCosto
        '
        Me.tPrecioCosto.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tPrecioCosto.Location = New System.Drawing.Point(438, 235)
        Me.tPrecioCosto.MaxLength = 10
        Me.tPrecioCosto.Name = "tPrecioCosto"
        Me.tPrecioCosto.Size = New System.Drawing.Size(99, 30)
        Me.tPrecioCosto.TabIndex = 185
        '
        'label13
        '
        Me.label13.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label13.AutoSize = True
        Me.label13.ForeColor = System.Drawing.Color.White
        Me.label13.Location = New System.Drawing.Point(330, 269)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(69, 23)
        Me.label13.TabIndex = 184
        Me.label13.Text = "Estado:"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(22, 235)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(140, 23)
        Me.Label15.TabIndex = 183
        Me.Label15.Text = "Precio de Venta:"
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(438, 268)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(95, 27)
        Me.CheckBox1.TabIndex = 182
        Me.CheckBox1.Text = "¿Activo?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(22, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 23)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "Proveedor:"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(22, 162)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 69)
        Me.Label16.TabIndex = 180
        Me.Label16.Text = "Descripción " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Producto:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tDescripcionProducto
        '
        Me.tDescripcionProducto.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tDescripcionProducto.Location = New System.Drawing.Point(178, 154)
        Me.tDescripcionProducto.MaxLength = 200
        Me.tDescripcionProducto.Multiline = True
        Me.tDescripcionProducto.Name = "tDescripcionProducto"
        Me.tDescripcionProducto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tDescripcionProducto.Size = New System.Drawing.Size(359, 66)
        Me.tDescripcionProducto.TabIndex = 178
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(22, 346)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 23)
        Me.Label10.TabIndex = 179
        Me.Label10.Text = "Categoria Producto:"
        '
        'tProveedor
        '
        Me.tProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tProveedor.Location = New System.Drawing.Point(178, 304)
        Me.tProveedor.MaxLength = 30
        Me.tProveedor.Name = "tProveedor"
        Me.tProveedor.ReadOnly = True
        Me.tProveedor.Size = New System.Drawing.Size(246, 30)
        Me.tProveedor.TabIndex = 177
        '
        'tPrecioVenta
        '
        Me.tPrecioVenta.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tPrecioVenta.Location = New System.Drawing.Point(178, 232)
        Me.tPrecioVenta.MaxLength = 10
        Me.tPrecioVenta.Name = "tPrecioVenta"
        Me.tPrecioVenta.Size = New System.Drawing.Size(99, 30)
        Me.tPrecioVenta.TabIndex = 176
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(22, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 23)
        Me.Label4.TabIndex = 174
        Me.Label4.Text = "Nombre Producto:"
        '
        'tNombreProducto
        '
        Me.tNombreProducto.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tNombreProducto.Location = New System.Drawing.Point(178, 37)
        Me.tNombreProducto.MaxLength = 30
        Me.tNombreProducto.Name = "tNombreProducto"
        Me.tNombreProducto.Size = New System.Drawing.Size(359, 30)
        Me.tNombreProducto.TabIndex = 175
        '
        'gridProductos
        '
        Me.gridProductos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NProducto, Me.CodigoProducto, Me.Producto, Me.Precio})
        Me.gridProductos.Location = New System.Drawing.Point(630, 100)
        Me.gridProductos.Name = "gridProductos"
        Me.gridProductos.ReadOnly = True
        Me.gridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridProductos.Size = New System.Drawing.Size(458, 503)
        Me.gridProductos.TabIndex = 7
        '
        'NProducto
        '
        Me.NProducto.DataPropertyName = "NProducto"
        Me.NProducto.HeaderText = "NProducto"
        Me.NProducto.Name = "NProducto"
        Me.NProducto.ReadOnly = True
        Me.NProducto.Visible = False
        '
        'CodigoProducto
        '
        Me.CodigoProducto.DataPropertyName = "CodigoProducto"
        Me.CodigoProducto.HeaderText = "Codigo Producto"
        Me.CodigoProducto.Name = "CodigoProducto"
        Me.CodigoProducto.ReadOnly = True
        '
        'Producto
        '
        Me.Producto.DataPropertyName = "Producto"
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.DataPropertyName = "PrecioVenta"
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(523, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*Si dejas Vacio Trae Todo"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(841, 46)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(8, 38)
        Me.Panel4.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(72, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrese Nombre para Buscar un Producto"
        '
        'tBuscar
        '
        Me.tBuscar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBuscar.Location = New System.Drawing.Point(412, 48)
        Me.tBuscar.Name = "tBuscar"
        Me.tBuscar.Size = New System.Drawing.Size(392, 30)
        Me.tBuscar.TabIndex = 1
        '
        'menuClientes
        '
        Me.menuClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.menuClientes.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuClientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.menuClientes.Location = New System.Drawing.Point(0, 0)
        Me.menuClientes.Name = "menuClientes"
        Me.menuClientes.Size = New System.Drawing.Size(1100, 24)
        Me.menuClientes.TabIndex = 0
        Me.menuClientes.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'btnAddProveedor
        '
        Me.btnAddProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAddProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProveedor.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProveedor.Image = Global.sistema.My.Resources.Resources.proveedorOp2
        Me.btnAddProveedor.Location = New System.Drawing.Point(438, 298)
        Me.btnAddProveedor.Name = "btnAddProveedor"
        Me.btnAddProveedor.Size = New System.Drawing.Size(37, 36)
        Me.btnAddProveedor.TabIndex = 195
        Me.btnAddProveedor.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddProveedor.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Image = Global.sistema.My.Resources.Resources.buscar
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(844, 46)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(191, 38)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.InicioToolStripMenuItem.Image = Global.sistema.My.Resources.Resources.gestion
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ProveedoresToolStripMenuItem.Image = Global.sistema.My.Resources.Resources.proveedorOp2
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ToolStripMenuItem1.Image = Global.sistema.My.Resources.Resources.clientes
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(146, 22)
        Me.ToolStripMenuItem1.Text = "Clientes"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.SalirToolStripMenuItem.Image = Global.sistema.My.Resources.Resources.salir
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'btnBorrar
        '
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.FlatAppearance.BorderSize = 0
        Me.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.ForeColor = System.Drawing.Color.White
        Me.btnBorrar.Image = Global.sistema.My.Resources.Resources.productDelete
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrar.Location = New System.Drawing.Point(12, 325)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(185, 64)
        Me.btnBorrar.TabIndex = 6
        Me.btnBorrar.Text = "&Borrar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Producto"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Image = Global.sistema.My.Resources.Resources.productAdd
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(12, 253)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(185, 64)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "&Nuevo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Producto"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Image = Global.sistema.My.Resources.Resources.Save_37110
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(12, 179)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(185, 64)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "&Guardar "
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.sistema.My.Resources.Resources.gestion
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pRestaurar
        '
        Me.pRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pRestaurar.Image = Global.sistema.My.Resources.Resources.restore
        Me.pRestaurar.Location = New System.Drawing.Point(1218, 3)
        Me.pRestaurar.Name = "pRestaurar"
        Me.pRestaurar.Size = New System.Drawing.Size(32, 32)
        Me.pRestaurar.TabIndex = 3
        Me.pRestaurar.TabStop = False
        Me.pRestaurar.Visible = False
        '
        'pMini
        '
        Me.pMini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pMini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pMini.Image = Global.sistema.My.Resources.Resources.minimize
        Me.pMini.Location = New System.Drawing.Point(1180, 3)
        Me.pMini.Name = "pMini"
        Me.pMini.Size = New System.Drawing.Size(32, 32)
        Me.pMini.TabIndex = 2
        Me.pMini.TabStop = False
        '
        'pMaxi
        '
        Me.pMaxi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pMaxi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pMaxi.Image = Global.sistema.My.Resources.Resources.maximize
        Me.pMaxi.Location = New System.Drawing.Point(1218, 3)
        Me.pMaxi.Name = "pMaxi"
        Me.pMaxi.Size = New System.Drawing.Size(32, 32)
        Me.pMaxi.TabIndex = 1
        Me.pMaxi.TabStop = False
        '
        'pCerrar
        '
        Me.pCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pCerrar.Image = Global.sistema.My.Resources.Resources.cancel1
        Me.pCerrar.Location = New System.Drawing.Point(1256, 3)
        Me.pCerrar.Name = "pCerrar"
        Me.pCerrar.Size = New System.Drawing.Size(32, 32)
        Me.pCerrar.TabIndex = 0
        Me.pCerrar.TabStop = False
        '
        'productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 650)
        Me.Controls.Add(Me.pnlContenido)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(1300, 650)
        Me.Name = "productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "productos"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlContenido.ResumeLayout(False)
        Me.pnlContenido.PerformLayout()
        Me.pCampos.ResumeLayout(False)
        Me.pCampos.PerformLayout()
        CType(Me.gridProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuClientes.ResumeLayout(False)
        Me.menuClientes.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaxi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnBorrar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblSistema As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pCerrar As PictureBox
    Friend WithEvents pMaxi As PictureBox
    Friend WithEvents pMini As PictureBox
    Friend WithEvents pRestaurar As PictureBox
    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents pnlContenido As Panel
    Friend WithEvents lIdProducto As Label
    Friend WithEvents pCampos As Panel
    Friend WithEvents gridProductos As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents tBuscar As TextBox
    Friend WithEvents menuClientes As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NProducto As DataGridViewTextBoxColumn
    Friend WithEvents CodigoProducto As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents label8 As Label
    Friend WithEvents tMarcaProducto As TextBox
    Friend WithEvents label7 As Label
    Friend WithEvents tCodProducto As TextBox
    Public WithEvents lIdProveedor As Label
    Private WithEvents cmbCategoria As ComboBox
    Friend WithEvents label6 As Label
    Friend WithEvents tStock As TextBox
    Friend WithEvents label5 As Label
    Friend WithEvents tPrecioCosto As TextBox
    Friend WithEvents label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents tDescripcionProducto As TextBox
    Friend WithEvents Label10 As Label
    Public WithEvents tProveedor As TextBox
    Friend WithEvents tPrecioVenta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tNombreProducto As TextBox
    Friend WithEvents btnAddProveedor As Button
End Class
