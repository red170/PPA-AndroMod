Public Class Galeria

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Apps.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub pb1_Click(sender As Object, e As EventArgs) Handles pb1.Click
        paisajes.show()
        Me.Hide()



    End Sub

    Private Sub pb2_Click(sender As Object, e As EventArgs) Handles pb2.Click
        material.show()
        Me.Hide()
    End Sub

    Private Sub pb3_Click(sender As Object, e As EventArgs) Handles pb3.Click
        deporte.show()
        Me.Hide()

    End Sub

    Private Sub pb4_Click(sender As Object, e As EventArgs) Handles pb4.Click
        sistemas.show()
        Me.Hide()
    End Sub
End Class