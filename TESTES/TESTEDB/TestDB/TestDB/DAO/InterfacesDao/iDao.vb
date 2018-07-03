Public Interface iDao(Of T)
    'WEB: http://www.macoratti.net/11/10/pp_dao1.htm

    Function Add(ByVal obj As T) As Boolean
    Function Update(ByVal obj As T) As Boolean
    Function Delete(ByVal obj As T) As Boolean


End Interface
