Public Class frmOferentes
    Public idLicitacion As Integer = 0
    Private listaOriginalEmpresas As New List(Of Empresas)
    Public ReadOnly Property EmpresasSeleccionadas As List(Of Empresas)
        Get
            Dim lista As New List(Of Empresas)
            For Each item As Empresas In listBoxOferentes.Items
                lista.Add(item)
            Next
            Return lista
        End Get
    End Property
    Private Sub frmOferentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmpresasLlenarLista(listBoxEmpresas, True)
        For Each item As Empresas In listBoxEmpresas.Items
            listaOriginalEmpresas.Add(item)
        Next

        If idLicitacion > 0 Then
            EmpresasLlenarListaLicitacion(listBoxOferentes, idLicitacion)
        End If

    End Sub

    Private Sub listBoxEmpresas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxEmpresas.SelectedIndexChanged
        If listBoxEmpresas.SelectedItem Is Nothing Then Exit Sub
        Dim empresa As Object = listBoxEmpresas.SelectedItem
        listBoxOferentes.Items.Add(empresa)
        listBoxEmpresas.Items.Remove(empresa)
    End Sub

    Private Sub listBoxOferentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxOferentes.SelectedIndexChanged
        If listBoxOferentes.SelectedItem Is Nothing Then Exit Sub
        Dim empresa As Object = listBoxOferentes.SelectedItem
        listBoxEmpresas.Items.Add(empresa)
        listBoxOferentes.Items.Remove(empresa)
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        listBoxOferentes.Items.Clear()
        listBoxEmpresas.Items.Clear()
        For Each empresa As Empresas In listaOriginalEmpresas
            listBoxEmpresas.Items.Add(empresa)
        Next
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class