Imports System.Data
Imports MySql.Data.MySqlClient
Public Module mComitentes

    Private ReadOnly ComitenteRepositorio As New ComitenteRepositorio
    Public Sub ComitentesLlenarLista(iList As Object, IncluirTodos As Boolean)
        Dim idPais As Integer
        idPais = 0
        Dim dtComitentes As List(Of Comitente) = ComitenteRepositorio.ObtenerComitentes(0)
        If IncluirTodos = True Then
            Dim placeholder As New Comitente
            placeholder.Id = 0
            placeholder.Nombre = "..."
            dtComitentes.Insert(0, placeholder)
        End If
        iList.DisplayMember = "Nombre"
        iList.ValueMember = "Id"
        iList.DataSource = dtComitentes
        iList.SelectedIndex = 0
    End Sub
    Public Sub ComitentesLlenarCombo(iCombo As Object, IncluirTodos As Boolean)
        Dim idPais As Integer
        idPais = 0
        Dim dtComitentes As List(Of Comitente) = ComitenteRepositorio.ObtenerComitentes(0)
        If IncluirTodos = True Then
            Dim placeholder As New Comitente
            placeholder.Id = 0
            placeholder.Nombre = "..."
            dtComitentes.Insert(0, placeholder)
        End If
        iCombo.DisplayMember = "Nombre"
        iCombo.ValueMember = "Id"
        iCombo.DataSource = dtComitentes
        iCombo.SelectedIndex = 0
    End Sub
End Module
