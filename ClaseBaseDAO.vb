Imports System.Data.SqlClient
Imports System.Data.Sql

Public MustInherit Class ClaseBaseDAO
    Protected Function obtenerConexion() As SqlConnection
        Dim oConn As New SqlConnection
        Dim Ruta As String = "C:\Users\Usuario\Documents\FELIPE\BASES DE DATOS\SQL\Solution1.ssmssln"

        oConn.ConnectionString = "Data Source=LAPTOP-FYE\SQLEXPRESS;Initial Catalog=Clientes;Integrated Security=True"

        Try
            oConn.Open()

        Catch ex As Exception
            MsgBox("Problemas con la base de datos")
        Finally
            oConn.Close()
        End Try
        Return oConn
    End Function

End Class
