Imports System.Data
Imports MySql.Data.MySqlClient

Public Class LicitacionesRepositorio

    'LA CADENA SE OBTIENE DEL MÓDULO DE CONEXIÓN A CORREGIR!
    Private ReadOnly _cadena As String = m_Conexion.Cadena

    Public Function ObtenerLicitaciones(id As Integer) As List(Of Licitaciones)
        Dim lista As New List(Of Licitaciones)
        Dim sql As String = "SELECT * FROM s_licitaciones"
        If id > 0 Then
            sql = sql & " WHERE id_comitente = " & id
        End If
        sql = sql & " ORDER BY fecha_presentacion"

        Using cn As New MySqlConnection(_cadena)
            Using cmd As New MySqlCommand(sql, cn)
                cn.Open()
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim c As New Licitaciones
                        c.Id_lic = Convert.ToInt32(dr("id_lic"))
                        c.Id_Comitente = Convert.ToInt32(dr("id_comitente"))
                        c.Numero = dr("Numero").ToString()
                        c.Denominacion = dr("denominacion").ToString()
                        c.FechaPresentacion = dr("fecha_presentacion").ToString()
                        c.Pres_Oficial = Convert.ToInt64(dr("pres_oficial"))
                        c.Plazo = Convert.ToInt32(dr("Plazo"))
                        c.Pliego = dr("pliego").ToString()
                        'c.telefono = dr("telefono").ToString()
                        'c.Pais = Convert.ToInt32(dr("id_pais"))
                        'c.tipo = Convert.ToInt32(dr("tipo"))
                        lista.Add(c)
                    End While
                End Using
            End Using
        End Using
        Return lista
    End Function
End Class


