<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicio))
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.pRestaurar = New System.Windows.Forms.PictureBox()
        Me.pMini = New System.Windows.Forms.PictureBox()
        Me.pMaxi = New System.Windows.Forms.PictureBox()
        Me.pCerrar = New System.Windows.Forms.PictureBox()
        Me.pnlContenido = New System.Windows.Forms.Panel()
        Me.lblInicio = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblSistema = New System.Windows.Forms.Label()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnProvvedores = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.pRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaxi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenido.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
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
        Me.pnlTitulo.TabIndex = 0
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
        'pnlContenido
        '
        Me.pnlContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.pnlContenido.Controls.Add(Me.lblInicio)
        Me.pnlContenido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenido.Location = New System.Drawing.Point(200, 35)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Size = New System.Drawing.Size(1100, 615)
        Me.pnlContenido.TabIndex = 2
        '
        'lblInicio
        '
        Me.lblInicio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInicio.AutoSize = True
        Me.lblInicio.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInicio.ForeColor = System.Drawing.Color.White
        Me.lblInicio.Location = New System.Drawing.Point(442, 162)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(400, 266)
        Me.lblInicio.TabIndex = 0
        Me.lblInicio.Text = "Bienvenido al" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sistema de Gestion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Clientes y Proveedores" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Elija Algunas de" &
    " las Opciones" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Disponibles"
        Me.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.sistema.My.Resources.Resources.gestion
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblSistema
        '
        Me.lblSistema.AutoSize = True
        Me.lblSistema.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSistema.ForeColor = System.Drawing.Color.White
        Me.lblSistema.Location = New System.Drawing.Point(101, 3)
        Me.lblSistema.Name = "lblSistema"
        Me.lblSistema.Size = New System.Drawing.Size(93, 81)
        Me.lblSistema.TabIndex = 0
        Me.lblSistema.Text = "Sistema " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gestion"
        Me.lblSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClientes
        '
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.White
        Me.btnClientes.Image = Global.sistema.My.Resources.Resources.clientes
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(12, 123)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(185, 38)
        Me.btnClientes.TabIndex = 0
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(3, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(8, 38)
        Me.Panel1.TabIndex = 0
        '
        'btnProvvedores
        '
        Me.btnProvvedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProvvedores.FlatAppearance.BorderSize = 0
        Me.btnProvvedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnProvvedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProvvedores.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProvvedores.ForeColor = System.Drawing.Color.White
        Me.btnProvvedores.Image = Global.sistema.My.Resources.Resources.proveedorOp2
        Me.btnProvvedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProvvedores.Location = New System.Drawing.Point(12, 167)
        Me.btnProvvedores.Name = "btnProvvedores"
        Me.btnProvvedores.Size = New System.Drawing.Size(185, 38)
        Me.btnProvvedores.TabIndex = 2
        Me.btnProvvedores.Text = "Proveedores"
        Me.btnProvvedores.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(3, 167)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(8, 38)
        Me.Panel2.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = Global.sistema.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(12, 211)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(185, 38)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(3, 211)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(8, 38)
        Me.Panel3.TabIndex = 3
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.Panel3)
        Me.pnlMenu.Controls.Add(Me.btnSalir)
        Me.pnlMenu.Controls.Add(Me.Panel2)
        Me.pnlMenu.Controls.Add(Me.btnProvvedores)
        Me.pnlMenu.Controls.Add(Me.Panel1)
        Me.pnlMenu.Controls.Add(Me.btnClientes)
        Me.pnlMenu.Controls.Add(Me.lblSistema)
        Me.pnlMenu.Controls.Add(Me.PictureBox1)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 35)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(200, 615)
        Me.pnlMenu.TabIndex = 1
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 650)
        Me.Controls.Add(Me.pnlContenido)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "inicio"
        Me.Text = "Inicio Sistema"
        Me.pnlTitulo.ResumeLayout(False)
        CType(Me.pRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaxi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenido.ResumeLayout(False)
        Me.pnlContenido.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents pCerrar As PictureBox
    Friend WithEvents pMaxi As PictureBox
    Friend WithEvents pMini As PictureBox
    Friend WithEvents pRestaurar As PictureBox
    Friend WithEvents pnlContenido As Panel
    Friend WithEvents lblInicio As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblSistema As Label
    Friend WithEvents btnClientes As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnProvvedores As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pnlMenu As Panel
End Class
