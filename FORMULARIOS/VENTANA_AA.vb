Public Class VENTANA_AA

    Private Sub VENTANA_AA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxbAncho.Text = 0
        TxbAlto.Text = 0
        CbxAncho.Text = 0
        CbxAlto.Text = 0



    End Sub




    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim ValorTbxAncho As Double
        Dim ValorTbxAlto As Double

        Dim SalidaAncho As Double
        Dim SalidaAlto As Double

        Dim ComversorAncho As String
        Dim ComversorAlto As String


        Dim SwitchAncho As Double
        Dim SwitchAlto As Double

        Dim RestaAncho As String = ""
        Dim RestaAlto As String = ""

        Dim Espacio As String = " "

        Dim JambaDivicion As Double
        Dim Jambas As Double = 2
        Dim Regla As Double
        Dim Huecorejuego As Double = 0.25
        Dim DeciSalidaAncho As Double
        Dim RedonderCelocia As Double
        Dim ResultadoCeloAlto As Double
        Dim ResultadoCeloAltoFinal As Double
        Dim CeloDiviciones As Double
        Dim AumentoUnaDivicion As String = ""
        Dim AumentoDosDivicion As String = ""
        Dim AumentoTresDivicion As String = ""
        Dim AumentoCuatroDivicion As String = ""
        Dim AumentoCincoDivicion As String = ""






        'CAPTURA EL ANCHO 
        ValorTbxAncho = TxbAncho.Text
        ValorTbxAlto = TxbAlto.Text


        If ValorTbxAncho >= 0 And ValorTbxAncho <= 30 Then
            Diviciones = 0
        End If

        If ValorTbxAncho >= 31 And ValorTbxAncho <= 60 Then
            Diviciones = 1
        End If

        If ValorTbxAncho >= 61 And ValorTbxAncho <= 90 Then
            Diviciones = 2
        End If

        If ValorTbxAncho >= 91 And ValorTbxAncho <= 120 Then
            Diviciones = 3
        End If
        If ValorTbxAncho >= 121 And ValorTbxAncho <= 150 Then
            Diviciones = 4
        End If

        If ValorTbxAncho >= 151 Then
            Diviciones = 5
        End If
        txtDiviciones.Text = Diviciones
        '**************************

        'ANCHO DEL CUADRO

        'DE 0 A 3/4
        If CbxAncho.Text = "0" Then
            SalidaAncho = 0
            ComversorAncho = ""
            RestaAncho = "3/4"
            SwitchAncho = 0.75
            AumentoUnaDivicion = "3/8"
            AumentoDosDivicion = "1/4"
            AumentoTresDivicion = "11/16"
            AumentoCuatroDivicion = "1/8"
            AumentoCincoDivicion = "1/8"
            'DE 1/6 A 13/16
        ElseIf CbxAncho.Text = "1/16" Then
            SalidaAncho = 0.0625
            ComversorAncho = "1/16"
            RestaAncho = "13/16"
            SwitchAncho = 0.8125
            AumentoUnaDivicion = "3/8"
            AumentoDosDivicion = "1/4"
            AumentoTresDivicion = "11/16"
            AumentoCuatroDivicion = "1/8"
            AumentoCincoDivicion = "1/8"
            'DE 1/8 A 7/8
        ElseIf CbxAncho.Text = "1/8" Then
            SalidaAncho = 0.125
            ComversorAncho = "1/8"
            RestaAncho = "7/8"
            SwitchAncho = 0.875
            AumentoUnaDivicion = "7/16"
            AumentoDosDivicion = "1/4"
            AumentoTresDivicion = "11/16"
            AumentoCuatroDivicion = "1/8"
            AumentoCincoDivicion = "1/8"
            'DE 3/16 A 15/16
        ElseIf CbxAncho.Text = "3/16" Then
            SalidaAncho = 0.1875
            ComversorAncho = "3/16"
            RestaAncho = "15/16"
            SwitchAncho = 0.9375
            AumentoUnaDivicion = "7/16"
            AumentoDosDivicion = "5/16"
            AumentoTresDivicion = "11/16"
            AumentoCuatroDivicion = "3/16"
            AumentoCincoDivicion = "1/8"
            'DE 1/4 A 0
        ElseIf CbxAncho.Text = "1/4" Then
            SalidaAncho = 0
            ComversorAncho = "1/4"
            RestaAncho = ""
            SwitchAncho = 0
            AumentoUnaDivicion = "1/2"
            AumentoDosDivicion = "5/16"
            AumentoTresDivicion = "3/4"
            AumentoTresDivicion = "11/16"
            AumentoCuatroDivicion = "3/16"
            AumentoCincoDivicion = "1/8"
            'DE 5/16 A 1/16
        ElseIf CbxAncho.Text = "5/16" Then
            SalidaAncho = 0.3125
            ComversorAncho = "5/16"
            RestaAncho = "15/16"
            SwitchAncho = 0
            AumentoUnaDivicion = "1/2"
            AumentoDosDivicion = "5/16"
            AumentoTresDivicion = "3/4"
            AumentoCuatroDivicion = "3/16"
            AumentoCincoDivicion = "1/8"
            'DE 3/8 A 1/8
        ElseIf CbxAncho.Text = "3/8" Then
            SalidaAncho = 0.375
            ComversorAncho = "3/8"
            RestaAncho = "1/8"
            SwitchAncho = 0
            AumentoUnaDivicion = "9/16"
            AumentoDosDivicion = "3/8"
            AumentoTresDivicion = "3/4"
            AumentoCuatroDivicion = "3/16"
            AumentoCincoDivicion = "3/16"
            'DE 7/16 A 3/16
        ElseIf CbxAncho.Text = "7/16" Then
            SalidaAncho = 0.4375
            ComversorAncho = "7/16"
            RestaAncho = "3/16"
            SwitchAncho = 0
            AumentoUnaDivicion = "9/16"
            AumentoDosDivicion = "3/4"
            AumentoTresDivicion = "3/16"
            AumentoCuatroDivicion = "3/16"
            AumentoCincoDivicion = "3/16"
            'DE 1/2 A 1/4
        ElseIf CbxAncho.Text = "1/2" Then
            SalidaAncho = 0.5
            ComversorAncho = "1/2"
            RestaAncho = "1/4"
            SwitchAncho = 0
            AumentoUnaDivicion = "5/8"
            AumentoDosDivicion = "3/8"
            AumentoTresDivicion = "13/16"
            AumentoCuatroDivicion = "1/4"
            AumentoCincoDivicion = "3/16"
            'DE 9/16 A 5/16
        ElseIf CbxAncho.Text = "9/16" Then
            SalidaAncho = 0.5625
            ComversorAncho = "9/16"
            RestaAncho = "5/16"
            SwitchAncho = 0
            AumentoUnaDivicion = "5/8"
            AumentoDosDivicion = "7/16"
            AumentoTresDivicion = "13/16"
            AumentoCuatroDivicion = "1/4"
            AumentoCincoDivicion = "3/16"
            'DE 5/8 A 3/8
        ElseIf CbxAncho.Text = "5/8" Then
            SalidaAncho = 0.625
            ComversorAncho = "5/8"
            RestaAncho = "3/8"
            SwitchAncho = 0
            AumentoUnaDivicion = "11/16"
            AumentoDosDivicion = "7/16"
            AumentoTresDivicion = "13/16"
            AumentoCuatroDivicion = "1/4"
            AumentoCincoDivicion = "3/16"

            'DE 11/16 A 7/16
        ElseIf CbxAncho.Text = "11/16" Then
            SalidaAncho = 0.6875
            ComversorAncho = "11/16"
            RestaAncho = "7/16"
            SwitchAncho = 0
            AumentoUnaDivicion = "11/16"
            AumentoDosDivicion = "7/16"
            AumentoTresDivicion = "13/16"
            AumentoCuatroDivicion = "1/4"
            AumentoCincoDivicion = "3/16"
            'DE 3/4 A 1/2
        ElseIf CbxAncho.Text = "3/4" Then
            SalidaAncho = 0.75
            ComversorAncho = "3/4"
            RestaAncho = "1/2"
            SwitchAncho = 0
            AumentoUnaDivicion = "3/4"
            AumentoDosDivicion = "1/2"
            AumentoTresDivicion = "7/8"
            AumentoCuatroDivicion = "1/4"
            AumentoCincoDivicion = "1/4"
            'DE 13/16 A 9/16
        ElseIf CbxAncho.Text = "13/16" Then
            SalidaAncho = 0.8125
            ComversorAncho = "13/16"
            RestaAncho = "9/16"
            SwitchAncho = 0
            AumentoUnaDivicion = "3/4"
            AumentoDosDivicion = "1/2"
            AumentoTresDivicion = "7/8"
            AumentoCuatroDivicion = "5/16"
            AumentoCincoDivicion = "3/16"
            AumentoCincoDivicion = "1/4"
            'DE 7/8 A 5/8
        ElseIf CbxAncho.Text = "7/8" Then
            SalidaAncho = 0.875
            ComversorAncho = "7/8"
            RestaAncho = "5/8"
            SwitchAncho = 0
            AumentoUnaDivicion = "13/16"
            AumentoDosDivicion = "1/2"
            AumentoTresDivicion = "7/8"
            AumentoCuatroDivicion = "5/16"
            AumentoCincoDivicion = "1/4"
            'DE 15/16 A 11/16
        ElseIf CbxAncho.Text = "15/16" Then
            SalidaAncho = 0.9375
            ComversorAncho = "15/16"
            RestaAncho = "11/16"
            SwitchAncho = 0
            AumentoUnaDivicion = "13/16"
            AumentoDosDivicion = "9/16"
            AumentoTresDivicion = "7/8"
            AumentoCuatroDivicion = "5/16"
            AumentoCincoDivicion = "1/4"
        End If


        If TxbAncho.Text = 32 And CbxAncho.Text = "0" Or TxbAncho.Text = 32 And CbxAncho.Text = "1/16" Then

            AumentoUnaDivicion = "7/8"

        ElseIf TxbAncho.Text = 34 And CbxAncho.Text = "0" Or TxbAncho.Text = 34 And CbxAncho.Text = "1/16" Then
            AumentoUnaDivicion = "7/8"

        ElseIf TxbAncho.Text = 36 And CbxAncho.Text = "0" Or TxbAncho.Text = 36 And CbxAncho.Text = "1/16" Then
            AumentoUnaDivicion = "7/8"

        ElseIf TxbAncho.Text = 38 And CbxAncho.Text = "0" Or TxbAncho.Text = 38 And CbxAncho.Text = "1/16" Then
            AumentoUnaDivicion = "7/8"

        ElseIf TxbAncho.Text = 40 And CbxAncho.Text = "0" Or TxbAncho.Text = 40 And CbxAncho.Text = "1/16" Then
            AumentoUnaDivicion = "7/8"

        ElseIf TxbAncho.Text = 42 And CbxAncho.Text = "0" Or TxbAncho.Text = 42 And CbxAncho.Text = "1/16" Then
            AumentoUnaDivicion = "7/8"

        ElseIf TxbAncho.Text = 44 And CbxAncho.Text = "0" Or TxbAncho.Text = 44 And CbxAncho.Text = "1/16" Then
            AumentoUnaDivicion = "7/8"

        ElseIf TxbAncho.Text = 46 And CbxAncho.Text = "0" Or TxbAncho.Text = 46 And CbxAncho.Text = "1/16" Then
            AumentoUnaDivicion = "7/8"

        ElseIf TxbAncho.Text = 48 And CbxAncho.Text = "0" Or TxbAncho.Text = 48 And CbxAncho.Text = "1/16" Then
            AumentoUnaDivicion = "7/8"

        ElseIf TxbAncho.Text = 50 And CbxAncho.Text = "0" Or TxbAncho.Text = 50 And CbxAncho.Text = "1/16" Then
            AumentoUnaDivicion = "7/8"

        ElseIf TxbAncho.Text = 52 And CbxAncho.Text = "0" Or TxbAncho.Text = 52 And CbxAncho.Text = "1/16" Then
            AumentoUnaDivicion = "7/8"

        ElseIf TxbAncho.Text = 54 And CbxAncho.Text = "0" Or TxbAncho.Text = 54 And CbxAncho.Text = "1/16" Then
            AumentoUnaDivicion = "7/8"

        ElseIf TxbAncho.Text = 56 And CbxAncho.Text = "0" Or TxbAncho.Text = 56 And CbxAncho.Text = "1/16" Then
            AumentoUnaDivicion = "7/8"

        ElseIf TxbAncho.Text = 58 And CbxAncho.Text = "0" Or TxbAncho.Text = 58 And CbxAncho.Text = "1/16" Then
            AumentoUnaDivicion = "7/8"

        ElseIf TxbAncho.Text = 60 And CbxAncho.Text = "0" Or TxbAncho.Text = 60 And CbxAncho.Text = "1/16" Then
            AumentoUnaDivicion = "7/8"

        End If

        If TxbAncho.Text = 32 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 32 And CbxAncho.Text = "3/16" Then

            AumentoUnaDivicion = "15/16"

        ElseIf TxbAncho.Text = 34 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 34 And CbxAncho.Text = "3/16" Then
            AumentoUnaDivicion = "15/16"

        ElseIf TxbAncho.Text = 36 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 36 And CbxAncho.Text = "3/16" Then
            AumentoUnaDivicion = "15/16"

        ElseIf TxbAncho.Text = 38 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 38 And CbxAncho.Text = "3/16" Then
            AumentoUnaDivicion = "15/16"

        ElseIf TxbAncho.Text = 40 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 40 And CbxAncho.Text = "3/16" Then
            AumentoUnaDivicion = "15/16"

        ElseIf TxbAncho.Text = 42 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 42 And CbxAncho.Text = "3/16" Then
            AumentoUnaDivicion = "15/16"

        ElseIf TxbAncho.Text = 44 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 44 And CbxAncho.Text = "3/16" Then
            AumentoUnaDivicion = "15/16"

        ElseIf TxbAncho.Text = 46 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 46 And CbxAncho.Text = "3/16" Then
            AumentoUnaDivicion = "15/16"

        ElseIf TxbAncho.Text = 48 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 48 And CbxAncho.Text = "3/16" Then
            AumentoUnaDivicion = "15/16"

        ElseIf TxbAncho.Text = 50 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 50 And CbxAncho.Text = "3/16" Then
            AumentoUnaDivicion = "15/16"

        ElseIf TxbAncho.Text = 52 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 52 And CbxAncho.Text = "3/16" Then
            AumentoUnaDivicion = "15/16"

        ElseIf TxbAncho.Text = 54 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 54 And CbxAncho.Text = "3/16" Then
            AumentoUnaDivicion = "15/16"

        ElseIf TxbAncho.Text = 56 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 56 And CbxAncho.Text = "3/16" Then
            AumentoUnaDivicion = "15/16"

        ElseIf TxbAncho.Text = 58 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 58 And CbxAncho.Text = "3/16" Then
            AumentoUnaDivicion = "15/16"

        ElseIf TxbAncho.Text = 60 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 60 And CbxAncho.Text = "3/16" Then
            AumentoUnaDivicion = "15/16"

        End If



        If TxbAncho.Text = 32 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 32 And CbxAncho.Text = "5/16" Then

            AumentoUnaDivicion = ""

        ElseIf TxbAncho.Text = 34 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 34 And CbxAncho.Text = "5/16" Then
            AumentoUnaDivicion = ""

        ElseIf TxbAncho.Text = 36 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 36 And CbxAncho.Text = "5/16" Then
            AumentoUnaDivicion = ""

        ElseIf TxbAncho.Text = 38 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 38 And CbxAncho.Text = "5/16" Then
            AumentoUnaDivicion = ""

        ElseIf TxbAncho.Text = 40 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 40 And CbxAncho.Text = "5/16" Then
            AumentoUnaDivicion = ""

        ElseIf TxbAncho.Text = 42 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 42 And CbxAncho.Text = "5/16" Then
            AumentoUnaDivicion = ""

        ElseIf TxbAncho.Text = 44 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 44 And CbxAncho.Text = "5/16" Then
            AumentoUnaDivicion = ""

        ElseIf TxbAncho.Text = 46 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 46 And CbxAncho.Text = "5/16" Then
            AumentoUnaDivicion = ""

        ElseIf TxbAncho.Text = 48 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 48 And CbxAncho.Text = "5/16" Then
            AumentoUnaDivicion = ""

        ElseIf TxbAncho.Text = 50 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 50 And CbxAncho.Text = "5/16" Then
            AumentoUnaDivicion = ""

        ElseIf TxbAncho.Text = 52 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 52 And CbxAncho.Text = "5/16" Then
            AumentoUnaDivicion = ""

        ElseIf TxbAncho.Text = 54 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 54 And CbxAncho.Text = "5/16" Then
            AumentoUnaDivicion = ""

        ElseIf TxbAncho.Text = 56 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 56 And CbxAncho.Text = "5/16" Then
            AumentoUnaDivicion = ""

        ElseIf TxbAncho.Text = 58 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 58 And CbxAncho.Text = "5/16" Then
            AumentoUnaDivicion = ""

        ElseIf TxbAncho.Text = 60 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 60 And CbxAncho.Text = "5/16" Then
            AumentoUnaDivicion = ""

        End If

        If TxbAncho.Text = 32 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 32 And CbxAncho.Text = "7/16" Then

            AumentoUnaDivicion = "1/16"

        ElseIf TxbAncho.Text = 34 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 34 And CbxAncho.Text = "7/16" Then
            AumentoUnaDivicion = "1/16"

        ElseIf TxbAncho.Text = 36 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 36 And CbxAncho.Text = "7/16" Then
            AumentoUnaDivicion = "1/16"

        ElseIf TxbAncho.Text = 38 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 38 And CbxAncho.Text = "7/16" Then
            AumentoUnaDivicion = "1/16"

        ElseIf TxbAncho.Text = 40 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 40 And CbxAncho.Text = "7/16" Then
            AumentoUnaDivicion = "1/16"

        ElseIf TxbAncho.Text = 42 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 42 And CbxAncho.Text = "7/16" Then
            AumentoUnaDivicion = "1/16"

        ElseIf TxbAncho.Text = 44 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 44 And CbxAncho.Text = "7/16" Then
            AumentoUnaDivicion = "1/16"

        ElseIf TxbAncho.Text = 46 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 46 And CbxAncho.Text = "7/16" Then
            AumentoUnaDivicion = "1/16"

        ElseIf TxbAncho.Text = 48 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 48 And CbxAncho.Text = "7/16" Then
            AumentoUnaDivicion = "1/16"

        ElseIf TxbAncho.Text = 50 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 50 And CbxAncho.Text = "7/16" Then
            AumentoUnaDivicion = "1/16"

        ElseIf TxbAncho.Text = 52 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 52 And CbxAncho.Text = "7/16" Then
            AumentoUnaDivicion = "1/16"

        ElseIf TxbAncho.Text = 54 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 54 And CbxAncho.Text = "7/16" Then
            AumentoUnaDivicion = "1/16"

        ElseIf TxbAncho.Text = 56 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 56 And CbxAncho.Text = "7/16" Then
            AumentoUnaDivicion = "1/16"

        ElseIf TxbAncho.Text = 58 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 58 And CbxAncho.Text = "7/16" Then
            AumentoUnaDivicion = "1/16"

        ElseIf TxbAncho.Text = 60 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 60 And CbxAncho.Text = "7/16" Then
            AumentoUnaDivicion = "1/16"

        End If



        If TxbAncho.Text = 32 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 32 And CbxAncho.Text = "9/16" Then

            AumentoUnaDivicion = "1/8"

        ElseIf TxbAncho.Text = 34 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 34 And CbxAncho.Text = "9/16" Then
            AumentoUnaDivicion = "1/8"

        ElseIf TxbAncho.Text = 36 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 36 And CbxAncho.Text = "9/16" Then
            AumentoUnaDivicion = "1/8"

        ElseIf TxbAncho.Text = 38 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 38 And CbxAncho.Text = "9/16" Then
            AumentoUnaDivicion = "1/8"

        ElseIf TxbAncho.Text = 40 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 40 And CbxAncho.Text = "9/16" Then
            AumentoUnaDivicion = "1/8"

        ElseIf TxbAncho.Text = 42 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 42 And CbxAncho.Text = "9/16" Then
            AumentoUnaDivicion = "1/8"

        ElseIf TxbAncho.Text = 44 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 44 And CbxAncho.Text = "9/16" Then
            AumentoUnaDivicion = "1/8"

        ElseIf TxbAncho.Text = 46 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 46 And CbxAncho.Text = "9/16" Then
            AumentoUnaDivicion = "1/8"

        ElseIf TxbAncho.Text = 48 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 48 And CbxAncho.Text = "9/16" Then
            AumentoUnaDivicion = "1/8"

        ElseIf TxbAncho.Text = 50 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 50 And CbxAncho.Text = "9/16" Then
            AumentoUnaDivicion = "1/8"

        ElseIf TxbAncho.Text = 52 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 52 And CbxAncho.Text = "9/16" Then
            AumentoUnaDivicion = "1/8"

        ElseIf TxbAncho.Text = 54 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 54 And CbxAncho.Text = "9/16" Then
            AumentoUnaDivicion = "1/8"

        ElseIf TxbAncho.Text = 56 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 56 And CbxAncho.Text = "9/16" Then
            AumentoUnaDivicion = "1/8"

        ElseIf TxbAncho.Text = 58 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 58 And CbxAncho.Text = "9/16" Then
            AumentoUnaDivicion = "1/8"

        ElseIf TxbAncho.Text = 60 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 60 And CbxAncho.Text = "9/16" Then
            AumentoUnaDivicion = "1/8"

        End If



        If TxbAncho.Text = 32 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 32 And CbxAncho.Text = "11/16" Then

            AumentoUnaDivicion = "3/16"

        ElseIf TxbAncho.Text = 34 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 34 And CbxAncho.Text = "11/16" Then
            AumentoUnaDivicion = "3/16"

        ElseIf TxbAncho.Text = 36 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 36 And CbxAncho.Text = "11/16" Then
            AumentoUnaDivicion = "3/16"

        ElseIf TxbAncho.Text = 38 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 38 And CbxAncho.Text = "11/16" Then
            AumentoUnaDivicion = "3/16"

        ElseIf TxbAncho.Text = 40 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 40 And CbxAncho.Text = "11/16" Then
            AumentoUnaDivicion = "3/16"

        ElseIf TxbAncho.Text = 42 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 42 And CbxAncho.Text = "11/16" Then
            AumentoUnaDivicion = "3/16"

        ElseIf TxbAncho.Text = 44 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 44 And CbxAncho.Text = "11/16" Then
            AumentoUnaDivicion = "3/16"

        ElseIf TxbAncho.Text = 46 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 46 And CbxAncho.Text = "11/16" Then
            AumentoUnaDivicion = "3/16"

        ElseIf TxbAncho.Text = 48 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 48 And CbxAncho.Text = "11/16" Then
            AumentoUnaDivicion = "3/16"

        ElseIf TxbAncho.Text = 50 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 50 And CbxAncho.Text = "11/16" Then
            AumentoUnaDivicion = "3/16"

        ElseIf TxbAncho.Text = 52 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 52 And CbxAncho.Text = "11/16" Then
            AumentoUnaDivicion = "3/16"

        ElseIf TxbAncho.Text = 54 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 54 And CbxAncho.Text = "11/16" Then
            AumentoUnaDivicion = "3/16"

        ElseIf TxbAncho.Text = 56 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 56 And CbxAncho.Text = "11/16" Then
            AumentoUnaDivicion = "3/16"

        ElseIf TxbAncho.Text = 58 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 58 And CbxAncho.Text = "11/16" Then
            AumentoUnaDivicion = "3/16"

        ElseIf TxbAncho.Text = 60 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 60 And CbxAncho.Text = "11/16" Then
            AumentoUnaDivicion = "3/16"

        End If


        If TxbAncho.Text = 32 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 32 And CbxAncho.Text = "13/16" Then

            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 34 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 34 And CbxAncho.Text = "13/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 36 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 36 And CbxAncho.Text = "13/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 38 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 38 And CbxAncho.Text = "13/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 40 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 40 And CbxAncho.Text = "13/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 42 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 42 And CbxAncho.Text = "13/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 44 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 44 And CbxAncho.Text = "13/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 46 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 46 And CbxAncho.Text = "13/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 48 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 48 And CbxAncho.Text = "13/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 50 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 50 And CbxAncho.Text = "13/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 52 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 52 And CbxAncho.Text = "13/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 54 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 54 And CbxAncho.Text = "13/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 56 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 56 And CbxAncho.Text = "13/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 58 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 58 And CbxAncho.Text = "13/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 60 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 60 And CbxAncho.Text = "13/16" Then
            AumentoUnaDivicion = "1/4"

        End If


        If TxbAncho.Text = 32 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 32 And CbxAncho.Text = "15/16" Then

            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 34 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 34 And CbxAncho.Text = "15/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 36 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 36 And CbxAncho.Text = "15/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 38 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 38 And CbxAncho.Text = "15/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 40 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 40 And CbxAncho.Text = "15/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 42 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 42 And CbxAncho.Text = "15/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 44 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 44 And CbxAncho.Text = "15/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 46 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 46 And CbxAncho.Text = "15/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 48 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 48 And CbxAncho.Text = "15/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 50 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 50 And CbxAncho.Text = "15/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 52 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 52 And CbxAncho.Text = "15/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 54 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 54 And CbxAncho.Text = "15/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 56 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 56 And CbxAncho.Text = "15/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 58 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 58 And CbxAncho.Text = "15/16" Then
            AumentoUnaDivicion = "1/4"

        ElseIf TxbAncho.Text = 60 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 60 And CbxAncho.Text = "15/16" Then
            AumentoUnaDivicion = "1/4"

        End If



        If TxbAncho.Text = 62 And CbxAncho.Text = "0" Or TxbAncho.Text = 62 And CbxAncho.Text = "1/16" Then

            AumentoDosDivicion = "9/16"


        ElseIf TxbAncho.Text = 62 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 62 And CbxAncho.Text = "3/16" Or
            TxbAncho.Text = 62 And CbxAncho.Text = "1/4" Then

            AumentoDosDivicion = "5/8"

        ElseIf TxbAncho.Text = 62 And CbxAncho.Text = "5/16" Or TxbAncho.Text = 62 And CbxAncho.Text = "3/8" Or
            TxbAncho.Text = 62 And CbxAncho.Text = "7/16" Then

            AumentoDosDivicion = "11/16"

        ElseIf TxbAncho.Text = 62 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 62 And CbxAncho.Text = "9/16" Or
             TxbAncho.Text = 62 And CbxAncho.Text = "5/8" Then

            AumentoDosDivicion = "3/4"

        ElseIf TxbAncho.Text = 62 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 62 And CbxAncho.Text = "9/16" Or
            TxbAncho.Text = 62 And CbxAncho.Text = "5/8" Then

            AumentoDosDivicion = "3/4"

        ElseIf TxbAncho.Text = 62 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 62 And CbxAncho.Text = "3/4" Or
            TxbAncho.Text = 62 And CbxAncho.Text = "13/16" Then

            AumentoDosDivicion = "13/16"

        ElseIf TxbAncho.Text = 62 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 62 And CbxAncho.Text = "15/16" Then

            AumentoDosDivicion = "7/8"


        End If


        If TxbAncho.Text = 63 And CbxAncho.Text = "0" Then

            AumentoDosDivicion = "7/8"


        ElseIf TxbAncho.Text = 63 And CbxAncho.Text = "1/16" Or TxbAncho.Text = 63 And CbxAncho.Text = "1/8" Or
            TxbAncho.Text = 63 And CbxAncho.Text = "3/16" Then

            AumentoDosDivicion = "15/16"

        ElseIf TxbAncho.Text = 63 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 63 And CbxAncho.Text = "5/16" Or
            TxbAncho.Text = 63 And CbxAncho.Text = "3/8" Then

            AumentoDosDivicion = ""

        ElseIf TxbAncho.Text = 63 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 63 And CbxAncho.Text = "1/2" Or
             TxbAncho.Text = 63 And CbxAncho.Text = "9/16" Then

            AumentoDosDivicion = "1/16"

        ElseIf TxbAncho.Text = 63 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 63 And CbxAncho.Text = "11/16" Or
            TxbAncho.Text = 63 And CbxAncho.Text = "3/4" Then

            AumentoDosDivicion = "1/8"

        ElseIf TxbAncho.Text = 63 And CbxAncho.Text = "13/16" Or TxbAncho.Text = 63 And CbxAncho.Text = "7/8" Or
            TxbAncho.Text = 63 And CbxAncho.Text = "15/16" Then

            AumentoDosDivicion = "3/16"



        End If


        If TxbAncho.Text = 65 And CbxAncho.Text = "0" Or TxbAncho.Text = 65 And CbxAncho.Text = "1/16" Then

            AumentoDosDivicion = "9/16"


        ElseIf TxbAncho.Text = 65 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 65 And CbxAncho.Text = "3/16" Or
            TxbAncho.Text = 65 And CbxAncho.Text = "1/4" Then

            AumentoDosDivicion = "5/8"

        ElseIf TxbAncho.Text = 65 And CbxAncho.Text = "5/16" Or TxbAncho.Text = 65 And CbxAncho.Text = "3/8" Or
            TxbAncho.Text = 65 And CbxAncho.Text = "7/16" Then

            AumentoDosDivicion = "11/16"

        ElseIf TxbAncho.Text = 65 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 65 And CbxAncho.Text = "9/16" Or
             TxbAncho.Text = 65 And CbxAncho.Text = "5/8" Then

            AumentoDosDivicion = "3/4"

        ElseIf TxbAncho.Text = 65 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 65 And CbxAncho.Text = "9/16" Or
            TxbAncho.Text = 65 And CbxAncho.Text = "5/8" Then

            AumentoDosDivicion = "3/4"

        ElseIf TxbAncho.Text = 65 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 65 And CbxAncho.Text = "3/4" Or
            TxbAncho.Text = 65 And CbxAncho.Text = "13/16" Then

            AumentoDosDivicion = "13/16"

        ElseIf TxbAncho.Text = 65 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 65 And CbxAncho.Text = "15/16" Then

            AumentoDosDivicion = "7/8"


        End If


        If TxbAncho.Text = 66 And CbxAncho.Text = "0" Then

            AumentoDosDivicion = "7/8"


        ElseIf TxbAncho.Text = 66 And CbxAncho.Text = "1/16" Or TxbAncho.Text = 66 And CbxAncho.Text = "1/8" Or
            TxbAncho.Text = 66 And CbxAncho.Text = "3/16" Then

            AumentoDosDivicion = "15/16"

        ElseIf TxbAncho.Text = 66 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 66 And CbxAncho.Text = "5/16" Or
            TxbAncho.Text = 66 And CbxAncho.Text = "3/8" Then

            AumentoDosDivicion = ""

        ElseIf TxbAncho.Text = 66 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 66 And CbxAncho.Text = "1/2" Or
             TxbAncho.Text = 66 And CbxAncho.Text = "9/16" Then

            AumentoDosDivicion = "1/16"

        ElseIf TxbAncho.Text = 66 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 66 And CbxAncho.Text = "11/16" Or
            TxbAncho.Text = 66 And CbxAncho.Text = "3/4" Then

            AumentoDosDivicion = "1/8"

        ElseIf TxbAncho.Text = 66 And CbxAncho.Text = "13/16" Or TxbAncho.Text = 66 And CbxAncho.Text = "7/8" Or
            TxbAncho.Text = 66 And CbxAncho.Text = "15/16" Then

            AumentoDosDivicion = "3/16"



        End If



        If TxbAncho.Text = 68 And CbxAncho.Text = "0" Or TxbAncho.Text = 68 And CbxAncho.Text = "1/16" Then

            AumentoDosDivicion = "9/16"


        ElseIf TxbAncho.Text = 68 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 68 And CbxAncho.Text = "3/16" Or
            TxbAncho.Text = 68 And CbxAncho.Text = "1/4" Then

            AumentoDosDivicion = "5/8"

        ElseIf TxbAncho.Text = 68 And CbxAncho.Text = "5/16" Or TxbAncho.Text = 68 And CbxAncho.Text = "3/8" Or
            TxbAncho.Text = 68 And CbxAncho.Text = "7/16" Then

            AumentoDosDivicion = "11/16"

        ElseIf TxbAncho.Text = 68 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 68 And CbxAncho.Text = "9/16" Or
             TxbAncho.Text = 68 And CbxAncho.Text = "5/8" Then

            AumentoDosDivicion = "3/4"

        ElseIf TxbAncho.Text = 68 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 68 And CbxAncho.Text = "9/16" Or
            TxbAncho.Text = 68 And CbxAncho.Text = "5/8" Then

            AumentoDosDivicion = "3/4"

        ElseIf TxbAncho.Text = 68 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 68 And CbxAncho.Text = "3/4" Or
            TxbAncho.Text = 68 And CbxAncho.Text = "13/16" Then

            AumentoDosDivicion = "13/16"

        ElseIf TxbAncho.Text = 68 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 68 And CbxAncho.Text = "15/16" Then

            AumentoDosDivicion = "7/8"


        End If


        If TxbAncho.Text = 69 And CbxAncho.Text = "0" Then

            AumentoDosDivicion = "7/8"


        ElseIf TxbAncho.Text = 69 And CbxAncho.Text = "1/16" Or TxbAncho.Text = 69 And CbxAncho.Text = "1/8" Or
            TxbAncho.Text = 69 And CbxAncho.Text = "3/16" Then

            AumentoDosDivicion = "15/16"

        ElseIf TxbAncho.Text = 69 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 69 And CbxAncho.Text = "5/16" Or
            TxbAncho.Text = 69 And CbxAncho.Text = "3/8" Then

            AumentoDosDivicion = ""

        ElseIf TxbAncho.Text = 69 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 69 And CbxAncho.Text = "1/2" Or
             TxbAncho.Text = 69 And CbxAncho.Text = "9/16" Then

            AumentoDosDivicion = "1/16"

        ElseIf TxbAncho.Text = 69 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 69 And CbxAncho.Text = "11/16" Or
            TxbAncho.Text = 69 And CbxAncho.Text = "3/4" Then

            AumentoDosDivicion = "1/8"

        ElseIf TxbAncho.Text = 69 And CbxAncho.Text = "13/16" Or TxbAncho.Text = 69 And CbxAncho.Text = "7/8" Or
            TxbAncho.Text = 69 And CbxAncho.Text = "15/16" Then

            AumentoDosDivicion = "3/16"



        End If


        If TxbAncho.Text = 71 And CbxAncho.Text = "0" Or TxbAncho.Text = 71 And CbxAncho.Text = "1/16" Then

            AumentoDosDivicion = "9/16"


        ElseIf TxbAncho.Text = 71 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 71 And CbxAncho.Text = "3/16" Or
            TxbAncho.Text = 71 And CbxAncho.Text = "1/4" Then

            AumentoDosDivicion = "5/8"

        ElseIf TxbAncho.Text = 71 And CbxAncho.Text = "5/16" Or TxbAncho.Text = 71 And CbxAncho.Text = "3/8" Or
            TxbAncho.Text = 71 And CbxAncho.Text = "7/16" Then

            AumentoDosDivicion = "11/16"

        ElseIf TxbAncho.Text = 71 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 71 And CbxAncho.Text = "9/16" Or
             TxbAncho.Text = 71 And CbxAncho.Text = "5/8" Then

            AumentoDosDivicion = "3/4"

        ElseIf TxbAncho.Text = 71 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 71 And CbxAncho.Text = "9/16" Or
            TxbAncho.Text = 71 And CbxAncho.Text = "5/8" Then

            AumentoDosDivicion = "3/4"

        ElseIf TxbAncho.Text = 71 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 71 And CbxAncho.Text = "3/4" Or
            TxbAncho.Text = 71 And CbxAncho.Text = "13/16" Then

            AumentoDosDivicion = "13/16"

        ElseIf TxbAncho.Text = 71 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 71 And CbxAncho.Text = "15/16" Then

            AumentoDosDivicion = "7/8"


        End If


        If TxbAncho.Text = 72 And CbxAncho.Text = "0" Then

            AumentoDosDivicion = "7/8"


        ElseIf TxbAncho.Text = 72 And CbxAncho.Text = "1/16" Or TxbAncho.Text = 69 And CbxAncho.Text = "1/8" Or
            TxbAncho.Text = 72 And CbxAncho.Text = "3/16" Then

            AumentoDosDivicion = "15/16"

        ElseIf TxbAncho.Text = 72 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 72 And CbxAncho.Text = "5/16" Or
            TxbAncho.Text = 72 And CbxAncho.Text = "3/8" Then

            AumentoDosDivicion = ""

        ElseIf TxbAncho.Text = 72 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 72 And CbxAncho.Text = "1/2" Or
             TxbAncho.Text = 72 And CbxAncho.Text = "9/16" Then

            AumentoDosDivicion = "1/16"

        ElseIf TxbAncho.Text = 72 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 72 And CbxAncho.Text = "11/16" Or
            TxbAncho.Text = 72 And CbxAncho.Text = "3/4" Then

            AumentoDosDivicion = "1/8"

        ElseIf TxbAncho.Text = 72 And CbxAncho.Text = "13/16" Or TxbAncho.Text = 72 And CbxAncho.Text = "7/8" Or
            TxbAncho.Text = 72 And CbxAncho.Text = "15/16" Then

            AumentoDosDivicion = "3/16"



        End If



        If TxbAncho.Text = 74 And CbxAncho.Text = "0" Or TxbAncho.Text = 74 And CbxAncho.Text = "1/16" Then

            AumentoDosDivicion = "9/16"


        ElseIf TxbAncho.Text = 74 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 74 And CbxAncho.Text = "3/16" Or
            TxbAncho.Text = 74 And CbxAncho.Text = "1/4" Then

            AumentoDosDivicion = "5/8"

        ElseIf TxbAncho.Text = 74 And CbxAncho.Text = "5/16" Or TxbAncho.Text = 74 And CbxAncho.Text = "3/8" Or
            TxbAncho.Text = 74 And CbxAncho.Text = "7/16" Then

            AumentoDosDivicion = "11/16"

        ElseIf TxbAncho.Text = 74 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 74 And CbxAncho.Text = "9/16" Or
             TxbAncho.Text = 74 And CbxAncho.Text = "5/8" Then

            AumentoDosDivicion = "3/4"

        ElseIf TxbAncho.Text = 74 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 74 And CbxAncho.Text = "9/16" Or
            TxbAncho.Text = 74 And CbxAncho.Text = "5/8" Then

            AumentoDosDivicion = "3/4"

        ElseIf TxbAncho.Text = 74 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 74 And CbxAncho.Text = "3/4" Or
            TxbAncho.Text = 74 And CbxAncho.Text = "13/16" Then

            AumentoDosDivicion = "13/16"

        ElseIf TxbAncho.Text = 74 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 74 And CbxAncho.Text = "15/16" Then

            AumentoDosDivicion = "7/8"


        End If


        If TxbAncho.Text = 75 And CbxAncho.Text = "0" Then

            AumentoDosDivicion = "7/8"


        ElseIf TxbAncho.Text = 75 And CbxAncho.Text = "1/16" Or TxbAncho.Text = 75 And CbxAncho.Text = "1/8" Or
            TxbAncho.Text = 75 And CbxAncho.Text = "3/16" Then

            AumentoDosDivicion = "15/16"

        ElseIf TxbAncho.Text = 75 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 75 And CbxAncho.Text = "5/16" Or
            TxbAncho.Text = 75 And CbxAncho.Text = "3/8" Then

            AumentoDosDivicion = ""

        ElseIf TxbAncho.Text = 75 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 75 And CbxAncho.Text = "1/2" Or
             TxbAncho.Text = 75 And CbxAncho.Text = "9/16" Then

            AumentoDosDivicion = "1/16"

        ElseIf TxbAncho.Text = 75 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 75 And CbxAncho.Text = "11/16" Or
            TxbAncho.Text = 75 And CbxAncho.Text = "3/4" Then

            AumentoDosDivicion = "1/8"

        ElseIf TxbAncho.Text = 75 And CbxAncho.Text = "13/16" Or TxbAncho.Text = 75 And CbxAncho.Text = "7/8" Or
            TxbAncho.Text = 75 And CbxAncho.Text = "15/16" Then

            AumentoDosDivicion = "3/16"



        End If


        If TxbAncho.Text = 77 And CbxAncho.Text = "0" Or TxbAncho.Text = 7 And CbxAncho.Text = "1/16" Then

            AumentoDosDivicion = "9/16"


        ElseIf TxbAncho.Text = 77 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 77 And CbxAncho.Text = "3/16" Or
            TxbAncho.Text = 77 And CbxAncho.Text = "1/4" Then

            AumentoDosDivicion = "5/8"

        ElseIf TxbAncho.Text = 77 And CbxAncho.Text = "5/16" Or TxbAncho.Text = 77 And CbxAncho.Text = "3/8" Or
            TxbAncho.Text = 77 And CbxAncho.Text = "7/16" Then

            AumentoDosDivicion = "11/16"

        ElseIf TxbAncho.Text = 77 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 77 And CbxAncho.Text = "9/16" Or
             TxbAncho.Text = 77 And CbxAncho.Text = "5/8" Then

            AumentoDosDivicion = "3/4"

        ElseIf TxbAncho.Text = 77 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 77 And CbxAncho.Text = "9/16" Or
            TxbAncho.Text = 77 And CbxAncho.Text = "5/8" Then

            AumentoDosDivicion = "3/4"

        ElseIf TxbAncho.Text = 77 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 77 And CbxAncho.Text = "3/4" Or
            TxbAncho.Text = 77 And CbxAncho.Text = "13/16" Then

            AumentoDosDivicion = "13/16"

        ElseIf TxbAncho.Text = 77 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 77 And CbxAncho.Text = "15/16" Then

            AumentoDosDivicion = "7/8"


        End If


        If TxbAncho.Text = 78 And CbxAncho.Text = "0" Then

            AumentoDosDivicion = "7/8"


        ElseIf TxbAncho.Text = 78 And CbxAncho.Text = "1/16" Or TxbAncho.Text = 78 And CbxAncho.Text = "1/8" Or
            TxbAncho.Text = 78 And CbxAncho.Text = "3/16" Then

            AumentoDosDivicion = "15/16"

        ElseIf TxbAncho.Text = 78 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 78 And CbxAncho.Text = "5/16" Or
            TxbAncho.Text = 78 And CbxAncho.Text = "3/8" Then

            AumentoDosDivicion = ""

        ElseIf TxbAncho.Text = 78 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 78 And CbxAncho.Text = "1/2" Or
             TxbAncho.Text = 78 And CbxAncho.Text = "9/16" Then

            AumentoDosDivicion = "1/16"

        ElseIf TxbAncho.Text = 78 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 78 And CbxAncho.Text = "11/16" Or
            TxbAncho.Text = 78 And CbxAncho.Text = "3/4" Then

            AumentoDosDivicion = "1/8"

        ElseIf TxbAncho.Text = 78 And CbxAncho.Text = "13/16" Or TxbAncho.Text = 78 And CbxAncho.Text = "7/8" Or
            TxbAncho.Text = 78 And CbxAncho.Text = "15/16" Then

            AumentoDosDivicion = "3/16"



        End If




        If TxbAncho.Text = 80 And CbxAncho.Text = "0" Or TxbAncho.Text = 80 And CbxAncho.Text = "1/16" Then

            AumentoDosDivicion = "9/16"


        ElseIf TxbAncho.Text = 80 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 80 And CbxAncho.Text = "3/16" Or
            TxbAncho.Text = 80 And CbxAncho.Text = "1/4" Then

            AumentoDosDivicion = "5/8"

        ElseIf TxbAncho.Text = 80 And CbxAncho.Text = "5/16" Or TxbAncho.Text = 80 And CbxAncho.Text = "3/8" Or
            TxbAncho.Text = 80 And CbxAncho.Text = "7/16" Then

            AumentoDosDivicion = "11/16"

        ElseIf TxbAncho.Text = 80 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 80 And CbxAncho.Text = "9/16" Or
             TxbAncho.Text = 80 And CbxAncho.Text = "5/8" Then

            AumentoDosDivicion = "3/4"

        ElseIf TxbAncho.Text = 80 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 80 And CbxAncho.Text = "9/16" Or
            TxbAncho.Text = 80 And CbxAncho.Text = "5/8" Then

            AumentoDosDivicion = "3/4"

        ElseIf TxbAncho.Text = 80 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 80 And CbxAncho.Text = "3/4" Or
            TxbAncho.Text = 80 And CbxAncho.Text = "13/16" Then

            AumentoDosDivicion = "13/16"

        ElseIf TxbAncho.Text = 80 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 80 And CbxAncho.Text = "15/16" Then

            AumentoDosDivicion = "7/8"


        End If


        If TxbAncho.Text = 81 And CbxAncho.Text = "0" Then

            AumentoDosDivicion = "7/8"


        ElseIf TxbAncho.Text = 81 And CbxAncho.Text = "1/16" Or TxbAncho.Text = 81 And CbxAncho.Text = "1/8" Or
            TxbAncho.Text = 81 And CbxAncho.Text = "3/16" Then

            AumentoDosDivicion = "15/16"

        ElseIf TxbAncho.Text = 81 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 81 And CbxAncho.Text = "5/16" Or
            TxbAncho.Text = 81 And CbxAncho.Text = "3/8" Then

            AumentoDosDivicion = ""

        ElseIf TxbAncho.Text = 81 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 81 And CbxAncho.Text = "1/2" Or
             TxbAncho.Text = 81 And CbxAncho.Text = "9/16" Then

            AumentoDosDivicion = "1/16"

        ElseIf TxbAncho.Text = 81 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 81 And CbxAncho.Text = "11/16" Or
            TxbAncho.Text = 81 And CbxAncho.Text = "3/4" Then

            AumentoDosDivicion = "1/8"

        ElseIf TxbAncho.Text = 81 And CbxAncho.Text = "13/16" Or TxbAncho.Text = 81 And CbxAncho.Text = "7/8" Or
            TxbAncho.Text = 81 And CbxAncho.Text = "15/16" Then

            AumentoDosDivicion = "3/16"



        End If



        If TxbAncho.Text = 83 And CbxAncho.Text = "0" Or TxbAncho.Text = 83 And CbxAncho.Text = "1/16" Then

            AumentoDosDivicion = "9/16"


        ElseIf TxbAncho.Text = 83 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 83 And CbxAncho.Text = "3/16" Or
            TxbAncho.Text = 83 And CbxAncho.Text = "1/4" Then

            AumentoDosDivicion = "5/8"

        ElseIf TxbAncho.Text = 83 And CbxAncho.Text = "5/16" Or TxbAncho.Text = 83 And CbxAncho.Text = "3/8" Or
            TxbAncho.Text = 83 And CbxAncho.Text = "7/16" Then

            AumentoDosDivicion = "11/16"

        ElseIf TxbAncho.Text = 83 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 83 And CbxAncho.Text = "9/16" Or
             TxbAncho.Text = 83 And CbxAncho.Text = "5/8" Then

            AumentoDosDivicion = "3/4"

        ElseIf TxbAncho.Text = 83 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 83 And CbxAncho.Text = "9/16" Or
            TxbAncho.Text = 83 And CbxAncho.Text = "5/8" Then

            AumentoDosDivicion = "3/4"

        ElseIf TxbAncho.Text = 83 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 83 And CbxAncho.Text = "3/4" Or
            TxbAncho.Text = 83 And CbxAncho.Text = "13/16" Then

            AumentoDosDivicion = "13/16"

        ElseIf TxbAncho.Text = 83 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 83 And CbxAncho.Text = "15/16" Then

            AumentoDosDivicion = "7/8"


        End If


        If TxbAncho.Text = 84 And CbxAncho.Text = "0" Then

            AumentoDosDivicion = "7/8"


        ElseIf TxbAncho.Text = 84 And CbxAncho.Text = "1/16" Or TxbAncho.Text = 84 And CbxAncho.Text = "1/8" Or
            TxbAncho.Text = 84 And CbxAncho.Text = "3/16" Then

            AumentoDosDivicion = "15/16"

        ElseIf TxbAncho.Text = 84 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 84 And CbxAncho.Text = "5/16" Or
            TxbAncho.Text = 84 And CbxAncho.Text = "3/8" Then

            AumentoDosDivicion = ""

        ElseIf TxbAncho.Text = 84 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 84 And CbxAncho.Text = "1/2" Or
             TxbAncho.Text = 84 And CbxAncho.Text = "9/16" Then

            AumentoDosDivicion = "1/16"

        ElseIf TxbAncho.Text = 84 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 84 And CbxAncho.Text = "11/16" Or
            TxbAncho.Text = 84 And CbxAncho.Text = "3/4" Then

            AumentoDosDivicion = "1/8"

        ElseIf TxbAncho.Text = 84 And CbxAncho.Text = "13/16" Or TxbAncho.Text = 84 And CbxAncho.Text = "7/8" Or
            TxbAncho.Text = 84 And CbxAncho.Text = "15/16" Then

            AumentoDosDivicion = "3/16"



        End If


        If TxbAncho.Text = 86 And CbxAncho.Text = "0" Or TxbAncho.Text = 86 And CbxAncho.Text = "1/16" Then

            AumentoDosDivicion = "9/16"


        ElseIf TxbAncho.Text = 86 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 86 And CbxAncho.Text = "3/16" Or
            TxbAncho.Text = 86 And CbxAncho.Text = "1/4" Then

            AumentoDosDivicion = "5/8"

        ElseIf TxbAncho.Text = 86 And CbxAncho.Text = "5/16" Or TxbAncho.Text = 86 And CbxAncho.Text = "3/8" Or
            TxbAncho.Text = 86 And CbxAncho.Text = "7/16" Then

            AumentoDosDivicion = "11/16"

        ElseIf TxbAncho.Text = 86 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 86 And CbxAncho.Text = "9/16" Or
             TxbAncho.Text = 86 And CbxAncho.Text = "5/8" Then

            AumentoDosDivicion = "3/4"

        ElseIf TxbAncho.Text = 86 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 86 And CbxAncho.Text = "9/16" Or
            TxbAncho.Text = 86 And CbxAncho.Text = "5/8" Then

            AumentoDosDivicion = "3/4"

        ElseIf TxbAncho.Text = 86 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 86 And CbxAncho.Text = "3/4" Or
            TxbAncho.Text = 86 And CbxAncho.Text = "13/16" Then

            AumentoDosDivicion = "13/16"

        ElseIf TxbAncho.Text = 86 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 86 And CbxAncho.Text = "15/16" Then

            AumentoDosDivicion = "7/8"


        End If


        If TxbAncho.Text = 87 And CbxAncho.Text = "0" Then

            AumentoDosDivicion = "7/8"


        ElseIf TxbAncho.Text = 87 And CbxAncho.Text = "1/16" Or TxbAncho.Text = 87 And CbxAncho.Text = "1/8" Or
            TxbAncho.Text = 87 And CbxAncho.Text = "3/16" Then

            AumentoDosDivicion = "15/16"

        ElseIf TxbAncho.Text = 87 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 87 And CbxAncho.Text = "5/16" Or
            TxbAncho.Text = 87 And CbxAncho.Text = "3/8" Then

            AumentoDosDivicion = ""

        ElseIf TxbAncho.Text = 87 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 87 And CbxAncho.Text = "1/2" Or
             TxbAncho.Text = 87 And CbxAncho.Text = "9/16" Then

            AumentoDosDivicion = "1/16"

        ElseIf TxbAncho.Text = 87 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 87 And CbxAncho.Text = "11/16" Or
            TxbAncho.Text = 87 And CbxAncho.Text = "3/4" Then

            AumentoDosDivicion = "1/8"

        ElseIf TxbAncho.Text = 87 And CbxAncho.Text = "13/16" Or TxbAncho.Text = 87 And CbxAncho.Text = "7/8" Or
            TxbAncho.Text = 87 And CbxAncho.Text = "15/16" Then

            AumentoDosDivicion = "3/16"



        End If


        If TxbAncho.Text = 89 And CbxAncho.Text = "0" Or TxbAncho.Text = 89 And CbxAncho.Text = "1/16" Then

            AumentoDosDivicion = "9/16"


        ElseIf TxbAncho.Text = 89 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 89 And CbxAncho.Text = "3/16" Or
            TxbAncho.Text = 89 And CbxAncho.Text = "1/4" Then

            AumentoDosDivicion = "5/8"

        ElseIf TxbAncho.Text = 89 And CbxAncho.Text = "5/16" Or TxbAncho.Text = 89 And CbxAncho.Text = "3/8" Or
            TxbAncho.Text = 89 And CbxAncho.Text = "7/16" Then

            AumentoDosDivicion = "11/16"

        ElseIf TxbAncho.Text = 89 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 89 And CbxAncho.Text = "9/16" Or
             TxbAncho.Text = 89 And CbxAncho.Text = "5/8" Then

            AumentoDosDivicion = "3/4"

        ElseIf TxbAncho.Text = 89 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 89 And CbxAncho.Text = "9/16" Or
            TxbAncho.Text = 89 And CbxAncho.Text = "5/8" Then

            AumentoDosDivicion = "3/4"

        ElseIf TxbAncho.Text = 89 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 89 And CbxAncho.Text = "3/4" Or
            TxbAncho.Text = 89 And CbxAncho.Text = "13/16" Then

            AumentoDosDivicion = "13/16"

        ElseIf TxbAncho.Text = 89 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 89 And CbxAncho.Text = "15/16" Then

            AumentoDosDivicion = "7/8"


        End If


        If TxbAncho.Text = 90 And CbxAncho.Text = "0" Then

            AumentoDosDivicion = "7/8"


        ElseIf TxbAncho.Text = 90 And CbxAncho.Text = "1/16" Or TxbAncho.Text = 90 And CbxAncho.Text = "1/8" Or
            TxbAncho.Text = 90 And CbxAncho.Text = "3/16" Then

            AumentoDosDivicion = "15/16"

        ElseIf TxbAncho.Text = 90 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 90 And CbxAncho.Text = "5/16" Or
            TxbAncho.Text = 90 And CbxAncho.Text = "3/8" Then

            AumentoDosDivicion = ""

        ElseIf TxbAncho.Text = 90 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 90 And CbxAncho.Text = "1/2" Or
             TxbAncho.Text = 90 And CbxAncho.Text = "9/16" Then

            AumentoDosDivicion = "1/16"

        ElseIf TxbAncho.Text = 90 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 90 And CbxAncho.Text = "11/16" Or
            TxbAncho.Text = 90 And CbxAncho.Text = "3/4" Then

            AumentoDosDivicion = "1/8"

        ElseIf TxbAncho.Text = 90 And CbxAncho.Text = "13/16" Or TxbAncho.Text = 90 And CbxAncho.Text = "7/8" Or
            TxbAncho.Text = 90 And CbxAncho.Text = "15/16" Then

            AumentoDosDivicion = "3/16"



        End If



        If TxbAncho.Text = 92 And CbxAncho.Text = "0" Or TxbAncho.Text = 92 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 92 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 92 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "15/16"

        ElseIf TxbAncho.Text = 92 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 92 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 92 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 92 And CbxAncho.Text = "7/16" Then

            AumentoTresDivicion = ""

        ElseIf TxbAncho.Text = 92 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 92 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 92 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 92 And CbxAncho.Text = "11/16" Then

            AumentoTresDivicion = "1/16"

        ElseIf TxbAncho.Text = 92 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 92 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 92 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 92 And CbxAncho.Text = "15/16" Then

            AumentoTresDivicion = "1/8"

        End If


        If TxbAncho.Text = 93 And CbxAncho.Text = "0" Or TxbAncho.Text = 93 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 93 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 93 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "3/16"

        ElseIf TxbAncho.Text = 93 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 93 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 93 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 93 And CbxAncho.Text = "7/16" Then

            AumentoTresDivicion = "1/4"

        ElseIf TxbAncho.Text = 93 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 93 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 93 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 93 And CbxAncho.Text = "11/16" Then

            AumentoTresDivicion = "5/16"

        ElseIf TxbAncho.Text = 93 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 93 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 93 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 93 And CbxAncho.Text = "15/16" Then

            AumentoTresDivicion = "3/8"




        End If


        If TxbAncho.Text = 94 And CbxAncho.Text = "0" Or TxbAncho.Text = 94 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 94 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 94 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "7/16"

        ElseIf TxbAncho.Text = 94 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 94 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 94 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 94 And CbxAncho.Text = "7/16" Then

            AumentoTresDivicion = "1/2"

        ElseIf TxbAncho.Text = 94 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 94 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 94 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 94 And CbxAncho.Text = "11/16" Then

            AumentoTresDivicion = "9/16"

        ElseIf TxbAncho.Text = 94 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 94 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 94 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 94 And CbxAncho.Text = "15/16" Then

            AumentoTresDivicion = "5/8"


        End If


        If TxbAncho.Text = 96 And CbxAncho.Text = "0" Or TxbAncho.Text = 96 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 96 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 96 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "15/16"

        ElseIf TxbAncho.Text = 96 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 96 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 96 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 96 And CbxAncho.Text = "7/16" Then

            AumentoTresDivicion = ""

        ElseIf TxbAncho.Text = 96 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 96 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 96 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 96 And CbxAncho.Text = "11/16" Then

            AumentoTresDivicion = "1/16"

        ElseIf TxbAncho.Text = 96 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 96 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 96 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 96 And CbxAncho.Text = "15/16" Then

            AumentoTresDivicion = "1/8"

        End If


        If TxbAncho.Text = 97 And CbxAncho.Text = "0" Or TxbAncho.Text = 97 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 97 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 97 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "3/16"

        ElseIf TxbAncho.Text = 97 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 97 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 97 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 97 And CbxAncho.Text = "7/16" Then

            AumentoTresDivicion = "1/4"

        ElseIf TxbAncho.Text = 97 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 97 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 97 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 97 And CbxAncho.Text = "11/16" Then

            AumentoTresDivicion = "5/16"

        ElseIf TxbAncho.Text = 97 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 97 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 97 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 97 And CbxAncho.Text = "15/16" Then

            AumentoTresDivicion = "3/8"


        End If


        If TxbAncho.Text = 98 And CbxAncho.Text = "0" Or TxbAncho.Text = 98 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 98 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 98 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "7/16"

        ElseIf TxbAncho.Text = 98 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 98 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 98 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 98 And CbxAncho.Text = "7/16" Then

            AumentoTresDivicion = "1/2"

        ElseIf TxbAncho.Text = 98 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 98 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 98 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 98 And CbxAncho.Text = "11/16" Then

            AumentoTresDivicion = "9/16"

        ElseIf TxbAncho.Text = 98 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 98 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 98 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 98 And CbxAncho.Text = "15/16" Then

            AumentoTresDivicion = "5/8"


        End If


        If TxbAncho.Text = 100 And CbxAncho.Text = "0" Or TxbAncho.Text = 100 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 100 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 100 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "15/16"

        ElseIf TxbAncho.Text = 100 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 100 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 100 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 100 And CbxAncho.Text = "7/16" Then

            AumentoTresDivicion = ""

        ElseIf TxbAncho.Text = 100 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 100 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 100 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 100 And CbxAncho.Text = "11/16" Then

            AumentoTresDivicion = "1/16"

        ElseIf TxbAncho.Text = 100 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 100 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 100 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 100 And CbxAncho.Text = "15/16" Then

            AumentoTresDivicion = "1/8"

        End If


        If TxbAncho.Text = 101 And CbxAncho.Text = "0" Or TxbAncho.Text = 101 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 101 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 101 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "3/16"

        ElseIf TxbAncho.Text = 101 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 101 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 101 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 101 And CbxAncho.Text = "7/16" Then

            AumentoTresDivicion = "1/4"

        ElseIf TxbAncho.Text = 101 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 101 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 101 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 101 And CbxAncho.Text = "11/16" Then

            AumentoTresDivicion = "5/16"

        ElseIf TxbAncho.Text = 101 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 101 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 101 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 101 And CbxAncho.Text = "15/16" Then

            AumentoTresDivicion = "3/8"


        End If


        If TxbAncho.Text = 102 And CbxAncho.Text = "0" Or TxbAncho.Text = 102 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 102 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 102 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "7/16"

        ElseIf TxbAncho.Text = 102 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 102 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 102 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 102 And CbxAncho.Text = "7/16" Then

            AumentoTresDivicion = "1/2"

        ElseIf TxbAncho.Text = 102 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 102 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 102 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 102 And CbxAncho.Text = "11/16" Then

            AumentoTresDivicion = "9/16"

        ElseIf TxbAncho.Text = 102 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 102 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 102 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 102 And CbxAncho.Text = "15/16" Then

            AumentoTresDivicion = "5/8"


        End If


        If TxbAncho.Text = 104 And CbxAncho.Text = "0" Or TxbAncho.Text = 104 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 104 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 104 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "15/16"

        ElseIf TxbAncho.Text = 104 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 104 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 104 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 104 And CbxAncho.Text = "7/16" Then

            AumentoTresDivicion = ""

        ElseIf TxbAncho.Text = 104 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 104 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 104 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 104 And CbxAncho.Text = "11/16" Then

            AumentoTresDivicion = "1/16"

        ElseIf TxbAncho.Text = 104 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 104 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 104 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 104 And CbxAncho.Text = "15/16" Then

            AumentoTresDivicion = "1/8"

        End If


        If TxbAncho.Text = 105 And CbxAncho.Text = "0" Or TxbAncho.Text = 105 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 105 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 105 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "3/16"

        ElseIf TxbAncho.Text = 105 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 105 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 105 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 105 And CbxAncho.Text = "7/16" Then

            AumentoTresDivicion = "1/4"

        ElseIf TxbAncho.Text = 105 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 105 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 105 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 105 And CbxAncho.Text = "11/16" Then

            AumentoTresDivicion = "5/16"

        ElseIf TxbAncho.Text = 105 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 105 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 105 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 105 And CbxAncho.Text = "15/16" Then

            AumentoTresDivicion = "3/8"


        End If


        If TxbAncho.Text = 106 And CbxAncho.Text = "0" Or TxbAncho.Text = 106 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 106 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 106 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "7/16"

        ElseIf TxbAncho.Text = 106 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 106 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 106 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 106 And CbxAncho.Text = "7/16" Then

            AumentoTresDivicion = "1/2"

        ElseIf TxbAncho.Text = 106 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 106 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 106 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 106 And CbxAncho.Text = "11/16" Then

            AumentoTresDivicion = "9/16"

        ElseIf TxbAncho.Text = 106 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 106 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 106 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 106 And CbxAncho.Text = "15/16" Then

            AumentoTresDivicion = "5/8"


        End If


        If TxbAncho.Text = 108 And CbxAncho.Text = "0" Or TxbAncho.Text = 108 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 108 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 108 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "15/16"

        ElseIf TxbAncho.Text = 108 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 108 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 108 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 108 And CbxAncho.Text = "7/16" Then

            AumentoTresDivicion = ""

        ElseIf TxbAncho.Text = 108 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 108 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 108 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 108 And CbxAncho.Text = "11/16" Then

            AumentoTresDivicion = "1/16"

        ElseIf TxbAncho.Text = 108 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 108 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 108 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 108 And CbxAncho.Text = "15/16" Then

            AumentoTresDivicion = "1/8"

        End If


        If TxbAncho.Text = 109 And CbxAncho.Text = "0" Or TxbAncho.Text = 109 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 109 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 109 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "3/16"

        ElseIf TxbAncho.Text = 109 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 109 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 109 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 109 And CbxAncho.Text = "7/16" Then

            AumentoTresDivicion = "1/4"

        ElseIf TxbAncho.Text = 109 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 109 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 109 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 109 And CbxAncho.Text = "11/16" Then

            AumentoTresDivicion = "5/16"

        ElseIf TxbAncho.Text = 109 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 109 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 109 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 109 And CbxAncho.Text = "15/16" Then

            AumentoTresDivicion = "3/8"


        End If


        If TxbAncho.Text = 110 And CbxAncho.Text = "0" Or TxbAncho.Text = 110 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 110 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 110 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "7/16"

        ElseIf TxbAncho.Text = 110 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 110 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 110 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 110 And CbxAncho.Text = "7/16" Then

            AumentoTresDivicion = "1/2"

        ElseIf TxbAncho.Text = 110 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 110 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 110 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 110 And CbxAncho.Text = "11/16" Then

            AumentoTresDivicion = "9/16"

        ElseIf TxbAncho.Text = 110 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 110 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 110 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 110 And CbxAncho.Text = "15/16" Then

            AumentoTresDivicion = "5/8"


        End If


        If TxbAncho.Text = 112 And CbxAncho.Text = "0" Or TxbAncho.Text = 112 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 112 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 112 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "15/16"

        ElseIf TxbAncho.Text = 112 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 112 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 112 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 112 And CbxAncho.Text = "7/16" Then

            AumentoTresDivicion = ""

        ElseIf TxbAncho.Text = 112 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 112 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 112 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 112 And CbxAncho.Text = "11/16" Then

            AumentoTresDivicion = "1/16"

        ElseIf TxbAncho.Text = 112 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 112 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 112 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 112 And CbxAncho.Text = "15/16" Then

            AumentoTresDivicion = "1/8"

        End If


        If TxbAncho.Text = 113 And CbxAncho.Text = "0" Or TxbAncho.Text = 113 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 113 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 113 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "3/16"

        ElseIf TxbAncho.Text = 113 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 113 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 113 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 113 And CbxAncho.Text = "7/16" Then

            AumentoTresDivicion = "1/4"

        ElseIf TxbAncho.Text = 113 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 113 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 113 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 113 And CbxAncho.Text = "11/16" Then

            AumentoTresDivicion = "5/16"

        ElseIf TxbAncho.Text = 113 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 113 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 113 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 113 And CbxAncho.Text = "15/16" Then

            AumentoTresDivicion = "3/8"


        End If


        If TxbAncho.Text = 114 And CbxAncho.Text = "0" Or TxbAncho.Text = 114 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 114 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 114 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "7/16"

        ElseIf TxbAncho.Text = 114 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 114 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 114 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 114 And CbxAncho.Text = "7/16" Then

            AumentoTresDivicion = "1/2"

        ElseIf TxbAncho.Text = 114 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 114 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 114 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 114 And CbxAncho.Text = "11/16" Then

            AumentoTresDivicion = "9/16"

        ElseIf TxbAncho.Text = 114 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 114 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 114 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 114 And CbxAncho.Text = "15/16" Then

            AumentoTresDivicion = "5/8"


        End If


        If TxbAncho.Text = 116 And CbxAncho.Text = "0" Or TxbAncho.Text = 116 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 116 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 116 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "15/16"

        ElseIf TxbAncho.Text = 116 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 116 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 116 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 116 And CbxAncho.Text = "7/16" Then

            AumentoTresDivicion = ""

        ElseIf TxbAncho.Text = 116 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 116 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 116 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 116 And CbxAncho.Text = "11/16" Then

            AumentoTresDivicion = "1/16"

        ElseIf TxbAncho.Text = 116 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 116 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 116 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 116 And CbxAncho.Text = "15/16" Then

            AumentoTresDivicion = "1/8"

        End If


        If TxbAncho.Text = 117 And CbxAncho.Text = "0" Or TxbAncho.Text = 117 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 117 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 117 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "3/16"

        ElseIf TxbAncho.Text = 117 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 117 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 117 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 117 And CbxAncho.Text = "7/16" Then

            AumentoTresDivicion = "1/4"

        ElseIf TxbAncho.Text = 117 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 117 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 117 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 117 And CbxAncho.Text = "11/16" Then

            AumentoTresDivicion = "5/16"

        ElseIf TxbAncho.Text = 117 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 117 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 117 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 117 And CbxAncho.Text = "15/16" Then

            AumentoTresDivicion = "3/8"


        End If


        If TxbAncho.Text = 118 And CbxAncho.Text = "0" Or TxbAncho.Text = 118 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 118 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 118 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "7/16"

        ElseIf TxbAncho.Text = 118 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 118 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 118 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 118 And CbxAncho.Text = "7/16" Then

            AumentoTresDivicion = "1/2"

        ElseIf TxbAncho.Text = 118 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 118 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 118 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 118 And CbxAncho.Text = "11/16" Then

            AumentoTresDivicion = "9/16"

        ElseIf TxbAncho.Text = 118 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 118 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 118 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 11811 And CbxAncho.Text = "15/16" Then

            AumentoTresDivicion = "5/8"


        End If


        If TxbAncho.Text = 120 And CbxAncho.Text = "0" Or TxbAncho.Text = 120 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 120 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 120 And CbxAncho.Text = "3/16" Then

            AumentoTresDivicion = "15/16"

        ElseIf TxbAncho.Text = 120 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 120 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 120 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 120 And CbxAncho.Text = "7/16" Or
            TxbAncho.Text = 120 And CbxAncho.Text = "1/2" Then



            AumentoTresDivicion = ""

        ElseIf TxbAncho.Text = 120 And CbxAncho.Text = "9/16" Or TxbAncho.Text = 120 And CbxAncho.Text = "5/8" Or
               TxbAncho.Text = 120 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 120 And CbxAncho.Text = "3/4" Or
               TxbAncho.Text = 120 And CbxAncho.Text = "13/16" Then

            AumentoTresDivicion = "1/16"

        ElseIf TxbAncho.Text = 120 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 120 And CbxAncho.Text = "15/16" Then


            AumentoTresDivicion = "1/8"

        End If


        '=====================================================================================================================
        If TxbAncho.Text = 122 And CbxAncho.Text = "0" Or TxbAncho.Text = 122 And CbxAncho.Text = "1/16" Then

            AumentoCuatroDivicion = "15/16"

        ElseIf TxbAncho.Text = 122 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 122 And CbxAncho.Text = "3/16" Or
               TxbAncho.Text = 122 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 122 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 122 And CbxAncho.Text = "3/8" Then

            AumentoCuatroDivicion = "3/8"

        ElseIf TxbAncho.Text = 122 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 122 And CbxAncho.Text = "1/2" Or
               TxbAncho.Text = 122 And CbxAncho.Text = "9/16" Or TxbAncho.Text = 122 And CbxAncho.Text = "5/8" Or
               TxbAncho.Text = 122 And CbxAncho.Text = "11/16" Then

            AumentoCuatroDivicion = "7/16"

        ElseIf TxbAncho.Text = 122 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 122 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 122 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 122 And CbxAncho.Text = "15/16" Then

            AumentoCuatroDivicion = "1/2"

        End If

        If TxbAncho.Text = 123 And CbxAncho.Text = "0" Then

            AumentoCuatroDivicion = "1/2"

        ElseIf TxbAncho.Text = 123 And CbxAncho.Text = "1/16" Or TxbAncho.Text = 123 And CbxAncho.Text = "1/8" Or
               TxbAncho.Text = 123 And CbxAncho.Text = "3/16" Or TxbAncho.Text = 123 And CbxAncho.Text = "1/4" Or
               TxbAncho.Text = 123 And CbxAncho.Text = "5/16" Then

            AumentoCuatroDivicion = "9/16"

        ElseIf TxbAncho.Text = 123 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 123 And CbxAncho.Text = "7/16" Or
               TxbAncho.Text = 123 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 123 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 123 And CbxAncho.Text = "5/8" Then

            AumentoCuatroDivicion = "5/8"

        End If

        If TxbAncho.Text = 124 And CbxAncho.Text = "0" Or TxbAncho.Text = 124 And CbxAncho.Text = "1/16" Or
               TxbAncho.Text = 124 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 124 And CbxAncho.Text = "3/16" Or
               TxbAncho.Text = 124 And CbxAncho.Text = "1/4" Then

            AumentoCuatroDivicion = "3/4"


        ElseIf TxbAncho.Text = 124 And CbxAncho.Text = "5/16" Or TxbAncho.Text = 124 And CbxAncho.Text = "3/8" Or
               TxbAncho.Text = 124 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 124 And CbxAncho.Text = "1/2" Or
               TxbAncho.Text = 124 And CbxAncho.Text = "9/16" Then

            AumentoCuatroDivicion = "13/16"


        ElseIf TxbAncho.Text = 124 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 124 And CbxAncho.Text = "3/4" Or
               TxbAncho.Text = 124 And CbxAncho.Text = "13/16" Or TxbAncho.Text = 124 And CbxAncho.Text = "7/8" Or
               TxbAncho.Text = 124 And CbxAncho.Text = "5/8" Then

            AumentoCuatroDivicion = "13/16"


        ElseIf TxbAncho.Text = 124 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 124 And CbxAncho.Text = "11/16" Or
               TxbAncho.Text = 124 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 124 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 124 And CbxAncho.Text = "7/8" Then

            AumentoCuatroDivicion = "7/8"


        ElseIf TxbAncho.Text = 124 And CbxAncho.Text = "15/16" Then

            AumentoCuatroDivicion = "15/16"


        End If

        If TxbAncho.Text = 125 And CbxAncho.Text = "0" Or TxbAncho.Text = 125 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 125 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 125 And CbxAncho.Text = "3/16" Then

            AumentoCuatroDivicion = "15/16"

        ElseIf TxbAncho.Text = 125 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 125 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 125 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 125 And CbxAncho.Text = "7/16" Or
               TxbAncho.Text = 125 And CbxAncho.Text = "1/2" Then

            AumentoCuatroDivicion = ""

        ElseIf TxbAncho.Text = 125 And CbxAncho.Text = "9/16" Or TxbAncho.Text = 125 And CbxAncho.Text = "5/8" Or
               TxbAncho.Text = 125 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 125 And CbxAncho.Text = "3/4" Or
               TxbAncho.Text = 125 And CbxAncho.Text = "13/16" Then

            AumentoCuatroDivicion = "1/16"

        ElseIf TxbAncho.Text = 125 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 125 And CbxAncho.Text = "15/16" Then


            AumentoCuatroDivicion = "1/8"

        End If

        If TxbAncho.Text = 127 And CbxAncho.Text = "0" Or TxbAncho.Text = 127 And CbxAncho.Text = "1/16" Then

            AumentoCuatroDivicion = "15/16"

        ElseIf TxbAncho.Text = 127 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 127 And CbxAncho.Text = "3/16" Or
               TxbAncho.Text = 127 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 127 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 127 And CbxAncho.Text = "3/8" Then

            AumentoCuatroDivicion = "3/8"

        ElseIf TxbAncho.Text = 127 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 127 And CbxAncho.Text = "1/2" Or
               TxbAncho.Text = 127 And CbxAncho.Text = "9/16" Or TxbAncho.Text = 127 And CbxAncho.Text = "5/8" Or
               TxbAncho.Text = 127 And CbxAncho.Text = "11/16" Then

            AumentoCuatroDivicion = "7/16"

        ElseIf TxbAncho.Text = 127 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 127 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 127 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 127 And CbxAncho.Text = "15/16" Then

            AumentoCuatroDivicion = "1/2"

        End If

        If TxbAncho.Text = 128 And CbxAncho.Text = "0" Then

            AumentoCuatroDivicion = "1/2"

        ElseIf TxbAncho.Text = 128 And CbxAncho.Text = "1/16" Or TxbAncho.Text = 128 And CbxAncho.Text = "1/8" Or
               TxbAncho.Text = 128 And CbxAncho.Text = "3/16" Or TxbAncho.Text = 128 And CbxAncho.Text = "1/4" Or
               TxbAncho.Text = 128 And CbxAncho.Text = "5/16" Then

            AumentoCuatroDivicion = "9/16"

        ElseIf TxbAncho.Text = 128 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 128 And CbxAncho.Text = "7/16" Or
               TxbAncho.Text = 128 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 128 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 128 And CbxAncho.Text = "5/8" Then

            AumentoCuatroDivicion = "5/8"

        End If

        If TxbAncho.Text = 129 And CbxAncho.Text = "0" Or TxbAncho.Text = 129 And CbxAncho.Text = "1/16" Or
               TxbAncho.Text = 129 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 129 And CbxAncho.Text = "3/16" Or
               TxbAncho.Text = 129 And CbxAncho.Text = "1/4" Then

            AumentoCuatroDivicion = "3/4"


        ElseIf TxbAncho.Text = 129 And CbxAncho.Text = "5/16" Or TxbAncho.Text = 129 And CbxAncho.Text = "3/8" Or
               TxbAncho.Text = 129 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 129 And CbxAncho.Text = "1/2" Or
               TxbAncho.Text = 129 And CbxAncho.Text = "9/16" Then

            AumentoCuatroDivicion = "13/16"


        ElseIf TxbAncho.Text = 129 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 129 And CbxAncho.Text = "3/4" Or
               TxbAncho.Text = 129 And CbxAncho.Text = "13/16" Or TxbAncho.Text = 129 And CbxAncho.Text = "7/8" Or
               TxbAncho.Text = 129 And CbxAncho.Text = "5/8" Then

            AumentoCuatroDivicion = "13/16"


        ElseIf TxbAncho.Text = 129 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 129 And CbxAncho.Text = "11/16" Or
               TxbAncho.Text = 129 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 129 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 129 And CbxAncho.Text = "7/8" Then

            AumentoCuatroDivicion = "7/8"


        ElseIf TxbAncho.Text = 129 And CbxAncho.Text = "15/16" Then

            AumentoCuatroDivicion = "15/16"


        End If

        If TxbAncho.Text = 130 And CbxAncho.Text = "0" Or TxbAncho.Text = 130 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 130 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 130 And CbxAncho.Text = "3/16" Then

            AumentoCuatroDivicion = "15/16"

        ElseIf TxbAncho.Text = 130 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 130 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 130 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 130 And CbxAncho.Text = "7/16" Or
               TxbAncho.Text = 130 And CbxAncho.Text = "1/2" Then

            AumentoCuatroDivicion = ""

        ElseIf TxbAncho.Text = 130 And CbxAncho.Text = "9/16" Or TxbAncho.Text = 130 And CbxAncho.Text = "5/8" Or
               TxbAncho.Text = 130 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 130 And CbxAncho.Text = "3/4" Or
               TxbAncho.Text = 130 And CbxAncho.Text = "13/16" Then

            AumentoCuatroDivicion = "1/16"

        ElseIf TxbAncho.Text = 130 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 130 And CbxAncho.Text = "15/16" Then


            AumentoCuatroDivicion = "1/8"

        End If

        If TxbAncho.Text = 132 And CbxAncho.Text = "0" Or TxbAncho.Text = 132 And CbxAncho.Text = "1/16" Then

            AumentoCuatroDivicion = "15/16"

        ElseIf TxbAncho.Text = 132 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 132 And CbxAncho.Text = "3/16" Or
               TxbAncho.Text = 132 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 132 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 132 And CbxAncho.Text = "3/8" Then

            AumentoCuatroDivicion = "3/8"

        ElseIf TxbAncho.Text = 132 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 132 And CbxAncho.Text = "1/2" Or
               TxbAncho.Text = 132 And CbxAncho.Text = "9/16" Or TxbAncho.Text = 132 And CbxAncho.Text = "5/8" Or
               TxbAncho.Text = 132 And CbxAncho.Text = "11/16" Then

            AumentoCuatroDivicion = "7/16"

        ElseIf TxbAncho.Text = 132 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 132 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 132 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 132 And CbxAncho.Text = "15/16" Then

            AumentoCuatroDivicion = "1/2"

        End If

        If TxbAncho.Text = 133 And CbxAncho.Text = "0" Then

            AumentoCuatroDivicion = "1/2"

        ElseIf TxbAncho.Text = 133 And CbxAncho.Text = "1/16" Or TxbAncho.Text = 133 And CbxAncho.Text = "1/8" Or
               TxbAncho.Text = 133 And CbxAncho.Text = "3/16" Or TxbAncho.Text = 133 And CbxAncho.Text = "1/4" Or
               TxbAncho.Text = 133 And CbxAncho.Text = "5/16" Then

            AumentoCuatroDivicion = "9/16"

        ElseIf TxbAncho.Text = 133 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 133 And CbxAncho.Text = "7/16" Or
               TxbAncho.Text = 133 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 133 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 133 And CbxAncho.Text = "5/8" Then

            AumentoCuatroDivicion = "5/8"

        End If



        If TxbAncho.Text = 134 And CbxAncho.Text = "0" Or TxbAncho.Text = 134 And CbxAncho.Text = "1/16" Or
               TxbAncho.Text = 134 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 134 And CbxAncho.Text = "3/16" Or
               TxbAncho.Text = 134 And CbxAncho.Text = "1/4" Then

            AumentoCuatroDivicion = "3/4"


        ElseIf TxbAncho.Text = 134 And CbxAncho.Text = "5/16" Or TxbAncho.Text = 134 And CbxAncho.Text = "3/8" Or
               TxbAncho.Text = 134 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 134 And CbxAncho.Text = "1/2" Or
               TxbAncho.Text = 134 And CbxAncho.Text = "9/16" Then

            AumentoCuatroDivicion = "13/16"


        ElseIf TxbAncho.Text = 134 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 134 And CbxAncho.Text = "3/4" Or
               TxbAncho.Text = 134 And CbxAncho.Text = "13/16" Or TxbAncho.Text = 134 And CbxAncho.Text = "7/8" Or
               TxbAncho.Text = 134 And CbxAncho.Text = "5/8" Then

            AumentoCuatroDivicion = "13/16"


        ElseIf TxbAncho.Text = 134 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 134 And CbxAncho.Text = "11/16" Or
               TxbAncho.Text = 134 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 134 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 134 And CbxAncho.Text = "7/8" Then

            AumentoCuatroDivicion = "7/8"


        ElseIf TxbAncho.Text = 134 And CbxAncho.Text = "15/16" Then

            AumentoCuatroDivicion = "15/16"


        End If

        If TxbAncho.Text = 135 And CbxAncho.Text = "0" Or TxbAncho.Text = 135 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 135 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 135 And CbxAncho.Text = "3/16" Then

            AumentoCuatroDivicion = "15/16"

        ElseIf TxbAncho.Text = 135 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 135 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 135 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 135 And CbxAncho.Text = "7/16" Or
               TxbAncho.Text = 135 And CbxAncho.Text = "1/2" Then

            AumentoCuatroDivicion = ""

        ElseIf TxbAncho.Text = 135 And CbxAncho.Text = "9/16" Or TxbAncho.Text = 135 And CbxAncho.Text = "5/8" Or
               TxbAncho.Text = 135 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 135 And CbxAncho.Text = "3/4" Or
               TxbAncho.Text = 135 And CbxAncho.Text = "13/16" Then

            AumentoCuatroDivicion = "1/16"

        ElseIf TxbAncho.Text = 135 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 135 And CbxAncho.Text = "15/16" Then


            AumentoCuatroDivicion = "1/8"

        End If

        If TxbAncho.Text = 137 And CbxAncho.Text = "0" Or TxbAncho.Text = 137 And CbxAncho.Text = "1/16" Then

            AumentoCuatroDivicion = "15/16"

        ElseIf TxbAncho.Text = 137 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 137 And CbxAncho.Text = "3/16" Or
               TxbAncho.Text = 137 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 137 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 137 And CbxAncho.Text = "3/8" Then

            AumentoCuatroDivicion = "3/8"

        ElseIf TxbAncho.Text = 137 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 137 And CbxAncho.Text = "1/2" Or
               TxbAncho.Text = 137 And CbxAncho.Text = "9/16" Or TxbAncho.Text = 137 And CbxAncho.Text = "5/8" Or
               TxbAncho.Text = 137 And CbxAncho.Text = "11/16" Then

            AumentoCuatroDivicion = "7/16"

        ElseIf TxbAncho.Text = 137 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 137 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 137 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 137 And CbxAncho.Text = "15/16" Then

            AumentoCuatroDivicion = "1/2"

        End If

        If TxbAncho.Text = 138 And CbxAncho.Text = "0" Then

            AumentoCuatroDivicion = "1/2"

        ElseIf TxbAncho.Text = 138 And CbxAncho.Text = "1/16" Or TxbAncho.Text = 138 And CbxAncho.Text = "1/8" Or
               TxbAncho.Text = 138 And CbxAncho.Text = "3/16" Or TxbAncho.Text = 138 And CbxAncho.Text = "1/4" Or
               TxbAncho.Text = 138 And CbxAncho.Text = "5/16" Then

            AumentoCuatroDivicion = "9/16"

        ElseIf TxbAncho.Text = 138 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 138 And CbxAncho.Text = "7/16" Or
               TxbAncho.Text = 138 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 138 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 138 And CbxAncho.Text = "5/8" Then

            AumentoCuatroDivicion = "5/8"

        End If

        If TxbAncho.Text = 139 And CbxAncho.Text = "0" Or TxbAncho.Text = 139 And CbxAncho.Text = "1/16" Or
               TxbAncho.Text = 139 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 139 And CbxAncho.Text = "3/16" Or
               TxbAncho.Text = 139 And CbxAncho.Text = "1/4" Then

            AumentoCuatroDivicion = "3/4"


        ElseIf TxbAncho.Text = 139 And CbxAncho.Text = "5/16" Or TxbAncho.Text = 139 And CbxAncho.Text = "3/8" Or
               TxbAncho.Text = 139 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 139 And CbxAncho.Text = "1/2" Or
               TxbAncho.Text = 139 And CbxAncho.Text = "9/16" Then

            AumentoCuatroDivicion = "13/16"


        ElseIf TxbAncho.Text = 139 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 139 And CbxAncho.Text = "3/4" Or
               TxbAncho.Text = 139 And CbxAncho.Text = "13/16" Or TxbAncho.Text = 139 And CbxAncho.Text = "7/8" Or
               TxbAncho.Text = 139 And CbxAncho.Text = "5/8" Then

            AumentoCuatroDivicion = "13/16"


        ElseIf TxbAncho.Text = 139 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 139 And CbxAncho.Text = "11/16" Or
               TxbAncho.Text = 139 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 139 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 139 And CbxAncho.Text = "7/8" Then

            AumentoCuatroDivicion = "7/8"


        ElseIf TxbAncho.Text = 139 And CbxAncho.Text = "15/16" Then

            AumentoCuatroDivicion = "15/16"


        End If

        If TxbAncho.Text = 140 And CbxAncho.Text = "0" Or TxbAncho.Text = 140 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 140 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 140 And CbxAncho.Text = "3/16" Then

            AumentoCuatroDivicion = "15/16"

        ElseIf TxbAncho.Text = 140 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 140 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 140 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 140 And CbxAncho.Text = "7/16" Or
               TxbAncho.Text = 140 And CbxAncho.Text = "1/2" Then

            AumentoCuatroDivicion = ""

        ElseIf TxbAncho.Text = 140 And CbxAncho.Text = "9/16" Or TxbAncho.Text = 140 And CbxAncho.Text = "5/8" Or
               TxbAncho.Text = 140 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 140 And CbxAncho.Text = "3/4" Or
               TxbAncho.Text = 140 And CbxAncho.Text = "13/16" Then

            AumentoCuatroDivicion = "1/16"

        ElseIf TxbAncho.Text = 140 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 140 And CbxAncho.Text = "15/16" Then


            AumentoCuatroDivicion = "1/8"

        End If

        If TxbAncho.Text = 142 And CbxAncho.Text = "0" Or TxbAncho.Text = 142 And CbxAncho.Text = "1/16" Then

            AumentoCuatroDivicion = "15/16"

        ElseIf TxbAncho.Text = 142 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 142 And CbxAncho.Text = "3/16" Or
               TxbAncho.Text = 142 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 142 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 142 And CbxAncho.Text = "3/8" Then

            AumentoCuatroDivicion = "3/8"

        ElseIf TxbAncho.Text = 142 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 142 And CbxAncho.Text = "1/2" Or
               TxbAncho.Text = 142 And CbxAncho.Text = "9/16" Or TxbAncho.Text = 142 And CbxAncho.Text = "5/8" Or
               TxbAncho.Text = 142 And CbxAncho.Text = "11/16" Then

            AumentoCuatroDivicion = "7/16"

        ElseIf TxbAncho.Text = 142 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 142 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 142 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 142 And CbxAncho.Text = "15/16" Then

            AumentoCuatroDivicion = "1/2"

        End If

        If TxbAncho.Text = 143 And CbxAncho.Text = "0" Then

            AumentoCuatroDivicion = "1/2"

        ElseIf TxbAncho.Text = 143 And CbxAncho.Text = "1/16" Or TxbAncho.Text = 143 And CbxAncho.Text = "1/8" Or
               TxbAncho.Text = 143 And CbxAncho.Text = "3/16" Or TxbAncho.Text = 143 And CbxAncho.Text = "1/4" Or
               TxbAncho.Text = 143 And CbxAncho.Text = "5/16" Then

            AumentoCuatroDivicion = "9/16"

        ElseIf TxbAncho.Text = 143 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 143 And CbxAncho.Text = "7/16" Or
               TxbAncho.Text = 143 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 143 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 143 And CbxAncho.Text = "5/8" Then

            AumentoCuatroDivicion = "5/8"

        End If

        If TxbAncho.Text = 144 And CbxAncho.Text = "0" Or TxbAncho.Text = 144 And CbxAncho.Text = "1/16" Or
               TxbAncho.Text = 144 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 144 And CbxAncho.Text = "3/16" Or
               TxbAncho.Text = 144 And CbxAncho.Text = "1/4" Then

            AumentoCuatroDivicion = "3/4"


        ElseIf TxbAncho.Text = 144 And CbxAncho.Text = "5/16" Or TxbAncho.Text = 144 And CbxAncho.Text = "3/8" Or
               TxbAncho.Text = 144 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 144 And CbxAncho.Text = "1/2" Or
               TxbAncho.Text = 144 And CbxAncho.Text = "9/16" Then

            AumentoCuatroDivicion = "13/16"


        ElseIf TxbAncho.Text = 144 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 144 And CbxAncho.Text = "3/4" Or
               TxbAncho.Text = 144 And CbxAncho.Text = "13/16" Or TxbAncho.Text = 144 And CbxAncho.Text = "7/8" Or
               TxbAncho.Text = 144 And CbxAncho.Text = "5/8" Then

            AumentoCuatroDivicion = "13/16"


        ElseIf TxbAncho.Text = 144 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 144 And CbxAncho.Text = "11/16" Or
               TxbAncho.Text = 144 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 144 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 144 And CbxAncho.Text = "7/8" Then

            AumentoCuatroDivicion = "7/8"


        ElseIf TxbAncho.Text = 144 And CbxAncho.Text = "15/16" Then

            AumentoCuatroDivicion = "15/16"


        End If

        If TxbAncho.Text = 145 And CbxAncho.Text = "0" Or TxbAncho.Text = 145 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 145 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 145 And CbxAncho.Text = "3/16" Then

            AumentoCuatroDivicion = "15/16"

        ElseIf TxbAncho.Text = 145 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 145 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 145 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 145 And CbxAncho.Text = "7/16" Or
               TxbAncho.Text = 145 And CbxAncho.Text = "1/2" Then

            AumentoCuatroDivicion = ""

        ElseIf TxbAncho.Text = 145 And CbxAncho.Text = "9/16" Or TxbAncho.Text = 145 And CbxAncho.Text = "5/8" Or
               TxbAncho.Text = 145 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 145 And CbxAncho.Text = "3/4" Or
               TxbAncho.Text = 145 And CbxAncho.Text = "13/16" Then

            AumentoCuatroDivicion = "1/16"

        ElseIf TxbAncho.Text = 145 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 145 And CbxAncho.Text = "15/16" Then


            AumentoCuatroDivicion = "1/8"

        End If

        If TxbAncho.Text = 147 And CbxAncho.Text = "0" Or TxbAncho.Text = 147 And CbxAncho.Text = "1/16" Then

            AumentoCuatroDivicion = "15/16"

        ElseIf TxbAncho.Text = 147 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 147 And CbxAncho.Text = "3/16" Or
               TxbAncho.Text = 147 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 147 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 147 And CbxAncho.Text = "3/8" Then

            AumentoCuatroDivicion = "3/8"

        ElseIf TxbAncho.Text = 147 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 147 And CbxAncho.Text = "1/2" Or
               TxbAncho.Text = 147 And CbxAncho.Text = "9/16" Or TxbAncho.Text = 147 And CbxAncho.Text = "5/8" Or
               TxbAncho.Text = 147 And CbxAncho.Text = "11/16" Then

            AumentoCuatroDivicion = "7/16"

        ElseIf TxbAncho.Text = 147 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 147 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 147 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 147 And CbxAncho.Text = "15/16" Then

            AumentoCuatroDivicion = "1/2"

        End If

        If TxbAncho.Text = 148 And CbxAncho.Text = "0" Then

            AumentoCuatroDivicion = "1/2"

        ElseIf TxbAncho.Text = 148 And CbxAncho.Text = "1/16" Or TxbAncho.Text = 148 And CbxAncho.Text = "1/8" Or
               TxbAncho.Text = 148 And CbxAncho.Text = "3/16" Or TxbAncho.Text = 148 And CbxAncho.Text = "1/4" Or
               TxbAncho.Text = 148 And CbxAncho.Text = "5/16" Then

            AumentoCuatroDivicion = "9/16"

        ElseIf TxbAncho.Text = 148 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 148 And CbxAncho.Text = "7/16" Or
               TxbAncho.Text = 148 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 148 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 148 And CbxAncho.Text = "5/8" Then

            AumentoCuatroDivicion = "5/8"

        End If

        If TxbAncho.Text = 149 And CbxAncho.Text = "0" Or TxbAncho.Text = 149 And CbxAncho.Text = "1/16" Or
               TxbAncho.Text = 149 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 149 And CbxAncho.Text = "3/16" Or
               TxbAncho.Text = 149 And CbxAncho.Text = "1/4" Then

            AumentoCuatroDivicion = "3/4"


        ElseIf TxbAncho.Text = 149 And CbxAncho.Text = "5/16" Or TxbAncho.Text = 149 And CbxAncho.Text = "3/8" Or
               TxbAncho.Text = 149 And CbxAncho.Text = "7/16" Or TxbAncho.Text = 149 And CbxAncho.Text = "1/2" Or
               TxbAncho.Text = 149 And CbxAncho.Text = "9/16" Then

            AumentoCuatroDivicion = "13/16"


        ElseIf TxbAncho.Text = 149 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 149 And CbxAncho.Text = "3/4" Or
               TxbAncho.Text = 149 And CbxAncho.Text = "13/16" Or TxbAncho.Text = 149 And CbxAncho.Text = "7/8" Or
               TxbAncho.Text = 149 And CbxAncho.Text = "5/8" Then

            AumentoCuatroDivicion = "13/16"


        ElseIf TxbAncho.Text = 149 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 149 And CbxAncho.Text = "11/16" Or
               TxbAncho.Text = 149 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 149 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 149 And CbxAncho.Text = "7/8" Then

            AumentoCuatroDivicion = "7/8"


        ElseIf TxbAncho.Text = 149 And CbxAncho.Text = "15/16" Then

            AumentoCuatroDivicion = "15/16"


        End If

        If TxbAncho.Text = 150 And CbxAncho.Text = "0" Or TxbAncho.Text = 150 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 150 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 150 And CbxAncho.Text = "3/16" Then

            AumentoCuatroDivicion = "15/16"

        ElseIf TxbAncho.Text = 150 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 150 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 150 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 150 And CbxAncho.Text = "7/16" Or
               TxbAncho.Text = 150 And CbxAncho.Text = "1/2" Then

            AumentoCuatroDivicion = ""

        ElseIf TxbAncho.Text = 150 And CbxAncho.Text = "9/16" Or TxbAncho.Text = 150 And CbxAncho.Text = "5/8" Or
               TxbAncho.Text = 150 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 150 And CbxAncho.Text = "3/4" Or
               TxbAncho.Text = 150 And CbxAncho.Text = "13/16" Then

            AumentoCuatroDivicion = "1/16"

        ElseIf TxbAncho.Text = 150 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 150 And CbxAncho.Text = "15/16" Then


            AumentoCuatroDivicion = "1/8"

        End If
        '=======================================================================================================================

        If TxbAncho.Text = 152 And CbxAncho.Text = "0" Or TxbAncho.Text = 152 And CbxAncho.Text = "1/16" Then


            AumentoCincoDivicion = "1/4"

        ElseIf TxbAncho.Text = 152 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 152 And CbxAncho.Text = "3/16" Or
               TxbAncho.Text = 152 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 152 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 152 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 152 And CbxAncho.Text = "7/16" Then

            AumentoCincoDivicion = "5/16"

        ElseIf TxbAncho.Text = 152 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 152 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 152 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 152 And CbxAncho.Text = "11/16" Or
               TxbAncho.Text = 152 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 152 And CbxAncho.Text = "13/16" Then

            AumentoCincoDivicion = "3/8"


        ElseIf TxbAncho.Text = 152 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 152 And CbxAncho.Text = "15/16" Then


            AumentoCincoDivicion = "7/16"

        End If


        If TxbAncho.Text = 153 And CbxAncho.Text = "0" Or TxbAncho.Text = 153 And CbxAncho.Text = "1/16" Or
               TxbAncho.Text = 153 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 153 And CbxAncho.Text = "3/16" Then

            AumentoCincoDivicion = "7/16"

        ElseIf TxbAncho.Text = 153 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 153 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 153 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 153 And CbxAncho.Text = "7/16" Or
               TxbAncho.Text = 153 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 153 And CbxAncho.Text = "9/16" Then

            AumentoCincoDivicion = "1/2"


        ElseIf TxbAncho.Text = 153 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 153 And CbxAncho.Text = "11/16" Or
               TxbAncho.Text = 153 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 153 And CbxAncho.Text = "3/4" Or
               TxbAncho.Text = 153 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 153 And CbxAncho.Text = "15/16" Then

            AumentoCincoDivicion = "9/16"

        End If

        If TxbAncho.Text = 154 And CbxAncho.Text = "0" Or TxbAncho.Text = 154 And CbxAncho.Text = "1/16" Or
               TxbAncho.Text = 154 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 154 And CbxAncho.Text = "3/16" Or
               TxbAncho.Text = 154 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 154 And CbxAncho.Text = "5/16" Then

            AumentoCincoDivicion = "5/8"

        ElseIf TxbAncho.Text = 154 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 154 And CbxAncho.Text = "7/16" Or
               TxbAncho.Text = 154 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 154 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 154 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 154 And CbxAncho.Text = "11/16" Then

            AumentoCincoDivicion = "11/16"


        ElseIf TxbAncho.Text = 154 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 154 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 154 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 154 And CbxAncho.Text = "15/16" Then

            AumentoCincoDivicion = "3/4"

        End If

        If TxbAncho.Text = 155 And CbxAncho.Text = "0" Or TxbAncho.Text = 155 And CbxAncho.Text = "1/16" Then

            AumentoCincoDivicion = "3/4"

        ElseIf TxbAncho.Text = 155 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 155 And CbxAncho.Text = "3/16" Or
               TxbAncho.Text = 155 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 155 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 155 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 155 And CbxAncho.Text = "7/16" Then

            AumentoCincoDivicion = "13/16"


        ElseIf TxbAncho.Text = 155 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 155 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 155 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 155 And CbxAncho.Text = "11/16" Or
               TxbAncho.Text = 155 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 155 And CbxAncho.Text = "13/16" Then

            AumentoCincoDivicion = "7/8"

        ElseIf TxbAncho.Text = 155 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 155 And CbxAncho.Text = "15/16" Then

            AumentoCincoDivicion = "15/16"


        End If

        If TxbAncho.Text = 156 And CbxAncho.Text = "0" Or TxbAncho.Text = 156 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 156 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 156 And CbxAncho.Text = "3/16" Then

            AumentoCincoDivicion = "5/16"

        ElseIf TxbAncho.Text = 156 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 156 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 156 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 156 And CbxAncho.Text = "7/16" Or
               TxbAncho.Text = 156 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 156 And CbxAncho.Text = "9/16" Then

            AumentoCincoDivicion = ""


        ElseIf TxbAncho.Text = 156 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 156 And CbxAncho.Text = "11/16" Or
               TxbAncho.Text = 156 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 156 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 156 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 156 And CbxAncho.Text = "15/16" Then

            AumentoCincoDivicion = "1/16"




        End If

        If TxbAncho.Text = 158 And CbxAncho.Text = "0" Or TxbAncho.Text = 152 And CbxAncho.Text = "1/16" Then


            AumentoCincoDivicion = "1/4"

        ElseIf TxbAncho.Text = 158 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 158 And CbxAncho.Text = "3/16" Or
               TxbAncho.Text = 158 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 158 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 158 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 158 And CbxAncho.Text = "7/16" Then

            AumentoCincoDivicion = "5/16"

        ElseIf TxbAncho.Text = 158 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 158 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 158 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 158 And CbxAncho.Text = "11/16" Or
               TxbAncho.Text = 158 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 158 And CbxAncho.Text = "13/16" Then

            AumentoCincoDivicion = "3/8"


        ElseIf TxbAncho.Text = 158 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 158 And CbxAncho.Text = "15/16" Then


            AumentoCincoDivicion = "7/16"

        End If

        If TxbAncho.Text = 159 And CbxAncho.Text = "0" Or TxbAncho.Text = 159 And CbxAncho.Text = "1/16" Or
               TxbAncho.Text = 159 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 159 And CbxAncho.Text = "3/16" Then

            AumentoCincoDivicion = "7/16"

        ElseIf TxbAncho.Text = 159 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 159 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 159 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 159 And CbxAncho.Text = "7/16" Or
               TxbAncho.Text = 159 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 159 And CbxAncho.Text = "9/16" Then

            AumentoCincoDivicion = "1/2"


        ElseIf TxbAncho.Text = 159 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 159 And CbxAncho.Text = "11/16" Or
               TxbAncho.Text = 159 And CbxAncho.Text = "11/16" Or TxbAncho.Text = 159 And CbxAncho.Text = "3/4" Or
               TxbAncho.Text = 159 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 159 And CbxAncho.Text = "15/16" Then

            AumentoCincoDivicion = "9/16"

        End If

        If TxbAncho.Text = 160 And CbxAncho.Text = "0" Or TxbAncho.Text = 160 And CbxAncho.Text = "1/16" Or
               TxbAncho.Text = 160 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 160 And CbxAncho.Text = "3/16" Or
               TxbAncho.Text = 160 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 160 And CbxAncho.Text = "5/16" Then

            AumentoCincoDivicion = "5/8"

        ElseIf TxbAncho.Text = 160 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 160 And CbxAncho.Text = "7/16" Or
               TxbAncho.Text = 160 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 160 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 160 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 160 And CbxAncho.Text = "11/16" Then

            AumentoCincoDivicion = "11/16"


        ElseIf TxbAncho.Text = 160 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 160 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 160 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 160 And CbxAncho.Text = "15/16" Then

            AumentoCincoDivicion = "3/4"

        End If

        If TxbAncho.Text = 161 And CbxAncho.Text = "0" Or TxbAncho.Text = 161 And CbxAncho.Text = "1/16" Then

            AumentoCincoDivicion = "3/4"

        ElseIf TxbAncho.Text = 161 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 161 And CbxAncho.Text = "3/16" Or
               TxbAncho.Text = 161 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 161 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 161 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 161 And CbxAncho.Text = "7/16" Then

            AumentoCincoDivicion = "13/16"


        ElseIf TxbAncho.Text = 161 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 161 And CbxAncho.Text = "9/16" Or
               TxbAncho.Text = 161 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 161 And CbxAncho.Text = "11/16" Or
               TxbAncho.Text = 161 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 161 And CbxAncho.Text = "13/16" Then

            AumentoCincoDivicion = "7/8"

        ElseIf TxbAncho.Text = 161 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 155 And CbxAncho.Text = "15/16" Then

            AumentoCincoDivicion = "15/16"


        End If

        If TxbAncho.Text = 162 And CbxAncho.Text = "0" Or TxbAncho.Text = 162 And CbxAncho.Text = "1/16" Or
           TxbAncho.Text = 162 And CbxAncho.Text = "1/8" Or TxbAncho.Text = 162 And CbxAncho.Text = "3/16" Then

            AumentoCincoDivicion = "5/16"

        ElseIf TxbAncho.Text = 162 And CbxAncho.Text = "1/4" Or TxbAncho.Text = 162 And CbxAncho.Text = "5/16" Or
               TxbAncho.Text = 162 And CbxAncho.Text = "3/8" Or TxbAncho.Text = 162 And CbxAncho.Text = "7/16" Or
               TxbAncho.Text = 162 And CbxAncho.Text = "1/2" Or TxbAncho.Text = 162 And CbxAncho.Text = "9/16" Then

            AumentoCincoDivicion = ""


        ElseIf TxbAncho.Text = 162 And CbxAncho.Text = "5/8" Or TxbAncho.Text = 162 And CbxAncho.Text = "11/16" Or
               TxbAncho.Text = 162 And CbxAncho.Text = "3/4" Or TxbAncho.Text = 162 And CbxAncho.Text = "13/16" Or
               TxbAncho.Text = 162 And CbxAncho.Text = "7/8" Or TxbAncho.Text = 162 And CbxAncho.Text = "15/16" Then

            AumentoCincoDivicion = "1/16"




        End If
























        'ALTO DEL CUADRO

        'DE 0 A 3/4
        If CbxAlto.Text = "0" Then
            SalidaAlto = 0
            ComversorAlto = ""
            RestaAlto = "3/4"
            SwitchAlto = 0.75

            'DE 1/6 A 13/16
        ElseIf CbxAlto.Text = "1/16" Then
            SalidaAlto = 0.0625
            ComversorAlto = "1/16"
            RestaAlto = "13/16"
            SwitchAlto = 0.8125

            'DE 1/8 A 7/8
        ElseIf CbxAlto.Text = "1/8" Then
            ComversorAlto = 0.125
            ComversorAncho = "1/8"
            RestaAlto = "7/8"
            SwitchAlto = 0.875

            'DE 3/16 A 15/16
        ElseIf CbxAlto.Text = "3/16" Then
            SalidaAlto = 0.1875
            ComversorAlto = "3/16"
            RestaAlto = "15/16"
            SwitchAlto = 0.9375

            'DE 1/4 A 0
        ElseIf CbxAlto.Text = "1/4" Then
            SalidaAlto = 0
            ComversorAlto = "1/4"
            RestaAlto = ""
            SwitchAlto = 0

            'DE 5/16 A 1/16
        ElseIf CbxAlto.Text = "5/16" Then
            SalidaAlto = 0.3125
            ComversorAlto = "5/16"
            RestaAlto = "15/16"
            SwitchAlto = 0

            'DE 3/8 A 1/8
        ElseIf CbxAlto.Text = "3/8" Then
            SalidaAlto = 0.375
            ComversorAlto = "3/8"
            RestaAlto = "1/8"
            SwitchAlto = 0

            'DE 7/16 A 3/16
        ElseIf CbxAlto.Text = "7/16" Then
            SalidaAlto = 0.4375
            ComversorAlto = "7/16"
            RestaAlto = "3/16"
            SwitchAlto = 0

            'DE 1/2 A 1/4
        ElseIf CbxAlto.Text = "1/2" Then
            SalidaAlto = 0.5
            ComversorAlto = "1/2"
            RestaAlto = "1/4"
            SwitchAlto = 0

            'DE 9/16 A 5/16
        ElseIf CbxAlto.Text = "9/16" Then
            SalidaAlto = 0.5625
            ComversorAlto = "9/16"
            RestaAlto = "5/16"
            SwitchAlto = 0

            'DE 5/8 A 3/8
        ElseIf CbxAlto.Text = "5/8" Then
            SalidaAlto = 0.625
            ComversorAlto = "5/8"
            RestaAlto = "3/8"
            SwitchAlto = 0

            'DE 11/16 A 7/16
        ElseIf CbxAlto.Text = "11/16" Then
            SalidaAlto = 0.6875
            ComversorAlto = "11/16"
            RestaAlto = "7/16"
            SwitchAlto = 0

            'DE 3/4 A 1/2
        ElseIf CbxAlto.Text = "3/4" Then
            SalidaAlto = 0.75
            ComversorAlto = "3/4"
            RestaAlto = "1/2"
            SwitchAlto = 0

            'DE 13/16 A 9/16
        ElseIf CbxAlto.Text = "13/16" Then
            SalidaAlto = 0.8125
            ComversorAlto = "13/16"
            RestaAlto = "9/16"
            SwitchAlto = 0

            'DE 7/8 A 5/8
        ElseIf CbxAlto.Text = "7/8" Then
            SalidaAlto = 0.875
            ComversorAlto = "7/8"
            RestaAlto = "5/8"
            SwitchAlto = 0

            'DE 15/16 A 11/16
        ElseIf CbxAlto.Text = "15/16" Then
            SalidaAlto = 0.9375
            ComversorAlto = "15/16"
            RestaAlto = "11/16"
            SwitchAlto = 0
        End If




        Dim VarAncho As Double = ValorTbxAncho - SwitchAncho
        Dim DecAncho As Double

        Dim VarAlto As Double = ValorTbxAlto - SwitchAlto
        Dim DecAlto As Double

        DecAncho = (Math.Floor(VarAncho))
        DecAlto = (Math.Floor(VarAlto))




        lbSalidaAncho.Text = DecAncho.ToString + Espacio + RestaAncho
        lblSalidaAlto.Text = DecAlto.ToString + Espacio + RestaAlto




        Dim CelociasLargo As Double
        Dim RejuegoCelocias As Double
        'Dim CelociasDividias As Double


        If Diviciones = 0 Then
            RejuegoCelocias = 0.25
            JambaDivicion = 0
            'AumentoCelocia = "3/4"
        ElseIf Diviciones = 1 Then
            RejuegoCelocias = 0.5
            JambaDivicion = 2

        ElseIf Diviciones = 2 Then

            RejuegoCelocias = 0.75
            JambaDivicion = 4

        ElseIf Diviciones = 3 Then

            RejuegoCelocias = 1
            JambaDivicion = 6

        ElseIf Diviciones = 4 Then

            RejuegoCelocias = 1.25
            JambaDivicion = 8

        ElseIf Diviciones = 5 Then

            RejuegoCelocias = 1.5
            JambaDivicion = 10

        End If


        CelociasLargo = ValorTbxAncho + SalidaAncho - Huecorejuego - Jambas - JambaDivicion



        If Diviciones = 0 Then
            Regla = CelociasLargo

        ElseIf Diviciones = 1 Then

            Regla = CelociasLargo / 2
        ElseIf Diviciones = 2 Then

            Regla = CelociasLargo / 3

        ElseIf Diviciones = 3 Then

            Regla = CelociasLargo / 4

        ElseIf Diviciones = 4 Then
            Regla = CelociasLargo / 5

        ElseIf Diviciones = 5 Then

            Regla = CelociasLargo / 6

        End If
        'MsgBox(Regla)
        DeciSalidaAncho = (Math.Floor(Regla))







        If Diviciones = 0 Then

            lblCelocias.Text = DeciSalidaAncho.ToString + Espacio + RestaAncho


        End If

        If Diviciones = 1 Then

            lblCelocias.Text = DeciSalidaAncho.ToString + Espacio + AumentoUnaDivicion

        End If

        If Diviciones = 2 Then

            lblCelocias.Text = DeciSalidaAncho.ToString + Espacio + AumentoDosDivicion

        End If

        If Diviciones = 3 Then

            lblCelocias.Text = DeciSalidaAncho.ToString + Espacio + AumentoTresDivicion

        End If

        If Diviciones = 4 Then

            lblCelocias.Text = DeciSalidaAncho.ToString + Espacio + AumentoCuatroDivicion

        End If

        If Diviciones = 5 Then

            lblCelocias.Text = DeciSalidaAncho.ToString + Espacio + AumentoCincoDivicion

        End If



        If txtDiviciones.Text = 0 Then
            CeloDiviciones = 1
        ElseIf Diviciones = 1 Then

            CeloDiviciones = 2
        ElseIf txtDiviciones.Text = 2 Then

            CeloDiviciones = 3

        ElseIf txtDiviciones.Text = 3 Then
            CeloDiviciones = 4


        ElseIf txtDiviciones.Text = 4 Then
            CeloDiviciones = 5

        ElseIf txtDiviciones.Text = 5 Then

            CeloDiviciones = 6

        End If
        ResultadoCeloAlto = ValorTbxAlto + SalidaAlto - 2
        RedonderCelocia = ResultadoCeloAlto / 3.5
        '* CeloDiviciones
        ResultadoCeloAltoFinal = (Math.Ceiling(RedonderCelocia))
        lblCeloAlto.Text = ResultadoCeloAltoFinal * CeloDiviciones






        DataGridView1.Rows.Add(TxbCantidad.Text, TxbAncho.Text + Espacio + CbxAncho.Text, TxbAlto.Text + Espacio + CbxAlto.Text, txtDiviciones.Text, TxbCantidad.Text)

    End Sub


    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        DataGridView1.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub TxbAncho_TextChanged(sender As Object, e As EventArgs) Handles TxbAncho.TextChanged


        'If TxbAncho.Text = "" Then
        '    TxbAncho.Text = 0
        'End If


        'If TxbAncho.Text >= 0 And TxbAncho.Text < 25 Then
        '    txtDiviciones.Text = 0

        'End If


        'If TxbAncho.Text > 25 And TxbAncho.Text < 35 Then
        '    Diviciones = 1

        'End If

        'If TxbAncho.Text > 35 And TxbAncho.Text <= 50 Then
        '    Diviciones = 2

        'End If

        'If TxbAncho.Text > 50 And TxbAncho.Text <= 75 Then
        '    Diviciones = 3

        'End If

        'If TxbAncho.Text >= 76 And TxbAncho.Text <= 100 Then
        '    Diviciones = 4

        'End If

        'If TxbAncho.Text >= 101 And TxbAncho.Text <= 125 Then
        '    Diviciones = 5
        'End If



    End Sub




    Private Sub CbxAncho_LostFocus(sender As Object, e As EventArgs) Handles CbxAncho.LostFocus
        If CbxAncho.Text = "" Then

            CbxAncho.Text = "0"

        End If
    End Sub



    Private Sub CbxAlto_LostFocus(sender As Object, e As EventArgs) Handles CbxAlto.LostFocus
        If CbxAlto.Text = "" Then

            CbxAlto.Text = "0"

        End If
    End Sub







    Private Sub TxbAncho_LostFocus(sender As Object, e As EventArgs) Handles TxbAncho.LostFocus
        If TxbAncho.Text = "" Then

            TxbAncho.Text = "0"

        End If
    End Sub


    Private Sub TxbAlto_LostFocus(sender As Object, e As EventArgs) Handles TxbAlto.LostFocus
        If TxbAlto.Text = "" Then
            TxbAlto.Text = 0
        End If
    End Sub






    Private Sub TxbAlto_TextChanged(sender As Object, e As EventArgs) Handles TxbAlto.TextChanged
        If TxbAlto.Text = "" Then
            TxbAlto.Text = 0
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class