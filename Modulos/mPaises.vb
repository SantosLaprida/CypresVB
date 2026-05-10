Imports System.Data
Imports MySql.Data.MySqlClient
Public Module mPaises
    Private ReadOnly paisRepositorio As New PaisRepositorio
    Public Sub PaisesLlenarLista(iList As Object, IncluirTodos As Boolean)
        Dim dtPaises As DataTable = paisRepositorio.ObtenerPaises()
        Dim drPlaceholder As DataRow = dtPaises.NewRow()
        If IncluirTodos = True Then
            drPlaceholder("id_pais") = 0
            drPlaceholder("descripcion") = "..."
            dtPaises.Rows.InsertAt(drPlaceholder, 0)
        End If
        iList.DisplayMember = "descripcion"
        iList.ValueMember = "id_pais"
        iList.DataSource = dtPaises
        iList.SelectedIndex = 0
    End Sub
    Public Sub PaisesLlenarCombo(iCombo As Object, IncluirTodos As Boolean)
        Dim dtPaises As DataTable = paisRepositorio.ObtenerPaises()
        Dim drPlaceholder As DataRow = dtPaises.NewRow()
        If IncluirTodos = True Then
            drPlaceholder("id_pais") = 0
            drPlaceholder("descripcion") = "..."
            dtPaises.Rows.InsertAt(drPlaceholder, 0)
        End If
        iCombo.DisplayMember = "descripcion"
        iCombo.ValueMember = "id_pais"
        iCombo.DataSource = dtPaises
        iCombo.SelectedIndex = 0
    End Sub
End Module
