Public Module m_Grillas

    Public Sub CargarCelda(dgv As DataGridView, fila As Integer, columna As String, valor As Object)

        If dgv.Columns.Contains(columna) Then
            dgv.Rows(fila).Cells(columna).Value = valor
        End If

    End Sub
    Public Sub CargarCeldaIdx(
    dgv As DataGridView,
    fila As Integer,
    columna As Integer,
    valor As Object,
    Optional alineacion As DataGridViewContentAlignment = DataGridViewContentAlignment.MiddleLeft,
    Optional negrita As Boolean = False,
    Optional altoFila As Integer = 0
)

        If columna >= 0 AndAlso columna < dgv.Columns.Count Then

            Dim celda = dgv.Rows(fila).Cells(columna)

            celda.Value = valor

            ' Alineación
            celda.Style.Alignment = alineacion

            ' Fuente
            If negrita Then
                celda.Style.Font = New Font(dgv.Font, FontStyle.Bold)
            End If

            ' Altura de fila
            If altoFila > 0 Then
                dgv.Rows(fila).Height = altoFila
            End If

        End If

    End Sub
    Sub EliminarFilaGrid(grid As Syncfusion.Windows.Forms.Grid.GridControl, row As Integer)

        If row <= 0 Then Exit Sub
        If row > grid.RowCount Then Exit Sub

        grid.Rows.RemoveRange(row, row)

    End Sub
    Sub InsertarFilaGrid(grid As Syncfusion.Windows.Forms.Grid.GridControl, row As Integer)

        If row <= 0 Then Exit Sub
        If row > grid.RowCount Then Exit Sub

        grid.Rows.InsertRange(row, 1)

    End Sub
End Module
