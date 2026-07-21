<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLicitaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLicitaciones))
        Dim GridCellInfo1 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo2 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo3 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo4 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
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
        TableLayoutPanel1 = New TableLayoutPanel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        ComboTipoProyecto = New ComboBox()
        ComboEstado = New ComboBox()
        ComboBoxPais = New ComboBox()
        ComboBoxComitente = New ComboBox()
        Label1 = New Label()
        Grid = New Syncfusion.Windows.Forms.Grid.GridControl()
        ToolStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(Grid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = SystemColors.ActiveCaption
        ToolStrip1.ImageScalingSize = New Size(16, 20)
        ToolStrip1.Items.AddRange(New ToolStripItem() {NuevoToolStripButton, AbrirToolStripButton, GuardarToolStripButton, ImprimirToolStripButton, toolStripSeparator, CortarToolStripButton, CopiarToolStripButton, PegarToolStripButton, toolStripSeparator1, AyudaToolStripButton})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Padding = New Padding(0, 0, 2, 0)
        ToolStrip1.Size = New Size(959, 27)
        ToolStrip1.TabIndex = 1
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' NuevoToolStripButton
        ' 
        NuevoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        NuevoToolStripButton.Image = CType(resources.GetObject("NuevoToolStripButton.Image"), Image)
        NuevoToolStripButton.ImageTransparentColor = Color.Magenta
        NuevoToolStripButton.Name = "NuevoToolStripButton"
        NuevoToolStripButton.Size = New Size(23, 24)
        NuevoToolStripButton.Text = "&Nuevo"
        ' 
        ' AbrirToolStripButton
        ' 
        AbrirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AbrirToolStripButton.Image = CType(resources.GetObject("AbrirToolStripButton.Image"), Image)
        AbrirToolStripButton.ImageTransparentColor = Color.Magenta
        AbrirToolStripButton.Name = "AbrirToolStripButton"
        AbrirToolStripButton.Size = New Size(23, 24)
        AbrirToolStripButton.Text = "&Abrir"
        ' 
        ' GuardarToolStripButton
        ' 
        GuardarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        GuardarToolStripButton.Image = CType(resources.GetObject("GuardarToolStripButton.Image"), Image)
        GuardarToolStripButton.ImageTransparentColor = Color.Magenta
        GuardarToolStripButton.Name = "GuardarToolStripButton"
        GuardarToolStripButton.Size = New Size(23, 24)
        GuardarToolStripButton.Text = "&Guardar"
        ' 
        ' ImprimirToolStripButton
        ' 
        ImprimirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ImprimirToolStripButton.Image = CType(resources.GetObject("ImprimirToolStripButton.Image"), Image)
        ImprimirToolStripButton.ImageTransparentColor = Color.Magenta
        ImprimirToolStripButton.Name = "ImprimirToolStripButton"
        ImprimirToolStripButton.Size = New Size(23, 24)
        ImprimirToolStripButton.Text = "&Imprimir"
        ' 
        ' toolStripSeparator
        ' 
        toolStripSeparator.Name = "toolStripSeparator"
        toolStripSeparator.Size = New Size(6, 27)
        ' 
        ' CortarToolStripButton
        ' 
        CortarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        CortarToolStripButton.Image = CType(resources.GetObject("CortarToolStripButton.Image"), Image)
        CortarToolStripButton.ImageTransparentColor = Color.Magenta
        CortarToolStripButton.Name = "CortarToolStripButton"
        CortarToolStripButton.Size = New Size(23, 24)
        CortarToolStripButton.Text = "&Cortar"
        ' 
        ' CopiarToolStripButton
        ' 
        CopiarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        CopiarToolStripButton.Image = CType(resources.GetObject("CopiarToolStripButton.Image"), Image)
        CopiarToolStripButton.ImageTransparentColor = Color.Magenta
        CopiarToolStripButton.Name = "CopiarToolStripButton"
        CopiarToolStripButton.Size = New Size(23, 24)
        CopiarToolStripButton.Text = "&Copiar"
        ' 
        ' PegarToolStripButton
        ' 
        PegarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        PegarToolStripButton.Image = CType(resources.GetObject("PegarToolStripButton.Image"), Image)
        PegarToolStripButton.ImageTransparentColor = Color.Magenta
        PegarToolStripButton.Name = "PegarToolStripButton"
        PegarToolStripButton.Size = New Size(23, 24)
        PegarToolStripButton.Text = "&Pegar"
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 27)
        ' 
        ' AyudaToolStripButton
        ' 
        AyudaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AyudaToolStripButton.Image = CType(resources.GetObject("AyudaToolStripButton.Image"), Image)
        AyudaToolStripButton.ImageTransparentColor = Color.Magenta
        AyudaToolStripButton.Name = "AyudaToolStripButton"
        AyudaToolStripButton.Size = New Size(23, 24)
        AyudaToolStripButton.Text = "&Ayuda"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(214), CByte(224), CByte(240))
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 27)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(959, 72)
        Panel1.TabIndex = 2
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(Label4, 3, 0)
        TableLayoutPanel1.Controls.Add(ComboTipoProyecto, 2, 1)
        TableLayoutPanel1.Controls.Add(ComboEstado, 3, 1)
        TableLayoutPanel1.Controls.Add(ComboBoxPais, 0, 1)
        TableLayoutPanel1.Controls.Add(ComboBoxComitente, 1, 1)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(Label2, 2, 0)
        TableLayoutPanel1.Controls.Add(Label3, 1, 0)
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(2)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(1102, 72)
        TableLayoutPanel1.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Location = New Point(942, 10)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 15)
        Label4.TabIndex = 7
        Label4.Text = "Estado"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Location = New Point(381, 10)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 15)
        Label3.TabIndex = 6
        Label3.Text = "Comitente"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Location = New Point(639, 10)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 15)
        Label2.TabIndex = 5
        Label2.Text = "Tipo de Proyecto"
        ' 
        ' ComboTipoProyecto
        ' 
        ComboTipoProyecto.Anchor = AnchorStyles.Top
        ComboTipoProyecto.FormattingEnabled = True
        ComboTipoProyecto.Location = New Point(599, 38)
        ComboTipoProyecto.Margin = New Padding(2)
        ComboTipoProyecto.Name = "ComboTipoProyecto"
        ComboTipoProyecto.Size = New Size(177, 23)
        ComboTipoProyecto.TabIndex = 1
        ' 
        ' ComboEstado
        ' 
        ComboEstado.Anchor = AnchorStyles.Top
        ComboEstado.FormattingEnabled = True
        ComboEstado.Location = New Point(875, 38)
        ComboEstado.Margin = New Padding(2)
        ComboEstado.Name = "ComboEstado"
        ComboEstado.Size = New Size(177, 23)
        ComboEstado.TabIndex = 2
        ' 
        ' ComboBoxPais
        ' 
        ComboBoxPais.Anchor = AnchorStyles.Top
        ComboBoxPais.FormattingEnabled = True
        ComboBoxPais.Location = New Point(49, 38)
        ComboBoxPais.Margin = New Padding(2)
        ComboBoxPais.Name = "ComboBoxPais"
        ComboBoxPais.Size = New Size(177, 23)
        ComboBoxPais.TabIndex = 0
        ' 
        ' ComboBoxComitente
        ' 
        ComboBoxComitente.Anchor = AnchorStyles.Top
        ComboBoxComitente.FormattingEnabled = True
        ComboBoxComitente.Location = New Point(324, 38)
        ComboBoxComitente.Margin = New Padding(2)
        ComboBoxComitente.Name = "ComboBoxComitente"
        ComboBoxComitente.Size = New Size(177, 23)
        ComboBoxComitente.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Location = New Point(123, 10)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(28, 15)
        Label1.TabIndex = 4
        Label1.Text = "Pais"
        ' 
        ' Grid
        ' 
        Grid.Font = New Font("Cambria", 8.25F)
        GridCellInfo1.Col = -1
        GridCellInfo1.Row = -1
        GridCellInfo1.StyleInfo.Font.Bold = False
        GridCellInfo1.StyleInfo.Font.Facename = "Cambria"
        GridCellInfo1.StyleInfo.Font.Italic = False
        GridCellInfo1.StyleInfo.Font.Size = 8.25F
        GridCellInfo1.StyleInfo.Font.Strikeout = False
        GridCellInfo1.StyleInfo.Font.Underline = False
        GridCellInfo1.StyleInfo.Font.Unit = GraphicsUnit.Point
        GridCellInfo2.Col = -1
        GridCellInfo2.Row = -1
        GridCellInfo2.StyleInfo.Font.Bold = False
        GridCellInfo2.StyleInfo.Font.Facename = "Cambria"
        GridCellInfo2.StyleInfo.Font.Italic = False
        GridCellInfo2.StyleInfo.Font.Size = 8.25F
        GridCellInfo2.StyleInfo.Font.Strikeout = False
        GridCellInfo2.StyleInfo.Font.Underline = False
        GridCellInfo2.StyleInfo.Font.Unit = GraphicsUnit.Point
        GridCellInfo3.Col = -1
        GridCellInfo3.Row = -1
        GridCellInfo3.StyleInfo.Font.Bold = False
        GridCellInfo3.StyleInfo.Font.Facename = "Cambria"
        GridCellInfo3.StyleInfo.Font.Italic = False
        GridCellInfo3.StyleInfo.Font.Size = 8.25F
        GridCellInfo3.StyleInfo.Font.Strikeout = False
        GridCellInfo3.StyleInfo.Font.Underline = False
        GridCellInfo3.StyleInfo.Font.Unit = GraphicsUnit.Point
        GridCellInfo4.Col = -1
        GridCellInfo4.Row = -1
        GridCellInfo4.StyleInfo.Font.Bold = False
        GridCellInfo4.StyleInfo.Font.Facename = "Cambria"
        GridCellInfo4.StyleInfo.Font.Italic = False
        GridCellInfo4.StyleInfo.Font.Size = 8.25F
        GridCellInfo4.StyleInfo.Font.Strikeout = False
        GridCellInfo4.StyleInfo.Font.Underline = False
        GridCellInfo4.StyleInfo.Font.Unit = GraphicsUnit.Point
        Grid.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() {GridCellInfo1, GridCellInfo2, GridCellInfo3, GridCellInfo4})
        Grid.Location = New Point(0, 104)
        Grid.Name = "Grid"
        Grid.Properties.DisplayHorzLines = False
        Grid.Properties.DisplayVertLines = False
        Grid.Properties.RowHeaders = False
        Grid.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode
        Grid.ShowRowHeaders = False
        Grid.Size = New Size(927, 255)
        Grid.SmartSizeBox = False
        Grid.TabIndex = 3
        Grid.Text = "GridControl1"
        Grid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        Grid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBorderColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        Grid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        Grid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        Grid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBackColor = Color.FromArgb(CByte(114), CByte(114), CByte(114))
        Grid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBorderColor = Color.FromArgb(CByte(94), CByte(94), CByte(94))
        Grid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        Grid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBorderColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        Grid.ThemeStyle.HorizontalScrollBarStyle.ScrollBarBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        Grid.ThemeStyle.HorizontalScrollBarStyle.ThumbBorderColor = Color.FromArgb(CByte(171), CByte(171), CByte(171))
        Grid.ThemeStyle.HorizontalScrollBarStyle.ThumbColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        Grid.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledBorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        Grid.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        Grid.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverBorderColor = Color.FromArgb(CByte(171), CByte(171), CByte(171))
        Grid.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverColor = Color.FromArgb(CByte(197), CByte(197), CByte(197))
        Grid.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedBorderColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        Grid.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedColor = Color.FromArgb(CByte(197), CByte(197), CByte(197))
        Grid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        Grid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBorderColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        Grid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        Grid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        Grid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBackColor = Color.FromArgb(CByte(114), CByte(114), CByte(114))
        Grid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBorderColor = Color.FromArgb(CByte(94), CByte(94), CByte(94))
        Grid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        Grid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBorderColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        Grid.ThemeStyle.VerticalScrollBarStyle.ScrollBarBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        Grid.ThemeStyle.VerticalScrollBarStyle.ThumbBorderColor = Color.FromArgb(CByte(171), CByte(171), CByte(171))
        Grid.ThemeStyle.VerticalScrollBarStyle.ThumbColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        Grid.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledBorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        Grid.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        Grid.ThemeStyle.VerticalScrollBarStyle.ThumbHoverBorderColor = Color.FromArgb(CByte(171), CByte(171), CByte(171))
        Grid.ThemeStyle.VerticalScrollBarStyle.ThumbHoverColor = Color.FromArgb(CByte(197), CByte(197), CByte(197))
        Grid.ThemeStyle.VerticalScrollBarStyle.ThumbPressedBorderColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        Grid.ThemeStyle.VerticalScrollBarStyle.ThumbPressedColor = Color.FromArgb(CByte(197), CByte(197), CByte(197))
        Grid.UseRightToLeftCompatibleTextBox = True
        ' 
        ' frmLicitaciones
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(959, 449)
        Controls.Add(Grid)
        Controls.Add(Panel1)
        Controls.Add(ToolStrip1)
        Name = "frmLicitaciones"
        Text = "Licitaciones"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(Grid, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ComboBoxPais As ComboBox
    Friend WithEvents ComboEstado As ComboBox
    Friend WithEvents ComboTipoProyecto As ComboBox
    Friend WithEvents ComboBoxComitente As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Grid As Syncfusion.Windows.Forms.Grid.GridControl
End Class
