Imports System.Data
Imports MySql.Data.MySqlClient

Public Class SubrubroRepositorio
    Private ReadOnly _cadena As String = m_Conexion.Cadena
    Public Function ObtenerSubrubros(id As Integer) As DataTable
        Dim dt As New DataTable

        Using cn As New MySqlConnection(_cadena)
            Using cmd As New MySqlCommand("SELECT id_subrubro, descripcion FROM s_subrubros WHERE id_rubro = @id ORDER BY descripcion", cn)
                cmd.Parameters.AddWithValue("@id", id)
                cn.Open()
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function

    Public Function ObtenerSubrubroPorId(id As Integer) As Rubros

        Dim c As Rubros = Nothing

        Dim sql As String = "SELECT * FROM s_subrubros WHERE id_subrubro = @id"

        Using cn As New MySqlConnection(Cadena)
            Using cmd As New MySqlCommand(sql, cn)

                cmd.Parameters.AddWithValue("@id", id)
                cn.Open()

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        c = New Rubros
                        c.Id = Convert.ToInt32(dr("id_rubro"))
                        c.descripcion = dr("descripcion").ToString()
                    End If
                End Using

            End Using
        End Using

        Return c

    End Function
    Public Function ExisteSubrubro(descripcion As String, Optional idExcluir As Integer = 0) As Boolean

        Dim sql As String =
        "SELECT COUNT(*) FROM s_subrubros " &
        "WHERE descripcion = @descripcion " &
        "AND id_subrubro <> @id"

        Using cn As New MySqlConnection(Cadena)
            Using cmd As New MySqlCommand(sql, cn)

                cmd.Parameters.AddWithValue("@descripcion", descripcion.Trim())
                cmd.Parameters.AddWithValue("@id", idExcluir)

                cn.Open()

                Dim cantidad As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                Return cantidad > 0

            End Using
        End Using

    End Function
    Public Sub GuardarSubrubro(c As Subrubros)

        Using cn As New MySqlConnection(Cadena)
            cn.Open()

            Using tran = cn.BeginTransaction()

                Try

                    If c.id_subrubro = 0 Then

                        Dim sqlId As String = "SELECT IFNULL(MAX(id_subrubro),0) + 1 FROM s_subrubros FOR UPDATE"

                        Using cmdId As New MySqlCommand(sqlId, cn, tran)
                            c.id_subrubro = Convert.ToInt32(cmdId.ExecuteScalar())
                        End Using

                        Dim sqlInsert As String =
                            "INSERT INTO s_subrubros 
                            (id_subrubro, id_rubro, descripcion)
                            VALUES 
                            (@id_subrubro, @id_rubro, @descripcion)"

                        Using cmd As New MySqlCommand(sqlInsert, cn, tran)
                            cmd.Parameters.AddWithValue("@id_subrubro", c.id_subrubro)
                            cmd.Parameters.AddWithValue("@id_rubro", c.id_rubro)
                            cmd.Parameters.AddWithValue("@Descripcion", c.descripcion)
                            cmd.ExecuteNonQuery()
                        End Using

                    Else

                        Dim sqlUpdate As String =
                            "UPDATE s_subrubros SET " &
                            "id_rubro = @id_rubro, " &
                            "Descripcion = @Descripcion " &
                            "WHERE id_subrubro = @id_subrubro"

                        Using cmd As New MySqlCommand(sqlUpdate, cn, tran)
                            cmd.Parameters.AddWithValue("@id_subrubro", c.id_subrubro)
                            cmd.Parameters.AddWithValue("@id_rubro", c.id_rubro)
                            cmd.Parameters.AddWithValue("@Descripcion", c.descripcion)
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
