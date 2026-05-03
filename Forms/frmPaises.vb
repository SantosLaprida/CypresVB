Imports System.Data
Imports MySql.Data.MySqlClient
Public Class frmPaises
    Private cargando As Boolean = False
    Private ReadOnly paisRepositorio As New PaisRepositorio()
    'Public paisRepositorio As New PaisRepositorio()
    Private Sub frmPaises_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargando = True
        InicializarListaPaises()
        lstPaises.SelectedIndex = -1
        txt_pais.Text = ""
    End Sub
    Private Sub InicializarListaPaises()
        Dim dtPaises As DataTable = paisRepositorio.ObtenerPaises()
        Dim drPlaceholder As DataRow = dtPaises.NewRow()
        'drPlaceholder("id_pais") = 0
        'drPlaceholder("descripcion") = "..."
        'dtPaises.Rows.InsertAt(drPlaceholder, 0)

        lstPaises.DisplayMember = "descripcion"
        lstPaises.ValueMember = "id_pais"
        lstPaises.DataSource = dtPaises
        lstPaises.SelectedIndex = 0
        lstPaises.Font = New Font(lstPaises.Font, FontStyle.Bold)
    End Sub
    Private Sub lstPaises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPaises.SelectedIndexChanged
        Dim c As modPaises

        c = mPaises.ObtenerPaisPorId(lstPaises.SelectedValue)

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

        If mPaises.ExistePais(c.Descripcion, c.Id) Then
            MessageBox.Show("Ya existe un país con esa descripción.")
            txt_pais.Focus()
            Exit Sub
        End If

        ' Si pasa validación → guardar
        GuardarPais(c)

        InicializarListaPaises()
        txt_pais.Text = ""
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim c As New modPaises
        c = mPaises.ObtenerPaisPorId(lstPaises.SelectedValue)
        c.Descripcion = txt_pais.Text.Trim()

        If c.Descripcion = "" Then
            MessageBox.Show("Ingrese una descripción.")
            Exit Sub
        End If

        If mPaises.ExistePais(c.Descripcion, c.Id) Then
            MessageBox.Show("Ya existe un país con esa descripción.")
            txt_pais.Focus()
            Exit Sub
        End If

        ' Si pasa validación → guardar
        GuardarPais(c)

        InicializarListaPaises()
        txt_pais.Text = ""

    End Sub
End Class