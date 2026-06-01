Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Public Class frmEmpresa
    Public Id As Integer = 0
    Public EmpresaEditada As Empresas
    Public EmpresasRepositorio As New EmpresasRepositorio()
    Public paisRepositorio As New PaisRepositorio()

    Private Sub frmEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PaisesLlenarCombo(ComboBoxPais, True)

        If Id > 0 Then
            Me.Text = "Editar Empresa"
            Dim c As Empresas = EmpresasRepositorio.ObtenerEmpresaPorId(Id)
            CargarEmpresa(c)

        Else
            Me.Text = "Nueva Empresa"
            txtComitente.Focus()

        End If

        CargarLogo(Id)

        ' PictureBox1.Image = Image.FromFile("GoogleDrive\Cypres\Logos\basaa.png")
        'RedondearBoton(btnGuardar, 10)
        'RedondearBoton(btnCancelar, 20)
    End Sub
    Private Sub CargarEmpresa(c As Empresas)
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
        txtComitente.Text = c.Nombre
        txtDireccion.Text = c.Direccion
        txtLocalidad.Text = c.Localidad
        txtCPostal.Text = c.CPostal
        txtTelefono.Text = c.telefono
        If c.Pais > 0 Then
            ComboBoxPais.SelectedValue = c.Pais
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)

        Dim c As New Empresas

        c.Id = Id
        c.Nombre = txtComitente.Text.Trim
        c.Direccion = txtDireccion.Text.Trim
        c.Localidad = txtLocalidad.Text.Trim
        c.CPostal = txtCPostal.Text.Trim
        c.telefono = txtTelefono.Text.Trim

        If ComboBoxPais.SelectedValue IsNot Nothing Then
            c.Pais = Convert.ToInt32(ComboBoxPais.SelectedValue)
        Else
            c.Pais = 0
        End If
        Try

            EmpresasRepositorio.GuardarEmpresa(c)

            EmpresaEditada = c

            DialogResult = DialogResult.OK
            Close()

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Close()
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

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim c As New Empresas

        c.Id = Id
        c.Nombre = txtComitente.Text.Trim()
        c.Direccion = txtDireccion.Text.Trim()
        c.Localidad = txtLocalidad.Text.Trim()
        c.CPostal = txtCPostal.Text.Trim()
        If ComboBoxPais.SelectedValue IsNot Nothing Then
            c.Pais = Convert.ToInt32(ComboBoxPais.SelectedValue)
        Else
            c.Pais = 0
        End If
        c.telefono = txtTelefono.Text.Trim()

        Try

            EmpresasRepositorio.GuardarEmpresa(c)

            EmpresaEditada = c

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        End Try

    End Sub

    Private Sub btnLogo_Click(sender As Object,
                          e As EventArgs) _
                          Handles btnLogo.Click

        If Id = 0 Then
            MessageBox.Show("Primero debe guardar la empresa.")
            Exit Sub
        End If

        Dim dlg As New OpenFileDialog

        dlg.Title = "Seleccionar Logo"
        dlg.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp"

        If dlg.ShowDialog() = DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(dlg.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom

            Dim repo As New EmpresasRepositorio
            repo.EmpresaGuardarLogo(Id, dlg.FileName)

        End If

    End Sub
    Private Sub CargarLogo(idEmpresa As Integer)

        Dim repo As New EmpresasRepositorio
        Dim bytes() As Byte = repo.EmpresaObtenerLogo(idEmpresa)

        If bytes Is Nothing Then
            PictureBox1.Image = Nothing
            Exit Sub
        End If

        Using ms As New IO.MemoryStream(bytes)
            PictureBox1.Image = Image.FromStream(ms)
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End Using

    End Sub
End Class