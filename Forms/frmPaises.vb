Imports System.Data
Imports MySql.Data.MySqlClient
Public Class frmPaises
    Private cargando As Boolean = False
    Private ReadOnly paisRepositorio As New PaisRepositorio()
    'Public paisRepositorio As New PaisRepositorio()
    Private Sub frmPaises_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargando = True
        PaisesLlenarLista(lstPaises, False)
        lstPaises.Font = New Font(lstPaises.Font, FontStyle.Bold)
        lstPaises.SelectedIndex = -1
        txt_pais.Text = ""
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
    Private Sub btnAgregar_click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim c As New modPaises
        c.Id = 0
        c.Descripcion = txt_pais.Text.Trim()

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

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim c As New modPaises
        c = paisRepositorio.ObtenerPaisPorId(lstPaises.SelectedValue)
        c.Descripcion = txt_pais.Text.Trim()

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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim c As New modPaises


    End Sub
End Class