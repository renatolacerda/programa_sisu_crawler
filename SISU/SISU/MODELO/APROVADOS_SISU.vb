Public Class APROVADOS_SISU

    Private _instituicao As String
    Public Property Instituicao() As String
        Get
            Return _instituicao
        End Get
        Set(ByVal value As String)
            _instituicao = value
        End Set
    End Property

    Private _localoferta As String
    Public Property LocalOferta() As String
        Get
            Return _localoferta
        End Get
        Set(ByVal value As String)
            _localoferta = value
        End Set
    End Property

    Private _curso As String
    Public Property Curso() As String
        Get
            Return _curso
        End Get
        Set(ByVal value As String)
            _curso = value
        End Set
    End Property

    Private _grauturno As String
    Public Property GrauTurno() As String
        Get
            Return _grauturno
        End Get
        Set(ByVal value As String)
            _grauturno = value
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

    Private _matricula As String
    Public Property Matricula() As String
        Get
            Return _matricula
        End Get
        Set(ByVal value As String)
            _matricula = value
        End Set
    End Property

End Class
