Public Interface iArrays(Of T)
#Region "Arrays"
    Function DataGridList(ByVal texto As String) As ArrayList
    Function DataGridList(ByVal id As Integer) As ArrayList
    Function DataGridList() As ArrayList
#End Region
End Interface
