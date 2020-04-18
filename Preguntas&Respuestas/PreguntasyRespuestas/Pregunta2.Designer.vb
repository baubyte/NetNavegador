<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pregunta2
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
        Me.bC = New System.Windows.Forms.Button()
        Me.bB = New System.Windows.Forms.Button()
        Me.bA = New System.Windows.Forms.Button()
        Me.lTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bC
        '
        Me.bC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bC.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bC.ForeColor = System.Drawing.Color.Green
        Me.bC.Location = New System.Drawing.Point(198, 273)
        Me.bC.Name = "bC"
        Me.bC.Size = New System.Drawing.Size(173, 40)
        Me.bC.TabIndex = 9
        Me.bC.Text = "Mano"
        Me.bC.UseVisualStyleBackColor = False
        '
        'bB
        '
        Me.bB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bB.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bB.ForeColor = System.Drawing.Color.Green
        Me.bB.Location = New System.Drawing.Point(198, 213)
        Me.bB.Name = "bB"
        Me.bB.Size = New System.Drawing.Size(173, 40)
        Me.bB.TabIndex = 8
        Me.bB.Text = "Brazo"
        Me.bB.UseVisualStyleBackColor = False
        '
        'bA
        '
        Me.bA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bA.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bA.ForeColor = System.Drawing.Color.Green
        Me.bA.Location = New System.Drawing.Point(198, 157)
        Me.bA.Name = "bA"
        Me.bA.Size = New System.Drawing.Size(173, 40)
        Me.bA.TabIndex = 7
        Me.bA.Text = "Pies"
        Me.bA.UseVisualStyleBackColor = False
        '
        'lTitulo
        '
        Me.lTitulo.Font = New System.Drawing.Font("Jokerman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTitulo.ForeColor = System.Drawing.Color.Green
        Me.lTitulo.Location = New System.Drawing.Point(42, 50)
        Me.lTitulo.Name = "lTitulo"
        Me.lTitulo.Size = New System.Drawing.Size(502, 65)
        Me.lTitulo.TabIndex = 6
        Me.lTitulo.Text = "¿Qué parte del cuerpo tiene 27 huesos y 35 músculos? "
        Me.lTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pregunta2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 405)
        Me.ControlBox = False
        Me.Controls.Add(Me.bC)
        Me.Controls.Add(Me.bB)
        Me.Controls.Add(Me.bA)
        Me.Controls.Add(Me.lTitulo)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Pregunta2"
        Me.Text = "2°"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bC As Button
    Friend WithEvents bB As Button
    Friend WithEvents bA As Button
    Friend WithEvents lTitulo As Label
End Class
