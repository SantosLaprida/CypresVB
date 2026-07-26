Imports System.Drawing
Imports System.Windows.Forms
Imports Syncfusion.Licensing

Public Class frm_Main
    '=========================
    ' Controles principales
    '=========================

    Private pnlEncabezado As Panel
    Private pnlMenu As Panel
    Private pnlContenido As Panel
    Private pnlPie As Panel

    Private lblTitulo As Label
    Private lblFecha As Label
    Private lblHora As Label

    Private WithEvents tmrHora As New Timer

    Public Class frm_Main


        ' Declaraciones
        Private pnlEncabezado As Panel
        Private pnlMenu As Panel
        Private pnlContenido As Panel
        Private pnlPie As Panel

        Private lblTitulo As Label
        Private lblFecha As Label
        Private lblHora As Label

        Private WithEvents tmrHora As New Timer

        ' ... resto de los procedimientos ...

    End Class
    Private Sub frm_Main_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load
        SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JHaF5cWWdCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdlWXpeeHRURWdZUUVwXUVWYEo=")
        ConfigurarFormulario()

    End Sub
    Private Sub ConfigurarFormulario()

        Me.Text = "Cypres - Módulo Licitaciones"
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.White
        Me.StartPosition = FormStartPosition.CenterScreen

        CrearEncabezado()
        CrearMenuLateral()
        CrearContenido()
        CrearPie()

        IniciarReloj()

    End Sub
    Private Sub CrearEncabezado()

        pnlEncabezado = New Panel With {
            .Dock = DockStyle.Top,
            .Height = 70,
            .BackColor = Color.FromArgb(17, 42, 65)
        }

        lblTitulo = New Label With {
            .Text = "CYPRES - Módulo Licitaciones",
            .Font = New Font("Segoe UI", 18, FontStyle.Bold),
            .ForeColor = Color.White,
            .AutoSize = True,
            .Location = New Point(20, 18)
        }

        lblFecha = New Label With {
            .Font = New Font("Segoe UI", 10),
            .ForeColor = Color.WhiteSmoke,
            .AutoSize = True
        }

        lblHora = New Label With {
            .Font = New Font("Segoe UI", 12, FontStyle.Bold),
            .ForeColor = Color.White,
            .AutoSize = True
        }

        pnlEncabezado.Controls.Add(lblTitulo)
        pnlEncabezado.Controls.Add(lblFecha)
        pnlEncabezado.Controls.Add(lblHora)

        AddHandler pnlEncabezado.Resize,
            Sub()

                lblHora.Left = pnlEncabezado.ClientSize.Width - lblHora.Width - 20
                lblHora.Top = 10

                lblFecha.Left = pnlEncabezado.ClientSize.Width - lblFecha.Width - 20
                lblFecha.Top = 38

            End Sub

        Me.Controls.Add(pnlEncabezado)

    End Sub
    Private Sub CrearMenuLateral()

        pnlMenu = New Panel With {
            .Dock = DockStyle.Left,
            .Width = 220,
            .BackColor = Color.FromArgb(28, 55, 78)
        }

        Dim lblMenu As New Label With {
            .Text = "MENÚ PRINCIPAL",
            .ForeColor = Color.WhiteSmoke,
            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
            .AutoSize = True,
            .Location = New Point(20, 25)
        }

        pnlMenu.Controls.Add(lblMenu)

        Dim btnInicio As Button = CrearBotonMenu("Inicio", 70)
        Dim btnLicitaciones As Button = CrearBotonMenu("Licitaciones", 120)
        Dim btnComitentes As Button = CrearBotonMenu("Comitentes", 170)
        Dim btnEmpresas As Button = CrearBotonMenu("Empresas", 220)
        Dim btnRubros As Button = CrearBotonMenu("Rubros y subrubros", 270)
        Dim btnEstados As Button = CrearBotonMenu("Estados", 320)
        Dim btnSalir As Button = CrearBotonMenu("Salir", 390)

        AddHandler btnSalir.Click,
            Sub()
                Me.Close()
            End Sub

        pnlMenu.Controls.Add(btnInicio)
        pnlMenu.Controls.Add(btnLicitaciones)
        pnlMenu.Controls.Add(btnComitentes)
        pnlMenu.Controls.Add(btnEmpresas)
        pnlMenu.Controls.Add(btnRubros)
        pnlMenu.Controls.Add(btnEstados)
        pnlMenu.Controls.Add(btnSalir)

        Me.Controls.Add(pnlMenu)
        pnlMenu.BringToFront()

        ' AQUÍ
        AddHandler btnLicitaciones.Click, AddressOf AbrirLicitaciones
        AddHandler btnComitentes.Click, AddressOf AbrirComitentes
        AddHandler btnEmpresas.Click, AddressOf AbrirEmpresas
        AddHandler btnRubros.Click, AddressOf AbrirRubros
        pnlMenu.Controls.Add(btnLicitaciones)

    End Sub
    Private Sub AbrirComitentes(sender As Object, e As EventArgs)

        Dim f As New frmComitentesAdm
        f.ShowDialog(Me)

    End Sub
    Private Sub AbrirRubros(sender As Object, e As EventArgs)

        Dim f As New frmRubros
        f.ShowDialog(Me)

    End Sub

    Private Sub AbrirEmpresas(sender As Object, e As EventArgs)

        Dim f As New frmEmpresas
        f.ShowDialog(Me)

    End Sub
    Private Sub AbrirLicitaciones(sender As Object, e As EventArgs)

        Dim f As New frmLicitaciones
        f.ShowDialog(Me)

    End Sub
    Private Function CrearBotonMenu(
    texto As String,
    posicionY As Integer
) As Button

        Dim boton As New Button With {
            .Text = texto,
            .Size = New Size(190, 40),
            .Location = New Point(15, posicionY),
            .BackColor = Color.FromArgb(28, 55, 78),
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Segoe UI", 10),
            .TextAlign = ContentAlignment.MiddleLeft,
            .Padding = New Padding(15, 0, 0, 0),
            .Cursor = Cursors.Hand
        }

        boton.FlatAppearance.BorderSize = 0
        boton.FlatAppearance.MouseOverBackColor =
            Color.FromArgb(38, 75, 100)

        Return boton

    End Function
    Private Sub CrearContenido()

        pnlContenido = New Panel With {
            .Dock = DockStyle.Fill,
            .BackColor = Color.FromArgb(242, 245, 247),
            .AutoScroll = True,
            .Padding = New Padding(25)
        }

        Dim lblBienvenida As New Label With {
            .Text = "Panel de Licitaciones",
            .Font = New Font("Segoe UI", 20, FontStyle.Bold),
            .ForeColor = Color.FromArgb(30, 50, 70),
            .AutoSize = True,
            .Location = New Point(30, 25)
        }

        Dim lblDescripcion As New Label With {
            .Text = "Resumen general y accesos principales del módulo.",
            .Font = New Font("Segoe UI", 10),
            .ForeColor = Color.DimGray,
            .AutoSize = True,
            .Location = New Point(32, 65)
        }

        pnlContenido.Controls.Add(lblBienvenida)
        pnlContenido.Controls.Add(lblDescripcion)

        CrearTarjetas()
        CrearAccesosRapidos()

        Me.Controls.Add(pnlContenido)

        pnlContenido.BringToFront()
        pnlMenu.BringToFront()
        pnlEncabezado.BringToFront()

    End Sub
    Private Sub CrearTarjetas()

        Dim tarjetaActivas As Panel =
        CrearTarjeta(
            "LICITACIONES ACTIVAS",
            "12",
            "Procesos actualmente en curso",
            Color.FromArgb(32, 120, 180)
        )

        tarjetaActivas.Location = New Point(30, 110)

        Dim tarjetaProximas As Panel =
        CrearTarjeta(
            "PRÓXIMOS VENCIMIENTOS",
            "5",
            "Presentaciones durante los próximos días",
            Color.FromArgb(230, 145, 35)
        )

        tarjetaProximas.Location = New Point(270, 110)

        Dim tarjetaAdjudicadas As Panel =
        CrearTarjeta(
            "ADJUDICADAS",
            "8",
            "Licitaciones adjudicadas",
            Color.FromArgb(45, 145, 90)
        )

        tarjetaAdjudicadas.Location = New Point(510, 110)

        Dim tarjetaPendientes As Panel =
        CrearTarjeta(
            "PENDIENTES",
            "3",
            "Procesos pendientes de revisión",
            Color.FromArgb(175, 65, 65)
        )

        tarjetaPendientes.Location = New Point(750, 110)

        pnlContenido.Controls.Add(tarjetaActivas)
        pnlContenido.Controls.Add(tarjetaProximas)
        pnlContenido.Controls.Add(tarjetaAdjudicadas)
        pnlContenido.Controls.Add(tarjetaPendientes)

    End Sub
    Private Function CrearTarjeta(
    titulo As String,
    valor As String,
    descripcion As String,
    colorTarjeta As Color
) As Panel

        Dim tarjeta As New Panel With {
        .Size = New Size(220, 130),
        .BackColor = Color.White,
        .BorderStyle = BorderStyle.FixedSingle
    }

        Dim barra As New Panel With {
        .Dock = DockStyle.Left,
        .Width = 6,
        .BackColor = colorTarjeta
    }

        Dim lblTituloTarjeta As New Label With {
        .Text = titulo,
        .Font = New Font("Segoe UI", 9, FontStyle.Bold),
        .ForeColor = Color.FromArgb(70, 70, 70),
        .AutoSize = True,
        .Location = New Point(18, 15)
    }

        Dim lblValorTarjeta As New Label With {
        .Text = valor,
        .Font = New Font("Segoe UI", 24, FontStyle.Bold),
        .ForeColor = colorTarjeta,
        .AutoSize = True,
        .Location = New Point(18, 40)
    }

        Dim lblDescripcionTarjeta As New Label With {
        .Text = descripcion,
        .Font = New Font("Segoe UI", 8),
        .ForeColor = Color.Gray,
        .AutoSize = False,
        .Size = New Size(185, 35),
        .Location = New Point(18, 90)
    }

        tarjeta.Controls.Add(lblTituloTarjeta)
        tarjeta.Controls.Add(lblValorTarjeta)
        tarjeta.Controls.Add(lblDescripcionTarjeta)
        tarjeta.Controls.Add(barra)

        Return tarjeta

    End Function
    Private Sub CrearAccesosRapidos()

        Dim titulo As New Label With {
            .Text = "Accesos rápidos",
            .Font = New Font("Segoe UI", 12, FontStyle.Bold),
            .ForeColor = Color.FromArgb(30, 50, 70),
            .AutoSize = True,
            .Location = New Point(30, 280)
        }

        pnlContenido.Controls.Add(titulo)

        Dim btnNueva = CrearBotonAcceso("Nueva Licitación")
        btnNueva.Location = New Point(30, 320)

        Dim btnBuscar = CrearBotonAcceso("Buscar")
        btnBuscar.Location = New Point(240, 320)

        Dim btnEmpresas = CrearBotonAcceso("Empresas")
        btnEmpresas.Location = New Point(450, 320)

        Dim btnReportes = CrearBotonAcceso("Reportes")
        btnReportes.Location = New Point(660, 320)

        pnlContenido.Controls.Add(btnNueva)
        pnlContenido.Controls.Add(btnBuscar)
        pnlContenido.Controls.Add(btnEmpresas)
        pnlContenido.Controls.Add(btnReportes)

    End Sub
    Private Function CrearBotonAcceso(texto As String) As Button

        Dim btn As New Button With {
            .Text = texto,
            .Size = New Size(180, 70),
            .BackColor = Color.White,
            .ForeColor = Color.FromArgb(30, 50, 70),
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
            .Cursor = Cursors.Hand
        }

        btn.FlatAppearance.BorderColor = Color.Silver
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 245, 250)

        Return btn

    End Function
    Private Sub CrearPie()

        pnlPie = New Panel With {
            .Dock = DockStyle.Bottom,
            .Height = 38,
            .BackColor = Color.FromArgb(17, 42, 65)
        }

        Dim lblSistema As New Label With {
            .Text = "Cypres - Sistema de Gestión de Costos y Presupuestos",
            .ForeColor = Color.Gainsboro,
            .Font = New Font("Segoe UI", 9),
            .AutoSize = True,
            .Location = New Point(20, 10)
        }

        Dim lblVersion As New Label With {
            .Text = "Módulo Licitaciones | Versión 1.0.0",
            .ForeColor = Color.Gainsboro,
            .Font = New Font("Segoe UI", 9),
            .AutoSize = True
        }

        pnlPie.Controls.Add(lblSistema)
        pnlPie.Controls.Add(lblVersion)

        AddHandler pnlPie.Resize,
            Sub()

                lblVersion.Left = pnlPie.ClientSize.Width - lblVersion.Width - 20
                lblVersion.Top = 10

            End Sub

        Me.Controls.Add(pnlPie)

    End Sub
    Private Sub IniciarReloj()

        lblFecha.Text = Date.Today.ToLongDateString()

        lblHora.Text = DateTime.Now.ToString("HH:mm:ss")

        tmrHora.Interval = 1000

        tmrHora.Start()

    End Sub

    Private Sub tmrHora_Tick(sender As Object, e As EventArgs) Handles tmrHora.Tick

        lblHora.Text = DateTime.Now.ToString("HH:mm:ss")

    End Sub
End Class