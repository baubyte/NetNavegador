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
        Me.bSalir = New System.Windows.Forms.Button()
        Me.Cubilete = New System.Windows.Forms.PictureBox()
        Me.Dado1 = New System.Windows.Forms.PictureBox()
        Me.Dado2 = New System.Windows.Forms.PictureBox()
        Me.Dado3 = New System.Windows.Forms.PictureBox()
        Me.Dado4 = New System.Windows.Forms.PictureBox()
        Me.Dado5 = New System.Windows.Forms.PictureBox()
        CType(Me.Cubilete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bSalir
        '
        Me.bSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bSalir.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalir.Location = New System.Drawing.Point(713, 456)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(69, 44)
        Me.bSalir.TabIndex = 0
        Me.bSalir.Text = "Salir"
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'Cubilete
        '
        Me.Cubilete.BackColor = System.Drawing.Color.Transparent
        Me.Cubilete.Location = New System.Drawing.Point(473, 12)
        Me.Cubilete.Name = "Cubilete"
        Me.Cubilete.Size = New System.Drawing.Size(319, 272)
        Me.Cubilete.TabIndex = 1
        Me.Cubilete.TabStop = False
        '
        'Dado1
        '
        Me.Dado1.BackgroundImage = Global.DadosVB.My.Resources.Resources.dado6
        Me.Dado1.Location = New System.Drawing.Point(88, 84)
        Me.Dado1.Name = "Dado1"
        Me.Dado1.Size = New System.Drawing.Size(94, 95)
        Me.Dado1.TabIndex = 2
        Me.Dado1.TabStop = False
        '
        'Dado2
        '
        Me.Dado2.BackgroundImage = Global.DadosVB.My.Resources.Resources.dado6
        Me.Dado2.Location = New System.Drawing.Point(88, 225)
        Me.Dado2.Name = "Dado2"
        Me.Dado2.Size = New System.Drawing.Size(94, 95)
        Me.Dado2.TabIndex = 3
        Me.Dado2.TabStop = False
        '
        'Dado3
        '
        Me.Dado3.BackgroundImage = Global.DadosVB.My.Resources.Resources.dado6
        Me.Dado3.Location = New System.Drawing.Point(88, 369)
        Me.Dado3.Name = "Dado3"
        Me.Dado3.Size = New System.Drawing.Size(94, 95)
        Me.Dado3.TabIndex = 4
        Me.Dado3.TabStop = False
        '
        'Dado4
        '
        Me.Dado4.BackgroundImage = Global.DadosVB.My.Resources.Resources.dado6
        Me.Dado4.Location = New System.Drawing.Point(245, 134)
        Me.Dado4.Name = "Dado4"
        Me.Dado4.Size = New System.Drawing.Size(94, 95)
        Me.Dado4.TabIndex = 5
        Me.Dado4.TabStop = False
        '
        'Dado5
        '
        Me.Dado5.BackgroundImage = Global.DadosVB.My.Resources.Resources.dado6
        Me.Dado5.Location = New System.Drawing.Point(245, 317)
        Me.Dado5.Name = "Dado5"
        Me.Dado5.Size = New System.Drawing.Size(94, 95)
        Me.Dado5.TabIndex = 6
        Me.Dado5.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DadosVB.My.Resources.Resources.mesa
        Me.ClientSize = New System.Drawing.Size(784, 503)
        Me.ControlBox = False
        Me.Controls.Add(Me.Dado5)
        Me.Controls.Add(Me.Dado4)
        Me.Controls.Add(Me.Dado3)
        Me.Controls.Add(Me.Dado2)
        Me.Controls.Add(Me.Dado1)
        Me.Controls.Add(Me.Cubilete)
        Me.Controls.Add(Me.bSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Apretá el Cubilete para tirar los dados"
        CType(Me.Cubilete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bSalir As Button
    Friend WithEvents Cubilete As PictureBox
    Friend WithEvents Dado1 As PictureBox
    Friend WithEvents Dado2 As PictureBox
    Friend WithEvents Dado3 As PictureBox
    Friend WithEvents Dado4 As PictureBox
    Friend WithEvents Dado5 As PictureBox
End Class
