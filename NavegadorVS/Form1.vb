Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        Dim condicion As Boolean = True
        If condicion Then
            Label2.Text = "¡Bien Hecho!"
        End If
        System.Diagnostics.Process.Start("https://www.google.com.ar/search?sxsrf=ALeKk008WtCMJQ30Fh9B3k-XMtBeGDQLvA%3A1586010186706&source=hp&ei=SpiIXvyaKbnZ5OUPqImMoA8&q=" & tBuscar.Text & "&oq=" & tBuscar.Text & "&gs_lcp=CgZwc3ktYWIQAzIHCAAQgwEQQzICCAAyAggAMgIIADIFCAAQgwEyAggAMgIIADICCAAyAggAMgIIADoECCMQJzoGCCMQJxATOgQIABBDShMIFxIPMGcxNTVnMTQ0ZzUtMjc3Sg0IGBIJMGcxZzFnNS0xUKoLWIYRYOEUaABwAHgCgAHyBIgBmQySAQswLjIuMS4wLjEuMZgBAKABAaoBB2d3cy13aXo&sclient=psy-ab&ved=0ahUKEwj856Wu_M7oAhW5LLkGHagEA_QQ4dUDCAY&uact=5")
    End Sub
End Class
