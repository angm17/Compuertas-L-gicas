Public Class Form1

    Public Function clean()
        A_Neg = False
        E_Neg = False
        signos(0, 0) = ""
        signos(0, 1) = ""
        signos(1, 0) = ""
        signos(1, 1) = ""
        signos(2, 0) = ""
        signos(2, 1) = ""
        signos(3, 0) = ""
        signos(3, 1) = ""
        signos(4, 0) = ""
        signos(4, 1) = ""
        signos(5, 0) = ""
        signos(5, 1) = ""
        Me.PictureBox2.Image = Nothing
        Me.PictureBox3.Image = Nothing
        Me.PictureBox4.Image = Nothing
        Me.PictureBox5.Image = Nothing
        Me.PictureBox6.Image = Nothing
        Me.PictureBox7.Image = Nothing
        Me.PictureBox8.Image = Nothing
        Me.PictureBox9.Image = Nothing
    End Function

    Public Function comp(ByVal image As String)

        If img = 1 Then
            Me.PictureBox2.Image = Bitmap.FromFile(image)
        ElseIf img = 2 Then
            Me.PictureBox3.Image = Bitmap.FromFile(image)
        ElseIf img = 3 Then
            Me.PictureBox4.Image = Bitmap.FromFile(image)
        ElseIf img = 4 Then
            Me.PictureBox5.Image = Bitmap.FromFile(image)
        ElseIf img = 5 Then
            Me.PictureBox6.Image = Bitmap.FromFile(image)
        ElseIf img = 6 Then
            Me.PictureBox7.Image = Bitmap.FromFile(image)
        ElseIf img = 7 Then
            If image = "Nothing" Then
                Me.PictureBox8.Image = Nothing
                A_Neg = False
            Else
                Me.PictureBox8.Image = Bitmap.FromFile(image)
                A_Neg = True
            End If


        ElseIf img = 8 Then
            If image = "Nothing" Then
                Me.PictureBox9.Image = Nothing
                E_Neg = False
            Else
                Me.PictureBox9.Image = Bitmap.FromFile(image)
                E_Neg = True
            End If

        End If

    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clean()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        img = 1
        Form2.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        img = 2
        Form2.Show()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        img = 3
        Form2.Show()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        img = 4
        Form2.Show()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        img = 5
        Form2.Show()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        img = 6
        Form2.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        img = 7
        Form3.Show()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        img = 8
        Form3.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PictureBox1.Image = Bitmap.FromFile("img/fondo.png")
        clean()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If signos(0, 0) = "" Or signos(0, 1) = "" Or signos(1, 0) = "" Or signos(1, 1) = "" Or signos(2, 0) = "" Or signos(2, 1) = "" Or signos(3, 0) = "" Or signos(3, 1) = "" Or signos(4, 0) = "" Or signos(4, 1) = "" Or signos(5, 0) = "" Or signos(5, 1) = "" Then
            MsgBox("Todas las compuertas deben ser llenadas")
        Else
            Form4.Show()
        End If


    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Form5.Show()

    End Sub
End Class
