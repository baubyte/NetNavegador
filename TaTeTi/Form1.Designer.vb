<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pMesa = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaPartidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lJugador1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lScoreX = New System.Windows.Forms.Label()
        Me.lScoreO = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.pWin1 = New System.Windows.Forms.PictureBox()
        Me.pWin2 = New System.Windows.Forms.PictureBox()
        Me.pWin3 = New System.Windows.Forms.PictureBox()
        CType(Me.pMesa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pWin1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pWin2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pWin3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pMesa
        '
        Me.pMesa.BackgroundImage = Global.TaTeTi.My.Resources.Resources.tablero
        Me.pMesa.Location = New System.Drawing.Point(319, 39)
        Me.pMesa.Name = "pMesa"
        Me.pMesa.Size = New System.Drawing.Size(630, 530)
        Me.pMesa.TabIndex = 0
        Me.pMesa.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Jokerman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(964, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaPartidaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(80, 21)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'NuevaPartidaToolStripMenuItem
        '
        Me.NuevaPartidaToolStripMenuItem.Name = "NuevaPartidaToolStripMenuItem"
        Me.NuevaPartidaToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.NuevaPartidaToolStripMenuItem.Text = "Nueva Partida"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'lJugador1
        '
        Me.lJugador1.AutoSize = True
        Me.lJugador1.BackColor = System.Drawing.Color.Transparent
        Me.lJugador1.Font = New System.Drawing.Font("Jokerman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lJugador1.ForeColor = System.Drawing.Color.Black
        Me.lJugador1.Location = New System.Drawing.Point(13, 108)
        Me.lJugador1.Name = "lJugador1"
        Me.lJugador1.Size = New System.Drawing.Size(173, 28)
        Me.lJugador1.TabIndex = 2
        Me.lJugador1.Text = "Jugador 1 (X): "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Jokerman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Jugador 2 (O): "
        '
        'lScoreX
        '
        Me.lScoreX.AutoSize = True
        Me.lScoreX.BackColor = System.Drawing.Color.Transparent
        Me.lScoreX.Font = New System.Drawing.Font("Jokerman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lScoreX.ForeColor = System.Drawing.Color.Black
        Me.lScoreX.Location = New System.Drawing.Point(181, 108)
        Me.lScoreX.Name = "lScoreX"
        Me.lScoreX.Size = New System.Drawing.Size(26, 28)
        Me.lScoreX.TabIndex = 4
        Me.lScoreX.Text = "0"
        '
        'lScoreO
        '
        Me.lScoreO.AutoSize = True
        Me.lScoreO.BackColor = System.Drawing.Color.Transparent
        Me.lScoreO.Font = New System.Drawing.Font("Jokerman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lScoreO.ForeColor = System.Drawing.Color.Black
        Me.lScoreO.Location = New System.Drawing.Point(182, 165)
        Me.lScoreO.Name = "lScoreO"
        Me.lScoreO.Size = New System.Drawing.Size(26, 28)
        Me.lScoreO.TabIndex = 5
        Me.lScoreO.Text = "0"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(343, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 149)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(548, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 149)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(767, 53)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(167, 149)
        Me.Button3.TabIndex = 8
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(343, 227)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(167, 149)
        Me.Button4.TabIndex = 9
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(548, 227)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(167, 149)
        Me.Button5.TabIndex = 10
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(767, 227)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(167, 149)
        Me.Button6.TabIndex = 11
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(343, 398)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(167, 149)
        Me.Button7.TabIndex = 12
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(548, 398)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(167, 149)
        Me.Button8.TabIndex = 13
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(767, 398)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(167, 149)
        Me.Button9.TabIndex = 14
        Me.Button9.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'pWin1
        '
        Me.pWin1.BackColor = System.Drawing.Color.Transparent
        Me.pWin1.Location = New System.Drawing.Point(6, 249)
        Me.pWin1.Name = "pWin1"
        Me.pWin1.Size = New System.Drawing.Size(306, 51)
        Me.pWin1.TabIndex = 15
        Me.pWin1.TabStop = False
        '
        'pWin2
        '
        Me.pWin2.BackColor = System.Drawing.Color.Transparent
        Me.pWin2.Location = New System.Drawing.Point(6, 348)
        Me.pWin2.Name = "pWin2"
        Me.pWin2.Size = New System.Drawing.Size(306, 51)
        Me.pWin2.TabIndex = 16
        Me.pWin2.TabStop = False
        '
        'pWin3
        '
        Me.pWin3.BackColor = System.Drawing.Color.Transparent
        Me.pWin3.Location = New System.Drawing.Point(7, 444)
        Me.pWin3.Name = "pWin3"
        Me.pWin3.Size = New System.Drawing.Size(306, 51)
        Me.pWin3.TabIndex = 17
        Me.pWin3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TaTeTi.My.Resources.Resources._269
        Me.ClientSize = New System.Drawing.Size(964, 601)
        Me.ControlBox = False
        Me.Controls.Add(Me.pWin3)
        Me.Controls.Add(Me.pWin2)
        Me.Controls.Add(Me.pWin1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lScoreO)
        Me.Controls.Add(Me.lScoreX)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lJugador1)
        Me.Controls.Add(Me.pMesa)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "TaTeTi"
        CType(Me.pMesa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pWin1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pWin2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pWin3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pMesa As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaPartidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lJugador1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lScoreX As Label
    Friend WithEvents lScoreO As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents pWin1 As PictureBox
    Friend WithEvents pWin2 As PictureBox
    Friend WithEvents pWin3 As PictureBox
End Class
