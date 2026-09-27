<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPacientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblNombre = New Label()
        lblApellido = New Label()
        lblEdad = New Label()
        lblIDPaciente = New Label()
        lblTelefono = New Label()
        lblEmail = New Label()
        lblSexo = New Label()
        lblPlanMedico = New Label()
        lblFechaNac = New Label()
        txtIDPaciente = New TextBox()
        txtApellido = New TextBox()
        txtEdad = New TextBox()
        txtTelefono = New TextBox()
        txtEmail = New TextBox()
        txtNombre = New TextBox()
        cmbSexo = New ComboBox()
        cmbPlanMedico = New ComboBox()
        dtpFechaNac = New DateTimePicker()
        dgvPacientes = New DataGridView()
        BtnBuscar = New Button()
        BtnSalir = New Button()
        BtnGuardar = New Button()
        BtnNuevo = New Button()
        grpDatosPacientes = New GroupBox()
        cmbCiudad = New ComboBox()
        lblCiudad = New Label()
        grpBotonesPaciente = New GroupBox()
        grbListaPaciente = New GroupBox()
        Panel1 = New Panel()
        Label3 = New Label()
        Label1 = New Label()
        grbFiltroBusquedaPaciente = New GroupBox()
        txtFiltroNombre = New TextBox()
        txtFiltroApellido = New TextBox()
        cmbFiltroPlanMedico = New ComboBox()
        cmbFiltroSexo = New ComboBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        CType(dgvPacientes, ComponentModel.ISupportInitialize).BeginInit()
        grpDatosPacientes.SuspendLayout()
        grpBotonesPaciente.SuspendLayout()
        grbListaPaciente.SuspendLayout()
        Panel1.SuspendLayout()
        grbFiltroBusquedaPaciente.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblNombre
        ' 
        lblNombre.Font = New Font("Segoe UI", 12F)
        lblNombre.Location = New Point(18, 66)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(100, 23)
        lblNombre.TabIndex = 1
        lblNombre.Text = "Nombre:"
        ' 
        ' lblApellido
        ' 
        lblApellido.Font = New Font("Segoe UI", 12F)
        lblApellido.Location = New Point(18, 99)
        lblApellido.Name = "lblApellido"
        lblApellido.Size = New Size(100, 23)
        lblApellido.TabIndex = 2
        lblApellido.Text = "Apellido:"
        ' 
        ' lblEdad
        ' 
        lblEdad.Font = New Font("Segoe UI", 12F)
        lblEdad.Location = New Point(18, 132)
        lblEdad.Name = "lblEdad"
        lblEdad.Size = New Size(100, 23)
        lblEdad.TabIndex = 3
        lblEdad.Text = "Edad:"
        ' 
        ' lblIDPaciente
        ' 
        lblIDPaciente.Font = New Font("Segoe UI", 12F)
        lblIDPaciente.Location = New Point(18, 33)
        lblIDPaciente.Name = "lblIDPaciente"
        lblIDPaciente.Size = New Size(100, 23)
        lblIDPaciente.TabIndex = 4
        lblIDPaciente.Text = "ID Paciente:"
        ' 
        ' lblTelefono
        ' 
        lblTelefono.Font = New Font("Segoe UI", 12F)
        lblTelefono.Location = New Point(18, 197)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New Size(100, 23)
        lblTelefono.TabIndex = 5
        lblTelefono.Text = "Teléfono:"
        ' 
        ' lblEmail
        ' 
        lblEmail.Font = New Font("Segoe UI", 12F)
        lblEmail.Location = New Point(18, 228)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(100, 23)
        lblEmail.TabIndex = 6
        lblEmail.Text = "Email:"
        ' 
        ' lblSexo
        ' 
        lblSexo.Font = New Font("Segoe UI", 12F)
        lblSexo.Location = New Point(18, 165)
        lblSexo.Name = "lblSexo"
        lblSexo.Size = New Size(100, 23)
        lblSexo.TabIndex = 7
        lblSexo.Text = "Sexo:"
        ' 
        ' lblPlanMedico
        ' 
        lblPlanMedico.Font = New Font("Segoe UI", 12F)
        lblPlanMedico.Location = New Point(18, 301)
        lblPlanMedico.Name = "lblPlanMedico"
        lblPlanMedico.Size = New Size(100, 23)
        lblPlanMedico.TabIndex = 8
        lblPlanMedico.Text = "Plan Médico:"
        ' 
        ' lblFechaNac
        ' 
        lblFechaNac.Font = New Font("Segoe UI", 12F)
        lblFechaNac.Location = New Point(18, 333)
        lblFechaNac.Name = "lblFechaNac"
        lblFechaNac.Size = New Size(148, 28)
        lblFechaNac.TabIndex = 9
        lblFechaNac.Text = "Fecha Nacimiento:"
        ' 
        ' txtIDPaciente
        ' 
        txtIDPaciente.BackColor = SystemColors.Window
        txtIDPaciente.Enabled = False
        txtIDPaciente.Font = New Font("Segoe UI", 12F)
        txtIDPaciente.Location = New Point(135, 33)
        txtIDPaciente.Name = "txtIDPaciente"
        txtIDPaciente.ReadOnly = True
        txtIDPaciente.Size = New Size(74, 29)
        txtIDPaciente.TabIndex = 10
        ' 
        ' txtApellido
        ' 
        txtApellido.Font = New Font("Segoe UI", 12F)
        txtApellido.Location = New Point(135, 96)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(161, 29)
        txtApellido.TabIndex = 11
        ' 
        ' txtEdad
        ' 
        txtEdad.Font = New Font("Segoe UI", 12F)
        txtEdad.Location = New Point(135, 129)
        txtEdad.Name = "txtEdad"
        txtEdad.Size = New Size(46, 29)
        txtEdad.TabIndex = 12
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Font = New Font("Segoe UI", 12F)
        txtTelefono.Location = New Point(135, 194)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(161, 29)
        txtTelefono.TabIndex = 13
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 12F)
        txtEmail.Location = New Point(135, 225)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(161, 29)
        txtEmail.TabIndex = 14
        ' 
        ' txtNombre
        ' 
        txtNombre.Font = New Font("Segoe UI", 12F)
        txtNombre.Location = New Point(135, 63)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(161, 29)
        txtNombre.TabIndex = 18
        ' 
        ' cmbSexo
        ' 
        cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSexo.Font = New Font("Segoe UI", 12F)
        cmbSexo.FormattingEnabled = True
        cmbSexo.Items.AddRange(New Object() {"M", "F"})
        cmbSexo.Location = New Point(135, 162)
        cmbSexo.Name = "cmbSexo"
        cmbSexo.Size = New Size(46, 29)
        cmbSexo.TabIndex = 19
        ' 
        ' cmbPlanMedico
        ' 
        cmbPlanMedico.Font = New Font("Segoe UI", 12F)
        cmbPlanMedico.FormattingEnabled = True
        cmbPlanMedico.Items.AddRange(New Object() {"Triple S", "MMM", "First Medical", "Menonita", "Ninguno"})
        cmbPlanMedico.Location = New Point(135, 298)
        cmbPlanMedico.Name = "cmbPlanMedico"
        cmbPlanMedico.Size = New Size(161, 29)
        cmbPlanMedico.TabIndex = 20
        ' 
        ' dtpFechaNac
        ' 
        dtpFechaNac.Font = New Font("Segoe UI", 12F)
        dtpFechaNac.Format = DateTimePickerFormat.Short
        dtpFechaNac.Location = New Point(172, 333)
        dtpFechaNac.Name = "dtpFechaNac"
        dtpFechaNac.Size = New Size(133, 29)
        dtpFechaNac.TabIndex = 21
        ' 
        ' dgvPacientes
        ' 
        dgvPacientes.AllowUserToAddRows = False
        dgvPacientes.AllowUserToDeleteRows = False
        dgvPacientes.BackgroundColor = SystemColors.ControlLightLight
        dgvPacientes.BorderStyle = BorderStyle.Fixed3D
        dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPacientes.Location = New Point(6, 32)
        dgvPacientes.Name = "dgvPacientes"
        dgvPacientes.ReadOnly = True
        dgvPacientes.RowHeadersVisible = False
        dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPacientes.Size = New Size(917, 182)
        dgvPacientes.TabIndex = 22
        ' 
        ' BtnBuscar
        ' 
        BtnBuscar.Font = New Font("Segoe UI", 12F)
        BtnBuscar.Location = New Point(105, 174)
        BtnBuscar.Name = "BtnBuscar"
        BtnBuscar.Size = New Size(82, 40)
        BtnBuscar.TabIndex = 31
        BtnBuscar.Text = "Buscar"
        BtnBuscar.UseVisualStyleBackColor = True
        ' 
        ' BtnSalir
        ' 
        BtnSalir.Font = New Font("Segoe UI", 12F)
        BtnSalir.Location = New Point(18, 92)
        BtnSalir.Name = "BtnSalir"
        BtnSalir.Size = New Size(82, 40)
        BtnSalir.TabIndex = 29
        BtnSalir.Text = "Salir"
        BtnSalir.UseVisualStyleBackColor = True
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.Font = New Font("Segoe UI", 12F)
        BtnGuardar.Location = New Point(105, 46)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(82, 40)
        BtnGuardar.TabIndex = 28
        BtnGuardar.Text = "Guardar"
        BtnGuardar.UseVisualStyleBackColor = True
        ' 
        ' BtnNuevo
        ' 
        BtnNuevo.Font = New Font("Segoe UI", 12F)
        BtnNuevo.Location = New Point(17, 46)
        BtnNuevo.Name = "BtnNuevo"
        BtnNuevo.Size = New Size(82, 40)
        BtnNuevo.TabIndex = 27
        BtnNuevo.Text = "Nuevo"
        BtnNuevo.UseVisualStyleBackColor = True
        ' 
        ' grpDatosPacientes
        ' 
        grpDatosPacientes.BackColor = SystemColors.ControlLight
        grpDatosPacientes.Controls.Add(cmbCiudad)
        grpDatosPacientes.Controls.Add(txtIDPaciente)
        grpDatosPacientes.Controls.Add(lblNombre)
        grpDatosPacientes.Controls.Add(lblCiudad)
        grpDatosPacientes.Controls.Add(lblApellido)
        grpDatosPacientes.Controls.Add(lblEdad)
        grpDatosPacientes.Controls.Add(lblIDPaciente)
        grpDatosPacientes.Controls.Add(lblTelefono)
        grpDatosPacientes.Controls.Add(lblEmail)
        grpDatosPacientes.Controls.Add(dtpFechaNac)
        grpDatosPacientes.Controls.Add(lblSexo)
        grpDatosPacientes.Controls.Add(cmbPlanMedico)
        grpDatosPacientes.Controls.Add(lblPlanMedico)
        grpDatosPacientes.Controls.Add(cmbSexo)
        grpDatosPacientes.Controls.Add(lblFechaNac)
        grpDatosPacientes.Controls.Add(txtNombre)
        grpDatosPacientes.Controls.Add(txtApellido)
        grpDatosPacientes.Controls.Add(txtEmail)
        grpDatosPacientes.Controls.Add(txtEdad)
        grpDatosPacientes.Controls.Add(txtTelefono)
        grpDatosPacientes.Font = New Font("Segoe UI", 10F)
        grpDatosPacientes.Location = New Point(69, 121)
        grpDatosPacientes.Name = "grpDatosPacientes"
        grpDatosPacientes.Size = New Size(357, 388)
        grpDatosPacientes.TabIndex = 32
        grpDatosPacientes.TabStop = False
        grpDatosPacientes.Text = "Datos del Paciente"
        ' 
        ' cmbCiudad
        ' 
        cmbCiudad.Font = New Font("Segoe UI", 12F)
        cmbCiudad.FormattingEnabled = True
        cmbCiudad.Items.AddRange(New Object() {"Adjuntas", "Aguada", "Aguadilla", "Aguas Buenas", "Aibonito", "Añasco", "Arecibo", "Arroyo", "Barceloneta", "Barranquitas", "Bayamón", "Cabo Rojo", "Caguas", "Camuy", "Canóvanas", "Carolina", "Cataño", "Cayey", "Ceiba", "Ciales", "Cidra", "Coamo", "Comerío", "Corozal", "Culebra", "Dorado", "Fajardo", "Florida", "Guánica", "Guayama", "Guayanilla", "Guaynabo", "Gurabo", "Hatillo", "Hormigueros", "Humacao", "Isabela", "Jayuya", "Juana Díaz", "Juncos", "Lajas", "Lares", "Las Marías", "Las Piedras", "Loíza", "Luquillo", "Manatí", "Maricao", "Maunabo", "Mayagüez", "Moca", "Morovis", "Naguabo", "Naranjito", "Orocovis", "Patillas", "Peñuelas", "Ponce", "Quebradillas", "Rincón", "Río Grande", "Sabana Grande", "Salinas", "San Germán", "San Juan", "San Lorenzo", "San Sebastián", "Santa Isabel", "Toa Alta", "Toa Baja", "Trujillo Alto", "Utuado", "Vega Alta", "Vega Baja", "Vieques", "Villalba", "Yabucoa", "Yauco"})
        cmbCiudad.Location = New Point(135, 259)
        cmbCiudad.Name = "cmbCiudad"
        cmbCiudad.Size = New Size(121, 29)
        cmbCiudad.TabIndex = 23
        ' 
        ' lblCiudad
        ' 
        lblCiudad.Font = New Font("Segoe UI", 12F)
        lblCiudad.Location = New Point(18, 262)
        lblCiudad.Name = "lblCiudad"
        lblCiudad.Size = New Size(100, 23)
        lblCiudad.TabIndex = 22
        lblCiudad.Text = "Ciudad:"
        ' 
        ' grpBotonesPaciente
        ' 
        grpBotonesPaciente.BackColor = SystemColors.ControlLight
        grpBotonesPaciente.Controls.Add(BtnNuevo)
        grpBotonesPaciente.Controls.Add(BtnSalir)
        grpBotonesPaciente.Controls.Add(BtnGuardar)
        grpBotonesPaciente.Font = New Font("Segoe UI", 10F)
        grpBotonesPaciente.Location = New Point(503, 121)
        grpBotonesPaciente.Name = "grpBotonesPaciente"
        grpBotonesPaciente.Size = New Size(198, 138)
        grpBotonesPaciente.TabIndex = 33
        grpBotonesPaciente.TabStop = False
        grpBotonesPaciente.Text = "Operaciones"
        ' 
        ' grbListaPaciente
        ' 
        grbListaPaciente.BackColor = SystemColors.ControlLight
        grbListaPaciente.Controls.Add(dgvPacientes)
        grbListaPaciente.Font = New Font("Segoe UI", 10F)
        grbListaPaciente.Location = New Point(69, 578)
        grbListaPaciente.Name = "grbListaPaciente"
        grbListaPaciente.Size = New Size(946, 236)
        grbListaPaciente.TabIndex = 34
        grbListaPaciente.TabStop = False
        grbListaPaciente.Text = "Registro de Pacientes"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1037, 96)
        Panel1.TabIndex = 35
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label3.Location = New Point(107, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(149, 19)
        Label3.TabIndex = 2
        Label3.Text = "Módulo de Pacientes"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label1.Location = New Point(69, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(339, 25)
        Label1.TabIndex = 0
        Label1.Text = "Sistema de Gestión de Clínica Médica"
        ' 
        ' grbFiltroBusquedaPaciente
        ' 
        grbFiltroBusquedaPaciente.BackColor = SystemColors.ControlLight
        grbFiltroBusquedaPaciente.Controls.Add(txtFiltroNombre)
        grbFiltroBusquedaPaciente.Controls.Add(txtFiltroApellido)
        grbFiltroBusquedaPaciente.Controls.Add(BtnBuscar)
        grbFiltroBusquedaPaciente.Controls.Add(cmbFiltroPlanMedico)
        grbFiltroBusquedaPaciente.Controls.Add(cmbFiltroSexo)
        grbFiltroBusquedaPaciente.Controls.Add(Label6)
        grbFiltroBusquedaPaciente.Controls.Add(Label5)
        grbFiltroBusquedaPaciente.Controls.Add(Label4)
        grbFiltroBusquedaPaciente.Controls.Add(Label2)
        grbFiltroBusquedaPaciente.Font = New Font("Segoe UI", 10F)
        grbFiltroBusquedaPaciente.Location = New Point(503, 318)
        grbFiltroBusquedaPaciente.Name = "grbFiltroBusquedaPaciente"
        grbFiltroBusquedaPaciente.Size = New Size(290, 235)
        grbFiltroBusquedaPaciente.TabIndex = 36
        grbFiltroBusquedaPaciente.TabStop = False
        grbFiltroBusquedaPaciente.Text = "Filtro de Busqueda"
        ' 
        ' txtFiltroNombre
        ' 
        txtFiltroNombre.Font = New Font("Segoe UI", 12F)
        txtFiltroNombre.Location = New Point(114, 33)
        txtFiltroNombre.Name = "txtFiltroNombre"
        txtFiltroNombre.Size = New Size(161, 29)
        txtFiltroNombre.TabIndex = 32
        ' 
        ' txtFiltroApellido
        ' 
        txtFiltroApellido.Font = New Font("Segoe UI", 12F)
        txtFiltroApellido.Location = New Point(114, 71)
        txtFiltroApellido.Name = "txtFiltroApellido"
        txtFiltroApellido.Size = New Size(161, 29)
        txtFiltroApellido.TabIndex = 22
        ' 
        ' cmbFiltroPlanMedico
        ' 
        cmbFiltroPlanMedico.Font = New Font("Segoe UI", 12F)
        cmbFiltroPlanMedico.FormattingEnabled = True
        cmbFiltroPlanMedico.Items.AddRange(New Object() {"Triple S", "MMM", "First Medical", "Menonita", "Ninguno"})
        cmbFiltroPlanMedico.Location = New Point(114, 139)
        cmbFiltroPlanMedico.Name = "cmbFiltroPlanMedico"
        cmbFiltroPlanMedico.Size = New Size(161, 29)
        cmbFiltroPlanMedico.TabIndex = 21
        ' 
        ' cmbFiltroSexo
        ' 
        cmbFiltroSexo.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFiltroSexo.Font = New Font("Segoe UI", 12F)
        cmbFiltroSexo.FormattingEnabled = True
        cmbFiltroSexo.Items.AddRange(New Object() {"M", "F"})
        cmbFiltroSexo.Location = New Point(114, 105)
        cmbFiltroSexo.Name = "cmbFiltroSexo"
        cmbFiltroSexo.Size = New Size(46, 29)
        cmbFiltroSexo.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(17, 142)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 21)
        Label6.TabIndex = 3
        Label6.Text = "Plan Médico:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(17, 108)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 21)
        Label5.TabIndex = 2
        Label5.Text = "Sexo:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(18, 74)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 21)
        Label4.TabIndex = 1
        Label4.Text = "Apellido:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(17, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 21)
        Label2.TabIndex = 0
        Label2.Text = "Nombre:"
        ' 
        ' frmPacientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(1037, 861)
        Controls.Add(grbFiltroBusquedaPaciente)
        Controls.Add(Panel1)
        Controls.Add(grbListaPaciente)
        Controls.Add(grpBotonesPaciente)
        Controls.Add(grpDatosPacientes)
        Name = "frmPacientes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmPacientes"
        CType(dgvPacientes, ComponentModel.ISupportInitialize).EndInit()
        grpDatosPacientes.ResumeLayout(False)
        grpDatosPacientes.PerformLayout()
        grpBotonesPaciente.ResumeLayout(False)
        grbListaPaciente.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        grbFiltroBusquedaPaciente.ResumeLayout(False)
        grbFiltroBusquedaPaciente.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblEdad As Label
    Friend WithEvents lblIDPaciente As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblPlanMedico As Label
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents txtIDPaciente As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents cmbPlanMedico As ComboBox
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents dgvPacientes As DataGridView
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents grpDatosPacientes As GroupBox
    Friend WithEvents grpBotonesPaciente As GroupBox
    Friend WithEvents grbListaPaciente As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCiudad As ComboBox
    Friend WithEvents lblCiudad As Label
    Friend WithEvents grbFiltroBusquedaPaciente As GroupBox
    Friend WithEvents txtFiltroApellido As TextBox
    Friend WithEvents cmbFiltroPlanMedico As ComboBox
    Friend WithEvents cmbFiltroSexo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFiltroNombre As TextBox
End Class
