<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOferentes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOferentes))
        listBoxEmpresas = New ListBox()
        listBoxOferentes = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        btnAceptar = New Button()
        btnCancelar = New Button()
        btnRemover = New Button()
        SuspendLayout()
        ' 
        ' listBoxEmpresas
        ' 
        listBoxEmpresas.BackColor = SystemColors.Info
        listBoxEmpresas.FormattingEnabled = True
        listBoxEmpresas.Location = New Point(89, 125)
        listBoxEmpresas.Name = "listBoxEmpresas"
        listBoxEmpresas.Size = New Size(313, 354)
        listBoxEmpresas.TabIndex = 0
        ' 
        ' listBoxOferentes
        ' 
        listBoxOferentes.BackColor = SystemColors.Info
        listBoxOferentes.FormattingEnabled = True
        listBoxOferentes.Location = New Point(473, 125)
        listBoxOferentes.Name = "listBoxOferentes"
        listBoxOferentes.Size = New Size(313, 354)
        listBoxOferentes.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(89, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 25)
        Label1.TabIndex = 2
        Label1.Text = "Empresas"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(473, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 25)
        Label2.TabIndex = 3
        Label2.Text = "Oferentes"
        ' 
        ' btnAceptar
        ' 
        btnAceptar.BackColor = SystemColors.HotTrack
        btnAceptar.Cursor = Cursors.Hand
        btnAceptar.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        btnAceptar.FlatAppearance.BorderSize = 0
        btnAceptar.FlatStyle = FlatStyle.Flat
        btnAceptar.Font = New Font("Segoe UI", 8.25F)
        btnAceptar.ForeColor = Color.White
        btnAceptar.Location = New Point(89, 537)
        btnAceptar.Margin = New Padding(5)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(111, 35)
        btnAceptar.TabIndex = 13
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = False
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
        btnCancelar.Location = New Point(255, 537)
        btnCancelar.Margin = New Padding(5)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(111, 35)
        btnCancelar.TabIndex = 14
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' btnRemover
        ' 
        btnRemover.FlatStyle = FlatStyle.Flat
        btnRemover.ForeColor = SystemColors.ActiveCaption
        btnRemover.Image = CType(resources.GetObject("btnRemover.Image"), Image)
        btnRemover.Location = New Point(473, 485)
        btnRemover.Name = "btnRemover"
        btnRemover.Size = New Size(62, 34)
        btnRemover.TabIndex = 16
        btnRemover.UseVisualStyleBackColor = True
        ' 
        ' frmOferentes
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(874, 649)
        Controls.Add(btnRemover)
        Controls.Add(btnCancelar)
        Controls.Add(btnAceptar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(listBoxOferentes)
        Controls.Add(listBoxEmpresas)
        Name = "frmOferentes"
        Text = "Oferentes"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents listBoxEmpresas As ListBox
    Friend WithEvents listBoxOferentes As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnRemover As Button
End Class
