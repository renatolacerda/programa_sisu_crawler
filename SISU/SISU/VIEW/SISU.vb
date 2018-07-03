Public Class SISU
    Dim myarray As New ArrayList
    Dim urlindex As Integer
    Dim valorIni As Integer
    Dim valorFim As Integer
    Dim sPause = False
    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        If btnImportar.Text = "Cancelar" Then
            urlindex = myarray.Count
            btnImportar.Text = "Importar Aprovados"
            txtInicio.Text = Nothing
            txtFim.Text = Nothing
            txtInicio.Focus()
            btnImportar.Enabled = False
            Exit Sub
        End If
        'http://sisu.mec.gov.br/selecionados?co_oferta=60102
        'DESLIGA O JAVASCRIPT
        wb.ScriptErrorsSuppressed = True
        'Patâmetros Iniciais
        valorIni = txtInicio.Text
        valorFim = txtFim.Text

        Debug.Print("valorIni:" & valorIni & "  |  " & "valorFim:" & valorFim)

        With Barra
            .Minimum = valorIni
            .Maximum = valorFim
            .Value = valorIni
        End With

        txtInicio.Enabled = False
        txtFim.Enabled = False

        'fazer loop
        Dim x As Integer
        Try
            urlindex = 0
            For x = valorIni To valorFim '60001

                myarray.Add("http://sisu.mec.gov.br/selecionados?co_oferta=" & Convert.ToString(x))
                'Debug.Print("http://sisu.mec.gov.br/selecionados?co_oferta=" & Convert.ToString(x))
                'Debug.Print("==============================")

            Next
            NavigateToNextUrl()
        Catch err1 As ObjectDisposedException
            'MsgBox(err1.InnerException)
        Catch err2 As InvalidOperationException
            'MsgBox(err2.InnerException)
        End Try
        btnImportar.Text = "Cancelar"
    End Sub
    Private Sub NavigateToNextUrl()
        'Continue only if there is a page pending.
        Try
            If urlindex < myarray.Count - 1 Then
                'Debug.Print("==============================")
                'Debug.Print(urlindex & "<" & myarray.Count - 1)
                'Debug.Print("==============================")
                While Not (sPause)
                    wb.Navigate(myarray(urlindex))
                    urlindex += 1
                    
                    'Debug.Print(urlindex)
                    'Debug.Print("==============================")
                    'Debug.Print(myarray(urlindex))
                    'Debug.Print("==============================")

                    lblContador.Text = urlindex + txtInicio.Text
                End While
            ElseIf urlindex = myarray.Count Then
                MsgBox("Processo finalizado!!", vbInformation)
                txtInicio.Enabled = True
                txtFim.Enabled = True
                lblContador.Text = ""
                btnImportar.Text = "Importar"
                txtInicio.Text = Nothing
                txtFim.Text = Nothing
                txtInicio.Focus()
                btnImportar.Enabled = False
            End If
        Catch ex As ArgumentOutOfRangeException
            MsgBox("Processo Finalizado")
        End Try
        
    End Sub

    Private Sub wb_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles wb.DocumentCompleted
        Dim acao As New APROVADOS_SISUDAO
        Dim ap = APROVADOS_SISUDAO.GetInstance

        If wb.ReadyState = WebBrowserReadyState.Complete Then
            'Process the page just loaded here.

            'Load the next page.
            Barra.Value += 1
            NavigateToNextUrl()
        End If
        ' Limpa Textos
        txtCurso.Text = ""
        txtGrau.Text = ""
        txtInscricao.Text = ""
        txtInstituicao.Text = ""
        txtLocal.Text = ""
        txtNome.Text = ""

        Dim PE2 As HtmlElementCollection = wb.Document.GetElementsByTagName("DIV")
        For Each c2 As HtmlElement In PE2
            If c2.GetAttribute("className") = "nome_ies_p" Then txtInstituicao.Text = c2.GetAttribute("InnerText")
            If c2.GetAttribute("className") = "nome_curso_p" Then txtCurso.Text = c2.GetAttribute("InnerText")
            If c2.GetAttribute("className") = "grau_turno_p" Then txtGrau.Text = c2.GetAttribute("InnerText")
            If c2.GetAttribute("className") = "nome_campus_p" Then txtLocal.Text = c2.GetAttribute("InnerText")

        Next

        ' Pega Nome e Inscrição
        Dim PE As HtmlElementCollection = wb.Document.GetElementsByTagName("td") '("span")

        For Each c1 As HtmlElement In PE

            If c1.OuterHtml.Contains("TD") And c1.GetAttribute("className") = "no_candidato" Then
                txtNome.Text = c1.GetAttribute("InnerText")
            ElseIf c1.OuterHtml.Contains("TD") And c1.GetAttribute("className") = "nu_enem" Then
                txtInscricao.Text = c1.GetAttribute("InnerText")
                'Grava(dados)
                ap.Curso = txtCurso.Text
                ap.GrauTurno = txtGrau.Text
                ap.Instituicao = txtInstituicao.Text
                ap.LocalOferta = txtLocal.Text
                ap.Matricula = txtInscricao.Text
                ap.Nome = txtNome.Text

                acao.Add(ap)

            End If

        Next
    End Sub
    Public Function GetElementsByClassName(ByVal htmlDoc As HtmlDocument, ByVal className As String) As List(Of HtmlElement)
        Dim elemList As New List(Of HtmlElement)
        className = className.ToLower()
        For Each elem As HtmlElement In htmlDoc.All
            If elem.GetAttribute("class").ToLower() = className Then
                elemList.Add(elem)
            End If
        Next
        Return elemList
    End Function

    
    Private Sub txtInicio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInicio.TextChanged, txtFim.TextChanged
        If txtInicio.Text <> "" And txtFim.Text <> "" Then
            btnImportar.Enabled = True
        End If
    End Sub

    Private Sub btnPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPause.Click
        If sPause = False Then
            sPause = True
            btnPause.Text = "||"
        Else
            sPause = False
            btnPause.Text = ">"
        End If
    End Sub
End Class
