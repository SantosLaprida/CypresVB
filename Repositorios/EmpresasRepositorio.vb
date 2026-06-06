Imports System.Data
Imports MySql.Data.MySqlClient

Public Class EmpresasRepositorio

    'LA CADENA SE OBTIENE DEL MÓDULO DE CONEXIÓN A CORREGIR!
    Private ReadOnly _cadena As String = m_Conexion.Cadena

    Public Function ObtenerEmpresas(id As Integer) As List(Of Empresas)
        Dim lista As New List(Of Empresas)
        Dim sql As String = "SELECT * FROM s_empresas"
        If id > 0 Then
            sql = sql & " WHERE pais = " & id
        End If
        sql = sql & " ORDER BY Nombre"
        Using cn As New MySqlConnection(_cadena)
            Using cmd As New MySqlCommand(sql, cn)
                cn.Open()
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim c As New Empresas

                        c.Id = Convert.ToInt32(dr("id_empresa"))
                        c.Nombre = dr("Nombre").ToString()
                        c.Direccion = dr("direccion").ToString()
                        c.Localidad = dr("localidad").ToString()
                        c.CPostal = dr("c_postal").ToString()
                        c.Pais = Convert.ToInt32(dr("pais"))
                        c.telefono = dr("Telefono").ToString()
                        'c.Celular = dr("Celular").ToString()
                        'c.Email = dr("eMail").ToString()
                        'c.Cuit = dr("cuit").ToString()
                        'c.PaginaWeb = Convert.ToInt32(dr("PaginaWeb"))
                        'c.Contacto = dr("Contacto").ToString()
                        'c.comentarios = dr("comentarios").ToString()
                        'c.Activo = Convert.ToBoolean(dr("Activo"))

                        lista.Add(c)
                    End While
                End Using
            End Using
        End Using
        Return lista
    End Function



    Public Function ObtenerEmpresaPorId(id As Integer) As Empresas
        Dim c As Empresas = Nothing
        Dim sql As String = "SELECT * FROM s_empresas WHERE id_empresa = @id"

        Using cn As New MySqlConnection(Cadena)
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@id", id)
                cn.Open()
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        c = New Empresas
                        c.Id = Convert.ToInt32(dr("id_empresa"))
                        c.Nombre = dr("Nombre").ToString()
                        c.Direccion = dr("direccion").ToString()
                        c.Localidad = dr("localidad").ToString()
                        c.CPostal = dr("c_postal").ToString()
                        'c.Provincia = dr("provincia").ToString()
                        c.Pais = Convert.ToInt32(dr("pais"))
                        c.telefono = dr("telefono").ToString()
                        'c.Celular = dr("Celular").ToString()
                        'c.Email = dr("eMail").ToString()
                        'c.Cuit = dr("cuit").ToString()
                        'c.PaginaWeb = Convert.ToInt32(dr("PaginaWeb"))
                        'c.Contacto = dr("Contacto").ToString()
                        'c.comentarios = dr("comentarios").ToString()
                        'c.Activo = Convert.ToBoolean(dr("Activo"))

                    End If
                End Using
            End Using
        End Using
        Return c
    End Function

    Public Sub GuardarEmpresa(p As Empresas)

        Using cn As New MySqlConnection(_cadena)
            cn.Open()

            Using tran = cn.BeginTransaction()

                Try

                    If p.Id = 0 Then

                        ' 🔹 Generate new ID
                        Dim sqlId As String = "SELECT IFNULL(MAX(id_empresa),0) + 1 FROM s_empresas FOR UPDATE"

                        Using cmdId As New MySqlCommand(sqlId, cn, tran)
                            p.Id = Convert.ToInt32(cmdId.ExecuteScalar())
                        End Using

                        ' 🔹 INSERT
                        Dim sqlInsert As String =
                        "INSERT INTO s_empresas " &
                        "(id_empresa, Nombre, direccion, localidad ) " &
                        "VALUES " &
                        "(@id, @nombre, @direccion, @localidad )"

                        Using cmd As New MySqlCommand(sqlInsert, cn, tran)
                            cmd.Parameters.AddWithValue("@id", p.Id)
                            cmd.Parameters.AddWithValue("@nombre", p.Nombre)
                            cmd.Parameters.AddWithValue("@direccion", p.Direccion)
                            cmd.Parameters.AddWithValue("@localidad", p.Localidad)
                            cmd.Parameters.AddWithValue("@pais", p.Pais)
                            cmd.Parameters.AddWithValue("@telefono", p.telefono)
                            cmd.ExecuteNonQuery()
                        End Using

                    Else

                        ' 🔹 UPDATE
                        Dim sqlUpdate As String =
                        "UPDATE s_empresas SET " &
                        "Nombre = @nombre, " &
                        "direccion = @direccion, " &
                        "localidad = @localidad, " &
                        "pais = @pais, " &
                        "telefono = @telefono " &
                        "WHERE id_empresa = @id"

                        Using cmd As New MySqlCommand(sqlUpdate, cn, tran)
                            cmd.Parameters.AddWithValue("@id", p.Id)
                            cmd.Parameters.AddWithValue("@nombre", p.Nombre)
                            cmd.Parameters.AddWithValue("@direccion", p.Direccion)
                            cmd.Parameters.AddWithValue("@localidad", p.Localidad)
                            cmd.Parameters.AddWithValue("@pais", p.Pais)
                            cmd.Parameters.AddWithValue("@telefono", p.telefono)
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
    Public Sub EmpresaGuardarLogo(
        idEmpresa As Integer,
        rutaArchivo As String)

        Dim bytesLogo() As Byte

        bytesLogo =
            IO.File.ReadAllBytes(rutaArchivo)

        Dim extension As String

        extension =
            IO.Path.GetExtension(rutaArchivo)

        Dim sql As String =
            "REPLACE INTO s_empresas_logos " &
            "(id_empresa, logo, extension) " &
            "VALUES " &
            "(@id, @logo, @extension)"

        Using cn As New MySqlConnection(Cadena)

            Using cmd As New MySqlCommand(sql, cn)

                cmd.Parameters.AddWithValue(
                    "@id", idEmpresa)

                cmd.Parameters.AddWithValue(
                    "@logo", bytesLogo)

                cmd.Parameters.AddWithValue(
                    "@extension", extension)

                cn.Open()

                cmd.ExecuteNonQuery()

            End Using

        End Using

    End Sub
    Public Function EmpresaObtenerLogo(idEmpresa As Integer) As Byte()

        Dim sql As String =
            "SELECT logo FROM s_empresas_logos WHERE id_empresa = @id"

        Using cn As New MySqlConnection(_cadena)
            Using cmd As New MySqlCommand(sql, cn)

                cmd.Parameters.AddWithValue("@id", idEmpresa)
                cn.Open()

                Dim result As Object = cmd.ExecuteScalar()

                If result Is Nothing OrElse IsDBNull(result) Then
                    Return Nothing
                End If

                Return CType(result, Byte())

            End Using
        End Using

    End Function

    Public Function EmpresaObtenerPorLicitacion(idLicitacion As Integer) As List(Of Empresas)
        Dim sql As String = "SELECT e.* FROM s_empresas e " &
                        "INNER JOIN s_lic_empresa le ON e.id_empresa = le.id_empresa " &
                        "WHERE le.id_lic = @id"

        Dim lista As New List(Of Empresas)

        Using cn As New MySqlConnection(_cadena)
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@id", idLicitacion)
                cn.Open()
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim empresa As New Empresas
                        empresa.Id = dr("id_empresa")
                        empresa.Nombre = dr("nombre")
                        empresa.Direccion = dr("direccion")
                        empresa.Localidad = dr("localidad")
                        empresa.CPostal = dr("c_postal")
                        empresa.Provincia = dr("provincia")
                        empresa.Pais = dr("pais")
                        empresa.telefono = dr("telefono")
                        empresa.Celular = dr("celular")
                        empresa.Email = dr("e_mail")
                        lista.Add(empresa)
                    End While
                End Using
            End Using
        End Using

        Return lista
    End Function

End Class