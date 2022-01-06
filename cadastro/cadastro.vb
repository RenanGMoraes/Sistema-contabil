Public Class cadastro
    Private Sub cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao_banco()
        carregar_checkout()
        cmb_buscaout.Items.Clear()
        With cmb_buscaout.Items
            .Add("N_Quarto")
            .Add("CPF")
        End With
        cmb_buscaout.SelectedIndex = 0
    End Sub

    Private Sub txt_nqout_lostfocus(sender As Object, e As EventArgs) Handles txt_nqout.LostFocus
        txt_valortconout.Clear()
        txt_diasout.Clear()
        txt_valortpout.Clear()
        txt_valortconout.Clear()
        txt_valortout.Clear()
        sql = "select * from tb_acrescimo where N_Quarto='" & txt_nqout.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            txt_nomeqout.Text = rs.Fields(1).Value
            txt_cpfout.Text = rs.Fields(2).Value
            txt_nomeout.Text = rs.Fields(3).Value
            txt_dataeout.Text = rs.Fields(9).Value
            txt_datasout.Text = rs.Fields(10).Value
            txt_valordout.Text = rs.Fields(12).Value
            txt_valortconout.Text = rs.Fields(8).Value
        End If
        sql = "select * from tb_movbem where N_Quarto='" & txt_nqout.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            txt_nomeqout.Text = rs.Fields(2).Value
            txt_cpfout.Text = rs.Fields(0).Value
            txt_nomeout.Text = rs.Fields(1).Value
            txt_dataeout.Text = rs.Fields(7).Value
            txt_datasout.Text = rs.Fields(8).Value
            txt_valordout.Text = rs.Fields(6).Value
            txt_valordout.Text = Convert.ToDouble(txt_valordout.Text).ToString("C")
        End If
    End Sub

    Private Sub txt_diasout_Leave(sender As Object, e As EventArgs) Handles txt_diasout.Leave
        Dim dtini As DateTime = txt_dataeout.Text
        Dim dtfim As DateTime = txt_datasout.Text
        txt_diasout.Text = DateDiff(DateInterval.Day, dtini, dtfim).ToString
        txt_valortout.Text = txt_diasout.Text * txt_valordout.Text
        txt_valortout.Text = Convert.ToDouble(txt_valortout.Text).ToString("C")
    End Sub

    Private Sub btn_checkout_Click(sender As Object, e As EventArgs) Handles btn_checkout.Click
        resp = MsgBox("Deseja realmente fechar esta conta, Numero do Quarto: " & txt_nqout.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            sql = "delete * from tb_acrescimo where N_Quarto='" & txt_nqout.Text & "'"
            rs = db.Execute(sql)
            carregar_checkout()
        End If
        sql = "delete * from tb_movbem where N_Quarto='" & txt_nqout.Text & "'"
        rs = db.Execute(sql)
        sql = "update tb_cademp set Estado='Disponivel' where N_Quarto='" & txt_nqout.Text & "'"
        rs = db.Execute(sql)
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub txt_buscaout_TextChanged(sender As Object, e As EventArgs) Handles txt_buscaout.TextChanged
        sql = "select * from tb_acrescimo where " & cmb_buscaout.Text & " like '" & txt_buscaout.Text & "%'"
        rs = db.Execute(sql)
        dgw_checkout.Rows.Clear()
        Do While rs.EOF = False
            With dgw_checkout
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(5).Value, rs.Fields(8).Value)
                rs.MoveNext()
            End With
        Loop
    End Sub

    Private Sub btn_cancelarout_Click(sender As Object, e As EventArgs) Handles btn_cancelarout.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub txt_valortout_lostfocus(sender As Object, e As EventArgs) Handles txt_valortout.LostFocus
        txt_valortpout.Text = txt_valortout.Text + txt_valortconout.Text
    End Sub
End Class