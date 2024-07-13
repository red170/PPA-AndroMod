Public Class Form1
    Public c As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If c < 100 Then
            ProgressBar1.Value = c
            c = c + 1
        Else
            Timer1.Enabled = False
            Me.Hide()
            Home.Show()
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        ProgressBar1.Value = 0.0
        ProgressBar1.Minimum = 100
        Timer1.Interval = 40
        Timer1.Enabled = True
    End Sub
End Class