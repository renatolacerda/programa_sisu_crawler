Imports System.Data.SqlServerCe
Imports TestDB.Variaveis

Public Class ClienteDAO
    Implements iDao(Of Cliente)
    Private instancia As New Cliente()

#Region "Construtor"
    Sub New()
        GetInstance()
    End Sub
    Public Function GetInstance() As Cliente
        Return instancia
    End Function
#End Region

#Region "CRUD"

    Public Function Add(ByVal obj As Cliente) As Boolean Implements iDao(Of Cliente).Add
        Using mycommand As New SqlCeCommand()
            Try
                Dim sql As String = "INSERT INTO tbCliente (Nome, Rua) VALUES (@nome, @rua)"
                mycommand.Parameters.AddWithValue("@nome", obj.Nome)
                mycommand.Parameters.AddWithValue("@rua", obj.Rua)
                mycommand.CommandText = sql
                Dim d As SqlCeCommand = conn.ExecutaQuery(mycommand)
                d.ExecuteNonQuery()
                d.Dispose()
                Return True
            Catch ex As Exception
                Debug.Print(ex.Message)
                Return False
            End Try
        End Using

        Return True
    End Function

    Public Function Delete(ByVal obj As Cliente) As Boolean Implements iDao(Of Cliente).Delete
        Using mycommand As New SqlCeCommand()
            Try
                Dim sql As String = "DELETE FROM `tbCliente` WHERE `id` = @id"

                mycommand.Parameters.AddWithValue("@id", obj.IdCliente)
                mycommand.CommandText = sql

                Dim d As SqlCeDataReader = conn.ExecutaDataRead(mycommand)

                d.Dispose()

                Return True
            Catch ex As Exception
                Debug.Print(ex.Message)
                Return False
            End Try
        End Using
    End Function

    Public Function Update(ByVal obj As Cliente) As Boolean Implements iDao(Of Cliente).Update
        Using mycommand As New SqlCeCommand()
            Try
                Dim sql As String = "UPDATE `tbCliente` SET `nome` = @nome WHERE (`rua` = @rua)"

                mycommand.Parameters.AddWithValue("@nome", obj.Nome)
                mycommand.Parameters.AddWithValue("@rua", obj.Rua)

                mycommand.CommandText = sql

                Dim d As SqlCeCommand = conn.ExecutaQuery(mycommand)

                d.ExecuteNonQuery()

                d.Dispose()

                Return True
            Catch ex As Exception
                Debug.Print(ex.Message)
                Return False
            End Try
        End Using
        Return True
    End Function
#End Region
    Public Function Verifica(ByVal nome As String) As Boolean
        Dim listGrid As SqlCeDataReader
        Dim sql As String

        Try
            sql = String.Format("SELECT * FROM tbCliente WHERE Nome = '{0}'", nome)

            listGrid = conn.ExecutaDataRead(sql)

            While (listGrid.HasRows)

            End While

            'If listGrid.HasRows Then

            'Else
            '    Return False
            'End If

            listGrid.Close()

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try

        Return False
    End Function

    Public Function DataGridList() As System.Collections.ArrayList
        Dim listGrid As SqlCeDataReader
        Dim List As New ArrayList
        Dim sql As String

        Try
            sql = "SELECT * FROM tbCliente ORDER BY Nome ASC"

            listGrid = conn.ExecutaDataRead(sql)

            If listGrid.HasRows Then
                For Each l In listGrid
                    List.Add(l)
                Next
            End If

            listGrid.Close()

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try

        Return List
    End Function
End Class

