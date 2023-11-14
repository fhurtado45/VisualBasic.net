Public Class Cliente

    Private ClienteID As Integer
    Public Property ID() As Integer
        Get
            Return ClienteID
        End Get
        Set(ByVal value As Integer)
            ClienteID = value
        End Set
    End Property

    Private ClienteNombre As String
    Public Property Nombre() As String
        Get
            Return ClienteNombre
        End Get
        Set(ByVal value As String)
            ClienteNombre = value
        End Set
    End Property

    Private ClienteFechaRegistro As Date
    Public Property FechaRegistro() As DateTime
        Get
            Return ClienteFechaRegistro
        End Get
        Set(ByVal value As DateTime)
            ClienteFechaRegistro = value
        End Set
    End Property

    Private ClienteRamo As String
    Public Property Ramo() As String
        Get
            Return ClienteRamo
        End Get
        Set(ByVal value As String)
            ClienteRamo = value
        End Set
    End Property

    Private ClienteLogin As String
    Public Property Login() As String
        Get
            Return ClienteLogin
        End Get
        Set(ByVal value As String)
            ClienteLogin = value
        End Set
    End Property

    Private ClientePassWord As String
    Public Property PassWord() As String
        Get
            Return ClientePassWord
        End Get
        Set(ByVal value As String)
            ClientePassWord = value
        End Set
    End Property

    ' DEFINICION Y PROPIEDADES DE LA CLAVE FORANEA

    Private listaDirecciones As List(Of Direccion)
    Public Property direcciones() As List(Of Direccion)
        Get
            Return listaDirecciones
        End Get
        Set(ByVal value As List(Of Direccion))
            listaDirecciones = value
        End Set
    End Property

End Class
