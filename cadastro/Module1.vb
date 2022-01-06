Module Module1
    Public rs As New ADODB.Recordset
    Public db As New ADODB.Connection
    Public sql, diretorio, resp, aux As String
    Public conexao = Application.StartupPath & "\banco_dados\cadastro.mdb"
    Public cont, i As Long
    Public res, n1, n2 As Double
    Sub conexao_banco()
        'string de conexão access
        Try
            db = CreateObject("ADODB.Connection")
            'Banco access extensão MDB
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data source=" & conexao)
            'Banco Access extensão ACCDB
            'db.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" & conexao)
        Catch ex As Exception
            MsgBox("Erro ao conectar")
        End Try
    End Sub


    Sub carregar_dados()

        sql = "select * from tb_cadastro order by Nome asc"
        rs = db.Execute(sql)
        frm_clientes.dgw_dados.Rows.Clear()
        Do While rs.EOF = False
            With frm_clientes.dgw_dados
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value)
                rs.MoveNext()
            End With
        Loop
    End Sub
    Sub carregar_dadosmov()

        sql = "select * from tb_cademp order by N_Quarto asc"
        rs = db.Execute(sql)
        Form2.dgw_listabens.Rows.Clear()
        Do While rs.EOF = False
            With Form2.dgw_listabens
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                rs.MoveNext()
            End With
        Loop
    End Sub
    Sub carregar_dadosbens()
        sql = "select * from tb_movbem order by nomemp asc"
        rs = db.Execute(sql)
        Form3.dgw_movbens.Rows.Clear()
        Do While rs.EOF = False
            With Form3.dgw_movbens
                .Rows.Add(rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(8).Value, rs.Fields(15).Value)
                rs.MoveNext()
            End With
        Loop
    End Sub
    Sub carregar_dadosacre()
        sql = "select * from tb_transf order by N_Quarto asc"
        rs = db.Execute(sql)
        Form6.dgw_dadosacre.Rows.Clear()
        Do While rs.EOF = False
            With Form6.dgw_dadosacre
                .Rows.Add(rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(5).Value, rs.Fields(7).Value, rs.Fields(8).Value)
                rs.MoveNext()
            End With
        Loop
    End Sub
    Sub carregar_baixa()
        sql = "select * from tb_baixa order by Cod_Prato asc"
        rs = db.Execute(sql)
        Form8.dgw_baixa.Rows.Clear()
        Do While rs.EOF = False
            With Form8.dgw_baixa
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value)
                rs.MoveNext()
            End With
        Loop
    End Sub
    Sub carregar_reserva()
        sql = "select * from tb_cademp order by N_Quarto asc"
        rs = db.Execute(sql)
        form9.dgw_reserva.Rows.Clear()
        Do While rs.EOF = False
            With form9.dgw_reserva
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                rs.MoveNext()
            End With
        Loop
    End Sub
    Sub carregar_baixa2()
        sql = "select * from tb_baixa order by Cod_Prato asc"
        rs = db.Execute(sql)
        Form3.dgw_movbens.Rows.Clear()
        Do While rs.EOF = False
            With Form3.dgw_movbens
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value)
                rs.MoveNext()
            End With
        Loop
    End Sub
    Sub carregar_checkout()
        sql = "select * from tb_acrescimo order by N_Quarto asc"
        rs = db.Execute(sql)
        cadastro.dgw_checkout.Rows.Clear()
        Do While rs.EOF = False
            With cadastro.dgw_checkout
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(5).Value, rs.Fields(8).Value)
                rs.MoveNext()
            End With
        Loop
    End Sub
End Module