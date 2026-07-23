<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLicitacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        ComboTipoProyecto = New ComboBox()
        Label3 = New Label()
        ComboBoxComitente = New ComboBox()
        Label2 = New Label()
        ComboBoxPais = New ComboBox()
        Label1 = New Label()
        Label4 = New Label()
        txtBoxNumero = New TextBox()
        GroupBox1 = New GroupBox()
        radPresentada = New RadioButton()
        radDesestimada = New RadioButton()
        radSuspendida = New RadioButton()
        radEnProceso = New RadioButton()
        radCalificacion = New RadioButton()
        radEnAgenda = New RadioButton()
        GroupBox2 = New GroupBox()
        Label6 = New Label()
        timePresentacion = New DateTimePicker()
        Label5 = New Label()
        datePresentacion = New DateTimePicker()
        txtPresentacion = New TextBox()
        GroupBox4 = New GroupBox()
        Label7 = New Label()
        timeApertura = New DateTimePicker()
        Label8 = New Label()
        dateApertura = New DateTimePicker()
        txtApertura = New TextBox()
        ListBoxOferentes = New ListBox()
        GroupBox3 = New GroupBox()
        btnAgregarOferentes = New Button()
        btnGuardar = New Button()
        btnCancelar = New Button()
        txtBoxDenominacion = New TextBox()
        lblDenominacion = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        txtBoxPlazo = New TextBox()
        lblPresupuesto = New Label()
        TxtBoxPliego = New TextBox()
        txtBoxPresupuesto = New TextBox()
        Label9 = New Label()
        lblPliego = New Label()
        Panel1 = New Panel()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox3.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ComboTipoProyecto
        ' 
        ComboTipoProyecto.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        ComboTipoProyecto.BackColor = SystemColors.HotTrack
        ComboTipoProyecto.DropDownStyle = ComboBoxStyle.DropDownList
        ComboTipoProyecto.Font = New Font("Book Antiqua", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboTipoProyecto.ForeColor = SystemColors.Window
        ComboTipoProyecto.FormattingEnabled = True
        ComboTipoProyecto.Location = New Point(133, 222)
        ComboTipoProyecto.Margin = New Padding(2)
        ComboTipoProyecto.Name = "ComboTipoProyecto"
        ComboTipoProyecto.Size = New Size(390, 23)
        ComboTipoProyecto.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(3, 226)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 15)
        Label3.TabIndex = 15
        Label3.Text = "Tipo de Proyecto:"
        ' 
        ' ComboBoxComitente
        ' 
        ComboBoxComitente.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        ComboBoxComitente.BackColor = SystemColors.HotTrack
        ComboBoxComitente.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxComitente.Font = New Font("Book Antiqua", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBoxComitente.ForeColor = SystemColors.Window
        ComboBoxComitente.FormattingEnabled = True
        ComboBoxComitente.Location = New Point(133, 42)
        ComboBoxComitente.Margin = New Padding(2)
        ComboBoxComitente.Name = "ComboBoxComitente"
        ComboBoxComitente.Size = New Size(390, 24)
        ComboBoxComitente.TabIndex = 14
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(2, 266)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 15)
        Label2.TabIndex = 13
        Label2.Text = "Pais:"
        ' 
        ' ComboBoxPais
        ' 
        ComboBoxPais.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        ComboBoxPais.BackColor = SystemColors.HotTrack
        ComboBoxPais.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxPais.Font = New Font("Book Antiqua", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBoxPais.ForeColor = SystemColors.Window
        ComboBoxPais.FormattingEnabled = True
        ComboBoxPais.Location = New Point(133, 262)
        ComboBoxPais.Margin = New Padding(2)
        ComboBoxPais.Name = "ComboBoxPais"
        ComboBoxPais.Size = New Size(390, 23)
        ComboBoxPais.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 15)
        Label1.TabIndex = 11
        Label1.Text = "Comitente:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(3, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(125, 15)
        Label4.TabIndex = 17
        Label4.Text = "Numero:"
        ' 
        ' txtBoxNumero
        ' 
        txtBoxNumero.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtBoxNumero.Location = New Point(134, 6)
        txtBoxNumero.Name = "txtBoxNumero"
        txtBoxNumero.Size = New Size(388, 23)
        txtBoxNumero.TabIndex = 18
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ActiveCaption
        GroupBox1.Controls.Add(radPresentada)
        GroupBox1.Controls.Add(radDesestimada)
        GroupBox1.Controls.Add(radSuspendida)
        GroupBox1.Controls.Add(radEnProceso)
        GroupBox1.Controls.Add(radCalificacion)
        GroupBox1.Controls.Add(radEnAgenda)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(580, 25)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(156, 203)
        GroupBox1.TabIndex = 23
        GroupBox1.TabStop = False
        GroupBox1.Text = "Estado"
        ' 
        ' radPresentada
        ' 
        radPresentada.AutoSize = True
        radPresentada.Font = New Font("Segoe UI", 9F)
        radPresentada.Location = New Point(23, 147)
        radPresentada.Name = "radPresentada"
        radPresentada.Size = New Size(83, 19)
        radPresentada.TabIndex = 28
        radPresentada.TabStop = True
        radPresentada.Text = "Presentada"
        radPresentada.UseVisualStyleBackColor = True
        ' 
        ' radDesestimada
        ' 
        radDesestimada.AutoSize = True
        radDesestimada.Font = New Font("Segoe UI", 9F)
        radDesestimada.Location = New Point(22, 122)
        radDesestimada.Name = "radDesestimada"
        radDesestimada.Size = New Size(92, 19)
        radDesestimada.TabIndex = 27
        radDesestimada.TabStop = True
        radDesestimada.Text = "Desestimada"
        radDesestimada.UseVisualStyleBackColor = True
        ' 
        ' radSuspendida
        ' 
        radSuspendida.AutoSize = True
        radSuspendida.Font = New Font("Segoe UI", 9F)
        radSuspendida.Location = New Point(23, 97)
        radSuspendida.Name = "radSuspendida"
        radSuspendida.Size = New Size(81, 19)
        radSuspendida.TabIndex = 26
        radSuspendida.TabStop = True
        radSuspendida.Text = "Supendida"
        radSuspendida.UseVisualStyleBackColor = True
        ' 
        ' radEnProceso
        ' 
        radEnProceso.AutoSize = True
        radEnProceso.Font = New Font("Segoe UI", 9F)
        radEnProceso.Location = New Point(21, 72)
        radEnProceso.Name = "radEnProceso"
        radEnProceso.Size = New Size(83, 19)
        radEnProceso.TabIndex = 25
        radEnProceso.TabStop = True
        radEnProceso.Text = "En Proceso"
        radEnProceso.UseVisualStyleBackColor = True
        ' 
        ' radCalificacion
        ' 
        radCalificacion.AutoSize = True
        radCalificacion.Font = New Font("Segoe UI", 9F)
        radCalificacion.Location = New Point(21, 47)
        radCalificacion.Name = "radCalificacion"
        radCalificacion.Size = New Size(103, 19)
        radCalificacion.TabIndex = 24
        radCalificacion.TabStop = True
        radCalificacion.Text = "En Calificacion"
        radCalificacion.UseVisualStyleBackColor = True
        ' 
        ' radEnAgenda
        ' 
        radEnAgenda.AutoSize = True
        radEnAgenda.Font = New Font("Segoe UI", 9F)
        radEnAgenda.Location = New Point(21, 22)
        radEnAgenda.Name = "radEnAgenda"
        radEnAgenda.Size = New Size(82, 19)
        radEnAgenda.TabIndex = 23
        radEnAgenda.TabStop = True
        radEnAgenda.Text = "En Agenda"
        radEnAgenda.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ActiveCaption
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(timePresentacion)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(datePresentacion)
        GroupBox2.Controls.Add(txtPresentacion)
        GroupBox2.FlatStyle = FlatStyle.Flat
        GroupBox2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(38, 369)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(942, 61)
        GroupBox2.TabIndex = 24
        GroupBox2.TabStop = False
        GroupBox2.Text = "Presentacion"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(762, 25)
        Label6.Name = "Label6"
        Label6.Size = New Size(37, 15)
        Label6.TabIndex = 23
        Label6.Text = "Hora:"
        ' 
        ' timePresentacion
        ' 
        timePresentacion.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        timePresentacion.Format = DateTimePickerFormat.Time
        timePresentacion.Location = New Point(810, 25)
        timePresentacion.Name = "timePresentacion"
        timePresentacion.Size = New Size(111, 23)
        timePresentacion.TabIndex = 22
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(567, 25)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 15)
        Label5.TabIndex = 21
        Label5.Text = "Fecha:"
        ' 
        ' datePresentacion
        ' 
        datePresentacion.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        datePresentacion.Format = DateTimePickerFormat.Short
        datePresentacion.Location = New Point(624, 25)
        datePresentacion.Name = "datePresentacion"
        datePresentacion.Size = New Size(110, 23)
        datePresentacion.TabIndex = 20
        ' 
        ' txtPresentacion
        ' 
        txtPresentacion.Location = New Point(6, 25)
        txtPresentacion.Name = "txtPresentacion"
        txtPresentacion.Size = New Size(542, 23)
        txtPresentacion.TabIndex = 19
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = SystemColors.ActiveCaption
        GroupBox4.Controls.Add(Label7)
        GroupBox4.Controls.Add(timeApertura)
        GroupBox4.Controls.Add(Label8)
        GroupBox4.Controls.Add(dateApertura)
        GroupBox4.Controls.Add(txtApertura)
        GroupBox4.FlatStyle = FlatStyle.Flat
        GroupBox4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.Location = New Point(38, 436)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(942, 61)
        GroupBox4.TabIndex = 26
        GroupBox4.TabStop = False
        GroupBox4.Text = "Apertura"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(762, 25)
        Label7.Name = "Label7"
        Label7.Size = New Size(37, 15)
        Label7.TabIndex = 23
        Label7.Text = "Hora:"
        ' 
        ' timeApertura
        ' 
        timeApertura.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        timeApertura.Format = DateTimePickerFormat.Time
        timeApertura.Location = New Point(810, 25)
        timeApertura.Name = "timeApertura"
        timeApertura.Size = New Size(111, 23)
        timeApertura.TabIndex = 22
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(567, 25)
        Label8.Name = "Label8"
        Label8.Size = New Size(42, 15)
        Label8.TabIndex = 21
        Label8.Text = "Fecha:"
        ' 
        ' dateApertura
        ' 
        dateApertura.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dateApertura.Format = DateTimePickerFormat.Short
        dateApertura.Location = New Point(624, 25)
        dateApertura.Name = "dateApertura"
        dateApertura.Size = New Size(110, 23)
        dateApertura.TabIndex = 20
        ' 
        ' txtApertura
        ' 
        txtApertura.Location = New Point(6, 25)
        txtApertura.Name = "txtApertura"
        txtApertura.Size = New Size(542, 23)
        txtApertura.TabIndex = 19
        ' 
        ' ListBoxOferentes
        ' 
        ListBoxOferentes.BorderStyle = BorderStyle.None
        ListBoxOferentes.FormattingEnabled = True
        ListBoxOferentes.Location = New Point(6, 17)
        ListBoxOferentes.Name = "ListBoxOferentes"
        ListBoxOferentes.Size = New Size(213, 150)
        ListBoxOferentes.TabIndex = 0
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = SystemColors.ActiveCaption
        GroupBox3.Controls.Add(btnAgregarOferentes)
        GroupBox3.Controls.Add(ListBoxOferentes)
        GroupBox3.FlatStyle = FlatStyle.Flat
        GroupBox3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(785, 25)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(236, 203)
        GroupBox3.TabIndex = 25
        GroupBox3.TabStop = False
        GroupBox3.Text = "Oferentes"
        ' 
        ' btnAgregarOferentes
        ' 
        btnAgregarOferentes.BackColor = SystemColors.Info
        btnAgregarOferentes.Location = New Point(6, 172)
        btnAgregarOferentes.Margin = New Padding(2)
        btnAgregarOferentes.Name = "btnAgregarOferentes"
        btnAgregarOferentes.Size = New Size(213, 26)
        btnAgregarOferentes.TabIndex = 1
        btnAgregarOferentes.Text = "Agregar Oferentes"
        btnAgregarOferentes.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = SystemColors.HotTrack
        btnGuardar.Cursor = Cursors.Hand
        btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        btnGuardar.FlatAppearance.BorderSize = 0
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.Font = New Font("Segoe UI", 8.25F)
        btnGuardar.ForeColor = Color.White
        btnGuardar.Location = New Point(785, 295)
        btnGuardar.Margin = New Padding(4, 3, 4, 3)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 27
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = SystemColors.HotTrack
        btnCancelar.Cursor = Cursors.Hand
        btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        btnCancelar.FlatAppearance.BorderSize = 0
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.Font = New Font("Segoe UI", 8.25F)
        btnCancelar.ForeColor = Color.White
        btnCancelar.Location = New Point(905, 295)
        btnCancelar.Margin = New Padding(4, 3, 4, 3)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 28
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' txtBoxDenominacion
        ' 
        txtBoxDenominacion.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtBoxDenominacion.Location = New Point(134, 78)
        txtBoxDenominacion.Name = "txtBoxDenominacion"
        txtBoxDenominacion.Size = New Size(388, 23)
        txtBoxDenominacion.TabIndex = 30
        ' 
        ' lblDenominacion
        ' 
        lblDenominacion.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblDenominacion.AutoSize = True
        lblDenominacion.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDenominacion.Location = New Point(3, 82)
        lblDenominacion.Name = "lblDenominacion"
        lblDenominacion.Size = New Size(125, 15)
        lblDenominacion.TabIndex = 29
        lblDenominacion.Text = "Denominacion:"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 75F))
        TableLayoutPanel1.Controls.Add(txtBoxPlazo, 1, 5)
        TableLayoutPanel1.Controls.Add(Label1, 0, 1)
        TableLayoutPanel1.Controls.Add(ComboBoxComitente, 1, 1)
        TableLayoutPanel1.Controls.Add(Label4, 0, 0)
        TableLayoutPanel1.Controls.Add(txtBoxNumero, 1, 0)
        TableLayoutPanel1.Controls.Add(lblDenominacion, 0, 2)
        TableLayoutPanel1.Controls.Add(txtBoxDenominacion, 1, 2)
        TableLayoutPanel1.Controls.Add(lblPresupuesto, 0, 3)
        TableLayoutPanel1.Controls.Add(TxtBoxPliego, 1, 4)
        TableLayoutPanel1.Controls.Add(txtBoxPresupuesto, 1, 3)
        TableLayoutPanel1.Controls.Add(Label9, 0, 5)
        TableLayoutPanel1.Controls.Add(lblPliego, 0, 4)
        TableLayoutPanel1.Controls.Add(Label2, 0, 7)
        TableLayoutPanel1.Controls.Add(ComboBoxPais, 1, 7)
        TableLayoutPanel1.Controls.Add(Label3, 0, 6)
        TableLayoutPanel1.Controls.Add(ComboTipoProyecto, 1, 6)
        TableLayoutPanel1.Location = New Point(38, 23)
        TableLayoutPanel1.Margin = New Padding(2)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 8
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.Size = New Size(525, 295)
        TableLayoutPanel1.TabIndex = 31
        ' 
        ' txtBoxPlazo
        ' 
        txtBoxPlazo.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtBoxPlazo.Location = New Point(134, 186)
        txtBoxPlazo.Name = "txtBoxPlazo"
        txtBoxPlazo.Size = New Size(388, 23)
        txtBoxPlazo.TabIndex = 36
        ' 
        ' lblPresupuesto
        ' 
        lblPresupuesto.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblPresupuesto.AutoSize = True
        lblPresupuesto.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPresupuesto.Location = New Point(2, 118)
        lblPresupuesto.Margin = New Padding(2, 0, 2, 0)
        lblPresupuesto.Name = "lblPresupuesto"
        lblPresupuesto.Size = New Size(127, 15)
        lblPresupuesto.TabIndex = 32
        lblPresupuesto.Text = "Presupuesto Oficial"
        ' 
        ' TxtBoxPliego
        ' 
        TxtBoxPliego.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TxtBoxPliego.Location = New Point(134, 150)
        TxtBoxPliego.Name = "TxtBoxPliego"
        TxtBoxPliego.Size = New Size(388, 23)
        TxtBoxPliego.TabIndex = 33
        ' 
        ' txtBoxPresupuesto
        ' 
        txtBoxPresupuesto.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtBoxPresupuesto.Location = New Point(134, 114)
        txtBoxPresupuesto.Name = "txtBoxPresupuesto"
        txtBoxPresupuesto.Size = New Size(388, 23)
        txtBoxPresupuesto.TabIndex = 34
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(2, 190)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(127, 15)
        Label9.TabIndex = 35
        Label9.Text = "Plazo (Meses)"
        ' 
        ' lblPliego
        ' 
        lblPliego.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblPliego.AutoSize = True
        lblPliego.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPliego.Location = New Point(2, 154)
        lblPliego.Margin = New Padding(2, 0, 2, 0)
        lblPliego.Name = "lblPliego"
        lblPliego.Size = New Size(127, 15)
        lblPliego.TabIndex = 31
        lblPliego.Text = "Pliego"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Info
        Panel1.Location = New Point(40, 344)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(988, 6)
        Panel1.TabIndex = 32
        ' 
        ' frmLicitacion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1046, 532)
        Controls.Add(Panel1)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "frmLicitacion"
        Text = "Licitacion"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox3.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ComboTipoProyecto As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxComitente As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxPais As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBoxNumero As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radEnProceso As RadioButton
    Friend WithEvents radCalificacion As RadioButton
    Friend WithEvents radEnAgenda As RadioButton
    Friend WithEvents radSuspendida As RadioButton
    Friend WithEvents radPresentada As RadioButton
    Friend WithEvents radDesestimada As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPresentacion As TextBox
    Friend WithEvents datePresentacion As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents timePresentacion As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents timeApertura As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents dateApertura As DateTimePicker
    Friend WithEvents txtApertura As TextBox
    Friend WithEvents ListBoxOferentes As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnAgregarOferentes As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtBoxDenominacion As TextBox
    Friend WithEvents lblDenominacion As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblPliego As Label
    Friend WithEvents lblPresupuesto As Label
    Friend WithEvents TxtBoxPliego As TextBox
    Friend WithEvents txtBoxPresupuesto As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtBoxPlazo As TextBox
    Friend WithEvents Label9 As Label
End Class
