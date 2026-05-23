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
        Cargar_Licitaciones()
    End Sub
    Private Sub InicializarGrid()
        Grid.Dock = DockStyle.None
        Me.Controls.Add(Grid)
        Grid.ActivateCurrentCellBehavior = GridCellActivateAction.None

        'Tamaño y ubicacion de la grilla
        Grid.Top = 83
        Grid.Height = 400
        Grid.Width = 1800
        Grid.RowCount = 0
        Grid.ColCount = 8

        Grid.ColWidths(1) = 80 'Numero
        Grid.ColWidths(2) = 80 'Fecha
        Grid.ColWidths(3) = 80 'comitente
        Grid.ColWidths(4) = 315 'Denominacion
        Grid.ColWidths(5) = 100 'presupuesto oficial
        Grid.ColWidths(6) = 80 'Plazo
        Grid.ColWidths(7) = 80 'Pliego
        Grid.ColWidths(8) = 150 'estado
        Me.Controls.Add(Grid)

        Dim totalWidth As Integer = 0
        For col As Integer = 1 To Grid.ColCount
            totalWidth += Grid.ColWidths(col)

        Next
        Grid.Width = totalWidth

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
        Dim fila As Integer = 0

        For Each c As Licitaciones In lista
            fila += 1
            If fila > Grid.RowCount Then
                Grid.RowCount = fila
            End If

            Grid.RowHeights(fila) = 25
            Grid(fila, 1).Text = c.Numero.ToString()
            Grid(fila, 1).HorizontalAlignment = GridHorizontalAlignment.Center
            Grid(fila, 1).VerticalAlignment = GridVerticalAlignment.Middle
            Grid(fila, 2).HorizontalAlignment = GridHorizontalAlignment.Center
            Grid(fila, 2).VerticalAlignment = GridVerticalAlignment.Middle
            Grid(fila, 2).Text = c.FechaPresentacion
            Dim comitente As Comitente = comitenteRepositorio.ObtenerComitentePorId(c.Id_Comitente)
            Dim sigla As String = comitente.Sigla
            Grid(fila, 3).HorizontalAlignment = GridHorizontalAlignment.Center
            Grid(fila, 3).VerticalAlignment = GridVerticalAlignment.Middle
            Grid(fila, 3).Text = sigla
            Grid(fila, 4).Text = c.Denominacion
            Grid(fila, 4).VerticalAlignment = GridVerticalAlignment.Middle
            Grid(fila, 5).Format = "N2"
            Grid(fila, 5).CellValue = c.Pres_Oficial
            Grid(fila, 5).VerticalAlignment = GridVerticalAlignment.Middle
            Grid(fila, 5).HorizontalAlignment = GridHorizontalAlignment.Right
            Grid(fila, 6).Text = c.Plazo
            Grid(fila, 6).VerticalAlignment = GridVerticalAlignment.Middle
            Grid(fila, 6).HorizontalAlignment = GridHorizontalAlignment.Center
            Grid(fila, 7).VerticalAlignment = GridVerticalAlignment.Middle
            Grid(fila, 7).HorizontalAlignment = GridHorizontalAlignment.Center
            Grid(fila, 7).Text = c.Pliego
            'Grid(fila, 6).Text = c.CPostal
            'Grid(fila, 7).VerticalAlignment = GridVerticalAlignment.Middle
            'Grid(fila, 7).Text = c.telefono
            'PintarFila(fila)
        Next

    End Sub
    Private Sub grid_DoubleClick(sender As Object, e As EventArgs)

        Dim row As Integer = Grid.CurrentCell.RowIndex
        If row <= 0 Then Exit Sub

        filaSeleccionada = row

        Dim id As Integer = Val(Grid(row, 1).Text)

        Dim f As New frmComitente
        f.IdComitente = id

        If f.ShowDialog() = DialogResult.OK Then

            Dim c As Comitente = f.ComitenteEditado

            'ReubicarComitente(row, c)

        End If

    End Sub

    Private Sub Cargar_Licitaciones(Optional IdComitente As Integer = 0)

        listaLicitaciones = LicitacionesRepositorio.ObtenerLicitaciones(IdComitente)

        CargarGrid(listaLicitaciones)
    End Sub
End Class