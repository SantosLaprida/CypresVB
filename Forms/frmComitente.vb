Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Public Class frmComitente

    Public IdComitente As Integer = 0
    Public ComitenteEditado As Comitente
    Public comitenteRepositiorio As New ComitenteRepositorio()
    Public paisRepositorio As New PaisRepositorio()

    Private Sub frmComitente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PaisesLlenarCombo(ComboBoxPais, True)

        If IdComitente > 0 Then
            Me.Text = "Editar Comitente"
            Dim c As Comitente = comitenteRepositiorio.ObtenerComitentePorId(IdComitente)
            CargarComitente(c)

        Else
            Me.Text = "Nuevo Comitente"
            txtSigla.Focus()

        End If
        RedondearBoton(btnGuardar, 10)
        'RedondearBoton(btnCancelar, 20)
    End Sub
    Private Sub CargarComitente(c As Comitente)
        '      Public Property Id As Integer
        'Public Property Sigla As String
        'Public Property Nombre As String
        'Public Property Direccion As String
        'Public Property Localidad As String
        'Public Property CPostal As String
        'Public Property Pais As Integer
        'Public Property telefono As String

        If c Is Nothing Then Exit Sub

        'lbl_Id.Text = c.Id.ToString()
        txtSigla.Text = c.Sigla
        txtComitente.Text = c.Nombre
        txtDireccion.Text = c.Direccion
        txtLocalidad.Text = c.Localidad
        txtCPostal.Text = c.CPostal
        txtTelefono.Text = c.telefono
        If c.Pais > 0 Then
            ComboBoxPais.SelectedValue = c.Pais
        End If
        If c.tipo = 1 Then
            rad_publico.Checked = True
        End If
        If c.tipo = 2 Then
            rad_privado.Checked = True
        End If
        txtMail.Text = c.Email

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim c As New Comitente

        c.Id = IdComitente
        c.Sigla = txtSigla.Text.Trim()
        c.Nombre = txtComitente.Text.Trim()
        c.Direccion = txtDireccion.Text.Trim()
        c.Localidad = txtLocalidad.Text.Trim()
        c.CPostal = txtCPostal.Text.Trim()
        c.telefono = txtTelefono.Text.Trim()

        If ComboBoxPais.SelectedValue IsNot Nothing Then
            c.Pais = Convert.ToInt32(ComboBoxPais.SelectedValue)
        Else
            c.Pais = 0
        End If
        If rad_publico.Checked = True Then
            c.tipo = 1
        End If
        If rad_privado.Checked = True Then
            c.tipo = 2
        End If
        Try

            comitenteRepositiorio.GuardarComitente(c)

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
    Private Sub RedondearBoton(btn As Button, radio As Integer)

        Dim path As New GraphicsPath()

        path.StartFigure()
        path.AddArc(0, 0, radio, radio, 180, 90)
        path.AddArc(btn.Width - radio, 0, radio, radio, 270, 90)
        path.AddArc(btn.Width - radio, btn.Height - radio, radio, radio, 0, 90)
        path.AddArc(0, btn.Height - radio, radio, radio, 90, 90)
        path.CloseFigure()

        btn.Region = New Region(path)

    End Sub

End Class