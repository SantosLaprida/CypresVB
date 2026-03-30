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
        Label1 = New Label()
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
        txtTipo = New TextBox()
        Label7 = New Label()
        lbl_Id = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(365, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(21, 15)
        Label1.TabIndex = 0
        Label1.Text = "ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(351, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 15)
        Label2.TabIndex = 2
        Label2.Text = "Sigla:"
        ' 
        ' txtSigla
        ' 
        txtSigla.Location = New Point(403, 81)
        txtSigla.MaxLength = 10
        txtSigla.Name = "txtSigla"
        txtSigla.Size = New Size(62, 23)
        txtSigla.TabIndex = 3
        ' 
        ' txtComitente
        ' 
        txtComitente.Location = New Point(403, 110)
        txtComitente.MaxLength = 50
        txtComitente.Name = "txtComitente"
        txtComitente.Size = New Size(358, 23)
        txtComitente.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(320, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 15)
        Label3.TabIndex = 4
        Label3.Text = "Comitente:"
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(403, 139)
        txtDireccion.MaxLength = 50
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(358, 23)
        txtDireccion.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(320, 139)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 15)
        Label4.TabIndex = 6
        Label4.Text = "Direccion:"
        ' 
        ' txtLocalidad
        ' 
        txtLocalidad.Location = New Point(403, 168)
        txtLocalidad.MaxLength = 50
        txtLocalidad.Name = "txtLocalidad"
        txtLocalidad.Size = New Size(358, 23)
        txtLocalidad.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(320, 168)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 15)
        Label5.TabIndex = 8
        Label5.Text = "Localidad:"
        ' 
        ' txtCPostal
        ' 
        txtCPostal.Location = New Point(403, 197)
        txtCPostal.MaxLength = 15
        txtCPostal.Name = "txtCPostal"
        txtCPostal.Size = New Size(100, 23)
        txtCPostal.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(324, 200)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 15)
        Label6.TabIndex = 10
        Label6.Text = "C. Postal:"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(412, 273)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(85, 23)
        btnGuardar.TabIndex = 12
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(518, 273)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(85, 23)
        btnCancelar.TabIndex = 13
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' txtTipo
        ' 
        txtTipo.Location = New Point(403, 226)
        txtTipo.MaxLength = 10
        txtTipo.Name = "txtTipo"
        txtTipo.Size = New Size(47, 23)
        txtTipo.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(365, 234)
        Label7.Name = "Label7"
        Label7.Size = New Size(33, 15)
        Label7.TabIndex = 14
        Label7.Text = "Tipo:"
        ' 
        ' lbl_Id
        ' 
        lbl_Id.AutoSize = True
        lbl_Id.BorderStyle = BorderStyle.FixedSingle
        lbl_Id.ForeColor = Color.Red
        lbl_Id.Location = New Point(403, 58)
        lbl_Id.Name = "lbl_Id"
        lbl_Id.Size = New Size(37, 17)
        lbl_Id.TabIndex = 16
        lbl_Id.Text = "lbl_id"
        lbl_Id.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmComitente
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbl_Id)
        Controls.Add(txtTipo)
        Controls.Add(Label7)
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
        Controls.Add(Label1)
        Name = "frmComitente"
        Text = "Comitente - Editar"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
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
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_Id As Label
End Class
