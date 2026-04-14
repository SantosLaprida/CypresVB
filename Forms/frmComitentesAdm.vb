Imports Syncfusion.Windows.Forms.Grid
Imports System.Data
Imports MySql.Data.MySqlClient
Imports TuProyecto
Public Class frmComitentesAdm

    Private listaComitentes As List(Of Comitente)
    Private ReadOnly comitenteRepositorio As New ComitenteRepositorio()
    Private ReadOnly paisRepositorio As New PaisRepositorio()

    Dim cadena As String =
        "Server=35.199.107.210;Port=3306;Database=laprida_cypres;Uid=claprida;Pwd=lapridac;"

    Private grid As New GridControl()
    Private filaSeleccionada As Integer = 0

    Private Sub frmComitentesAdm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler grid.DoubleClick, AddressOf grid_DoubleClick
        InicializarGrid()
        Cargar_Comitentes()
        InicializarComboBoxPaises()

    End Sub
    Private Sub InicializarGrid()
        grid.Dock = DockStyle.None
        Me.Controls.Add(grid)
        grid.ActivateCurrentCellBehavior = GridCellActivateAction.None

        'Tamaño y ubicacion de la grilla
        grid.Top = 83
        grid.Height = 300
        grid.Width = 750
        grid.RowCount = 0
        grid.ColCount = 4

        grid.ColWidths(1) = 0 'ID
        grid.ColWidths(2) = 80 'sigla
        grid.ColWidths(3) = 300 'comitente
        grid.ColWidths(4) = 315 'direccion
        Me.Controls.Add(grid)
        'Encabezado
        grid.RowHeights(0) = 35
        grid(0, 2).Text = "Sigla"
        grid(0, 3).Text = "Comitente"
        grid(0, 4).Text = "Direccion"
    End Sub
    Private Sub Cargar_Comitentes(Optional idPais As Integer = 0)

        listaComitentes = comitenteRepositorio.ObtenerComitentes(idPais)
        CargarGrid(listaComitentes)
    End Sub

    Private Sub InicializarComboBoxPaises()
        Dim dtPaises As DataTable = paisRepositorio.ObtenerPaises()
        Dim drPlaceholder As DataRow = dtPaises.NewRow()
        drPlaceholder("id_pais") = 0
        drPlaceholder("descripcion") = "..."
        dtPaises.Rows.InsertAt(drPlaceholder, 0)

        ComboBoxPais.DisplayMember = "descripcion"
        ComboBoxPais.ValueMember = "id_pais"
        ComboBoxPais.DataSource = dtPaises
        ComboBoxPais.SelectedIndex = 0
        ComboBoxPais.Font = New Font(ComboBoxPais.Font, FontStyle.Bold)
        ComboBoxPais.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub CargarGrid(lista As List(Of Comitente))

        grid.RowCount = 1
        filaSeleccionada = 0
        Dim fila As Integer = 0

        For Each c As Comitente In lista
            fila += 1
            If fila > grid.RowCount Then
                grid.RowCount = fila
            End If

            grid.RowHeights(fila) = 30
            grid(fila, 1).Text = c.Id.ToString()
            grid(fila, 1).VerticalAlignment = GridVerticalAlignment.Middle
            grid(fila, 2).Text = c.Sigla
            grid(fila, 2).VerticalAlignment = GridVerticalAlignment.Middle
            grid(fila, 3).Text = c.Nombre
            grid(fila, 3).VerticalAlignment = GridVerticalAlignment.Middle
            grid(fila, 4).Text = c.Direccion
            grid(fila, 4).VerticalAlignment = GridVerticalAlignment.Middle
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
    Private Sub grid_DoubleClick(sender As Object, e As EventArgs)

        Dim row As Integer = grid.CurrentCell.RowIndex
        If row <= 0 Then Exit Sub

        filaSeleccionada = row

        Dim id As Integer = Val(grid(row, 1).Text)

        Dim f As New frmComitente
        f.IdComitente = id

        If f.ShowDialog() = DialogResult.OK Then

            Dim c As Comitente = f.ComitenteEditado

            ReubicarComitente(row, c)

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim row = grid.CurrentCell.RowIndex
        EliminarFilaGrid(grid, row)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim row As Integer = grid.CurrentCell.RowIndex
        grid.Rows.InsertRange(row, 1)
    End Sub

    Private Function BuscarPosicionComitente(nombre As String, Optional filaExcluir As Integer = 0) As Integer

        For row As Integer = 1 To grid.RowCount

            If row = filaExcluir Then Continue For

            Dim actual As String = grid(row, 3).Text

            If String.Compare(nombre, actual, True) < 0 Then
                Return row
            End If

        Next

        Return grid.RowCount + 1

    End Function
    Private Sub CargarFilaComitente(row As Integer, c As Comitente)

        grid.RowHeights(row) = 30
        grid(row, 1).Text = c.Id.ToString()
        grid(row, 1).VerticalAlignment = GridVerticalAlignment.Middle
        grid(row, 2).Text = c.Sigla
        grid(row, 2).VerticalAlignment = GridVerticalAlignment.Middle
        grid(row, 3).Text = c.Nombre
        grid(row, 3).VerticalAlignment = GridVerticalAlignment.Middle
        grid(row, 4).Text = c.Direccion
        grid(row, 4).VerticalAlignment = GridVerticalAlignment.Middle
        PintarFila(row)

    End Sub
    Private Sub ReubicarComitente(rowActual As Integer, c As Comitente)

        Dim nuevaFila As Integer = BuscarPosicionComitente(c.Nombre, rowActual)

        ' 🔹 Si no cambia de lugar
        If nuevaFila = rowActual OrElse nuevaFila = rowActual + 1 Then
            CargarFilaComitente(rowActual, c)
            Exit Sub
        End If

        ' 🔹 eliminar fila actual
        grid.Rows.RemoveRange(rowActual, rowActual)

        ' 🔹 ajustar índice
        If nuevaFila > rowActual Then
            nuevaFila -= 1
        End If

        ' 🔹 insertar
        grid.Rows.InsertRange(nuevaFila, 1)

        ' 🔹 cargar datos
        CargarFilaComitente(nuevaFila, c)

        ' 🔹 repintar
        Dim desde As Integer = Math.Min(rowActual, nuevaFila)

        For r As Integer = desde To grid.RowCount
            PintarFila(r)
        Next

        filaSeleccionada = nuevaFila

    End Sub

    Private Sub NuevoToolStripButton_Click(sender As Object, e As EventArgs) Handles NuevoToolStripButton.Click
        Dim f As New frmComitente

        If f.ShowDialog() = DialogResult.OK Then

            Dim c As Comitente = f.ComitenteEditado

            InsertarComitenteEnGrid(c)

        End If

    End Sub
    Private Sub InsertarComitenteEnGrid(c As Comitente)

        Dim nuevaFila As Integer = BuscarPosicionComitente(c.Nombre)

        ' 🔹 Si va al final
        If nuevaFila > grid.RowCount Then

            grid.RowCount += 1
            nuevaFila = grid.RowCount

        Else

            ' 🔹 Insertar en el medio
            grid.Rows.InsertRange(nuevaFila, 1)

        End If

        ' 🔹 Cargar datos
        CargarFilaComitente(nuevaFila, c)

        ' 🔹 Repintar desde ahí
        For r As Integer = nuevaFila To grid.RowCount
            PintarFila(r)
        Next

        filaSeleccionada = nuevaFila

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        FiltrarComitentes(txtBuscar.Text)
    End Sub
    Private Sub FiltrarComitentes(texto As String)
        If listaComitentes Is Nothing OrElse listaComitentes.Count = 0 Then Exit Sub

        If texto.Trim = "" Then
            CargarGrid(listaComitentes)
            Exit Sub
        End If

        Dim textoBuscado As String = texto.Trim().ToLower()

        Dim filtrada As List(Of Comitente) = listaComitentes.Where(Function(c)
                                                                       Return c.Sigla.ToLower().Contains(textoBuscado) OrElse
               c.Nombre.ToLower().Contains(textoBuscado)
                                                                   End Function).ToList()

        CargarGrid(filtrada)
    End Sub

    Private Sub ComboBoxPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPais.SelectedIndexChanged

        Cargar_Comitentes(ComboBoxPais.SelectedValue)
    End Sub
End Class