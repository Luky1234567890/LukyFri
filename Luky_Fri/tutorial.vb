Public Class tutorial
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        My.Computer.FileSystem.WriteAllText("c:\lukyfri_save.txt", TextBox1.Text, False)
        MsgBox("Saved successfuly!", vbOKOnly, "Luky Fri.")
        Close()
    End Sub
End Class