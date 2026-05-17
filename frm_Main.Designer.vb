<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnCcomitentes = New Button()
        btnPaises = New Button()
        btnProveedores = New Button()
        btnRubros = New Button()
        btnProyectoTipo = New Button()
        SuspendLayout()
        ' 
        ' btnCcomitentes
        ' 
        btnCcomitentes.BackColor = SystemColors.HotTrack
        btnCcomitentes.FlatAppearance.BorderSize = 0
        btnCcomitentes.FlatStyle = FlatStyle.Flat
        btnCcomitentes.Location = New Point(311, 169)
        btnCcomitentes.Margin = New Padding(4, 5, 4, 5)
        btnCcomitentes.Name = "btnCcomitentes"
        btnCcomitentes.Size = New Size(156, 32)
        btnCcomitentes.TabIndex = 0
        btnCcomitentes.Text = "Comitentes"
        btnCcomitentes.UseVisualStyleBackColor = False
        ' 
        ' btnPaises
        ' 
        btnPaises.BackColor = SystemColors.HotTrack
        btnPaises.FlatAppearance.BorderSize = 0
        btnPaises.FlatStyle = FlatStyle.Flat
        btnPaises.Location = New Point(311, 251)
        btnPaises.Margin = New Padding(4, 5, 4, 5)
        btnPaises.Name = "btnPaises"
        btnPaises.Size = New Size(156, 32)
        btnPaises.TabIndex = 1
        btnPaises.Text = "Paises"
        btnPaises.UseVisualStyleBackColor = False
        ' 
        ' btnProveedores
        ' 
        btnProveedores.BackColor = SystemColors.HotTrack
        btnProveedores.FlatAppearance.BorderSize = 0
        btnProveedores.FlatStyle = FlatStyle.Flat
        btnProveedores.Location = New Point(311, 210)
        btnProveedores.Margin = New Padding(4, 5, 4, 5)
        btnProveedores.Name = "btnProveedores"
        btnProveedores.Size = New Size(156, 32)
        btnProveedores.TabIndex = 2
        btnProveedores.Text = "Proveedores"
        btnProveedores.UseVisualStyleBackColor = False
        ' 
        ' btnRubros
        ' 
        btnRubros.BackColor = SystemColors.HotTrack
        btnRubros.FlatAppearance.BorderSize = 0
        btnRubros.FlatStyle = FlatStyle.Flat
        btnRubros.Location = New Point(311, 129)
        btnRubros.Name = "btnRubros"
        btnRubros.Size = New Size(156, 32)
        btnRubros.TabIndex = 2
        btnRubros.Text = "Rubros"
        btnRubros.UseVisualStyleBackColor = False
        ' 
        ' btnProyectoTipo
        ' 
        btnProyectoTipo.BackColor = SystemColors.HotTrack
        btnProyectoTipo.FlatAppearance.BorderSize = 0
        btnProyectoTipo.FlatStyle = FlatStyle.Flat
        btnProyectoTipo.Location = New Point(311, 293)
        btnProyectoTipo.Margin = New Padding(4, 5, 4, 5)
        btnProyectoTipo.Name = "btnProyectoTipo"
        btnProyectoTipo.Size = New Size(156, 32)
        btnProyectoTipo.TabIndex = 3
        btnProyectoTipo.Text = "Tipos de Proyectos"
        btnProyectoTipo.UseVisualStyleBackColor = False
        ' 
        ' frm_Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 449)
        Controls.Add(btnProyectoTipo)
        Controls.Add(btnProveedores)
        Controls.Add(btnRubros)
        Controls.Add(btnPaises)
        Controls.Add(btnCcomitentes)
        ForeColor = SystemColors.ButtonHighlight
        Margin = New Padding(4, 5, 4, 5)
        Name = "frm_Main"
        Text = "Main"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnCcomitentes As Button
    Friend WithEvents btnPaises As Button
    Friend WithEvents btnProveedores As Button
    Friend WithEvents btnRubros As Button
    Friend WithEvents btnProyectoTipo As Button
End Class
