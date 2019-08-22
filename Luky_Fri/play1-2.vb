Public Class play1_2
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        jump.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        close_sure.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        play1_1.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        play1_3.Show()
        Close()
    End Sub
End Class