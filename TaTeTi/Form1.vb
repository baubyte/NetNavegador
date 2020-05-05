Public Class Form1
    'Variables Necesarias
    Dim judadorFigura As String = "equis"
    Dim scoreX As Integer = 0
    Dim scoreO As Integer = 0
    Dim countBtns As Integer = 0
    'Para Seleccionar el Figura o Jugador
    Public Function JugadorXO(ByRef Figura As String)
        'Buscamos la Imagen
        If Figura = "equis" Then
            judadorFigura = "circulo"
            Return My.Resources.equis
        Else
            judadorFigura = "equis"
            Return My.Resources.circulo
        End If
    End Function
    'Comprobamos si Gana la X
    Public Sub winX()
        countBtns += 1
        If Button1.Tag = "equis" And Button2.Tag = "equis" And Button3.Tag = "equis" Then
            pWin1.Image = My.Resources.winX
            pWin2.Image = My.Resources.winX
            pWin3.Image = My.Resources.winX
            EndGameX()
        ElseIf Button4.Tag = "equis" And Button5.Tag = "equis" And Button6.Tag = "equis" Then
            pWin1.Image = My.Resources.winX
            pWin2.Image = My.Resources.winX
            pWin3.Image = My.Resources.winX
            EndGameX()
        ElseIf Button7.Tag = "equis" And Button8.Tag = "equis" And Button9.Tag = "equis" Then
            pWin1.Image = My.Resources.winX
            pWin2.Image = My.Resources.winX
            pWin3.Image = My.Resources.winX
            EndGameX()
        ElseIf Button1.Tag = "equis" And Button4.Tag = "equis" And Button7.Tag = "equis" Then
            pWin1.Image = My.Resources.winX
            pWin2.Image = My.Resources.winX
            pWin3.Image = My.Resources.winX
            EndGameX()
        ElseIf Button2.Tag = "equis" And Button5.Tag = "equis" And Button8.Tag = "equis" Then
            pWin1.Image = My.Resources.winX
            pWin2.Image = My.Resources.winX
            pWin3.Image = My.Resources.winX
            EndGameX()
        ElseIf Button3.Tag = "equis" And Button6.Tag = "equis" And Button9.Tag = "equis" Then
            pWin1.Image = My.Resources.winX
            pWin2.Image = My.Resources.winX
            pWin3.Image = My.Resources.winX
            EndGameX()
        ElseIf Button1.Tag = "equis" And Button5.Tag = "equis" And Button9.Tag = "equis" Then
            pWin1.Image = My.Resources.winX
            pWin2.Image = My.Resources.winX
            pWin3.Image = My.Resources.winX
            EndGameX()
        ElseIf Button3.Tag = "equis" And Button5.Tag = "equis" And Button7.Tag = "equis" Then
            pWin1.Image = My.Resources.winX
            pWin2.Image = My.Resources.winX
            pWin3.Image = My.Resources.winX
            EndGameX()
        End If
        winO()
    End Sub
    'Fin del Juego Gano X
    Public Sub EndGameX()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        scoreX += 1
        countBtns = 0
        lScoreX.Text = scoreX.ToString
    End Sub
    'Comprobamos si Gana la O
    Public Sub winO()
        If Button1.Tag = "circulo" And Button2.Tag = "circulo" And Button3.Tag = "circulo" Then
            pWin1.Image = My.Resources.winO
            pWin2.Image = My.Resources.winO
            pWin3.Image = My.Resources.winO
            EndGameO()
        ElseIf Button4.Tag = "circulo" And Button5.Tag = "circulo" And Button6.Tag = "circulo" Then
            pWin1.Image = My.Resources.winO
            pWin2.Image = My.Resources.winO
            pWin3.Image = My.Resources.winO
            EndGameO()
        ElseIf Button7.Tag = "circulo" And Button8.Tag = "circulo" And Button9.Tag = "circulo" Then
            pWin1.Image = My.Resources.winO
            pWin2.Image = My.Resources.winO
            pWin3.Image = My.Resources.winO
            EndGameO()
        ElseIf Button1.Tag = "circulo" And Button4.Tag = "circulo" And Button7.Tag = "circulo" Then
            pWin1.Image = My.Resources.winO
            pWin2.Image = My.Resources.winO
            pWin3.Image = My.Resources.winO
            EndGameO()
        ElseIf Button2.Tag = "circulo" And Button5.Tag = "circulo" And Button8.Tag = "circulo" Then
            pWin1.Image = My.Resources.winO
            pWin2.Image = My.Resources.winO
            pWin3.Image = My.Resources.winO
            EndGameO()
        ElseIf Button3.Tag = "circulo" And Button6.Tag = "circulo" And Button9.Tag = "circulo" Then
            pWin1.Image = My.Resources.winO
            pWin2.Image = My.Resources.winO
            pWin3.Image = My.Resources.winO
            EndGameO()
        ElseIf Button1.Tag = "circulo" And Button5.Tag = "circulo" And Button9.Tag = "circulo" Then
            pWin1.Image = My.Resources.winO
            pWin2.Image = My.Resources.winO
            pWin3.Image = My.Resources.winO
            EndGameO()
        ElseIf Button3.Tag = "circulo" And Button5.Tag = "circulo" And Button7.Tag = "circulo" Then
            pWin1.Image = My.Resources.winO
            pWin2.Image = My.Resources.winO
            pWin3.Image = My.Resources.winO
        ElseIf countBtns = 9 Then
            pWin1.Image = My.Resources.empate
            pWin2.Image = My.Resources.empate
            pWin3.Image = My.Resources.empate
            countBtns = 0
        End If
    End Sub
    'Fin del Juego Gano O
    Public Sub EndGameO()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        scoreO += 1
        countBtns = 0
        lScoreO.Text = scoreO.ToString
    End Sub
    'Resetear Botones BackGround y Tag
    Public Sub Reset()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        'Background
        Button1.BackgroundImage = Nothing
        Button2.BackgroundImage = Nothing
        Button3.BackgroundImage = Nothing
        Button4.BackgroundImage = Nothing
        Button5.BackgroundImage = Nothing
        Button6.BackgroundImage = Nothing
        Button7.BackgroundImage = Nothing
        Button8.BackgroundImage = Nothing
        Button9.BackgroundImage = Nothing
        'Tag
        Button1.Tag = ""
        Button2.Tag = ""
        Button3.Tag = ""
        Button4.Tag = ""
        Button5.Tag = ""
        Button6.Tag = ""
        Button7.Tag = ""
        Button8.Tag = ""
        Button9.Tag = ""
        'Win Image
        pWin1.Image = Nothing
        pWin2.Image = Nothing
        pWin3.Image = Nothing
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Tag = judadorFigura
        Button1.BackgroundImage = JugadorXO(judadorFigura)
        Button1.Enabled = False
        winX()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MessageBox.Show("¿Seguro que Quieres Salir?", "Salir del Juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Tag = judadorFigura
        Button2.BackgroundImage = JugadorXO(judadorFigura)
        Button2.Enabled = False
        winX()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Tag = judadorFigura
        Button3.BackgroundImage = JugadorXO(judadorFigura)
        Button3.Enabled = False
        winX()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    Button4.Tag = judadorFigura
        Button4.BackgroundImage = JugadorXO(judadorFigura)
        Button4.Enabled = False
        winX()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    Button5.Tag = judadorFigura
        Button5.BackgroundImage = JugadorXO(judadorFigura)
        Button5.Enabled = False
        winX()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    Button6.Tag = judadorFigura
        Button6.BackgroundImage = JugadorXO(judadorFigura)
        Button6.Enabled = False
        winX()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
    Button7.Tag = judadorFigura
        Button7.BackgroundImage = JugadorXO(judadorFigura)
        Button7.Enabled = False
        winX()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
    Button8.Tag = judadorFigura
        Button8.BackgroundImage = JugadorXO(judadorFigura)
        Button8.Enabled = False
        winX()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
    Button9.Tag = judadorFigura
        Button9.BackgroundImage = JugadorXO(judadorFigura)
        Button9.Enabled = False
        winX()
    End Sub

    Private Sub NuevaPartidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaPartidaToolStripMenuItem.Click
        Reset()
        countBtns = 0
        judadorFigura = "equis"
    End Sub
End Class
