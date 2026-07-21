Imports Syncfusion.Windows.Forms.Grid
Imports System.Data
Imports MySql.Data.MySqlClient
Public Class frmProyectos
    Private Sub frmProyectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler grid.DoubleClick, AddressOf grid_DoubleClick
        InicializarGrid()
        ComitentesLlenarCombo(ComboComitente, True)

    End Sub
    Private Sub InicializarGrid()
        grid.Font = New Font("Segoe UI Semibold", 9)
        If Not Me.Controls.Contains(grid) Then
            Me.Controls.Add(grid)
        End If
        grid.ActivateCurrentCellBehavior = GridCellActivateAction.None

        ' === Column Setup ===
        grid.ColCount = 2
        grid.ColWidths(1) = 0          ' ID (hidden)
        grid.ColWidths(2) = 400         ' descripcion

        ' === Calculate Total Width ===
        'Dim totalWidth As Integer = 0
        'For col As Integer = 1 To grid.ColCount
        '    totalWidth += grid.ColWidths(col)
        'Next

        ' === Size and Position ===
        grid.Width = 1000  'totalWidth
        grid.Height = 400
        grid.Top = Panel1.Bottom
        grid.Left = 0

        ' === Header ===
        grid.RowHeights(0) = 35
        grid(0, 2).Text = "Proyecto"
        'grid(0, 3).Text = "Comitente"
        'grid(0, 4).Text = "Direccion"
        'grid(0, 5).Text = "Localidad"
        'grid(0, 6).Text = "C. Postal"
        'grid(0, 7).Text = "Telefono"

        ' === Resize form to match grid ===
        Me.ClientSize = New Size(grid.Width, Me.ClientSize.Height)
    End Sub

    Private Sub grid_CellClick(sender As Object, e As GridCellClickEventArgs) Handles grid.CellClick

    End Sub
    Private Sub grid_DoubleClick(sender As Object, e As EventArgs)


    End Sub
End Class