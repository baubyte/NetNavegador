Public Class Form1
    'Variable para Generar Numeros al Azar Predecibles o no
    Dim Azar As Boolean = True
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        If MessageBox.Show("¿Seguro que Quieres Salir?", "Salir del Juego", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then End
    End Sub
    'Funcion para Generar Numeros al Azar
    Function NumDado(Random As Boolean) As Integer
        If Random Then Randomize()
        Return Int(Rnd() * 6 + 1)
    End Function

    Private Sub Cubilete_Click(sender As Object, e As EventArgs) Handles Cubilete.Click
        CambiaDado(Dado1)
        CambiaDado(Dado2)
        CambiaDado(Dado3)
        CambiaDado(Dado4)
        CambiaDado(Dado5)
    End Sub
    Sub CambiaDado(ByRef DadoX As PictureBox)
        'Generamos un Dado al Azar
        Dim Num As Integer = NumDado(Azar)
        'Buscamos la Imagen de Acuerdo al Numero Generado
        Select Case Num
            Case 1 : DadoX.Image = My.Resources.dado1
            Case 2 : DadoX.Image = My.Resources.dado2
            Case 3 : DadoX.Image = My.Resources.dado3
            Case 4 : DadoX.Image = My.Resources.dado4
            Case 5 : DadoX.Image = My.Resources.dado5
            Case 6 : DadoX.Image = My.Resources.dado6
        End Select
    End Sub
    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Dim monto As Decimal = 1000
    '    Dim IVA As Decimal = 0, IIBB As Decimal = 0, Interes1 As Decimal = 0
    '    CalculaValores(monto, IVA, IIBB, Interes1)
    '    MessageBox.Show("Monto: " & monto & ",IVA: " & IVA & ", IIBB: " & IIBB & ", Interes1: " & Interes1)
    'End Sub
    'Sub CalculaValores(ByVal MontoX As Decimal, ByRef IVA As Decimal, ByRef IB As Decimal, ByRef Interes1 As Decimal)
    '    'IVA Es una Variable Local, que Hace Rferencia a IVA del Buttom2
    '    IVA = MontoX * 21 / 100
    '    IB = MontoX * 3 / 100
    '    Interes1 = MontoX * 9 / 100
    'End Sub
End Class
