Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Drawing
Public Class frmPaises
    Private cargando As Boolean = False
    Private ReadOnly paisRepositorio As New PaisRepositorio()
    Private pnlBotones As Panel
    Private Sub frm_Paises_Load(
    sender As Object, e As EventArgs) Handles MyBase.Load

        CrearEncabezado()
        paisRepositorio.ObtenerPaises()
        PaisesLlenarLista(lstPaises, True)
        btnEliminar.Enabled = False
        btnModificar.Enabled = False

    End Sub

    Private Sub CrearEncabezado()

        pnlSuperior.BackColor = Color.FromArgb(19, 48, 73)
        pnlLateral.BackColor = pnlSuperior.BackColor
        btnAgregar.BackColor = pnlSuperior.BackColor
        btnModificar.BackColor = pnlSuperior.BackColor
        btnEliminar.BackColor = pnlSuperior.BackColor
        btnSalir.BackColor = pnlSuperior.BackColor

    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim paisId As Integer = CInt(lstPaises.SelectedValue)

        Dim confirmacion As DialogResult = MessageBox.Show(
            "¿Está seguro de que desea eliminar el país seleccionado?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If confirmacion = DialogResult.Yes Then
            paisRepositorio.EliminarPais(paisId)
            PaisesLlenarLista(lstPaises, True)

        End If

    End Sub



    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub lstPaises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPaises.SelectedIndexChanged
        Dim haySeleccion As Boolean = lstPaises.SelectedIndex > 0 AndAlso
                                  lstPaises.SelectedItem.ToString() <> "..."
        btnModificar.Enabled = haySeleccion
        btnEliminar.Enabled = haySeleccion
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim f As New frmAgregarPais
        If f.ShowDialog() = DialogResult.OK Then
            paisRepositorio.ObtenerPaises()
            PaisesLlenarLista(lstPaises, True)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim f As New frmAgregarPais
        f.pais = paisRepositorio.ObtenerPaisPorId(CInt(lstPaises.SelectedValue))
        If f.ShowDialog() = DialogResult.OK Then
            paisRepositorio.ObtenerPaises()
            PaisesLlenarLista(lstPaises, True)
        End If
    End Sub
End Class