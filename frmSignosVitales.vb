Imports Microsoft.Data.SqlClient

Public Class frmSignosVitales

    Dim conexion As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ClinicaMedicaDB;Integrated Security=True")

    Private Sub frmSignosVitales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIDRegistro.ReadOnly = True
        txtPaciente.ReadOnly = True
        txtIDPaciente.Visible = False
    End Sub

    Private Sub BtnBuscarPaciente_Click(sender As Object, e As EventArgs) Handles BtnBuscarPaciente.Click

        Dim query As String =
            "SELECT PacienteID, Nombre, Apellido, Telefono " &
            "FROM Pacientes " &
            "WHERE Nombre LIKE @criterio OR Apellido LIKE @criterio"

        Try
            Dim comando As New SqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@criterio", "%" & txtBuscarPaciente.Text.Trim() & "%")

            Dim adaptador As New SqlDataAdapter(comando)
            Dim tabla As New DataTable()

            adaptador.Fill(tabla)

            dgvPacientes.DataSource = Nothing
            dgvPacientes.Columns.Clear()
            dgvPacientes.AutoGenerateColumns = True
            dgvPacientes.DataSource = tabla

            dgvPacientes.Columns("PacienteID").Visible = False
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvPacientes.ReadOnly = True
            dgvPacientes.AllowUserToAddRows = False

        Catch ex As Exception
            MessageBox.Show("Error al buscar pacientes: " & ex.Message)
        End Try

    End Sub

    Private Sub dgvPacientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPacientes.CellClick

        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvPacientes.Rows(e.RowIndex)

            txtIDPaciente.Text = fila.Cells("PacienteID").Value.ToString()
            txtPaciente.Text = fila.Cells("Nombre").Value.ToString() & " " &
                               fila.Cells("Apellido").Value.ToString()
        End If

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If txtIDPaciente.Text.Trim() = "" Or txtPaciente.Text.Trim() = "" Then
            MessageBox.Show("Debe buscar y seleccionar un paciente.")
            Exit Sub
        End If

        If txtPresion.Text.Trim() = "" Or txtTemperatura.Text.Trim() = "" Or txtPeso.Text.Trim() = "" Or txtAltura.Text.Trim() = "" Or txtFrecuenciaCardiaca.Text.Trim() = "" Then
            MessageBox.Show("Debe completar todos los campos antes de guardar.")
            Exit Sub
        End If

        Try
            conexion.Open()

            Dim pacienteID As Integer = CInt(txtIDPaciente.Text)

            If txtIDRegistro.Text.Trim() = "" Then

                Dim queryInsert As String =
                    "INSERT INTO SignosVitales (PacienteID, Fecha, Presion, Temperatura, Peso, Altura, FrecuenciaCardiaca) " &
                    "VALUES (@PacienteID, @Fecha, @Presion, @Temperatura, @Peso, @Altura, @FrecuenciaCardiaca)"

                Using cmdInsert As New SqlCommand(queryInsert, conexion)
                    cmdInsert.Parameters.AddWithValue("@PacienteID", pacienteID)
                    cmdInsert.Parameters.AddWithValue("@Fecha", dtpFecha.Value.Date)
                    cmdInsert.Parameters.AddWithValue("@Presion", txtPresion.Text.Trim())
                    cmdInsert.Parameters.AddWithValue("@Temperatura", txtTemperatura.Text.Trim())
                    cmdInsert.Parameters.AddWithValue("@Peso", txtPeso.Text.Trim())
                    cmdInsert.Parameters.AddWithValue("@Altura", txtAltura.Text.Trim())
                    cmdInsert.Parameters.AddWithValue("@FrecuenciaCardiaca", txtFrecuenciaCardiaca.Text.Trim())
                    cmdInsert.ExecuteNonQuery()
                End Using

                MessageBox.Show("Registro guardado correctamente.")

            Else

                Dim queryUpdate As String =
                    "UPDATE SignosVitales SET PacienteID=@PacienteID, Fecha=@Fecha, Presion=@Presion, " &
                    "Temperatura=@Temperatura, Peso=@Peso, Altura=@Altura, FrecuenciaCardiaca=@FrecuenciaCardiaca " &
                    "WHERE RegistroID=@RegistroID"

                Using cmdUpdate As New SqlCommand(queryUpdate, conexion)
                    cmdUpdate.Parameters.AddWithValue("@PacienteID", pacienteID)
                    cmdUpdate.Parameters.AddWithValue("@Fecha", dtpFecha.Value.Date)
                    cmdUpdate.Parameters.AddWithValue("@Presion", txtPresion.Text.Trim())
                    cmdUpdate.Parameters.AddWithValue("@Temperatura", txtTemperatura.Text.Trim())
                    cmdUpdate.Parameters.AddWithValue("@Peso", txtPeso.Text.Trim())
                    cmdUpdate.Parameters.AddWithValue("@Altura", txtAltura.Text.Trim())
                    cmdUpdate.Parameters.AddWithValue("@FrecuenciaCardiaca", txtFrecuenciaCardiaca.Text.Trim())
                    cmdUpdate.Parameters.AddWithValue("@RegistroID", CInt(txtIDRegistro.Text))
                    cmdUpdate.ExecuteNonQuery()
                End Using

                MessageBox.Show("Registro actualizado correctamente.")

            End If

        Catch ex As Exception
            MessageBox.Show("Error al guardar signos vitales: " & ex.Message)

        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try

        BtnNuevo.PerformClick()

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        Dim query As String =
            "SELECT S.RegistroID, S.PacienteID, " &
            "P.Nombre + ' ' + P.Apellido AS Paciente, " &
            "S.Fecha, S.Presion, S.Temperatura, S.Peso, S.Altura, S.FrecuenciaCardiaca " &
            "FROM SignosVitales S " &
            "INNER JOIN Pacientes P ON S.PacienteID = P.PacienteID " &
            "WHERE S.Fecha BETWEEN @FechaDesde AND @FechaHasta"

        Try
            Dim comando As New SqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@FechaDesde", dtpFechaDesde.Value.Date)
            comando.Parameters.AddWithValue("@FechaHasta", dtpFechaHasta.Value.Date)

            Dim adaptador As New SqlDataAdapter(comando)
            Dim tabla As New DataTable()

            adaptador.Fill(tabla)

            dgvSignosVitales.DataSource = Nothing
            dgvSignosVitales.Columns.Clear()
            dgvSignosVitales.AutoGenerateColumns = True
            dgvSignosVitales.DataSource = tabla

            dgvSignosVitales.Columns("RegistroID").Visible = False
            dgvSignosVitales.Columns("PacienteID").Visible = False

            dgvSignosVitales.Columns("Temperatura").HeaderText = "Temp. °F"
            dgvSignosVitales.Columns("Peso").HeaderText = "Peso lb"
            dgvSignosVitales.Columns("Altura").HeaderText = "Altura pulg."
            dgvSignosVitales.Columns("FrecuenciaCardiaca").HeaderText = "Pulso"

            dgvSignosVitales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            dgvSignosVitales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            dgvSignosVitales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvSignosVitales.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvSignosVitales.ReadOnly = True
            dgvSignosVitales.AllowUserToAddRows = False


        Catch ex As Exception
            MessageBox.Show("Error al consultar signos vitales: " & ex.Message)
        End Try

    End Sub

    Private Sub dgvSignosVitales_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSignosVitales.CellDoubleClick

        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvSignosVitales.Rows(e.RowIndex)

            txtIDRegistro.Text = fila.Cells("RegistroID").Value.ToString()
            txtIDPaciente.Text = fila.Cells("PacienteID").Value.ToString()
            txtPaciente.Text = fila.Cells("Paciente").Value.ToString()
            dtpFecha.Value = Convert.ToDateTime(fila.Cells("Fecha").Value)
            txtPresion.Text = fila.Cells("Presion").Value.ToString()
            txtTemperatura.Text = fila.Cells("Temperatura").Value.ToString()
            txtPeso.Text = fila.Cells("Peso").Value.ToString()
            txtAltura.Text = fila.Cells("Altura").Value.ToString()
            txtFrecuenciaCardiaca.Text = fila.Cells("FrecuenciaCardiaca").Value.ToString()
        End If

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        txtIDRegistro.Clear()
        txtIDPaciente.Clear()
        txtPaciente.Clear()
        txtPresion.Clear()
        txtTemperatura.Clear()
        txtPeso.Clear()
        txtAltura.Clear()
        txtFrecuenciaCardiaca.Clear()
        txtBuscarPaciente.Clear()
        dgvPacientes.DataSource = Nothing
        dtpFecha.Value = DateTime.Now
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

End Class