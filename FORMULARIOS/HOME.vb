Imports System.ComponentModel
'Using System;
'Using System.Collections.Generic;
'Using System.ComponentModel;
'Using System.Data;
'Using System.Drawing;
'Using System.Text;
'Using System.Windows.Forms;
'Using System.Net;
Public Class HOME
    Private Sub HOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtDip.BackColor = Color.LawnGreen
        TxtDPrinter.BackColor = Color.LawnGreen
        TxtDPc.BackColor = Color.LawnGreen
        TxtIp.BackColor = Color.Yellow
        TxtPc.BackColor = Color.Yellow
        TxtDPc.BackColor = Color.LawnGreen
        tbNivel.BackColor = Color.LawnGreen
        tbUsuario.BackColor = Color.Yellow
        LblFecha.BackColor = Color.Yellow
        TxtDfecha.BackColor = Color.LawnGreen
        TxtdHora.BackColor = Color.LawnGreen
        tbHora.BackColor = Color.Yellow
        TxtPrinter.BackColor = Color.Yellow





        'TxtPc.Text = My.Computer.Name.ToString
        LblPc.Text = My.Computer.Name.ToString

        'TxtIp.Text = getIp()
        LblIp.Text = getIp()



        Dim p As Printing.PrinterSettings
        p = New Printing.PrinterSettings()
        'TxtPrinter.Text = p.PrinterName
        LblPrinter.Text = p.PrinterName


        LblUsuarios.Text = usuario
        'tbUsuario.Text = usuario
        LblNivel.Text = estado



        If estado <> "Administrador" Then

            btnVentanasAA.Enabled = False
            btnVentanasCorrediza.Enabled = False



        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVentanasAA.Click

        VENTANA_AA.ShowDialog()




    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TxtDfecha.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'tbHora.Text = TimeOfDay
        'LblFecha.Text = DateString

        'LblFecha.Text = DateString
        LblHora.Text = TimeOfDay
        LblFechaDos.Text = DateString





    End Sub

    Private Sub CREARUSUARIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CREARUSUARIOToolStripMenuItem.Click
        CREAR_USUARIO2.ShowDialog()

    End Sub

    Private Sub ELIMINARUSUARIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARUSUARIOToolStripMenuItem.Click
        ELIMINAR_USUARIO.ShowDialog()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        End


    End Sub

    Private Sub tbUsuario_TextChanged(sender As Object, e As EventArgs) Handles tbUsuario.TextChanged

    End Sub

    Private Sub tbUsuario_GotFocus(sender As Object, e As EventArgs) Handles tbUsuario.GotFocus
        Clipboard.Clear()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtIp.TextChanged

    End Sub
End Class