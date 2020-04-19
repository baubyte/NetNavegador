<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fin
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
        Me.lTitulo = New System.Windows.Forms.Label()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bComenzar = New System.Windows.Forms.Button()
        Me.lText = New System.Windows.Forms.Label()
        Me.lPuntaje = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lTitulo
        '
        Me.lTitulo.Font = New System.Drawing.Font("Jokerman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTitulo.ForeColor = System.Drawing.Color.Green
        Me.lTitulo.Location = New System.Drawing.Point(38, 47)
        Me.lTitulo.Name = "lTitulo"
        Me.lTitulo.Size = New System.Drawing.Size(502, 65)
        Me.lTitulo.TabIndex = 19
        Me.lTitulo.Text = "¡Bien Hecho Terminaste!"
        Me.lTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bSalir
        '
        Me.bSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bSalir.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalir.ForeColor = System.Drawing.Color.Green
        Me.bSalir.Location = New System.Drawing.Point(323, 240)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(106, 40)
        Me.bSalir.TabIndex = 21
        Me.bSalir.Text = "&Salir"
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'bComenzar
        '
        Me.bComenzar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bComenzar.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bComenzar.ForeColor = System.Drawing.Color.Green
        Me.bComenzar.Location = New System.Drawing.Point(99, 240)
        Me.bComenzar.Name = "bComenzar"
        Me.bComenzar.Size = New System.Drawing.Size(180, 40)
        Me.bComenzar.TabIndex = 20
        Me.bComenzar.Text = "&Intentar Otra Vez"
        Me.bComenzar.UseVisualStyleBackColor = False
        '
        'lText
        '
        Me.lText.Font = New System.Drawing.Font("Jokerman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lText.ForeColor = System.Drawing.Color.Green
        Me.lText.Location = New System.Drawing.Point(82, 135)
        Me.lText.Name = "lText"
        Me.lText.Size = New System.Drawing.Size(103, 65)
        Me.lText.TabIndex = 22
        Me.lText.Text = "Erraste:"
        Me.lText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lPuntaje
        '
        Me.lPuntaje.Font = New System.Drawing.Font("Jokerman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPuntaje.ForeColor = System.Drawing.Color.Green
        Me.lPuntaje.Location = New System.Drawing.Point(203, 135)
        Me.lPuntaje.Name = "lPuntaje"
        Me.lPuntaje.Size = New System.Drawing.Size(103, 65)
        Me.lPuntaje.TabIndex = 23
        Me.lPuntaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Jokerman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(325, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 65)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "de 6 Preguntas."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Fin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 405)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lPuntaje)
        Me.Controls.Add(Me.lText)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bComenzar)
        Me.Controls.Add(Me.lTitulo)
        Me.Name = "Fin"
        Me.Text = "Fin"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lTitulo As Label
    Friend WithEvents bSalir As Button
    Friend WithEvents bComenzar As Button
    Friend WithEvents lText As Label
    Friend WithEvents lPuntaje As Label
    Friend WithEvents Label1 As Label
End Class
