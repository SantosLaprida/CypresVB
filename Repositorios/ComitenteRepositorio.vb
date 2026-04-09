Imports System.Data
Imports MySql.Data.MySqlClient

Public Class ComitenteRepositorio

    'LA CADENA SE OBTIENE DEL MÓDULO DE CONEXIÓN A CORREGIR!
    Private ReadOnly _cadena As String = m_Conexion.Cadena

    Public Function ObtenerComitentes() As DataTable

        Dim dt As New DataTable

        Using cn As New MySqlConnection(Cadena)
            Using cmd As New MySqlCommand("SELECT id_comitente, sigla, comitente, direccion FROM s_comitentes ORDER BY comitente", cn)

                cn.Open()

                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using

            End Using
        End Using

        Return dt
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
                            "INSERT INTO s_comitentes (id_comitente, sigla, comitente, direccion, localidad, c_postal) " &
                            "VALUES (@id, @sigla, @comitente, @direccion, @localidad, @c_postal)"

                        Using cmd As New MySqlCommand(sqlInsert, cn, tran)
                            cmd.Parameters.AddWithValue("@id", c.Id)
                            cmd.Parameters.AddWithValue("@sigla", c.Sigla)
                            cmd.Parameters.AddWithValue("@comitente", c.Nombre)
                            cmd.Parameters.AddWithValue("@direccion", c.Direccion)
                            cmd.Parameters.AddWithValue("@localidad", c.Localidad)
                            cmd.Parameters.AddWithValue("@c_postal", c.CPostal)
                            cmd.ExecuteNonQuery()
                        End Using

                    Else

                        Dim sqlUpdate As String =
                            "UPDATE s_comitentes SET " &
                            "sigla = @sigla, " &
                            "comitente = @comitente, " &
                            "direccion = @direccion, " &
                            "localidad = @localidad, " &
                            "c_postal = @c_postal " &
                            "WHERE id_comitente = @id"

                        Using cmd As New MySqlCommand(sqlUpdate, cn, tran)
                            cmd.Parameters.AddWithValue("@id", c.Id)
                            cmd.Parameters.AddWithValue("@sigla", c.Sigla)
                            cmd.Parameters.AddWithValue("@comitente", c.Nombre)
                            cmd.Parameters.AddWithValue("@direccion", c.Direccion)
                            cmd.Parameters.AddWithValue("@localidad", c.Localidad)
                            cmd.Parameters.AddWithValue("@c_postal", c.CPostal)
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
