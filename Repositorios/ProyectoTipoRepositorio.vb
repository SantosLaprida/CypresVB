Imports System.Data
Imports MySql.Data.MySqlClient

Public Class ProyectoTipoRepositorio
    Private ReadOnly _cadena As String = m_Conexion.Cadena

    Public Function ObtenerProyectoTipo() As DataTable
        Dim dt As New DataTable

        Using cn As New MySqlConnection(_cadena)
            Using cmd As New MySqlCommand("SELECT id_tipo, descripcion FROM s_proyecto_tipo ORDER BY descripcion", cn)
                cn.Open()
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function
    Public Function ObtenerProyectoTipoPorId(id As Integer) As modProyectoTipo
        Dim c As modProyectoTipo = Nothing
        Dim sql As String = "SELECT * FROM s_proyecto_tipo WHERE id_tipo = @id"

        Using cn As New MySqlConnection(Cadena)
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@id", id)
                cn.Open()
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        c = New modProyectoTipo
                        c.Id_tipo = Convert.ToInt32(dr("id_tipo"))
                        c.Descripcion = dr("descripcion").ToString()
                    End If
                End Using
            End Using
        End Using
        Return c
    End Function
    Public Function ExisteProyectoTipo(descripcion As String, Optional idExcluir As Integer = 0) As Boolean

        Dim sql As String =
            "SELECT COUNT(*) FROM s_proyecto_tipo " &
            "WHERE descripcion = @descripcion " &
            "AND id_tipo <> @id"

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
    Public Sub GuardarProyectoTipo(c As modProyectoTipo)

        Using cn As New MySqlConnection(Cadena)
            cn.Open()

            Using tran = cn.BeginTransaction()

                Try

                    If c.Id_tipo = 0 Then

                        Dim sqlId As String = "SELECT IFNULL(MAX(id_tipo),0) + 1 FROM s_proyecto_tipo FOR UPDATE"

                        Using cmdId As New MySqlCommand(sqlId, cn, tran)
                            c.Id_tipo = Convert.ToInt32(cmdId.ExecuteScalar())
                        End Using

                        Dim sqlInsert As String =
                            "INSERT INTO s_proyecto_tipo 
                            (id_tipo, descripcion)
                            VALUES 
                            (@id, @descripcion)"

                        Using cmd As New MySqlCommand(sqlInsert, cn, tran)
                            cmd.Parameters.AddWithValue("@id", c.Id_tipo)
                            cmd.Parameters.AddWithValue("@Descripcion", c.Descripcion)
                            cmd.ExecuteNonQuery()
                        End Using

                    Else

                        Dim sqlUpdate As String =
                            "UPDATE s_proyecto_tipo SET " &
                            "Descripcion = @Descripcion " &
                            "WHERE id_tipo = @id"

                        Using cmd As New MySqlCommand(sqlUpdate, cn, tran)
                            cmd.Parameters.AddWithValue("@id", c.Id_tipo)
                            cmd.Parameters.AddWithValue("@Descripcion", c.Descripcion)
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
