Imports System.Data
Imports MySql.Data.MySqlClient

Public Class PaisRepositorio
    Private ReadOnly _cadena As String = m_Conexion.Cadena

    Public Function ObtenerPaises() As DataTable
        Dim dt As New DataTable

        Using cn As New MySqlConnection(_cadena)
            Using cmd As New MySqlCommand("SELECT id_pais, descripcion FROM s_paises ORDER BY descripcion", cn)
                cn.Open()
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function

End Class
