Public Class Word


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
        Dim open As New OpenFileDialog
        Dim mystreamreader As System.IO.StreamReader
        open.Filter = "TEXT [*.txt]|*.txt|All Files [*.*]|*.*"
        open.CheckFileExists = True
        open.Title = "Abrir Archivo"
        open.ShowDialog(Me)
        Try
            open.OpenFile()
            mystreamreader = System.IO.File.OpenText(open.FileName)
            document.Text = mystreamreader.ReadToEnd
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs)
        Dim save As New OpenFileDialog
        Dim mystreamwriter As System.IO.StreamWriter
        save.Filter = "TEXT [*.txt]|*.txt|All Files [*.*]|*.*"
        save.CheckPathExists = True
        save.Title = "Guardar Como"
        save.ShowDialog(Me)
        Try
            mystreamwriter = System.IO.File.AppendText(save.FileName)
            mystreamwriter.Write(document.Text)
            mystreamwriter.Flush()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        document.Undo()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        document.Redo()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        document.Copy()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        document.Paste()

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        document.Cut()

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        document.SelectAll()

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        document.Clear()

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Try
            Dim dlg As FontDialog = New FontDialog
            dlg.Font = document.Font
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                document.Font = dlg.Font
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub document_TextChanged(sender As Object, e As EventArgs) Handles document.TextChanged

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Me.Hide()
        Apps.Show()
    End Sub

    Private Sub Word_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim save As New SaveFileDialog
        Dim mystreamwriter As System.IO.StreamWriter
        save.Filter = "TEXT [*.txt]|*.txt|All Files [*.*]|*.*"
        save.CheckPathExists = True
        save.Title = "Guardar Como"
        save.ShowDialog(Me)
        Try
            mystreamwriter = System.IO.File.AppendText(save.FileName)
            mystreamwriter.Write(document.Text)
            mystreamwriter.Flush()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) 
        document.Clear()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim open As New OpenFileDialog
        Dim mystreamreader As System.IO.StreamReader
        open.Filter = "TEXT [*.txt]|*.txt|All Files [*.*]|*.*"
        open.CheckFileExists = True
        open.Title = "Abrir Archivo"
        open.ShowDialog(Me)
        Try
            open.OpenFile()
            mystreamreader = System.IO.File.OpenText(open.FileName)
            document.Text = mystreamreader.ReadToEnd
        Catch ex As Exception

        End Try
    End Sub
End Class