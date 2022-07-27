Public Class Form1

    Dim str As String = "test string"
    Dim pi As Double = 3.14
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(str)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_hasil.Text = (pi * Double.Parse(txt_jari.Text) * Double.Parse(txt_jari.Text)).ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txt_hasil.Text = (2 * pi * Double.Parse(txt_jari.Text)).ToString
    End Sub
End Class
