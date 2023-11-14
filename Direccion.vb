Public Class Direccion

    Private DireccDireccionID As Integer
    Public Property DireccionID() As Integer
        Get
            Return DireccDireccionID
        End Get
        Set(ByVal value As Integer)
            DireccDireccionID = value
        End Set
    End Property

    Private DireccClienteID As Integer
    Public Property ClienteID() As Integer
        Get
            Return DireccClienteID
        End Get
        Set(ByVal value As Integer)
            DireccClienteID = value
        End Set
    End Property

    Private DireccDireccion As String
    Public Property Direccion() As String
        Get
            Return DireccDireccion
        End Get
        Set(ByVal value As String)
            DireccDireccion = value
        End Set
    End Property

    Private DireccCiudad As String
    Public Property Ciudad() As String
        Get
            Return DireccCiudad
        End Get
        Set(ByVal value As String)
            DireccCiudad = value
        End Set
    End Property

    Private DireccEstado As String
    Public Property Estado() As String
        Get
            Return DireccEstado
        End Get
        Set(ByVal value As String)
            DireccEstado = value
        End Set
    End Property

    Private DireccTelefono As String
    Public Property Telefono() As String
        Get
            Return DireccTelefono
        End Get
        Set(ByVal value As String)
            DireccTelefono = value
        End Set
    End Property

    Private DireccCelular As String
    Public Property Celular() As String
        Get
            Return DireccCelular
        End Get
        Set(ByVal value As String)
            DireccCelular = value
        End Set
    End Property

    Private DireccNIF As String
    Public Property NIF() As String
        Get
            Return DireccNIF
        End Get
        Set(ByVal value As String)
            DireccNIF = value
        End Set
    End Property

    Private DireccPuntoReferencia As String
    Public Property PuntoReferencia() As String
        Get
            Return DireccPuntoReferencia
        End Get
        Set(ByVal value As String)
            DireccPuntoReferencia = value
        End Set
    End Property



End Class
