Public Class inciso1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1, n2, n3, n4, n5, prom As Integer
        Dim bad, maybe, accept, excelent As String
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        n3 = TextBox3.Text
        n4 = TextBox4.Text
        n5 = TextBox5.Text
        prom = (n1 + n2 + n3 + n4 + n5) / 5
        bad = "Pesimo Alumno"
        maybe = "Alumno Regular"
        accept = "Alumno Aceptable"
        excelent = "Alumno Excelente"
        If prom <= 59 Then
            MsgBox(prom.ToString() + vbCrLf + bad)
        ElseIf prom >= 60 And prom <= 79 Then
            MsgBox(prom.ToString + vbCrLf + maybe)
        ElseIf prom >= 80 And prom <= 90 Then
            MsgBox(prom.ToString + vbCrLf + accept)
        ElseIf prom >= 91 And prom <= 100 Then
            MsgBox(prom.ToString + vbCrLf + excelent)
        End If
    End Sub
End Class