Imports System.Data.SqlClient
Imports ClientesEntidades

Public Class ClientesDAO
    Inherits ClaseBaseDAO

    Public Function consultarClientes() As DataTable
        Dim oCommand As New SqlCommand
        Try
            oCommand.Connection = MyBase.obtenerConexion()
            oCommand.CommandText = "SELECT * FROM tbl_clientes"
            oCommand.Connection.Open()

            If oCommand.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim adp As New SqlDataAdapter(oCommand)
                adp.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            If oCommand.Connection.State = ConnectionState.Open Then
                oCommand.Connection.Close()
            End If
        End Try
    End Function

    Public Function consultarClientePorId(ByVal Id As Integer) As Cliente
        Dim x As New Cliente
        Dim oCommand As New SqlCommand
        Dim dataReader As SqlDataReader
        'dataReader = Nothing
        Try
            oCommand.Connection = MyBase.obtenerConexion()
            oCommand.CommandText = "SELECT * FROM tbl_clientes WHERE clienteID = " & Id
            oCommand.Connection.Open()
            dataReader = oCommand.ExecuteReader

            If oCommand.ExecuteNonQuery Then
                x.ID = dataReader.GetInt32(0)
                x.Nombre = dataReader.GetString(1)
                x.FechaRegistro = dataReader.GetDateTime(2)
                x.Ramo = dataReader.GetString(3)
                x.Login = dataReader.GetString(4)
                x.PassWord = dataReader.GetString(5)
                MsgBox("(DAO) Nombre: " & x.Nombre)
            End If
            dataReader.Close()
            Return x
        Catch ex As Exception
            MsgBox("No se encontro cliente ID: " & Id & " " & ex.Message)
            Return Nothing
        Finally

            If oCommand.Connection.State = ConnectionState.Open Then
                oCommand.Connection.Close()
            End If

        End Try

    End Function
    Public Function obtenerListadoClientes() As List(Of Cliente)
        Dim oCommand As New SqlCommand

        Try
            Dim listadoClientes As New List(Of Cliente)
            oCommand.Connection = MyBase.obtenerConexion()
            oCommand.CommandText = "SELECT * FROM tbl_clientes"
            oCommand.Connection.Open()
            Dim oDataRead As SqlDataReader = oCommand.ExecuteReader()

            ' FUNCION PARA RECUPERAR LOS DATOS
            listadoClientes = recuperarListado(oDataRead)
            oDataRead.Close()
            oCommand.Connection.Close()
            Return listadoClientes

        Catch ex As Exception
            Throw New System.ApplicationException("No se pudo crear la consulta de clientes", ex)
        Finally
            If oCommand.Connection.State = ConnectionState.Open Then
                oCommand.Connection.Close()
            End If
        End Try

    End Function

    Private Function recuperarListado(ByVal dataReader As SqlDataReader) As List(Of Cliente)

        Try
            Dim listadoClientes As New List(Of Cliente)
            While (dataReader.Read)
                Dim x As New Cliente
                x.ID = dataReader.GetInt32(0)
                x.Nombre = dataReader.GetString(1)
                x.FechaRegistro = dataReader.GetDateTime(2)
                x.Ramo = dataReader.GetString(3)
                x.Login = dataReader.GetString(4)
                x.PassWord = dataReader.GetString(5)

                listadoClientes.Add(x)
            End While

            Return listadoClientes

        Catch ex As Exception
            MsgBox("Error Recuperar")
            Throw New System.ApplicationException("No se pudo crear el listado de clientes", ex)
        End Try
    End Function

    Public Function obtenerListadoClientesPorID(ByVal Id As Integer) As List(Of Cliente)
        Dim oCommand As New SqlCommand
        Try
            Dim listadoClientes As List(Of Cliente)
            oCommand.Connection = MyBase.obtenerConexion()
            oCommand.CommandText = "SELECT * FROM tbl_clientes WHERE clienteID = @clienteID"
            oCommand.Parameters.Add("@clienteID", SqlDbType.Int).Value = Id
            oCommand.Connection.Open()

            Dim dr As SqlDataReader = oCommand.ExecuteReader()

            ' FUNCION PARA RECUPERAR LOS DATOS
            listadoClientes = recuperarListado(dr)
            dr.Close()
            oCommand.Connection.Close()
            Return listadoClientes

        Catch ex As Exception

            Throw New System.ApplicationException("No se pudo encontrar el cliente", ex)
        Finally
            If oCommand.Connection.State = ConnectionState.Open Then
                oCommand.Connection.Close()
            End If
        End Try

    End Function

    Public Sub actualizarClientes(ByVal listaDeClientes As List(Of Cliente))
        Dim oCommand As New SqlCommand

        Try
            oCommand.Connection = MyBase.obtenerConexion()
            oCommand.CommandText = "UPDATE tbl_clientes SET nombre = @Nombre, fechaRegistro = @fechaRegistro, Ramo = @Ramo, Login = @Login, PassWord = @PassWord WHERE ClienteID = @ClienteID"
            oCommand.Parameters.Add("@ClienteID", SqlDbType.Int)
            oCommand.Parameters.Add("@Nombre", SqlDbType.NChar)
            oCommand.Parameters.Add("@fechaRegistro", SqlDbType.DateTime)
            oCommand.Parameters.Add("@Ramo", SqlDbType.NChar)
            oCommand.Parameters.Add("@Login", SqlDbType.NChar)
            oCommand.Parameters.Add("@PassWord", SqlDbType.NChar)

            oCommand.Connection.Open()
            For Each x As Cliente In listaDeClientes
                oCommand.Parameters("@ClienteID").Value = x.ID
                oCommand.Parameters("@Nombre").Value = x.Nombre
                oCommand.Parameters("@fechaRegistro").Value = x.FechaRegistro
                oCommand.Parameters("@Ramo").Value = x.Ramo
                oCommand.Parameters("@Login").Value = x.Login
                oCommand.Parameters("@PassWord").Value = x.PassWord
                oCommand.ExecuteNonQuery()
            Next
            oCommand.Connection.Close()
        Catch ex As Exception
            Throw New System.ApplicationException("No se pudo actualizar el cliente", ex)
        Finally
            If oCommand.Connection.State = ConnectionState.Open Then
                oCommand.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub eliminarClientes(ByVal listaDeClientes As List(Of Cliente))
        Dim oCommand As New SqlCommand

        Try
            oCommand.Connection = MyBase.obtenerConexion()
            oCommand.CommandText = "DELETE FROM tbl_clientes WHERE ClienteID = @ClienteID"
            oCommand.Parameters.Add("@ClienteID", SqlDbType.Int)

            oCommand.Connection.Open()

            For Each X As Cliente In listaDeClientes
                oCommand.Parameters("@ClienteID").Value = X.ID
                oCommand.ExecuteNonQuery()
            Next

            oCommand.Connection.Close()
        Catch ex As Exception
            Throw New System.ApplicationException("No se pudo eliminar el cliente", ex)
        Finally
            If oCommand.Connection.State = ConnectionState.Open Then
                oCommand.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub eliminarClientePorID(ByVal Id As Integer)
        Dim oCommand As New SqlCommand

        Try
            oCommand.Connection = MyBase.obtenerConexion()
            oCommand.CommandText = "DELETE FROM tbl_clientes WHERE ClienteID = @ClienteID"
            oCommand.Parameters.Add("@ClienteID", SqlDbType.Int).Value = Id

            oCommand.Connection.Open()
            oCommand.ExecuteNonQuery()
            oCommand.Connection.Close()

        Catch ex As Exception
            Throw New SystemException("No se pudo eliminar ese cliente", ex)
        Finally
            If oCommand.Connection.State = ConnectionState.Open Then
                oCommand.Connection.Close()
            End If
        End Try
    End Sub
    '   VIDEOS 09 Y 10
    Public Sub insertarClientes(ByVal listaDeClientes As List(Of Cliente))
        Dim oCommand As New SqlCommand

        Try
            oCommand.Connection = MyBase.obtenerConexion()
            oCommand.CommandText = "INSERT INTO tbl_clientes VALUES (@ClienteID, @Nombre, @fechaRegistro, @Ramo, @Login, @PassWord)"
            oCommand.Parameters.Add("@ClienteID", SqlDbType.Int)
            oCommand.Parameters.Add("@Nombre", SqlDbType.NChar)
            oCommand.Parameters.Add("@fechaRegistro", SqlDbType.DateTime)
            oCommand.Parameters.Add("@Ramo", SqlDbType.NChar)
            oCommand.Parameters.Add("@Login", SqlDbType.NChar)
            oCommand.Parameters.Add("@PassWord", SqlDbType.NChar)

            oCommand.Connection.Open()
            For Each x As Cliente In listaDeClientes
                oCommand.Parameters("@ClienteID").Value = capturarIdFinal()
                oCommand.Parameters("@Nombre").Value = x.Nombre
                oCommand.Parameters("@fechaRegistro").Value = x.FechaRegistro
                oCommand.Parameters("@Ramo").Value = x.Ramo
                oCommand.Parameters("@Login").Value = x.Login
                oCommand.Parameters("@PassWord").Value = x.PassWord
                oCommand.ExecuteNonQuery()
            Next
            oCommand.Connection.Close()
        Catch ex As Exception
            Throw New System.ApplicationException("No se pudo insertar los clientes", ex)
        Finally
            If oCommand.Connection.State = ConnectionState.Open Then
                oCommand.Connection.Close()
            End If
        End Try
    End Sub

    Private Function capturarIdFinal() As Integer
        Dim oCommand As New SqlCommand
        Dim ultimoID As New Object
        Dim FinalID As Integer
        Try
            oCommand.Connection = MyBase.obtenerConexion()
            oCommand.CommandText = "SELECT MAX(ClienteID) FROM tbl_clientes"
            oCommand.Connection.Open()

            ultimoID = oCommand.ExecuteScalar()
            'FinalID = 1
            If IsNothing(ultimoID) Then

                FinalID = 1
            Else
                Convert.ToInt32(ultimoID)
                FinalID = ultimoID
                FinalID += 1
            End If

            Return FinalID

            oCommand.Connection.Close()

        Catch ex As Exception

            Throw New System.ApplicationException("No se pudo obtener siguiente ID", ex)
        End Try

    End Function

    Public Function insertarClientes(ByVal oCliente As Cliente) As Integer
        Dim oCommand As New SqlCommand
        Dim Id As Integer = capturarIdFinal()

        Try
            oCommand.Connection = MyBase.obtenerConexion()
            oCommand.CommandText = "INSERT INTO tbl_clientes VALUES (@ClienteID, @Nombre, @fechaRegistro, @Ramo, @Login, @PassWord)"
            oCommand.Parameters.Add("@ClienteID", SqlDbType.Int)
            oCommand.Parameters.Add("@Nombre", SqlDbType.NChar)
            oCommand.Parameters.Add("@fechaRegistro", SqlDbType.DateTime)
            oCommand.Parameters.Add("@Ramo", SqlDbType.NChar)
            oCommand.Parameters.Add("@Login", SqlDbType.NChar)
            oCommand.Parameters.Add("@PassWord", SqlDbType.NChar)

            oCommand.Connection.Open()

            oCommand.Parameters("@ClienteID").Value = Id
            oCommand.Parameters("@Nombre").Value = oCliente.Nombre
            oCommand.Parameters("@fechaRegistro").Value = oCliente.FechaRegistro
            oCommand.Parameters("@Ramo").Value = oCliente.Ramo
            oCommand.Parameters("@Login").Value = oCliente.Login
            oCommand.Parameters("@PassWord").Value = oCliente.PassWord

            oCommand.ExecuteNonQuery()

            oCommand.Connection.Close()
            Return Id
        Catch ex As Exception
            Throw New System.ApplicationException("No se pudo insertar el cliente", ex)
        Finally
            If oCommand.Connection.State = ConnectionState.Open Then
                oCommand.Connection.Close()
            End If
        End Try
    End Function
End Class
