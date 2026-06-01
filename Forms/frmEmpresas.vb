Imports Syncfusion
Imports Syncfusion.Windows.Forms.Grid
Public Class frmEmpresas
    Private listaEmpresas As List(Of Empresas)
    Private ReadOnly EmpresasRepositorio As New EmpresasRepositorio()
    Private ReadOnly paisRepositorio As New PaisRepositorio()

    'Private grid As New GridControl()
    Private filaSeleccionada As Integer = 0

    Private Sub frmEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PaisesLlenarCombo(ComboBoxPais, True)
        InicializarGrid()
        Cargar_Empresas()
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
        Grid.ColCount = 7
        'Grid.ColWidths(0) = 80
        Grid.ColWidths(1) = 0 'Id
        Grid.ColWidths(2) = 250 'Empresa
        Grid.ColWidths(3) = 250 'Direccion
        Grid.ColWidths(4) = 200 'Localidad
        Grid.ColWidths(5) = 90 'cpostal
        Grid.ColWidths(6) = 200 'telefono
        Grid.ColWidths(7) = 90 'logo
        'Grid.ColWidths(7) = 80 'Pliego
        'Grid.ColWidths(8) = 200 'estado
        Me.Controls.Add(Grid)

        Dim totalWidth As Integer = 0
        For col As Integer = 1 To Grid.ColCount
            totalWidth += Grid.ColWidths(col)

        Next
        Grid.Width = totalWidth

        Grid.RowHeights(0) = 35
        Grid(0, 1).Text = "Id"
        Grid(0, 2).Text = "Empresa"
        Grid(0, 3).Text = "Direccion"
        Grid(0, 4).Text = "Localidad"
        Grid(0, 5).Text = "C. Postal"
        Grid(0, 6).Text = "Telefono"
        Grid(0, 7).Text = ""
        Me.ClientSize = New Size(Grid.Width + 100, Me.ClientSize.Height)
    End Sub
    Private Sub CargarGrid(lista As List(Of Empresas))

        Grid.RowCount = 0
        filaSeleccionada = 0
        Dim fila As Integer = 0

        For Each c As Empresas In lista
            fila += 1
            If fila > Grid.RowCount Then
                Grid.RowCount = fila
            End If

            Grid.RowHeights(fila) = 35

            For i As Integer = 1 To Grid.ColCount
                Grid(fila, i).VerticalAlignment = GridVerticalAlignment.Middle
                Grid(fila, i).HorizontalAlignment = GridHorizontalAlignment.Center
            Next
            Grid(fila, 1).Text = c.Id.ToString()
            Grid(fila, 2).Font.Bold = True
            Grid(fila, 2).Text = c.Nombre
            Grid(fila, 3).Text = c.Direccion
            Grid(fila, 4).Text = c.Localidad
            Grid(fila, 5).Text = c.CPostal
            Grid(fila, 6).Text = c.telefono
            EmpresaCargarLogoEnCelda(fila, 7, c.Id)
            PintarFila(fila)
        Next

    End Sub
    Private Sub Cargar_Empresas(Optional idPais As Integer = 0)

        listaEmpresas = EmpresasRepositorio.ObtenerEmpresas(idPais)
        CargarGrid(listaEmpresas)
    End Sub

    Private Sub NuevoToolStripButton_Click(sender As Object, e As EventArgs) Handles NuevoToolStripButton.Click
        Dim f As New frmEmpresa

        If f.ShowDialog() = DialogResult.OK Then

            Dim c As Empresas = f.EmpresaEditada
            InsertarEmpresaEnGrid(c)

        End If

    End Sub

    Private Sub grid_DoubleClick(sender As Object, e As EventArgs) Handles Grid.CellDoubleClick

        Dim row As Integer = Grid.CurrentCell.RowIndex
        If row <= 0 Then Exit Sub

        filaSeleccionada = row

        Dim id As Integer = Val(Grid(row, 1).Text)

        Dim f As New frmEmpresa
        f.Id = id

        If f.ShowDialog() = DialogResult.OK Then

            Dim c As Empresas = f.EmpresaEditada

            ReubicarEmpresa(row, c)

        End If

    End Sub



    Private Sub InsertarEmpresaEnGrid(c As Empresas)

        Dim nuevaFila As Integer = EmpresaBuscarPosicion(c.Nombre)

        ' 🔹 Si va al final
        If nuevaFila > Grid.RowCount Then

            Grid.RowCount += 1
            nuevaFila = Grid.RowCount

        Else

            ' 🔹 Insertar en el medio
            Grid.Rows.InsertRange(nuevaFila, 1)

        End If

        ' 🔹 Cargar datos
        EmpresaCargarFila(nuevaFila, c)

        ' 🔹 Repintar desde ahí
        For r As Integer = nuevaFila To Grid.RowCount
            PintarFila(r)
        Next

        filaSeleccionada = nuevaFila

    End Sub

    Private Sub ReubicarEmpresa(rowActual As Integer, c As Empresas)

        Dim nuevaFila As Integer = EmpresaBuscarPosicion(c.Nombre, rowActual)

        ' 🔹 Si no cambia de lugar
        If nuevaFila = rowActual OrElse nuevaFila = rowActual + 1 Then
            EmpresaCargarFila(rowActual, c)
            Exit Sub
        End If

        ' 🔹 eliminar fila actual
        Grid.Rows.RemoveRange(rowActual, rowActual)

        ' 🔹 ajustar índice
        If nuevaFila > rowActual Then
            nuevaFila -= 1
        End If

        ' 🔹 insertar
        Grid.Rows.InsertRange(nuevaFila, 2)

        ' 🔹 cargar datos
        EmpresaCargarFila(nuevaFila, c)

        ' 🔹 repintar
        Dim desde As Integer = Math.Min(rowActual, nuevaFila)

        For r As Integer = desde To Grid.RowCount
            PintarFila(r)
        Next

        filaSeleccionada = nuevaFila

    End Sub
    Private Function EmpresaBuscarPosicion(nombre As String, Optional filaExcluir As Integer = 0) As Integer

        For row As Integer = 1 To Grid.RowCount

            If row = filaExcluir Then Continue For

            Dim actual As String = Grid(row, 2).Text

            If String.Compare(nombre, actual, True) < 0 Then
                Return row
            End If

        Next

        Return Grid.RowCount + 1

    End Function
    Private Sub EmpresaCargarFila(row As Integer, c As Empresas)

        Grid.RowHeights(row) = 30
        Grid(row, 1).Text = c.Id.ToString()
        Grid(row, 2).VerticalAlignment = GridVerticalAlignment.Middle
        Grid(row, 2).HorizontalAlignment = GridHorizontalAlignment.Center
        Grid(row, 2).Text = c.Nombre.ToString()
        Grid(row, 2).Font.Bold = True
        Grid(row, 3).HorizontalAlignment = GridHorizontalAlignment.Center
        Grid(row, 3).VerticalAlignment = GridVerticalAlignment.Middle
        Grid(row, 3).Text = c.Direccion
        Grid(row, 4).HorizontalAlignment = GridHorizontalAlignment.Center
        Grid(row, 4).VerticalAlignment = GridVerticalAlignment.Middle
        Grid(row, 4).Text = c.Localidad
        Grid(row, 5).HorizontalAlignment = GridHorizontalAlignment.Center
        Grid(row, 5).VerticalAlignment = GridVerticalAlignment.Middle
        Grid(row, 5).Text = c.CPostal
        Grid(row, 6).HorizontalAlignment = GridHorizontalAlignment.Center
        Grid(row, 6).VerticalAlignment = GridVerticalAlignment.Middle
        Grid(row, 6).Text = c.telefono
        EmpresaCargarLogoEnCelda(row, 7, c.Id)
        PintarFila(row)
    End Sub
    Private Sub PintarFila(row As Integer)

        For col As Integer = 1 To Grid.ColCount

            If row Mod 2 = 0 Then
                Grid(row, col).BackColor = Color.White
            Else
                Grid(row, col).BackColor = Color.FromArgb(240, 245, 255)
            End If

        Next

    End Sub

    Private Sub ComboBoxPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPais.SelectedIndexChanged
        Cargar_Empresas(ComboBoxPais.SelectedValue)
    End Sub

    Private Sub FiltrarEmpresas(texto As String)
        If listaEmpresas Is Nothing OrElse listaEmpresas.Count = 0 Then Exit Sub

        If texto.Trim = "" Then
            CargarGrid(listaEmpresas)
            Exit Sub
        End If

        Dim textoBuscado As String = texto.Trim().ToLower()

        Dim filtrada As List(Of Empresas) = listaEmpresas.Where(Function(c)
                                                                    Return c.Nombre.ToLower().Contains(textoBuscado) OrElse
                    c.Nombre.ToLower().Contains(textoBuscado)
                                                                End Function).ToList()

        CargarGrid(filtrada)
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        FiltrarEmpresas(txtBuscar.Text)
    End Sub

    Private Sub EmpresaCargarLogoEnCelda(row As Integer, col As Integer, idEmpresa As Integer)

        Dim repo As New EmpresasRepositorio
        Dim bytes() As Byte = repo.EmpresaObtenerLogo(idEmpresa)

        If bytes Is Nothing Then Exit Sub

        Using ms As New IO.MemoryStream(bytes)

            Dim img As Image = Image.FromStream(ms)

            Dim imgReducida As Image =
            RedimensionarImagen(img, 40, 40)

            Grid(row, col).CellType = "Image"
            Grid(row, col).ImageList = Nothing
            Grid(row, col).CellValue = imgReducida

        End Using

    End Sub
    Private Function RedimensionarImagen(imgOriginal As Image,
                                     ancho As Integer,
                                     alto As Integer) As Image

        Dim bmp As New Bitmap(ancho, alto)

        Using g As Graphics = Graphics.FromImage(bmp)

            g.InterpolationMode =
                Drawing2D.InterpolationMode.HighQualityBicubic

            g.Clear(Color.White)
            g.DrawImage(imgOriginal, 0, 0, ancho, alto)

        End Using

        Return bmp

    End Function


End Class