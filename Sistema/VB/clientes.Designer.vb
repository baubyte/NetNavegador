<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class clientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clientes))
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.pRestaurar = New System.Windows.Forms.PictureBox()
        Me.pMini = New System.Windows.Forms.PictureBox()
        Me.pMaxi = New System.Windows.Forms.PictureBox()
        Me.pCerrar = New System.Windows.Forms.PictureBox()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblSistema = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlContenido = New System.Windows.Forms.Panel()
        Me.lIdCliente = New System.Windows.Forms.Label()
        Me.pCampos = New System.Windows.Forms.Panel()
        Me.tEmail = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tClave = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tUsuario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tCUIT = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tLocalidad = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tComentario = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tTelefono = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tProvincia = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tCP = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tDireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tDNI = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tApellido = New System.Windows.Forms.TextBox()
        Me.gridClientes = New System.Windows.Forms.DataGridView()
        Me.ncliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApeYNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.tBuscar = New System.Windows.Forms.TextBox()
        Me.menuClientes = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.pRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaxi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenido.SuspendLayout()
        Me.pCampos.SuspendLayout()
        CType(Me.gridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuClientes.SuspendLayout()
        Me.SuspendLayout()
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
        Me.pnlTitulo.TabIndex = 1
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
        Me.pnlMenu.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(3, 325)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(8, 64)
        Me.Panel3.TabIndex = 7
        '
        'btnBorrar
        '
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.FlatAppearance.BorderSize = 0
        Me.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.ForeColor = System.Drawing.Color.White
        Me.btnBorrar.Image = Global.sistema.My.Resources.Resources.delete_delete_delete
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrar.Location = New System.Drawing.Point(12, 325)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(185, 64)
        Me.btnBorrar.TabIndex = 6
        Me.btnBorrar.Text = "&Borrar Cliente"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(3, 253)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(8, 64)
        Me.Panel2.TabIndex = 5
        '
        'btnNuevo
        '
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Image = Global.sistema.My.Resources.Resources.new_add_user
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(12, 253)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(185, 64)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "&Nuevo Cliente"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(3, 179)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(8, 64)
        Me.Panel1.TabIndex = 3
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
        'pnlContenido
        '
        Me.pnlContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.pnlContenido.Controls.Add(Me.lIdCliente)
        Me.pnlContenido.Controls.Add(Me.pCampos)
        Me.pnlContenido.Controls.Add(Me.gridClientes)
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
        Me.pnlContenido.TabIndex = 3
        '
        'lIdCliente
        '
        Me.lIdCliente.AutoSize = True
        Me.lIdCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lIdCliente.ForeColor = System.Drawing.Color.White
        Me.lIdCliente.Location = New System.Drawing.Point(57, 90)
        Me.lIdCliente.Name = "lIdCliente"
        Me.lIdCliente.Size = New System.Drawing.Size(15, 16)
        Me.lIdCliente.TabIndex = 95
        Me.lIdCliente.Text = "0"
        '
        'pCampos
        '
        Me.pCampos.Controls.Add(Me.tEmail)
        Me.pCampos.Controls.Add(Me.Label15)
        Me.pCampos.Controls.Add(Me.Label14)
        Me.pCampos.Controls.Add(Me.tClave)
        Me.pCampos.Controls.Add(Me.Label13)
        Me.pCampos.Controls.Add(Me.tUsuario)
        Me.pCampos.Controls.Add(Me.Label7)
        Me.pCampos.Controls.Add(Me.tCUIT)
        Me.pCampos.Controls.Add(Me.CheckBox1)
        Me.pCampos.Controls.Add(Me.Label3)
        Me.pCampos.Controls.Add(Me.tLocalidad)
        Me.pCampos.Controls.Add(Me.Label16)
        Me.pCampos.Controls.Add(Me.tComentario)
        Me.pCampos.Controls.Add(Me.Label12)
        Me.pCampos.Controls.Add(Me.DateTimePicker1)
        Me.pCampos.Controls.Add(Me.Label11)
        Me.pCampos.Controls.Add(Me.tTelefono)
        Me.pCampos.Controls.Add(Me.Label10)
        Me.pCampos.Controls.Add(Me.tProvincia)
        Me.pCampos.Controls.Add(Me.Label9)
        Me.pCampos.Controls.Add(Me.tCP)
        Me.pCampos.Controls.Add(Me.Label8)
        Me.pCampos.Controls.Add(Me.tDireccion)
        Me.pCampos.Controls.Add(Me.Label6)
        Me.pCampos.Controls.Add(Me.tDNI)
        Me.pCampos.Controls.Add(Me.Label5)
        Me.pCampos.Controls.Add(Me.tNombre)
        Me.pCampos.Controls.Add(Me.Label4)
        Me.pCampos.Controls.Add(Me.tApellido)
        Me.pCampos.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pCampos.ForeColor = System.Drawing.Color.White
        Me.pCampos.Location = New System.Drawing.Point(56, 109)
        Me.pCampos.Name = "pCampos"
        Me.pCampos.Size = New System.Drawing.Size(514, 503)
        Me.pCampos.TabIndex = 58
        '
        'tEmail
        '
        Me.tEmail.Location = New System.Drawing.Point(117, 408)
        Me.tEmail.MaxLength = 35
        Me.tEmail.Name = "tEmail"
        Me.tEmail.Size = New System.Drawing.Size(373, 30)
        Me.tEmail.TabIndex = 46
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(338, 299)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 23)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "CP:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(7, 230)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 23)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Contraseña:"
        '
        'tClave
        '
        Me.tClave.Location = New System.Drawing.Point(117, 223)
        Me.tClave.MaxLength = 30
        Me.tClave.Name = "tClave"
        Me.tClave.Size = New System.Drawing.Size(359, 30)
        Me.tClave.TabIndex = 43
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(7, 190)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 23)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Usuario:"
        '
        'tUsuario
        '
        Me.tUsuario.Location = New System.Drawing.Point(117, 187)
        Me.tUsuario.MaxLength = 10
        Me.tUsuario.Name = "tUsuario"
        Me.tUsuario.Size = New System.Drawing.Size(359, 30)
        Me.tUsuario.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(7, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 23)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "CUIT (solo núm.)"
        '
        'tCUIT
        '
        Me.tCUIT.Location = New System.Drawing.Point(154, 151)
        Me.tCUIT.MaxLength = 30
        Me.tCUIT.Name = "tCUIT"
        Me.tCUIT.Size = New System.Drawing.Size(322, 30)
        Me.tCUIT.TabIndex = 39
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(390, 115)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(86, 27)
        Me.CheckBox1.TabIndex = 38
        Me.CheckBox1.Text = "Activo?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 23)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Provincia:"
        '
        'tLocalidad
        '
        Me.tLocalidad.Location = New System.Drawing.Point(103, 296)
        Me.tLocalidad.MaxLength = 20
        Me.tLocalidad.Name = "tLocalidad"
        Me.tLocalidad.Size = New System.Drawing.Size(232, 30)
        Me.tLocalidad.TabIndex = 36
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(7, 457)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(109, 23)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Comentarios:"
        '
        'tComentario
        '
        Me.tComentario.Location = New System.Drawing.Point(117, 444)
        Me.tComentario.MaxLength = 200
        Me.tComentario.Multiline = True
        Me.tComentario.Name = "tComentario"
        Me.tComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tComentario.Size = New System.Drawing.Size(373, 52)
        Me.tComentario.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(7, 121)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(177, 23)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Fecha de Nacimiento:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(190, 115)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(168, 30)
        Me.DateTimePicker1.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(7, 415)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 23)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Email:"
        '
        'tTelefono
        '
        Me.tTelefono.Location = New System.Drawing.Point(117, 371)
        Me.tTelefono.MaxLength = 35
        Me.tTelefono.Name = "tTelefono"
        Me.tTelefono.Size = New System.Drawing.Size(373, 30)
        Me.tTelefono.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(7, 374)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 23)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Teléfono:"
        '
        'tProvincia
        '
        Me.tProvincia.Location = New System.Drawing.Point(117, 332)
        Me.tProvincia.MaxLength = 30
        Me.tProvincia.Name = "tProvincia"
        Me.tProvincia.Size = New System.Drawing.Size(373, 30)
        Me.tProvincia.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(7, 299)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 23)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Localidad:"
        '
        'tCP
        '
        Me.tCP.Location = New System.Drawing.Point(377, 296)
        Me.tCP.MaxLength = 10
        Me.tCP.Name = "tCP"
        Me.tCP.Size = New System.Drawing.Size(99, 30)
        Me.tCP.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(7, 263)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 23)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Dirección:"
        '
        'tDireccion
        '
        Me.tDireccion.Location = New System.Drawing.Point(117, 260)
        Me.tDireccion.MaxLength = 50
        Me.tDireccion.Name = "tDireccion"
        Me.tDireccion.Size = New System.Drawing.Size(359, 30)
        Me.tDireccion.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(7, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "DNI (solo núm.)"
        '
        'tDNI
        '
        Me.tDNI.Location = New System.Drawing.Point(140, 79)
        Me.tDNI.MaxLength = 8
        Me.tDNI.Name = "tDNI"
        Me.tDNI.Size = New System.Drawing.Size(336, 30)
        Me.tDNI.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(7, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nombre/s:"
        '
        'tNombre
        '
        Me.tNombre.Location = New System.Drawing.Point(117, 43)
        Me.tNombre.MaxLength = 30
        Me.tNombre.Name = "tNombre"
        Me.tNombre.Size = New System.Drawing.Size(359, 30)
        Me.tNombre.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellido/s:"
        '
        'tApellido
        '
        Me.tApellido.Location = New System.Drawing.Point(117, 7)
        Me.tApellido.MaxLength = 30
        Me.tApellido.Name = "tApellido"
        Me.tApellido.Size = New System.Drawing.Size(359, 30)
        Me.tApellido.TabIndex = 4
        '
        'gridClientes
        '
        Me.gridClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ncliente, Me.ApeYNom, Me.cuit})
        Me.gridClientes.Location = New System.Drawing.Point(630, 100)
        Me.gridClientes.Name = "gridClientes"
        Me.gridClientes.ReadOnly = True
        Me.gridClientes.Size = New System.Drawing.Size(458, 503)
        Me.gridClientes.TabIndex = 7
        '
        'ncliente
        '
        Me.ncliente.DataPropertyName = "ncliente"
        Me.ncliente.HeaderText = "ncliente"
        Me.ncliente.Name = "ncliente"
        Me.ncliente.ReadOnly = True
        Me.ncliente.Visible = False
        '
        'ApeYNom
        '
        Me.ApeYNom.DataPropertyName = "ApeYNom"
        Me.ApeYNom.HeaderText = "Apellido y Nombre"
        Me.ApeYNom.Name = "ApeYNom"
        Me.ApeYNom.ReadOnly = True
        '
        'cuit
        '
        Me.cuit.DataPropertyName = "CUIT"
        Me.cuit.HeaderText = "CUIT"
        Me.cuit.Name = "cuit"
        Me.cuit.ReadOnly = True
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
        Me.Label1.Size = New System.Drawing.Size(319, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrese Nombre para Buscar un Cliente"
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
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
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
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.SalirToolStripMenuItem.Image = Global.sistema.My.Resources.Resources.salir
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'clientes
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
        Me.MainMenuStrip = Me.menuClientes
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(1300, 650)
        Me.Name = "clientes"
        Me.Text = "clientes"
        Me.pnlTitulo.ResumeLayout(False)
        CType(Me.pRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaxi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenido.ResumeLayout(False)
        Me.pnlContenido.PerformLayout()
        Me.pCampos.ResumeLayout(False)
        Me.pCampos.PerformLayout()
        CType(Me.gridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuClientes.ResumeLayout(False)
        Me.menuClientes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents pRestaurar As PictureBox
    Friend WithEvents pMini As PictureBox
    Friend WithEvents pMaxi As PictureBox
    Friend WithEvents pCerrar As PictureBox
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblSistema As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlContenido As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnBorrar As Button
    Friend WithEvents menuClientes As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pCampos As Panel
    Friend WithEvents tEmail As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tClave As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tUsuario As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tCUIT As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tLocalidad As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents tComentario As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents tTelefono As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tProvincia As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tCP As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tDireccion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tDNI As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tApellido As TextBox
    Friend WithEvents gridClientes As DataGridView
    Friend WithEvents ncliente As DataGridViewTextBoxColumn
    Friend WithEvents ApeYNom As DataGridViewTextBoxColumn
    Friend WithEvents cuit As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents tBuscar As TextBox
    Friend WithEvents lIdCliente As Label
End Class
