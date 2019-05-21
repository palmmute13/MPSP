<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LOGIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        Me.ButtonEntrar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.tbContrasena = New System.Windows.Forms.TextBox()
        Me.CREADO = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.lbHora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonEntrar
        '
        Me.ButtonEntrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEntrar.Location = New System.Drawing.Point(305, 360)
        Me.ButtonEntrar.Name = "ButtonEntrar"
        Me.ButtonEntrar.Size = New System.Drawing.Size(88, 30)
        Me.ButtonEntrar.TabIndex = 3
        Me.ButtonEntrar.Text = "ENTRAR"
        Me.ButtonEntrar.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSalir.Location = New System.Drawing.Point(211, 360)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(88, 30)
        Me.ButtonSalir.TabIndex = 4
        Me.ButtonSalir.Text = "SALIR"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(125, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'tbUsuario
        '
        Me.tbUsuario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tbUsuario.Location = New System.Drawing.Point(84, 212)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(237, 22)
        Me.tbUsuario.TabIndex = 1
        '
        'tbContrasena
        '
        Me.tbContrasena.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tbContrasena.Location = New System.Drawing.Point(84, 240)
        Me.tbContrasena.Name = "tbContrasena"
        Me.tbContrasena.Size = New System.Drawing.Size(237, 22)
        Me.tbContrasena.TabIndex = 2
        '
        'CREADO
        '
        Me.CREADO.AutoSize = True
        Me.CREADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CREADO.Location = New System.Drawing.Point(140, 9)
        Me.CREADO.Name = "CREADO"
        Me.CREADO.Size = New System.Drawing.Size(119, 12)
        Me.CREADO.TabIndex = 4
        Me.CREADO.Text = "Creado por Pedro A. Peralta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "829-981-3829"
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFecha.Location = New System.Drawing.Point(197, 197)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(15, 12)
        Me.lbFecha.TabIndex = 7
        Me.lbFecha.Text = "xx"
        '
        'lbHora
        '
        Me.lbHora.AutoSize = True
        Me.lbHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHora.Location = New System.Drawing.Point(140, 197)
        Me.lbHora.Name = "lbHora"
        Me.lbHora.Size = New System.Drawing.Size(41, 12)
        Me.lbHora.TabIndex = 6
        Me.lbHora.Text = "00:00:00"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(84, 268)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(237, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(405, 402)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lbFecha)
        Me.Controls.Add(Me.lbHora)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CREADO)
        Me.Controls.Add(Me.tbContrasena)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonEntrar)
        Me.MaximumSize = New System.Drawing.Size(421, 441)
        Me.MinimumSize = New System.Drawing.Size(421, 441)
        Me.Name = "LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                               .....::::: BIENVENIDO AL SISTEMA :::::....."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonEntrar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tbUsuario As TextBox
    Friend WithEvents tbContrasena As TextBox
    Friend WithEvents CREADO As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbFecha As Label
    Friend WithEvents lbHora As Label
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents ComboBox1 As ComboBox
End Class
