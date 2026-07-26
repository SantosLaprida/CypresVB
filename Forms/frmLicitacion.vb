Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Public Class frmLicitacion

    Public idLicitacion As Integer = 0
    Public licitacionEditada As Licitaciones
    Public licitacionesRepositorio As New LicitacionesRepositorio()
    Public comitenteRepositiorio As New ComitenteRepositorio()
    Public paisRepositorio As New PaisRepositorio()
    Public proyectotiporepositorio As New ProyectoTipoRepositorio
    Private Sub frmLicitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PaisesLlenarCombo(ComboBoxPais, True)
        ComitentesLlenarCombo(ComboBoxComitente, True)
        ProyectoTipoLlenarLlenarCombo(ComboTipoProyecto, True)
        EmpresasLlenarListaLicitacion(ListBoxOferentes, idLicitacion)

        If idLicitacion > 0 Then
            Me.Text = "Editar Licitación"
            Dim l As Licitaciones = licitacionesRepositorio.ObtenerLicitacionPorId(idLicitacion)
            CargarLicitacion(l)
        Else
            Me.Text = "Nueva Licitación"
            radEnAgenda.Checked = True
        End If

    End Sub

    Private Function ObtenerEstadoSeleccionado() As Integer
        If radEnAgenda.Checked Then Return 1
        If radCalificacion.Checked Then Return 2
        If radEnProceso.Checked Then Return 3
        If radSuspendida.Checked Then Return 4
        If radDesestimada.Checked Then Return 5
        If radPresentada.Checked Then Return 6
        Return 0
    End Function

    Private Function LlenarEstado(estado As Integer)
        If estado = 1 Or estado = Nothing Then
            radEnAgenda.Checked = True
        End If
        If estado = 2 Then
            radCalificacion.Checked = True
        End If
        If estado = 3 Then
            radEnProceso.Checked = True
        End If
        If estado = 4 Then
            radSuspendida.Checked = True
        End If
        If estado = 5 Then
            radDesestimada.Checked = True
        End If
        If estado = 6 Then
            radPresentada.Checked = True
        End If
    End Function
    Private Sub CargarLicitacion(l As Licitaciones)
        If l Is Nothing Then Exit Sub
        txtBoxNumero.Text = l.Numero.ToString()
        ComboBoxComitente.SelectedValue = l.Id_Comitente
        txtBoxDenominacion.Text = l.Denominacion
        txtBoxPlazo.Text = l.Plazo.ToString()
        txtBoxPresupuesto.Text = l.Pres_Oficial.ToString()
        TxtBoxPliego.Text = l.Pliego
        ComboTipoProyecto.SelectedValue = l.IdTipoProyecto
        ComboBoxPais.SelectedValue = l.IdPais
        txtPresentacion.Text = l.LugarPresentacion
        txtApertura.Text = l.LugarApertura
        dateApertura.Value = Convert.ToDateTime(l.FechaApertura)
        datePresentacion.Value = Convert.ToDateTime(l.FechaPresentacion)
        timeApertura.Value = Convert.ToDateTime(l.HoraApertura)
        timePresentacion.Value = Convert.ToDateTime(l.HoraPresentacion)
        EmpresasLlenarListaLicitacion(ListBoxOferentes, idLicitacion)
        LlenarEstado(l.Estado)

    End Sub


    Private Sub btnAgregarOferentes_click(sender As Object, e As EventArgs) Handles btnAgregarOferentes.Click
        Dim f As New frmOferentes
        f.idLicitacion = idLicitacion

        If f.ShowDialog() = DialogResult.OK Then
            ListBoxOferentes.Items.Clear()
            For Each empresa As Empresas In f.EmpresasSeleccionadas
                ListBoxOferentes.Items.Add(empresa)
            Next
        End If


    End Sub

    Private Function validarCampos() As Boolean
        Dim errores As New List(Of String)

        If String.IsNullOrEmpty(txtBoxDenominacion.Text.Trim) Then
            errores.Add("- Denominación")
        End If

        If String.IsNullOrEmpty(txtBoxNumero.Text.Trim) Then
            errores.Add("- Número de licitación")
        End If
        If Convert.ToInt32(ComboBoxComitente.SelectedValue) = 0 Then
            errores.Add("- Comitente")
        End If

        If String.IsNullOrEmpty(txtBoxPlazo.Text.Trim) Then
            errores.Add("- Plazo")
        End If

        If String.IsNullOrEmpty(txtBoxPresupuesto.Text.Trim) Then
            errores.Add("- Presupuesto oficial")
        Else
            Dim presupuesto As Decimal
            If Not Decimal.TryParse(txtBoxPresupuesto.Text.Trim(), presupuesto) Then
                errores.Add("- Presupuesto oficial debe ser un número válido")
            End If
        End If

        If String.IsNullOrEmpty(TxtBoxPliego.Text.Trim) Then
            errores.Add("- Pliego")
        End If

        If Convert.ToInt32(ComboBoxPais.SelectedValue) = 0 Then
            errores.Add("- País")
        End If
        If Convert.ToInt32(ComboTipoProyecto.SelectedValue) = 0 Then
            errores.Add("- Tipo de proyecto")
        End If

        If errores.Count > 0 Then
            MessageBox.Show("Faltan los siguientes campos:" & vbNewLine & String.Join(vbNewLine, errores),
                            "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validarCampos() = False Then
            Exit Sub
        End If

        licitacionEditada = New Licitaciones()
        licitacionEditada.Id_lic = idLicitacion
        licitacionEditada.Numero = txtBoxNumero.Text.Trim()
        licitacionEditada.Id_Comitente = Convert.ToInt32(ComboBoxComitente.SelectedValue)
        licitacionEditada.Denominacion = txtBoxDenominacion.Text.Trim()
        licitacionEditada.Plazo = txtBoxPlazo.Text.Trim()
        licitacionEditada.Pres_Oficial = Convert.ToDecimal(txtBoxPresupuesto.Text.Trim())
        licitacionEditada.Pliego = TxtBoxPliego.Text.Trim()
        licitacionEditada.IdPais = Convert.ToInt32(ComboBoxPais.SelectedValue)
        licitacionEditada.IdTipoProyecto = Convert.ToInt32(ComboTipoProyecto.SelectedValue)
        licitacionEditada.LugarPresentacion = txtPresentacion.Text.Trim()
        licitacionEditada.LugarApertura = txtApertura.Text.Trim()
        licitacionEditada.FechaPresentacion = datePresentacion.Value.ToString("yyyy-MM-dd")
        licitacionEditada.FechaApertura = dateApertura.Value.ToString("yyyy-MM-dd")
        licitacionEditada.HoraApertura = timeApertura.Value.ToString("HH:mm:ss")
        licitacionEditada.HoraPresentacion = timePresentacion.Value.ToString("HH:mm:ss")
        licitacionEditada.Estado = ObtenerEstadoSeleccionado()

        Dim oferentes As New List(Of Integer)
        For Each item As Empresas In ListBoxOferentes.Items
            oferentes.Add(item.Id)
        Next

        Dim idGuardado As Integer = licitacionesRepositorio.GuardarLicitacion(licitacionEditada, oferentes)
        idLicitacion = idGuardado
        MessageBox.Show("Licitación guardada correctamente.")
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class