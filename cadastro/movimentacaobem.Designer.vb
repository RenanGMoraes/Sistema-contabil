<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_busca1 = New System.Windows.Forms.TextBox()
        Me.cmb_selecao1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgw_movbens = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab_movbenss = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_valort = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_cancon = New System.Windows.Forms.Button()
        Me.txt_salvcon = New System.Windows.Forms.Button()
        Me.txt_valordcon = New System.Windows.Forms.TextBox()
        Me.txt_acomcon = New System.Windows.Forms.TextBox()
        Me.txt_valorp = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_qtd = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_nomeprato = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_nprato = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_dataecon = New System.Windows.Forms.MaskedTextBox()
        Me.txt_datacon = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nomecon = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_cpfcon = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nomeqcon = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nquartocon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dgw_movbens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_movbenss.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Busca avançada"
        '
        'txt_busca1
        '
        Me.txt_busca1.Location = New System.Drawing.Point(29, 110)
        Me.txt_busca1.Name = "txt_busca1"
        Me.txt_busca1.Size = New System.Drawing.Size(100, 20)
        Me.txt_busca1.TabIndex = 1
        '
        'cmb_selecao1
        '
        Me.cmb_selecao1.FormattingEnabled = True
        Me.cmb_selecao1.Location = New System.Drawing.Point(212, 110)
        Me.cmb_selecao1.Name = "cmb_selecao1"
        Me.cmb_selecao1.Size = New System.Drawing.Size(121, 21)
        Me.cmb_selecao1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Selecione"
        '
        'dgw_movbens
        '
        Me.dgw_movbens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw_movbens.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgw_movbens.Location = New System.Drawing.Point(19, 137)
        Me.dgw_movbens.Name = "dgw_movbens"
        Me.dgw_movbens.Size = New System.Drawing.Size(477, 210)
        Me.dgw_movbens.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "Numero do Prato"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nome do Prato"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Valor Unitario"
        Me.Column3.Name = "Column3"
        '
        'tab_movbenss
        '
        Me.tab_movbenss.Controls.Add(Me.TabPage2)
        Me.tab_movbenss.Controls.Add(Me.TabPage1)
        Me.tab_movbenss.Location = New System.Drawing.Point(12, 12)
        Me.tab_movbenss.Name = "tab_movbenss"
        Me.tab_movbenss.SelectedIndex = 0
        Me.tab_movbenss.Size = New System.Drawing.Size(566, 414)
        Me.tab_movbenss.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txt_valort)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txt_cancon)
        Me.TabPage2.Controls.Add(Me.txt_salvcon)
        Me.TabPage2.Controls.Add(Me.txt_valordcon)
        Me.TabPage2.Controls.Add(Me.txt_acomcon)
        Me.TabPage2.Controls.Add(Me.txt_valorp)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txt_qtd)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txt_nomeprato)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txt_nprato)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txt_dataecon)
        Me.TabPage2.Controls.Add(Me.txt_datacon)
        Me.TabPage2.Controls.Add(Me.txt_nomecon)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txt_cpfcon)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txt_nomeqcon)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txt_nquartocon)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(558, 388)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consumo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(152, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(216, 20)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "REGISTRO DE CONSUMO"
        '
        'txt_valort
        '
        Me.txt_valort.Location = New System.Drawing.Point(195, 281)
        Me.txt_valort.Name = "txt_valort"
        Me.txt_valort.ReadOnly = True
        Me.txt_valort.Size = New System.Drawing.Size(100, 20)
        Me.txt_valort.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(214, 265)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Valor Total"
        '
        'txt_cancon
        '
        Me.txt_cancon.Location = New System.Drawing.Point(36, 326)
        Me.txt_cancon.Name = "txt_cancon"
        Me.txt_cancon.Size = New System.Drawing.Size(101, 39)
        Me.txt_cancon.TabIndex = 22
        Me.txt_cancon.Text = "Cancelar"
        Me.txt_cancon.UseVisualStyleBackColor = True
        '
        'txt_salvcon
        '
        Me.txt_salvcon.Location = New System.Drawing.Point(276, 326)
        Me.txt_salvcon.Name = "txt_salvcon"
        Me.txt_salvcon.Size = New System.Drawing.Size(118, 39)
        Me.txt_salvcon.TabIndex = 21
        Me.txt_salvcon.Text = "Salvar Consumo"
        Me.txt_salvcon.UseVisualStyleBackColor = True
        '
        'txt_valordcon
        '
        Me.txt_valordcon.Location = New System.Drawing.Point(430, 335)
        Me.txt_valordcon.Name = "txt_valordcon"
        Me.txt_valordcon.Size = New System.Drawing.Size(81, 20)
        Me.txt_valordcon.TabIndex = 20
        Me.txt_valordcon.Visible = False
        '
        'txt_acomcon
        '
        Me.txt_acomcon.Location = New System.Drawing.Point(431, 307)
        Me.txt_acomcon.Name = "txt_acomcon"
        Me.txt_acomcon.Size = New System.Drawing.Size(35, 20)
        Me.txt_acomcon.TabIndex = 19
        Me.txt_acomcon.Visible = False
        '
        'txt_valorp
        '
        Me.txt_valorp.Location = New System.Drawing.Point(323, 199)
        Me.txt_valorp.Name = "txt_valorp"
        Me.txt_valorp.ReadOnly = True
        Me.txt_valorp.Size = New System.Drawing.Size(100, 20)
        Me.txt_valorp.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(240, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Valor Unitario"
        '
        'txt_qtd
        '
        Me.txt_qtd.Location = New System.Drawing.Point(122, 196)
        Me.txt_qtd.Name = "txt_qtd"
        Me.txt_qtd.Size = New System.Drawing.Size(31, 20)
        Me.txt_qtd.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(54, 199)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Quantidade"
        '
        'txt_nomeprato
        '
        Me.txt_nomeprato.Location = New System.Drawing.Point(323, 170)
        Me.txt_nomeprato.Name = "txt_nomeprato"
        Me.txt_nomeprato.ReadOnly = True
        Me.txt_nomeprato.Size = New System.Drawing.Size(223, 20)
        Me.txt_nomeprato.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(232, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Nome do Prato"
        '
        'txt_nprato
        '
        Me.txt_nprato.Location = New System.Drawing.Point(122, 170)
        Me.txt_nprato.Name = "txt_nprato"
        Me.txt_nprato.Size = New System.Drawing.Size(31, 20)
        Me.txt_nprato.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Numero do Prato"
        '
        'txt_dataecon
        '
        Me.txt_dataecon.Location = New System.Drawing.Point(431, 281)
        Me.txt_dataecon.Mask = "00/00/0000"
        Me.txt_dataecon.Name = "txt_dataecon"
        Me.txt_dataecon.Size = New System.Drawing.Size(80, 20)
        Me.txt_dataecon.TabIndex = 10
        Me.txt_dataecon.ValidatingType = GetType(Date)
        Me.txt_dataecon.Visible = False
        '
        'txt_datacon
        '
        Me.txt_datacon.Location = New System.Drawing.Point(431, 255)
        Me.txt_datacon.Mask = "00/00/0000"
        Me.txt_datacon.Name = "txt_datacon"
        Me.txt_datacon.Size = New System.Drawing.Size(80, 20)
        Me.txt_datacon.TabIndex = 9
        Me.txt_datacon.ValidatingType = GetType(Date)
        Me.txt_datacon.Visible = False
        '
        'txt_nomecon
        '
        Me.txt_nomecon.Location = New System.Drawing.Point(323, 94)
        Me.txt_nomecon.Name = "txt_nomecon"
        Me.txt_nomecon.ReadOnly = True
        Me.txt_nomecon.Size = New System.Drawing.Size(205, 20)
        Me.txt_nomecon.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(232, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Nome do Cliente"
        '
        'txt_cpfcon
        '
        Me.txt_cpfcon.Location = New System.Drawing.Point(66, 90)
        Me.txt_cpfcon.Mask = "999,999,999-99"
        Me.txt_cpfcon.Name = "txt_cpfcon"
        Me.txt_cpfcon.Size = New System.Drawing.Size(100, 20)
        Me.txt_cpfcon.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "CPF"
        '
        'txt_nomeqcon
        '
        Me.txt_nomeqcon.Location = New System.Drawing.Point(323, 61)
        Me.txt_nomeqcon.Name = "txt_nomeqcon"
        Me.txt_nomeqcon.ReadOnly = True
        Me.txt_nomeqcon.Size = New System.Drawing.Size(205, 20)
        Me.txt_nomeqcon.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(232, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nome do Quarto"
        '
        'txt_nquartocon
        '
        Me.txt_nquartocon.Location = New System.Drawing.Point(122, 61)
        Me.txt_nquartocon.Name = "txt_nquartocon"
        Me.txt_nquartocon.Size = New System.Drawing.Size(28, 20)
        Me.txt_nquartocon.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Numero do Quarto"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.txt_busca1)
        Me.TabPage1.Controls.Add(Me.dgw_movbens)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.cmb_selecao1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(558, 388)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista dos Pratos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(91, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(342, 28)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Lista de Consumo por Quarto"
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(409, 95)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 37)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Cancelar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 428)
        Me.Controls.Add(Me.tab_movbenss)
        Me.Name = "Form3"
        Me.Text = "Consumo"
        CType(Me.dgw_movbens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_movbenss.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_busca1 As TextBox
    Friend WithEvents cmb_selecao1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgw_movbens As DataGridView
    Friend WithEvents tab_movbenss As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_cpfcon As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_nomeqcon As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nquartocon As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_nomecon As TextBox
    Friend WithEvents txt_datacon As MaskedTextBox
    Friend WithEvents txt_dataecon As MaskedTextBox
    Friend WithEvents txt_nprato As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents txt_valort As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_cancon As Button
    Friend WithEvents txt_salvcon As Button
    Friend WithEvents txt_valordcon As TextBox
    Friend WithEvents txt_acomcon As TextBox
    Friend WithEvents txt_valorp As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_qtd As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_nomeprato As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
End Class
