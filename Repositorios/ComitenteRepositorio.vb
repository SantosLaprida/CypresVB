Imports System.Data
Imports MySql.Data.MySqlClient

Public Class ComitenteRepositorio

    'LA CADENA SE OBTIENE DEL MÓDULO DE CONEXIÓN A CORREGIR!
    Private ReadOnly _cadena As String = m_Conexion.Cadena

    Public Function ObtenerComitentes(id As Integer) As List(Of Comitente)
        Dim lista As New List(Of Comitente)
        Dim sql As String = "SELECT * FROM s_comitentes"
        If id > 0 Then
            sql = sql & " WHERE id_pais = " & id
        End If
        sql = sql & " ORDER BY comitente"

        Using cn As New MySqlConnection(_cadena)
            Using cmd As New MySqlCommand(sql, cn)
                cn.Open()
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim c As New Comitente
                        c.Id = Convert.ToInt32(dr("id_comitente"))
                        c.Sigla = dr("sigla").ToString()
                        c.Nombre = dr("comitente").ToString()
                        c.Direccion = dr("direccion").ToString()
                        c.Localidad = dr("localidad").ToString()
                        c.CPostal = dr("c_postal").ToString()
                        c.telefono = dr("telefono").ToString()
                        c.Pais = Convert.ToInt32(dr("id_pais"))
                        c.tipo = Convert.ToInt32(dr("tipo"))
                        lista.Add(c)
                    End While
                End Using
            End Using
        End Using
        Return lista
    End Function



    Public Function ObtenerComitentePorId(id As Integer) As Comitente
        Dim c As Comitente = Nothing
        Dim sql As String = "SELECT * FROM s_comitentes WHERE id_comitente = @id"

        Using cn As New MySqlConnection(Cadena)
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@id", id)
                cn.Open()
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        c = New Comitente
                        c.Id = Convert.ToInt32(dr("id_comitente"))
                        c.Sigla = dr("sigla").ToString()
                        c.Nombre = dr("comitente").ToString()
                        c.Direccion = dr("direccion").ToString()
                        c.Localidad = dr("localidad").ToString()
                        c.CPostal = dr("c_postal").ToString()
                        c.telefono = dr("telefono").ToString()
                        c.Pais = Convert.ToInt32(dr("id_pais"))
                        c.Email = dr("email").ToString()
                        c.tipo = Convert.ToInt32(dr("tipo"))
                    End If
                End Using
            End Using
        End Using
        Return c
    End Function

    Public Sub GuardarComitente(c As Comitente)

        Using cn As New MySqlConnection(Cadena)
            cn.Open()

            Using tran = cn.BeginTransaction()

                Try

                    If c.Id = 0 Then

                        Dim sqlId As String = "SELECT IFNULL(MAX(id_comitente),0) + 1 FROM s_comitentes FOR UPDATE"

                        Using cmdId As New MySqlCommand(sqlId, cn, tran)
                            c.Id = Convert.ToInt32(cmdId.ExecuteScalar())
                        End Using

                        Dim sqlInsert As String =
                            "INSERT INTO s_comitentes 
                            (id_comitente, sigla, comitente, direccion, localidad, c_postal, telefono, id_pais)
                            VALUES 
                            (@id, @sigla, @comitente, @direccion, @localidad, @c_postal, @telefono, @pais)"

                        Using cmd As New MySqlCommand(sqlInsert, cn, tran)
                            cmd.Parameters.AddWithValue("@id", c.Id)
                            cmd.Parameters.AddWithValue("@sigla", c.Sigla)
                            cmd.Parameters.AddWithValue("@comitente", c.Nombre)
                            cmd.Parameters.AddWithValue("@direccion", c.Direccion)
                            cmd.Parameters.AddWithValue("@localidad", c.Localidad)
                            cmd.Parameters.AddWithValue("@c_postal", c.CPostal)
                            cmd.Parameters.AddWithValue("@telefono", c.telefono)
                            cmd.Parameters.AddWithValue("@pais", c.Pais)
                            cmd.ExecuteNonQuery()
                        End Using

                    Else

                        Dim sqlUpdate As String =
                            "UPDATE s_comitentes SET " &
                            "sigla = @sigla, " &
                            "comitente = @comitente, " &
                            "direccion = @direccion, " &
                            "localidad = @localidad, " &
                            "c_postal = @c_postal, " &
                            "telefono = @telefono, " &
                            "id_pais = @pais " &
                            "WHERE id_comitente = @id"

                        Using cmd As New MySqlCommand(sqlUpdate, cn, tran)
                            cmd.Parameters.AddWithValue("@id", c.Id)
                            cmd.Parameters.AddWithValue("@sigla", c.Sigla)
                            cmd.Parameters.AddWithValue("@comitente", c.Nombre)
                            cmd.Parameters.AddWithValue("@direccion", c.Direccion)
                            cmd.Parameters.AddWithValue("@localidad", c.Localidad)
                            cmd.Parameters.AddWithValue("@c_postal", c.CPostal)
                            cmd.Parameters.AddWithValue("@telefono", c.telefono)
                            cmd.Parameters.AddWithValue("@email", c.Email)
                            cmd.Parameters.AddWithValue("@pais", c.Pais)
                            cmd.ExecuteNonQuery()
                        End Using

                    End If

                    tran.Commit()

                Catch
                    tran.Rollback()
                    Throw
                End Try

            End Using

        End Using

    End Sub

End Class
