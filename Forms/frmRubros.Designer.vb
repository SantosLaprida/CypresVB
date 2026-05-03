<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRubros
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
        Label5 = New Label()
        lstRubros = New ListBox()
        lstSubrubros = New ListBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        btnModificarRubro = New Button()
        btnAgregarRubro = New Button()
        Label2 = New Label()
        txt_rubro = New TextBox()
        GroupBox3 = New GroupBox()
        btnAgregarSubrubro = New Button()
        Label3 = New Label()
        TextBox1 = New TextBox()
        lblRubro = New Label()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.BackColor = SystemColors.ActiveCaption
        Label5.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        Label5.Location = New Point(12, 17)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(227, 19)
        Label5.TabIndex = 14
        Label5.Text = "Rubros"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lstRubros
        ' 
        lstRubros.BorderStyle = BorderStyle.FixedSingle
        lstRubros.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstRubros.FormattingEnabled = True
        lstRubros.Location = New Point(12, 37)
        lstRubros.Name = "lstRubros"
        lstRubros.Size = New Size(227, 287)
        lstRubros.TabIndex = 10
        ' 
        ' lstSubrubros
        ' 
        lstSubrubros.BorderStyle = BorderStyle.FixedSingle
        lstSubrubros.FormattingEnabled = True
        lstSubrubros.Location = New Point(245, 37)
        lstSubrubros.Name = "lstSubrubros"
        lstSubrubros.Size = New Size(227, 287)
        lstSubrubros.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        Label1.Location = New Point(245, 17)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(227, 19)
        Label1.TabIndex = 17
        Label1.Text = "Subrubros"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnModificarRubro)
        GroupBox2.Controls.Add(btnAgregarRubro)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(txt_rubro)
        GroupBox2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(480, 37)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(289, 109)
        GroupBox2.TabIndex = 18
        GroupBox2.TabStop = False
        GroupBox2.Text = "Rubros"
        ' 
        ' btnModificarRubro
        ' 
        btnModificarRubro.BackColor = SystemColors.HotTrack
        btnModificarRubro.FlatStyle = FlatStyle.Flat
        btnModificarRubro.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnModificarRubro.ForeColor = Color.White
        btnModificarRubro.Location = New Point(183, 74)
        btnModificarRubro.Name = "btnModificarRubro"
        btnModificarRubro.Size = New Size(75, 29)
        btnModificarRubro.TabIndex = 22
        btnModificarRubro.Text = "Modificar "
        btnModificarRubro.UseVisualStyleBackColor = False
        ' 
        ' btnAgregarRubro
        ' 
        btnAgregarRubro.BackColor = SystemColors.HotTrack
        btnAgregarRubro.FlatStyle = FlatStyle.Flat
        btnAgregarRubro.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAgregarRubro.ForeColor = Color.White
        btnAgregarRubro.ImageAlign = ContentAlignment.MiddleLeft
        btnAgregarRubro.Location = New Point(100, 74)
        btnAgregarRubro.Name = "btnAgregarRubro"
        btnAgregarRubro.Size = New Size(77, 29)
        btnAgregarRubro.TabIndex = 21
        btnAgregarRubro.Text = "Agregar"
        btnAgregarRubro.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.ActiveCaption
        Label2.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        Label2.Location = New Point(31, 21)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(227, 19)
        Label2.TabIndex = 18
        Label2.Text = "Descripcion"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txt_rubro
        ' 
        txt_rubro.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_rubro.Location = New Point(31, 43)
        txt_rubro.MaxLength = 50
        txt_rubro.Name = "txt_rubro"
        txt_rubro.Size = New Size(227, 23)
        txt_rubro.TabIndex = 12
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(lblRubro)
        GroupBox3.Controls.Add(btnAgregarSubrubro)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(TextBox1)
        GroupBox3.Location = New Point(480, 152)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(287, 172)
        GroupBox3.TabIndex = 19
        GroupBox3.TabStop = False
        GroupBox3.Text = "Subrubros"
        ' 
        ' btnAgregarSubrubro
        ' 
        btnAgregarSubrubro.BackColor = SystemColors.HotTrack
        btnAgregarSubrubro.FlatStyle = FlatStyle.Flat
        btnAgregarSubrubro.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAgregarSubrubro.ForeColor = Color.White
        btnAgregarSubrubro.ImageAlign = ContentAlignment.MiddleLeft
        btnAgregarSubrubro.Location = New Point(102, 123)
        btnAgregarSubrubro.Name = "btnAgregarSubrubro"
        btnAgregarSubrubro.Size = New Size(75, 29)
        btnAgregarSubrubro.TabIndex = 22
        btnAgregarSubrubro.Text = "Agregar"
        btnAgregarSubrubro.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.BackColor = SystemColors.ActiveCaption
        Label3.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        Label3.Location = New Point(32, 72)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(227, 19)
        Label3.TabIndex = 20
        Label3.Text = "Descripcion"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(31, 94)
        TextBox1.MaxLength = 50
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(227, 23)
        TextBox1.TabIndex = 19
        ' 
        ' lblRubro
        ' 
        lblRubro.BackColor = Color.White
        lblRubro.BorderStyle = BorderStyle.FixedSingle
        lblRubro.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRubro.Location = New Point(32, 30)
        lblRubro.Name = "lblRubro"
        lblRubro.Size = New Size(221, 20)
        lblRubro.TabIndex = 23
        lblRubro.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' frmRubros
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(777, 439)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(Label1)
        Controls.Add(lstSubrubros)
        Controls.Add(Label5)
        Controls.Add(lstRubros)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmRubros"
        Text = "Rubros"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents lstRubros As ListBox
    Friend WithEvents lstSubrubros As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_rubro As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnAgregarRubro As Button
    Friend WithEvents btnModificarRubro As Button
    Friend WithEvents btnAgregarSubrubro As Button
    Friend WithEvents lblRubro As Label
End Class
