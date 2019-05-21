<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CREAR_USUARIO2
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
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbCedula = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.tbFecha = New System.Windows.Forms.TextBox()
        Me.tbHora = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdusuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContrasenaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CdusuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaingresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogtableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogdbDataSet2 = New PRINCIPAL.logdbDataSet2()
        Me.LogtableTableAdapter = New PRINCIPAL.logdbDataSet2TableAdapters.logtableTableAdapter()
        Me.btCrearUsuario = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbContra = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbNIvelUsuario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LogdbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogtableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogdbDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogdbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbNombre
        '
        Me.tbNombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(116, 42)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(198, 23)
        Me.tbNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "NOMBRES:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbEmail)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbTelefono)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbCedula)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbApellido)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(36, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 218)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRIMER PASO===> DATOS PERSONALES"
        '
        'tbEmail
        '
        Me.tbEmail.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.Location = New System.Drawing.Point(116, 158)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(249, 23)
        Me.tbEmail.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "EMAIL:"
        '
        'tbTelefono
        '
        Me.tbTelefono.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefono.Location = New System.Drawing.Point(116, 129)
        Me.tbTelefono.MaxLength = 10
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(87, 23)
        Me.tbTelefono.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "TELEFONO:"
        '
        'tbCedula
        '
        Me.tbCedula.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCedula.Location = New System.Drawing.Point(116, 100)
        Me.tbCedula.MaxLength = 11
        Me.tbCedula.Name = "tbCedula"
        Me.tbCedula.Size = New System.Drawing.Size(100, 23)
        Me.tbCedula.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "CEDULA:"
        '
        'tbApellido
        '
        Me.tbApellido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellido.Location = New System.Drawing.Point(116, 71)
        Me.tbApellido.Name = "tbApellido"
        Me.tbApellido.Size = New System.Drawing.Size(198, 23)
        Me.tbApellido.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "APELLIDOS:"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Location = New System.Drawing.Point(997, 24)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(10)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 64)
        Me.btnSalir.TabIndex = 20
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnBorrar.Location = New System.Drawing.Point(877, 24)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(10)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(100, 64)
        Me.btnBorrar.TabIndex = 21
        Me.btnBorrar.Text = "BORRAR"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Location = New System.Drawing.Point(757, 24)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(10)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 64)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(916, 38)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(100, 23)
        Me.TextBox6.TabIndex = 26
        Me.TextBox6.Text = "FECHA:"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(916, 12)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(100, 23)
        Me.TextBox7.TabIndex = 25
        Me.TextBox7.Text = "HORA:"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbFecha
        '
        Me.tbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFecha.Location = New System.Drawing.Point(1022, 37)
        Me.tbFecha.Margin = New System.Windows.Forms.Padding(3, 3, 100, 3)
        Me.tbFecha.Name = "tbFecha"
        Me.tbFecha.ReadOnly = True
        Me.tbFecha.Size = New System.Drawing.Size(100, 22)
        Me.tbFecha.TabIndex = 24
        Me.tbFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbHora
        '
        Me.tbHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHora.Location = New System.Drawing.Point(1022, 11)
        Me.tbHora.Margin = New System.Windows.Forms.Padding(3, 3, 100, 3)
        Me.tbHora.Name = "tbHora"
        Me.tbHora.ReadOnly = True
        Me.tbHora.Size = New System.Drawing.Size(100, 22)
        Me.tbHora.TabIndex = 23
        Me.tbHora.Text = "00:00:00"
        Me.tbHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(637, 24)
        Me.Button1.Margin = New System.Windows.Forms.Padding(10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 64)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "IR AL INICIO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSalir)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.btnGuardar)
        Me.GroupBox3.Controls.Add(Me.btnBorrar)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 598)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1110, 101)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdusuarioDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.ContrasenaDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.CdusuarioDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.FechaingresoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LogtableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 261)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1110, 314)
        Me.DataGridView1.TabIndex = 29
        '
        'IdusuarioDataGridViewTextBoxColumn
        '
        Me.IdusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario"
        Me.IdusuarioDataGridViewTextBoxColumn.HeaderText = "#"
        Me.IdusuarioDataGridViewTextBoxColumn.Name = "IdusuarioDataGridViewTextBoxColumn"
        Me.IdusuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdusuarioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IdusuarioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.IdusuarioDataGridViewTextBoxColumn.Width = 30
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "USUARIO"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsuarioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UsuarioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ContrasenaDataGridViewTextBoxColumn
        '
        Me.ContrasenaDataGridViewTextBoxColumn.DataPropertyName = "contrasena"
        Me.ContrasenaDataGridViewTextBoxColumn.HeaderText = "CONTRASEÑA"
        Me.ContrasenaDataGridViewTextBoxColumn.Name = "ContrasenaDataGridViewTextBoxColumn"
        Me.ContrasenaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ContrasenaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ContrasenaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "NIVEL DE USUARIO"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EstadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.EstadoDataGridViewTextBoxColumn.Width = 130
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "NOMBRES"
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        Me.NombresDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombresDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NombresDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NombresDataGridViewTextBoxColumn.Width = 120
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "APELLIDOS"
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApellidosDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ApellidosDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ApellidosDataGridViewTextBoxColumn.Width = 120
        '
        'CdusuarioDataGridViewTextBoxColumn
        '
        Me.CdusuarioDataGridViewTextBoxColumn.DataPropertyName = "cd_usuario"
        Me.CdusuarioDataGridViewTextBoxColumn.HeaderText = "CEDULA"
        Me.CdusuarioDataGridViewTextBoxColumn.Name = "CdusuarioDataGridViewTextBoxColumn"
        Me.CdusuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.CdusuarioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CdusuarioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "TELEFONO"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TelefonoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TelefonoDataGridViewTextBoxColumn.Width = 80
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "EMAIL"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.EmailDataGridViewTextBoxColumn.Width = 150
        '
        'FechaingresoDataGridViewTextBoxColumn
        '
        Me.FechaingresoDataGridViewTextBoxColumn.DataPropertyName = "fecha_ingreso"
        Me.FechaingresoDataGridViewTextBoxColumn.HeaderText = "FECHA INGRESO"
        Me.FechaingresoDataGridViewTextBoxColumn.Name = "FechaingresoDataGridViewTextBoxColumn"
        Me.FechaingresoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaingresoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FechaingresoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FechaingresoDataGridViewTextBoxColumn.Width = 180
        '
        'LogtableBindingSource
        '
        Me.LogtableBindingSource.DataMember = "logtable"
        Me.LogtableBindingSource.DataSource = Me.LogdbDataSet2
        '
        'LogdbDataSet2
        '
        Me.LogdbDataSet2.DataSetName = "logdbDataSet2"
        Me.LogdbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LogtableTableAdapter
        '
        Me.LogtableTableAdapter.ClearBeforeFill = True
        '
        'btCrearUsuario
        '
        Me.btCrearUsuario.Location = New System.Drawing.Point(146, 139)
        Me.btCrearUsuario.Name = "btCrearUsuario"
        Me.btCrearUsuario.Size = New System.Drawing.Size(198, 58)
        Me.btCrearUsuario.TabIndex = 30
        Me.btCrearUsuario.Text = "CREAR USUARIO"
        Me.btCrearUsuario.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbContra)
        Me.GroupBox2.Controls.Add(Me.btCrearUsuario)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.tbNIvelUsuario)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.tbUsuario)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(476, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(414, 218)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SEGUNDO PASO===> CREAR USUARIO"
        '
        'tbContra
        '
        Me.tbContra.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbContra.Location = New System.Drawing.Point(146, 71)
        Me.tbContra.Name = "tbContra"
        Me.tbContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.tbContra.Size = New System.Drawing.Size(198, 23)
        Me.tbContra.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "NIVEL DE USUARIO:"
        '
        'tbNIvelUsuario
        '
        Me.tbNIvelUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNIvelUsuario.Location = New System.Drawing.Point(146, 100)
        Me.tbNIvelUsuario.Name = "tbNIvelUsuario"
        Me.tbNIvelUsuario.Size = New System.Drawing.Size(198, 23)
        Me.tbNIvelUsuario.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(36, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "CONTRASEÑA:"
        '
        'tbUsuario
        '
        Me.tbUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsuario.Location = New System.Drawing.Point(146, 42)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(198, 23)
        Me.tbUsuario.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(68, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 15)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "USUARIO:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'CREAR_USUARIO2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 711)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.tbFecha)
        Me.Controls.Add(Me.tbHora)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximumSize = New System.Drawing.Size(1150, 750)
        Me.MinimumSize = New System.Drawing.Size(1150, 750)
        Me.Name = "CREAR_USUARIO2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CREAR_USUARIO2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogtableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogdbDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogdbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbCedula As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents Label2 As Label
    Protected Friend WithEvents tbEmail As TextBox
    Protected Friend WithEvents Label5 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents tbFecha As TextBox
    Friend WithEvents tbHora As TextBox
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LogdbDataSetBindingSource As BindingSource
    Friend WithEvents LogdbDataSet2 As logdbDataSet2
    Friend WithEvents LogtableBindingSource As BindingSource
    Friend WithEvents LogtableTableAdapter As logdbDataSet2TableAdapters.logtableTableAdapter
    Friend WithEvents IdusuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContrasenaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CdusuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaingresoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btCrearUsuario As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbContra As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbNIvelUsuario As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbUsuario As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
