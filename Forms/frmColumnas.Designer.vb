<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColumnas
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
        checkBoxColumnas = New CheckedListBox()
        labelSeparador = New Label()
        checkBoxMostrarTodo = New CheckBox()
        SuspendLayout()
        ' 
        ' checkBoxColumnas
        ' 
        checkBoxColumnas.BorderStyle = BorderStyle.None
        checkBoxColumnas.CheckOnClick = True
        checkBoxColumnas.FormattingEnabled = True
        checkBoxColumnas.Location = New Point(0, -1)
        checkBoxColumnas.Name = "checkBoxColumnas"
        checkBoxColumnas.Size = New Size(242, 280)
        checkBoxColumnas.TabIndex = 0
        ' 
        ' labelSeparador
        ' 
        labelSeparador.BorderStyle = BorderStyle.Fixed3D
        labelSeparador.Location = New Point(0, 205)
        labelSeparador.Name = "labelSeparador"
        labelSeparador.Size = New Size(241, 3)
        labelSeparador.TabIndex = 1
        ' 
        ' checkBoxMostrarTodo
        ' 
        checkBoxMostrarTodo.AutoSize = True
        checkBoxMostrarTodo.BackColor = Color.White
        checkBoxMostrarTodo.Location = New Point(12, 222)
        checkBoxMostrarTodo.Name = "checkBoxMostrarTodo"
        checkBoxMostrarTodo.Size = New Size(124, 29)
        checkBoxMostrarTodo.TabIndex = 2
        checkBoxMostrarTodo.Text = "CheckBox1"
        checkBoxMostrarTodo.UseVisualStyleBackColor = False
        ' 
        ' frmColumnas
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(237, 274)
        Controls.Add(checkBoxMostrarTodo)
        Controls.Add(labelSeparador)
        Controls.Add(checkBoxColumnas)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmColumnas"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.Manual
        Text = "frmColumnas"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents checkBoxColumnas As CheckedListBox
    Friend WithEvents labelSeparador As Label
    Friend WithEvents checkBoxMostrarTodo As CheckBox
End Class
