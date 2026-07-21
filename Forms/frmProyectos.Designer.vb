<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProyectos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProyectos))
        grid = New Syncfusion.Windows.Forms.Grid.GridControl()
        ToolStrip1 = New ToolStrip()
        NuevoToolStripButton = New ToolStripButton()
        AbrirToolStripButton = New ToolStripButton()
        GuardarToolStripButton = New ToolStripButton()
        ImprimirToolStripButton = New ToolStripButton()
        toolStripSeparator = New ToolStripSeparator()
        toolStripSeparator1 = New ToolStripSeparator()
        Label1 = New Label()
        Panel1 = New Panel()
        ComboLicitacion = New ComboBox()
        Label3 = New Label()
        ComboComitente = New ComboBox()
        Label2 = New Label()
        btnColumnas = New Button()
        CType(grid, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' grid
        ' 
        grid.Location = New Point(0, 89)
        grid.Name = "grid"
        grid.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode
        grid.Size = New Size(711, 252)
        grid.SmartSizeBox = False
        grid.TabIndex = 10
        grid.Text = "GridControl2"
        grid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        grid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBorderColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        grid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        grid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        grid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBackColor = Color.FromArgb(CByte(114), CByte(114), CByte(114))
        grid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBorderColor = Color.FromArgb(CByte(94), CByte(94), CByte(94))
        grid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        grid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBorderColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        grid.ThemeStyle.HorizontalScrollBarStyle.ScrollBarBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        grid.ThemeStyle.HorizontalScrollBarStyle.ThumbBorderColor = Color.FromArgb(CByte(171), CByte(171), CByte(171))
        grid.ThemeStyle.HorizontalScrollBarStyle.ThumbColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        grid.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledBorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        grid.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        grid.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverBorderColor = Color.FromArgb(CByte(171), CByte(171), CByte(171))
        grid.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverColor = Color.FromArgb(CByte(197), CByte(197), CByte(197))
        grid.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedBorderColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        grid.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedColor = Color.FromArgb(CByte(197), CByte(197), CByte(197))
        grid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        grid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBorderColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        grid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        grid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        grid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBackColor = Color.FromArgb(CByte(114), CByte(114), CByte(114))
        grid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBorderColor = Color.FromArgb(CByte(94), CByte(94), CByte(94))
        grid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        grid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBorderColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        grid.ThemeStyle.VerticalScrollBarStyle.ScrollBarBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        grid.ThemeStyle.VerticalScrollBarStyle.ThumbBorderColor = Color.FromArgb(CByte(171), CByte(171), CByte(171))
        grid.ThemeStyle.VerticalScrollBarStyle.ThumbColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        grid.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledBorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        grid.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        grid.ThemeStyle.VerticalScrollBarStyle.ThumbHoverBorderColor = Color.FromArgb(CByte(171), CByte(171), CByte(171))
        grid.ThemeStyle.VerticalScrollBarStyle.ThumbHoverColor = Color.FromArgb(CByte(197), CByte(197), CByte(197))
        grid.ThemeStyle.VerticalScrollBarStyle.ThumbPressedBorderColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        grid.ThemeStyle.VerticalScrollBarStyle.ThumbPressedColor = Color.FromArgb(CByte(197), CByte(197), CByte(197))
        grid.UseRightToLeftCompatibleTextBox = True
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = SystemColors.ActiveCaption
        ToolStrip1.ImageScalingSize = New Size(24, 24)
        ToolStrip1.Items.AddRange(New ToolStripItem() {NuevoToolStripButton, AbrirToolStripButton, GuardarToolStripButton, ImprimirToolStripButton, toolStripSeparator, toolStripSeparator1})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Padding = New Padding(0, 0, 3, 0)
        ToolStrip1.Size = New Size(800, 31)
        ToolStrip1.TabIndex = 9
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' NuevoToolStripButton
        ' 
        NuevoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        NuevoToolStripButton.Image = CType(resources.GetObject("NuevoToolStripButton.Image"), Image)
        NuevoToolStripButton.ImageTransparentColor = Color.Magenta
        NuevoToolStripButton.Name = "NuevoToolStripButton"
        NuevoToolStripButton.Padding = New Padding(5, 0, 5, 0)
        NuevoToolStripButton.Size = New Size(38, 28)
        NuevoToolStripButton.Text = "&Nuevo"
        ' 
        ' AbrirToolStripButton
        ' 
        AbrirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AbrirToolStripButton.Image = CType(resources.GetObject("AbrirToolStripButton.Image"), Image)
        AbrirToolStripButton.ImageTransparentColor = Color.Magenta
        AbrirToolStripButton.Name = "AbrirToolStripButton"
        AbrirToolStripButton.Padding = New Padding(5, 0, 5, 0)
        AbrirToolStripButton.Size = New Size(38, 28)
        AbrirToolStripButton.Text = "&Abrir"
        ' 
        ' GuardarToolStripButton
        ' 
        GuardarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        GuardarToolStripButton.Image = CType(resources.GetObject("GuardarToolStripButton.Image"), Image)
        GuardarToolStripButton.ImageTransparentColor = Color.Magenta
        GuardarToolStripButton.Name = "GuardarToolStripButton"
        GuardarToolStripButton.Padding = New Padding(5, 0, 5, 0)
        GuardarToolStripButton.Size = New Size(38, 28)
        GuardarToolStripButton.Text = "&Guardar"
        ' 
        ' ImprimirToolStripButton
        ' 
        ImprimirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ImprimirToolStripButton.Image = CType(resources.GetObject("ImprimirToolStripButton.Image"), Image)
        ImprimirToolStripButton.ImageTransparentColor = Color.Magenta
        ImprimirToolStripButton.Name = "ImprimirToolStripButton"
        ImprimirToolStripButton.Padding = New Padding(5, 0, 5, 0)
        ImprimirToolStripButton.Size = New Size(38, 28)
        ImprimirToolStripButton.Text = "&Imprimir"
        ' 
        ' toolStripSeparator
        ' 
        toolStripSeparator.Name = "toolStripSeparator"
        toolStripSeparator.Size = New Size(6, 31)
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 31)
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(261, 137)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 15)
        Label1.TabIndex = 12
        Label1.Text = "Comitente:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(ComboLicitacion)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(ComboComitente)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnColumnas)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 31)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 52)
        Panel1.TabIndex = 16
        ' 
        ' ComboLicitacion
        ' 
        ComboLicitacion.Anchor = AnchorStyles.Top
        ComboLicitacion.FormattingEnabled = True
        ComboLicitacion.Location = New Point(477, 9)
        ComboLicitacion.Margin = New Padding(2)
        ComboLicitacion.Name = "ComboLicitacion"
        ComboLicitacion.Size = New Size(234, 23)
        ComboLicitacion.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(402, 9)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 15)
        Label3.TabIndex = 19
        Label3.Text = "Licitacion:"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ComboComitente
        ' 
        ComboComitente.Anchor = AnchorStyles.Top
        ComboComitente.FormattingEnabled = True
        ComboComitente.Location = New Point(94, 9)
        ComboComitente.Margin = New Padding(2)
        ComboComitente.Name = "ComboComitente"
        ComboComitente.Size = New Size(234, 23)
        ComboComitente.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(19, 9)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 17
        Label2.Text = "Comitente:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnColumnas
        ' 
        btnColumnas.FlatAppearance.BorderSize = 0
        btnColumnas.FlatStyle = FlatStyle.Flat
        btnColumnas.Image = CType(resources.GetObject("btnColumnas.Image"), Image)
        btnColumnas.Location = New Point(957, 15)
        btnColumnas.Margin = New Padding(2)
        btnColumnas.Name = "btnColumnas"
        btnColumnas.Size = New Size(22, 19)
        btnColumnas.TabIndex = 0
        btnColumnas.UseVisualStyleBackColor = True
        ' 
        ' frmProyectos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(grid)
        Controls.Add(ToolStrip1)
        Name = "frmProyectos"
        Text = "Proyectos"
        CType(grid, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grid As Syncfusion.Windows.Forms.Grid.GridControl
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NuevoToolStripButton As ToolStripButton
    Friend WithEvents AbrirToolStripButton As ToolStripButton
    Friend WithEvents GuardarToolStripButton As ToolStripButton
    Friend WithEvents ImprimirToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnColumnas As Button
    Friend WithEvents ComboComitente As ComboBox
    Friend WithEvents ComboLicitacion As ComboBox
    Friend WithEvents Label3 As Label
End Class
