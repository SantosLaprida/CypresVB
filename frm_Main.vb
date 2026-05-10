Imports System.Drawing.Drawing2D
Public Class frm_Main
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RedondearBoton(btnCcomitentes, 5)
        RedondearBoton(btnPaises, 5)
        RedondearBoton(btnProveedores, 5)
    End Sub
    Private Sub btnPaises_Click(sender As Object, e As EventArgs) Handles btnPaises.Click
        frmPaises.ShowDialog()
    End Sub
    Private Sub btnComitentes_Click(sender As Object, e As EventArgs) Handles btnCcomitentes.Click
        frmComitentesAdm.Show()
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        frmProveedoresAdmin.Show()
    End Sub
    Private Sub RedondearBoton(btn As Button, radio As Integer)

        Dim path As New GraphicsPath()

        path.StartFigure()
        path.AddArc(0, 0, radio, radio, 180, 90)
        path.AddArc(btn.Width - radio, 0, radio, radio, 270, 90)
        path.AddArc(btn.Width - radio, btn.Height - radio, radio, radio, 0, 90)
        path.AddArc(0, btn.Height - radio, radio, radio, 90, 90)
        path.CloseFigure()

        btn.Region = New Region(path)

    End Sub

    Private Sub btnRubros_Click(sender As Object, e As EventArgs) Handles btnRubros.Click
        frmRubros.ShowDialog()
    End Sub

    Private Sub btnProyectoTipo_Click(sender As Object, e As EventArgs) Handles btnProyectoTipo.Click
        frmProyectoTipo.ShowDialog()
    End Sub
End Class