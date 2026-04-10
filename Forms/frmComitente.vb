Imports MySql.Data.MySqlClient
Public Class frmComitente

    Public IdComitente As Integer = 0
    Public ComitenteEditado As Comitente
<<<<<<< HEAD
    Public ComitenteRepositiorio As New ComitenteRepositorio()

=======
    Public ComitenteRepositorio As New ComitenteRepositorio()
>>>>>>> 90de2d613c7de7b40a4365b2741eff155b4fde26
    Private cadena As String =
        "Server=35.199.107.210;Port=3306;Database=laprida_cypres;Uid=claprida;Pwd=lapridac;"

    Private Sub frmComitente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If IdComitente > 0 Then

<<<<<<< HEAD
            Dim c As Comitente = ComitenteRepositiorio.ObtenerComitentePorId(IdComitente)
=======
            Dim c As Comitente = ComitenteRepositorio.ObtenerComitentePorId(IdComitente)
>>>>>>> 90de2d613c7de7b40a4365b2741eff155b4fde26
            CargarComitente(c)

        Else

            txtSigla.Focus()

        End If

    End Sub
    Private Sub CargarComitente(c As Comitente)

        If c Is Nothing Then Exit Sub

        lbl_Id.Text = c.Id.ToString()
        txtSigla.Text = c.Sigla
        txtComitente.Text = c.Nombre
        txtDireccion.Text = c.Direccion
        txtLocalidad.Text = c.localidad
        txtCPostal.Text = c.cpostal

    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim c As New Comitente

        c.Id = IdComitente
        c.Sigla = txtSigla.Text.Trim()
        c.Nombre = txtComitente.Text.Trim()
        c.Direccion = txtDireccion.Text.Trim()
        c.Localidad = txtLocalidad.Text.Trim()
        c.CPostal = txtCPostal.Text.Trim()

        Try

<<<<<<< HEAD
            ComitenteRepositiorio.GuardarComitente(c)
=======
            ComitenteRepositorio.GuardarComitente(c)
>>>>>>> 90de2d613c7de7b40a4365b2741eff155b4fde26

            ComitenteEditado = c

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub


End Class