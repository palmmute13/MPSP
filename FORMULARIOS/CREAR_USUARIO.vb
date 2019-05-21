Imports System.Data
Imports System.Data.SqlClient

Public Class CREAR_USUARIO









    Private dt As New DataTable
    Private dv As New DataView





    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Sub cargar_datos() Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LogdbDataSet2.logtable' Puede moverla o quitarla según sea necesario.
        Me.LogtableTableAdapter.Fill(Me.LogdbDataSet2.logtable)
        Dim dt As New Data.DataSet
        Dim da As New SqlDataAdapter("select * from logtable", conn)
        da.Fill(dt, "logtable")
        DataGridView1.DataSource = dt.Tables("logtable")


    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tbHora.Text = TimeOfDay
        tbFecha.Text = DateString

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        HOME.Close()
        LOGIN.Show()

    End Sub

    Private Sub CREAR_USUARIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tbUsuario.Enabled = False
        tbContra.Enabled = False
        tbNIvelUsuario.Enabled = False




        'PARA ALININEAR EL HEADER DEL DATAGRIDVIEW AL CENTRO
        DataGridView1.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter





        DataGridView1.Columns(0).HeaderCell.Style.Font = New Font("Ariel", 8, FontStyle.Bold)
        DataGridView1.Columns(1).HeaderCell.Style.Font = New Font("Ariel", 8, FontStyle.Bold)
        DataGridView1.Columns(2).HeaderCell.Style.Font = New Font("Ariel", 8, FontStyle.Bold)
        DataGridView1.Columns(3).HeaderCell.Style.Font = New Font("Ariel", 8, FontStyle.Bold)
        DataGridView1.Columns(4).HeaderCell.Style.Font = New Font("Ariel", 8, FontStyle.Bold)
        DataGridView1.Columns(5).HeaderCell.Style.Font = New Font("Ariel", 8, FontStyle.Bold)
        DataGridView1.Columns(6).HeaderCell.Style.Font = New Font("Ariel", 8, FontStyle.Bold)
        DataGridView1.Columns(7).HeaderCell.Style.Font = New Font("Ariel", 8, FontStyle.Bold)
        DataGridView1.Columns(8).HeaderCell.Style.Font = New Font("Ariel", 8, FontStyle.Bold)
        DataGridView1.Columns(9).HeaderCell.Style.Font = New Font("Ariel", 8, FontStyle.Bold)

        DataGridView1.RowHeadersVisible = False

        'DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)

        'For X = 0 To DataGridView1.Columns.Count - 1
        '    If DataGridView1.Columns(X).ToString = Nothing Then
        '        DataGridView1.Columns.Remove(DataGridView1.Columns(X))
        '    End If
        'Next



    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()



        USER_PASS.ShowDialog()


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click


        Try

            Dim cmd As New SqlCommand("INSERT INTO logtable(cd_usuario, nombres, apellidos, telefono, email, usuario, contrasena, estado, fecha_ingreso) 
                                     VAULES (" & tbCedula.Text & " , " & tbNombre.Text & " , " & tbApellido.Text & " , " & tbTelefono.Text & ",
                                     " & tbEmail.Text & " , " & tbUsuario.Text & " , " & tbContra.Text & " , " & tbNIvelUsuario.Text & " , " & tbFecha.Text & ")", conn)







            conn.Open()
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox("no conexion")
        End Try






        'cmd.Parameters.Add("@cd_usuario", SqlDbType.VarChar)
        'cmd.Parameters.Add("@nombres", SqlDbType.VarChar)
        'cmd.Parameters.Add("@apellidos", SqlDbType.VarChar)
        'cmd.Parameters.Add("@telefono", SqlDbType.VarChar)
        'cmd.Parameters.Add("@email", SqlDbType.VarChar)
        'cmd.Parameters.Add("@usuario", SqlDbType.VarChar)
        'cmd.Parameters.Add("@contrasena", SqlDbType.VarChar)
        'cmd.Parameters.Add("@estado", SqlDbType.VarChar)
        'cmd.Parameters.Add("@fecha_ingreso", SqlDbType.VarChar)


        'cmd.Parameters("@cd_usuario").Value = tbCedula.Text
        'cmd.Parameters("@nombres").Value = tbNombre.Text
        'cmd.Parameters("@apellidos").Value = tbApellido.Text
        'cmd.Parameters("@telefono").Value = tbTelefono.Text
        'cmd.Parameters("@email").Value = tbEmail.Text
        'cmd.Parameters("@usuario").Value = tbUsuario.Text
        'cmd.Parameters("@contrasena").Value = tbContra.Text
        'cmd.Parameters("@estado").Value = tbNIvelUsuario.Text
        'cmd.Parameters("@fecha_ingreso").Value = tbFecha.Text



        'cmd.ExecuteNonQuery()

        conn.Close()
        MsgBox("conexion")

    End Sub
End Class