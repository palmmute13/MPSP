Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes

Public Class LOGIN

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbUsuario.TabIndex = 1


        'placeholder de los textbox
        tbUsuario.Text = "                     USUARIO"
        tbUsuario.ForeColor = Color.Gray

        tbContrasena.Text = "                 CONTRASEÑA"
        tbContrasena.ForeColor = Color.Gray
    End Sub

    Private Sub TextBoxUsuario_GotFocus(sender As Object, e As EventArgs) Handles tbUsuario.GotFocus
        tbUsuario.Text = ""
        tbUsuario.ForeColor = Color.Black
        tbContrasena.PasswordChar = ""
        tbContrasena.Text = "                 CONTRASEÑA"
        tbContrasena.ForeColor = Color.Gray



    End Sub

    Private Sub TextBoxUsuario_LostFocus(sender As Object, e As EventArgs) Handles tbUsuario.LostFocus

        If tbUsuario.Text = "                     USUARIO" Then
            tbUsuario.ForeColor = Color.Gray

        End If

        If tbUsuario.Text = "" Then
            tbUsuario.Text = "                     USUARIO"
            tbUsuario.ForeColor = Color.Gray

        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        End

    End Sub
    Private Sub TextBoxContrasena_GotFocus(sender As Object, e As EventArgs) Handles tbContrasena.GotFocus
        tbContrasena.Text = ""
        tbContrasena.ForeColor = Color.Black
        tbContrasena.PasswordChar = "X"
    End Sub

    Private Sub TextBoxContrasena_LostFocus(sender As Object, e As EventArgs) Handles tbContrasena.LostFocus
        If tbContrasena.Text = "                 CONTRASEÑA" Then
            tbUsuario.ForeColor = Color.Gray

        End If

        If tbContrasena.Text = "" Then
            tbContrasena.Text = "                 CONTRASEÑA"
            tbContrasena.ForeColor = Color.Gray

        End If

    End Sub
    Sub clear()
        tbUsuario.Text = Nothing
        tbContrasena.Text = ""
        tbUsuario.Focus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonEntrar.Click



        Dim cmd As New SqlCommand("SELECT * FROM logtable", conn)

        conn.Open()


        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        Dim j As Integer = 0
        Try
            While dr.Read()
                If tbUsuario.Text = dr(6) And tbContrasena.Text = dr(7) Then
                    contraseña = dr(7)
                    estado = dr(8)
                    usuario = tbUsuario.Text
                    Me.Hide()
                    HOME.Show()
                    tbUsuario.Clear()
                    tbContrasena.Clear()
                    j = 1
                End If
            End While
            If j <> 1 Then
                MsgBox("El usuario o contraseña son incorrectos.",
                MsgBoxStyle.Critical, "Informe de ingreso")
                clear()
            End If
        Catch exp As Exception
            MsgBox("ERROR:" & exp.Message, , "Mensaje")
        Finally
            conn.Close()
        End Try

        'If TextBoxUsuario.Text = "                     USUARIO" And TextBoxContrasena.Text = "                 CONTRASEÑA" Then
        '    MsgBox("'INTRODUSCA EL NOMBRE DE USUARIO Y CONTRASEÑA POR FAVOR'",)
        '    Return
        'End If

        'Dim Conn As New MySqlConnection("Server=192.168.0.10;Database=logdb; Uid=cliente;Pwd=3829777;")
        'Dim Cmd As New MySqlCommand("SELECT * FROM logtable Where usuario = @usuario and contrasena = @contrasena", Conn)
        '    Conn.Open()

        '    Cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = TextBoxUsuario.Text
        '    Cmd.Parameters.Add("@contrasena", MySqlDbType.VarChar).Value = TextBoxContrasena.Text

        '    Dim Adapt As New MySqlDataAdapter(Cmd)
        '    Dim Datable As New DataTable()
        '    Adapt.Fill(Datable)

        '    If Datable.Rows.Count() <= 0 Then
        '    MessageBox.Show("EL NOMBRE DE USUARIO Y CONTRASEÑA SON INVALIDO")
        '    TextBoxUsuario.Text = "                     USUARIO"
        '    TextBoxContrasena.Text = "                 CONTRASEÑA"
        '    TextBoxContrasena.ForeColor = Color.Gray
        '    TextBoxUsuario.ForeColor = Color.Gray
        '    TextBoxContrasena.PasswordChar = ""
        '    ButtonSalir.Focus()


        'Else
        '    HOME.Show()
        '    Me.Hide()

        'End If
        '    Conn.Close()
    End Sub

    Private Sub TextBoxUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbUsuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            tbContrasena.Focus()
        End If

    End Sub

    Private Sub TextBoxContrasena_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbContrasena.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            ButtonEntrar.Focus()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbHora.Text = TimeOfDay
        lbFecha.Text = DateString
    End Sub

    Private Sub tbUsuario_TextChanged(sender As Object, e As EventArgs) Handles tbUsuario.TextChanged
        tbUsuario.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tbUsuario.Text)
        tbUsuario.SelectionStart = tbUsuario.Text.Length
    End Sub
End Class
