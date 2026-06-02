Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Licitaciones
    Public Const PUBLICO = 1
    Public Const PRIVADO = 2
    Public Property Id_lic As Integer
    Public Property Id_Comitente As Integer
    Public Property Numero As String
    Public Property Denominacion As String
    Public Property esUte As Integer

    'Obra_tipo en la base de datos
    Public Property IdTipoProyecto As Integer
    Public Property idMoneda As Integer
    Public Property IdPais As Integer
    Public Property Estado As Integer
    Public Property Pres_Oficial As Double
    Public Property Pliego As String
    Public Property ConIva As Double
    Public Property Plazo As String
    Public Property PortalWeb As String
    Public Property LugarPresentacion As String
    Public Property FechaPresentacion As String
    Public Property LugarApertura As String
    Public Property FechaApertura As String
    Public Property HoraApertura As String
    Public Property HoraPresentacion As String
    Public Property LugarConsulta As String
    Public Property FechaConsulta As Date
    Public Property HoraConsulta As TimeOnly
    Public Property Responsable As Integer
    Public Property FechaModificacion As String


End Class