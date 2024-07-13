Public Class Music
    Dim pauplay As Integer = 1
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        Apps.Show()

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Hide()
        Home.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ListBox1.Visible = True
        Label1.Visible = True
        Label2.Visible = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If pauplay = 1 Then
            PictureBox1.Image = My.Resources.Pausar2
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            pauplay = 0
        Else
            PictureBox1.Image = My.Resources.Play2
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
            pauplay = 1
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ListBox1.Visible = False
        Label1.Visible = False
        Label2.Visible = False
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        For Each cancion As String In OpenFileDialog1.FileNames
            ListBox1.Items.Add(cancion)
        Next
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        AxWindowsMediaPlayer1.URL = ListBox1.SelectedItem
        ListBox1.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Timer1.Start()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ListBox1.SelectedIndex += 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim bar1max As Integer
        bar1max = AxWindowsMediaPlayer1.currentMedia.duration
        Try
            Label4.Text = AxWindowsMediaPlayer1.currentMedia.durationString
            Label3.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString
            ProgressBar1.Maximum = Val(bar1max)
            ProgressBar1.Value = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        ListBox1.SelectedIndex -= 1
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = ProgressBar1.Value
    End Sub
End Class