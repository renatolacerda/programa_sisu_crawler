Imports System.Data.Odbc

Public Class DATAGRID_VIA_COD

    Private Sub btnLerDBF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLerDBF.Click
        Using oConn As New OdbcConnection()
            oConn.ConnectionString = "Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=F:\CORRETORA\;Exclusive=No; Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;Extended Properties=dBASE IV;"
            oConn.Open()
            Dim oCmd As OdbcCommand = oConn.CreateCommand()
            'oCmd.CommandText = "SELECT * FROM F:\CORRETORA\ENEM_1902_3ºANO.DBF"
            oCmd.CommandText = "SELECT * FROM F:\CORRETORA\FEPECS_JUNDIAI_0409.DBF"
            Dim dt As New DataTable()
            dt.Load(oCmd.ExecuteReader())
            oConn.Close()
            dg.DataSource = dt

            ' Adiciona Coluna Nome
            dg.Columns.Add("Aluno", "Aluno")
            dg.Columns("Aluno").DisplayIndex = 1

            'Remove a Coluna Flags
            dg.Columns.Remove("Flags")

            Dim texto As String = Nothing
            'percorre cada linha do DataGridView
            For Each linha As DataGridViewRow In dg.Rows

                'percorre cada célula da linha
                For Each celula As DataGridViewCell In dg.Rows(linha.Index).Cells

                    'MsgBox(dg.Columns(celula.ColumnIndex).Name)

                    If celula.ColumnIndex = 0 Then
                        texto = celula.Value.ToString.ToLower
                        If texto.Contains("?") Then
                            dg.Rows(celula.RowIndex).DefaultCellStyle.BackColor = Color.Green
                            texto = Nothing
                        End If
                    End If

                    'se a coluna for a coluna 3 (Idioma) então verifica o criterio
                    If celula.ColumnIndex = 3 Then
                        texto = celula.Value.ToString.ToLower
                        'se o texto informado estiver contido na célula então seleciona toda linha
                        If texto.Contains("*") Then
                            'seleciona a linha
                            'dg.Rows(celula.RowIndex).Selected = True
                            dg.Rows(celula.RowIndex).DefaultCellStyle.BackColor = Color.DarkRed
                            celula.Value = 1
                            'Exit Sub
                            texto = Nothing
                        End If
                    End If
                Next
            Next

        End Using
    End Sub
End Class
