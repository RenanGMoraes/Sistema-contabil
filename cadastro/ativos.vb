Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao_banco()
    End Sub

    Private Sub btn_cadbens_ativ_Click(sender As Object, e As EventArgs) Handles btn_cadbens_ativ.Click
        Form2.Show()
    End Sub

    Private Sub btn_cadacresc_Click(sender As Object, e As EventArgs) Handles btn_cadacresc.Click
        Form6.Show()
    End Sub

    Private Sub btn_baixaparc_Click(sender As Object, e As EventArgs) Handles btn_baixaparc.Click
        Form8.Show()
    End Sub

    Private Sub btn_transf_ativ_Click(sender As Object, e As EventArgs) Handles btn_transf_ativ.Click
        form9.Show()
    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        cadastro.Show()
    End Sub

    Private Sub btn__Click(sender As Object, e As EventArgs) Handles btn_regcon.Click
        Form3.Show()
    End Sub

    Private Sub btn_cadastrocliente_Click(sender As Object, e As EventArgs) Handles btn_cadastrocliente.Click
        frm_clientes.Show()
    End Sub
End Class