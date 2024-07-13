Public Class material

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Galeria.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static i
        i = i + 1
        PictureBox2.Image = ImageList1.Images(i)
        If i = 9 Then
            i = 0

        End If
    End Sub
End Class