Public Class Form1

    Private Sub txtNome_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNome.EditValueChanged
        txtRua.Enabled = True
    End Sub

    Private Sub txtRua_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRua.EditValueChanged
        If (txtNome.Text <> "" And txtRua.Text <> "") Then
            btnAdd.Enabled = True
        Else
            btnAdd.Enabled = False
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'pesquisar se o nome existe
        'se nao existir cadastra
        Dim acao As New ClienteDAO
        Dim c = acao.GetInstance

        c.Nome = txtNome.Text
        c.Rua = txtRua.Text

        Dim b As Boolean

        If b = acao.Verifica(c.Nome) Then
            MsgBox("Cliente já cadastrado!!", vbInformation)
        Else
            b = acao.Add(c)
            If b = True Then
                MsgBox("Cadastro efetuado com sucesso!!", vbInformation)
            End If
        End If

    End Sub
End Class
