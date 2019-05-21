<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ELIMINAR_USUARIO
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
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbCedula = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbContra = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbNIvelUsuario = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbFecha = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbEmail
        '
        Me.tbEmail.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.Location = New System.Drawing.Point(155, 179)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(8)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(198, 23)
        Me.tbEmail.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(92, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "EMAIL:"
        '
        'tbTelefono
        '
        Me.tbTelefono.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefono.Location = New System.Drawing.Point(155, 140)
        Me.tbTelefono.Margin = New System.Windows.Forms.Padding(8)
        Me.tbTelefono.MaxLength = 10
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(87, 23)
        Me.tbTelefono.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "TELEFONO:"
        '
        'tbCedula
        '
        Me.tbCedula.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCedula.Location = New System.Drawing.Point(155, 101)
        Me.tbCedula.Margin = New System.Windows.Forms.Padding(8)
        Me.tbCedula.MaxLength = 11
        Me.tbCedula.Name = "tbCedula"
        Me.tbCedula.Size = New System.Drawing.Size(100, 23)
        Me.tbCedula.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(77, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "CEDULA:"
        '
        'tbApellido
        '
        Me.tbApellido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellido.Location = New System.Drawing.Point(155, 62)
        Me.tbApellido.Margin = New System.Windows.Forms.Padding(8)
        Me.tbApellido.Name = "tbApellido"
        Me.tbApellido.Size = New System.Drawing.Size(198, 23)
        Me.tbApellido.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "APELLIDOS:"
        '
        'tbNombre
        '
        Me.tbNombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(155, 23)
        Me.tbNombre.Margin = New System.Windows.Forms.Padding(8)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(198, 23)
        Me.tbNombre.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "NOMBRES:"
        '
        'tbContra
        '
        Me.tbContra.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbContra.Location = New System.Drawing.Point(155, 257)
        Me.tbContra.Margin = New System.Windows.Forms.Padding(8)
        Me.tbContra.Name = "tbContra"
        Me.tbContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.tbContra.Size = New System.Drawing.Size(198, 23)
        Me.tbContra.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(40, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 15)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "CONTRASEÑA:"
        '
        'tbUsuario
        '
        Me.tbUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsuario.Location = New System.Drawing.Point(155, 218)
        Me.tbUsuario.Margin = New System.Windows.Forms.Padding(8)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(198, 23)
        Me.tbUsuario.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(72, 221)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 15)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "USUARIO:"
        '
        'tbNIvelUsuario
        '
        Me.tbNIvelUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNIvelUsuario.Location = New System.Drawing.Point(155, 296)
        Me.tbNIvelUsuario.Margin = New System.Windows.Forms.Padding(8)
        Me.tbNIvelUsuario.Name = "tbNIvelUsuario"
        Me.tbNIvelUsuario.Size = New System.Drawing.Size(198, 23)
        Me.tbNIvelUsuario.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 299)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 15)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "NIVEL DE USUARIO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 15)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "FECHA CREACION:"
        '
        'tbFecha
        '
        Me.tbFecha.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFecha.Location = New System.Drawing.Point(155, 335)
        Me.tbFecha.Margin = New System.Windows.Forms.Padding(8)
        Me.tbFecha.Name = "tbFecha"
        Me.tbFecha.Size = New System.Drawing.Size(198, 23)
        Me.tbFecha.TabIndex = 35
        '
        'ELIMINAR_USUARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 497)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbFecha)
        Me.Controls.Add(Me.tbContra)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbNIvelUsuario)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbTelefono)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbCedula)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbApellido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ELIMINAR_USUARIO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ELIMINAR_USUARIO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected Friend WithEvents tbEmail As TextBox
    Protected Friend WithEvents Label5 As Label
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbCedula As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbContra As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbUsuario As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbNIvelUsuario As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbFecha As TextBox
End Class
