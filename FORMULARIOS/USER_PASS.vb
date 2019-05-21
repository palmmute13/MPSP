
Imports System.Data.SqlClient

Public Class USER_PASS
    Private Sub btnUser_Pass_Click(sender As Object, e As EventArgs) Handles btnUser_Pass.Click


        If txtContra.Text <> txtConfirmar.Text Then

            ErrorProvider1.SetError(txtConfirmar, "La contraseña es diferente")
            Return

        Else
            ErrorProvider1.SetError(txtConfirmar, Nothing)

        End If






        Dim cmd As New SqlCommand("SELECT * FROM logtable", conn)

        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("Error de conexion con el Servidor")
        End Try








        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        Dim j As Integer = 0
        Try
            While dr.Read()
                If txtUsuario.Text = dr(6) Then
                    j = 1
                End If
            End While

            If j = 1 Then
                MsgBox("El usuario ya existe.",
                MsgBoxStyle.Critical, "Informe de ingreso")
                txtUsuario.Text = ""
                txtUsuario.Focus()
                Return

            End If


        Catch exp As Exception
            MsgBox("ERROR:" & exp.Message, , "Mensaje")
        Finally
            conn.Close()
        End Try





        usr = txtUsuario.Text
        Contra = txtContra.Text
        nivel = cbNivelUsuario.Text
        Me.Hide()
        CREAR_USUARIO2.Show()

        CREAR_USUARIO2.tbUsuario.Text = usr
        CREAR_USUARIO2.tbContra.Text = Contra
        CREAR_USUARIO2.tbNIvelUsuario.Text = nivel











    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

        CREAR_USUARIO2.Show()
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        txtUsuario.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtUsuario.Text)
        txtUsuario.SelectionStart = txtUsuario.Text.Length
    End Sub

    Private Sub USER_PASS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Text = CREAR_USUARIO2.tbNombre.Text

    End Sub
End Class