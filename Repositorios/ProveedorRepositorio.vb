Imports System.Data
Imports MySql.Data.MySqlClient

Public Class ProveedorRepositorio

    'LA CADENA SE OBTIENE DEL MÓDULO DE CONEXIÓN A CORREGIR!
    Private ReadOnly _cadena As String = m_Conexion.Cadena

    Public Function ObtenerProveedores(id As Integer) As List(Of Proveedor)
        Dim lista As New List(Of Proveedor)
        Dim sql As String = "SELECT * FROM s_proveedor"
        If id > 0 Then
            sql = sql & " WHERE pais = " & id
        End If
        sql = sql & " ORDER BY Nombre"
        Using cn As New MySqlConnection(_cadena)
            Using cmd As New MySqlCommand(sql, cn)
                cn.Open()
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim c As New Proveedor

                        c.Id = Convert.ToInt32(dr("id_proveedor"))
                        c.Nombre = dr("Nombre").ToString()
                        c.Direccion = dr("direccion").ToString()
                        c.Localidad = dr("localidad").ToString()
                        c.Provincia = dr("provincia").ToString()
                        c.Pais = Convert.ToInt32(dr("pais"))
                        c.telefono = dr("Telefono").ToString()
                        c.Celular = dr("Celular").ToString()
                        c.Email = dr("eMail").ToString()
                        c.Cuit = dr("cuit").ToString()
                        c.PaginaWeb = Convert.ToInt32(dr("PaginaWeb"))
                        c.Contacto = dr("Contacto").ToString()
                        c.comentarios = dr("comentarios").ToString()
                        c.Activo = Convert.ToBoolean(dr("Activo"))

                        lista.Add(c)
                    End While
                End Using
            End Using
        End Using
        Return lista
    End Function



    Public Function ObtenerProveedorPorId(id As Integer) As Proveedor
        Dim c As Proveedor = Nothing
        Dim sql As String = "SELECT * FROM s_proveedor WHERE id_proveedor = @id"

        Using cn As New MySqlConnection(Cadena)
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@id", id)
                cn.Open()
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        c = New Proveedor
                        c.Id = Convert.ToInt32(dr("id_proveedor"))
                        c.Nombre = dr("Nombre").ToString()
                        c.Direccion = dr("direccion").ToString()
                        c.Localidad = dr("localidad").ToString()
                        c.CPostal = dr("c_postal").ToString()
                        c.Provincia = dr("provincia").ToString()
                        c.Pais = Convert.ToInt32(dr("pais"))
                        c.telefono = dr("Telefono").ToString()
                        c.Celular = dr("Celular").ToString()
                        c.Email = dr("eMail").ToString()
                        c.Cuit = dr("cuit").ToString()
                        c.PaginaWeb = Convert.ToInt32(dr("PaginaWeb"))
                        c.Contacto = dr("Contacto").ToString()
                        c.comentarios = dr("comentarios").ToString()
                        c.Activo = Convert.ToBoolean(dr("Activo"))

                    End If
                End Using
            End Using
        End Using
        Return c
    End Function

    Public Sub GuardarProveedor(p As Proveedor)

        Using cn As New MySqlConnection(_cadena)
            cn.Open()

            Using tran = cn.BeginTransaction()

                Try

                    If p.Id = 0 Then

                        ' 🔹 Generate new ID
                        Dim sqlId As String = "SELECT IFNULL(MAX(id_proveedor),0) + 1 FROM s_proveedor FOR UPDATE"

                        Using cmdId As New MySqlCommand(sqlId, cn, tran)
                            p.Id = Convert.ToInt32(cmdId.ExecuteScalar())
                        End Using

                        ' 🔹 INSERT
                        Dim sqlInsert As String =
                        "INSERT INTO s_proveedor " &
                        "(id_proveedor, Nombre, direccion, localidad, provincia, pais, telefono, celular, email, cuit, paginaweb, contacto, comentarios, Activo) " &
                        "VALUES " &
                        "(@id, @nombre, @direccion, @localidad, @provincia, @pais, @telefono, @celular, @email, @cuit, @paginaweb, @contacto, @comentarios, @activo)"

                        Using cmd As New MySqlCommand(sqlInsert, cn, tran)
                            cmd.Parameters.AddWithValue("@id", p.Id)
                            cmd.Parameters.AddWithValue("@nombre", p.Nombre)
                            cmd.Parameters.AddWithValue("@direccion", p.Direccion)
                            cmd.Parameters.AddWithValue("@localidad", p.Localidad)
                            cmd.Parameters.AddWithValue("@provincia", p.Provincia)
                            cmd.Parameters.AddWithValue("@pais", p.Pais)
                            cmd.Parameters.AddWithValue("@telefono", p.telefono)
                            cmd.Parameters.AddWithValue("@celular", p.Celular)
                            cmd.Parameters.AddWithValue("@email", p.Email)
                            cmd.Parameters.AddWithValue("@cuit", p.Cuit)
                            cmd.Parameters.AddWithValue("@paginaweb", p.PaginaWeb)
                            cmd.Parameters.AddWithValue("@contacto", p.Contacto)
                            cmd.Parameters.AddWithValue("@comentarios", p.comentarios)
                            cmd.Parameters.AddWithValue("@activo", p.Activo)
                            cmd.ExecuteNonQuery()
                        End Using

                    Else

                        ' 🔹 UPDATE
                        Dim sqlUpdate As String =
                        "UPDATE s_proveedor SET " &
                        "Nombre = @nombre, " &
                        "direccion = @direccion, " &
                        "localidad = @localidad, " &
                        "provincia = @provincia, " &
                        "pais = @pais, " &
                        "telefono = @telefono, " &
                        "celular = @celular, " &
                        "email = @email, " &
                        "cuit = @cuit, " &
                        "paginaweb = @paginaweb, " &
                        "contacto = @contacto, " &
                        "comentarios = @comentarios, " &
                        "Activo = @activo " &
                        "WHERE id_proveedor = @id"

                        Using cmd As New MySqlCommand(sqlUpdate, cn, tran)
                            cmd.Parameters.AddWithValue("@id", p.Id)
                            cmd.Parameters.AddWithValue("@nombre", p.Nombre)
                            cmd.Parameters.AddWithValue("@direccion", p.Direccion)
                            cmd.Parameters.AddWithValue("@localidad", p.Localidad)
                            cmd.Parameters.AddWithValue("@provincia", p.Provincia)
                            cmd.Parameters.AddWithValue("@pais", p.Pais)
                            cmd.Parameters.AddWithValue("@telefono", p.telefono)
                            cmd.Parameters.AddWithValue("@celular", p.Celular)
                            cmd.Parameters.AddWithValue("@email", p.Email)
                            cmd.Parameters.AddWithValue("@cuit", p.Cuit)
                            cmd.Parameters.AddWithValue("@paginaweb", p.PaginaWeb)
                            cmd.Parameters.AddWithValue("@contacto", p.Contacto)
                            cmd.Parameters.AddWithValue("@comentarios", p.comentarios)
                            cmd.Parameters.AddWithValue("@activo", p.Activo)
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
