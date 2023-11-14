Imports System.Data.SqlClient
Imports ClientesEntidades

Public Class DireccionesDAO
    Inherits ClaseBaseDAO
    Public Function obtenerListadoDirecciones() As List(Of Direccion)
        Dim oCommand As New SqlCommand

        Try
            Dim listadoDirecciones As List(Of Direccion)
            oCommand.Connection = MyBase.obtenerConexion()
            oCommand.CommandText = "SELECT * FROM tbl_Direcciones"
            oCommand.Connection.Open()
            Dim oDataRead As SqlDataReader = oCommand.ExecuteReader()

            ' FUNCION PARA RECUPERAR LOS DATOS
            listadoDirecciones = recuperarListado(oDataRead)
            oDataRead.Close()
            oCommand.Connection.Close()
            Return listadoDirecciones

        Catch ex As Exception
            Throw New System.ApplicationException("No se pudo crear la consulta de Direcciones", ex)
        Finally
            If oCommand.Connection.State = ConnectionState.Open Then
                oCommand.Connection.Close()
            End If
        End Try

    End Function

    Public Function recuperarListado(ByVal dataReader As SqlDataReader) As List(Of Direccion)
        Dim oCommand As New SqlCommand
        Try
            Dim listadoDirecciones As New List(Of Direccion)
            While (dataReader.Read)
                Dim x As New Direccion
                x.DireccionID = dataReader.GetInt32(0)
                x.Direccion = dataReader.GetString(1)
                x.Ciudad = dataReader.GetString(2)
                x.Estado = dataReader.GetString(3)
                x.Telefono = dataReader.GetString(4)
                x.Celular = dataReader.GetString(5)
                x.NIF = dataReader.GetString(6)
                x.PuntoReferencia = dataReader.GetString(7)

                listadoDirecciones.Add(x)
            End While

            Return listadoDirecciones

        Catch ex As Exception
            Throw New System.ApplicationException("No se pudo crear el listado de Direcciones", ex)
        Finally
            If oCommand.Connection.State = ConnectionState.Open Then
                oCommand.Connection.Close()
            End If
        End Try
    End Function

    Public Function obtenerListadoDireccionesPorID(ByVal Id As Integer) As List(Of Direccion)
        Dim oCommand As New SqlCommand

        Try
            Dim listadoDirecciones As List(Of Direccion)
            oCommand.Connection = MyBase.obtenerConexion()
            oCommand.CommandText = "SELECT * FROM tbl_Direcciones WHERE DireccionID = @DireccionID"
            oCommand.Parameters.Add("@DireccionID", SqlDbType.Int).Value = Id
            oCommand.Connection.Open()
            Dim oDataRead As SqlDataReader = oCommand.ExecuteReader()

            ' FUNCION PARA RECUPERAR LOS DATOS
            listadoDirecciones = recuperarListado(oDataRead)
            oDataRead.Close()
            oCommand.Connection.Close()
            Return listadoDirecciones

        Catch ex As Exception
            Throw New System.ApplicationException("No se pudo encontrar la Direccion por ID", ex)
        Finally
            If oCommand.Connection.State = ConnectionState.Open Then
                oCommand.Connection.Close()
            End If
        End Try

    End Function

    Public Sub actualizarDirecciones(ByVal listaDeDirecciones As List(Of Direccion))
        Dim oCommand As New SqlCommand

        Try
            oCommand.Connection = MyBase.obtenerConexion()
            oCommand.CommandText = "UPDATE tbl_Direcciones SET ClienteID = @ClienteID, Direccion = @Direccion, Ciudad = @Ciudad, Estado = @Estado, Telefono = @Telefono, Celular = @Celular, NIF = @NIF, PuntoReferencia = @PuntoReferencia WHERE DireccionID = @DireccionID"
            oCommand.Parameters.Add("@DireccionID", SqlDbType.Int)
            oCommand.Parameters.Add("@Direccion", SqlDbType.NChar)
            oCommand.Parameters.Add("@Ciudad", SqlDbType.NChar)
            oCommand.Parameters.Add("@Estado", SqlDbType.NChar)
            oCommand.Parameters.Add("@Telefono", SqlDbType.NChar)
            oCommand.Parameters.Add("@Celular", SqlDbType.NChar)
            oCommand.Parameters.Add("@NIF", SqlDbType.NChar)
            oCommand.Parameters.Add("@PuntoReferencia", SqlDbType.NChar)
            oCommand.Connection.Open()
            For Each x As Direccion In listaDeDirecciones
                oCommand.Parameters("@DireccionID").Value = x.DireccionID
                oCommand.Parameters("@Direccion").Value = x.Direccion
                oCommand.Parameters("@Ciudad").Value = x.Ciudad
                oCommand.Parameters("@Estado").Value = x.Estado
                oCommand.Parameters("@Telefono").Value = x.Telefono
                oCommand.Parameters("@Celular").Value = x.Celular
                oCommand.Parameters("@NIF").Value = x.NIF
                oCommand.Parameters("@PuntoReferencia").Value = x.PuntoReferencia
                oCommand.ExecuteNonQuery()
            Next
            oCommand.Connection.Close()
        Catch ex As Exception
            Throw New System.ApplicationException("No se pudo actualizar la Direccion", ex)
        Finally
            If oCommand.Connection.State = ConnectionState.Open Then
                oCommand.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub eliminarDirecciones(ByVal listaDeDirecciones As List(Of Direccion))
        Dim oCommand As New SqlCommand

        Try
            oCommand.Connection = MyBase.obtenerConexion()
            oCommand.CommandText = "DELETE FROM tbl_Direcciones WHERE DireccionID = @DireccionID"
            oCommand.Parameters.Add("@DireccionID", SqlDbType.Int)

            oCommand.Connection.Open()

            For Each X As Direccion In listaDeDirecciones
                oCommand.Parameters("@DireccionID").Value = X.DireccionID
                oCommand.ExecuteNonQuery()
            Next

            oCommand.Connection.Close()
        Catch ex As Exception
            Throw New System.ApplicationException("No se pudo eliminar la Direccion", ex)
        Finally
            If oCommand.Connection.State = ConnectionState.Open Then
                oCommand.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub eliminarDireccionPorID(ByVal Id As Integer)
        Dim oCommand As New SqlCommand

        Try
            oCommand.Connection = MyBase.obtenerConexion()
            oCommand.CommandText = "DELETE FROM tbl_Direcciones WHERE DireccionID = @DireccionID"
            oCommand.Parameters.Add("@DireccionID", SqlDbType.Int).Value = Id

            oCommand.Connection.Open()
            oCommand.ExecuteNonQuery()
            oCommand.Connection.Close()

        Catch ex As Exception
            Throw New SystemException("No se pudo eliminar esa Direccion", ex)
        Finally
            If oCommand.Connection.State = ConnectionState.Open Then
                oCommand.Connection.Close()
            End If
        End Try
    End Sub
    '   VIDEOS 09 Y 10
    Public Sub insertarDirecciones(ByVal listaDeDirecciones As List(Of Direccion))
        Dim oCommand As New SqlCommand

        Try
            oCommand.Connection = MyBase.obtenerConexion()
            oCommand.CommandText = "INSERT INTO tbl_Direcciones VALUES (@DireccionID, @ClienteID, @Direccion, @Ciudad, @Estado, @telefono, @Celular, @NIF, @PuntoReferencia)"
            oCommand.Parameters.Add("@DireccionID", SqlDbType.Int)
            oCommand.Parameters.Add("@Direccion", SqlDbType.NChar)
            oCommand.Parameters.Add("@Ciudad", SqlDbType.NChar)
            oCommand.Parameters.Add("@Estado", SqlDbType.NChar)
            oCommand.Parameters.Add("@Telefono", SqlDbType.NChar)
            oCommand.Parameters.Add("@Celular", SqlDbType.NChar)
            oCommand.Parameters.Add("@NIF", SqlDbType.NChar)
            oCommand.Parameters.Add("@PuntoReferencia", SqlDbType.NChar)
            oCommand.Connection.Open()
            For Each x As Direccion In listaDeDirecciones
                oCommand.Parameters("@DireccionID").Value = capturarIdFinal()
                oCommand.Parameters("@Direccion").Value = x.Direccion
                oCommand.Parameters("@Ciudad").Value = x.Ciudad
                oCommand.Parameters("@Estado").Value = x.Estado
                oCommand.Parameters("@Telefono").Value = x.Telefono
                oCommand.Parameters("@Celular").Value = x.Celular
                oCommand.Parameters("@NIF").Value = x.NIF
                oCommand.Parameters("@PuntoReferencia").Value = x.PuntoReferencia

                oCommand.ExecuteNonQuery()
            Next
            oCommand.Connection.Close()
        Catch ex As Exception
            Throw New System.ApplicationException("No se pudo insertar las Direcciones", ex)
        Finally
            If oCommand.Connection.State = ConnectionState.Open Then
                oCommand.Connection.Close()
            End If
        End Try
    End Sub

    Private Function capturarIdFinal() As Integer
        Dim oCommand As New SqlCommand
        Try
            oCommand.Connection = MyBase.obtenerConexion()
            oCommand.CommandText = "SELECT MAX(DireccionID) FROM tbl_Direcciones"
            oCommand.Connection.Open()

            Dim ultimoID As Object = oCommand.ExecuteScalar()
            If ultimoID Is Nothing Then
                ultimoID = 1
            Else
                ultimoID += 1
            End If

            Return Convert.ToInt32(ultimoID)

            oCommand.Connection.Close()

        Catch ex As Exception
            Throw New System.ApplicationException("No se pudo obtener siguiente ID de Direccion", ex)
        End Try

    End Function

    Public Sub insertarDirecciones(ByVal oDireccion As Direccion)
        Dim oCommand As New SqlCommand

        Try
            oCommand.Connection = MyBase.obtenerConexion()
            oCommand.CommandText = "INSERT INTO tbl_Direcciones VALUES (@DireccionID, @Direccion, @Ciudad, @Estado, @Telefono, @Celular, @NIF, @PuntoReferencia)"
            oCommand.Parameters.Add("@DireccionID", SqlDbType.Int)
            oCommand.Parameters.Add("@Direccion", SqlDbType.NChar)
            oCommand.Parameters.Add("@Ciudad", SqlDbType.NChar)
            oCommand.Parameters.Add("@Estado", SqlDbType.NChar)
            oCommand.Parameters.Add("@Telefono", SqlDbType.NChar)
            oCommand.Parameters.Add("@Celular", SqlDbType.NChar)
            oCommand.Parameters.Add("@NIF", SqlDbType.NChar)
            oCommand.Parameters.Add("@PuntoReferencia", SqlDbType.NChar)

            oCommand.Connection.Open()

            oCommand.Parameters("@DireccionID").Value = capturarIdFinal()
            oCommand.Parameters("@Direccion").Value = oDireccion.Direccion
            oCommand.Parameters("@Ciudad").Value = oDireccion.Ciudad
            oCommand.Parameters("@Estado").Value = oDireccion.Estado
            oCommand.Parameters("@Telefono").Value = oDireccion.Telefono
            oCommand.Parameters("@Celular").Value = oDireccion.Celular
            oCommand.Parameters("@NIF").Value = oDireccion.NIF
            oCommand.Parameters("@PuntoReferencia").Value = oDireccion.PuntoReferencia
            oCommand.ExecuteNonQuery()

            oCommand.Connection.Close()
        Catch ex As Exception
            Throw New System.ApplicationException("No se pudo insertar la Direccion", ex)
        Finally
            If oCommand.Connection.State = ConnectionState.Open Then
                oCommand.Connection.Close()
            End If
        End Try
    End Sub
End Class
