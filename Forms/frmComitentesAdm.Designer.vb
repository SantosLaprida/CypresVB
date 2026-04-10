<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComitentesAdm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComitentesAdm))
        ToolStrip1 = New ToolStrip()
        NuevoToolStripButton = New ToolStripButton()
        AbrirToolStripButton = New ToolStripButton()
        GuardarToolStripButton = New ToolStripButton()
        ImprimirToolStripButton = New ToolStripButton()
        toolStripSeparator = New ToolStripSeparator()
        CortarToolStripButton = New ToolStripButton()
        CopiarToolStripButton = New ToolStripButton()
        PegarToolStripButton = New ToolStripButton()
        toolStripSeparator1 = New ToolStripSeparator()
        AyudaToolStripButton = New ToolStripButton()
        Button2 = New Button()
        Panel1 = New Panel()
        Label2 = New Label()
        ComboBoxPais = New ComboBox()
        Label1 = New Label()
        txtBuscar = New TextBox()
        Button1 = New Button()
        ToolStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = SystemColors.ActiveCaption
        ToolStrip1.ImageScalingSize = New Size(16, 20)
        ToolStrip1.Items.AddRange(New ToolStripItem() {NuevoToolStripButton, AbrirToolStripButton, GuardarToolStripButton, ImprimirToolStripButton, toolStripSeparator, CortarToolStripButton, CopiarToolStripButton, PegarToolStripButton, toolStripSeparator1, AyudaToolStripButton})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Padding = New Padding(0, 0, 3, 0)
        ToolStrip1.Size = New Size(1385, 29)
        ToolStrip1.TabIndex = 0
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' NuevoToolStripButton
        ' 
        NuevoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        NuevoToolStripButton.Image = CType(resources.GetObject("NuevoToolStripButton.Image"), Image)
        NuevoToolStripButton.ImageTransparentColor = Color.Magenta
        NuevoToolStripButton.Name = "NuevoToolStripButton"
        NuevoToolStripButton.Size = New Size(34, 24)
        NuevoToolStripButton.Text = "&Nuevo"
        ' 
        ' AbrirToolStripButton
        ' 
        AbrirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AbrirToolStripButton.Image = CType(resources.GetObject("AbrirToolStripButton.Image"), Image)
        AbrirToolStripButton.ImageTransparentColor = Color.Magenta
        AbrirToolStripButton.Name = "AbrirToolStripButton"
        AbrirToolStripButton.Size = New Size(34, 24)
        AbrirToolStripButton.Text = "&Abrir"
        ' 
        ' GuardarToolStripButton
        ' 
        GuardarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        GuardarToolStripButton.Image = CType(resources.GetObject("GuardarToolStripButton.Image"), Image)
        GuardarToolStripButton.ImageTransparentColor = Color.Magenta
        GuardarToolStripButton.Name = "GuardarToolStripButton"
        GuardarToolStripButton.Size = New Size(34, 24)
        GuardarToolStripButton.Text = "&Guardar"
        ' 
        ' ImprimirToolStripButton
        ' 
        ImprimirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ImprimirToolStripButton.Image = CType(resources.GetObject("ImprimirToolStripButton.Image"), Image)
        ImprimirToolStripButton.ImageTransparentColor = Color.Magenta
        ImprimirToolStripButton.Name = "ImprimirToolStripButton"
        ImprimirToolStripButton.Size = New Size(34, 24)
        ImprimirToolStripButton.Text = "&Imprimir"
        ' 
        ' toolStripSeparator
        ' 
        toolStripSeparator.Name = "toolStripSeparator"
        toolStripSeparator.Size = New Size(6, 29)
        ' 
        ' CortarToolStripButton
        ' 
        CortarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        CortarToolStripButton.Image = CType(resources.GetObject("CortarToolStripButton.Image"), Image)
        CortarToolStripButton.ImageTransparentColor = Color.Magenta
        CortarToolStripButton.Name = "CortarToolStripButton"
        CortarToolStripButton.Size = New Size(34, 24)
        CortarToolStripButton.Text = "&Cortar"
        ' 
        ' CopiarToolStripButton
        ' 
        CopiarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        CopiarToolStripButton.Image = CType(resources.GetObject("CopiarToolStripButton.Image"), Image)
        CopiarToolStripButton.ImageTransparentColor = Color.Magenta
        CopiarToolStripButton.Name = "CopiarToolStripButton"
        CopiarToolStripButton.Size = New Size(34, 24)
        CopiarToolStripButton.Text = "&Copiar"
        ' 
        ' PegarToolStripButton
        ' 
        PegarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        PegarToolStripButton.Image = CType(resources.GetObject("PegarToolStripButton.Image"), Image)
        PegarToolStripButton.ImageTransparentColor = Color.Magenta
        PegarToolStripButton.Name = "PegarToolStripButton"
        PegarToolStripButton.Size = New Size(34, 24)
        PegarToolStripButton.Text = "&Pegar"
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 29)
        ' 
        ' AyudaToolStripButton
        ' 
        AyudaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AyudaToolStripButton.Image = CType(resources.GetObject("AyudaToolStripButton.Image"), Image)
        AyudaToolStripButton.ImageTransparentColor = Color.Magenta
        AyudaToolStripButton.Name = "AyudaToolStripButton"
        AyudaToolStripButton.Size = New Size(34, 24)
        AyudaToolStripButton.Text = "&Ayuda"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1016, 400)
        Button2.Margin = New Padding(4, 5, 4, 5)
        Button2.Name = "Button2"
        Button2.Size = New Size(107, 38)
        Button2.TabIndex = 2
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(ComboBoxPais)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtBuscar)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(0, 50)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1385, 87)
        Panel1.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(457, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 25)
        Label2.TabIndex = 7
        Label2.Text = "Pais:"
        ' 
        ' ComboBoxPais
        ' 
        ComboBoxPais.FormattingEnabled = True
        ComboBoxPais.Location = New Point(505, 30)
        ComboBoxPais.Name = "ComboBoxPais"
        ComboBoxPais.Size = New Size(137, 33)
        ComboBoxPais.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(897, 32)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 25)
        Label1.TabIndex = 5
        Label1.Text = "Comitente:"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(1000, 25)
        txtBuscar.Margin = New Padding(4, 5, 4, 5)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(341, 31)
        txtBuscar.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(4, 25)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(107, 38)
        Button1.TabIndex = 2
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' frmComitentesAdm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1385, 750)
        Controls.Add(Panel1)
        Controls.Add(Button2)
        Controls.Add(ToolStrip1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "frmComitentesAdm"
        Text = "Form2"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NuevoToolStripButton As ToolStripButton
    Friend WithEvents AbrirToolStripButton As ToolStripButton
    Friend WithEvents GuardarToolStripButton As ToolStripButton
    Friend WithEvents ImprimirToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents CortarToolStripButton As ToolStripButton
    Friend WithEvents CopiarToolStripButton As ToolStripButton
    Friend WithEvents PegarToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Button2 As Button
    Friend WithEvents AyudaToolStripButton As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxPais As ComboBox
End Class
