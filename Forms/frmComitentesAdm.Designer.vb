<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmComitentesAdm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComitentesAdm))
        ToolStrip1 = New ToolStrip()
        NuevoToolStripButton = New ToolStripButton()
        AbrirToolStripButton = New ToolStripButton()
        GuardarToolStripButton = New ToolStripButton()
        ImprimirToolStripButton = New ToolStripButton()
        toolStripSeparator = New ToolStripSeparator()
        toolStripSeparator1 = New ToolStripSeparator()
        Panel1 = New Panel()
        GridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
        btnColumnas = New Button()
        Label2 = New Label()
        ComboBoxPais = New ComboBox()
        Label1 = New Label()
        txtBuscar = New TextBox()
        SfToolTip1 = New Syncfusion.Windows.Forms.SfToolTip(components)
        ToolStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(GridControl1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = SystemColors.ActiveCaption
        ToolStrip1.ImageScalingSize = New Size(24, 24)
        ToolStrip1.Items.AddRange(New ToolStripItem() {NuevoToolStripButton, AbrirToolStripButton, GuardarToolStripButton, ImprimirToolStripButton, toolStripSeparator, toolStripSeparator1})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Padding = New Padding(0, 0, 3, 0)
        ToolStrip1.Size = New Size(1370, 33)
        ToolStrip1.TabIndex = 0
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
        toolStripSeparator.Size = New Size(6, 33)
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 33)
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(GridControl1)
        Panel1.Controls.Add(btnColumnas)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(ComboBoxPais)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtBuscar)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 33)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1370, 81)
        Panel1.TabIndex = 4
        ' 
        ' GridControl1
        ' 
        GridControl1.Location = New Point(0, 99)
        GridControl1.Name = "GridControl1"
        GridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode
        GridControl1.Size = New Size(988, 326)
        GridControl1.SmartSizeBox = False
        GridControl1.TabIndex = 5
        GridControl1.Text = "GridControl1"
        GridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        GridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBorderColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        GridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        GridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        GridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBackColor = Color.FromArgb(CByte(114), CByte(114), CByte(114))
        GridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBorderColor = Color.FromArgb(CByte(94), CByte(94), CByte(94))
        GridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        GridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBorderColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        GridControl1.ThemeStyle.HorizontalScrollBarStyle.ScrollBarBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        GridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbBorderColor = Color.FromArgb(CByte(171), CByte(171), CByte(171))
        GridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        GridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledBorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        GridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        GridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverBorderColor = Color.FromArgb(CByte(171), CByte(171), CByte(171))
        GridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverColor = Color.FromArgb(CByte(197), CByte(197), CByte(197))
        GridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedBorderColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        GridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedColor = Color.FromArgb(CByte(197), CByte(197), CByte(197))
        GridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        GridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBorderColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        GridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        GridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        GridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBackColor = Color.FromArgb(CByte(114), CByte(114), CByte(114))
        GridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBorderColor = Color.FromArgb(CByte(94), CByte(94), CByte(94))
        GridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        GridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBorderColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        GridControl1.ThemeStyle.VerticalScrollBarStyle.ScrollBarBackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        GridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbBorderColor = Color.FromArgb(CByte(171), CByte(171), CByte(171))
        GridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        GridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledBorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        GridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        GridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbHoverBorderColor = Color.FromArgb(CByte(171), CByte(171), CByte(171))
        GridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbHoverColor = Color.FromArgb(CByte(197), CByte(197), CByte(197))
        GridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbPressedBorderColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        GridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbPressedColor = Color.FromArgb(CByte(197), CByte(197), CByte(197))
        GridControl1.UseRightToLeftCompatibleTextBox = True
        ' 
        ' btnColumnas
        ' 
        btnColumnas.FlatAppearance.BorderSize = 0
        btnColumnas.FlatStyle = FlatStyle.Flat
        btnColumnas.Image = CType(resources.GetObject("btnColumnas.Image"), Image)
        btnColumnas.Location = New Point(873, 20)
        btnColumnas.Name = "btnColumnas"
        btnColumnas.Size = New Size(32, 28)
        btnColumnas.TabIndex = 5
        btnColumnas.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 22)
        Label2.TabIndex = 7
        Label2.Text = "Pais:"
        ' 
        ' ComboBoxPais
        ' 
        ComboBoxPais.FormattingEnabled = True
        ComboBoxPais.Location = New Point(104, 23)
        ComboBoxPais.Name = "ComboBoxPais"
        ComboBoxPais.Size = New Size(137, 30)
        ComboBoxPais.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(282, 26)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 22)
        Label1.TabIndex = 5
        Label1.Text = "Comitente:"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(417, 26)
        txtBuscar.Margin = New Padding(4, 5, 4, 5)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(341, 29)
        txtBuscar.TabIndex = 4
        ' 
        ' frmComitentesAdm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 22.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 658)
        Controls.Add(Panel1)
        Controls.Add(ToolStrip1)
        Font = New Font("Consolas", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 5, 4, 5)
        Name = "frmComitentesAdm"
        Text = "Form2"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(GridControl1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NuevoToolStripButton As ToolStripButton
    Friend WithEvents AbrirToolStripButton As ToolStripButton
    Friend WithEvents GuardarToolStripButton As ToolStripButton
    Friend WithEvents ImprimirToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxPais As ComboBox
    Friend WithEvents btnColumnas As Button
    Friend WithEvents SfToolTip1 As Syncfusion.Windows.Forms.SfToolTip
    Friend WithEvents GridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
End Class
