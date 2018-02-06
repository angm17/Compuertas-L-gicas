Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        compuerta = 0
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        compuerta = 1
        signos(img - 1, 0) = "+"
        signos(img - 1, 1) = "+"
        Form1.comp("img/and.jpg")
        Form1.Refresh()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        compuerta = 2
        signos(img - 1, 0) = "*"
        signos(img - 1, 1) = "+"
        Form1.comp("img/or.jpg")
        Form1.Refresh()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        compuerta = 3
        signos(img - 1, 0) = "+"
        signos(img - 1, 1) = "-"
        Form1.comp("img/nand.jpg")
        Form1.Refresh()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        compuerta = 4
        signos(img - 1, 0) = "*"
        signos(img - 1, 1) = "-"
        Form1.comp("img/nor.jpg")
        Form1.Refresh()
        Me.Hide()
    End Sub
End Class