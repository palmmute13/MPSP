<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HOME
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HOME))
        Me.btnVentanasAA = New System.Windows.Forms.Button()
        Me.btnVentanasCorrediza = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ADMINISTRACIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CREARUSUARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ELIMINARUSUARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODIFICARUSUARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BUSCARCLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CREARCLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IMPRIMIRLISTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VENTANASAAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VENTCORREDISAZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TxtIp = New System.Windows.Forms.TextBox()
        Me.TxtPrinter = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.TxtDip = New System.Windows.Forms.TextBox()
        Me.TxtPc = New System.Windows.Forms.TextBox()
        Me.TxtDfecha = New System.Windows.Forms.TextBox()
        Me.TxtDPrinter = New System.Windows.Forms.TextBox()
        Me.tbHora = New System.Windows.Forms.TextBox()
        Me.LblFecha = New System.Windows.Forms.TextBox()
        Me.TxtdHora = New System.Windows.Forms.TextBox()
        Me.tbNivel = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.TxtDPc = New System.Windows.Forms.TextBox()
        Me.LblPc = New System.Windows.Forms.Label()
        Me.LblUsuarios = New System.Windows.Forms.Label()
        Me.LblNivel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblIp = New System.Windows.Forms.Label()
        Me.LblPrinter = New System.Windows.Forms.Label()
        Me.LblFechaDos = New System.Windows.Forms.Label()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVentanasAA
        '
        Me.btnVentanasAA.Location = New System.Drawing.Point(37, 143)
        Me.btnVentanasAA.Margin = New System.Windows.Forms.Padding(100, 3, 3, 3)
        Me.btnVentanasAA.Name = "btnVentanasAA"
        Me.btnVentanasAA.Size = New System.Drawing.Size(169, 50)
        Me.btnVentanasAA.TabIndex = 0
        Me.btnVentanasAA.Text = "VENTANAS AA"
        Me.btnVentanasAA.UseVisualStyleBackColor = True
        '
        'btnVentanasCorrediza
        '
        Me.btnVentanasCorrediza.Location = New System.Drawing.Point(37, 199)
        Me.btnVentanasCorrediza.Margin = New System.Windows.Forms.Padding(100, 3, 3, 3)
        Me.btnVentanasCorrediza.Name = "btnVentanasCorrediza"
        Me.btnVentanasCorrediza.Size = New System.Drawing.Size(169, 50)
        Me.btnVentanasCorrediza.TabIndex = 1
        Me.btnVentanasCorrediza.Text = "VENTANAS CORREDIZAS"
        Me.btnVentanasCorrediza.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(37, 255)
        Me.Button3.Margin = New System.Windows.Forms.Padding(100, 3, 3, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(169, 50)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "PUERTAS"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(37, 311)
        Me.Button4.Margin = New System.Windows.Forms.Padding(100, 3, 3, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(169, 50)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "CONSULTAS"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(37, 367)
        Me.Button5.Margin = New System.Windows.Forms.Padding(100, 3, 3, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(169, 50)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "REPORTE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADMINISTRACIONToolStripMenuItem, Me.CLIENTESToolStripMenuItem, Me.REPORTESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(954, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ADMINISTRACIONToolStripMenuItem
        '
        Me.ADMINISTRACIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CREARUSUARIOToolStripMenuItem, Me.ELIMINARUSUARIOToolStripMenuItem, Me.MODIFICARUSUARIOToolStripMenuItem})
        Me.ADMINISTRACIONToolStripMenuItem.Name = "ADMINISTRACIONToolStripMenuItem"
        Me.ADMINISTRACIONToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.ADMINISTRACIONToolStripMenuItem.Text = "ADMINISTRACION"
        '
        'CREARUSUARIOToolStripMenuItem
        '
        Me.CREARUSUARIOToolStripMenuItem.Name = "CREARUSUARIOToolStripMenuItem"
        Me.CREARUSUARIOToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.CREARUSUARIOToolStripMenuItem.Text = "CREAR USUARIO"
        '
        'ELIMINARUSUARIOToolStripMenuItem
        '
        Me.ELIMINARUSUARIOToolStripMenuItem.Name = "ELIMINARUSUARIOToolStripMenuItem"
        Me.ELIMINARUSUARIOToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ELIMINARUSUARIOToolStripMenuItem.Text = "ELIMINAR USUARIO"
        '
        'MODIFICARUSUARIOToolStripMenuItem
        '
        Me.MODIFICARUSUARIOToolStripMenuItem.Name = "MODIFICARUSUARIOToolStripMenuItem"
        Me.MODIFICARUSUARIOToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.MODIFICARUSUARIOToolStripMenuItem.Text = "MODIFICAR USUARIO"
        '
        'CLIENTESToolStripMenuItem
        '
        Me.CLIENTESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BUSCARCLIENTESToolStripMenuItem, Me.CREARCLIENTESToolStripMenuItem, Me.IMPRIMIRLISTAToolStripMenuItem})
        Me.CLIENTESToolStripMenuItem.Name = "CLIENTESToolStripMenuItem"
        Me.CLIENTESToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.CLIENTESToolStripMenuItem.Text = "CLIENTES"
        '
        'BUSCARCLIENTESToolStripMenuItem
        '
        Me.BUSCARCLIENTESToolStripMenuItem.Name = "BUSCARCLIENTESToolStripMenuItem"
        Me.BUSCARCLIENTESToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.BUSCARCLIENTESToolStripMenuItem.Text = "BUSCAR CLIENTES"
        '
        'CREARCLIENTESToolStripMenuItem
        '
        Me.CREARCLIENTESToolStripMenuItem.Name = "CREARCLIENTESToolStripMenuItem"
        Me.CREARCLIENTESToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.CREARCLIENTESToolStripMenuItem.Text = "CREAR CLIENTES"
        '
        'IMPRIMIRLISTAToolStripMenuItem
        '
        Me.IMPRIMIRLISTAToolStripMenuItem.Name = "IMPRIMIRLISTAToolStripMenuItem"
        Me.IMPRIMIRLISTAToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.IMPRIMIRLISTAToolStripMenuItem.Text = "IMPRIMIR LISTA"
        '
        'REPORTESToolStripMenuItem
        '
        Me.REPORTESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VENTANASAAToolStripMenuItem, Me.VENTCORREDISAZToolStripMenuItem})
        Me.REPORTESToolStripMenuItem.Name = "REPORTESToolStripMenuItem"
        Me.REPORTESToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.REPORTESToolStripMenuItem.Text = "REPORTES"
        '
        'VENTANASAAToolStripMenuItem
        '
        Me.VENTANASAAToolStripMenuItem.Name = "VENTANASAAToolStripMenuItem"
        Me.VENTANASAAToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.VENTANASAAToolStripMenuItem.Text = "VENTANAS AA"
        '
        'VENTCORREDISAZToolStripMenuItem
        '
        Me.VENTCORREDISAZToolStripMenuItem.Name = "VENTCORREDISAZToolStripMenuItem"
        Me.VENTCORREDISAZToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.VENTCORREDISAZToolStripMenuItem.Text = "VENT. CORREDISAZ"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(37, 479)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(169, 50)
        Me.Button9.TabIndex = 22
        Me.Button9.Text = "SALIR"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(37, 423)
        Me.Button1.Margin = New System.Windows.Forms.Padding(100, 3, 3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 50)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "CONFIGURACION"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtIp
        '
        Me.TxtIp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtIp.Enabled = False
        Me.TxtIp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.TxtIp.Location = New System.Drawing.Point(610, 29)
        Me.TxtIp.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.TxtIp.Name = "TxtIp"
        Me.TxtIp.ReadOnly = True
        Me.TxtIp.Size = New System.Drawing.Size(128, 23)
        Me.TxtIp.TabIndex = 26
        Me.TxtIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPrinter
        '
        Me.TxtPrinter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPrinter.Enabled = False
        Me.TxtPrinter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.TxtPrinter.Location = New System.Drawing.Point(610, 54)
        Me.TxtPrinter.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.TxtPrinter.Name = "TxtPrinter"
        Me.TxtPrinter.ReadOnly = True
        Me.TxtPrinter.Size = New System.Drawing.Size(128, 23)
        Me.TxtPrinter.TabIndex = 27
        Me.TxtPrinter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtDip
        '
        Me.TxtDip.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDip.Enabled = False
        Me.TxtDip.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDip.Location = New System.Drawing.Point(518, 29)
        Me.TxtDip.Margin = New System.Windows.Forms.Padding(0, 1, 2, 1)
        Me.TxtDip.Name = "TxtDip"
        Me.TxtDip.ReadOnly = True
        Me.TxtDip.Size = New System.Drawing.Size(90, 23)
        Me.TxtDip.TabIndex = 13
        Me.TxtDip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPc
        '
        Me.TxtPc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPc.Enabled = False
        Me.TxtPc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.TxtPc.Location = New System.Drawing.Point(385, 29)
        Me.TxtPc.Margin = New System.Windows.Forms.Padding(0, 3, 5, 3)
        Me.TxtPc.Name = "TxtPc"
        Me.TxtPc.ReadOnly = True
        Me.TxtPc.Size = New System.Drawing.Size(128, 23)
        Me.TxtPc.TabIndex = 25
        Me.TxtPc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtDfecha
        '
        Me.TxtDfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDfecha.Enabled = False
        Me.TxtDfecha.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDfecha.Location = New System.Drawing.Point(743, 29)
        Me.TxtDfecha.Margin = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.TxtDfecha.Name = "TxtDfecha"
        Me.TxtDfecha.ReadOnly = True
        Me.TxtDfecha.Size = New System.Drawing.Size(100, 23)
        Me.TxtDfecha.TabIndex = 5
        Me.TxtDfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDPrinter
        '
        Me.TxtDPrinter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDPrinter.Enabled = False
        Me.TxtDPrinter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDPrinter.Location = New System.Drawing.Point(518, 54)
        Me.TxtDPrinter.Margin = New System.Windows.Forms.Padding(0, 1, 2, 1)
        Me.TxtDPrinter.Name = "TxtDPrinter"
        Me.TxtDPrinter.ReadOnly = True
        Me.TxtDPrinter.Size = New System.Drawing.Size(90, 23)
        Me.TxtDPrinter.TabIndex = 28
        Me.TxtDPrinter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbHora
        '
        Me.tbHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbHora.Enabled = False
        Me.tbHora.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.tbHora.Location = New System.Drawing.Point(845, 54)
        Me.tbHora.Margin = New System.Windows.Forms.Padding(0, 2, 0, 3)
        Me.tbHora.Name = "tbHora"
        Me.tbHora.ReadOnly = True
        Me.tbHora.Size = New System.Drawing.Size(100, 23)
        Me.tbHora.TabIndex = 2
        Me.tbHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblFecha
        '
        Me.LblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblFecha.Enabled = False
        Me.LblFecha.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblFecha.Location = New System.Drawing.Point(845, 29)
        Me.LblFecha.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.ReadOnly = True
        Me.LblFecha.Size = New System.Drawing.Size(100, 23)
        Me.LblFecha.TabIndex = 3
        Me.LblFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtdHora
        '
        Me.TxtdHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtdHora.Enabled = False
        Me.TxtdHora.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtdHora.HideSelection = False
        Me.TxtdHora.Location = New System.Drawing.Point(743, 54)
        Me.TxtdHora.Margin = New System.Windows.Forms.Padding(0, 0, 2, 3)
        Me.TxtdHora.Name = "TxtdHora"
        Me.TxtdHora.ReadOnly = True
        Me.TxtdHora.Size = New System.Drawing.Size(100, 23)
        Me.TxtdHora.TabIndex = 4
        Me.TxtdHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbNivel
        '
        Me.tbNivel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNivel.Enabled = False
        Me.tbNivel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNivel.Location = New System.Drawing.Point(268, 54)
        Me.tbNivel.Margin = New System.Windows.Forms.Padding(3, 3, 2, 3)
        Me.tbNivel.Name = "tbNivel"
        Me.tbNivel.ReadOnly = True
        Me.tbNivel.Size = New System.Drawing.Size(115, 23)
        Me.tbNivel.TabIndex = 7
        Me.tbNivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(251, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'tbUsuario
        '
        Me.tbUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbUsuario.Enabled = False
        Me.tbUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.tbUsuario.Location = New System.Drawing.Point(385, 54)
        Me.tbUsuario.Margin = New System.Windows.Forms.Padding(0, 2, 5, 1)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.ReadOnly = True
        Me.tbUsuario.Size = New System.Drawing.Size(128, 23)
        Me.tbUsuario.TabIndex = 6
        Me.tbUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtDPc
        '
        Me.TxtDPc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDPc.Enabled = False
        Me.TxtDPc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDPc.Location = New System.Drawing.Point(268, 29)
        Me.TxtDPc.Margin = New System.Windows.Forms.Padding(1, 1, 2, 1)
        Me.TxtDPc.Name = "TxtDPc"
        Me.TxtDPc.ReadOnly = True
        Me.TxtDPc.Size = New System.Drawing.Size(115, 23)
        Me.TxtDPc.TabIndex = 29
        Me.TxtDPc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblPc
        '
        Me.LblPc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPc.AutoSize = True
        Me.LblPc.BackColor = System.Drawing.Color.Yellow
        Me.LblPc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblPc.Location = New System.Drawing.Point(407, 32)
        Me.LblPc.Name = "LblPc"
        Me.LblPc.Size = New System.Drawing.Size(15, 15)
        Me.LblPc.TabIndex = 31
        Me.LblPc.Text = "0"
        '
        'LblUsuarios
        '
        Me.LblUsuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblUsuarios.AutoSize = True
        Me.LblUsuarios.BackColor = System.Drawing.Color.Yellow
        Me.LblUsuarios.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblUsuarios.Location = New System.Drawing.Point(407, 57)
        Me.LblUsuarios.Name = "LblUsuarios"
        Me.LblUsuarios.Size = New System.Drawing.Size(15, 15)
        Me.LblUsuarios.TabIndex = 32
        Me.LblUsuarios.Text = "0"
        '
        'LblNivel
        '
        Me.LblNivel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblNivel.AutoSize = True
        Me.LblNivel.BackColor = System.Drawing.Color.LawnGreen
        Me.LblNivel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblNivel.Location = New System.Drawing.Point(273, 57)
        Me.LblNivel.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LblNivel.Name = "LblNivel"
        Me.LblNivel.Size = New System.Drawing.Size(15, 15)
        Me.LblNivel.TabIndex = 33
        Me.LblNivel.Text = "0"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LawnGreen
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(350, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "PC:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LawnGreen
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(532, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "DIREC. IP:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LawnGreen
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(536, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "PRINTER:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LawnGreen
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(783, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "FECHA:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LawnGreen
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(791, 57)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "HORA:"
        '
        'LblIp
        '
        Me.LblIp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblIp.AutoSize = True
        Me.LblIp.BackColor = System.Drawing.Color.Yellow
        Me.LblIp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblIp.Location = New System.Drawing.Point(628, 32)
        Me.LblIp.Name = "LblIp"
        Me.LblIp.Size = New System.Drawing.Size(15, 15)
        Me.LblIp.TabIndex = 39
        Me.LblIp.Text = "0"
        '
        'LblPrinter
        '
        Me.LblPrinter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPrinter.AutoSize = True
        Me.LblPrinter.BackColor = System.Drawing.Color.Yellow
        Me.LblPrinter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblPrinter.Location = New System.Drawing.Point(628, 57)
        Me.LblPrinter.Name = "LblPrinter"
        Me.LblPrinter.Size = New System.Drawing.Size(15, 15)
        Me.LblPrinter.TabIndex = 40
        Me.LblPrinter.Text = "0"
        '
        'LblFechaDos
        '
        Me.LblFechaDos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblFechaDos.AutoSize = True
        Me.LblFechaDos.BackColor = System.Drawing.Color.Yellow
        Me.LblFechaDos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblFechaDos.Location = New System.Drawing.Point(862, 32)
        Me.LblFechaDos.Name = "LblFechaDos"
        Me.LblFechaDos.Size = New System.Drawing.Size(15, 15)
        Me.LblFechaDos.TabIndex = 41
        Me.LblFechaDos.Text = "0"
        '
        'LblHora
        '
        Me.LblHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblHora.AutoSize = True
        Me.LblHora.BackColor = System.Drawing.Color.Yellow
        Me.LblHora.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblHora.Location = New System.Drawing.Point(862, 57)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(15, 15)
        Me.LblHora.TabIndex = 42
        Me.LblHora.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(254, 83)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(691, 18)
        Me.Panel1.TabIndex = 43
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button9)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.btnVentanasAA)
        Me.Panel2.Controls.Add(Me.btnVentanasCorrediza)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(0, 32)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(251, 590)
        Me.Panel2.TabIndex = 44
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(254, 29)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 72)
        Me.Panel3.TabIndex = 44
        '
        'HOME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 634)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblHora)
        Me.Controls.Add(Me.LblFechaDos)
        Me.Controls.Add(Me.LblPrinter)
        Me.Controls.Add(Me.LblIp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblNivel)
        Me.Controls.Add(Me.LblUsuarios)
        Me.Controls.Add(Me.LblPc)
        Me.Controls.Add(Me.TxtDPc)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.tbNivel)
        Me.Controls.Add(Me.TxtdHora)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.tbHora)
        Me.Controls.Add(Me.TxtDPrinter)
        Me.Controls.Add(Me.TxtDfecha)
        Me.Controls.Add(Me.TxtPc)
        Me.Controls.Add(Me.TxtDip)
        Me.Controls.Add(Me.TxtIp)
        Me.Controls.Add(Me.TxtPrinter)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(970, 673)
        Me.Name = "HOME"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "      "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVentanasAA As Button
    Friend WithEvents btnVentanasCorrediza As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ADMINISTRACIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CREARUSUARIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BUSCARCLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CREARCLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IMPRIMIRLISTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REPORTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VENTANASAAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VENTCORREDISAZToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ELIMINARUSUARIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MODIFICARUSUARIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button9 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxtIp As TextBox
    Friend WithEvents TxtPrinter As TextBox
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxtDip As TextBox
    Friend WithEvents TxtPc As TextBox
    Friend WithEvents TxtDfecha As TextBox
    Friend WithEvents TxtDPrinter As TextBox
    Friend WithEvents tbHora As TextBox
    Friend WithEvents LblFecha As TextBox
    Friend WithEvents TxtdHora As TextBox
    Friend WithEvents tbNivel As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tbUsuario As TextBox
    Friend WithEvents TxtDPc As TextBox
    Friend WithEvents LblPc As Label
    Friend WithEvents LblUsuarios As Label
    Friend WithEvents LblNivel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblIp As Label
    Friend WithEvents LblPrinter As Label
    Friend WithEvents LblFechaDos As Label
    Friend WithEvents LblHora As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
