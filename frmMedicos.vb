Imports Microsoft.Data.SqlClient

Public Class frmMedicos

    Dim conexion As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ClinicaMedicaDB;Integrated Security=True")
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If txtNombre.Text.Trim() = "" Or txtApellido.Text.Trim() = "" Or cmbEspecialidad.Text.Trim() = "" Or txtTelefono.Text.Trim() = "" Or txtEmail.Text.Trim() = "" Or cmbHorario.Text.Trim() = "" Then
            MessageBox.Show("Debe completar todos los campos antes de guardar.")
            Exit Sub
        End If

        Try
            conexion.Open()

            If txtIDMedico.Text.Trim() = "" Then

                Dim queryExiste As String =
                "SELECT COUNT(*) FROM Medicos WHERE Nombre=@Nombre AND Apellido=@Apellido"

                Using cmdExiste As New SqlCommand(queryExiste, conexion)
                    cmdExiste.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim())
                    cmdExiste.Parameters.AddWithValue("@Apellido", txtApellido.Text.Trim())
                    cmdExiste.Parameters.AddWithValue("@Especialidad", cmbEspecialidad.Text.Trim())

                    If CInt(cmdExiste.ExecuteScalar()) > 0 Then
                        MessageBox.Show("Este médico ya existe en la base de datos.")
                        Exit Sub
                    End If
                End Using

                Dim queryInsert As String =
                "INSERT INTO Medicos (Nombre, Apellido, Especialidad, Telefono, Email, Horario) " &
                "VALUES (@Nombre, @Apellido, @Especialidad, @Telefono, @Email, @Horario)"

                Using cmdInsert As New SqlCommand(queryInsert, conexion)
                    cmdInsert.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim())
                    cmdInsert.Parameters.AddWithValue("@Apellido", txtApellido.Text.Trim())
                    cmdInsert.Parameters.AddWithValue("@Especialidad", cmbEspecialidad.Text.Trim())
                    cmdInsert.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim())
                    cmdInsert.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                    cmdInsert.Parameters.AddWithValue("@Horario", cmbHorario.Text.Trim())
                    cmdInsert.ExecuteNonQuery()
                End Using

                MessageBox.Show("Médico guardado correctamente.")

            Else

                Dim queryUpdate As String =
                "UPDATE Medicos SET Nombre=@Nombre, Apellido=@Apellido, Especialidad=@Especialidad, " &
                "Telefono=@Telefono, Email=@Email, Horario=@Horario WHERE MedicoID=@MedicoID"

                Using cmdUpdate As New SqlCommand(queryUpdate, conexion)
                    cmdUpdate.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim())
                    cmdUpdate.Parameters.AddWithValue("@Apellido", txtApellido.Text.Trim())
                    cmdUpdate.Parameters.AddWithValue("@Especialidad", cmbEspecialidad.Text.Trim())
                    cmdUpdate.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim())
                    cmdUpdate.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                    cmdUpdate.Parameters.AddWithValue("@Horario", cmbHorario.Text.Trim())
                    cmdUpdate.Parameters.AddWithValue("@MedicoID", CInt(txtIDMedico.Text))
                    cmdUpdate.ExecuteNonQuery()
                End Using

                MessageBox.Show("Médico actualizado correctamente.")

            End If

        Catch ex As Exception
            MessageBox.Show("Error al guardar médico: " & ex.Message)

        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try

        BtnNuevo.PerformClick()
        BtnBuscar.PerformClick()

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        txtIDMedico.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        cmbEspecialidad.SelectedIndex = -1
        txtTelefono.Clear()
        txtEmail.Clear()
        cmbHorario.SelectedIndex = -1
        txtNombre.Focus()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        Dim query As String =
    "SELECT MIN(MedicoID) AS MedicoID, Nombre, Apellido, Especialidad, Telefono, Email, Horario " &
    "FROM Medicos " &
    "WHERE (@Nombre = '' OR Nombre LIKE @NombreFiltro) " &
    "AND (@Apellido = '' OR Apellido LIKE @ApellidoFiltro) " &
    "AND (@Especialidad = '' OR Especialidad = @Especialidad) " &
    "GROUP BY Nombre, Apellido, Especialidad, Telefono, Email, Horario " &
    "ORDER BY Nombre, Apellido"

        Try
            Dim comando As New SqlCommand(query, conexion)

            ' 🔥 AQUÍ VAN LOS PARÁMETROS
            comando.Parameters.AddWithValue("@Nombre", txtFiltroNombre.Text.Trim())
            comando.Parameters.AddWithValue("@NombreFiltro", "%" & txtFiltroNombre.Text.Trim() & "%")

            comando.Parameters.AddWithValue("@Apellido", txtFiltroApellido.Text.Trim())
            comando.Parameters.AddWithValue("@ApellidoFiltro", "%" & txtFiltroApellido.Text.Trim() & "%")

            comando.Parameters.AddWithValue("@Especialidad", cmbFiltroEspecialidad.Text.Trim())

            Dim adaptador As New SqlDataAdapter(comando)
            Dim tabla As New DataTable()

            adaptador.Fill(tabla)

            dgvMedicos.DataSource = Nothing
            dgvMedicos.Columns.Clear()
            dgvMedicos.AutoGenerateColumns = True
            dgvMedicos.DataSource = tabla

            dgvMedicos.Columns("MedicoID").Visible = False

            dgvMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvMedicos.ReadOnly = True
            dgvMedicos.AllowUserToAddRows = False

        Catch ex As Exception
            MessageBox.Show("Error al consultar médicos: " & ex.Message)
        End Try

    End Sub

    Private Sub dgvMedicos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMedicos.CellDoubleClick
        If e.RowIndex >= 0 Then
            txtIDMedico.Text = dgvMedicos.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtNombre.Text = dgvMedicos.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtApellido.Text = dgvMedicos.Rows(e.RowIndex).Cells(2).Value.ToString()
            cmbEspecialidad.Text = dgvMedicos.Rows(e.RowIndex).Cells(3).Value.ToString()
            txtTelefono.Text = dgvMedicos.Rows(e.RowIndex).Cells(4).Value.ToString()
            txtEmail.Text = dgvMedicos.Rows(e.RowIndex).Cells(5).Value.ToString()
            cmbHorario.Text = dgvMedicos.Rows(e.RowIndex).Cells(6).Value.ToString()
        End If
    End Sub

    Private Sub frmMedicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim query As String = "SELECT DISTINCT Especialidad FROM Medicos"

            Dim comando As New SqlCommand(query, conexion)
            Dim adaptador As New SqlDataAdapter(comando)
            Dim tabla As New DataTable()

            adaptador.Fill(tabla)

            cmbEspecialidad.DataSource = tabla
            cmbEspecialidad.DisplayMember = "Especialidad"
            cmbEspecialidad.SelectedIndex = -1

            ' También para el filtro
            cmbFiltroEspecialidad.DataSource = tabla.Copy()
            cmbFiltroEspecialidad.DisplayMember = "Especialidad"
            cmbFiltroEspecialidad.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error cargando especialidades: " & ex.Message)
        End Try

    End Sub

End Class