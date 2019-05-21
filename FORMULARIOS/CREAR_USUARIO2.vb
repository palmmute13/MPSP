Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class CREAR_USUARIO2









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
    'Function cambia(ByVal cambiatext As String) As String
    '    Dim a As String = StrConv(cambiatext, VbStrConv.ProperCase)
    '    Return a
    'End Function
    Private Sub CREAR_USUARIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tbUsuario.Enabled = False
        tbContra.Enabled = False
        tbNIvelUsuario.Enabled = False
        btCrearUsuario.Enabled = False





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

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btCrearUsuario.Click
        Me.Hide()



        USER_PASS.ShowDialog()


    End Sub
    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]" &
        "*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            EmailAddressCheck = True

        Else
            EmailAddressCheck = False

        End If
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click


        If tbNombre.TextLength = 0 Then
            ErrorProvider1.SetError(tbNombre, "Debe llenar el campo Nombre en el formulario")
            Return

        Else
            ErrorProvider1.SetError(tbNombre, Nothing)

        End If

        If tbApellido.TextLength = 0 Then
            ErrorProvider1.SetError(tbApellido, "Debe llenar el campo Apellido en el formulario")
            Return
        End If
        ErrorProvider1.SetError(tbApellido, Nothing)


        If tbCedula.TextLength = 0 Then
            ErrorProvider1.SetError(tbCedula, "Debe llenar el campo Cedula en el formulario")
            Return
        Else
            ErrorProvider1.SetError(tbCedula, Nothing)

        End If


        If tbTelefono.TextLength = 0 Then
            ErrorProvider1.SetError(tbTelefono, "Debe llenar el campo Telefono en el formulario")
            Return

        Else
            ErrorProvider1.SetError(tbTelefono, Nothing)

        End If


        Dim email As String = tbEmail.Text
        If EmailAddressCheck(email) = False Then
            ErrorProvider1.SetError(tbEmail, "Debe ingresar un correo valido")
            Return

        Else
            ErrorProvider1.SetError(tbEmail, Nothing)

        End If


        If tbUsuario.TextLength = 0 Then
            MsgBox("Debe crear el Usuario")
            ErrorProvider1.SetError(btCrearUsuario, "Crear Usuario Aqui")
            Return
        Else


            ErrorProvider1.SetError(btCrearUsuario, Nothing)

        End If

        If tbContra.TextLength = 0 Then
            MsgBox("Debe crear el Usuario")
            ErrorProvider1.SetError(btCrearUsuario, "Crear Usuario Aqui")
            Return
        Else


            ErrorProvider1.SetError(btCrearUsuario, Nothing)

        End If

        If tbNIvelUsuario.TextLength = 0 Then
            MsgBox("Debe crear el Usuario")
            ErrorProvider1.SetError(btCrearUsuario, "Crear Usuario Aqui")
            Return
        Else


            ErrorProvider1.SetError(btCrearUsuario, Nothing)

        End If


        conn.Open()








        Dim command As SqlClient.SqlCommand = conn.CreateCommand()
        command.CommandText = "INSERT INTO logtable VALUES ('" & tbCedula.Text & "','" & tbNombre.Text & "','" & tbApellido.Text & "','" & tbTelefono.Text & "','" & tbEmail.Text & "','" & tbUsuario.Text & "','" & tbContra.Text & "','" & tbNIvelUsuario.Text & "','" & tbFecha.Text & "' )"
        If command.ExecuteNonQuery() > 0 Then
            MsgBox("USUARIO REGISTRADO")
        Else
            MsgBox("NO SEPUDO REGISTAR EL USUARIO ")
        End If


        cargar_datos()








        conn.Close()

        tbNombre.Text = ""
        tbApellido.Text = ""
        tbCedula.Text = ""
        tbTelefono.Text = ""
        tbEmail.Text = ""
        tbUsuario.Text = ""
        tbContra.Text = ""
        tbNIvelUsuario.Text = ""









        'Try

        '    Dim cmd As New SqlCommand("INSERT INTO logtable(cd_usuario, nombres, apellidos, telefono, email, usuario, contrasena, estado, fecha_ingreso) 
        '                             VAULES ('" & tbCedula.Text & "','" & tbNombre.Text & "','" & tbApellido.Text & "','" & tbTelefono.Text & "','" & tbEmail.Text & "','" & tbUsuario.Text & "','" & tbContra.Text & "','" & tbNIvelUsuario.Text & "','" & tbFecha.Text & "')", conn)







        '    conn.Open()
        '    cmd.ExecuteNonQuery()


        'Catch ex As Exception
        '    MsgBox("no conexion")
        'End Try






        ''cmd.Parameters.Add("@cd_usuario", SqlDbType.VarChar)
        ''cmd.Parameters.Add("@nombres", SqlDbType.VarChar)
        ''cmd.Parameters.Add("@apellidos", SqlDbType.VarChar)
        ''cmd.Parameters.Add("@telefono", SqlDbType.VarChar)
        ''cmd.Parameters.Add("@email", SqlDbType.VarChar)
        ''cmd.Parameters.Add("@usuario", SqlDbType.VarChar)
        ''cmd.Parameters.Add("@contrasena", SqlDbType.VarChar)
        ''cmd.Parameters.Add("@estado", SqlDbType.VarChar)
        ''cmd.Parameters.Add("@fecha_ingreso", SqlDbType.VarChar)


        ''cmd.Parameters("@cd_usuario").Value = tbCedula.Text
        ''cmd.Parameters("@nombres").Value = tbNombre.Text
        ''cmd.Parameters("@apellidos").Value = tbApellido.Text
        ''cmd.Parameters("@telefono").Value = tbTelefono.Text
        ''cmd.Parameters("@email").Value = tbEmail.Text
        ''cmd.Parameters("@usuario").Value = tbUsuario.Text
        ''cmd.Parameters("@contrasena").Value = tbContra.Text
        ''cmd.Parameters("@estado").Value = tbNIvelUsuario.Text
        ''cmd.Parameters("@fecha_ingreso").Value = tbFecha.Text



        ''cmd.ExecuteNonQuery()

        'conn.Close()
        'MsgBox("conexion")

    End Sub

    Private Sub tbEmail_TextChanged(sender As Object, e As EventArgs) Handles tbEmail.TextChanged
        If tbEmail.TextLength = 0 And tbNombre.TextLength = 0 And tbApellido.TextLength = 0 And tbCedula.TextLength = 0 And tbTelefono.TextLength = 0 Then
            btCrearUsuario.Enabled = False

        Else
            If tbEmail.TextLength > 0 And tbNombre.TextLength > 0 And tbApellido.TextLength > 0 And tbCedula.TextLength > 0 And tbTelefono.TextLength > 0 Then
                btCrearUsuario.Enabled = Enabled
            End If

        End If
    End Sub



    Private Sub tbEmail_GotFocus(sender As Object, e As EventArgs) Handles tbEmail.GotFocus
        If tbEmail.TextLength = 0 And tbNombre.TextLength = 0 And tbApellido.TextLength = 0 And tbCedula.TextLength = 0 And tbTelefono.TextLength = 0 Then
            btCrearUsuario.Enabled = False

        Else
            If tbEmail.TextLength > 0 And tbNombre.TextLength > 0 And tbApellido.TextLength > 0 And tbCedula.TextLength > 0 And tbTelefono.TextLength > 0 Then
                btCrearUsuario.Enabled = Enabled
            End If

        End If
    End Sub


    Private Sub tbEmail_LostFocus(sender As Object, e As EventArgs) Handles tbEmail.LostFocus
        If tbEmail.TextLength = 0 And tbNombre.TextLength = 0 And tbApellido.TextLength = 0 And tbCedula.TextLength = 0 And tbTelefono.TextLength = 0 Then
            btCrearUsuario.Enabled = False

        Else
            If tbEmail.TextLength > 0 And tbNombre.TextLength > 0 And tbApellido.TextLength > 0 And tbCedula.TextLength > 0 And tbTelefono.TextLength > 0 Then
                btCrearUsuario.Enabled = Enabled
            End If

        End If
    End Sub

    Private Sub tbNombre_TextChanged(sender As Object, e As EventArgs) Handles tbNombre.TextChanged
        tbNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tbNombre.Text)
        tbNombre.SelectionStart = tbNombre.Text.Length
    End Sub

    Private Sub tbApellido_TextChanged(sender As Object, e As EventArgs) Handles tbApellido.TextChanged
        tbApellido.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tbApellido.Text)
        tbApellido.SelectionStart = tbApellido.Text.Length
    End Sub
End Class