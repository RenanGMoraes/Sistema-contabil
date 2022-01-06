Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao_banco()
        carregar_dadosacre()
        cmb_selecao3.Items.Clear()
        With cmb_selecao3.Items
            .Add("N_Quarto")
            .Add("Estado")
        End With

    End Sub

    Private Sub txt_idbem3_LostFocus(sender As Object, e As EventArgs) Handles txt_idbem3.LostFocus
        Try
            sql = "select * from tb_transf where N_Quarto='" & txt_idbem3.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_nomebem2.Text = rs.Fields(3).Value
                txt_cpfress.Text = rs.Fields(0).Value
                txt_nomep5.Text = rs.Fields(1).Value
                txt_descacre.Text = rs.Fields(4).Value
                txt_grupoacre.Text = rs.Fields(5).Value
                txt_valoracre.Text = rs.Fields(6).Value
                txt_dataquiacre.Text = rs.Fields(7).Value
                txt_dateres.Text = rs.Fields(8).Value
                cmb_acomres.Text = rs.Fields(9).Value
            End If
        Catch ex As Exception
            MsgBox("ERRO!BEM JA DEU BAIXA")
        End Try
    End Sub

    Private Sub btn_salvaracre_Click(sender As Object, e As EventArgs) Handles btn_salvaracre.Click
        Try
            If txt_nomep5.Text = "" Or txt_idbem3.Text = "" Or txt_nomebem2.Text = "" Or txt_descacre.Text = "" Or txt_dataquiacre.Text = "" Or txt_valoracre.Text = "" Or txt_grupoacre.Text = "" Then
                MsgBox("Preencha os dados corretamente")
                Exit Sub
            Else
                sql = "insert into tb_movbem values('" & txt_cpfress.Text & "','" & txt_nomep5.Text & "','" & txt_idbem3.Text & "','" & txt_nomebem2.Text & "','" & txt_descacre.Text & "','" & txt_grupoacre.Text & "', " &
                "'" & txt_valoracre.Text & "','" & txt_dataquiacre.Text & "','" & txt_dateres.Text & "','" & cmb_acomres.Text & "')"
                rs = db.Execute(sql)
                MsgBox("Salvo com sucesso!")
            End If
        Catch ex As Exception
            MsgBox("ERRO!")
        End Try
        sql = "update tb_cademp Set Estado='Ocupado' where N_Quarto='" & txt_idbem3.Text & "'"
        rs = db.Execute(sql)
        sql = "update tb_movbem set Estado='Ocupado' where N_Quarto='" & txt_idbem3.Text & "'"
        rs = db.Execute(sql)
        sql = "delete * from tb_transf where N_Quarto='" & txt_idbem3.Text & "'"
        rs = db.Execute(sql)
        carregar_dadosacre()
        carregar_dadosmov()
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub btn_buscar3_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar3.TextChanged
        sql = "select * from tb_transf where " & cmb_selecao3.Text & " like '" & txt_buscar3.Text & "%'"
        rs = db.Execute(sql)
        dgw_dadosacre.Rows.Clear()
        Do While rs.EOF = False
            With dgw_dadosacre
                .Rows.Add(rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(5).Value, rs.Fields(7).Value, rs.Fields(8).Value)
                rs.MoveNext()
            End With
        Loop
    End Sub
    Private Sub txt_valoracre_Leave(sender As Object, e As EventArgs) Handles txt_valoracre.Leave
        txt_valoracre.Text = Convert.ToDouble(txt_valoracre.Text).ToString("C")
    End Sub

    Private Sub btn_canceacre_Click(sender As Object, e As EventArgs) Handles btn_canceacre.Click
        resp = MsgBox("Deseja excluir esta RESERVA: Numero do Quarto" & txt_idbem3.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            sql = "delete * from tb_transf where N_Quarto='" & txt_idbem3.Text & "'"
            rs = db.Execute(sql)
        End If
        sql = "update tb_cademp set Estado='Disponivel' where N_Quarto='" & txt_idbem3.Text & "'"
        rs = db.Execute(sql)
        carregar_dadosacre()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
        Me.Close()
    End Sub
End Class