Public Class Form3

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Form1.comp("img/not.jpg")
        Form1.Refresh()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Form1.comp("Nothing")
        Form1.Refresh()
        Me.Hide()
    End Sub
End Class