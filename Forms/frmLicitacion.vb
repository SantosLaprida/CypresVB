Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Public Class frmLicitacion
    Public comitenteRepositiorio As New ComitenteRepositorio()
    Public paisRepositorio As New PaisRepositorio()
    Public proyectotiporepositorio As New ProyectoTipoRepositorio
    Private Sub frmLicitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PaisesLlenarCombo(ComboBoxPais, True)
        ComitentesLlenarCombo(ComboBoxComitente, True)
        ProyectoTipoLlenarLlenarCombo(ComboTipoProyecto, True)
    End Sub
End Class