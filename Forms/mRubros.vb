Imports System.Data
Imports MySql.Data.MySqlClient


Module mRubros
    Private ReadOnly rubroRepositorio As New RubroRepositorio()
    Private ReadOnly subrubroRepositorio As New SubrubroRepositorio()
    Public Sub RubrosLlenarLista(iList As Object, IncluirTodos As Boolean)
        Dim dtRubros As DataTable = rubroRepositorio.ObtenerRubros()
        Dim drPlaceholder As DataRow = dtRubros.NewRow()
        If IncluirTodos = True Then
            drPlaceholder("id_rubro") = 0
            drPlaceholder("descripcion") = "..."
            dtRubros.Rows.InsertAt(drPlaceholder, 0)
        End If
        iList.DisplayMember = "descripcion"
        iList.ValueMember = "id_rubro"
        iList.DataSource = dtRubros
        iList.SelectedIndex = 0
        'iList.Font = New Font(iList.Font, FontStyle.Bold)
    End Sub
    Public Sub SubrubrosLlenarLista(id As Integer, iList As Object, IncluirTodos As Boolean)
        Dim dtSubrubros As DataTable = subrubroRepositorio.ObtenerSubrubros(id)
        Dim drPlaceholder As DataRow = dtSubrubros.NewRow()
        If IncluirTodos = True Then
            drPlaceholder("id_subrubro") = 0
            drPlaceholder("descripcion") = "..."
            dtSubrubros.Rows.InsertAt(drPlaceholder, 0)
        End If
        iList.DisplayMember = "descripcion"
        iList.ValueMember = "id_subrubro"
        iList.DataSource = dtSubrubros
        'iList.SelectedIndex = 0
        'lstSubrubros.Font = New Font(lstSubrubros.Font, FontStyle.Bold)
    End Sub
End Module
