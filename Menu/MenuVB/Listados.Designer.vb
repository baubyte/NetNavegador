<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listados
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
        Me.bVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bVolver
        '
        Me.bVolver.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bVolver.Location = New System.Drawing.Point(689, 402)
        Me.bVolver.Name = "bVolver"
        Me.bVolver.Size = New System.Drawing.Size(99, 36)
        Me.bVolver.TabIndex = 1
        Me.bVolver.Text = "Volver"
        Me.bVolver.UseVisualStyleBackColor = True
        '
        'Listados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.bVolver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Listados"
        Me.Text = "Listados"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bVolver As Button
End Class
