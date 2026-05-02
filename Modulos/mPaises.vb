Imports System.Data
Imports MySql.Data.MySqlClient
Public Module mPaises
    Public Const PUBLICO = 1
    Public Const PRIVADO = 2

    Public Class modPaises
        Public Property Id As Integer
        Public Property Descripcion As String
        Public Property Activo As Integer

    End Class
    Public Function ObtenerPaisPorId(id As Integer) As modPaises

        Dim c As modPaises = Nothing

        Dim sql As String = "SELECT * FROM s_paises WHERE id_pais = @id"

        Using cn As New MySqlConnection(Cadena)
            Using cmd As New MySqlCommand(sql, cn)

                cmd.Parameters.AddWithValue("@id", id)
                cn.Open()

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        c = New modPaises
                        c.Id = Convert.ToInt32(dr("id_pais"))
                        c.Descripcion = dr("descripcion").ToString()
                        c.Activo = Convert.ToInt32(dr("activo"))
                    End If
                End Using

            End Using
        End Using

        Return c

    End Function
    Public Function ExistePais(descripcion As String, Optional idExcluir As Integer = 0) As Boolean

        Dim sql As String =
        "SELECT COUNT(*) FROM s_paises " &
        "WHERE descripcion = @descripcion " &
        "AND id_pais <> @id"

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

    Public Sub GuardarPais(c As modPaises)

        Using cn As New MySqlConnection(Cadena)
            cn.Open()

            Using tran = cn.BeginTransaction()

                Try

                    If c.Id = 0 Then

                        Dim sqlId As String = "SELECT IFNULL(MAX(id_pais),0) + 1 FROM s_paises FOR UPDATE"

                        Using cmdId As New MySqlCommand(sqlId, cn, tran)
                            c.Id = Convert.ToInt32(cmdId.ExecuteScalar())
                        End Using

                        Dim sqlInsert As String =
                            "INSERT INTO s_paises 
                            (id_pais, descripcion, activo)
                            VALUES 
                            (@id, @descripcion, @activo)"

                        Using cmd As New MySqlCommand(sqlInsert, cn, tran)
                            cmd.Parameters.AddWithValue("@id", c.Id)
                            cmd.Parameters.AddWithValue("@Descripcion", c.Descripcion)
                            cmd.Parameters.AddWithValue("@Activo", c.Activo)
                            cmd.ExecuteNonQuery()
                        End Using

                    Else

                        Dim sqlUpdate As String =
                            "UPDATE s_paises SET " &
                            "Descripcion = @Descripcion, " &
                            "Activo = @Activo " &
                            "WHERE id_pais = @id"

                        Using cmd As New MySqlCommand(sqlUpdate, cn, tran)
                            cmd.Parameters.AddWithValue("@id", c.Id)
                            cmd.Parameters.AddWithValue("@Descripcion", c.Descripcion)
                            cmd.Parameters.AddWithValue("@Activo", c.Activo)
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

End Module
