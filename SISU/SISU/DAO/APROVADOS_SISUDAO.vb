Imports MySql.Data.MySqlClient

Public Class APROVADOS_SISUDAO

    Private Shared ReadOnly instancia As New APROVADOS_SISU()

#Region "Construtor"
    Sub New()
        GetInstance()
    End Sub
    Public Shared Function GetInstance() As APROVADOS_SISU
        Return instancia
    End Function
#End Region

#Region "CRUD"

    Public Function Add(ByVal obj As APROVADOS_SISU) As Boolean
        Using sqlCommand As New MySqlCommand()
            Try
                Const _mysql As String = "INSERT INTO `aprovados_sisu` (`instituicao`, `local`, `curso`, `grau`, `nome`, `matricula`) VALUES (@valor1, @valor2, @valor3, @valor4, @valor5, @valor6)"
                sqlCommand.Parameters.AddWithValue("@valor1", obj.Instituicao)
                sqlCommand.Parameters.AddWithValue("@valor2", obj.LocalOferta)
                sqlCommand.Parameters.AddWithValue("@valor3", obj.Curso)
                sqlCommand.Parameters.AddWithValue("@valor4", obj.GrauTurno)
                sqlCommand.Parameters.AddWithValue("@valor5", obj.Nome)
                sqlCommand.Parameters.AddWithValue("@valor6", obj.Matricula)
                sqlCommand.CommandText = _mysql
                Dim d As MySqlCommand = conn.ExecutaQuery(sqlCommand)
                d.ExecuteNonQuery()
                d.Dispose()
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Using

        Return True
    End Function

#End Region

End Class
