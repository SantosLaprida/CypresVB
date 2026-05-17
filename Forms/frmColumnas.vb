Imports Syncfusion.Windows.Forms.Grid

Public Class frmColumnas

    Private ReadOnly grid As GridControl
    Private ReadOnly fixedColumnas As List(Of String)

    Public Sub New(dataGrid As GridControl, Optional fixedColumnas As List(Of String) = Nothing)
        InitializeComponent()
        Me.grid = dataGrid
        Me.fixedColumnas = If(fixedColumnas, New List(Of String)())
        Me.BackColor = Color.White
        Me.checkBoxMostrarTodo.Text = "Mostrar/Esconder todas"
        Me.checkBoxColumnas.Top = checkBoxColumnas.Top + 10
        Me.checkBoxColumnas.Left = checkBoxColumnas.Left + 10
        Me.checkBoxMostrarTodo.Left = checkBoxColumnas.Left
        Me.checkBoxMostrarTodo.Checked = True

    End Sub

    Private Sub frmColumnas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To grid.Model.ColCount
            Dim header As String = grid.Model(0, i).Text
            If header <> "" And Not fixedColumnas.Contains(header) Then
                checkBoxColumnas.Items.Add(header, True)
            End If
        Next
        Dim itemHeight As Integer = checkBoxColumnas.ItemHeight
        checkBoxColumnas.Height = itemHeight * checkBoxColumnas.Items.Count
        labelSeparador.Top = checkBoxColumnas.Bottom + 5
        checkBoxMostrarTodo.Top = labelSeparador.Bottom + 5

        Me.Height = checkBoxMostrarTodo.Bottom + 15
    End Sub

    Private Sub checkBoxColumnas_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles checkBoxColumnas.ItemCheck
        Dim header As String = checkBoxColumnas.Items(e.Index).ToString()
        Dim mostrar As Boolean = (e.NewValue = CheckState.Checked)

        If fixedColumnas.Contains(header) AndAlso Not mostrar Then
            e.NewValue = CheckState.Checked
            Exit Sub
        End If

        For i As Integer = 1 To grid.ColCount
            If grid.Model(0, i).Text = header Then
                grid.Cols.Hidden(i) = Not mostrar
                grid.Refresh()
                Exit For
            End If
        Next

        Dim allChecked As Boolean = True
        For i As Integer = 0 To checkBoxColumnas.Items.Count - 1
            Dim isChecked As Boolean = If(i = e.Index, mostrar, checkBoxColumnas.GetItemChecked(i))
            If Not isChecked Then
                allChecked = False
                Exit For
            End If
        Next

        RemoveHandler checkBoxMostrarTodo.CheckedChanged, AddressOf checkBoxMostrarTodo_CheckedChanged
        checkBoxMostrarTodo.Checked = allChecked
        AddHandler checkBoxMostrarTodo.CheckedChanged, AddressOf checkBoxMostrarTodo_CheckedChanged
    End Sub

    Private Sub checkBoxMostrarTodo_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxMostrarTodo.CheckedChanged
        Dim mostrar As Boolean = checkBoxMostrarTodo.Checked
        For i As Integer = 0 To checkBoxColumnas.Items.Count - 1
            checkBoxColumnas.SetItemChecked(i, mostrar)
        Next
    End Sub

    Private Sub checkBoxColumnas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles checkBoxColumnas.SelectedIndexChanged
        checkBoxColumnas.ClearSelected()
    End Sub

End Class