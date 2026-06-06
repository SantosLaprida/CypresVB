Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Public Class frmLicitacion

    Public idLicitacion As Integer = 0
    Public licitacionEditada As Licitaciones
    Public licitacionesRepositorio As New LicitacionesRepositorio()
    Public comitenteRepositiorio As New ComitenteRepositorio()
    Public paisRepositorio As New PaisRepositorio()
    Public proyectotiporepositorio As New ProyectoTipoRepositorio
    Private Sub frmLicitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PaisesLlenarCombo(ComboBoxPais, True)
        ComitentesLlenarCombo(ComboBoxComitente, True)
        ProyectoTipoLlenarLlenarCombo(ComboTipoProyecto, True)
        EmpresasLlenarListaLicitacion(ListBoxOferentes, idLicitacion)

        If idLicitacion > 0 Then
            Me.Text = "Editar Licitación"
            Dim l As Licitaciones = licitacionesRepositorio.ObtenerLicitacionPorId(idLicitacion)
            CargarLicitacion(l)
        Else
            Me.Text = "Nueva Licitación"
        End If



    End Sub

    Private Sub CargarLicitacion(l As Licitaciones)
        If l Is Nothing Then Exit Sub
        txtBoxNumero.Text = l.Numero.ToString()
        ComboBoxComitente.SelectedValue = l.Id_Comitente
        ComboTipoProyecto.SelectedValue = l.IdTipoProyecto
        ComboBoxPais.SelectedValue = l.IdPais
        txtPresentacion.Text = l.LugarPresentacion
        txtApertura.Text = l.LugarApertura
        dateApertura.Value = Convert.ToDateTime(l.FechaApertura)
        datePresentacion.Value = Convert.ToDateTime(l.FechaPresentacion)
        timeApertura.Value = Convert.ToDateTime(l.HoraApertura)
        timePresentacion.Value = Convert.ToDateTime(l.HoraPresentacion)
        EmpresasLlenarListaLicitacion(ListBoxOferentes, idLicitacion)
    End Sub

    Private Sub btnAgregarOferentes_click(sender As Object, e As EventArgs) Handles btnAgregarOferentes.Click
        Dim f As New frmOferentes
        f.idLicitacion = idLicitacion

        If f.ShowDialog() = DialogResult.OK Then
            ListBoxOferentes.Items.Clear()
            For Each empresa As Empresas In f.EmpresasSeleccionadas
                ListBoxOferentes.Items.Add(empresa)
            Next
        End If


    End Sub
End Class