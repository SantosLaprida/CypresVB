<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedoresAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedoresAdmin))
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
        Panel1 = New Panel()
        btnColumnas = New Button()
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
        ToolStrip1.Size = New Size(2018, 29)
        ToolStrip1.TabIndex = 1
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
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(btnColumnas)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 29)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(2018, 87)
        Panel1.TabIndex = 5
        ' 
        ' btnColumnas
        ' 
        btnColumnas.FlatAppearance.BorderSize = 0
        btnColumnas.FlatStyle = FlatStyle.Flat
        btnColumnas.Image = CType(resources.GetObject("btnColumnas.Image"), Image)
        btnColumnas.Location = New Point(1367, 25)
        btnColumnas.Name = "btnColumnas"
        btnColumnas.Size = New Size(32, 32)
        btnColumnas.TabIndex = 0
        btnColumnas.UseVisualStyleBackColor = True
        ' 
        ' frmProveedoresAdmin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2018, 905)
        Controls.Add(Panel1)
        Controls.Add(ToolStrip1)
        Name = "frmProveedoresAdmin"
        Text = "Proveedores"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
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
    Friend WithEvents AyudaToolStripButton As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnColumnas As Button
End Class
