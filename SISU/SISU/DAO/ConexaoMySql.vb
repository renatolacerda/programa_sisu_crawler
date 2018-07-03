'Importando MySql e DataSet
Imports MySql.Data.MySqlClient
Imports System.Data.DataSet

Public Class ConexaoMySql
    Private mConexao As New MySqlConnection
    Private mComando As New MySqlCommand
    Private mDataAdap As New MySqlDataAdapter
    Private mDataRead As MySqlDataReader
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
#End Region
#Region "Conecta/Desconecta"
    Public Sub ConectarMySql()

        If Not mConexao.State = ConnectionState.Open Then
            Try
                Dim strConexao As String = "Data Source=" + ServidorUs + ";user id=" + LoginUs + ";password=" + SenhaUs + "; database=" + BancoDeDadosUs + "; Allow User Variables = 'True'; Port = '3305';"
                '; SSL Mode=Required" ';MultipleActiveResultSets=True ;Connection Lifetime=0 ' default command timeout=0;
                mConexao = New MySqlConnection()
                mConexao.ConnectionString = strConexao
                mConexao.Open()
                'DBStatus = True ' variável que controla se a informação está online ou offline
            Catch ex As MySqlException
                Debug.WriteLine(ex.ToString)
                MsgBox("Não conseguiu acessar a base Web do Sistema!! : " & ex.Message, vbInformation)

                'DBStatus = False ' variável que controla se a informação está online ou offline

                'ServidorUs = varServidorUs : LoginUs = varLoginUs : SenhaUs = varSenhaUs : BancoDeDadosUs = varBancoDeDadosUs

                'Dim strConexao As String = "Data Source=" + ServidorUs + ";user id=" + LoginUs + ";password=" + SenhaUs + "; database=" + BancoDeDadosUs
                'mConexao = New MySqlConnection()
                'mConexao.ConnectionString = strConexao
                'mConexao.Open()
            End Try
        End If
    End Sub
    Public Sub DesconectarMySql()
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
            ConectarMySql()
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
    Public Function ExecutaDataTable(ByVal sql As String, ByVal cmd As MySqlCommand) As DataTable
        mDataTable = Nothing
        Try
            ConectarMySql()
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

    Public Function ExecutaDataTable(ByVal cmd As MySqlCommand) As DataTable

        mDataTable = Nothing
        Try
            ConectarMySql()
            mComando = cmd
            mComando.CommandType = CommandType.Text
            'mComando.CommandText = sql
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


    Public Function ExecutaDataRead(ByVal sql As String) As MySqlDataReader
        mDataRead = Nothing

        Try
            ConectarMySql()
            mComando.CommandType = CommandType.Text
            mComando.CommandText = sql
            mComando.Connection = mConexao
            mDataRead = mComando.ExecuteReader()
            Return mDataRead
        Catch exMsql As MySqlException
            Debug.WriteLine(exMsql.ToString)
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try
        Return mDataRead
    End Function
    Public Function ExecutaDataRead(ByVal sql As String, ByVal cmd As MySqlCommand) As MySqlDataReader
        mDataRead = Nothing

        mDataRead.Close()
        Try
            ConectarMySql()
            mComando = cmd
            mComando.CommandType = CommandType.Text
            mComando.CommandText = sql
            mComando.Connection = mConexao
            mDataRead = mComando.ExecuteReader()
            Return mDataRead
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try
        Return mDataRead
    End Function
    Public Function ExecutaDataRead(ByVal cmd As MySqlCommand) As MySqlDataReader
        mDataRead = Nothing

        Try
            ConectarMySql()
            mComando = cmd
            mComando.CommandType = CommandType.Text
            'mComando.CommandText = sql
            mComando.Connection = mConexao
            mDataRead = mComando.ExecuteReader()
            Return mDataRead
        Catch ex As MySqlException
            If ex.Number = 1451 Then
                MsgBox("Erro!! Não pode excluir um registro já vinculado em outra tabela!!!", vbCritical)
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try
        Return mDataRead
    End Function
    Public Function ExecutaQuery(ByVal sql As String) As MySqlCommand
        Try
            ConectarMySql()
            mComando.CommandType = CommandType.Text
            mComando.CommandText = sql
            mComando.Connection = mConexao
            Return mComando
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try
        Return mComando
    End Function
    Public Function ExecutaQuery(ByVal sql As String, ByVal cmd As MySqlCommand) As MySqlCommand
        Try
            ConectarMySql()
            mComando = cmd
            mComando.CommandType = CommandType.Text
            mComando.CommandText = sql
            mComando.Connection = mConexao
            Return mComando
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try
        Return mComando
    End Function
    Public Function ExecutaQuery(ByVal cmd As MySqlCommand) As MySqlCommand
        Try
            ' Criar função para dar Lock nas tabelas
            ConectarMySql()
            mComando = cmd
            mComando.CommandType = CommandType.Text
            'mComando.CommandText = sql
            mComando.Connection = mConexao
            Return mComando
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try
        Return mComando
    End Function
    Public Function LastRecordId(ByVal campo As String, ByVal tabela As String) As Integer
        Dim v As Integer
        Dim _mysql = String.Format("SELECT {0} FROM {1} ORDER BY {0} DESC LIMIT 1", campo, tabela)

        Dim dt As DataTable = ExecutaDataTable(_mysql)

        v = Convert.ToInt16(dt.Rows(0))

        Return v
    End Function
#End Region
End Class

