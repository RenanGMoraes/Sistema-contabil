Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao_banco()
        carregar_baixa()
        cmb_selebaixa.Items.Clear()
        With cmb_selebaixa.Items
            .Add("Cod_Prato")
            .Add("Nome_Prato")
        End With
        cmb_selebaixa.SelectedIndex = 0
    End Sub

    Private Sub txt_nomebem5_LostFocus(sender As Object, e As EventArgs) Handles txt_nomebem5.LostFocus
        Try
            sql = "select * from tb_baixa where Cod_Prato ='" & txt_nomebem5.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_valorbaixa1.Text = rs.Fields(2).Value
                txt_nomemp6.Text = rs.Fields(1).Value
            End If
        Catch ex As Exception
            MsgBox("ERRO!CODIGO NAO LOCALIZADO")
        End Try
    End Sub

    Private Sub btn_gravarbaixa_Click(sender As Object, e As EventArgs) Handles btn_gravarbaixa.Click
        Try
            If txt_nomebem5.Text = "" Or txt_nomemp6.Text = "" Or txt_valorbaixa1.Text = "" Then
                MsgBox("Preencha os dados corretamente")
                Exit Sub
            Else
                sql = "insert into tb_baixa values('" & txt_nomebem5.Text & "', '" & txt_nomemp6.Text & "','" & txt_valorbaixa1.Text & "')"
                rs = db.Execute(sql)
                MsgBox("Prato registrado com sucesso!")
                carregar_baixa()
                txt_nomebem5.Clear()
                txt_nomemp6.Clear()
                txt_valorbaixa1.Clear()
            End If
        Catch ex As Exception
            MsgBox("ERRO CODIGO DO PRATO JA CADASTRADO!")
        End Try

    End Sub

    Private Sub txt_buscabaixa_TextChanged(sender As Object, e As EventArgs) Handles txt_buscabaixa.TextChanged
        sql = "select * from tb_baixa where " & cmb_selebaixa.Text & " like '" & txt_buscabaixa.Text & "%'"
        rs = db.Execute(sql)
        dgw_baixa.Rows.Clear()
        Do While rs.EOF = False
            With dgw_baixa
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value)
                rs.MoveNext()
            End With
        Loop
    End Sub

    Private Sub txt_valorbaixa1_Leave(sender As Object, e As EventArgs) Handles txt_valorbaixa1.Leave
        txt_valorbaixa1.Text = Convert.ToDouble(txt_valorbaixa1.Text).ToString("C")
    End Sub

    Private Sub btn_cancer2_Click(sender As Object, e As EventArgs) Handles btn_cancer2.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub btn_cancelarbaixa_Click(sender As Object, e As EventArgs) Handles btn_cancelarbaixa.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub txt_altali_Click(sender As Object, e As EventArgs) Handles txt_altali.Click
        If txt_nomemp6.Text = "" Or txt_valorbaixa1.Text = "" Then
            MsgBox("Preencha os dados corretamente")
            Exit Sub
        Else
            sql = "update tb_baixa set Nome_Prato='" & txt_nomemp6.Text & "', Valor='" & txt_valorbaixa1.Text & "' where Cod_Prato='" & txt_nomebem5.Text & "'"
            rs = db.Execute(sql)
            MsgBox("DADOS ALTERADOS COM SUCESSO!")
            carregar_baixa()
            txt_nomebem5.Clear()
            txt_nomemp6.Clear()
            txt_valorbaixa1.Clear()
        End If
    End Sub

    Private Sub txt_excali_Click(sender As Object, e As EventArgs) Handles txt_excali.Click
        resp = MsgBox("Deseja excluir este Prato: " & txt_nomebem5.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            sql = "delete * from tb_baixa where Cod_Prato='" & txt_nomebem5.Text & "'"
            rs = db.Execute(sql)
            carregar_baixa()
            txt_nomebem5.Clear()
            txt_nomemp6.Clear()
            txt_valorbaixa1.Clear()
        End If
    End Sub
End Class