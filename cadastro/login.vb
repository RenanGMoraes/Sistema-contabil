Public Class Form11

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        If txt_usu.Text = "" Or txt_senha.Text = "" Then
            MsgBox("Preencha os dados corretamente")
            Exit Sub
        ElseIf txt_usu.Text = "admin" And txt_senha.Text = "admin" Then
            MsgBox("BEM VINDO ADMINISTRADOR")
        Else txt_usu.Text = "select * from tb_login where usuario='" & txt_usu.Text &
            MsgBox("Usuario logado com sucesso")
        End If
        Form5.Show()
        Me.Close()
    End Sub
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao_banco()
    End Sub
End Class