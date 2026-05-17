Imports System.Data
Imports MySql.Data.MySqlClient


Public Class Comitente
    Public Const PUBLICO = 1
    Public Const PRIVADO = 2
    Public Property Id As Integer
    Public Property Sigla As String
    Public Property Nombre As String
    Public Property Direccion As String
    Public Property Localidad As String
    Public Property CPostal As String
    Public Property Pais As Integer
    Public Property telefono As String
    Public Property Email As String
    Public Property tipo As Integer
    Public Property cuit As String
    Public Property comentarios As String


    'AGREGAR CAMPOS DE LA TABLA COMITENTES


End Class


