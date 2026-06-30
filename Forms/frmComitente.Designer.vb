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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComitente))
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
        TableLayoutPanel1 = New TableLayoutPanel()
        btnLogo = New Button()
        PictureBox1 = New PictureBox()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        Label2.Location = New Point(5, 0)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 23)
        Label2.TabIndex = 2
        Label2.Text = "Sigla:"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtSigla
        ' 
        txtSigla.Font = New Font("Microsoft Sans Serif", 8.25F)
        txtSigla.Location = New Point(114, 5)
        txtSigla.Margin = New Padding(5)
        txtSigla.MaxLength = 10
        txtSigla.Name = "txtSigla"
        txtSigla.Size = New Size(197, 26)
        txtSigla.TabIndex = 3
        ' 
        ' txtComitente
        ' 
        txtComitente.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtComitente.Location = New Point(114, 50)
        txtComitente.Margin = New Padding(5)
        txtComitente.MaxLength = 50
        txtComitente.Name = "txtComitente"
        txtComitente.Size = New Size(394, 26)
        txtComitente.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        Label3.Location = New Point(5, 45)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 23)
        Label3.TabIndex = 4
        Label3.Text = "Comitente:"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Font = New Font("Microsoft Sans Serif", 8.25F)
        txtDireccion.Location = New Point(114, 95)
        txtDireccion.Margin = New Padding(5)
        txtDireccion.MaxLength = 50
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(394, 26)
        txtDireccion.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        Label4.Location = New Point(5, 90)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 23)
        Label4.TabIndex = 6
        Label4.Text = "Direccion:"
        Label4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtLocalidad
        ' 
        txtLocalidad.Font = New Font("Microsoft Sans Serif", 8.25F)
        txtLocalidad.Location = New Point(114, 140)
        txtLocalidad.Margin = New Padding(5)
        txtLocalidad.MaxLength = 50
        txtLocalidad.Name = "txtLocalidad"
        txtLocalidad.Size = New Size(394, 26)
        txtLocalidad.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        Label5.Location = New Point(5, 135)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 23)
        Label5.TabIndex = 8
        Label5.Text = "Localidad:"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtCPostal
        ' 
        txtCPostal.Font = New Font("Microsoft Sans Serif", 8.25F)
        txtCPostal.Location = New Point(114, 185)
        txtCPostal.Margin = New Padding(5)
        txtCPostal.MaxLength = 15
        txtCPostal.Name = "txtCPostal"
        txtCPostal.Size = New Size(197, 26)
        txtCPostal.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        Label6.Location = New Point(5, 180)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 23)
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
        btnGuardar.Location = New Point(122, 546)
        btnGuardar.Margin = New Padding(5)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(92, 35)
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
        btnCancelar.Location = New Point(253, 546)
        btnCancelar.Margin = New Padding(5)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(96, 35)
        btnCancelar.TabIndex = 13
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        Label8.Location = New Point(5, 315)
        Label8.Margin = New Padding(5, 0, 5, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(46, 23)
        Label8.TabIndex = 17
        Label8.Text = "Pais:"
        Label8.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ComboBoxPais
        ' 
        ComboBoxPais.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBoxPais.FormattingEnabled = True
        ComboBoxPais.Location = New Point(114, 320)
        ComboBoxPais.Margin = New Padding(5)
        ComboBoxPais.Name = "ComboBoxPais"
        ComboBoxPais.Size = New Size(197, 31)
        ComboBoxPais.TabIndex = 18
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Font = New Font("Microsoft Sans Serif", 8.25F)
        txtTelefono.Location = New Point(114, 230)
        txtTelefono.Margin = New Padding(5)
        txtTelefono.MaxLength = 50
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(197, 26)
        txtTelefono.TabIndex = 20
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        Label9.ImageAlign = ContentAlignment.MiddleRight
        Label9.Location = New Point(5, 225)
        Label9.Margin = New Padding(5, 0, 5, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(83, 23)
        Label9.TabIndex = 19
        Label9.Text = "Telefono:"
        Label9.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtMail
        ' 
        txtMail.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtMail.Location = New Point(114, 275)
        txtMail.Margin = New Padding(5)
        txtMail.MaxLength = 50
        txtMail.Name = "txtMail"
        txtMail.Size = New Size(197, 29)
        txtMail.TabIndex = 22
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        Label10.ImageAlign = ContentAlignment.MiddleRight
        Label10.Location = New Point(5, 270)
        Label10.Margin = New Padding(5, 0, 5, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(59, 23)
        Label10.TabIndex = 21
        Label10.Text = "Email:"
        Label10.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' rad_publico
        ' 
        rad_publico.AutoSize = True
        rad_publico.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rad_publico.Location = New Point(122, 493)
        rad_publico.Name = "rad_publico"
        rad_publico.Size = New Size(91, 27)
        rad_publico.TabIndex = 23
        rad_publico.TabStop = True
        rad_publico.Text = "Publico"
        rad_publico.UseVisualStyleBackColor = True
        ' 
        ' rad_privado
        ' 
        rad_privado.AutoSize = True
        rad_privado.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rad_privado.Location = New Point(225, 493)
        rad_privado.Name = "rad_privado"
        rad_privado.Size = New Size(92, 27)
        rad_privado.TabIndex = 24
        rad_privado.TabStop = True
        rad_privado.Text = "Privado"
        rad_privado.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Controls.Add(Label3, 0, 1)
        TableLayoutPanel1.Controls.Add(Label4, 0, 2)
        TableLayoutPanel1.Controls.Add(ComboBoxPais, 1, 7)
        TableLayoutPanel1.Controls.Add(txtMail, 1, 6)
        TableLayoutPanel1.Controls.Add(Label5, 0, 3)
        TableLayoutPanel1.Controls.Add(txtTelefono, 1, 5)
        TableLayoutPanel1.Controls.Add(Label10, 0, 6)
        TableLayoutPanel1.Controls.Add(Label6, 0, 4)
        TableLayoutPanel1.Controls.Add(Label8, 0, 7)
        TableLayoutPanel1.Controls.Add(Label9, 0, 5)
        TableLayoutPanel1.Controls.Add(txtCPostal, 1, 4)
        TableLayoutPanel1.Controls.Add(txtSigla, 1, 0)
        TableLayoutPanel1.Controls.Add(txtLocalidad, 1, 3)
        TableLayoutPanel1.Controls.Add(txtComitente, 1, 1)
        TableLayoutPanel1.Controls.Add(txtDireccion, 1, 2)
        TableLayoutPanel1.Location = New Point(93, 100)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 8
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 45F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 45F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 45F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 45F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 45F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 45F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 45F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 45F))
        TableLayoutPanel1.Size = New Size(676, 360)
        TableLayoutPanel1.TabIndex = 25
        ' 
        ' btnLogo
        ' 
        btnLogo.BackColor = SystemColors.HotTrack
        btnLogo.FlatAppearance.BorderSize = 0
        btnLogo.FlatStyle = FlatStyle.Flat
        btnLogo.Font = New Font("Segoe UI", 8.25F)
        btnLogo.ForeColor = Color.White
        btnLogo.Location = New Point(600, 30)
        btnLogo.Margin = New Padding(5)
        btnLogo.Name = "btnLogo"
        btnLogo.Size = New Size(96, 35)
        btnLogo.TabIndex = 31
        btnLogo.Text = "Guardar Logo"
        btnLogo.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(172, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(101, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 32
        PictureBox1.TabStop = False
        ' 
        ' frmComitente
        ' 
        AutoScaleDimensions = New SizeF(12F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(777, 661)
        Controls.Add(PictureBox1)
        Controls.Add(btnLogo)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(rad_privado)
        Controls.Add(rad_publico)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmComitente"
        Text = "Comitente - Editar"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnLogo As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
