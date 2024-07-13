Public Class Calc
    Dim OPERACION As String
    Dim A As Double
    Dim B As Double
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Hide()
        Apps.Show()

    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Apps.Show()
        Me.Hide()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        B = TextBox1.Text
        TextBox1.Text = ""
        If OPERACION = "+" Then
            TextBox1.Text = A + B
        ElseIf OPERACION = "-" Then
            TextBox1.Text = A - B
        ElseIf OPERACION = "*" Then
            TextBox1.Text = A * B
        ElseIf OPERACION = "/" Then
            TextBox1.Text = A / B
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        A = TextBox1.Text
        TextBox1.Text = ""
        OPERACION = "+"
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        A = TextBox1.Text
        TextBox1.Text = ""
        OPERACION = "-"
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        A = TextBox1.Text
        TextBox1.Text = ""
        OPERACION = "*"
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        A = TextBox1.Text
        TextBox1.Text = ""
        OPERACION = "/"
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        TextBox1.Text = TextBox1.Text & "1"
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        TextBox1.Text = TextBox1.Text & "3"
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        TextBox1.Text = TextBox1.Text & "5"
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        TextBox1.Text = TextBox1.Text & "6"
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        TextBox1.Text = TextBox1.Text & "7"
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        TextBox1.Text = TextBox1.Text & "8"
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        TextBox1.Text = TextBox1.Text & "9"
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        TextBox1.Text = TextBox1.Text & "0"
    End Sub
End Class