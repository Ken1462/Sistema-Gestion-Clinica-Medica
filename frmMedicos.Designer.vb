<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedicos
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
        dgvMedicos = New DataGridView()
        Panel1 = New Panel()
        Label3 = New Label()
        Label1 = New Label()
        grpBotonesCitas = New GroupBox()
        BtnNuevo = New Button()
        BtnSalir = New Button()
        BtnGuardar = New Button()
        grbMedico = New GroupBox()
        cmbHorario = New ComboBox()
        txtEmail = New TextBox()
        txtTelefono = New TextBox()
        cmbEspecialidad = New ComboBox()
        txtApellido = New TextBox()
        txtNombre = New TextBox()
        txtIDMedico = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        grbFiltroBusquedaPaciente = New GroupBox()
        cmbFiltroEspecialidad = New ComboBox()
        txtFiltroNombre = New TextBox()
        txtFiltroApellido = New TextBox()
        BtnBuscar = New Button()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        GroupBox1 = New GroupBox()
        CType(dgvMedicos, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        grpBotonesCitas.SuspendLayout()
        grbMedico.SuspendLayout()
        grbFiltroBusquedaPaciente.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvMedicos
        ' 
        dgvMedicos.AllowUserToAddRows = False
        dgvMedicos.AllowUserToDeleteRows = False
        dgvMedicos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvMedicos.BackgroundColor = Color.White
        dgvMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMedicos.Location = New Point(23, 29)
        dgvMedicos.Name = "dgvMedicos"
        dgvMedicos.ReadOnly = True
        dgvMedicos.RowHeadersVisible = False
        dgvMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMedicos.Size = New Size(873, 239)
        dgvMedicos.TabIndex = 9
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(985, 95)
        Panel1.TabIndex = 37
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label3.Location = New Point(107, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 19)
        Label3.TabIndex = 2
        Label3.Text = "Módulo de Médicos"
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
        grpBotonesCitas.Location = New Point(466, 117)
        grpBotonesCitas.Name = "grpBotonesCitas"
        grpBotonesCitas.Size = New Size(195, 141)
        grpBotonesCitas.TabIndex = 38
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
        ' grbMedico
        ' 
        grbMedico.BackColor = SystemColors.ControlLight
        grbMedico.Controls.Add(cmbHorario)
        grbMedico.Controls.Add(txtEmail)
        grbMedico.Controls.Add(txtTelefono)
        grbMedico.Controls.Add(cmbEspecialidad)
        grbMedico.Controls.Add(txtApellido)
        grbMedico.Controls.Add(txtNombre)
        grbMedico.Controls.Add(txtIDMedico)
        grbMedico.Controls.Add(Label9)
        grbMedico.Controls.Add(Label8)
        grbMedico.Controls.Add(Label7)
        grbMedico.Controls.Add(Label6)
        grbMedico.Controls.Add(Label5)
        grbMedico.Controls.Add(Label4)
        grbMedico.Controls.Add(Label2)
        grbMedico.Font = New Font("Segoe UI", 10F)
        grbMedico.Location = New Point(69, 133)
        grbMedico.Name = "grbMedico"
        grbMedico.Size = New Size(291, 271)
        grbMedico.TabIndex = 39
        grbMedico.TabStop = False
        grbMedico.Text = "Datos del Médico"
        ' 
        ' cmbHorario
        ' 
        cmbHorario.Font = New Font("Segoe UI", 12F)
        cmbHorario.FormattingEnabled = True
        cmbHorario.Items.AddRange(New Object() {"7:00 AM - 3:00 PM", "8:00 AM - 4:00 PM", "9:00 AM - 5:00 PM", "10:00 AM - 6:00 PM"})
        cmbHorario.Location = New Point(121, 219)
        cmbHorario.Name = "cmbHorario"
        cmbHorario.Size = New Size(144, 29)
        cmbHorario.TabIndex = 13
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 12F)
        txtEmail.Location = New Point(121, 184)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(154, 29)
        txtEmail.TabIndex = 12
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Font = New Font("Segoe UI", 12F)
        txtTelefono.Location = New Point(121, 150)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(130, 29)
        txtTelefono.TabIndex = 11
        ' 
        ' cmbEspecialidad
        ' 
        cmbEspecialidad.Font = New Font("Segoe UI", 12F)
        cmbEspecialidad.FormattingEnabled = True
        cmbEspecialidad.Items.AddRange(New Object() {"Medicina General", "Pediatría", "Cardiología", "Ginecología", "Dermatología"})
        cmbEspecialidad.Location = New Point(121, 119)
        cmbEspecialidad.Name = "cmbEspecialidad"
        cmbEspecialidad.Size = New Size(144, 29)
        cmbEspecialidad.TabIndex = 10
        ' 
        ' txtApellido
        ' 
        txtApellido.Font = New Font("Segoe UI", 12F)
        txtApellido.Location = New Point(121, 91)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(100, 29)
        txtApellido.TabIndex = 9
        ' 
        ' txtNombre
        ' 
        txtNombre.Font = New Font("Segoe UI", 12F)
        txtNombre.Location = New Point(121, 60)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 29)
        txtNombre.TabIndex = 8
        ' 
        ' txtIDMedico
        ' 
        txtIDMedico.Enabled = False
        txtIDMedico.Font = New Font("Segoe UI", 12F)
        txtIDMedico.Location = New Point(121, 30)
        txtIDMedico.Name = "txtIDMedico"
        txtIDMedico.Size = New Size(59, 29)
        txtIDMedico.TabIndex = 7
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F)
        Label9.Location = New Point(6, 222)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 21)
        Label9.TabIndex = 6
        Label9.Text = "Horario:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.Location = New Point(6, 63)
        Label8.Name = "Label8"
        Label8.Size = New Size(71, 21)
        Label8.TabIndex = 5
        Label8.Text = "Nombre:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(6, 94)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 21)
        Label7.TabIndex = 4
        Label7.Text = "Apellido:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(6, 122)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 21)
        Label6.TabIndex = 3
        Label6.Text = "Especialidad:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(6, 153)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 21)
        Label5.TabIndex = 2
        Label5.Text = "Teléfono:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(6, 187)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 21)
        Label4.TabIndex = 1
        Label4.Text = "Email:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(6, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 21)
        Label2.TabIndex = 0
        Label2.Text = "ID Médico:"
        ' 
        ' grbFiltroBusquedaPaciente
        ' 
        grbFiltroBusquedaPaciente.BackColor = SystemColors.ControlLight
        grbFiltroBusquedaPaciente.Controls.Add(cmbFiltroEspecialidad)
        grbFiltroBusquedaPaciente.Controls.Add(txtFiltroNombre)
        grbFiltroBusquedaPaciente.Controls.Add(txtFiltroApellido)
        grbFiltroBusquedaPaciente.Controls.Add(BtnBuscar)
        grbFiltroBusquedaPaciente.Controls.Add(Label11)
        grbFiltroBusquedaPaciente.Controls.Add(Label12)
        grbFiltroBusquedaPaciente.Controls.Add(Label13)
        grbFiltroBusquedaPaciente.Font = New Font("Segoe UI", 10F)
        grbFiltroBusquedaPaciente.Location = New Point(460, 286)
        grbFiltroBusquedaPaciente.Name = "grbFiltroBusquedaPaciente"
        grbFiltroBusquedaPaciente.Size = New Size(293, 208)
        grbFiltroBusquedaPaciente.TabIndex = 40
        grbFiltroBusquedaPaciente.TabStop = False
        grbFiltroBusquedaPaciente.Text = "Buscar Médicos"
        ' 
        ' cmbFiltroEspecialidad
        ' 
        cmbFiltroEspecialidad.Font = New Font("Segoe UI", 12F)
        cmbFiltroEspecialidad.FormattingEnabled = True
        cmbFiltroEspecialidad.Items.AddRange(New Object() {"Medicina ", "General", "", "Pediatría", "", "Cardiología", "", "Ginecología", "", "Dermatología"})
        cmbFiltroEspecialidad.Location = New Point(114, 105)
        cmbFiltroEspecialidad.Name = "cmbFiltroEspecialidad"
        cmbFiltroEspecialidad.Size = New Size(161, 29)
        cmbFiltroEspecialidad.TabIndex = 32
        ' 
        ' txtFiltroNombre
        ' 
        txtFiltroNombre.Font = New Font("Segoe UI", 12F)
        txtFiltroNombre.Location = New Point(114, 33)
        txtFiltroNombre.Name = "txtFiltroNombre"
        txtFiltroNombre.Size = New Size(161, 29)
        txtFiltroNombre.TabIndex = 23
        ' 
        ' txtFiltroApellido
        ' 
        txtFiltroApellido.Font = New Font("Segoe UI", 12F)
        txtFiltroApellido.Location = New Point(114, 71)
        txtFiltroApellido.Name = "txtFiltroApellido"
        txtFiltroApellido.Size = New Size(161, 29)
        txtFiltroApellido.TabIndex = 22
        ' 
        ' BtnBuscar
        ' 
        BtnBuscar.Font = New Font("Segoe UI", 12F)
        BtnBuscar.Location = New Point(93, 148)
        BtnBuscar.Name = "BtnBuscar"
        BtnBuscar.Size = New Size(82, 40)
        BtnBuscar.TabIndex = 31
        BtnBuscar.Text = "Buscar"
        BtnBuscar.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F)
        Label11.Location = New Point(17, 108)
        Label11.Name = "Label11"
        Label11.Size = New Size(95, 21)
        Label11.TabIndex = 2
        Label11.Text = "Especialidad"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F)
        Label12.Location = New Point(18, 74)
        Label12.Name = "Label12"
        Label12.Size = New Size(70, 21)
        Label12.TabIndex = 1
        Label12.Text = "Apellido:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F)
        Label13.Location = New Point(17, 36)
        Label13.Name = "Label13"
        Label13.Size = New Size(71, 21)
        Label13.TabIndex = 0
        Label13.Text = "Nombre:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ControlLight
        GroupBox1.Controls.Add(dgvMedicos)
        GroupBox1.Font = New Font("Segoe UI", 10F)
        GroupBox1.Location = New Point(69, 500)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(902, 274)
        GroupBox1.TabIndex = 41
        GroupBox1.TabStop = False
        GroupBox1.Text = "Lista de Médicos"
        ' 
        ' frmMedicos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(985, 786)
        Controls.Add(GroupBox1)
        Controls.Add(grbFiltroBusquedaPaciente)
        Controls.Add(grbMedico)
        Controls.Add(grpBotonesCitas)
        Controls.Add(Panel1)
        Name = "frmMedicos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmMedicos"
        CType(dgvMedicos, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        grpBotonesCitas.ResumeLayout(False)
        grbMedico.ResumeLayout(False)
        grbMedico.PerformLayout()
        grbFiltroBusquedaPaciente.ResumeLayout(False)
        grbFiltroBusquedaPaciente.PerformLayout()
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents dgvMedicos As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grpBotonesCitas As GroupBox
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents grbMedico As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbHorario As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents cmbEspecialidad As ComboBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtIDMedico As TextBox
    Friend WithEvents grbFiltroBusquedaPaciente As GroupBox
    Friend WithEvents cmbFiltroEspecialidad As ComboBox
    Friend WithEvents txtFiltroNombre As TextBox
    Friend WithEvents txtFiltroApellido As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
