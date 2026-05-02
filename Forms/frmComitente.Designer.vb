<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComitente
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
        Label2 = New Label()
        txtSigla = New TextBox()
        txtComitente = New TextBox()
        Label3 = New Label()
        txtDireccion = New TextBox()
        Label4 = New Label()
        txtLocalidad = New TextBox()
        Label5 = New Label()
        txtCPostal = New TextBox()
        Label6 = New Label()
        btnGuardar = New Button()
        btnCancelar = New Button()
        Label8 = New Label()
        ComboBoxPais = New ComboBox()
        txtTelefono = New TextBox()
        Label9 = New Label()
        txtMail = New TextBox()
        Label10 = New Label()
        rad_publico = New RadioButton()
        rad_privado = New RadioButton()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        Label2.Location = New Point(81, 24)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 13)
        Label2.TabIndex = 2
        Label2.Text = "Sigla:"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtSigla
        ' 
        txtSigla.Font = New Font("Microsoft Sans Serif", 8.25F)
        txtSigla.Location = New Point(146, 23)
        txtSigla.Margin = New Padding(5)
        txtSigla.MaxLength = 10
        txtSigla.Name = "txtSigla"
        txtSigla.Size = New Size(103, 20)
        txtSigla.TabIndex = 3
        ' 
        ' txtComitente
        ' 
        txtComitente.Font = New Font("Microsoft Sans Serif", 8.25F)
        txtComitente.Location = New Point(146, 54)
        txtComitente.Margin = New Padding(5)
        txtComitente.MaxLength = 50
        txtComitente.Name = "txtComitente"
        txtComitente.Size = New Size(394, 20)
        txtComitente.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        Label3.Location = New Point(52, 54)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 13)
        Label3.TabIndex = 4
        Label3.Text = "Comitente:"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Font = New Font("Microsoft Sans Serif", 8.25F)
        txtDireccion.Location = New Point(147, 85)
        txtDireccion.Margin = New Padding(5)
        txtDireccion.MaxLength = 50
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(394, 20)
        txtDireccion.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        Label4.Location = New Point(58, 88)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 13)
        Label4.TabIndex = 6
        Label4.Text = "Direccion:"
        Label4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtLocalidad
        ' 
        txtLocalidad.Font = New Font("Microsoft Sans Serif", 8.25F)
        txtLocalidad.Location = New Point(146, 119)
        txtLocalidad.Margin = New Padding(5)
        txtLocalidad.MaxLength = 50
        txtLocalidad.Name = "txtLocalidad"
        txtLocalidad.Size = New Size(394, 20)
        txtLocalidad.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        Label5.Location = New Point(56, 120)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 13)
        Label5.TabIndex = 8
        Label5.Text = "Localidad:"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtCPostal
        ' 
        txtCPostal.Font = New Font("Microsoft Sans Serif", 8.25F)
        txtCPostal.Location = New Point(146, 151)
        txtCPostal.Margin = New Padding(5)
        txtCPostal.MaxLength = 15
        txtCPostal.Name = "txtCPostal"
        txtCPostal.Size = New Size(110, 20)
        txtCPostal.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        Label6.Location = New Point(61, 152)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 13)
        Label6.TabIndex = 10
        Label6.Text = "C. Postal:"
        Label6.TextAlign = ContentAlignment.MiddleRight
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
        btnGuardar.Location = New Point(146, 321)
        btnGuardar.Margin = New Padding(5)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(90, 27)
        btnGuardar.TabIndex = 12
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = SystemColors.HotTrack
        btnCancelar.FlatAppearance.BorderSize = 0
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.Font = New Font("Segoe UI", 8.25F)
        btnCancelar.ForeColor = Color.White
        btnCancelar.Location = New Point(277, 321)
        btnCancelar.Margin = New Padding(5)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(90, 27)
        btnCancelar.TabIndex = 13
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        Label8.Location = New Point(85, 247)
        Label8.Margin = New Padding(5, 0, 5, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(31, 13)
        Label8.TabIndex = 17
        Label8.Text = "Pais:"
        Label8.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ComboBoxPais
        ' 
        ComboBoxPais.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBoxPais.FormattingEnabled = True
        ComboBoxPais.Location = New Point(147, 245)
        ComboBoxPais.Margin = New Padding(5)
        ComboBoxPais.Name = "ComboBoxPais"
        ComboBoxPais.Size = New Size(166, 21)
        ComboBoxPais.TabIndex = 18
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Font = New Font("Microsoft Sans Serif", 8.25F)
        txtTelefono.Location = New Point(146, 183)
        txtTelefono.Margin = New Padding(5)
        txtTelefono.MaxLength = 50
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(394, 20)
        txtTelefono.TabIndex = 20
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        Label9.ImageAlign = ContentAlignment.MiddleRight
        Label9.Location = New Point(61, 184)
        Label9.Margin = New Padding(5, 0, 5, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(55, 13)
        Label9.TabIndex = 19
        Label9.Text = "Telefono:"
        Label9.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtMail
        ' 
        txtMail.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtMail.Location = New Point(146, 213)
        txtMail.Margin = New Padding(5)
        txtMail.MaxLength = 50
        txtMail.Name = "txtMail"
        txtMail.Size = New Size(394, 22)
        txtMail.TabIndex = 22
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        Label10.ImageAlign = ContentAlignment.MiddleRight
        Label10.Location = New Point(78, 219)
        Label10.Margin = New Padding(5, 0, 5, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(38, 13)
        Label10.TabIndex = 21
        Label10.Text = "Email:"
        Label10.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' rad_publico
        ' 
        rad_publico.AutoSize = True
        rad_publico.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rad_publico.Location = New Point(147, 274)
        rad_publico.Name = "rad_publico"
        rad_publico.Size = New Size(63, 17)
        rad_publico.TabIndex = 23
        rad_publico.TabStop = True
        rad_publico.Text = "Publico"
        rad_publico.UseVisualStyleBackColor = True
        ' 
        ' rad_privado
        ' 
        rad_privado.AutoSize = True
        rad_privado.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rad_privado.Location = New Point(250, 274)
        rad_privado.Name = "rad_privado"
        rad_privado.Size = New Size(63, 17)
        rad_privado.TabIndex = 24
        rad_privado.TabStop = True
        rad_privado.Text = "Privado"
        rad_privado.UseVisualStyleBackColor = True
        ' 
        ' frmComitente
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(1067, 413)
        Controls.Add(rad_privado)
        Controls.Add(rad_publico)
        Controls.Add(txtMail)
        Controls.Add(Label10)
        Controls.Add(txtTelefono)
        Controls.Add(Label9)
        Controls.Add(ComboBoxPais)
        Controls.Add(Label8)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(txtCPostal)
        Controls.Add(Label6)
        Controls.Add(txtLocalidad)
        Controls.Add(Label5)
        Controls.Add(txtDireccion)
        Controls.Add(Label4)
        Controls.Add(txtComitente)
        Controls.Add(Label3)
        Controls.Add(txtSigla)
        Controls.Add(Label2)
        Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmComitente"
        Text = "Comitente - Editar"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSigla As TextBox
    Friend WithEvents txtComitente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCPostal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBoxPais As ComboBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents rad_publico As RadioButton
    Friend WithEvents rad_privado As RadioButton
End Class
