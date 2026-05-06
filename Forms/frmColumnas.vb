Imports Syncfusion.Windows.Forms.Grid

Public Class frmColumnas

    Private ReadOnly grid As GridControl


    Public Sub New(dataGrid As GridControl)
        InitializeComponent()
        Me.grid = dataGrid
        Me.BackColor = Color.White
        Me.checkBoxMostrarTodo.Text = "Mostrar/Esconder todas"
        Me.checkBoxColumnas.Top = checkBoxColumnas.Top + 10
        Me.checkBoxColumnas.Left = checkBoxColumnas.Left + 10
        Me.checkBoxMostrarTodo.Left = checkBoxColumnas.Left

    End Sub

    Private Sub frmColumnas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To grid.Model.ColCount
            Dim header As String = grid.Model(0, i).Text
            If header <> "" Then
                checkBoxColumnas.Items.Add(header, True)
            End If
        Next
        Dim itemHeight As Integer = checkBoxColumnas.ItemHeight
        checkBoxColumnas.Height = itemHeight * checkBoxColumnas.Items.Count

        labelSeparador.Top = checkBoxColumnas.Bottom + 5
        checkBoxMostrarTodo.Top = labelSeparador.Bottom + 5

        Me.Height = checkBoxMostrarTodo.Bottom + 15
    End Sub
    Private Sub frmColumnas_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.Close()
    End Sub

End Class