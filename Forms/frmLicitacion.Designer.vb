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
        GroupBox3 = New GroupBox()
        ListBoxOferentes = New ListBox()
        GroupBox4 = New GroupBox()
        Label7 = New Label()
        timeApertura = New DateTimePicker()
        Label8 = New Label()
        dateApertura = New DateTimePicker()
        txtApertura = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' ComboTipoProyecto
        ' 
        ComboTipoProyecto.BackColor = SystemColors.HotTrack
        ComboTipoProyecto.DropDownStyle = ComboBoxStyle.DropDownList
        ComboTipoProyecto.Font = New Font("Book Antiqua", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboTipoProyecto.ForeColor = SystemColors.Window
        ComboTipoProyecto.FormattingEnabled = True
        ComboTipoProyecto.Location = New Point(229, 152)
        ComboTipoProyecto.Name = "ComboTipoProyecto"
        ComboTipoProyecto.Size = New Size(268, 30)
        ComboTipoProyecto.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(73, 152)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(151, 25)
        Label3.TabIndex = 15
        Label3.Text = "Tipo de Proyecto:"
        ' 
        ' ComboBoxComitente
        ' 
        ComboBoxComitente.BackColor = SystemColors.HotTrack
        ComboBoxComitente.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxComitente.Font = New Font("Book Antiqua", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBoxComitente.ForeColor = SystemColors.Window
        ComboBoxComitente.FormattingEnabled = True
        ComboBoxComitente.Location = New Point(229, 38)
        ComboBoxComitente.Name = "ComboBoxComitente"
        ComboBoxComitente.Size = New Size(533, 30)
        ComboBoxComitente.TabIndex = 14
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(73, 210)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 25)
        Label2.TabIndex = 13
        Label2.Text = "Pais:"
        ' 
        ' ComboBoxPais
        ' 
        ComboBoxPais.BackColor = SystemColors.HotTrack
        ComboBoxPais.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxPais.Font = New Font("Book Antiqua", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBoxPais.ForeColor = SystemColors.Window
        ComboBoxPais.FormattingEnabled = True
        ComboBoxPais.Location = New Point(229, 205)
        ComboBoxPais.Name = "ComboBoxPais"
        ComboBoxPais.Size = New Size(180, 30)
        ComboBoxPais.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(73, 38)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 25)
        Label1.TabIndex = 11
        Label1.Text = "Comitente:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(73, 97)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 25)
        Label4.TabIndex = 17
        Label4.Text = "Numero:"
        ' 
        ' txtBoxNumero
        ' 
        txtBoxNumero.Location = New Point(229, 97)
        txtBoxNumero.Margin = New Padding(4, 5, 4, 5)
        txtBoxNumero.Name = "txtBoxNumero"
        txtBoxNumero.Size = New Size(164, 31)
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
        GroupBox1.Location = New Point(791, 38)
        GroupBox1.Margin = New Padding(4, 5, 4, 5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 5, 4, 5)
        GroupBox1.Size = New Size(220, 308)
        GroupBox1.TabIndex = 23
        GroupBox1.TabStop = False
        GroupBox1.Text = "Estado"
        ' 
        ' radPresentada
        ' 
        radPresentada.AutoSize = True
        radPresentada.Font = New Font("Segoe UI", 9F)
        radPresentada.Location = New Point(33, 245)
        radPresentada.Margin = New Padding(4, 5, 4, 5)
        radPresentada.Name = "radPresentada"
        radPresentada.Size = New Size(124, 29)
        radPresentada.TabIndex = 28
        radPresentada.TabStop = True
        radPresentada.Text = "Presentada"
        radPresentada.UseVisualStyleBackColor = True
        ' 
        ' radDesestimada
        ' 
        radDesestimada.AutoSize = True
        radDesestimada.Font = New Font("Segoe UI", 9F)
        radDesestimada.Location = New Point(31, 203)
        radDesestimada.Margin = New Padding(4, 5, 4, 5)
        radDesestimada.Name = "radDesestimada"
        radDesestimada.Size = New Size(139, 29)
        radDesestimada.TabIndex = 27
        radDesestimada.TabStop = True
        radDesestimada.Text = "Desestimada"
        radDesestimada.UseVisualStyleBackColor = True
        ' 
        ' radSuspendida
        ' 
        radSuspendida.AutoSize = True
        radSuspendida.Font = New Font("Segoe UI", 9F)
        radSuspendida.Location = New Point(33, 162)
        radSuspendida.Margin = New Padding(4, 5, 4, 5)
        radSuspendida.Name = "radSuspendida"
        radSuspendida.Size = New Size(122, 29)
        radSuspendida.TabIndex = 26
        radSuspendida.TabStop = True
        radSuspendida.Text = "Supendida"
        radSuspendida.UseVisualStyleBackColor = True
        ' 
        ' radEnProceso
        ' 
        radEnProceso.AutoSize = True
        radEnProceso.Font = New Font("Segoe UI", 9F)
        radEnProceso.Location = New Point(30, 120)
        radEnProceso.Margin = New Padding(4, 5, 4, 5)
        radEnProceso.Name = "radEnProceso"
        radEnProceso.Size = New Size(124, 29)
        radEnProceso.TabIndex = 25
        radEnProceso.TabStop = True
        radEnProceso.Text = "En Proceso"
        radEnProceso.UseVisualStyleBackColor = True
        ' 
        ' radCalificacion
        ' 
        radCalificacion.AutoSize = True
        radCalificacion.Font = New Font("Segoe UI", 9F)
        radCalificacion.Location = New Point(30, 78)
        radCalificacion.Margin = New Padding(4, 5, 4, 5)
        radCalificacion.Name = "radCalificacion"
        radCalificacion.Size = New Size(149, 29)
        radCalificacion.TabIndex = 24
        radCalificacion.TabStop = True
        radCalificacion.Text = "En Calificacion"
        radCalificacion.UseVisualStyleBackColor = True
        ' 
        ' radEnAgenda
        ' 
        radEnAgenda.AutoSize = True
        radEnAgenda.Font = New Font("Segoe UI", 9F)
        radEnAgenda.Location = New Point(30, 37)
        radEnAgenda.Margin = New Padding(4, 5, 4, 5)
        radEnAgenda.Name = "radEnAgenda"
        radEnAgenda.Size = New Size(123, 29)
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
        GroupBox2.Location = New Point(17, 357)
        GroupBox2.Margin = New Padding(4, 5, 4, 5)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 5, 4, 5)
        GroupBox2.Size = New Size(1346, 102)
        GroupBox2.TabIndex = 24
        GroupBox2.TabStop = False
        GroupBox2.Text = "Presentacion"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(1089, 42)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 25)
        Label6.TabIndex = 23
        Label6.Text = "Hora:"
        ' 
        ' timePresentacion
        ' 
        timePresentacion.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        timePresentacion.Format = DateTimePickerFormat.Time
        timePresentacion.Location = New Point(1157, 42)
        timePresentacion.Margin = New Padding(4, 5, 4, 5)
        timePresentacion.Name = "timePresentacion"
        timePresentacion.Size = New Size(157, 31)
        timePresentacion.TabIndex = 22
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(810, 42)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 25)
        Label5.TabIndex = 21
        Label5.Text = "Fecha:"
        ' 
        ' datePresentacion
        ' 
        datePresentacion.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        datePresentacion.Format = DateTimePickerFormat.Short
        datePresentacion.Location = New Point(891, 42)
        datePresentacion.Margin = New Padding(4, 5, 4, 5)
        datePresentacion.Name = "datePresentacion"
        datePresentacion.Size = New Size(155, 31)
        datePresentacion.TabIndex = 20
        ' 
        ' txtPresentacion
        ' 
        txtPresentacion.Location = New Point(9, 42)
        txtPresentacion.Margin = New Padding(4, 5, 4, 5)
        txtPresentacion.Name = "txtPresentacion"
        txtPresentacion.Size = New Size(773, 31)
        txtPresentacion.TabIndex = 19
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = SystemColors.ActiveCaption
        GroupBox3.Controls.Add(ListBoxOferentes)
        GroupBox3.FlatStyle = FlatStyle.Flat
        GroupBox3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(1041, 38)
        GroupBox3.Margin = New Padding(4, 5, 4, 5)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4, 5, 4, 5)
        GroupBox3.Size = New Size(321, 308)
        GroupBox3.TabIndex = 25
        GroupBox3.TabStop = False
        GroupBox3.Text = "Oferentes"
        ' 
        ' ListBoxOferentes
        ' 
        ListBoxOferentes.BorderStyle = BorderStyle.None
        ListBoxOferentes.FormattingEnabled = True
        ListBoxOferentes.Location = New Point(9, 28)
        ListBoxOferentes.Margin = New Padding(4, 5, 4, 5)
        ListBoxOferentes.Name = "ListBoxOferentes"
        ListBoxOferentes.Size = New Size(304, 250)
        ListBoxOferentes.TabIndex = 0
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
        GroupBox4.Location = New Point(17, 468)
        GroupBox4.Margin = New Padding(4, 5, 4, 5)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(4, 5, 4, 5)
        GroupBox4.Size = New Size(1346, 102)
        GroupBox4.TabIndex = 26
        GroupBox4.TabStop = False
        GroupBox4.Text = "Apertura"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(1089, 42)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(59, 25)
        Label7.TabIndex = 23
        Label7.Text = "Hora:"
        ' 
        ' timeApertura
        ' 
        timeApertura.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        timeApertura.Format = DateTimePickerFormat.Time
        timeApertura.Location = New Point(1157, 42)
        timeApertura.Margin = New Padding(4, 5, 4, 5)
        timeApertura.Name = "timeApertura"
        timeApertura.Size = New Size(157, 31)
        timeApertura.TabIndex = 22
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(810, 42)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 25)
        Label8.TabIndex = 21
        Label8.Text = "Fecha:"
        ' 
        ' dateApertura
        ' 
        dateApertura.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dateApertura.Format = DateTimePickerFormat.Short
        dateApertura.Location = New Point(891, 42)
        dateApertura.Margin = New Padding(4, 5, 4, 5)
        dateApertura.Name = "dateApertura"
        dateApertura.Size = New Size(155, 31)
        dateApertura.TabIndex = 20
        ' 
        ' txtApertura
        ' 
        txtApertura.Location = New Point(9, 42)
        txtApertura.Margin = New Padding(4, 5, 4, 5)
        txtApertura.Name = "txtApertura"
        txtApertura.Size = New Size(773, 31)
        txtApertura.TabIndex = 19
        ' 
        ' frmLicitacion
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1664, 750)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(txtBoxNumero)
        Controls.Add(Label4)
        Controls.Add(ComboTipoProyecto)
        Controls.Add(Label3)
        Controls.Add(ComboBoxComitente)
        Controls.Add(Label2)
        Controls.Add(ComboBoxPais)
        Controls.Add(Label1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "frmLicitacion"
        Text = "Licitacion"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ListBoxOferentes As ListBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents timeApertura As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents dateApertura As DateTimePicker
    Friend WithEvents txtApertura As TextBox
End Class
