Public Class frmAgregarPais

    Private ReadOnly paisRepositorio As New PaisRepositorio()
    Public pais As modPaises

    Private Sub frmAgregarPais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If pais IsNot Nothing Then
            txtDescripcion.Text = pais.Descripcion
        Else
            pais = New modPaises()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If String.IsNullOrWhiteSpace(txtDescripcion.Text) Then
            MessageBox.Show("Ingrese una descripción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        pais.Descripcion = txtDescripcion.Text
        If pais.Id = 0 Then
            paisRepositorio.GuardarPais(pais)
        Else
            paisRepositorio.GuardarPais(pais)
        End If
        DialogResult = DialogResult.OK
        Close()
    End Sub
End Class