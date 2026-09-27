<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnPacientes = New Button()
        btnCitas = New Button()
        btnMedicos = New Button()
        btnSignosVitales = New Button()
        btnSalir = New Button()
        lblBienvenida = New Label()
        lblSelecciona = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnPacientes
        ' 
        btnPacientes.BackColor = SystemColors.InactiveBorder
        btnPacientes.Font = New Font("Segoe UI", 10F)
        btnPacientes.Location = New Point(143, 157)
        btnPacientes.Name = "btnPacientes"
        btnPacientes.Size = New Size(120, 40)
        btnPacientes.TabIndex = 2
        btnPacientes.Text = "Pacientes"
        btnPacientes.UseVisualStyleBackColor = False
        ' 
        ' btnCitas
        ' 
        btnCitas.BackColor = SystemColors.InactiveBorder
        btnCitas.Font = New Font("Segoe UI", 10F)
        btnCitas.Location = New Point(143, 208)
        btnCitas.Name = "btnCitas"
        btnCitas.Size = New Size(120, 40)
        btnCitas.TabIndex = 3
        btnCitas.Text = "Citas"
        btnCitas.UseVisualStyleBackColor = False
        ' 
        ' btnMedicos
        ' 
        btnMedicos.BackColor = SystemColors.InactiveBorder
        btnMedicos.Font = New Font("Segoe UI", 10F)
        btnMedicos.Location = New Point(369, 157)
        btnMedicos.Name = "btnMedicos"
        btnMedicos.Size = New Size(120, 40)
        btnMedicos.TabIndex = 4
        btnMedicos.Text = "Médicos"
        btnMedicos.UseVisualStyleBackColor = False
        ' 
        ' btnSignosVitales
        ' 
        btnSignosVitales.BackColor = SystemColors.InactiveBorder
        btnSignosVitales.Font = New Font("Segoe UI", 10F)
        btnSignosVitales.Location = New Point(369, 208)
        btnSignosVitales.Name = "btnSignosVitales"
        btnSignosVitales.Size = New Size(120, 40)
        btnSignosVitales.TabIndex = 5
        btnSignosVitales.Text = "Signos Vitales"
        btnSignosVitales.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = SystemColors.InactiveBorder
        btnSalir.Font = New Font("Segoe UI", 10F)
        btnSalir.Location = New Point(261, 271)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(120, 40)
        btnSalir.TabIndex = 6
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' lblBienvenida
        ' 
        lblBienvenida.Font = New Font("Segoe UI", 14F)
        lblBienvenida.Location = New Point(219, 343)
        lblBienvenida.Name = "lblBienvenida"
        lblBienvenida.Size = New Size(202, 29)
        lblBienvenida.TabIndex = 7
        lblBienvenida.Text = "Bienvenido al sistema"
        ' 
        ' lblSelecciona
        ' 
        lblSelecciona.Font = New Font("Segoe UI", 14F)
        lblSelecciona.Location = New Point(219, 372)
        lblSelecciona.Name = "lblSelecciona"
        lblSelecciona.Size = New Size(202, 29)
        lblSelecciona.TabIndex = 8
        lblSelecciona.Text = "Selecciona una opcón"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(669, 97)
        Panel1.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(242, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(188, 32)
        Label2.TabIndex = 1
        Label2.Text = "Menú Principal"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(119, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(439, 32)
        Label1.TabIndex = 0
        Label1.Text = "Sistema de Gestión de Clínica Médica"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(669, 460)
        Controls.Add(Panel1)
        Controls.Add(lblSelecciona)
        Controls.Add(lblBienvenida)
        Controls.Add(btnSalir)
        Controls.Add(btnSignosVitales)
        Controls.Add(btnMedicos)
        Controls.Add(btnCitas)
        Controls.Add(btnPacientes)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menú Principal"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnPacientes As Button
    Friend WithEvents btnCitas As Button
    Friend WithEvents btnMedicos As Button
    Friend WithEvents btnSignosVitales As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblBienvenida As Label
    Friend WithEvents lblSelecciona As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
