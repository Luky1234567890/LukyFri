Public Class close_sure
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        play1.Close()
        play2.Close()
        play3.Close()
        play4.Close()
        Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Close()
    End Sub
End Class