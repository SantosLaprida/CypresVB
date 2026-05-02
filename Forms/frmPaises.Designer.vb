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
        SuspendLayout()
        ' 
        ' lstPaises
        ' 
        lstPaises.BorderStyle = BorderStyle.FixedSingle
        lstPaises.FormattingEnabled = True
        lstPaises.Location = New Point(49, 31)
        lstPaises.Name = "lstPaises"
        lstPaises.Size = New Size(226, 227)
        lstPaises.TabIndex = 0
        ' 
        ' txt_pais
        ' 
        txt_pais.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_pais.Location = New Point(49, 275)
        txt_pais.MaxLength = 50
        txt_pais.Name = "txt_pais"
        txt_pais.Size = New Size(226, 23)
        txt_pais.TabIndex = 1
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = SystemColors.HotTrack
        btnAgregar.FlatAppearance.BorderSize = 0
        btnAgregar.FlatStyle = FlatStyle.Flat
        btnAgregar.ForeColor = Color.White
        btnAgregar.Location = New Point(49, 317)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(69, 29)
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
        btnModificar.Location = New Point(124, 317)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(69, 29)
        btnModificar.TabIndex = 3
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.BackColor = SystemColors.ActiveCaption
        Label5.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        Label5.Location = New Point(49, 9)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(226, 19)
        Label5.TabIndex = 9
        Label5.Text = "Paises"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmPaises
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(345, 395)
        Controls.Add(Label5)
        Controls.Add(btnModificar)
        Controls.Add(btnAgregar)
        Controls.Add(txt_pais)
        Controls.Add(lstPaises)
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
End Class
