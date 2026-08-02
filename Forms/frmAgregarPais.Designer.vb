<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarPais
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        labelDescripcion = New Label()
        txtDescripcion = New TextBox()
        btnGuardar = New Button()
        btnCancelar = New Button()
        lblDescripcion = New Label()
        SuspendLayout()
        ' 
        ' labelDescripcion
        ' 
        labelDescripcion.AutoSize = True
        labelDescripcion.Location = New Point(44, 66)
        labelDescripcion.Name = "labelDescripcion"
        labelDescripcion.Size = New Size(0, 25)
        labelDescripcion.TabIndex = 0
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(174, 63)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(272, 31)
        txtDescripcion.TabIndex = 1
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
        btnGuardar.Location = New Point(127, 130)
        btnGuardar.Margin = New Padding(5)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(92, 35)
        btnGuardar.TabIndex = 13
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
        btnCancelar.Location = New Point(300, 130)
        btnCancelar.Margin = New Padding(5)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(92, 35)
        btnCancelar.TabIndex = 14
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.AutoSize = True
        lblDescripcion.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        lblDescripcion.Location = New Point(52, 63)
        lblDescripcion.Margin = New Padding(5, 0, 5, 0)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(103, 23)
        lblDescripcion.TabIndex = 15
        lblDescripcion.Text = "Descripcion"
        lblDescripcion.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' frmAgregarPais
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(596, 191)
        Controls.Add(lblDescripcion)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(txtDescripcion)
        Controls.Add(labelDescripcion)
        Name = "frmAgregarPais"
        Text = "frmAgregarPais"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents labelDescripcion As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblDescripcion As Label
End Class
