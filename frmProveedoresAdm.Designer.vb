<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProveedoresAdm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedoresAdm))
        Button1 = New Button()
        btnNuevo = New Button()
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
        GridProveedores = New Syncfusion.Windows.Forms.Grid.GridControl()
        ToolStrip1.SuspendLayout()
        CType(GridProveedores, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(654, 219)
        Button1.Name = "Button1"
        Button1.Size = New Size(79, 25)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.BackColor = Color.Transparent
        btnNuevo.FlatAppearance.BorderSize = 0
        btnNuevo.FlatStyle = FlatStyle.Flat
        btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), Image)
        btnNuevo.Location = New Point(524, 212)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(36, 32)
        btnNuevo.TabIndex = 2
        btnNuevo.Tag = "Nuevo"
        btnNuevo.TextAlign = ContentAlignment.MiddleRight
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {NuevoToolStripButton, AbrirToolStripButton, GuardarToolStripButton, ImprimirToolStripButton, toolStripSeparator, CortarToolStripButton, CopiarToolStripButton, PegarToolStripButton, toolStripSeparator1, AyudaToolStripButton})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(800, 25)
        ToolStrip1.TabIndex = 3
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' NuevoToolStripButton
        ' 
        NuevoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        NuevoToolStripButton.Image = CType(resources.GetObject("NuevoToolStripButton.Image"), Image)
        NuevoToolStripButton.ImageTransparentColor = Color.Magenta
        NuevoToolStripButton.Name = "NuevoToolStripButton"
        NuevoToolStripButton.Size = New Size(23, 22)
        NuevoToolStripButton.Text = "&Nuevo"
        ' 
        ' AbrirToolStripButton
        ' 
        AbrirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AbrirToolStripButton.Image = CType(resources.GetObject("AbrirToolStripButton.Image"), Image)
        AbrirToolStripButton.ImageTransparentColor = Color.Magenta
        AbrirToolStripButton.Name = "AbrirToolStripButton"
        AbrirToolStripButton.Size = New Size(23, 22)
        AbrirToolStripButton.Text = "&Abrir"
        ' 
        ' GuardarToolStripButton
        ' 
        GuardarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        GuardarToolStripButton.Image = CType(resources.GetObject("GuardarToolStripButton.Image"), Image)
        GuardarToolStripButton.ImageTransparentColor = Color.Magenta
        GuardarToolStripButton.Name = "GuardarToolStripButton"
        GuardarToolStripButton.Size = New Size(23, 22)
        GuardarToolStripButton.Text = "&Guardar"
        ' 
        ' ImprimirToolStripButton
        ' 
        ImprimirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ImprimirToolStripButton.Image = CType(resources.GetObject("ImprimirToolStripButton.Image"), Image)
        ImprimirToolStripButton.ImageTransparentColor = Color.Magenta
        ImprimirToolStripButton.Name = "ImprimirToolStripButton"
        ImprimirToolStripButton.Size = New Size(23, 22)
        ImprimirToolStripButton.Text = "&Imprimir"
        ' 
        ' toolStripSeparator
        ' 
        toolStripSeparator.Name = "toolStripSeparator"
        toolStripSeparator.Size = New Size(6, 25)
        ' 
        ' CortarToolStripButton
        ' 
        CortarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        CortarToolStripButton.Image = CType(resources.GetObject("CortarToolStripButton.Image"), Image)
        CortarToolStripButton.ImageTransparentColor = Color.Magenta
        CortarToolStripButton.Name = "CortarToolStripButton"
        CortarToolStripButton.Size = New Size(23, 22)
        CortarToolStripButton.Text = "&Cortar"
        ' 
        ' CopiarToolStripButton
        ' 
        CopiarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        CopiarToolStripButton.Image = CType(resources.GetObject("CopiarToolStripButton.Image"), Image)
        CopiarToolStripButton.ImageTransparentColor = Color.Magenta
        CopiarToolStripButton.Name = "CopiarToolStripButton"
        CopiarToolStripButton.Size = New Size(23, 22)
        CopiarToolStripButton.Text = "&Copiar"
        ' 
        ' PegarToolStripButton
        ' 
        PegarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        PegarToolStripButton.Image = CType(resources.GetObject("PegarToolStripButton.Image"), Image)
        PegarToolStripButton.ImageTransparentColor = Color.Magenta
        PegarToolStripButton.Name = "PegarToolStripButton"
        PegarToolStripButton.Size = New Size(23, 22)
        PegarToolStripButton.Text = "&Pegar"
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' AyudaToolStripButton
        ' 
        AyudaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AyudaToolStripButton.Image = CType(resources.GetObject("AyudaToolStripButton.Image"), Image)
        AyudaToolStripButton.ImageTransparentColor = Color.Magenta
        AyudaToolStripButton.Name = "AyudaToolStripButton"
        AyudaToolStripButton.Size = New Size(23, 22)
        AyudaToolStripButton.Text = "&Ayuda"
        ' 
        ' GridProveedores
        ' 
        GridProveedores.Location = New Point(0, 28)
        GridProveedores.Name = "GridProveedores"
        GridProveedores.Size = New Size(788, 80)
        GridProveedores.SmartSizeBox = False
        GridProveedores.TabIndex = 4
        GridProveedores.Text = "GridControl1"
        GridProveedores.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        GridProveedores.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBorderColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        GridProveedores.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        GridProveedores.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        GridProveedores.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBackColor = Color.FromArgb(CByte(114), CByte(114), CByte(114))
        GridProveedores.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBorderColor = Color.FromArgb(CByte(94), CByte(94), CByte(94))
        GridProveedores.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        GridProveedores.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBorderColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        GridProveedores.ThemeStyle.HorizontalScrollBarStyle.ScrollBarBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        GridProveedores.ThemeStyle.HorizontalScrollBarStyle.ThumbBorderColor = Color.FromArgb(CByte(171), CByte(171), CByte(171))
        GridProveedores.ThemeStyle.HorizontalScrollBarStyle.ThumbColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        GridProveedores.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledBorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        GridProveedores.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        GridProveedores.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverBorderColor = Color.FromArgb(CByte(171), CByte(171), CByte(171))
        GridProveedores.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverColor = Color.FromArgb(CByte(197), CByte(197), CByte(197))
        GridProveedores.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedBorderColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        GridProveedores.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedColor = Color.FromArgb(CByte(197), CByte(197), CByte(197))
        GridProveedores.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        GridProveedores.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBorderColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        GridProveedores.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        GridProveedores.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        GridProveedores.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBackColor = Color.FromArgb(CByte(114), CByte(114), CByte(114))
        GridProveedores.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBorderColor = Color.FromArgb(CByte(94), CByte(94), CByte(94))
        GridProveedores.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        GridProveedores.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBorderColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        GridProveedores.ThemeStyle.VerticalScrollBarStyle.ScrollBarBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        GridProveedores.ThemeStyle.VerticalScrollBarStyle.ThumbBorderColor = Color.FromArgb(CByte(171), CByte(171), CByte(171))
        GridProveedores.ThemeStyle.VerticalScrollBarStyle.ThumbColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        GridProveedores.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledBorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        GridProveedores.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        GridProveedores.ThemeStyle.VerticalScrollBarStyle.ThumbHoverBorderColor = Color.FromArgb(CByte(171), CByte(171), CByte(171))
        GridProveedores.ThemeStyle.VerticalScrollBarStyle.ThumbHoverColor = Color.FromArgb(CByte(197), CByte(197), CByte(197))
        GridProveedores.ThemeStyle.VerticalScrollBarStyle.ThumbPressedBorderColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        GridProveedores.ThemeStyle.VerticalScrollBarStyle.ThumbPressedColor = Color.FromArgb(CByte(197), CByte(197), CByte(197))
        GridProveedores.UseRightToLeftCompatibleTextBox = True
        ' 
        ' frmProveedoresAdm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GridProveedores)
        Controls.Add(ToolStrip1)
        Controls.Add(btnNuevo)
        Controls.Add(Button1)
        Name = "frmProveedoresAdm"
        Text = "Form1"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        CType(GridProveedores, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnNuevo As Button
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
    Friend WithEvents GridProveedores As Syncfusion.Windows.Forms.Grid.GridControl


End Class
