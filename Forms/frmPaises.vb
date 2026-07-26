Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Drawing
Public Class frmPaises
    Private cargando As Boolean = False
    Private ReadOnly paisRepositorio As New PaisRepositorio()
    Private pnlBotones As Panel
    'Public paisRepositorio As New PaisRepositorio()
    Private Sub frm_Paises_Load(
    sender As Object,
    e As EventArgs
) Handles MyBase.Load

        CrearEncabezado()

        paisRepositorio.ObtenerPaises()
        PaisesLlenarLista(lstPaises, False)

    End Sub
    Private Sub CrearEncabezado()

        pnlSuperior.BackColor = Color.FromArgb(19, 48, 73)
        pnlLateral.BackColor = pnlSuperior.BackColor
        btnAgregar.BackColor = pnlSuperior.BackColor
        btnModificar.BackColor = pnlSuperior.BackColor
        btnEliminar.BackColor = pnlSuperior.BackColor
        btnSalir.BackColor = pnlSuperior.BackColor

    End Sub

    Private Sub lstPaises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPaises.SelectedIndexChanged
        Dim c As modPaises

        c = paisRepositorio.ObtenerPaisPorId(lstPaises.SelectedValue)

        If c IsNot Nothing Then
            txt_pais.Text = c.Descripcion
        Else
            txt_pais.Text = ""
        End If

    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub

    Private Sub btnAgregar_Click_1(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim c As New modPaises
        c.Id = 0
        c.Descripcion = txt_pais.Text.Trim

        If c.Descripcion = "" Then
            MessageBox.Show("Ingrese una descripción.")
            Exit Sub
        End If

        If paisRepositorio.ExistePais(c.Descripcion, c.Id) Then
            MessageBox.Show("Ya existe un país con esa descripción.")
            txt_pais.Focus()
            Exit Sub
        End If

        ' Si pasa validación → guardar
        paisRepositorio.GuardarPais(c)

        PaisesLlenarLista(lstPaises, False)
        txt_pais.Text = ""

    End Sub

    Private Sub btnModificar_Click_1(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim c As New modPaises
        c = paisRepositorio.ObtenerPaisPorId(lstPaises.SelectedValue)
        c.Descripcion = txt_pais.Text.Trim

        If c.Descripcion = "" Then
            MessageBox.Show("Ingrese una descripción.")
            Exit Sub
        End If

        If paisRepositorio.ExistePais(c.Descripcion, c.Id) Then
            MessageBox.Show("Ya existe un país con esa descripción.")
            txt_pais.Focus()
            Exit Sub
        End If

        ' Si pasa validación → guardar
        paisRepositorio.GuardarPais(c)

        PaisesLlenarLista(lstPaises, False)
        txt_pais.Text = ""

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class