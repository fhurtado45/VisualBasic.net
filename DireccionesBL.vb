Imports clientes.DAL
Imports ClientesEntidades
Public Class DireccionesBL
    Public Function obtenerListadoDirecciones() As List(Of Direccion)
        Dim x As New DireccionesDAO
        Return x.obtenerListadoDirecciones
    End Function

    Public Function obtenerListadoDireccionesPorId(ByVal Id As Integer) As List(Of Direccion)
        Dim x As New DireccionesDAO
        Return x.obtenerListadoDireccionesPorID(Id)
    End Function

    Public Sub actualizarDirecciones(ByVal listaDeDirecciones As List(Of Direccion))
        Dim x As New DireccionesDAO
        x.actualizarDirecciones(listaDeDirecciones)
    End Sub

    Public Sub eliminarDirecciones(ByVal listaDeDirecciones As List(Of Direccion))
        Dim x As New DireccionesDAO
        x.eliminarDirecciones(listaDeDirecciones)
    End Sub

    Public Sub eliminarDireccionesPorId(ByVal Id As Integer)
        Dim x As New DireccionesDAO
        x.eliminarDireccionPorID(Id)
    End Sub

    Public Sub insertarDirecciones(ByVal listaDeDirecciones As List(Of Direccion))
        Dim x As New DireccionesDAO
        x.insertarDirecciones(listaDeDirecciones)
    End Sub

    Public Sub insertarDirecciones(ByVal oDireccion As Direccion)
        Dim x As New DireccionesDAO
        x.insertarDirecciones(oDireccion)
    End Sub
End Class
