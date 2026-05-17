Imports Syncfusion.Windows.Forms.Grid

Public Class frmProveedoresAdmin

    Private listProveedores As List(Of Proveedor)
    Private ReadOnly proveedorRepositorio As New ProveedorRepositorio()
    Private ReadOnly paisRepositorio As New PaisRepositorio()

    Private grid As New GridControl()
    Private filaSeleccionada As Integer = 0

    Private Sub frmComitentesAdm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'AddHandler grid.DoubleClick
        InicializarGrid()
        Cargar_Proveedores()

        'Cargar_Comitentes()
        'InicializarComboBoxPaises()

    End Sub


    Private Sub InicializarGrid()

        grid.Dock = DockStyle.None
        Me.Controls.Add(grid)

        grid.ActivateCurrentCellBehavior = GridCellActivateAction.None

        grid.Top = 83
        grid.Height = 400
        grid.Width = 1400

        grid.RowCount = 0
        grid.ColCount = 8

        ' Ancho de columnas
        grid.ColWidths(1) = 0   ' ID (hidden)
        grid.ColWidths(2) = 250 ' Nombre
        grid.ColWidths(3) = 250 ' Dirección
        grid.ColWidths(4) = 180 ' Localidad
        grid.ColWidths(5) = 180 ' Provincia
        grid.ColWidths(6) = 150 ' Teléfono
        grid.ColWidths(7) = 220 ' Email
        grid.ColWidths(8) = 100 ' Activo

        'Encabezado
        grid.RowHeights(0) = 35

        grid(0, 2).Text = "Nombre"
        grid(0, 3).Text = "Dirección"
        grid(0, 4).Text = "Localidad"
        grid(0, 5).Text = "Provincia"
        grid(0, 6).Text = "Teléfono"
        grid(0, 7).Text = "Email"
        grid(0, 8).Text = "Activo"

    End Sub

    'Public Property Id As Integer
    'Public Property Nombre As String
    'Public Property Direccion As String
    'Public Property Localidad As String
    'Public Property CPostal As String
    'Public Property Provincia As String
    'Public Property Pais As Integer
    'Public Property telefono As String
    'Public Property Celular As String
    'Public Property Email As String
    'Public Property Cuit As String
    'Public Property PaginaWeb As Integer
    'Public Property Contacto As String
    'Public Property comentarios As String
    'Public Property Activo As Boolean

    Private Sub Cargar_Proveedores(Optional idPais As Integer = 0)

        listProveedores = proveedorRepositorio.ObtenerProveedores(idPais)
        CargarGrid(listProveedores)
    End Sub

    Private Sub CargarGrid(lista As List(Of Proveedor))

        grid.RowCount = 0
        filaSeleccionada = 0
        Dim fila As Integer = 0

        For Each p As Proveedor In lista

            fila += 1
            If fila > grid.RowCount Then
                grid.RowCount = fila
            End If

            grid.RowHeights(fila) = 25

            grid(fila, 1).Text = p.Id.ToString()

            grid(fila, 2).Text = p.Nombre
            grid(fila, 2).VerticalAlignment = GridVerticalAlignment.Middle

            grid(fila, 3).Text = p.Direccion
            grid(fila, 3).VerticalAlignment = GridVerticalAlignment.Middle

            grid(fila, 4).Text = p.Localidad
            grid(fila, 4).VerticalAlignment = GridVerticalAlignment.Middle

            grid(fila, 5).Text = p.Provincia
            grid(fila, 5).VerticalAlignment = GridVerticalAlignment.Middle

            grid(fila, 6).Text = p.telefono
            grid(fila, 6).HorizontalAlignment = GridHorizontalAlignment.Center
            grid(fila, 6).VerticalAlignment = GridVerticalAlignment.Middle

            grid(fila, 7).Text = p.Email
            grid(fila, 7).VerticalAlignment = GridVerticalAlignment.Middle

            grid(fila, 8).Text = If(p.Activo, "Sí", "No")
            grid(fila, 8).HorizontalAlignment = GridHorizontalAlignment.Center
            grid(fila, 8).VerticalAlignment = GridVerticalAlignment.Middle

            PintarFila(fila)

        Next

    End Sub

    Private Sub PintarFila(row As Integer)

        For col As Integer = 1 To grid.ColCount

            If row Mod 2 = 0 Then
                grid(row, col).BackColor = Color.White
            Else
                grid(row, col).BackColor = Color.FromArgb(240, 245, 255)
            End If

        Next

    End Sub

    Private Sub btnColumnas_Click(sender As Object, e As EventArgs) Handles btnColumnas.Click
        Dim fixedColumns As New List(Of String) From {"Nombre", "Dirección"}
        Dim f As New frmColumnas(Me.grid, fixedColumns)
        Dim loc As Point = btnColumnas.PointToScreen(New Point(0, btnColumnas.Height))
        f.Location = loc
        f.Show(Me)

    End Sub
End Class