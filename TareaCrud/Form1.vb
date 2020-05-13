Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim cmd As New MySqlCommand
    Public Property Obj As Object

    Public Sub TbColor()
        ActualizarSelect()
    End Sub

    Private Sub AgregarRegistro_Click(sender As Object, e As EventArgs) Handles AgregarRegistro.Click
        conexion.ConnectionString = "Server='localhost';Database='veterinaria';Uid=root;Pwd='';"

        Try
            conexion.Open()
            cmd.Connection = conexion

            cmd.CommandText = "INSERT INTO perros (nombre_mascota,raza,color) VALUES(@nombre_mascota,@raza,@color)"
            cmd.Prepare()

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nombre_mascota", NombreMascotaCampo.Text)
            cmd.Parameters.AddWithValue("@raza", RazaCampo.Text)
            cmd.Parameters.AddWithValue("@color", CampoColor.Text)
            cmd.ExecuteNonQuery()
            NombreMascotaCampo.Clear()
            RazaCampo.Clear()
            CampoId.Clear()

            conexion.Close()

            ' MsgBox("Ah ingresado un nueva mascota ")
            ActualizarSelect()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub ActualizarSelect()
        Dim ds As DataSet = New DataSet
        Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter

        conexion.ConnectionString = "Server='localhost';Database='veterinaria';Uid=root;Pwd='';"


        Try
            conexion.Open()
            cmd.Connection = conexion

            cmd.CommandText = "SELECT * FROM perros ORDER BY id ASC"
            adaptador.SelectCommand = cmd
            adaptador.Fill(ds, "Tabla")
            VisorDeDatos.DataSource = ds
            VisorDeDatos.DataMember = "Tabla"


            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub TbColor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarSelect()
    End Sub

    Private Sub VisorDeDatos_SelectionChanged(sender As Object, e As EventArgs) Handles VisorDeDatos.SelectionChanged
        If VisorDeDatos.SelectedRows.Count > 0 Then
            NombreMascotaCampo.Text = VisorDeDatos.Item("nombre_mascota", VisorDeDatos.SelectedRows(0).Index).Value
            RazaCampo.Text = VisorDeDatos.Item("raza", VisorDeDatos.SelectedRows(0).Index).Value
            CampoId.Text = VisorDeDatos.Item("color", VisorDeDatos.SelectedRows(0).Index).Value
            CampoId.Text = VisorDeDatos.Item("id", VisorDeDatos.SelectedRows(0).Index).Value
        End If
    End Sub

    Private Sub EditarRegistro_Click(sender As Object, e As EventArgs) Handles EditarRegistro.Click
        conexion.ConnectionString = "Server='localhost';Database='veterinaria';Uid=root;Pwd='';"

        Try
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandText = "UPDATE perros SET nombre_mascota=@nombre_mascota, raza=@raza, color=@color WHERE id=@id"
            cmd.Prepare()

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nombre_mascota", NombreMascotaCampo.Text)
            cmd.Parameters.AddWithValue("@raza", RazaCampo.Text)
            cmd.Parameters.AddWithValue("@color", CampoColor.Text)
            cmd.Parameters.AddWithValue("@id", CampoId.Text)
            cmd.ExecuteNonQuery()
            NombreMascotaCampo.Clear()
            RazaCampo.Clear()
            CampoColor.Clear()
            CampoId.Clear()
            conexion.Close()

            ActualizarSelect()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EliminarRegistro_Click(sender As Object, e As EventArgs) Handles EliminarRegistro.Click
        conexion.ConnectionString = "Server='localhost';Database='veterinaria';Uid=root;Pwd='';"
        Try
            conexion.Open()
            cmd.Connection = conexion
            If MessageBox.Show("seguro de realizar esta accion", "confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

            End If
            cmd.CommandText = "Delete from perros where id = @id"
            cmd.Prepare()

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", CampoId.Text)
            cmd.ExecuteNonQuery()
            CampoId.Clear()


            conexion.Close()

            ActualizarSelect()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Pamela Rodriguez
    End Sub
End Class
