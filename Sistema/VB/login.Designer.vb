<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.pTitulo = New System.Windows.Forms.Panel()
        Me.lLogin = New System.Windows.Forms.Label()
        Me.lblSistema = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tClave = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tUsuario = New System.Windows.Forms.TextBox()
        Me.pTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pTitulo
        '
        Me.pTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pTitulo.Controls.Add(Me.lLogin)
        Me.pTitulo.Controls.Add(Me.lblSistema)
        Me.pTitulo.Controls.Add(Me.PictureBox1)
        Me.pTitulo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pTitulo.Name = "pTitulo"
        Me.pTitulo.Size = New System.Drawing.Size(650, 103)
        Me.pTitulo.TabIndex = 0
        '
        'lLogin
        '
        Me.lLogin.AutoSize = True
        Me.lLogin.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lLogin.ForeColor = System.Drawing.Color.White
        Me.lLogin.Location = New System.Drawing.Point(295, 30)
        Me.lLogin.Name = "lLogin"
        Me.lLogin.Size = New System.Drawing.Size(177, 35)
        Me.lLogin.TabIndex = 3
        Me.lLogin.Text = "Iniciar Sesión"
        '
        'lblSistema
        '
        Me.lblSistema.AutoSize = True
        Me.lblSistema.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSistema.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSistema.ForeColor = System.Drawing.Color.White
        Me.lblSistema.Location = New System.Drawing.Point(107, 9)
        Me.lblSistema.Name = "lblSistema"
        Me.lblSistema.Size = New System.Drawing.Size(93, 81)
        Me.lblSistema.TabIndex = 1
        Me.lblSistema.Text = "Sistema " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gestion"
        Me.lblSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.sistema.My.Resources.Resources.gestion
        Me.PictureBox1.Location = New System.Drawing.Point(9, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.btnSalir)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btnLogin)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.tClave)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.tUsuario)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 103)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(650, 397)
        Me.Panel2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(532, 333)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(8, 64)
        Me.Panel1.TabIndex = 10
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
        Me.btnSalir.Location = New System.Drawing.Point(540, 333)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 64)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(436, 114)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(8, 64)
        Me.Panel3.TabIndex = 8
        '
        'btnLogin
        '
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Image = Global.sistema.My.Resources.Resources.Login_37128
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Location = New System.Drawing.Point(444, 114)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(185, 64)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "&Iniciar Sesión"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = Global.sistema.My.Resources.Resources.security_protection_protect_key_password_login_108554
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(32, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 27)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "    Contraseña"
        '
        'tClave
        '
        Me.tClave.Location = New System.Drawing.Point(184, 170)
        Me.tClave.Name = "tClave"
        Me.tClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tClave.Size = New System.Drawing.Size(237, 26)
        Me.tClave.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = Global.sistema.My.Resources.Resources.loginmanager_10029
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(64, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 27)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "    Usuario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tUsuario
        '
        Me.tUsuario.Location = New System.Drawing.Point(184, 105)
        Me.tUsuario.MaxLength = 10
        Me.tUsuario.Name = "tUsuario"
        Me.tUsuario.Size = New System.Drawing.Size(237, 26)
        Me.tUsuario.TabIndex = 0
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(650, 500)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pTitulo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(650, 500)
        Me.Name = "login"
        Me.Text = "login"
        Me.pTitulo.ResumeLayout(False)
        Me.pTitulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pTitulo As Panel
    Friend WithEvents lblSistema As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lLogin As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents tClave As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tUsuario As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSalir As Button
End Class
