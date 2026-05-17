<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProyectoTipo
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
        lblProyectotipo = New Label()
        btnModificar = New Button()
        btnAgregar = New Button()
        txtProyectoTipo = New TextBox()
        lstProyectoTipo = New ListBox()
        SuspendLayout()
        ' 
        ' lblProyectotipo
        ' 
        lblProyectotipo.BackColor = SystemColors.ActiveCaption
        lblProyectotipo.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        lblProyectotipo.Location = New Point(23, 24)
        lblProyectotipo.Margin = New Padding(5, 0, 5, 0)
        lblProyectotipo.Name = "lblProyectotipo"
        lblProyectotipo.Size = New Size(226, 19)
        lblProyectotipo.TabIndex = 14
        lblProyectotipo.Text = "Tipos de Proyectos"
        lblProyectotipo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnModificar
        ' 
        btnModificar.BackColor = SystemColors.HotTrack
        btnModificar.FlatAppearance.BorderSize = 0
        btnModificar.FlatStyle = FlatStyle.Flat
        btnModificar.ForeColor = Color.White
        btnModificar.Location = New Point(98, 332)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(69, 29)
        btnModificar.TabIndex = 13
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = False
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = SystemColors.HotTrack
        btnAgregar.FlatAppearance.BorderSize = 0
        btnAgregar.FlatStyle = FlatStyle.Flat
        btnAgregar.ForeColor = Color.White
        btnAgregar.Location = New Point(23, 332)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(69, 29)
        btnAgregar.TabIndex = 12
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' txtProyectoTipo
        ' 
        txtProyectoTipo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtProyectoTipo.Location = New Point(23, 290)
        txtProyectoTipo.MaxLength = 50
        txtProyectoTipo.Name = "txtProyectoTipo"
        txtProyectoTipo.Size = New Size(226, 23)
        txtProyectoTipo.TabIndex = 11
        ' 
        ' lstProyectoTipo
        ' 
        lstProyectoTipo.BorderStyle = BorderStyle.FixedSingle
        lstProyectoTipo.FormattingEnabled = True
        lstProyectoTipo.Location = New Point(23, 46)
        lstProyectoTipo.Name = "lstProyectoTipo"
        lstProyectoTipo.Size = New Size(226, 227)
        lstProyectoTipo.TabIndex = 10
        ' 
        ' frmProyectoTipo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(301, 398)
        Controls.Add(lblProyectotipo)
        Controls.Add(btnModificar)
        Controls.Add(btnAgregar)
        Controls.Add(txtProyectoTipo)
        Controls.Add(lstProyectoTipo)
        Name = "frmProyectoTipo"
        Text = "Tipos de Proyectos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblProyectotipo As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtProyectoTipo As TextBox
    Friend WithEvents lstProyectoTipo As ListBox
End Class
