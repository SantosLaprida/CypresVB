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
        txt_pais = New TextBox()
        pnlLateral = New Panel()
        btnSalir = New Button()
        btnEliminar = New Button()
        btnModificar = New Button()
        btnAgregar = New Button()
        pnlSuperior = New Panel()
        PictureBox1 = New PictureBox()
        lblDescripcion = New Label()
        lblTitulo = New Label()
        Label1 = New Label()
        pnlLateral.SuspendLayout()
        pnlSuperior.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lstPaises
        ' 
        lstPaises.BorderStyle = BorderStyle.None
        lstPaises.FormattingEnabled = True
        lstPaises.Location = New Point(142, 79)
        lstPaises.Name = "lstPaises"
        lstPaises.Size = New Size(226, 210)
        lstPaises.TabIndex = 0
        ' 
        ' txt_pais
        ' 
        txt_pais.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_pais.Location = New Point(142, 328)
        txt_pais.MaxLength = 50
        txt_pais.Name = "txt_pais"
        txt_pais.Size = New Size(226, 23)
        txt_pais.TabIndex = 1
        ' 
        ' pnlLateral
        ' 
        pnlLateral.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        pnlLateral.Controls.Add(btnSalir)
        pnlLateral.Controls.Add(btnEliminar)
        pnlLateral.Controls.Add(btnModificar)
        pnlLateral.Controls.Add(btnAgregar)
        pnlLateral.Location = New Point(0, 63)
        pnlLateral.Name = "pnlLateral"
        pnlLateral.Size = New Size(139, 226)
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
        btnSalir.Location = New Point(11, 147)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(102, 37)
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
        btnEliminar.Location = New Point(11, 96)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(102, 37)
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
        btnModificar.Location = New Point(11, 58)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(102, 37)
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
        btnAgregar.Location = New Point(11, 20)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(102, 37)
        btnAgregar.TabIndex = 3
        btnAgregar.Text = "  Agregar"
        btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' pnlSuperior
        ' 
        pnlSuperior.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        pnlSuperior.Controls.Add(PictureBox1)
        pnlSuperior.Controls.Add(lblDescripcion)
        pnlSuperior.Controls.Add(lblTitulo)
        pnlSuperior.Location = New Point(-3, 0)
        pnlSuperior.Name = "pnlSuperior"
        pnlSuperior.Size = New Size(533, 77)
        pnlSuperior.TabIndex = 12
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Paises
        PictureBox1.Location = New Point(32, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(60, 35)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDescripcion.ForeColor = Color.White
        lblDescripcion.Location = New Point(154, 49)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(150, 20)
        lblDescripcion.TabIndex = 1
        lblDescripcion.Text = "Administrador de Paises"
        ' 
        ' lblTitulo
        ' 
        lblTitulo.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitulo.ForeColor = Color.White
        lblTitulo.Location = New Point(145, 9)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(150, 30)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Paises"
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(8, 332)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 19)
        Label1.TabIndex = 13
        Label1.Text = "Ingrese Descripcion:"
        ' 
        ' frmPaises
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(523, 397)
        Controls.Add(Label1)
        Controls.Add(pnlSuperior)
        Controls.Add(pnlLateral)
        Controls.Add(txt_pais)
        Controls.Add(lstPaises)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmPaises"
        Text = "Paises"
        pnlLateral.ResumeLayout(False)
        pnlSuperior.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstPaises As ListBox
    Friend WithEvents txt_pais As TextBox
    Friend WithEvents pnlLateral As Panel
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents pnlSuperior As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
