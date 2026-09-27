Public Class Form1
    Private Sub btnPacientes_Click(sender As Object, e As EventArgs) Handles btnPacientes.Click
        frmPacientes.Show()
    End Sub

    Private Sub btnCitas_Click(sender As Object, e As EventArgs) Handles btnCitas.Click
        frmCitas.Show()
    End Sub

    Private Sub btnMedicos_Click(sender As Object, e As EventArgs) Handles btnMedicos.Click
        frmMedicos.Show()
    End Sub

    Private Sub btnSignosVitales_Click(sender As Object, e As EventArgs) Handles btnSignosVitales.Click
        frmSignosVitales.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class