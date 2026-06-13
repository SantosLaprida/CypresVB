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
                        c.Estado = Convert.ToInt32(dr("Estado"))
                        c.IdPais = Convert.ToInt32(dr("id_pais"))
                        'c.tipo = Convert.ToInt32(dr("tipo"))
                        lista.Add(c)
                    End While
                End Using
            End Using
        End Using
        Return lista
    End Function

    Public Function ObtenerLicitacionPorId(id As Integer) As Licitaciones
        Dim c As Licitaciones = Nothing
        Dim sql As String = "SELECT * FROM s_licitaciones WHERE id_lic = @id"
        Using cn As New MySqlConnection(_cadena)
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@id", id)
                cn.Open()
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        c = New Licitaciones
                        c.Id_lic = Convert.ToInt32(dr("id_lic"))
                        c.Id_Comitente = Convert.ToInt32(dr("id_comitente"))
                        c.Numero = dr("Numero").ToString()
                        c.Denominacion = dr("denominacion").ToString()
                        c.FechaPresentacion = dr("fecha_presentacion").ToString()
                        c.FechaApertura = dr("fecha_apertura").ToString()
                        c.HoraApertura = dr("hora_apertura").ToString()
                        c.HoraPresentacion = dr("hora_presentacion").ToString()
                        c.Pres_Oficial = Convert.ToInt64(dr("pres_oficial"))
                        c.Plazo = Convert.ToInt32(dr("Plazo"))
                        c.Pliego = dr("pliego").ToString()
                        c.Estado = Convert.ToInt32(dr("Estado"))
                        c.IdPais = Convert.ToInt32(dr("id_pais"))
                        c.IdTipoProyecto = Convert.ToInt32(dr("Obra_tipo"))
                        c.LugarPresentacion = dr("lugar_presentacion").ToString()
                        c.LugarApertura = dr("lugar_apertura").ToString()
                    End If
                End Using
            End Using
        End Using
        Return c
    End Function


    Private Function ObtenerSiguienteId() As Integer
        Dim sql As String = "SELECT COALESCE(MAX(id_lic), 0) + 1 FROM s_licitaciones"
        Using cn As New MySqlConnection(_cadena)
            Using cmd As New MySqlCommand(sql, cn)
                cn.Open()
                Return Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
    End Function


    Private Function N(value As Object) As Object
        Return If(value Is Nothing, DBNull.Value, value)
    End Function

    Public Function GuardarLicitacion(c As Licitaciones, o As List(Of Integer)) As Integer
        Dim sql As String
        If c.Id_lic = 0 Then
            c.Id_lic = ObtenerSiguienteId()
            sql = "INSERT INTO s_licitaciones (id_lic, id_comitente, Numero, denominacion, obra_tipo, id_pais, Estado, pres_oficial, pliego, plazo, portal_web, lugar_presentacion, fecha_presentacion, lugar_apertura, fecha_apertura, hora_apertura, hora_presentacion, lugar_consulta, fecha_consulta, responsable, fecha_moddificacion) " &
              "VALUES (@id_lic, @id_comitente, @numero, @denominacion, @obra_tipo, @id_pais, @estado, @pres_oficial, @pliego, @plazo, @portal_web, @lugar_presentacion, @fecha_presentacion, @lugar_apertura, @fecha_apertura, @hora_apertura, @hora_presentacion, @lugar_consulta, @fecha_consulta, @responsable, @fecha_moddificacion)"
        Else
            sql = "UPDATE s_licitaciones SET id_comitente=@id_comitente, Numero=@numero, denominacion=@denominacion, obra_tipo=@obra_tipo, id_pais=@id_pais, Estado=@estado, pres_oficial=@pres_oficial, pliego=@pliego, plazo=@plazo, portal_web=@portal_web, lugar_presentacion=@lugar_presentacion, fecha_presentacion=@fecha_presentacion, lugar_apertura=@lugar_apertura, fecha_apertura=@fecha_apertura, hora_apertura=@hora_apertura, hora_presentacion=@hora_presentacion, lugar_consulta=@lugar_consulta, fecha_consulta=@fecha_consulta, responsable=@responsable, fecha_moddificacion=@fecha_moddificacion " &
              "WHERE id_lic=@id_lic"
        End If

        Using cn As New MySqlConnection(_cadena)
            cn.Open()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@id_lic", c.Id_lic)
                cmd.Parameters.AddWithValue("@id_comitente", c.Id_Comitente)
                cmd.Parameters.AddWithValue("@numero", N(c.Numero))
                cmd.Parameters.AddWithValue("@denominacion", N(c.Denominacion))
                cmd.Parameters.AddWithValue("@obra_tipo", c.IdTipoProyecto)
                cmd.Parameters.AddWithValue("@id_pais", c.IdPais)
                cmd.Parameters.AddWithValue("@estado", c.Estado)
                cmd.Parameters.AddWithValue("@pres_oficial", c.Pres_Oficial)
                cmd.Parameters.AddWithValue("@pliego", N(c.Pliego))
                cmd.Parameters.AddWithValue("@plazo", N(c.Plazo))
                cmd.Parameters.AddWithValue("@portal_web", N(c.PortalWeb))
                cmd.Parameters.AddWithValue("@lugar_presentacion", N(c.LugarPresentacion))
                cmd.Parameters.AddWithValue("@fecha_presentacion", N(c.FechaPresentacion))
                cmd.Parameters.AddWithValue("@lugar_apertura", N(c.LugarApertura))
                cmd.Parameters.AddWithValue("@fecha_apertura", N(c.FechaApertura))
                cmd.Parameters.AddWithValue("@hora_apertura", N(c.HoraApertura))
                cmd.Parameters.AddWithValue("@hora_presentacion", N(c.HoraPresentacion))
                cmd.Parameters.AddWithValue("@lugar_consulta", N(c.LugarConsulta))
                cmd.Parameters.AddWithValue("@fecha_consulta", N(c.FechaConsulta))
                cmd.Parameters.AddWithValue("@responsable", c.Responsable)
                cmd.Parameters.AddWithValue("@fecha_moddificacion", N(c.FechaModificacion))
                cmd.ExecuteNonQuery()
            End Using

            ' Delete existing oferentes for this licitacion
            Using cmd As New MySqlCommand("DELETE FROM s_lic_empresa WHERE id_lic = @id_lic", cn)
                cmd.Parameters.AddWithValue("@id_lic", c.Id_lic)
                cmd.ExecuteNonQuery()
            End Using

            ' Insert new oferentes
            If o IsNot Nothing AndAlso o.Count > 0 Then
                For Each idEmpresa As Integer In o
                    Using cmd As New MySqlCommand("INSERT INTO s_lic_empresa (id_lic, id_empresa) VALUES (@id_lic, @id_empresa)", cn)
                        cmd.Parameters.AddWithValue("@id_lic", c.Id_lic)
                        cmd.Parameters.AddWithValue("@id_empresa", idEmpresa)
                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End If
        End Using

        Return c.Id_lic
    End Function

End Class


