<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_clientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_clientes))
        Me.tab_cademp = New System.Windows.Forms.TabControl()
        Me.cadbur = New System.Windows.Forms.TabPage()
        Me.txt_datanasc = New System.Windows.Forms.MaskedTextBox()
        Me.btn_exclui = New System.Windows.Forms.Button()
        Me.btn_alterar = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_nomemp = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_end = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.txt_foneres = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listaemp = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dgw_dados = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Selecione = New System.Windows.Forms.Label()
        Me.cmb_selecao = New System.Windows.Forms.ComboBox()
        Me.txt_busca = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.tab_cademp.SuspendLayout()
        Me.cadbur.SuspendLayout()
        Me.listaemp.SuspendLayout()
        CType(Me.dgw_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab_cademp
        '
        Me.tab_cademp.Controls.Add(Me.cadbur)
        Me.tab_cademp.Controls.Add(Me.listaemp)
        Me.tab_cademp.Location = New System.Drawing.Point(2, 2)
        Me.tab_cademp.Name = "tab_cademp"
        Me.tab_cademp.SelectedIndex = 0
        Me.tab_cademp.Size = New System.Drawing.Size(703, 394)
        Me.tab_cademp.TabIndex = 0
        '
        'cadbur
        '
        Me.cadbur.Controls.Add(Me.txt_datanasc)
        Me.cadbur.Controls.Add(Me.btn_exclui)
        Me.cadbur.Controls.Add(Me.btn_alterar)
        Me.cadbur.Controls.Add(Me.Label23)
        Me.cadbur.Controls.Add(Me.Button1)
        Me.cadbur.Controls.Add(Me.Label19)
        Me.cadbur.Controls.Add(Me.txt_nomemp)
        Me.cadbur.Controls.Add(Me.Label10)
        Me.cadbur.Controls.Add(Me.txt_email)
        Me.cadbur.Controls.Add(Me.Label9)
        Me.cadbur.Controls.Add(Me.txt_cidade)
        Me.cadbur.Controls.Add(Me.Label8)
        Me.cadbur.Controls.Add(Me.txt_end)
        Me.cadbur.Controls.Add(Me.Label6)
        Me.cadbur.Controls.Add(Me.btn_gravar)
        Me.cadbur.Controls.Add(Me.txt_foneres)
        Me.cadbur.Controls.Add(Me.Label3)
        Me.cadbur.Controls.Add(Me.txt_cpf)
        Me.cadbur.Controls.Add(Me.Label1)
        Me.cadbur.Location = New System.Drawing.Point(4, 22)
        Me.cadbur.Name = "cadbur"
        Me.cadbur.Padding = New System.Windows.Forms.Padding(3)
        Me.cadbur.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cadbur.Size = New System.Drawing.Size(695, 368)
        Me.cadbur.TabIndex = 0
        Me.cadbur.Text = "Cadastro de Clientes"
        Me.cadbur.UseVisualStyleBackColor = True
        '
        'txt_datanasc
        '
        Me.txt_datanasc.Location = New System.Drawing.Point(253, 234)
        Me.txt_datanasc.Mask = "00/00/0000"
        Me.txt_datanasc.Name = "txt_datanasc"
        Me.txt_datanasc.Size = New System.Drawing.Size(79, 20)
        Me.txt_datanasc.TabIndex = 29
        Me.txt_datanasc.ValidatingType = GetType(Date)
        '
        'btn_exclui
        '
        Me.btn_exclui.Location = New System.Drawing.Point(417, 297)
        Me.btn_exclui.Name = "btn_exclui"
        Me.btn_exclui.Size = New System.Drawing.Size(88, 36)
        Me.btn_exclui.TabIndex = 28
        Me.btn_exclui.Text = "Excluir"
        Me.btn_exclui.UseVisualStyleBackColor = True
        '
        'btn_alterar
        '
        Me.btn_alterar.Location = New System.Drawing.Point(313, 297)
        Me.btn_alterar.Name = "btn_alterar"
        Me.btn_alterar.Size = New System.Drawing.Size(82, 36)
        Me.btn_alterar.TabIndex = 27
        Me.btn_alterar.Text = "Alterar"
        Me.btn_alterar.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label23.Location = New System.Drawing.Point(178, 19)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(327, 28)
        Me.Label23.TabIndex = 26
        Me.Label23.Text = "CADASTRO DE CLIENTES"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(26, 306)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 37)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(250, 218)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 13)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Data de Nascimento"
        '
        'txt_nomemp
        '
        Me.txt_nomemp.Location = New System.Drawing.Point(26, 88)
        Me.txt_nomemp.Name = "txt_nomemp"
        Me.txt_nomemp.Size = New System.Drawing.Size(411, 20)
        Me.txt_nomemp.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Nome do Cliente"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(26, 188)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(374, 20)
        Me.txt_email.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 172)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Email"
        '
        'txt_cidade
        '
        Me.txt_cidade.Location = New System.Drawing.Point(26, 142)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(195, 20)
        Me.txt_cidade.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Cidade"
        '
        'txt_end
        '
        Me.txt_end.Location = New System.Drawing.Point(253, 142)
        Me.txt_end.Name = "txt_end"
        Me.txt_end.Size = New System.Drawing.Size(319, 20)
        Me.txt_end.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(250, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Endereço"
        '
        'btn_gravar
        '
        Me.btn_gravar.Image = CType(resources.GetObject("btn_gravar.Image"), System.Drawing.Image)
        Me.btn_gravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_gravar.Location = New System.Drawing.Point(526, 297)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(83, 36)
        Me.btn_gravar.TabIndex = 10
        Me.btn_gravar.Text = "Gravar"
        Me.btn_gravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_gravar.UseVisualStyleBackColor = True
        '
        'txt_foneres
        '
        Me.txt_foneres.Location = New System.Drawing.Point(26, 234)
        Me.txt_foneres.Mask = "(99)9999-9999"
        Me.txt_foneres.Name = "txt_foneres"
        Me.txt_foneres.Size = New System.Drawing.Size(143, 20)
        Me.txt_foneres.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Telefone"
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(481, 88)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(96, 20)
        Me.txt_cpf.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(478, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPF"
        '
        'listaemp
        '
        Me.listaemp.Controls.Add(Me.Button3)
        Me.listaemp.Controls.Add(Me.Label25)
        Me.listaemp.Controls.Add(Me.dgw_dados)
        Me.listaemp.Controls.Add(Me.Selecione)
        Me.listaemp.Controls.Add(Me.cmb_selecao)
        Me.listaemp.Controls.Add(Me.txt_busca)
        Me.listaemp.Controls.Add(Me.Label5)
        Me.listaemp.Location = New System.Drawing.Point(4, 22)
        Me.listaemp.Name = "listaemp"
        Me.listaemp.Padding = New System.Windows.Forms.Padding(3)
        Me.listaemp.Size = New System.Drawing.Size(695, 368)
        Me.listaemp.TabIndex = 1
        Me.listaemp.Text = "Lista de Clientes"
        Me.listaemp.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(600, 105)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 37)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Cancelar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label25.Location = New System.Drawing.Point(224, 17)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(234, 33)
        Me.Label25.TabIndex = 28
        Me.Label25.Text = "Lista de Clientes"
        '
        'dgw_dados
        '
        Me.dgw_dados.AllowUserToAddRows = False
        Me.dgw_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgw_dados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgw_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgw_dados.Location = New System.Drawing.Point(6, 148)
        Me.dgw_dados.Name = "dgw_dados"
        Me.dgw_dados.ReadOnly = True
        Me.dgw_dados.Size = New System.Drawing.Size(682, 214)
        Me.dgw_dados.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "CPF"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 52
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Nome"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 60
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Cidade"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 65
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Endereço"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 78
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Email"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 57
        '
        'Column6
        '
        Me.Column6.HeaderText = "Telefone"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 74
        '
        'Column7
        '
        Me.Column7.HeaderText = "Data de Nascimento"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 118
        '
        'Selecione
        '
        Me.Selecione.AutoSize = True
        Me.Selecione.Location = New System.Drawing.Point(269, 107)
        Me.Selecione.Name = "Selecione"
        Me.Selecione.Size = New System.Drawing.Size(54, 13)
        Me.Selecione.TabIndex = 3
        Me.Selecione.Text = "Selecione"
        '
        'cmb_selecao
        '
        Me.cmb_selecao.FormattingEnabled = True
        Me.cmb_selecao.Location = New System.Drawing.Point(272, 123)
        Me.cmb_selecao.Name = "cmb_selecao"
        Me.cmb_selecao.Size = New System.Drawing.Size(121, 21)
        Me.cmb_selecao.TabIndex = 2
        '
        'txt_busca
        '
        Me.txt_busca.Location = New System.Drawing.Point(20, 124)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(183, 20)
        Me.txt_busca.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Digite um parâmetro de busca"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frm_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 394)
        Me.Controls.Add(Me.tab_cademp)
        Me.Name = "frm_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE CLIENTES"
        Me.tab_cademp.ResumeLayout(False)
        Me.cadbur.ResumeLayout(False)
        Me.cadbur.PerformLayout()
        Me.listaemp.ResumeLayout(False)
        Me.listaemp.PerformLayout()
        CType(Me.dgw_dados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_cademp As System.Windows.Forms.TabControl
    Friend WithEvents cadbur As System.Windows.Forms.TabPage
    Friend WithEvents txt_cpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents listaemp As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_foneres As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_gravar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgw_dados As System.Windows.Forms.DataGridView
    Friend WithEvents Selecione As System.Windows.Forms.Label
    Friend WithEvents cmb_selecao As System.Windows.Forms.ComboBox
    Friend WithEvents txt_busca As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txt_end As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_nomemp As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label19 As Label
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents Label23 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents btn_alterar As Button
    Friend WithEvents btn_exclui As Button
    Friend WithEvents txt_datanasc As MaskedTextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
