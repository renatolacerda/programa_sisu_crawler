Public Interface iSearch(Of T)
#Region "Pesquisas"
    Function FindById(ByVal id As Integer) As Boolean
    Function FindById(ByVal id As T) As Boolean
    Function FindByName(ByVal nome As T) As Integer
    Function FindByName(ByVal nome As String) As Boolean
#End Region
End Interface
