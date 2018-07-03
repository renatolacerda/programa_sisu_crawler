Public Class Cliente

    Private _idcliente As Integer
    Public Property IdCliente() As Integer
        Get
            Return _idcliente
        End Get
        Set(ByVal value As Integer)
            _idcliente = value
        End Set
    End Property

    Private _nome As String
    Public Property Nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property

    Private _rua As String
    Public Property Rua() As String
        Get
            Return _rua
        End Get
        Set(ByVal value As String)
            _rua = value
        End Set
    End Property

End Class
