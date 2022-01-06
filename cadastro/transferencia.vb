Public Class form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao_banco()
        carregar_reserva()
        cmb_selres.Items.Clear()
        With cmb_selres.Items
            .Add("N_Quarto")
            .Add("Estado")
        End With
        cmb_selres.SelectedIndex = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If txt_chapao.Text = "" Or txt_doco.Text = "" Or txt_idbemo.Text = "" Or txt_nomempo.Text = "" Or txt_datadest.Text = "" Or txt_descbemo.Text = "" Or txt_idbemo.Text = "" Or cmb_acompanha.Text = "" Then
                MsgBox("Preencha os campos corretamente!")
                Exit Sub
            ElseIf txt_chapao.Text = "Reservado" Then
                MsgBox("QUARTO RESERVADO, ESCOLHA UM QUARTO DISPONIVEL!")
                Exit Sub
            ElseIf txt_chapao.Text = "Ocupado" Then
                MsgBox("QUARTO OCUPADO, ESCOLHA UM QUARTO DISPONIVEL")
                Exit Sub
            Else sql = "insert into tb_transf values('" & txt_cpffff.Text & "','" & txt_nomempo.Text & "','" & txt_idbemo.Text & "','" & txt_nameq.Text & "','" & txt_doco.Text & "','" & txt_chapao.Text & "','" & txt_descbemo.Text & "', " &
            "'" & txt_datadest.Text & "','" & txt_dataex.Text & "','" & cmb_acompanha.Text & "')"
                rs = db.Execute(sql)
                MsgBox("Dados salvos com sucesso!")
            End If
        Catch ex As Exception
            MsgBox("ERRO ID!")
        End Try
        sql = "update tb_transf Set Estado='Reservado' where N_Quarto= '" & txt_idbemo.Text & "'"
        rs = db.Execute(sql)
        sql = "update tb_cademp Set Estado='Reservado' where N_Quarto= '" & txt_idbemo.Text & "'"
        rs = db.Execute(sql)

        carregar_reserva()
        carregar_dadosmov()

        Form5.Show()
        Me.Close()

    End Sub

    Private Sub txt_idbemo_LostFocus(sender As Object, e As EventArgs) Handles txt_idbemo.LostFocus
        Try
            sql = "select * from tb_cademp where N_Quarto='" & txt_idbemo.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_nameq.Text = rs.Fields(1).Value
                txt_doco.Text = rs.Fields(2).Value
                txt_chapao.Text = rs.Fields(4).Value
                txt_descbemo.Text = rs.Fields(3).Value
            End If
        Catch ex As Exception
            MsgBox("ERRO!ID NAO LOCALIZADO")
        End Try
    End Sub

    Private Sub txt_cpffff_LostFocus(sender As Object, e As EventArgs) Handles txt_cpffff.LostFocus
        Try
            sql = "select * from tb_cadastro where cpf='" & txt_cpffff.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_nomempo.Text = rs.Fields(1).Value
            End If
        Catch ex As Exception
            MsgBox("ERRO!ID NAO LOCALIZADO")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub txt_buscare_TextChanged(sender As Object, e As EventArgs) Handles txt_buscare.TextChanged
        sql = "select * from tb_cademp where " & cmb_selres.Text & " like '" & txt_buscare.Text & "%'"
        rs = db.Execute(sql)
        dgw_reserva.Rows.Clear()
        Do While rs.EOF = False
            With dgw_reserva
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                rs.MoveNext()
            End With
        Loop
    End Sub
End Class