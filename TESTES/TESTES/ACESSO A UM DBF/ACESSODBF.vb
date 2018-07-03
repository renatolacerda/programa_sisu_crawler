Imports System.Data.Odbc

Public Class ACESSODBF

    Private Sub btnLerDBF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLerDBF.Click
        Using oConn As New OdbcConnection()
            oConn.ConnectionString = "Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=F:\CORRETORA\;Exclusive=No; Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;Extended Properties=dBASE IV;"
            oConn.Open()
            Dim oCmd As OdbcCommand = oConn.CreateCommand()
            oCmd.CommandText = "SELECT * FROM F:\CORRETORA\ENEM_1902_3ºANO.DBF"
            Dim dt As New DataTable()
            dt.Load(oCmd.ExecuteReader())
            oConn.Close()
            DataGridView1.DataSource = dt
        End Using
    End Sub
End Class
