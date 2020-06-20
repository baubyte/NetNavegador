<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarProveedor))
        Me.gridProveedores = New System.Windows.Forms.DataGridView()
        Me.nproveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApeYNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.tBuscar = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        CType(Me.gridProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridProveedores
        '
        Me.gridProveedores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nproveedor, Me.ApeYNom, Me.cuit})
        Me.gridProveedores.Location = New System.Drawing.Point(13, 103)
        Me.gridProveedores.Name = "gridProveedores"
        Me.gridProveedores.ReadOnly = True
        Me.gridProveedores.Size = New System.Drawing.Size(527, 179)
        Me.gridProveedores.TabIndex = 13
        '
        'nproveedor
        '
        Me.nproveedor.DataPropertyName = "nproveedor"
        Me.nproveedor.HeaderText = "nproveedor"
        Me.nproveedor.Name = "nproveedor"
        Me.nproveedor.ReadOnly = True
        Me.nproveedor.Visible = False
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
        Me.Label2.Location = New System.Drawing.Point(106, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "*Si dejas Vacio Trae Todo"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(374, 29)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(8, 38)
        Me.Panel4.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ingrese Nombre para Buscar un Proveedor"
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
        Me.btnBuscar.Location = New System.Drawing.Point(377, 29)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(191, 38)
        Me.btnBuscar.TabIndex = 11
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'tBuscar
        '
        Me.tBuscar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBuscar.Location = New System.Drawing.Point(46, 35)
        Me.tBuscar.Name = "tBuscar"
        Me.tBuscar.Size = New System.Drawing.Size(297, 30)
        Me.tBuscar.TabIndex = 8
        '
        'label3
        '
        Me.label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(155, 318)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(219, 16)
        Me.label3.TabIndex = 112
        Me.label3.Text = "*Doble Click Para Agregar el Proveedor"
        '
        'BuscarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 402)
        Me.ControlBox = False
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.gridProveedores)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.tBuscar)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(600, 402)
        Me.MinimumSize = New System.Drawing.Size(600, 402)
        Me.Name = "BuscarProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BuscarProveedores"
        CType(Me.gridProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridProveedores As DataGridView
    Friend WithEvents nproveedor As DataGridViewTextBoxColumn
    Friend WithEvents ApeYNom As DataGridViewTextBoxColumn
    Friend WithEvents cuit As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents tBuscar As TextBox
    Friend WithEvents label3 As Label
End Class
