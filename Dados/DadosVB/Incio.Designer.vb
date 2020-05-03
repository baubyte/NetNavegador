<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Incio
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
        Me.lJugador1 = New System.Windows.Forms.Label()
        Me.lJugador2 = New System.Windows.Forms.Label()
        Me.tJugador1 = New System.Windows.Forms.TextBox()
        Me.tJugador2 = New System.Windows.Forms.TextBox()
        Me.bIniciar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lTitulo = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lJugador1
        '
        Me.lJugador1.AutoSize = True
        Me.lJugador1.BackColor = System.Drawing.Color.Transparent
        Me.lJugador1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lJugador1.ForeColor = System.Drawing.Color.White
        Me.lJugador1.Location = New System.Drawing.Point(26, 97)
        Me.lJugador1.Name = "lJugador1"
        Me.lJugador1.Size = New System.Drawing.Size(193, 27)
        Me.lJugador1.TabIndex = 0
        Me.lJugador1.Text = "Nombre Jugador 1:"
        Me.lJugador1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lJugador2
        '
        Me.lJugador2.AutoSize = True
        Me.lJugador2.BackColor = System.Drawing.Color.Transparent
        Me.lJugador2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lJugador2.ForeColor = System.Drawing.Color.White
        Me.lJugador2.Location = New System.Drawing.Point(26, 206)
        Me.lJugador2.Name = "lJugador2"
        Me.lJugador2.Size = New System.Drawing.Size(193, 27)
        Me.lJugador2.TabIndex = 1
        Me.lJugador2.Text = "Nombre Jugador 2:"
        Me.lJugador2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tJugador1
        '
        Me.tJugador1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tJugador1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tJugador1.Location = New System.Drawing.Point(225, 97)
        Me.tJugador1.Name = "tJugador1"
        Me.tJugador1.Size = New System.Drawing.Size(243, 34)
        Me.tJugador1.TabIndex = 2
        '
        'tJugador2
        '
        Me.tJugador2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tJugador2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tJugador2.Location = New System.Drawing.Point(225, 203)
        Me.tJugador2.Name = "tJugador2"
        Me.tJugador2.Size = New System.Drawing.Size(243, 34)
        Me.tJugador2.TabIndex = 3
        '
        'bIniciar
        '
        Me.bIniciar.BackColor = System.Drawing.Color.Green
        Me.bIniciar.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bIniciar.ForeColor = System.Drawing.Color.White
        Me.bIniciar.Location = New System.Drawing.Point(161, 300)
        Me.bIniciar.Name = "bIniciar"
        Me.bIniciar.Size = New System.Drawing.Size(149, 65)
        Me.bIniciar.TabIndex = 4
        Me.bIniciar.Text = "Guardar e Inciar"
        Me.bIniciar.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(1, 1)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(77, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "&Opciones"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'lTitulo
        '
        Me.lTitulo.AutoSize = True
        Me.lTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lTitulo.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTitulo.ForeColor = System.Drawing.Color.White
        Me.lTitulo.Location = New System.Drawing.Point(118, 28)
        Me.lTitulo.Name = "lTitulo"
        Me.lTitulo.Size = New System.Drawing.Size(249, 35)
        Me.lTitulo.TabIndex = 9
        Me.lTitulo.Text = "Intento de Generala"
        Me.lTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Incio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DadosVB.My.Resources.Resources.mesa
        Me.ClientSize = New System.Drawing.Size(480, 413)
        Me.ControlBox = False
        Me.Controls.Add(Me.lTitulo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.bIniciar)
        Me.Controls.Add(Me.tJugador2)
        Me.Controls.Add(Me.tJugador1)
        Me.Controls.Add(Me.lJugador2)
        Me.Controls.Add(Me.lJugador1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Incio"
        Me.Text = "Inciar Juego"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lJugador1 As Label
    Friend WithEvents lJugador2 As Label
    Friend WithEvents tJugador1 As TextBox
    Friend WithEvents tJugador2 As TextBox
    Friend WithEvents bIniciar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lTitulo As Label
End Class
