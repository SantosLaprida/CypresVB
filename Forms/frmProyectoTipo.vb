Public Class frmProyectoTipo
    Private cargando As Boolean = False
    Private ReadOnly ProyectoTipoRepositorio As New ProyectoTipoRepositorio()
    'Public paisRepositorio As New PaisRepositorio()
    Private Sub frmProyectoTipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargando = True
        ProyectoTipoLlenarLista(lstProyectoTipo, False)
        lstProyectoTipo.Font = New Font(lstProyectoTipo.Font, FontStyle.Bold)
        lstProyectoTipo.SelectedIndex = -1
        txtProyectoTipo.Text = ""
    End Sub
    Private Sub lstProyectoTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProyectoTipo.SelectedIndexChanged
        Dim c As modProyectoTipo

        c = ProyectoTipoRepositorio.ObtenerProyectoTipoPorId(lstProyectoTipo.SelectedValue)

        If c IsNot Nothing Then
            txtProyectoTipo.Text = c.Descripcion
        Else
            txtProyectoTipo.Text = ""
        End If

    End Sub
    Private Sub btnAgregar_click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim c As New modProyectoTipo
        c.Id_tipo = 0
        c.Descripcion = txtProyectoTipo.Text.Trim()

        If c.Descripcion = "" Then
            MessageBox.Show("Ingrese una descripción.")
            Exit Sub
        End If

        If ProyectoTipoRepositorio.ExisteProyectoTipo(c.Descripcion, c.Id_tipo) Then
            MessageBox.Show("Ya existe un tipo de proyecto con esa descripción.")
            txtProyectoTipo.Focus()
            Exit Sub
        End If

        ' Si pasa validación → guardar
        ProyectoTipoRepositorio.GuardarProyectoTipo(c)

        ProyectoTipoLlenarLista(lstProyectoTipo, False)
        txtProyectoTipo.Text = ""
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim c As New modProyectoTipo
        c = ProyectoTipoRepositorio.ObtenerProyectoTipoPorId(lstProyectoTipo.SelectedValue)
        c.Descripcion = txtProyectoTipo.Text.Trim()

        If c.Descripcion = "" Then
            MessageBox.Show("Ingrese una descripción.")
            Exit Sub
        End If

        If ProyectoTipoRepositorio.ExisteProyectoTipo(c.Descripcion, c.Id_tipo) Then
            MessageBox.Show("Ya existe un tipo de proyecto con esa descripción.")
            txtProyectoTipo.Focus()
            Exit Sub
        End If

        ' Si pasa validación → guardar
        ProyectoTipoRepositorio.GuardarProyectoTipo(c)

        ProyectoTipoLlenarLista(lstProyectoTipo, False)
        txtProyectoTipo.Text = ""

    End Sub
End Class