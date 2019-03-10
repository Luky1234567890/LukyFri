Public Class play3
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        close_sure.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        play2.Show()
        Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        jump.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        play4.Show()
        Close()
    End Sub

    Private Sub play3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class