<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignosVitales
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
        lblIDRegistro = New Label()
        lblPaciente = New Label()
        lblFecha = New Label()
        lblPresion = New Label()
        lblTemperatura = New Label()
        lblPeso = New Label()
        lblAltura = New Label()
        lblFrecuenciaCardiaca = New Label()
        dgvSignosVitales = New DataGridView()
        txtIDRegistro = New TextBox()
        dtpFecha = New DateTimePicker()
        txtPeso = New TextBox()
        txtPresion = New TextBox()
        txtTemperatura = New TextBox()
        txtAltura = New TextBox()
        txtFrecuenciaCardiaca = New TextBox()
        txtPaciente = New TextBox()
        Panel1 = New Panel()
        Label3 = New Label()
        Label1 = New Label()
        grpBotonesCitas = New GroupBox()
        BtnNuevo = New Button()
        BtnSalir = New Button()
        BtnGuardar = New Button()
        grbDatosSignosVitales = New GroupBox()
        GroupBox1 = New GroupBox()
        dtpFechaHasta = New DateTimePicker()
        dtpFechaDesde = New DateTimePicker()
        txtFiltroPaciente = New TextBox()
        BtnBuscar = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        txtIDPaciente = New TextBox()
        grbResultadosPaciente = New GroupBox()
        dgvPacientes = New DataGridView()
        grbSeleccionPacinte = New GroupBox()
        Label7 = New Label()
        txtBuscarPaciente = New TextBox()
        Label6 = New Label()
        BtnBuscarPaciente = New Button()
        CType(dgvSignosVitales, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        grpBotonesCitas.SuspendLayout()
        grbDatosSignosVitales.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        grbResultadosPaciente.SuspendLayout()
        CType(dgvPacientes, ComponentModel.ISupportInitialize).BeginInit()
        grbSeleccionPacinte.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblIDRegistro
        ' 
        lblIDRegistro.AutoSize = True
        lblIDRegistro.Font = New Font("Segoe UI", 12F)
        lblIDRegistro.Location = New Point(16, 32)
        lblIDRegistro.Name = "lblIDRegistro"
        lblIDRegistro.Size = New Size(71, 21)
        lblIDRegistro.TabIndex = 1
        lblIDRegistro.Text = "Registro:"
        ' 
        ' lblPaciente
        ' 
        lblPaciente.AutoSize = True
        lblPaciente.Font = New Font("Segoe UI", 12F)
        lblPaciente.Location = New Point(16, 63)
        lblPaciente.Name = "lblPaciente"
        lblPaciente.Size = New Size(70, 21)
        lblPaciente.TabIndex = 2
        lblPaciente.Text = "Paciente:"
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.Font = New Font("Segoe UI", 12F)
        lblFecha.Location = New Point(16, 96)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(53, 21)
        lblFecha.TabIndex = 3
        lblFecha.Text = "Fecha:"
        ' 
        ' lblPresion
        ' 
        lblPresion.AutoSize = True
        lblPresion.Font = New Font("Segoe UI", 12F)
        lblPresion.Location = New Point(16, 127)
        lblPresion.Name = "lblPresion"
        lblPresion.Size = New Size(65, 21)
        lblPresion.TabIndex = 4
        lblPresion.Text = "Presión:"
        ' 
        ' lblTemperatura
        ' 
        lblTemperatura.AutoSize = True
        lblTemperatura.Font = New Font("Segoe UI", 12F)
        lblTemperatura.Location = New Point(16, 157)
        lblTemperatura.Name = "lblTemperatura"
        lblTemperatura.Size = New Size(100, 21)
        lblTemperatura.TabIndex = 5
        lblTemperatura.Text = "Temperatura:"
        ' 
        ' lblPeso
        ' 
        lblPeso.AutoSize = True
        lblPeso.Font = New Font("Segoe UI", 12F)
        lblPeso.Location = New Point(16, 187)
        lblPeso.Name = "lblPeso"
        lblPeso.Size = New Size(45, 21)
        lblPeso.TabIndex = 6
        lblPeso.Text = "Peso:"
        ' 
        ' lblAltura
        ' 
        lblAltura.AutoSize = True
        lblAltura.Font = New Font("Segoe UI", 12F)
        lblAltura.Location = New Point(16, 219)
        lblAltura.Name = "lblAltura"
        lblAltura.Size = New Size(55, 21)
        lblAltura.TabIndex = 7
        lblAltura.Text = "Altura:"
        ' 
        ' lblFrecuenciaCardiaca
        ' 
        lblFrecuenciaCardiaca.AutoSize = True
        lblFrecuenciaCardiaca.Font = New Font("Segoe UI", 12F)
        lblFrecuenciaCardiaca.Location = New Point(16, 246)
        lblFrecuenciaCardiaca.Name = "lblFrecuenciaCardiaca"
        lblFrecuenciaCardiaca.Size = New Size(151, 21)
        lblFrecuenciaCardiaca.TabIndex = 8
        lblFrecuenciaCardiaca.Text = "Frecuencia Cardíaca:"
        ' 
        ' dgvSignosVitales
        ' 
        dgvSignosVitales.AllowUserToAddRows = False
        dgvSignosVitales.AllowUserToDeleteRows = False
        dgvSignosVitales.BackgroundColor = Color.White
        dgvSignosVitales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSignosVitales.Location = New Point(7, 31)
        dgvSignosVitales.Name = "dgvSignosVitales"
        dgvSignosVitales.ReadOnly = True
        dgvSignosVitales.RowHeadersVisible = False
        dgvSignosVitales.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSignosVitales.Size = New Size(839, 173)
        dgvSignosVitales.TabIndex = 9
        ' 
        ' txtIDRegistro
        ' 
        txtIDRegistro.Enabled = False
        txtIDRegistro.Font = New Font("Segoe UI", 12F)
        txtIDRegistro.Location = New Point(172, 29)
        txtIDRegistro.Name = "txtIDRegistro"
        txtIDRegistro.ReadOnly = True
        txtIDRegistro.Size = New Size(100, 29)
        txtIDRegistro.TabIndex = 32
        ' 
        ' dtpFecha
        ' 
        dtpFecha.Font = New Font("Segoe UI", 12F)
        dtpFecha.Format = DateTimePickerFormat.Short
        dtpFecha.Location = New Point(172, 90)
        dtpFecha.Name = "dtpFecha"
        dtpFecha.Size = New Size(121, 29)
        dtpFecha.TabIndex = 34
        ' 
        ' txtPeso
        ' 
        txtPeso.Font = New Font("Segoe UI", 12F)
        txtPeso.Location = New Point(172, 179)
        txtPeso.Name = "txtPeso"
        txtPeso.Size = New Size(100, 29)
        txtPeso.TabIndex = 35
        ' 
        ' txtPresion
        ' 
        txtPresion.Font = New Font("Segoe UI", 12F)
        txtPresion.Location = New Point(172, 119)
        txtPresion.Name = "txtPresion"
        txtPresion.Size = New Size(100, 29)
        txtPresion.TabIndex = 36
        ' 
        ' txtTemperatura
        ' 
        txtTemperatura.Font = New Font("Segoe UI", 12F)
        txtTemperatura.Location = New Point(172, 149)
        txtTemperatura.Name = "txtTemperatura"
        txtTemperatura.Size = New Size(100, 29)
        txtTemperatura.TabIndex = 37
        ' 
        ' txtAltura
        ' 
        txtAltura.Font = New Font("Segoe UI", 12F)
        txtAltura.Location = New Point(172, 211)
        txtAltura.Name = "txtAltura"
        txtAltura.Size = New Size(100, 29)
        txtAltura.TabIndex = 38
        ' 
        ' txtFrecuenciaCardiaca
        ' 
        txtFrecuenciaCardiaca.Font = New Font("Segoe UI", 12F)
        txtFrecuenciaCardiaca.Location = New Point(172, 243)
        txtFrecuenciaCardiaca.Name = "txtFrecuenciaCardiaca"
        txtFrecuenciaCardiaca.Size = New Size(100, 29)
        txtFrecuenciaCardiaca.TabIndex = 39
        ' 
        ' txtPaciente
        ' 
        txtPaciente.Font = New Font("Microsoft Sans Serif", 12F)
        txtPaciente.Location = New Point(172, 61)
        txtPaciente.Name = "txtPaciente"
        txtPaciente.ReadOnly = True
        txtPaciente.Size = New Size(100, 26)
        txtPaciente.TabIndex = 40
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(933, 95)
        Panel1.TabIndex = 41
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label3.Location = New Point(107, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(178, 19)
        Label3.TabIndex = 2
        Label3.Text = "Módulo de Signos Vitales"
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
        ' grpBotonesCitas
        ' 
        grpBotonesCitas.BackColor = SystemColors.ControlLight
        grpBotonesCitas.Controls.Add(BtnNuevo)
        grpBotonesCitas.Controls.Add(BtnSalir)
        grpBotonesCitas.Controls.Add(BtnGuardar)
        grpBotonesCitas.Font = New Font("Segoe UI", 10F)
        grpBotonesCitas.Location = New Point(412, 220)
        grpBotonesCitas.Name = "grpBotonesCitas"
        grpBotonesCitas.Size = New Size(195, 141)
        grpBotonesCitas.TabIndex = 42
        grpBotonesCitas.TabStop = False
        grpBotonesCitas.Text = "Operaciones"
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
        ' BtnSalir
        ' 
        BtnSalir.Font = New Font("Segoe UI", 12F)
        BtnSalir.Location = New Point(17, 92)
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
        ' grbDatosSignosVitales
        ' 
        grbDatosSignosVitales.BackColor = SystemColors.ControlLight
        grbDatosSignosVitales.Controls.Add(lblIDRegistro)
        grbDatosSignosVitales.Controls.Add(lblPaciente)
        grbDatosSignosVitales.Controls.Add(lblFecha)
        grbDatosSignosVitales.Controls.Add(txtPaciente)
        grbDatosSignosVitales.Controls.Add(lblPresion)
        grbDatosSignosVitales.Controls.Add(txtFrecuenciaCardiaca)
        grbDatosSignosVitales.Controls.Add(lblTemperatura)
        grbDatosSignosVitales.Controls.Add(txtAltura)
        grbDatosSignosVitales.Controls.Add(lblPeso)
        grbDatosSignosVitales.Controls.Add(txtTemperatura)
        grbDatosSignosVitales.Controls.Add(lblAltura)
        grbDatosSignosVitales.Controls.Add(txtPresion)
        grbDatosSignosVitales.Controls.Add(lblFrecuenciaCardiaca)
        grbDatosSignosVitales.Controls.Add(txtPeso)
        grbDatosSignosVitales.Controls.Add(txtIDRegistro)
        grbDatosSignosVitales.Controls.Add(dtpFecha)
        grbDatosSignosVitales.Font = New Font("Segoe UI", 10F)
        grbDatosSignosVitales.Location = New Point(26, 140)
        grbDatosSignosVitales.Name = "grbDatosSignosVitales"
        grbDatosSignosVitales.Size = New Size(304, 280)
        grbDatosSignosVitales.TabIndex = 43
        grbDatosSignosVitales.TabStop = False
        grbDatosSignosVitales.Text = "Datos del Registro"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ControlLight
        GroupBox1.Controls.Add(dtpFechaHasta)
        GroupBox1.Controls.Add(dtpFechaDesde)
        GroupBox1.Controls.Add(txtFiltroPaciente)
        GroupBox1.Controls.Add(BtnBuscar)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI", 10F)
        GroupBox1.Location = New Point(26, 631)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(441, 117)
        GroupBox1.TabIndex = 44
        GroupBox1.TabStop = False
        GroupBox1.Text = "Filtro de Busqueda"
        ' 
        ' dtpFechaHasta
        ' 
        dtpFechaHasta.Font = New Font("Segoe UI", 12F)
        dtpFechaHasta.Format = DateTimePickerFormat.Short
        dtpFechaHasta.Location = New Point(137, 78)
        dtpFechaHasta.Name = "dtpFechaHasta"
        dtpFechaHasta.Size = New Size(121, 29)
        dtpFechaHasta.TabIndex = 43
        ' 
        ' dtpFechaDesde
        ' 
        dtpFechaDesde.Font = New Font("Segoe UI", 12F)
        dtpFechaDesde.Format = DateTimePickerFormat.Short
        dtpFechaDesde.Location = New Point(137, 51)
        dtpFechaDesde.Name = "dtpFechaDesde"
        dtpFechaDesde.Size = New Size(121, 29)
        dtpFechaDesde.TabIndex = 42
        ' 
        ' txtFiltroPaciente
        ' 
        txtFiltroPaciente.Font = New Font("Microsoft Sans Serif", 12F)
        txtFiltroPaciente.Location = New Point(137, 24)
        txtFiltroPaciente.Name = "txtFiltroPaciente"
        txtFiltroPaciente.Size = New Size(100, 26)
        txtFiltroPaciente.TabIndex = 41
        ' 
        ' BtnBuscar
        ' 
        BtnBuscar.Font = New Font("Segoe UI", 12F)
        BtnBuscar.Location = New Point(299, 65)
        BtnBuscar.Name = "BtnBuscar"
        BtnBuscar.Size = New Size(82, 40)
        BtnBuscar.TabIndex = 32
        BtnBuscar.Text = "Buscar"
        BtnBuscar.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(18, 84)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 21)
        Label5.TabIndex = 2
        Label5.Text = "Fecha Hasta:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(18, 57)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 21)
        Label4.TabIndex = 1
        Label4.Text = "Fecha Desde:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(18, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 21)
        Label2.TabIndex = 0
        Label2.Text = "Paciente:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ControlLight
        GroupBox2.Controls.Add(dgvSignosVitales)
        GroupBox2.Font = New Font("Segoe UI", 10F)
        GroupBox2.Location = New Point(26, 754)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(869, 221)
        GroupBox2.TabIndex = 45
        GroupBox2.TabStop = False
        GroupBox2.Text = "Lista de Registros"
        ' 
        ' txtIDPaciente
        ' 
        txtIDPaciente.Font = New Font("Microsoft Sans Serif", 12F)
        txtIDPaciente.Location = New Point(721, 119)
        txtIDPaciente.Name = "txtIDPaciente"
        txtIDPaciente.ReadOnly = True
        txtIDPaciente.Size = New Size(100, 26)
        txtIDPaciente.TabIndex = 46
        txtIDPaciente.Visible = False
        ' 
        ' grbResultadosPaciente
        ' 
        grbResultadosPaciente.BackColor = SystemColors.ControlLight
        grbResultadosPaciente.Controls.Add(dgvPacientes)
        grbResultadosPaciente.Font = New Font("Segoe UI", 10F)
        grbResultadosPaciente.Location = New Point(406, 465)
        grbResultadosPaciente.Name = "grbResultadosPaciente"
        grbResultadosPaciente.Size = New Size(420, 146)
        grbResultadosPaciente.TabIndex = 47
        grbResultadosPaciente.TabStop = False
        grbResultadosPaciente.Text = "Resultados:"
        ' 
        ' dgvPacientes
        ' 
        dgvPacientes.AllowUserToAddRows = False
        dgvPacientes.AllowUserToDeleteRows = False
        dgvPacientes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvPacientes.BackgroundColor = SystemColors.ButtonHighlight
        dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPacientes.Location = New Point(6, 24)
        dgvPacientes.Name = "dgvPacientes"
        dgvPacientes.ReadOnly = True
        dgvPacientes.RowHeadersVisible = False
        dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPacientes.Size = New Size(397, 116)
        dgvPacientes.TabIndex = 16
        ' 
        ' grbSeleccionPacinte
        ' 
        grbSeleccionPacinte.BackColor = SystemColors.ControlLight
        grbSeleccionPacinte.Controls.Add(Label7)
        grbSeleccionPacinte.Controls.Add(txtBuscarPaciente)
        grbSeleccionPacinte.Controls.Add(Label6)
        grbSeleccionPacinte.Controls.Add(BtnBuscarPaciente)
        grbSeleccionPacinte.Location = New Point(26, 465)
        grbSeleccionPacinte.Name = "grbSeleccionPacinte"
        grbSeleccionPacinte.Size = New Size(350, 118)
        grbSeleccionPacinte.TabIndex = 48
        grbSeleccionPacinte.TabStop = False
        grbSeleccionPacinte.Text = "Selección de Paciente"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(6, 70)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 21)
        Label7.TabIndex = 35
        ' 
        ' txtBuscarPaciente
        ' 
        txtBuscarPaciente.Font = New Font("Segoe UI", 12F)
        txtBuscarPaciente.Location = New Point(133, 25)
        txtBuscarPaciente.Name = "txtBuscarPaciente"
        txtBuscarPaciente.Size = New Size(196, 29)
        txtBuscarPaciente.TabIndex = 36
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(6, 25)
        Label6.Name = "Label6"
        Label6.Size = New Size(121, 21)
        Label6.TabIndex = 34
        Label6.Text = "Buscar paciente:"
        ' 
        ' BtnBuscarPaciente
        ' 
        BtnBuscarPaciente.Font = New Font("Segoe UI", 12F)
        BtnBuscarPaciente.Location = New Point(121, 69)
        BtnBuscarPaciente.Name = "BtnBuscarPaciente"
        BtnBuscarPaciente.Size = New Size(126, 40)
        BtnBuscarPaciente.TabIndex = 32
        BtnBuscarPaciente.Text = "Buscar Paciente"
        BtnBuscarPaciente.UseVisualStyleBackColor = True
        ' 
        ' frmSignosVitales
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(933, 1025)
        Controls.Add(grbResultadosPaciente)
        Controls.Add(grbSeleccionPacinte)
        Controls.Add(txtIDPaciente)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(grbDatosSignosVitales)
        Controls.Add(grpBotonesCitas)
        Controls.Add(Panel1)
        Name = "frmSignosVitales"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmSignosVitales"
        CType(dgvSignosVitales, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        grpBotonesCitas.ResumeLayout(False)
        grbDatosSignosVitales.ResumeLayout(False)
        grbDatosSignosVitales.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        grbResultadosPaciente.ResumeLayout(False)
        CType(dgvPacientes, ComponentModel.ISupportInitialize).EndInit()
        grbSeleccionPacinte.ResumeLayout(False)
        grbSeleccionPacinte.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblIDRegistro As Label
    Friend WithEvents lblPaciente As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblPresion As Label
    Friend WithEvents lblTemperatura As Label
    Friend WithEvents lblPeso As Label
    Friend WithEvents lblAltura As Label
    Friend WithEvents lblFrecuenciaCardiaca As Label
    Friend WithEvents dgvSignosVitales As DataGridView
    Friend WithEvents txtIDRegistro As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents txtPresion As TextBox
    Friend WithEvents txtTemperatura As TextBox
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents txtFrecuenciaCardiaca As TextBox
    Friend WithEvents txtPaciente As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grpBotonesCitas As GroupBox
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents grbDatosSignosVitales As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFechaDesde As DateTimePicker
    Friend WithEvents txtFiltroPaciente As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents dtpFechaHasta As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtIDPaciente As TextBox
    Friend WithEvents grbResultadosPaciente As GroupBox
    Friend WithEvents dgvPacientes As DataGridView
    Friend WithEvents grbSeleccionPacinte As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBuscarPaciente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnBuscarPaciente As Button
End Class
