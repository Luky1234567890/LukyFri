Public Class Start
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        play1.Show()
        Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        tutorial.Show()
        Hide()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("C:\Program Files (x86)\Nelinka\Luky Fri\lukyfri_playmusic.wav",
        AudioPlayMode.BackgroundLoop)
        If System.IO.File.Exists("C:\lukyfri_save.txt") = True Then
            Process.Start("C:\lukyfri_save.txt")
            MsgBox("Here is what you did last time! :D", MsgBoxStyle.OkOnly, "Luky Fri.")
        Else
            MsgBox("No save file found! :(", MsgBoxStyle.OkOnly, "Luky Fri.")
        End If
    End Sub

    Private Sub Menu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        nelcard.Show()
        Hide()
    End Sub
End Class
