Public Class frm_clientes

    Private Sub frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao_banco()
        carregar_dados()
        cmb_selecao.Items.Clear()
        With cmb_selecao.Items
            .Add("CPF")
            .Add("Nome")
        End With
        cmb_selecao.SelectedIndex = 0
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            If txt_nomemp.Text = "" Or txt_cidade.Text = "" Or txt_cpf.Text = "" Or txt_email.Text = "" Or txt_foneres.Text = "" Or txt_cidade.Text = "" Or txt_datanasc.Text = "" Then
                MsgBox("Preencha os dados corretamente")
                Exit Sub
            Else
                sql = "insert into tb_cadastro values ('" & txt_cpf.Text & "', " &
                "'" & txt_nomemp.Text & "', " &
                "'" & txt_end.Text & "', '" & txt_email.Text & "','" & txt_cidade.Text & "', '" & txt_foneres.Text & "','" & txt_datanasc.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados Gravados com sucesso!")
                carregar_dados()
                txt_email.Clear()
                txt_cpf.Clear()
                txt_foneres.Clear()
                txt_nomemp.Clear()
                txt_cidade.Clear()
                txt_end.Clear()
                txt_datanasc.Clear()
                txt_cpf.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao Gravar! CPF JA CADASTRADO!")
        End Try
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            sql = "Select * from tb_cadastro where CPF='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_cpf.Text = rs.Fields(0).Value
                txt_nomemp.Text = rs.Fields(1).Value
                txt_end.Text = rs.Fields(2).Value
                txt_cidade.Text = rs.Fields(4).Value
                txt_foneres.Text = rs.Fields(5).Value
                txt_email.Text = rs.Fields(3).Value
                txt_datanasc.Text = rs.Fields(6).Value
            Else
                txt_nomemp.Focus()
            End If
        Catch ex As Exception
            MsgBox("erro ao processar!")
        End Try
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        sql = "select * from tb_cadastro where " & cmb_selecao.Text & " like '" & txt_busca.Text & "%'"
        rs = db.Execute(sql)
        dgw_dados.Rows.Clear()
        Do While rs.EOF = False
            With dgw_dados
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value)
                rs.MoveNext()
            End With
        Loop
    End Sub
    Private Sub btn_alterar_Click(sender As Object, e As EventArgs) Handles btn_alterar.Click
        If txt_nomemp.Text = "" Or txt_cidade.Text = "" Or txt_cpf.Text = "" Or txt_email.Text = "" Or txt_foneres.Text = "" Or txt_datanasc.Text = "" Or txt_end.Text = "" Then
            MsgBox("Preencha os dados corretamente")
            Exit Sub
        Else
            sql = "update tb_cadastro set Nome='" & txt_nomemp.Text & "', fone_residencial='" & txt_foneres.Text & "', Endereco='" & txt_end.Text & "',  cidade='" & txt_cidade.Text & "', email='" & txt_email.Text & "', datanasc='" & txt_datanasc.Text & "' where CPF='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            MsgBox("dados alterados com sucesso!")
            carregar_dados()
            txt_email.Clear()
            txt_cpf.Clear()
            txt_foneres.Clear()
            txt_nomemp.Clear()
            txt_cidade.Clear()
            txt_end.Clear()
            txt_datanasc.Clear()
            txt_cpf.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub btn_exclui_Click(sender As Object, e As EventArgs) Handles btn_exclui.Click
        If txt_nomemp.Text = "" Or txt_cidade.Text = "" Or txt_cpf.Text = "" Or txt_email.Text = "" Or txt_foneres.Text = "" Or txt_datanasc.Text = "" Or txt_end.Text = "" Then
            MsgBox("Preencha os dados corretamente")
            Exit Sub
        End If
        resp = MsgBox("Deseja excluir este CPF: " & txt_cpf.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            sql = "delete * from tb_cadastro where CPF='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            carregar_dados()
            txt_email.Clear()
            txt_cpf.Clear()
            txt_foneres.Clear()
            txt_nomemp.Clear()
            txt_cidade.Clear()
            txt_end.Clear()
            txt_datanasc.Clear()
            txt_cpf.Focus()
        End If

    End Sub
    'Private Sub dgw_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw_dados.CellContentClick
    'Try
    'With dgw_dados
    ' aux = .CurrentRow.Cells(1).Value.ToString()
    ' If .CurrentRow.Cells(3).Selected = True Then
    ' TabControl1.SelectTab(0)
    'sql = "select * from tb_cadastro where cpf='" & aux & "'"
    ' rs = db.Execute(sql)
    ' txt_cpf.Text = rs.Fields(0).Value
    ' txt_nome.Text = rs.Fields(1).Value
    ' txt_foneres.Text = rs.Fields(2).Value
    '  txt_celular.Text = rs.Fields(3).Value
    'ElseIf .CurrentRow.Cells(4).Selected = True Then
    ' resp = MsgBox("Deseja excluir o cpf:" & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
    ' If resp = MsgBoxResult.Yes Then
    '   sql = "delete * from tb_cadastro where cpf ='" & aux & "'"
    '   rs = db.Execute(sql)
    '    carregar_dados()
    'End If
    'Else
    '  Exit Sub
    '   End If
    '  End With
    'Catch ex As Exception
    '    MsgBox("erro ao processar")
    'End Try
    '  End Sub
End Class