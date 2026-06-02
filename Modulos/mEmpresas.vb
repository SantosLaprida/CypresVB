Public Module mEmpresas

    Private ReadOnly empresasRepositorio As New EmpresasRepositorio()

    Public Sub EmpresasLlenarLista(iList As Object, IncluirTodos As Boolean)
        Dim listaEmpresas As List(Of Empresas) = empresasRepositorio.ObtenerEmpresas(0)
        If IncluirTodos Then
            Dim placeHolder As New Empresas
            placeHolder.Id = 0
            placeHolder.Nombre = "..."
            listaEmpresas.Insert(0, placeHolder)
        End If

        iList.DisplayMember = "Nombre"
        iList.ValueMember = "Id"
        iList.DataSource = listaEmpresas
        iList.SelectedIndex = 0

    End Sub

End Module
