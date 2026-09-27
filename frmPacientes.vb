Imports Microsoft.Data.SqlClient

Public Class frmPacientes

    Dim conexion As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ClinicaMedicaDB;Integrated Security=True")
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEdad.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If txtNombre.Text = "" Or txtApellido.Text = "" Or txtEdad.Text = "" Then
            MessageBox.Show("Debe completar los campos obligatorios.")
            Exit Sub
        End If

        Try
            conexion.Open()

            ' 🔥 VALIDAR SI YA EXISTE
            Dim queryExiste As String =
"SELECT COUNT(*) FROM Pacientes WHERE Nombre=@Nombre AND Apellido=@Apellido AND FechaNacimiento=@FechaNacimiento"

            Using cmdExiste As New SqlCommand(queryExiste, conexion)
                cmdExiste.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim())
                cmdExiste.Parameters.AddWithValue("@Apellido", txtApellido.Text.Trim())
                cmdExiste.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNac.Value.Date)

                If CInt(cmdExiste.ExecuteScalar()) > 0 And txtIDPaciente.Text = "" Then
                    MessageBox.Show("Este paciente ya existe.")
                    Exit Sub
                End If
            End Using

            ' 🔽 AQUÍ SIGUE TU INSERT NORMAL
            If txtIDPaciente.Text = "" Then
                ' INSERT
                Dim query As String =
            "INSERT INTO Pacientes (Nombre, Apellido, Edad, Sexo, Telefono, Email, Ciudad, PlanMedico, FechaNacimiento)
            VALUES (@Nombre, @Apellido, @Edad, @Sexo, @Telefono, @Email, @Ciudad, @PlanMedico, @FechaNacimiento)"

                Using cmd As New SqlCommand(query, conexion)
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                    cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text)
                    cmd.Parameters.AddWithValue("@Edad", txtEdad.Text)
                    cmd.Parameters.AddWithValue("@Sexo", cmbSexo.Text)
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@Ciudad", cmbCiudad.Text)
                    cmd.Parameters.AddWithValue("@PlanMedico", cmbPlanMedico.Text)
                    cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNac.Value.Date)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Paciente guardado correctamente.")

            Else
                ' UPDATE
                Dim query As String =
                "UPDATE Pacientes SET Nombre=@Nombre, Apellido=@Apellido, Edad=@Edad, " &
                "Sexo=@Sexo, Telefono=@Telefono, Email=@Email, Ciudad=@Ciudad, PlanMedico=@PlanMedico, " &
                "FechaNacimiento=@FechaNacimiento " &
                "WHERE PacienteID=@ID"

                Using cmd As New SqlCommand(query, conexion)
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                    cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text)
                    cmd.Parameters.AddWithValue("@Edad", txtEdad.Text)
                    cmd.Parameters.AddWithValue("@Sexo", cmbSexo.Text)
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@Ciudad", cmbCiudad.Text)
                    cmd.Parameters.AddWithValue("@PlanMedico", cmbPlanMedico.Text)
                    cmd.Parameters.AddWithValue("@ID", txtIDPaciente.Text)
                    cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNac.Value.Date)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Paciente actualizado correctamente.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try

        BtnNuevo.PerformClick()
        BtnBuscar.PerformClick()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        txtIDPaciente.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtEdad.Clear()
        txtTelefono.Clear()
        txtEmail.Clear()
        cmbSexo.SelectedIndex = -1
        cmbCiudad.SelectedIndex = -1
        cmbPlanMedico.SelectedIndex = -1
        dtpFechaNac.Value = DateTime.Now
        txtNombre.Focus()
    End Sub

    Private Sub txtFiltroNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltroNombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFiltroApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltroApellido.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        Dim query As String =
        "SELECT MIN(PacienteID) AS PacienteID, Nombre, Apellido, Edad, Sexo, Telefono, Email, Ciudad, PlanMedico " &
        "FROM Pacientes " &
        "WHERE (@Nombre = '' OR Nombre LIKE @NombreFiltro) " &
        "AND (@Apellido = '' OR Apellido LIKE @ApellidoFiltro) " &
        "AND (@Sexo = '' OR Sexo = @Sexo) " &
        "AND (@PlanMedico = '' OR PlanMedico = @PlanMedico) " &
        "GROUP BY Nombre, Apellido, Edad, Sexo, Telefono, Email, Ciudad, PlanMedico " &
        "ORDER BY Nombre, Apellido"

        Try
            Dim comando As New SqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@Nombre", txtFiltroNombre.Text.Trim())
            comando.Parameters.AddWithValue("@NombreFiltro", "%" & txtFiltroNombre.Text.Trim() & "%")

            comando.Parameters.AddWithValue("@Apellido", txtFiltroApellido.Text.Trim())
            comando.Parameters.AddWithValue("@ApellidoFiltro", "%" & txtFiltroApellido.Text.Trim() & "%")

            comando.Parameters.AddWithValue("@Sexo", cmbFiltroSexo.Text.Trim())
            comando.Parameters.AddWithValue("@PlanMedico", cmbFiltroPlanMedico.Text.Trim())
            Dim adaptador As New SqlDataAdapter(comando)
            Dim tabla As New DataTable()

            adaptador.Fill(tabla)

            dgvPacientes.DataSource = Nothing
            dgvPacientes.Columns.Clear()
            dgvPacientes.AutoGenerateColumns = True
            dgvPacientes.DataSource = tabla

            dgvPacientes.Columns("Email").Width = 200
            dgvPacientes.Columns("PacienteID").Visible = False
            dgvPacientes.Columns("Edad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPacientes.Columns("Sexo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvPacientes.AllowUserToAddRows = False

        Catch ex As Exception
            MessageBox.Show("Error al consultar: " & ex.Message)
        End Try

    End Sub

    Private Sub dgvPacientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPacientes.CellDoubleClick
        If e.RowIndex >= 0 Then
            txtIDPaciente.Text = dgvPacientes.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtNombre.Text = dgvPacientes.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtApellido.Text = dgvPacientes.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtEdad.Text = dgvPacientes.Rows(e.RowIndex).Cells(3).Value.ToString()
            cmbSexo.Text = dgvPacientes.Rows(e.RowIndex).Cells(4).Value.ToString()
            txtTelefono.Text = dgvPacientes.Rows(e.RowIndex).Cells(5).Value.ToString()
            txtEmail.Text = dgvPacientes.Rows(e.RowIndex).Cells(6).Value.ToString()
            cmbCiudad.Text = dgvPacientes.Rows(e.RowIndex).Cells(7).Value.ToString()
            cmbPlanMedico.Text = dgvPacientes.Rows(e.RowIndex).Cells(8).Value.ToString()
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class