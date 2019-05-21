<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USER_PASS
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cbNivelUsuario = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtConfirmar = New System.Windows.Forms.TextBox()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUser_Pass = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbNivelUsuario
        '
        Me.cbNivelUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.cbNivelUsuario.FormattingEnabled = True
        Me.cbNivelUsuario.Items.AddRange(New Object() {"Administrador", "Supervisor", "Vendedor"})
        Me.cbNivelUsuario.Location = New System.Drawing.Point(116, 141)
        Me.cbNivelUsuario.Name = "cbNivelUsuario"
        Me.cbNivelUsuario.Size = New System.Drawing.Size(282, 23)
        Me.cbNivelUsuario.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "CONTRASEÑA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "NIVEL:"
        '
        'txtConfirmar
        '
        Me.txtConfirmar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmar.Location = New System.Drawing.Point(116, 100)
        Me.txtConfirmar.Name = "txtConfirmar"
        Me.txtConfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.txtConfirmar.Size = New System.Drawing.Size(282, 23)
        Me.txtConfirmar.TabIndex = 13
        '
        'txtContra
        '
        Me.txtContra.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContra.Location = New System.Drawing.Point(116, 71)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.txtContra.Size = New System.Drawing.Size(282, 23)
        Me.txtContra.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "CONTRASEÑA:"
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(116, 28)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(282, 23)
        Me.txtUsuario.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "USUARIO:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbNivelUsuario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtConfirmar)
        Me.GroupBox1.Controls.Add(Me.txtContra)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 209)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CREAR USUARIO"
        '
        'btnUser_Pass
        '
        Me.btnUser_Pass.Location = New System.Drawing.Point(267, 358)
        Me.btnUser_Pass.Name = "btnUser_Pass"
        Me.btnUser_Pass.Size = New System.Drawing.Size(169, 52)
        Me.btnUser_Pass.TabIndex = 20
        Me.btnUser_Pass.Text = "GUARDAR"
        Me.btnUser_Pass.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 52)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "VOLVER ATRAS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'USER_PASS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 422)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnUser_Pass)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximumSize = New System.Drawing.Size(464, 461)
        Me.MinimumSize = New System.Drawing.Size(464, 461)
        Me.Name = "USER_PASS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USER_PASS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbNivelUsuario As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtConfirmar As TextBox
    Friend WithEvents txtContra As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnUser_Pass As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Button1 As Button
End Class
