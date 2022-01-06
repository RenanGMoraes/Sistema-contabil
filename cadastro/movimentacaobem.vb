Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao_banco()
        carregar_baixa2()
        cmb_selecao1.Items.Clear()
        With cmb_selecao1.Items
            .Add("Cod_Prato")
            .Add("Nome_Prato")
        End With
        cmb_selecao1.SelectedIndex = 0
    End Sub

    Private Sub txt_busca1_TextChanged(sender As Object, e As EventArgs) Handles txt_busca1.TextChanged
        sql = "select * from tb_baixa where " & cmb_selecao1.Text & " like '" & txt_busca1.Text & "%'"
        rs = db.Execute(sql)
        dgw_movbens.Rows.Clear()
        Do While rs.EOF = False
            With dgw_movbens
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value)
                rs.MoveNext()
            End With
        Loop
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub txt_nquartocon_lostfocus(sender As Object, e As EventArgs) Handles txt_nquartocon.LostFocus
        Try
            sql = "select * from tb_movbem where N_Quarto='" & txt_nquartocon.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_nomeqcon.Text = rs.Fields(3).Value
                txt_cpfcon.Text = rs.Fields(0).Value
                txt_nomecon.Text = rs.Fields(1).Value
                txt_datacon.Text = rs.Fields(7).Value
                txt_dataecon.Text = rs.Fields(8).Value
                txt_valordcon.Text = rs.Fields(6).Value
                txt_acomcon.Text = rs.Fields(9).Value
            End If
        Catch ex As Exception
            MsgBox("QUARTO N ENCONTRADO")
        End Try

    End Sub

    Private Sub txt_nprato_lostfocus(sender As Object, e As EventArgs) Handles txt_nprato.LostFocus
        Try
            sql = "select * from tb_baixa where Cod_Prato='" & txt_nprato.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_nomeprato.Text = rs.Fields(1).Value
                txt_valorp.Text = rs.Fields(2).Value
            End If
        Catch ex As Exception
            MsgBox("PRATO NAO ENCONTRADO")
        End Try

    End Sub

    Private Sub txt_qtd_lostfocus(sender As Object, e As EventArgs) Handles txt_qtd.LostFocus
        txt_valort.Text = txt_qtd.Text * txt_valorp.Text
        txt_valort.Text = Convert.ToDouble(txt_valort.Text).ToString("C")
    End Sub

    Private Sub txt_salvcon_Click(sender As Object, e As EventArgs) Handles txt_salvcon.Click
        Try
            If txt_nquartocon.Text = "" Or txt_nomeqcon.Text = "" Or txt_cpfcon.Text = "" Or txt_nomecon.Text = "" Or txt_nprato.Text = "" Or txt_nomeprato.Text = "" Or txt_qtd.Text = "" Then
                MsgBox("PREENCHA OS DADOS CORRETAMENTE")
                Exit Sub
            Else sql = "insert into tb_acrescimo values('" & txt_nquartocon.Text & "','" & txt_nomeqcon.Text & "','" & txt_cpfcon.Text & "','" & txt_nomecon.Text & "','" & txt_nprato.Text & "','" & txt_nomeprato.Text & "','" & txt_qtd.Text & "','" & txt_valorp.Text & "','" & txt_valort.Text & "','" & txt_datacon.Text & "','" & txt_dataecon.Text & "','" & txt_acomcon.Text & "','" & txt_valordcon.Text & "')"
                rs = db.Execute(sql)
                MsgBox("CONSUMO REGISTRADO COM SUCESSO!")
            End If
        Catch ex As Exception
            MsgBox("DEU ERRO")
        End Try
    End Sub

    Private Sub txt_cancon_Click(sender As Object, e As EventArgs) Handles txt_cancon.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub
End Class