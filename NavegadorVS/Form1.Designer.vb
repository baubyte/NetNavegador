<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.tBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bRojo = New System.Windows.Forms.Button()
        Me.bAzul = New System.Windows.Forms.Button()
        Me.bVerde = New System.Windows.Forms.Button()
        Me.bVer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bBuscar
        '
        Me.bBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bBuscar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscar.Location = New System.Drawing.Point(566, 86)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(82, 31)
        Me.bBuscar.TabIndex = 0
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = False
        '
        'tBuscar
        '
        Me.tBuscar.BackColor = System.Drawing.Color.Silver
        Me.tBuscar.Location = New System.Drawing.Point(192, 92)
        Me.tBuscar.Name = "tBuscar"
        Me.tBuscar.Size = New System.Drawing.Size(358, 20)
        Me.tBuscar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrese Busqueda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(563, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Click para Buscar"
        '
        'bRojo
        '
        Me.bRojo.BackColor = System.Drawing.Color.Red
        Me.bRojo.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRojo.ForeColor = System.Drawing.Color.White
        Me.bRojo.Location = New System.Drawing.Point(192, 134)
        Me.bRojo.Name = "bRojo"
        Me.bRojo.Size = New System.Drawing.Size(94, 29)
        Me.bRojo.TabIndex = 4
        Me.bRojo.Text = "Rojo"
        Me.bRojo.UseVisualStyleBackColor = False
        '
        'bAzul
        '
        Me.bAzul.BackColor = System.Drawing.Color.Navy
        Me.bAzul.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAzul.ForeColor = System.Drawing.Color.White
        Me.bAzul.Location = New System.Drawing.Point(456, 134)
        Me.bAzul.Name = "bAzul"
        Me.bAzul.Size = New System.Drawing.Size(94, 29)
        Me.bAzul.TabIndex = 5
        Me.bAzul.Text = "Azul"
        Me.bAzul.UseVisualStyleBackColor = False
        '
        'bVerde
        '
        Me.bVerde.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bVerde.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bVerde.ForeColor = System.Drawing.Color.White
        Me.bVerde.Location = New System.Drawing.Point(327, 134)
        Me.bVerde.Name = "bVerde"
        Me.bVerde.Size = New System.Drawing.Size(94, 29)
        Me.bVerde.TabIndex = 6
        Me.bVerde.Text = "Verde"
        Me.bVerde.UseVisualStyleBackColor = False
        '
        'bVer
        '
        Me.bVer.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bVer.Location = New System.Drawing.Point(306, 180)
        Me.bVer.Name = "bVer"
        Me.bVer.Size = New System.Drawing.Size(143, 32)
        Me.bVer.TabIndex = 7
        Me.bVer.Text = "Ver"
        Me.bVer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(795, 242)
        Me.Controls.Add(Me.bVer)
        Me.Controls.Add(Me.bVerde)
        Me.Controls.Add(Me.bAzul)
        Me.Controls.Add(Me.bRojo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tBuscar)
        Me.Controls.Add(Me.bBuscar)
        Me.Name = "Form1"
        Me.Text = "Buscador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bBuscar As Button
    Friend WithEvents tBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bRojo As Button
    Friend WithEvents bAzul As Button
    Friend WithEvents bVerde As Button
    Friend WithEvents bVer As Button
End Class
