Imports System.Data.SqlServerCe

Public Class ConexaoSDF
    Private mConexao As New SqlCeConnection
    Private mComando As New SqlCeCommand
    Private mDataAdap As New SqlCeDataAdapter
    Private mDataRead As SqlCeDataReader
    Private mDataTable As New DataTable

    Private usuarioServidor As String
    Private usuarioBancoDeDados As String
    Private usuarioLogin As String
    Private usuarioSenha As String
    'TODO: SE DBOFFLINE = TRUE ENTÃO ANOTAR NO BANCO DE DADOS QUE OS DADOS DEVERÃO QUANDO A CONEXÃO VOLTAR GRAVÁ-LOS NA BASE
    'PENSAR QUE O SISTEMA É DISTRIBUIDO E DEVERÁ TOMAR CUIDADO COM OS IDs E QUE ELES NÃO INFLUENCIEM NA CONSISTÊNCIA DA BASE.
#Region "Core"
#Region "Propriedades"
    Public Property ServidorUs() As String
        Get
            Return usuarioServidor
        End Get
        Set(ByVal value As String)
            usuarioServidor = value
        End Set
    End Property
    Public Property BancoDeDadosUs() As String
        Get
            Return usuarioBancoDeDados
        End Get
        Set(ByVal value As String)
            usuarioBancoDeDados = value
        End Set
    End Property
    Public Property LoginUs() As String
        Get
            Return usuarioLogin
        End Get
        Set(ByVal value As String)
            usuarioLogin = value
        End Set
    End Property
    Public Property SenhaUs() As String
        Get
            Return usuarioSenha
        End Get
        Set(ByVal value As String)
            usuarioSenha = value
        End Set
    End Property
#End Region
#Region "Construtor"
    Sub New(ByVal servidor As String, ByVal usuario As String, ByVal senha As String, ByVal bancoDeDados As String)
        ServidorUs = servidor
        LoginUs = usuario
        SenhaUs = senha
        BancoDeDadosUs = bancoDeDados
    End Sub
    Sub New(ByVal bancoDeDados As String)
        BancoDeDadosUs = bancoDeDados
    End Sub
#End Region
#Region "Conecta/Desconecta"
    Public Sub ConectarSQLCe()

        If Not mConexao.State = ConnectionState.Open Then
            Try
                'Dim strConexao As String = "Data Source=" + (String.Format("{0}\\{1}.sdf;Persist Security Info=False;", System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase), BancoDeDadosUs))

                Dim strConexao As String = "Data Source=|DataDirectory|" + BancoDeDadosUs + ".sdf;Persist Security Info=False;"

                mConexao = New SqlCeConnection()
                mConexao.ConnectionString = strConexao
                mConexao.Open()
            Catch ex As SqlCeException
                MsgBox("Não conseguiu acessar a base do Sistema!! : " & ex.Message, vbInformation)
            End Try
        End If
    End Sub
    Public Sub DesconectarSQLCe()
        If mConexao.State = ConnectionState.Open Then
            mConexao.Close()
            mConexao.Dispose()
            mConexao = Nothing
        End If
    End Sub
#End Region
#End Region
#Region "Pesquisas"
    ' Criar função para dar Lock nas tabelas
    Public Function ExecutaDataTable(ByVal sql As String) As DataTable
        mDataTable = Nothing
        Try
            ConectarSQLCe()
            mComando.CommandType = CommandType.Text
            mComando.CommandText = sql
            mComando.Connection = mConexao
            mDataAdap.SelectCommand = mComando
            mDataAdap.Fill(mDataTable)
            Return mDataTable
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try
        Return mDataTable
    End Function
    Public Function ExecutaDataTable(ByVal sql As String, ByVal cmd As SqlCeCommand) As DataTable
        mDataTable = Nothing
        Try
            ConectarSQLCe()
            mComando = cmd
            mComando.CommandType = CommandType.Text
            mComando.CommandText = sql
            mComando.Connection = mConexao
            mDataAdap.SelectCommand = mComando
            mDataAdap.Fill(mDataTable)
            Return mDataTable
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try
        Return mDataTable
    End Function

    Public Function ExecutaDataTable(ByVal cmd As SqlCeCommand) As DataTable

        mDataTable = Nothing
        Try
            ConectarSQLCe()
            mComando = cmd
            mComando.CommandType = CommandType.Text
            mComando.Connection = mConexao
            mDataAdap.SelectCommand = mComando
            mDataAdap.Fill(mDataTable)
            Return mDataTable
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try
        Return mDataTable
    End Function
    Public Sub CloseMDataRead()

        mDataRead.Close()

    End Sub


    Public Function ExecutaDataRead(ByVal sql As String) As SqlCeDataReader
        mDataRead = Nothing

        Try
            ConectarSQLCe()
            mComando.CommandType = CommandType.Text
            mComando.CommandText = sql
            mComando.Connection = mConexao
            mDataRead = mComando.ExecuteReader()
            Return mDataRead
        Catch exSql As SqlCeException
            Debug.Print(exSql.Message)
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
        Return mDataRead
    End Function
    Public Function ExecutaDataRead(ByVal sql As String, ByVal cmd As SqlCeCommand) As SqlCeDataReader
        mDataRead = Nothing

        mDataRead.Close()
        Try
            ConectarSQLCe()
            mComando = cmd
            mComando.CommandType = CommandType.Text
            mComando.CommandText = sql
            mComando.Connection = mConexao
            mDataRead = mComando.ExecuteReader()
            Return mDataRead
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
        Return mDataRead
    End Function
    Public Function ExecutaDataRead(ByVal cmd As SqlCeCommand) As SqlCeDataReader
        mDataRead = Nothing

        Try
            ConectarSQLCe()
            mComando = cmd
            mComando.CommandType = CommandType.Text
            mComando.Connection = mConexao
            mDataRead = mComando.ExecuteReader()
            Return mDataRead
        Catch ex As SqlCeException
            'If ex.Number = 1451 Then
            '    MsgBox("Erro!! Não pode excluir um registro já vinculado em outra tabela!!!", vbCritical)
            'End If
            Debug.Print(ex.ToString)
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try
        Return mDataRead
    End Function
    Public Function ExecutaQuery(ByVal sql As String) As SqlCeCommand
        Try
            ConectarSQLCe()
            mComando.CommandType = CommandType.Text
            mComando.CommandText = sql
            mComando.Connection = mConexao
            Return mComando
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
        Return mComando
    End Function
    Public Function ExecutaQuery(ByVal sql As String, ByVal cmd As SqlCeCommand) As SqlCeCommand
        Try
            ConectarSQLCe()
            mComando = cmd
            mComando.CommandType = CommandType.Text
            mComando.CommandText = sql
            mComando.Connection = mConexao
            Return mComando
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
        Return mComando
    End Function
    Public Function ExecutaQuery(ByVal cmd As SqlCeCommand) As SqlCeCommand
        Try
            ' Criar função para dar Lock nas tabelas
            ConectarSQLCe()
            mComando = cmd
            mComando.CommandType = CommandType.Text
            'mComando.CommandText = sql
            mComando.Connection = mConexao
            Return mComando
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
        Return mComando
    End Function
#End Region

End Class

