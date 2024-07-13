Public Class Games

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
        Apps.Show()
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Close()
        Home.Show()

    End Sub

    Private Sub Games_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxShockwaveFlash1.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Hide()
        Label1.Hide()
        AxShockwaveFlash1.Show()
        OpenFileDialog1.ShowDialog()
        AxShockwaveFlash1.Movie = OpenFileDialog1.FileName

    End Sub
End Class