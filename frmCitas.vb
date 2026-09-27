Imports Microsoft.Data.SqlClient

Public Class frmCitas

    Dim conexion As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ClinicaMedicaDB;Integrated Security=True")

    Private Sub frmCitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIDCita.ReadOnly = True
        txtIDPaciente.Visible = False
        txtPaciente.ReadOnly = True

        Try
            Dim queryMedicos As String =
            "SELECT MIN(MedicoID) AS MedicoID, Nombre + ' ' + Apellido AS NombreCompleto " &
            "FROM Medicos " &
            "GROUP BY Nombre, Apellido " &
            "ORDER BY NombreCompleto"

            Dim adaptadorMedicos As New SqlDataAdapter(queryMedicos, conexion)
            Dim tablaMedicos As New DataTable()

            adaptadorMedicos.Fill(tablaMedicos)

            cmbMedico.DataSource = tablaMedicos
            cmbMedico.DisplayMember = "NombreCompleto"
            cmbMedico.ValueMember = "MedicoID"
            cmbMedico.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error al cargar médicos: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        ' 🔹 Validaciones
        If txtIDPaciente.Text.Trim() = "" Or txtPaciente.Text.Trim() = "" Then
            MessageBox.Show("Debe buscar y seleccionar un paciente.")
            Exit Sub
        End If

        If cmbMedico.SelectedIndex = -1 Or cmbMedico.SelectedValue Is Nothing Then
            MessageBox.Show("Debe seleccionar un médico.")
            Exit Sub
        End If

        If txtMotivo.Text.Trim() = "" Then
            MessageBox.Show("Debe escribir el motivo de la cita.")
            Exit Sub
        End If

        If dtpFecha.Value.Date < DateTime.Now.Date Then
            MessageBox.Show("No se puede registrar una cita en una fecha pasada.")
            Exit Sub
        End If

        Try
            conexion.Open()

            Dim pacienteID As Integer = CInt(txtIDPaciente.Text)
            Dim medicoID As Integer = CInt(cmbMedico.SelectedValue)

            If txtIDCita.Text.Trim() = "" Then
                ' 🔹 INSERT
                Dim queryInsert As String =
                "INSERT INTO Citas (PacienteID, MedicoID, Fecha, Hora, Motivo) " &
                "VALUES (@PacienteID, @MedicoID, @Fecha, @Hora, @Motivo)"

                Using cmdInsert As New SqlCommand(queryInsert, conexion)
                    cmdInsert.Parameters.AddWithValue("@PacienteID", pacienteID)
                    cmdInsert.Parameters.AddWithValue("@MedicoID", medicoID)
                    cmdInsert.Parameters.AddWithValue("@Fecha", dtpFecha.Value.Date)
                    cmdInsert.Parameters.AddWithValue("@Hora", dtpHora.Value)
                    cmdInsert.Parameters.AddWithValue("@Motivo", txtMotivo.Text.Trim())
                    cmdInsert.ExecuteNonQuery()
                End Using

                MessageBox.Show("Cita guardada correctamente.")

            Else
                ' 🔹 UPDATE
                Dim queryUpdate As String =
                "UPDATE Citas SET PacienteID=@PacienteID, MedicoID=@MedicoID, " &
                "Fecha=@Fecha, Hora=@Hora, Motivo=@Motivo WHERE CitaID=@CitaID"

                Using cmdUpdate As New SqlCommand(queryUpdate, conexion)
                    cmdUpdate.Parameters.AddWithValue("@PacienteID", pacienteID)
                    cmdUpdate.Parameters.AddWithValue("@MedicoID", medicoID)
                    cmdUpdate.Parameters.AddWithValue("@Fecha", dtpFecha.Value.Date)
                    cmdUpdate.Parameters.AddWithValue("@Hora", dtpHora.Value)
                    cmdUpdate.Parameters.AddWithValue("@Motivo", txtMotivo.Text.Trim())
                    cmdUpdate.Parameters.AddWithValue("@CitaID", CInt(txtIDCita.Text))
                    cmdUpdate.ExecuteNonQuery()
                End Using

                MessageBox.Show("Cita actualizada correctamente.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error al guardar la cita: " & ex.Message)

        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try

        ' 🔹 Limpiar formulario para nueva entrada
        BtnNuevo.PerformClick()

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim query As String =
    "SELECT C.CitaID AS [ID Cita], C.PacienteID, C.MedicoID, " &
    "P.Nombre + ' ' + P.Apellido AS Paciente, " &
    "M.Nombre + ' ' + M.Apellido AS Medico, " &
    "C.Fecha, " &
   "ISNULL(CONVERT(varchar(8), C.Hora, 108), '') AS Hora, " &
    "C.Motivo " &
    "FROM Citas C " &
    "INNER JOIN Pacientes P ON C.PacienteID = P.PacienteID " &
    "INNER JOIN Medicos M ON C.MedicoID = M.MedicoID " &
    "WHERE C.Fecha BETWEEN @FechaDesde AND @FechaHasta"

        Try
            Dim comando As New SqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@FechaDesde", dtpFechaDesde.Value.Date)
            comando.Parameters.AddWithValue("@FechaHasta", dtpFechaHasta.Value.Date)

            Dim adaptador As New SqlDataAdapter(comando)
            Dim tabla As New DataTable()

            adaptador.Fill(tabla)

            dgvCitas.DataSource = Nothing
            dgvCitas.Columns.Clear()
            dgvCitas.AutoGenerateColumns = True
            dgvCitas.DataSource = tabla

            dgvCitas.Columns("ID Cita").Visible = False
            dgvCitas.Columns("PacienteID").Visible = False
            dgvCitas.Columns("MedicoID").Visible = False

            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvCitas.Columns("Fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvCitas.Columns("Hora").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvCitas.ReadOnly = True
            dgvCitas.AllowUserToAddRows = False

        Catch ex As Exception
            MessageBox.Show("Error al consultar las citas: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvCitas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCitas.CellClick
        If e.RowIndex >= 0 Then
            Dim fila = dgvCitas.Rows(e.RowIndex)

            txtIDCita.Text = fila.Cells("ID Cita").Value.ToString
            txtIDPaciente.Text = fila.Cells("PacienteID").Value.ToString
            txtPaciente.Text = fila.Cells("Paciente").Value.ToString

            cmbMedico.SelectedValue = Convert.ToInt32(fila.Cells("MedicoID").Value)

            dtpFecha.Value = Convert.ToDateTime(fila.Cells("Fecha").Value)
            dtpHora.Value = Date.Today.Add(TimeSpan.Parse(fila.Cells("Hora").Value.ToString))
            txtMotivo.Text = fila.Cells("Motivo").Value.ToString
        End If
    End Sub

    Private Sub dgvPacientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPacientes.CellClick

        If e.RowIndex >= 0 Then

            Dim fila As DataGridViewRow = dgvPacientes.Rows(e.RowIndex)

            txtIDPaciente.Text = fila.Cells("PacienteID").Value.ToString()

            txtPaciente.Text = fila.Cells("Nombre").Value.ToString() & " " &
                           fila.Cells("Apellido").Value.ToString()

        End If

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        ' Datos de cita
        txtIDCita.Clear()
        txtIDPaciente.Clear()
        txtPaciente.Clear()
        cmbMedico.SelectedIndex = -1
        dtpFecha.Value = DateTime.Now
        dtpHora.Value = DateTime.Now
        txtMotivo.Clear()

        ' 🔹 Limpiar buscador de paciente
        txtBuscarPaciente.Clear()
        dgvPacientes.DataSource = Nothing

    End Sub

    Private Sub BtnBuscarPaciente_Click(sender As Object, e As EventArgs) Handles BtnBuscarPaciente.Click

        Dim query As String = "SELECT PacienteID, Nombre, Apellido, Telefono " &
                          "FROM Pacientes " &
                          "WHERE Nombre LIKE @criterio OR Apellido LIKE @criterio"

        Try
            Dim comando As New SqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@criterio", "%" & txtBuscarPaciente.Text.Trim() & "%")

            Dim adaptador As New SqlDataAdapter(comando)
            Dim tabla As New DataTable()

            adaptador.Fill(tabla)

            dgvPacientes.DataSource = tabla

            ' 🔴 IMPORTANTE: ocultar ID
            dgvPacientes.Columns("PacienteID").Visible = False

            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvPacientes.ReadOnly = True

        Catch ex As Exception
            MessageBox.Show("Error al buscar pacientes: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

End Class