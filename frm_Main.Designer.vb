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
        SuspendLayout()
        ' 
        ' btnCcomitentes
        ' 
        btnCcomitentes.BackColor = SystemColors.HotTrack
        btnCcomitentes.FlatAppearance.BorderSize = 0
        btnCcomitentes.FlatStyle = FlatStyle.Flat
        btnCcomitentes.Location = New Point(444, 281)
        btnCcomitentes.Margin = New Padding(6, 8, 6, 8)
        btnCcomitentes.Name = "btnCcomitentes"
        btnCcomitentes.Size = New Size(223, 53)
        btnCcomitentes.TabIndex = 0
        btnCcomitentes.Text = "Comitentes"
        btnCcomitentes.UseVisualStyleBackColor = False
        ' 
        ' btnPaises
        ' 
        btnPaises.BackColor = SystemColors.HotTrack
        btnPaises.FlatAppearance.BorderSize = 0
        btnPaises.FlatStyle = FlatStyle.Flat
        btnPaises.Location = New Point(444, 419)
        btnPaises.Margin = New Padding(6, 8, 6, 8)
        btnPaises.Name = "btnPaises"
        btnPaises.Size = New Size(223, 53)
        btnPaises.TabIndex = 1
        btnPaises.Text = "Paises"
        btnPaises.UseVisualStyleBackColor = False
        ' 
        ' btnProveedores
        ' 
        btnProveedores.BackColor = SystemColors.HotTrack
        btnProveedores.FlatAppearance.BorderSize = 0
        btnProveedores.FlatStyle = FlatStyle.Flat
        btnProveedores.Location = New Point(444, 350)
        btnProveedores.Margin = New Padding(6, 8, 6, 8)
        btnProveedores.Name = "btnProveedores"
        btnProveedores.Size = New Size(223, 53)
        btnProveedores.TabIndex = 2
        btnProveedores.Text = "Proveedores"
        btnProveedores.UseVisualStyleBackColor = False
        ' 
        ' btnRubros
        ' 
        btnRubros.BackColor = SystemColors.HotTrack
        btnRubros.FlatAppearance.BorderSize = 0
        btnRubros.FlatStyle = FlatStyle.Flat
        btnRubros.Location = New Point(444, 215)
        btnRubros.Margin = New Padding(4, 5, 4, 5)
        btnRubros.Name = "btnRubros"
        btnRubros.Size = New Size(223, 53)
        btnRubros.TabIndex = 2
        btnRubros.Text = "Rubros"
        btnRubros.UseVisualStyleBackColor = False
        ' 
        ' frm_Main
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 750)
        Controls.Add(btnProveedores)
        Controls.Add(btnRubros)
        Controls.Add(btnPaises)
        Controls.Add(btnCcomitentes)
        ForeColor = SystemColors.ButtonHighlight
        Margin = New Padding(6, 8, 6, 8)
        Name = "frm_Main"
        Text = "Main"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnCcomitentes As Button
    Friend WithEvents btnPaises As Button
    Friend WithEvents btnProveedores As Button
    Friend WithEvents btnRubros As Button
End Class
