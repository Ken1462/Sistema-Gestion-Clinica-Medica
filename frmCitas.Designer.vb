<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCitas
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
        lblIDCita = New Label()
        lblMedico = New Label()
        lblFecha = New Label()
        lblHora = New Label()
        lblMotivo = New Label()
        txtIDCita = New TextBox()
        txtMotivo = New TextBox()
        dtpFecha = New DateTimePicker()
        dtpHora = New DateTimePicker()
        dgvCitas = New DataGridView()
        cmbMedico = New ComboBox()
        txtIDPaciente = New TextBox()
        Panel1 = New Panel()
        Label3 = New Label()
        Label1 = New Label()
        grpBotonesCitas = New GroupBox()
        BtnNuevo = New Button()
        BtnSalir = New Button()
        BtnGuardar = New Button()
        BtnBuscar = New Button()
        grbDatosCitas = New GroupBox()
        txtPaciente = New TextBox()
        Label5 = New Label()
        BtnBuscarPaciente = New Button()
        grbFiltroCitas = New GroupBox()
        dtpFechaHasta = New DateTimePicker()
        dtpFechaDesde = New DateTimePicker()
        Label4 = New Label()
        Label2 = New Label()
        grpListaCitas = New GroupBox()
        grbSeleccionPacinte = New GroupBox()
        Label7 = New Label()
        txtBuscarPaciente = New TextBox()
        Label6 = New Label()
        grbResultadosPaciente = New GroupBox()
        dgvPacientes = New DataGridView()
        CType(dgvCitas, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        grpBotonesCitas.SuspendLayout()
        grbDatosCitas.SuspendLayout()
        grbFiltroCitas.SuspendLayout()
        grpListaCitas.SuspendLayout()
        grbSeleccionPacinte.SuspendLayout()
        grbResultadosPaciente.SuspendLayout()
        CType(dgvPacientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblIDCita
        ' 
        lblIDCita.AutoSize = True
        lblIDCita.Font = New Font("Segoe UI", 12F)
        lblIDCita.Location = New Point(16, 29)
        lblIDCita.Name = "lblIDCita"
        lblIDCita.Size = New Size(59, 21)
        lblIDCita.TabIndex = 1
        lblIDCita.Text = "ID Cita:"
        ' 
        ' lblMedico
        ' 
        lblMedico.AutoSize = True
        lblMedico.Font = New Font("Segoe UI", 12F)
        lblMedico.Location = New Point(16, 111)
        lblMedico.Name = "lblMedico"
        lblMedico.Size = New Size(64, 21)
        lblMedico.TabIndex = 3
        lblMedico.Text = "Médico:"
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.Font = New Font("Segoe UI", 12F)
        lblFecha.Location = New Point(16, 146)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(53, 21)
        lblFecha.TabIndex = 4
        lblFecha.Text = "Fecha:"
        ' 
        ' lblHora
        ' 
        lblHora.AutoSize = True
        lblHora.Font = New Font("Segoe UI", 12F)
        lblHora.Location = New Point(16, 180)
        lblHora.Name = "lblHora"
        lblHora.Size = New Size(47, 21)
        lblHora.TabIndex = 5
        lblHora.Text = "Hora:"
        ' 
        ' lblMotivo
        ' 
        lblMotivo.AutoSize = True
        lblMotivo.Font = New Font("Segoe UI", 12F)
        lblMotivo.Location = New Point(16, 216)
        lblMotivo.Name = "lblMotivo"
        lblMotivo.Size = New Size(62, 21)
        lblMotivo.TabIndex = 6
        lblMotivo.Text = "Motivo:"
        ' 
        ' txtIDCita
        ' 
        txtIDCita.Enabled = False
        txtIDCita.Font = New Font("Segoe UI", 12F)
        txtIDCita.Location = New Point(120, 26)
        txtIDCita.Name = "txtIDCita"
        txtIDCita.ReadOnly = True
        txtIDCita.Size = New Size(100, 29)
        txtIDCita.TabIndex = 7
        ' 
        ' txtMotivo
        ' 
        txtMotivo.Font = New Font("Segoe UI", 12F)
        txtMotivo.Location = New Point(120, 213)
        txtMotivo.Name = "txtMotivo"
        txtMotivo.Size = New Size(196, 29)
        txtMotivo.TabIndex = 13
        ' 
        ' dtpFecha
        ' 
        dtpFecha.CalendarFont = New Font("Segoe UI", 12F)
        dtpFecha.Font = New Font("Segoe UI", 12F)
        dtpFecha.Format = DateTimePickerFormat.Short
        dtpFecha.Location = New Point(120, 145)
        dtpFecha.Name = "dtpFecha"
        dtpFecha.Size = New Size(117, 29)
        dtpFecha.TabIndex = 14
        ' 
        ' dtpHora
        ' 
        dtpHora.Font = New Font("Segoe UI", 12F)
        dtpHora.Format = DateTimePickerFormat.Time
        dtpHora.Location = New Point(120, 174)
        dtpHora.Name = "dtpHora"
        dtpHora.Size = New Size(132, 29)
        dtpHora.TabIndex = 15
        ' 
        ' dgvCitas
        ' 
        dgvCitas.AllowUserToAddRows = False
        dgvCitas.AllowUserToDeleteRows = False
        dgvCitas.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvCitas.BackgroundColor = SystemColors.ButtonHighlight
        dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCitas.Location = New Point(16, 24)
        dgvCitas.Name = "dgvCitas"
        dgvCitas.ReadOnly = True
        dgvCitas.RowHeadersVisible = False
        dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCitas.Size = New Size(897, 207)
        dgvCitas.TabIndex = 16
        ' 
        ' cmbMedico
        ' 
        cmbMedico.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMedico.Font = New Font("Segoe UI", 12F)
        cmbMedico.FormattingEnabled = True
        cmbMedico.Location = New Point(120, 108)
        cmbMedico.Name = "cmbMedico"
        cmbMedico.Size = New Size(170, 29)
        cmbMedico.TabIndex = 23
        ' 
        ' txtIDPaciente
        ' 
        txtIDPaciente.Font = New Font("Microsoft Sans Serif", 12F)
        txtIDPaciente.Location = New Point(777, 106)
        txtIDPaciente.Name = "txtIDPaciente"
        txtIDPaciente.ReadOnly = True
        txtIDPaciente.Size = New Size(100, 26)
        txtIDPaciente.TabIndex = 32
        txtIDPaciente.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1009, 100)
        Panel1.TabIndex = 36
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label3.Location = New Point(107, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 19)
        Label3.TabIndex = 2
        Label3.Text = "Módulo de Citas"
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
        grpBotonesCitas.Location = New Point(526, 174)
        grpBotonesCitas.Name = "grpBotonesCitas"
        grpBotonesCitas.Size = New Size(202, 157)
        grpBotonesCitas.TabIndex = 37
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
        ' BtnBuscar
        ' 
        BtnBuscar.Font = New Font("Segoe UI", 12F)
        BtnBuscar.Location = New Point(276, 43)
        BtnBuscar.Name = "BtnBuscar"
        BtnBuscar.Size = New Size(82, 40)
        BtnBuscar.TabIndex = 31
        BtnBuscar.Text = "Buscar"
        BtnBuscar.UseVisualStyleBackColor = True
        ' 
        ' grbDatosCitas
        ' 
        grbDatosCitas.BackColor = SystemColors.ControlLight
        grbDatosCitas.Controls.Add(txtPaciente)
        grbDatosCitas.Controls.Add(Label5)
        grbDatosCitas.Controls.Add(lblIDCita)
        grbDatosCitas.Controls.Add(lblMedico)
        grbDatosCitas.Controls.Add(lblFecha)
        grbDatosCitas.Controls.Add(cmbMedico)
        grbDatosCitas.Controls.Add(lblHora)
        grbDatosCitas.Controls.Add(lblMotivo)
        grbDatosCitas.Controls.Add(dtpHora)
        grbDatosCitas.Controls.Add(txtIDCita)
        grbDatosCitas.Controls.Add(dtpFecha)
        grbDatosCitas.Controls.Add(txtMotivo)
        grbDatosCitas.Font = New Font("Segoe UI", 10F)
        grbDatosCitas.Location = New Point(37, 128)
        grbDatosCitas.Name = "grbDatosCitas"
        grbDatosCitas.Size = New Size(341, 263)
        grbDatosCitas.TabIndex = 38
        grbDatosCitas.TabStop = False
        grbDatosCitas.Text = "Datos de Cita"
        ' 
        ' txtPaciente
        ' 
        txtPaciente.Font = New Font("Microsoft Sans Serif", 12F)
        txtPaciente.Location = New Point(120, 69)
        txtPaciente.Name = "txtPaciente"
        txtPaciente.ReadOnly = True
        txtPaciente.Size = New Size(170, 26)
        txtPaciente.TabIndex = 34
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(16, 71)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 21)
        Label5.TabIndex = 33
        Label5.Text = "Paciente:"
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
        ' grbFiltroCitas
        ' 
        grbFiltroCitas.BackColor = SystemColors.ControlLight
        grbFiltroCitas.Controls.Add(dtpFechaHasta)
        grbFiltroCitas.Controls.Add(dtpFechaDesde)
        grbFiltroCitas.Controls.Add(BtnBuscar)
        grbFiltroCitas.Controls.Add(Label4)
        grbFiltroCitas.Controls.Add(Label2)
        grbFiltroCitas.Font = New Font("Segoe UI", 10F)
        grbFiltroCitas.Location = New Point(59, 606)
        grbFiltroCitas.Name = "grbFiltroCitas"
        grbFiltroCitas.Size = New Size(377, 100)
        grbFiltroCitas.TabIndex = 39
        grbFiltroCitas.TabStop = False
        grbFiltroCitas.Text = "Filtro de Busquedas"
        ' 
        ' dtpFechaHasta
        ' 
        dtpFechaHasta.Font = New Font("Segoe UI", 11F)
        dtpFechaHasta.Format = DateTimePickerFormat.Short
        dtpFechaHasta.Location = New Point(122, 58)
        dtpFechaHasta.Name = "dtpFechaHasta"
        dtpFechaHasta.Size = New Size(124, 27)
        dtpFechaHasta.TabIndex = 3
        ' 
        ' dtpFechaDesde
        ' 
        dtpFechaDesde.Font = New Font("Segoe UI", 11F)
        dtpFechaDesde.Format = DateTimePickerFormat.Short
        dtpFechaDesde.Location = New Point(122, 27)
        dtpFechaDesde.Name = "dtpFechaDesde"
        dtpFechaDesde.Size = New Size(124, 27)
        dtpFechaDesde.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F)
        Label4.Location = New Point(6, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 20)
        Label4.TabIndex = 1
        Label4.Text = "Fecha Hasta:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(6, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 20)
        Label2.TabIndex = 0
        Label2.Text = "Fecha Desde:"
        ' 
        ' grpListaCitas
        ' 
        grpListaCitas.BackColor = SystemColors.ControlLight
        grpListaCitas.Controls.Add(dgvCitas)
        grpListaCitas.Font = New Font("Segoe UI", 10F)
        grpListaCitas.Location = New Point(37, 734)
        grpListaCitas.Name = "grpListaCitas"
        grpListaCitas.Size = New Size(930, 315)
        grpListaCitas.TabIndex = 40
        grpListaCitas.TabStop = False
        grpListaCitas.Text = "Lista de Citas"
        ' 
        ' grbSeleccionPacinte
        ' 
        grbSeleccionPacinte.BackColor = SystemColors.ControlLight
        grbSeleccionPacinte.Controls.Add(Label7)
        grbSeleccionPacinte.Controls.Add(txtBuscarPaciente)
        grbSeleccionPacinte.Controls.Add(Label6)
        grbSeleccionPacinte.Controls.Add(BtnBuscarPaciente)
        grbSeleccionPacinte.Location = New Point(65, 448)
        grbSeleccionPacinte.Name = "grbSeleccionPacinte"
        grbSeleccionPacinte.Size = New Size(350, 118)
        grbSeleccionPacinte.TabIndex = 41
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
        ' grbResultadosPaciente
        ' 
        grbResultadosPaciente.BackColor = SystemColors.ControlLight
        grbResultadosPaciente.Controls.Add(dgvPacientes)
        grbResultadosPaciente.Font = New Font("Segoe UI", 10F)
        grbResultadosPaciente.Location = New Point(445, 448)
        grbResultadosPaciente.Name = "grbResultadosPaciente"
        grbResultadosPaciente.Size = New Size(420, 146)
        grbResultadosPaciente.TabIndex = 41
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
        dgvPacientes.Size = New Size(397, 101)
        dgvPacientes.TabIndex = 16
        ' 
        ' frmCitas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(1009, 1061)
        Controls.Add(grbResultadosPaciente)
        Controls.Add(grbSeleccionPacinte)
        Controls.Add(grpListaCitas)
        Controls.Add(grbFiltroCitas)
        Controls.Add(grbDatosCitas)
        Controls.Add(grpBotonesCitas)
        Controls.Add(Panel1)
        Controls.Add(txtIDPaciente)
        Name = "frmCitas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmCitas"
        CType(dgvCitas, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        grpBotonesCitas.ResumeLayout(False)
        grbDatosCitas.ResumeLayout(False)
        grbDatosCitas.PerformLayout()
        grbFiltroCitas.ResumeLayout(False)
        grbFiltroCitas.PerformLayout()
        grpListaCitas.ResumeLayout(False)
        grbSeleccionPacinte.ResumeLayout(False)
        grbSeleccionPacinte.PerformLayout()
        grbResultadosPaciente.ResumeLayout(False)
        CType(dgvPacientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblIDCita As Label
    Friend WithEvents lblMedico As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents lblMotivo As Label
    Friend WithEvents txtIDCita As TextBox
    Friend WithEvents txtMotivo As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents dtpHora As DateTimePicker
    Friend WithEvents dgvCitas As DataGridView
    Friend WithEvents cmbMedico As ComboBox
    Friend WithEvents txtIDPaciente As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grpBotonesCitas As GroupBox
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents grbDatosCitas As GroupBox
    Friend WithEvents grbFiltroCitas As GroupBox
    Friend WithEvents dtpFechaHasta As DateTimePicker
    Friend WithEvents dtpFechaDesde As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents grpListaCitas As GroupBox
    Friend WithEvents txtPaciente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnBuscarPaciente As Button
    Friend WithEvents grbSeleccionPacinte As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBuscarPaciente As TextBox
    Friend WithEvents grbResultadosPaciente As GroupBox
    Friend WithEvents dgvPacientes As DataGridView
End Class
