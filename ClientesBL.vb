Imports clientes.DAL
Imports ClientesEntidades
Public Class ClientesBL

    Public Function consultarClientes() As DataTable
        Dim x As New ClientesDAO
        Dim dt As DataTable
        dt = x.consultarClientes
        Return dt
    End Function

    Public Function consultarClientePorId(ByVal Id As Integer) As Cliente
        Dim x As New ClientesDAO
        Return x.consultarClientePorId(Id)
    End Function
    Public Function obtenerListadoClientes() As List(Of Cliente)
        Dim x As New ClientesDAO
        Return x.obtenerListadoClientes
    End Function

    Public Function obtenerListadoClientesPorId(ByVal Id As Integer) As List(Of Cliente)
        Dim x As New ClientesDAO
        Return x.obtenerListadoClientesPorID(Id)
    End Function

    Public Sub actualizarClientes(ByVal listaDeClientes As List(Of Cliente))
        Dim x As New ClientesDAO
        x.actualizarClientes(listaDeClientes)
    End Sub

    Public Sub eliminarClientes(ByVal listaDeClientes As List(Of Cliente))
        Dim x As New ClientesDAO
        x.eliminarClientes(listaDeClientes)
    End Sub

    Public Sub eliminarClientesPorId(ByVal Id As Integer)
        Dim x As New ClientesDAO
        x.eliminarClientePorID(Id)
    End Sub

    Public Sub insertarClientes(ByVal listaDeClientes As List(Of Cliente))
        Dim x As New ClientesDAO
        x.insertarClientes(listaDeClientes)
    End Sub

    Public Function insertarClientes(ByVal oCliente As Cliente) As Integer
        Dim x As New ClientesDAO
        Dim Id As Integer
        Id = x.insertarClientes(oCliente)
        Return Id
    End Function

End Class
