Imports System.Data
Imports MySql.Data.MySqlClient
Public Module mProyectoTipo
    Private ReadOnly proyectoTipoRepositorio As New ProyectoTipoRepositorio()

    Public Sub ProyectoTipoLlenarLista(iList As Object, IncluirTodos As Boolean)
        Dim dtProyectoTipo As DataTable = proyectoTipoRepositorio.ObtenerProyectoTipo()
        Dim drPlaceholder As DataRow = dtProyectoTipo.NewRow()
        If IncluirTodos = True Then
            drPlaceholder("id_tipo") = 0
            drPlaceholder("descripcion") = "..."
            dtProyectoTipo.Rows.InsertAt(drPlaceholder, 0)
        End If
        iList.DisplayMember = "descripcion"
        iList.ValueMember = "id_tipo"
        iList.DataSource = dtProyectoTipo
        iList.SelectedIndex = 0
    End Sub
    Public Sub ProyectoTipoLlenarLlenarCombo(iCombo As Object, IncluirTodos As Boolean)
        Dim dtProyectoTipo As DataTable = ProyectoTipoRepositorio.ObtenerProyectoTipo()
        Dim drPlaceholder As DataRow = dtProyectoTipo.NewRow()
        If IncluirTodos = True Then
            drPlaceholder("id_tipo") = 0
            drPlaceholder("descripcion") = "..."
            dtProyectoTipo.Rows.InsertAt(drPlaceholder, 0)
        End If
        iCombo.DisplayMember = "descripcion"
        iCombo.ValueMember = "id_tipo"
        iCombo.DataSource = dtProyectoTipo
        iCombo.SelectedIndex = 0
    End Sub
End Module
