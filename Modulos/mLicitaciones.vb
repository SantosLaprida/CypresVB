Imports System.Data
Imports MySql.Data.MySqlClient
Public Module mLicitaciones
    'CONSTANTES
    Public Const ESTADO_AGENDA = 1
    Public Const ESTADO_CALIFICACION = 2
    Public Const ESTADO_PROCESO = 3
    Public Const ESTADO_SUSPENDIDO = 4
    Public Const ESTADO_DESESTIMADA = 5
    Public Const ESTADO_PRESENTADA = 6
    Public Const ESTADO_ANTECEDENTE = 7
    Public Const U_MEDIDA = 1
    Public Const A_ALZADO = 2
    'VARIABLES

    Public Function ObtenerEstados() As List(Of LicEstado)

        Return New List(Of LicEstado) From {
            New LicEstado With {.Id = 0, .Descripcion = "..."},
            New LicEstado With {.Id = ESTADO_AGENDA, .Descripcion = "EN AGENDA"},
            New LicEstado With {.Id = ESTADO_CALIFICACION, .Descripcion = "EN CALIFICACION"},
            New LicEstado With {.Id = ESTADO_PROCESO, .Descripcion = "EN PROCESO"},
            New LicEstado With {.Id = ESTADO_SUSPENDIDO, .Descripcion = "SUSPENDIDA"},
            New LicEstado With {.Id = ESTADO_DESESTIMADA, .Descripcion = "DESESTIMADA"},
            New LicEstado With {.Id = ESTADO_PRESENTADA, .Descripcion = "PRESENTADA"},
            New LicEstado With {.Id = ESTADO_ANTECEDENTE, .Descripcion = "ANTECEDENTE"}
        }

    End Function

    Public Sub LicEstadosLlenarLlenarCombo(iCombo As Object, IncluirTodos As Boolean)
        iCombo.DataSource = ObtenerEstados()
        iCombo.DisplayMember = "Descripcion"
        iCombo.ValueMember = "Id"
        iCombo.SelectedIndex = 0
    End Sub
    Public Function ObtenerDescripcionEstado(idEstado As Integer) As String

        Select Case idEstado

            Case ESTADO_AGENDA
                Return "EN AGENDA"

            Case ESTADO_CALIFICACION
                Return "EN CALIFICACION"

            Case ESTADO_PROCESO
                Return "EN PROCESO"

            Case ESTADO_SUSPENDIDO
                Return "SUSPENDIDA"

            Case ESTADO_DESESTIMADA
                Return "DESESTIMADA"

            Case ESTADO_PRESENTADA
                Return "PRESENTADA"

            Case ESTADO_ANTECEDENTE
                Return "ANTECEDENTE"

            Case Else
                Return ""

        End Select

    End Function
End Module
