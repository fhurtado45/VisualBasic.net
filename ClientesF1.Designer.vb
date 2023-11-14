<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClientesF1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientesF1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.cltInclusion = New System.Windows.Forms.TabPage()
        Me.inclMensaje = New System.Windows.Forms.Label()
        Me.btnCancelarIncl = New System.Windows.Forms.Button()
        Me.btnAceptarIncl = New System.Windows.Forms.Button()
        Me.inclLabelID = New System.Windows.Forms.Label()
        Me.inclNroID = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.inclPassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.inclLogin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.inclRamo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.inclFechaInclusion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.inclNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cltActualizacion = New System.Windows.Forms.TabPage()
        Me.modMensaje = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.modIdCliente = New System.Windows.Forms.TextBox()
        Me.btnCancelarMod = New System.Windows.Forms.Button()
        Me.btnAceptarMod = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.modPassword = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.modLogin = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.modRamo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.modFecha = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.modNombre = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cltEliminar = New System.Windows.Forms.TabPage()
        Me.cltConsultar = New System.Windows.Forms.TabPage()
        Me.conBtnLimpiar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.consBtnRefrescar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.cltInclusion.SuspendLayout()
        Me.cltActualizacion.SuspendLayout()
        Me.cltEliminar.SuspendLayout()
        Me.cltConsultar.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.cltInclusion)
        Me.TabControl1.Controls.Add(Me.cltActualizacion)
        Me.TabControl1.Controls.Add(Me.cltEliminar)
        Me.TabControl1.Controls.Add(Me.cltConsultar)
        Me.TabControl1.Location = New System.Drawing.Point(137, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(515, 448)
        Me.TabControl1.TabIndex = 0
        '
        'cltInclusion
        '
        Me.cltInclusion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cltInclusion.Controls.Add(Me.inclMensaje)
        Me.cltInclusion.Controls.Add(Me.btnCancelarIncl)
        Me.cltInclusion.Controls.Add(Me.btnAceptarIncl)
        Me.cltInclusion.Controls.Add(Me.inclLabelID)
        Me.cltInclusion.Controls.Add(Me.inclNroID)
        Me.cltInclusion.Controls.Add(Me.Label8)
        Me.cltInclusion.Controls.Add(Me.inclPassword)
        Me.cltInclusion.Controls.Add(Me.Label7)
        Me.cltInclusion.Controls.Add(Me.inclLogin)
        Me.cltInclusion.Controls.Add(Me.Label6)
        Me.cltInclusion.Controls.Add(Me.inclRamo)
        Me.cltInclusion.Controls.Add(Me.Label5)
        Me.cltInclusion.Controls.Add(Me.inclFechaInclusion)
        Me.cltInclusion.Controls.Add(Me.Label4)
        Me.cltInclusion.Controls.Add(Me.inclNombre)
        Me.cltInclusion.Controls.Add(Me.Label3)
        Me.cltInclusion.Location = New System.Drawing.Point(4, 22)
        Me.cltInclusion.Name = "cltInclusion"
        Me.cltInclusion.Padding = New System.Windows.Forms.Padding(3)
        Me.cltInclusion.Size = New System.Drawing.Size(507, 422)
        Me.cltInclusion.TabIndex = 0
        Me.cltInclusion.Text = "Incluir"
        Me.cltInclusion.UseVisualStyleBackColor = True
        '
        'inclMensaje
        '
        Me.inclMensaje.AutoSize = True
        Me.inclMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inclMensaje.ForeColor = System.Drawing.Color.Blue
        Me.inclMensaje.Location = New System.Drawing.Point(34, 385)
        Me.inclMensaje.Name = "inclMensaje"
        Me.inclMensaje.Size = New System.Drawing.Size(63, 16)
        Me.inclMensaje.TabIndex = 15
        Me.inclMensaje.Text = "Label11"
        '
        'btnCancelarIncl
        '
        Me.btnCancelarIncl.Location = New System.Drawing.Point(261, 350)
        Me.btnCancelarIncl.Name = "btnCancelarIncl"
        Me.btnCancelarIncl.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarIncl.TabIndex = 14
        Me.btnCancelarIncl.Text = "Cancelar"
        Me.btnCancelarIncl.UseVisualStyleBackColor = True
        '
        'btnAceptarIncl
        '
        Me.btnAceptarIncl.Location = New System.Drawing.Point(261, 318)
        Me.btnAceptarIncl.Name = "btnAceptarIncl"
        Me.btnAceptarIncl.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarIncl.TabIndex = 13
        Me.btnAceptarIncl.Text = "Aceptar"
        Me.btnAceptarIncl.UseVisualStyleBackColor = True
        '
        'inclLabelID
        '
        Me.inclLabelID.AutoSize = True
        Me.inclLabelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inclLabelID.Location = New System.Drawing.Point(40, 75)
        Me.inclLabelID.Name = "inclLabelID"
        Me.inclLabelID.Size = New System.Drawing.Size(214, 16)
        Me.inclLabelID.TabIndex = 12
        Me.inclLabelID.Text = "Registrado con el número ======>"
        '
        'inclNroID
        '
        Me.inclNroID.AutoSize = True
        Me.inclNroID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inclNroID.Location = New System.Drawing.Point(264, 69)
        Me.inclNroID.Name = "inclNroID"
        Me.inclNroID.Size = New System.Drawing.Size(21, 24)
        Me.inclNroID.TabIndex = 11
        Me.inclNroID.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Password"
        '
        'inclPassword
        '
        Me.inclPassword.Location = New System.Drawing.Point(37, 318)
        Me.inclPassword.Name = "inclPassword"
        Me.inclPassword.Size = New System.Drawing.Size(152, 20)
        Me.inclPassword.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Login"
        '
        'inclLogin
        '
        Me.inclLogin.Location = New System.Drawing.Point(37, 254)
        Me.inclLogin.Name = "inclLogin"
        Me.inclLogin.Size = New System.Drawing.Size(298, 20)
        Me.inclLogin.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(160, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Ramo"
        '
        'inclRamo
        '
        Me.inclRamo.Location = New System.Drawing.Point(157, 192)
        Me.inclRamo.Name = "inclRamo"
        Me.inclRamo.Size = New System.Drawing.Size(178, 20)
        Me.inclRamo.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha de Inclusión"
        '
        'inclFechaInclusion
        '
        Me.inclFechaInclusion.Location = New System.Drawing.Point(37, 193)
        Me.inclFechaInclusion.Name = "inclFechaInclusion"
        Me.inclFechaInclusion.Size = New System.Drawing.Size(100, 20)
        Me.inclFechaInclusion.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nombre del Cliente"
        '
        'inclNombre
        '
        Me.inclNombre.Location = New System.Drawing.Point(37, 130)
        Me.inclNombre.Name = "inclNombre"
        Me.inclNombre.Size = New System.Drawing.Size(299, 20)
        Me.inclNombre.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(32, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 39)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Inclusión de Clientes"
        '
        'cltActualizacion
        '
        Me.cltActualizacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cltActualizacion.Controls.Add(Me.modMensaje)
        Me.cltActualizacion.Controls.Add(Me.Label9)
        Me.cltActualizacion.Controls.Add(Me.modIdCliente)
        Me.cltActualizacion.Controls.Add(Me.btnCancelarMod)
        Me.cltActualizacion.Controls.Add(Me.btnAceptarMod)
        Me.cltActualizacion.Controls.Add(Me.Label12)
        Me.cltActualizacion.Controls.Add(Me.modPassword)
        Me.cltActualizacion.Controls.Add(Me.Label13)
        Me.cltActualizacion.Controls.Add(Me.modLogin)
        Me.cltActualizacion.Controls.Add(Me.Label14)
        Me.cltActualizacion.Controls.Add(Me.modRamo)
        Me.cltActualizacion.Controls.Add(Me.Label15)
        Me.cltActualizacion.Controls.Add(Me.modFecha)
        Me.cltActualizacion.Controls.Add(Me.Label16)
        Me.cltActualizacion.Controls.Add(Me.modNombre)
        Me.cltActualizacion.Controls.Add(Me.Label17)
        Me.cltActualizacion.Location = New System.Drawing.Point(4, 22)
        Me.cltActualizacion.Name = "cltActualizacion"
        Me.cltActualizacion.Padding = New System.Windows.Forms.Padding(3)
        Me.cltActualizacion.Size = New System.Drawing.Size(507, 422)
        Me.cltActualizacion.TabIndex = 1
        Me.cltActualizacion.Text = "Modificar"
        Me.cltActualizacion.UseVisualStyleBackColor = True
        '
        'modMensaje
        '
        Me.modMensaje.AutoSize = True
        Me.modMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modMensaje.ForeColor = System.Drawing.Color.Blue
        Me.modMensaje.Location = New System.Drawing.Point(34, 385)
        Me.modMensaje.Name = "modMensaje"
        Me.modMensaje.Size = New System.Drawing.Size(63, 16)
        Me.modMensaje.TabIndex = 32
        Me.modMensaje.Text = "Label11"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(39, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 16)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Identificación del Cliente:"
        '
        'modIdCliente
        '
        Me.modIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modIdCliente.Location = New System.Drawing.Point(196, 76)
        Me.modIdCliente.Name = "modIdCliente"
        Me.modIdCliente.Size = New System.Drawing.Size(57, 22)
        Me.modIdCliente.TabIndex = 30
        '
        'btnCancelarMod
        '
        Me.btnCancelarMod.Location = New System.Drawing.Point(261, 350)
        Me.btnCancelarMod.Name = "btnCancelarMod"
        Me.btnCancelarMod.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarMod.TabIndex = 29
        Me.btnCancelarMod.Text = "Cancelar"
        Me.btnCancelarMod.UseVisualStyleBackColor = True
        '
        'btnAceptarMod
        '
        Me.btnAceptarMod.Location = New System.Drawing.Point(261, 318)
        Me.btnAceptarMod.Name = "btnAceptarMod"
        Me.btnAceptarMod.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarMod.TabIndex = 28
        Me.btnAceptarMod.Text = "Aceptar"
        Me.btnAceptarMod.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(40, 303)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Password"
        '
        'modPassword
        '
        Me.modPassword.Location = New System.Drawing.Point(37, 318)
        Me.modPassword.Name = "modPassword"
        Me.modPassword.Size = New System.Drawing.Size(152, 20)
        Me.modPassword.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(40, 239)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Login"
        '
        'modLogin
        '
        Me.modLogin.Location = New System.Drawing.Point(37, 254)
        Me.modLogin.Name = "modLogin"
        Me.modLogin.Size = New System.Drawing.Size(298, 20)
        Me.modLogin.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(160, 177)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Ramo"
        '
        'modRamo
        '
        Me.modRamo.Location = New System.Drawing.Point(157, 192)
        Me.modRamo.Name = "modRamo"
        Me.modRamo.Size = New System.Drawing.Size(178, 20)
        Me.modRamo.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(40, 178)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Fecha de Inclusión"
        '
        'modFecha
        '
        Me.modFecha.Location = New System.Drawing.Point(37, 193)
        Me.modFecha.Name = "modFecha"
        Me.modFecha.Size = New System.Drawing.Size(100, 20)
        Me.modFecha.TabIndex = 18
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(40, 115)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 13)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Nombre del Cliente"
        '
        'modNombre
        '
        Me.modNombre.Location = New System.Drawing.Point(37, 130)
        Me.modNombre.Name = "modNombre"
        Me.modNombre.Size = New System.Drawing.Size(299, 20)
        Me.modNombre.TabIndex = 16
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Blue
        Me.Label17.Location = New System.Drawing.Point(32, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(271, 39)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Modificación de Clientes"
        '
        'cltEliminar
        '
        Me.cltEliminar.Controls.Add(Me.PictureBox1)
        Me.cltEliminar.Location = New System.Drawing.Point(4, 22)
        Me.cltEliminar.Name = "cltEliminar"
        Me.cltEliminar.Padding = New System.Windows.Forms.Padding(3)
        Me.cltEliminar.Size = New System.Drawing.Size(507, 422)
        Me.cltEliminar.TabIndex = 2
        Me.cltEliminar.Text = "Eliminar"
        Me.cltEliminar.UseVisualStyleBackColor = True
        '
        'cltConsultar
        '
        Me.cltConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cltConsultar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cltConsultar.Controls.Add(Me.conBtnLimpiar)
        Me.cltConsultar.Controls.Add(Me.Label10)
        Me.cltConsultar.Controls.Add(Me.consBtnRefrescar)
        Me.cltConsultar.Controls.Add(Me.TextBox1)
        Me.cltConsultar.Controls.Add(Me.dgvClientes)
        Me.cltConsultar.Location = New System.Drawing.Point(4, 22)
        Me.cltConsultar.Name = "cltConsultar"
        Me.cltConsultar.Padding = New System.Windows.Forms.Padding(3)
        Me.cltConsultar.Size = New System.Drawing.Size(507, 422)
        Me.cltConsultar.TabIndex = 3
        Me.cltConsultar.Text = "Consultar"
        Me.cltConsultar.UseVisualStyleBackColor = True
        '
        'conBtnLimpiar
        '
        Me.conBtnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.conBtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.conBtnLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.conBtnLimpiar.Location = New System.Drawing.Point(303, 379)
        Me.conBtnLimpiar.Name = "conBtnLimpiar"
        Me.conBtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.conBtnLimpiar.TabIndex = 4
        Me.conBtnLimpiar.Text = "Limpiar"
        Me.conBtnLimpiar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 18)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Información de Clientes"
        '
        'consBtnRefrescar
        '
        Me.consBtnRefrescar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.consBtnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.consBtnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.consBtnRefrescar.ForeColor = System.Drawing.Color.Navy
        Me.consBtnRefrescar.Location = New System.Drawing.Point(421, 379)
        Me.consBtnRefrescar.Name = "consBtnRefrescar"
        Me.consBtnRefrescar.Size = New System.Drawing.Size(75, 23)
        Me.consBtnRefrescar.TabIndex = 2
        Me.consBtnRefrescar.Text = "Refrescar"
        Me.consBtnRefrescar.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 383)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'dgvClientes
        '
        Me.dgvClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(6, 36)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(490, 326)
        Me.dgvClientes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(2, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Proceso de"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 42)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Clientes"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(468, 374)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ClientesF1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 473)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ClientesF1"
        Me.Text = "CLIENTES"
        Me.TabControl1.ResumeLayout(False)
        Me.cltInclusion.ResumeLayout(False)
        Me.cltInclusion.PerformLayout()
        Me.cltActualizacion.ResumeLayout(False)
        Me.cltActualizacion.PerformLayout()
        Me.cltEliminar.ResumeLayout(False)
        Me.cltConsultar.ResumeLayout(False)
        Me.cltConsultar.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents cltInclusion As TabPage
    Friend WithEvents cltActualizacion As TabPage
    Friend WithEvents cltEliminar As TabPage
    Friend WithEvents cltConsultar As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents inclPassword As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents inclLogin As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents inclRamo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents inclFechaInclusion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents inclNombre As TextBox
    Friend WithEvents inclLabelID As Label
    Friend WithEvents inclNroID As Label
    Friend WithEvents btnCancelarIncl As Button
    Friend WithEvents btnAceptarIncl As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents modIdCliente As TextBox
    Friend WithEvents btnCancelarMod As Button
    Friend WithEvents btnAceptarMod As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents modPassword As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents modLogin As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents modRamo As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents modFecha As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents modNombre As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents inclMensaje As Label
    Friend WithEvents modMensaje As Label
    Friend WithEvents consBtnRefrescar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents conBtnLimpiar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
