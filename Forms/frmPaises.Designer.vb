<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaises
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaises))
        lstPaises = New ListBox()
        pnlLateral = New Panel()
        btnSalir = New Button()
        btnEliminar = New Button()
        btnModificar = New Button()
        btnAgregar = New Button()
        pnlSuperior = New Panel()
        PictureBox1 = New PictureBox()
        lblDescripcion = New Label()
        lblTitulo = New Label()
        pnlLateral.SuspendLayout()
        pnlSuperior.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lstPaises
        ' 
        lstPaises.BorderStyle = BorderStyle.None
        lstPaises.FormattingEnabled = True
        lstPaises.Location = New Point(193, 132)
        lstPaises.Margin = New Padding(4, 5, 4, 5)
        lstPaises.Name = "lstPaises"
        lstPaises.Size = New Size(387, 550)
        lstPaises.TabIndex = 0
        ' 
        ' pnlLateral
        ' 
        pnlLateral.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        pnlLateral.Controls.Add(btnSalir)
        pnlLateral.Controls.Add(btnEliminar)
        pnlLateral.Controls.Add(btnModificar)
        pnlLateral.Controls.Add(btnAgregar)
        pnlLateral.Location = New Point(0, 105)
        pnlLateral.Margin = New Padding(4, 5, 4, 5)
        pnlLateral.Name = "pnlLateral"
        pnlLateral.Size = New Size(195, 574)
        pnlLateral.TabIndex = 11
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnSalir.Cursor = Cursors.Hand
        btnSalir.FlatAppearance.BorderSize = 0
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.ForeColor = Color.White
        btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), Image)
        btnSalir.ImageAlign = ContentAlignment.MiddleLeft
        btnSalir.Location = New Point(16, 245)
        btnSalir.Margin = New Padding(4, 5, 4, 5)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(146, 62)
        btnSalir.TabIndex = 6
        btnSalir.Text = "   Salir"
        btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnEliminar.Cursor = Cursors.Hand
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.ForeColor = Color.White
        btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), Image)
        btnEliminar.ImageAlign = ContentAlignment.MiddleLeft
        btnEliminar.Location = New Point(16, 160)
        btnEliminar.Margin = New Padding(4, 5, 4, 5)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(146, 62)
        btnEliminar.TabIndex = 5
        btnEliminar.Text = "  Eliminar"
        btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnModificar
        ' 
        btnModificar.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnModificar.Cursor = Cursors.Hand
        btnModificar.FlatAppearance.BorderSize = 0
        btnModificar.FlatStyle = FlatStyle.Flat
        btnModificar.ForeColor = Color.White
        btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), Image)
        btnModificar.ImageAlign = ContentAlignment.MiddleLeft
        btnModificar.Location = New Point(16, 97)
        btnModificar.Margin = New Padding(4, 5, 4, 5)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(146, 62)
        btnModificar.TabIndex = 4
        btnModificar.Text = "  Modificar"
        btnModificar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnModificar.UseVisualStyleBackColor = False
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnAgregar.Cursor = Cursors.Hand
        btnAgregar.FlatAppearance.BorderSize = 0
        btnAgregar.FlatStyle = FlatStyle.Flat
        btnAgregar.ForeColor = Color.White
        btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), Image)
        btnAgregar.ImageAlign = ContentAlignment.MiddleLeft
        btnAgregar.Location = New Point(16, 33)
        btnAgregar.Margin = New Padding(4, 5, 4, 5)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(146, 62)
        btnAgregar.TabIndex = 3
        btnAgregar.Text = "  Agregar"
        btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' pnlSuperior
        ' 
        pnlSuperior.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(62))
        pnlSuperior.Controls.Add(PictureBox1)
        pnlSuperior.Controls.Add(lblDescripcion)
        pnlSuperior.Controls.Add(lblTitulo)
        pnlSuperior.Location = New Point(-4, 0)
        pnlSuperior.Margin = New Padding(4, 5, 4, 5)
        pnlSuperior.Name = "pnlSuperior"
        pnlSuperior.Size = New Size(584, 128)
        pnlSuperior.TabIndex = 12
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Paises
        PictureBox1.Location = New Point(46, 37)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(86, 58)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDescripcion.ForeColor = Color.White
        lblDescripcion.Location = New Point(220, 82)
        lblDescripcion.Margin = New Padding(4, 0, 4, 0)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(214, 33)
        lblDescripcion.TabIndex = 1
        lblDescripcion.Text = "Administrador de Paises"
        ' 
        ' lblTitulo
        ' 
        lblTitulo.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitulo.ForeColor = Color.White
        lblTitulo.Location = New Point(207, 15)
        lblTitulo.Margin = New Padding(4, 0, 4, 0)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(214, 50)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Paises"
        ' 
        ' frmPaises
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(578, 669)
        Controls.Add(pnlSuperior)
        Controls.Add(pnlLateral)
        Controls.Add(lstPaises)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmPaises"
        Text = "Paises"
        pnlLateral.ResumeLayout(False)
        pnlSuperior.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstPaises As ListBox
    Friend WithEvents pnlLateral As Panel
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents pnlSuperior As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
