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
        Me.lTitulo = New System.Windows.Forms.Label()
        Me.bComenzar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lTitulo
        '
        Me.lTitulo.AutoSize = True
        Me.lTitulo.Font = New System.Drawing.Font("Jokerman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTitulo.ForeColor = System.Drawing.Color.Green
        Me.lTitulo.Location = New System.Drawing.Point(153, 83)
        Me.lTitulo.Name = "lTitulo"
        Me.lTitulo.Size = New System.Drawing.Size(277, 31)
        Me.lTitulo.TabIndex = 0
        Me.lTitulo.Text = "¡Veamos que tanto Sabes!"
        '
        'bComenzar
        '
        Me.bComenzar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bComenzar.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bComenzar.ForeColor = System.Drawing.Color.Green
        Me.bComenzar.Location = New System.Drawing.Point(159, 276)
        Me.bComenzar.Name = "bComenzar"
        Me.bComenzar.Size = New System.Drawing.Size(106, 40)
        Me.bComenzar.TabIndex = 1
        Me.bComenzar.Text = "&Comnezar"
        Me.bComenzar.UseVisualStyleBackColor = False
        '
        'bSalir
        '
        Me.bSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bSalir.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalir.ForeColor = System.Drawing.Color.Green
        Me.bSalir.Location = New System.Drawing.Point(324, 276)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(106, 40)
        Me.bSalir.TabIndex = 2
        Me.bSalir.Text = "&Salir"
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PreguntasyRespuestas.My.Resources.Resources.wp3638491
        Me.ClientSize = New System.Drawing.Size(582, 405)
        Me.ControlBox = False
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bComenzar)
        Me.Controls.Add(Me.lTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lTitulo As Label
    Friend WithEvents bComenzar As Button
    Friend WithEvents bSalir As Button
End Class
