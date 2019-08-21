Public Class select_world
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Start.Show()
        Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        play1.Show()
        Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        play1_1.Show()
        Close()
    End Sub
End Class