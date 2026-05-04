Imports System.Data
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Misc
Imports ZstdSharp.Unsafe
Public Class frmRubros
    Private cargando As Boolean = False
    Private ReadOnly rubroRepositorio As New RubroRepositorio()
    Private ReadOnly subrubroRepositorio As New SubrubroRepositorio()

    Private Sub frmRubros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargando = True
        InicializarListaRubros()
        lstRubros.SelectedIndex = -1
        txt_rubro.Text = ""
    End Sub
    Private Sub InicializarListaRubros()
        Dim dtRubros As DataTable = rubroRepositorio.ObtenerRubros()
        Dim drPlaceholder As DataRow = dtRubros.NewRow()
        drPlaceholder("id_rubro") = 0
        drPlaceholder("descripcion") = "..."
        dtRubros.Rows.InsertAt(drPlaceholder, 0)

        lstRubros.DisplayMember = "descripcion"
        lstRubros.ValueMember = "id_rubro"
        lstRubros.DataSource = dtRubros
        lstRubros.SelectedIndex = 0
        lstRubros.Font = New Font(lstRubros.Font, FontStyle.Bold)
    End Sub

    Private Sub lstRubros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRubros.SelectedIndexChanged
        Dim c As Rubros
        Dim id As Integer
        c = rubroRepositorio.ObtenerRubroPorId(lstRubros.SelectedValue)
        If c IsNot Nothing Then
            lblRubro.Text = c.descripcion
            id = c.Id
            InicializarListaSubrubros(c.Id)

        Else
            lblRubro.Text = ""
            lstSubrubros.DataSource=Nothing
        End If
    End Sub
    Private Sub lstRubros_DoubleClick(sender As Object, e As EventArgs) Handles lstRubros.DoubleClick
        Dim c As Rubros

        c = rubroRepositorio.ObtenerRubroPorId(lstRubros.SelectedValue)

        If c IsNot Nothing Then
            txt_rubro.Text = c.descripcion
        Else
            txt_rubro.Text = ""
        End If

    End Sub
    Private Sub btnAgregarRubro_click(sender As Object, e As EventArgs) Handles btnAgregarRubro.Click
        Dim c As New Rubros
        c.Id = 0
        c.descripcion = txt_rubro.Text.Trim

        If c.descripcion = "" Then
            MessageBox.Show("Ingrese una descripción.")
            Exit Sub
        End If

        If rubroRepositorio.ExisteRubro(c.descripcion, c.Id) Then
            MessageBox.Show("Ya existe un rubro con esa descripción.")
            txt_rubro.Focus()
            Exit Sub
        End If

        ' Si pasa validación → guardar
        rubroRepositorio.GuardarRubro(c)

        InicializarListaRubros()
        txt_rubro.Text = ""
    End Sub

    Private Sub btnModificarRubro_Click(sender As Object, e As EventArgs) Handles btnModificarRubro.Click
        Dim c As New Rubros
        c = rubroRepositorio.ObtenerRubroPorId(lstRubros.SelectedValue)
        c.descripcion = txt_rubro.Text.Trim

        If c.descripcion = "" Then
            MessageBox.Show("Ingrese una descripción.")
            Exit Sub
        End If

        If rubroRepositorio.ExisteRubro(c.descripcion, c.Id) Then
            MessageBox.Show("Ya existe un rubro con esa descripción.")
            txt_rubro.Focus()
            Exit Sub
        End If

        ' Si pasa validación → guardar
        rubroRepositorio.GuardarRubro(c)

        InicializarListaRubros()
        txt_rubro.Text = ""
    End Sub
    Private Sub InicializarListaSubrubros(id As Integer)
        Dim dtSubrubros As DataTable = SubrubroRepositorio.ObtenerSubrubros(id)
        Dim drPlaceholder As DataRow = dtSubrubros.NewRow()
        'drPlaceholder("id_subrubro") = 0
        'drPlaceholder("descripcion") = "..."
        'dtSubrubros.Rows.InsertAt(drPlaceholder, 0)

        lstSubrubros.DisplayMember = "descripcion"
        lstSubrubros.ValueMember = "id_subrubro"
        lstSubrubros.DataSource = dtSubrubros
        'lstSubrubros.SelectedIndex = 0
        lstSubrubros.Font = New Font(lstSubrubros.Font, FontStyle.Bold)
    End Sub
End Class