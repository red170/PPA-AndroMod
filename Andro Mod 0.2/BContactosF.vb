Public Class tbcprincipal

    Private Sub BContactosF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarse()
        llenaGrid()
        txtid.Hide()
        txtapellido.Hide()
        txtnombre.Hide()
        txtid1.Hide()
        Label7.Hide()
        Label6.Hide()
        Label5.Hide()
        Label2.Hide()
        Label4.Hide()
        Label3.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        Label1.Hide()
        TextBox1.Hide()



    End Sub
    Private Sub llenaGrid()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strsql As String = "SELECT ID, NOMBRE, NUMERO FROM CONTACTOS"
        Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)

        ds.Tables.Add("Tabla")
        adp.Fill(ds.Tables("Tabla"))

        Me.DataGridView1.DataSource = ds.Tables("Tabla")

        Me.DataGridView1.Columns(0).HeaderText = "ID"

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Hide()
        Home.Show()
    End Sub


    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        Apps.Show()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

        Me.Close()
        Apps.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)
        

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If (Me.txtid.Text = "") Then
            MsgBox("Vacio", MsgBoxStyle.Information, "Administrador")
            Me.txtid.Select()
        Else
            Dim id As Integer
            Dim nombre As String = ""
            Dim numero As String = ""


            id = Me.txtid.Text
            nombre = Me.txtnombre.Text
            numero = Me.txtapellido.Text


            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            sql = "INSERT INTO CONTACTOS (ID, NOMBRE, NUMERO)"
            sql += " VALUES (" & id & ",'" & nombre & "','" & numero & "')"

            cmd.CommandText = sql
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Listo", MsgBoxStyle.Information, "Administrador")
                llenaGrid()

            Catch ex As Exception
                If ex.ToString.Contains("valores duplicados") Then
                    MsgBox("Ya Existe Un Contacto Con Ese Numero", MsgBoxStyle.Information, "Administrador")
                Else

                End If




            End Try
            txtid.Text = ""
            txtnombre.Text = ""
            txtapellido.Text = ""
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        txtid.Show()
        txtapellido.Show()
        txtnombre.Show()
        txtid1.Show()
        Label7.Show()
        Label6.Show()
        Label5.Show()
        Label2.Show()
        Label4.Show()
        TextBox1.Hide()
        DataGridView1.Hide()
        Label1.Hide()
        Label3.Show()
        Label8.Show()
        Label9.Show()
        Label10.Show()
        PictureBox1.Hide()


    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles Label7.Click
        txtid.Hide()
        txtapellido.Hide()
        txtnombre.Hide()
        txtid1.Hide()
        Label7.Hide()
        Label6.Hide()
        Label5.Hide()
        Label2.Hide()
        Label4.Hide()

        DataGridView1.Show()

        PictureBox1.Show()
        Label3.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()


    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs) Handles Label6.Click
        Dim iden As Integer
        iden = Me.txtid1.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        sql = "DELETE FROM CONTACTOS WHERE ID =" & iden & " "
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Eliminado", MsgBoxStyle.Information, "Administrador")
            llenaGrid()
        Catch ex As Exception

        End Try
        txtid1.Text = ""
    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles Label1.Click

        Dim id As String
        id = TextBox1.Text
        consultar(id)
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_MouseMove(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseMove

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class