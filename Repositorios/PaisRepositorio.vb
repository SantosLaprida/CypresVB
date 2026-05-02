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
    'Public Function ObtenerPaisPorId(id As Integer) As modPaises
    '    Dim c As modPaises = Nothing
    '    Dim sql As String = "SELECT * FROM s_paises WHERE id_pais = @id"

    '    Using cn As New MySqlConnection(Cadena)
    '        Using cmd As New MySqlCommand(sql, cn)
    '            cmd.Parameters.AddWithValue("@id", id)
    '            cn.Open()
    '            Using dr As MySqlDataReader = cmd.ExecuteReader()
    '                If dr.Read() Then
    '                    c = New modPaises
    '                    c.Id = Convert.ToInt32(dr("id_pais"))
    '                    c.descripcion = dr("descripcion").ToString()
    '                    c.activo = Convert.ToInt32(dr("activo"))
    '                End If
    '            End Using
    '        End Using
    '    End Using
    '    Return c
    'End Function
End Class
