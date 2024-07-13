Module BContactos
    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=BContactosF.mdb;Persist Security Info=False")
    Public cmd As New OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader
    Public sql As String = ""


    Public Sub conectarse()
        Try
            conn.Open()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub consultar(ByRef identificacion As String)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        If identificacion <> "" Then
            cmd.CommandText = "SELECT NOMBRE,NUMERO FROM CONTACTOS WHERE ID =" + identificacion
        Else
            cmd.CommandText = "SELECT NOMBRE,NUMERO FROM CONTACTOS"
        End If
        Try
            dr = cmd.ExecuteReader()
            If dr.HasRows Then

                While dr.Read()
                    MsgBox(dr(0).ToString + " " + dr(1).ToString + " " + dr(2).ToString, MsgBoxStyle.Information, "Administrador")

                End While
            Else
                MsgBox("El Registro No Existe", MsgBoxStyle.Information, "Administrador")
            End If
            dr.Close()

        Catch ex As Exception

        End Try

    End Sub
End Module

