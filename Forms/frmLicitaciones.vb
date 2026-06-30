Imports Syncfusion
Imports Syncfusion.Windows.Forms.Grid

Public Class frmLicitaciones
    Private listaLicitaciones As List(Of Licitaciones)
    Private ReadOnly licitacionesRepositorio As New LicitacionesRepositorio()
    Private ReadOnly comitenteRepositorio As New ComitenteRepositorio()

    'Private grid As New GridControl()
    Private filaSeleccionada As Integer = 0
    Private Sub frmLicitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Grid.DoubleClick, AddressOf grid_DoubleClick
        InicializarGrid()
        PaisesLlenarCombo(ComboBoxPais, True)
        ComitentesLlenarCombo(ComboBoxComitente, True)
        ProyectoTipoLlenarLlenarCombo(ComboTipoProyecto, True)
        ObtenerEstados()
        LicEstadosLlenarLlenarCombo(ComboEstado, True)
        Cargar_Licitaciones()


    End Sub
    Private Sub InicializarGrid()
        Grid.Font = New Font("Segoe UI Semibold", 9)
        If Not Me.Controls.Contains(Grid) Then
            Me.Controls.Add(Grid)
        End If
        Grid.ActivateCurrentCellBehavior = GridCellActivateAction.None

        Grid.RowCount = 0
        Grid.ColCount = 8

        Grid.ColWidths(1) = 80
        Grid.ColWidths(2) = 80
        Grid.ColWidths(3) = 200
        Grid.ColWidths(4) = 315
        Grid.ColWidths(5) = 200
        Grid.ColWidths(6) = 80
        Grid.ColWidths(7) = 80
        Grid.ColWidths(8) = 200

        ' === Calculate Total Width ===
        Dim totalWidth As Integer = 0
        For col As Integer = 1 To Grid.ColCount
            totalWidth += Grid.ColWidths(col)
        Next

        Grid.Width = totalWidth
        Grid.Height = 600
        Grid.Top = Panel1.Bottom
        Grid.Left = 0

        Grid.RowHeights(0) = 35
        Grid(0, 1).Text = "Numero"
        Grid(0, 2).Text = "Fecha"
        Grid(0, 3).Text = "Comitente"
        Grid(0, 4).Text = "Denominacion"
        Grid(0, 5).Text = "P_Oficial"
        Grid(0, 6).Text = "P.(Meses)"
        Grid(0, 7).Text = "Pliego"
        Grid(0, 8).Text = "Estado"

        Me.ClientSize = New Size(Grid.Width, Me.ClientSize.Height)
    End Sub


    Private Sub CargarGrid(lista As List(Of Licitaciones))
        Grid.RowCount = 0
        filaSeleccionada = 0

        Dim comitentes As Dictionary(Of Integer, Comitente) = comitenteRepositorio _
        .ObtenerComitentes(0) _
        .ToDictionary(Function(c) c.Id)

        Grid.BeginUpdate()

        Dim fila As Integer = 0
        For Each c As Licitaciones In lista
            fila += 1
            If fila > Grid.RowCount Then Grid.RowCount = fila

            Grid.RowHeights(fila) = 35

            For col As Integer = 0 To Grid.ColCount
                Grid(fila, col).HorizontalAlignment = GridHorizontalAlignment.Center
                Grid(fila, col).VerticalAlignment = GridVerticalAlignment.Middle
            Next

            Grid(fila, 0).Text = c.Id_lic.ToString()
            Grid(fila, 1).Text = c.Numero.ToString()

            Dim fecha As Date
            If Date.TryParse(c.FechaPresentacion, fecha) Then
                Grid(fila, 2).Text = fecha.ToString("dd/MM/yyyy")
            Else
                Grid(fila, 2).Text = c.FechaPresentacion
            End If

            Dim sigla As String = ""
            Dim value As Comitente = Nothing
            If comitentes.TryGetValue(c.Id_Comitente, value) Then
                sigla = value.Sigla
            End If
            Grid(fila, 3).Text = sigla

            Grid(fila, 4).Text = c.Denominacion

            Grid(fila, 5).Format = "N2"
            Grid(fila, 5).CellValue = c.Pres_Oficial

            Grid(fila, 6).Text = c.Plazo
            Grid(fila, 7).Text = c.Pliego
            Grid(fila, 8).Text = ObtenerDescripcionEstado(c.Estado)
        Next

        Grid.EndUpdate()
    End Sub


    Private Sub AplicarFiltros()
        Dim idPais As Integer = Convert.ToInt32(ComboBoxPais.SelectedValue)
        Dim idComitente As Integer = Convert.ToInt32(ComboBoxComitente.SelectedValue)
        Dim idTipo As Integer = Convert.ToInt32(ComboTipoProyecto.SelectedValue)
        Dim idEstado As Integer = Convert.ToInt32(ComboEstado.SelectedValue)

        Dim filtrada = listaLicitaciones.Where(Function(l)
                                                   Return (idPais = 0 OrElse l.IdPais = idPais) AndAlso
                                                      (idComitente = 0 OrElse l.Id_Comitente = idComitente) AndAlso
                                                      (idTipo = 0 OrElse l.IdTipoProyecto = idTipo) AndAlso
                                                      (idEstado = 0 OrElse l.Estado = idEstado)
                                               End Function).ToList()

        CargarGrid(filtrada)
    End Sub
    Private Sub NuevoToolStripButton_Click(sender As Object, e As EventArgs) Handles NuevoToolStripButton.Click
        frmLicitacion.ShowDialog()
    End Sub

    Private Sub Cargar_Licitaciones(Optional IdComitente As Integer = 0)

        listaLicitaciones = licitacionesRepositorio.ObtenerLicitaciones(IdComitente)

        CargarGrid(listaLicitaciones)
    End Sub

    Private Sub grid_DoubleClick(sender As Object, e As EventArgs) Handles Grid.DoubleClick

        Dim row = Grid.CurrentCell.RowIndex
        If row <= 0 Then Exit Sub

        filaSeleccionada = row

        Dim id As Integer = Val(Grid(row, 0).Text)

        Dim f As New frmLicitacion
        f.idLicitacion = id

        If f.ShowDialog = DialogResult.OK Then
            Dim index = listaLicitaciones.FindIndex(Function(c) c.Id_lic = id)
            If index >= 0 Then
                listaLicitaciones(index) = f.licitacionEditada
                CargarGrid(listaLicitaciones)
            End If
        End If

    End Sub

    Private Sub ComboBoxPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPais.SelectedIndexChanged
        If listaLicitaciones Is Nothing Then Exit Sub
        AplicarFiltros()
    End Sub

    Private Sub ComboBoxComitente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTipoProyecto.SelectedIndexChanged
        If listaLicitaciones Is Nothing Then Exit Sub
        AplicarFiltros()
    End Sub

    Private Sub ComboEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboEstado.SelectedIndexChanged
        If listaLicitaciones Is Nothing Then Exit Sub
        AplicarFiltros()
    End Sub

    Private Sub ComboBoxTipoProyecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxComitente.SelectedIndexChanged
        If listaLicitaciones Is Nothing Then Exit Sub
        AplicarFiltros()
    End Sub

End Class