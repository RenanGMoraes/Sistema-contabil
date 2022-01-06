Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao_banco()
        carregar_dadosmov()
        cmb_selq.Items.Clear()
        With cmb_selq.Items
            .Add("N_Quarto")
            .Add("Estado")
        End With
        cmb_selq.SelectedIndex = 0
    End Sub

    Private Sub btn_salvar1_Click(sender As Object, e As EventArgs) Handles btn_salvar1.Click
        Try
            If txt_id2.Text = "" Or txt_nomemp3.Text = "" Or txt_descbem.Text = "" Or txt_valorbaixa2.Text = "" Or txt_local.Text = "" Or txt_datacorre.Text = "" Then
                MsgBox("Preencha os dados Corretamente")
                Exit Sub
            ElseIf txt_local.Text = "Ocupado" Then
                MsgBox("QUARTO JA OCUPADO, ESCOLHA UM QUARTO DISPONIVEL!")
                Exit Sub
            ElseIf txt_local.Text = "Reservado" Then
                MsgBox("QUARTO JA RESERVADO, ESCOLHA UM QUARTO DISPONIVEL!")
                Exit Sub
            Else sql = "insert into tb_movbem values ('" & txt_cpff.Text & "','" & txt_descbem.Text & "','" & txt_id2.Text & "','" & txt_nomemp3.Text & "', '" & txt_tipocomp.Text & "','" & txt_local.Text & "','" & txt_valorbaixa2.Text & "','" & txt_datacorre.Text & "','" & txt_databaixa1.Text & "','" & cmb_acomp.Text & "')"
                MsgBox("Check-In feito com sucesso!")
                rs = db.Execute(sql)
            End If
        Catch ex As Exception
            MsgBox("ERRO QUARTO JA EM USO!")
        End Try
        sql = "update tb_cademp set Estado='Ocupado' where N_Quarto='" & txt_id2.Text & "'"
        rs = db.Execute(sql)
        carregar_dadosmov()
        Form5.Show()
        Me.Close()
    End Sub
    Private Sub txt_id2_lostfocus(sender As Object, e As EventArgs) Handles txt_id2.LostFocus
        sql = "Select * from tb_cademp where N_Quarto='" & txt_id2.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            txt_nomemp3.Text = rs.Fields(1).Value
            txt_tipocomp.Text = rs.Fields(2).Value
            txt_local.Text = rs.Fields(4).Value
            txt_valorbaixa2.Text = rs.Fields(3).Value
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub btn_cancelar1_Click(sender As Object, e As EventArgs) Handles btn_cancelar1.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub txt_valorbaixa2_Leave(sender As Object, e As EventArgs) Handles txt_valorbaixa2.Leave
        txt_valorbaixa2.Text = Convert.ToDouble(txt_valorbaixa2.Text).ToString("C")
    End Sub

    Private Sub txt_buscaq_TextChanged(sender As Object, e As EventArgs) Handles txt_buscaq.TextChanged
        sql = "select * from tb_cademp where " & cmb_selq.Text & " like '" & txt_buscaq.Text & "%'"
        rs = db.Execute(sql)
        dgw_listabens.Rows.Clear()
        Do While rs.EOF = False
            With dgw_listabens
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                rs.MoveNext()
            End With
        Loop
    End Sub

    Private Sub txt_cpff_LostFocus(sender As Object, e As EventArgs) Handles txt_cpff.LostFocus
        Try
            sql = "Select * from tb_cadastro where cpf='" & txt_cpff.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_descbem.Text = rs.Fields(1).Value
            Else
                txt_descbem.Focus()
            End If
        Catch ex As Exception
            MsgBox("erro ao processar!")
        End Try
    End Sub
End Class

