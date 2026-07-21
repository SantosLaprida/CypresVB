<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Main
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
        SuspendLayout()
        ' 
        ' frm_Main
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 449)
        ForeColor = SystemColors.ButtonHighlight
        Margin = New Padding(4, 5, 4, 5)
        Name = "frm_Main"
        Text = "Main"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnCcomitentes As Button
    Friend WithEvents btnPaises As Button
    Friend WithEvents btnProveedores As Button
    Friend WithEvents btnRubros As Button
    Friend WithEvents btnProyectoTipo As Button
    Friend WithEvents btnLicitaciones As Button
    Friend WithEvents btnEmpresas As Button
    Friend WithEvents btnProyectos As Button


End Class
