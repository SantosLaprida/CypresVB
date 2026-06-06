Public Module mEmpresas

    Private ReadOnly empresasRepositorio As New EmpresasRepositorio()
    Private ReadOnly licitacionesRepositorio As New LicitacionesRepositorio()

    Public Sub EmpresasLlenarLista(iList As Object, IncluirTodos As Boolean)
        Dim listaEmpresas As List(Of Empresas) = empresasRepositorio.ObtenerEmpresas(0)
        'If IncluirTodos Then
        '    Dim placeHolder As New Empresas
        '    placeHolder.Id = 0
        '    placeHolder.Nombre = "..."
        '    listaEmpresas.Insert(0, placeHolder)
        'End If

        iList.DisplayMember = "Nombre"
        iList.ValueMember = "Id"
        iList.Items.Clear()
        For Each empresa As Empresas In listaEmpresas
            iList.Items.Add(empresa)
        Next

    End Sub

    Public Sub EmpresasLlenarListaLicitacion(iList As Object, IdLicitacion As Integer)

        Dim listaEmpresas As List(Of Empresas) = empresasRepositorio.EmpresaObtenerPorLicitacion(IdLicitacion)
        iList.DisplayMember = "Nombre"
        iList.ValueMember = "Id"
        iList.Items.Clear()

        For Each empresa As Empresas In listaEmpresas
            iList.Items.Add(empresa)
        Next

    End Sub

End Module
