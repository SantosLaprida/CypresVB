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
        lstPaises = New ListBox()
        txt_pais = New TextBox()
        btnAgregar = New Button()
        btnModificar = New Button()
        Label5 = New Label()
        btnEliminar = New Button()
        SuspendLayout()
        ' 
        ' lstPaises
        ' 
        lstPaises.BorderStyle = BorderStyle.FixedSingle
        lstPaises.FormattingEnabled = True
        lstPaises.Location = New Point(70, 52)
        lstPaises.Margin = New Padding(4, 5, 4, 5)
        lstPaises.Name = "lstPaises"
        lstPaises.Size = New Size(322, 377)
        lstPaises.TabIndex = 0
        ' 
        ' txt_pais
        ' 
        txt_pais.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_pais.Location = New Point(70, 458)
        txt_pais.Margin = New Padding(4, 5, 4, 5)
        txt_pais.MaxLength = 50
        txt_pais.Name = "txt_pais"
        txt_pais.Size = New Size(321, 31)
        txt_pais.TabIndex = 1
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = SystemColors.HotTrack
        btnAgregar.FlatAppearance.BorderSize = 0
        btnAgregar.FlatStyle = FlatStyle.Flat
        btnAgregar.ForeColor = Color.White
        btnAgregar.Location = New Point(70, 528)
        btnAgregar.Margin = New Padding(4, 5, 4, 5)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(99, 48)
        btnAgregar.TabIndex = 2
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' btnModificar
        ' 
        btnModificar.BackColor = SystemColors.HotTrack
        btnModificar.FlatAppearance.BorderSize = 0
        btnModificar.FlatStyle = FlatStyle.Flat
        btnModificar.ForeColor = Color.White
        btnModificar.Location = New Point(177, 528)
        btnModificar.Margin = New Padding(4, 5, 4, 5)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(99, 48)
        btnModificar.TabIndex = 3
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.BackColor = SystemColors.ActiveCaption
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(70, 15)
        Label5.Margin = New Padding(7, 0, 7, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(323, 32)
        Label5.TabIndex = 9
        Label5.Text = "Paises"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = SystemColors.HotTrack
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.ForeColor = Color.White
        btnEliminar.Location = New Point(284, 528)
        btnEliminar.Margin = New Padding(4, 5, 4, 5)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(99, 48)
        btnEliminar.TabIndex = 10
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' frmPaises
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(493, 658)
        Controls.Add(btnEliminar)
        Controls.Add(Label5)
        Controls.Add(btnModificar)
        Controls.Add(btnAgregar)
        Controls.Add(txt_pais)
        Controls.Add(lstPaises)
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmPaises"
        Text = "Paises"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstPaises As ListBox
    Friend WithEvents txt_pais As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEliminar As Button
End Class
