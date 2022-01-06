<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_cadacresc = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmb_acomres = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_dateres = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpfress = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_dataquiacre = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_valoracre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_grupoacre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_descacre = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_canceacre = New System.Windows.Forms.Button()
        Me.btn_salvaracre = New System.Windows.Forms.Button()
        Me.txt_nomebem2 = New System.Windows.Forms.TextBox()
        Me.txt_nomep5 = New System.Windows.Forms.TextBox()
        Me.txt_idbem3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tab_lstacresc = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_selecao3 = New System.Windows.Forms.ComboBox()
        Me.txt_buscar3 = New System.Windows.Forms.TextBox()
        Me.dgw_dadosacre = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tab_cadacresc.SuspendLayout()
        Me.tab_lstacresc.SuspendLayout()
        CType(Me.dgw_dadosacre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_cadacresc)
        Me.TabControl1.Controls.Add(Me.tab_lstacresc)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(807, 427)
        Me.TabControl1.TabIndex = 0
        '
        'tab_cadacresc
        '
        Me.tab_cadacresc.Controls.Add(Me.Button2)
        Me.tab_cadacresc.Controls.Add(Me.Label15)
        Me.tab_cadacresc.Controls.Add(Me.cmb_acomres)
        Me.tab_cadacresc.Controls.Add(Me.Label6)
        Me.tab_cadacresc.Controls.Add(Me.txt_dateres)
        Me.tab_cadacresc.Controls.Add(Me.txt_cpfress)
        Me.tab_cadacresc.Controls.Add(Me.Label4)
        Me.tab_cadacresc.Controls.Add(Me.txt_dataquiacre)
        Me.tab_cadacresc.Controls.Add(Me.Label7)
        Me.tab_cadacresc.Controls.Add(Me.txt_valoracre)
        Me.tab_cadacresc.Controls.Add(Me.Label5)
        Me.tab_cadacresc.Controls.Add(Me.txt_grupoacre)
        Me.tab_cadacresc.Controls.Add(Me.Label3)
        Me.tab_cadacresc.Controls.Add(Me.Label14)
        Me.tab_cadacresc.Controls.Add(Me.txt_descacre)
        Me.tab_cadacresc.Controls.Add(Me.Label13)
        Me.tab_cadacresc.Controls.Add(Me.Label11)
        Me.tab_cadacresc.Controls.Add(Me.btn_canceacre)
        Me.tab_cadacresc.Controls.Add(Me.btn_salvaracre)
        Me.tab_cadacresc.Controls.Add(Me.txt_nomebem2)
        Me.tab_cadacresc.Controls.Add(Me.txt_nomep5)
        Me.tab_cadacresc.Controls.Add(Me.txt_idbem3)
        Me.tab_cadacresc.Controls.Add(Me.Label2)
        Me.tab_cadacresc.Controls.Add(Me.Label1)
        Me.tab_cadacresc.Location = New System.Drawing.Point(4, 22)
        Me.tab_cadacresc.Name = "tab_cadacresc"
        Me.tab_cadacresc.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_cadacresc.Size = New System.Drawing.Size(799, 401)
        Me.tab_cadacresc.TabIndex = 0
        Me.tab_cadacresc.Text = "Cadastro de Acrescimo"
        Me.tab_cadacresc.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(382, 232)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Acompanhantes"
        '
        'cmb_acomres
        '
        Me.cmb_acomres.FormattingEnabled = True
        Me.cmb_acomres.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.cmb_acomres.Location = New System.Drawing.Point(472, 228)
        Me.cmb_acomres.Name = "cmb_acomres"
        Me.cmb_acomres.Size = New System.Drawing.Size(140, 21)
        Me.cmb_acomres.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(137, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Data de Saida"
        '
        'txt_dateres
        '
        Me.txt_dateres.Location = New System.Drawing.Point(139, 229)
        Me.txt_dateres.Mask = "00/00/0000"
        Me.txt_dateres.Name = "txt_dateres"
        Me.txt_dateres.Size = New System.Drawing.Size(82, 20)
        Me.txt_dateres.TabIndex = 16
        Me.txt_dateres.ValidatingType = GetType(Date)
        '
        'txt_cpfress
        '
        Me.txt_cpfress.Location = New System.Drawing.Point(73, 120)
        Me.txt_cpfress.Mask = "999,999,999-99"
        Me.txt_cpfress.Name = "txt_cpfress"
        Me.txt_cpfress.ReadOnly = True
        Me.txt_cpfress.Size = New System.Drawing.Size(100, 20)
        Me.txt_cpfress.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Data Entrada"
        '
        'txt_dataquiacre
        '
        Me.txt_dataquiacre.Location = New System.Drawing.Point(41, 229)
        Me.txt_dataquiacre.Mask = "00/00/0000"
        Me.txt_dataquiacre.Name = "txt_dataquiacre"
        Me.txt_dataquiacre.ReadOnly = True
        Me.txt_dataquiacre.Size = New System.Drawing.Size(76, 20)
        Me.txt_dataquiacre.TabIndex = 1
        Me.txt_dataquiacre.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(422, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Estado"
        '
        'txt_valoracre
        '
        Me.txt_valoracre.Location = New System.Drawing.Point(54, 303)
        Me.txt_valoracre.Name = "txt_valoracre"
        Me.txt_valoracre.ReadOnly = True
        Me.txt_valoracre.Size = New System.Drawing.Size(148, 20)
        Me.txt_valoracre.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Valor da Diaria"
        '
        'txt_grupoacre
        '
        Me.txt_grupoacre.Location = New System.Drawing.Point(476, 161)
        Me.txt_grupoacre.Name = "txt_grupoacre"
        Me.txt_grupoacre.ReadOnly = True
        Me.txt_grupoacre.Size = New System.Drawing.Size(136, 20)
        Me.txt_grupoacre.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(385, 123)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Nome do Cliente"
        '
        'txt_descacre
        '
        Me.txt_descacre.Location = New System.Drawing.Point(73, 164)
        Me.txt_descacre.Name = "txt_descacre"
        Me.txt_descacre.ReadOnly = True
        Me.txt_descacre.Size = New System.Drawing.Size(104, 20)
        Me.txt_descacre.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(385, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Nome do Quarto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label11.Location = New System.Drawing.Point(228, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(278, 28)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "CHECK IN - RESERVA"
        '
        'btn_canceacre
        '
        Me.btn_canceacre.Image = CType(resources.GetObject("btn_canceacre.Image"), System.Drawing.Image)
        Me.btn_canceacre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_canceacre.Location = New System.Drawing.Point(527, 331)
        Me.btn_canceacre.Name = "btn_canceacre"
        Me.btn_canceacre.Size = New System.Drawing.Size(116, 31)
        Me.btn_canceacre.TabIndex = 11
        Me.btn_canceacre.Text = "Cancelar Reserva"
        Me.btn_canceacre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_canceacre.UseVisualStyleBackColor = True
        '
        'btn_salvaracre
        '
        Me.btn_salvaracre.Image = CType(resources.GetObject("btn_salvaracre.Image"), System.Drawing.Image)
        Me.btn_salvaracre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salvaracre.Location = New System.Drawing.Point(401, 331)
        Me.btn_salvaracre.Name = "btn_salvaracre"
        Me.btn_salvaracre.Size = New System.Drawing.Size(105, 31)
        Me.btn_salvaracre.TabIndex = 10
        Me.btn_salvaracre.Text = "Salvar"
        Me.btn_salvaracre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salvaracre.UseVisualStyleBackColor = True
        '
        'txt_nomebem2
        '
        Me.txt_nomebem2.Location = New System.Drawing.Point(476, 84)
        Me.txt_nomebem2.Name = "txt_nomebem2"
        Me.txt_nomebem2.ReadOnly = True
        Me.txt_nomebem2.Size = New System.Drawing.Size(253, 20)
        Me.txt_nomebem2.TabIndex = 5
        '
        'txt_nomep5
        '
        Me.txt_nomep5.Location = New System.Drawing.Point(476, 120)
        Me.txt_nomep5.Name = "txt_nomep5"
        Me.txt_nomep5.ReadOnly = True
        Me.txt_nomep5.Size = New System.Drawing.Size(253, 20)
        Me.txt_nomep5.TabIndex = 4
        '
        'txt_idbem3
        '
        Me.txt_idbem3.Location = New System.Drawing.Point(107, 80)
        Me.txt_idbem3.Name = "txt_idbem3"
        Me.txt_idbem3.Size = New System.Drawing.Size(32, 20)
        Me.txt_idbem3.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cod Quarto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPF"
        '
        'tab_lstacresc
        '
        Me.tab_lstacresc.Controls.Add(Me.Button1)
        Me.tab_lstacresc.Controls.Add(Me.Label12)
        Me.tab_lstacresc.Controls.Add(Me.Label10)
        Me.tab_lstacresc.Controls.Add(Me.cmb_selecao3)
        Me.tab_lstacresc.Controls.Add(Me.txt_buscar3)
        Me.tab_lstacresc.Controls.Add(Me.dgw_dadosacre)
        Me.tab_lstacresc.Controls.Add(Me.Label9)
        Me.tab_lstacresc.Location = New System.Drawing.Point(4, 22)
        Me.tab_lstacresc.Name = "tab_lstacresc"
        Me.tab_lstacresc.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_lstacresc.Size = New System.Drawing.Size(799, 401)
        Me.tab_lstacresc.TabIndex = 1
        Me.tab_lstacresc.Text = "Lista de Quartos Reservados"
        Me.tab_lstacresc.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(649, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 31)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label12.Location = New System.Drawing.Point(200, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(343, 28)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Lista dos Quartos Reservados"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(386, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Metodo de Busca"
        '
        'cmb_selecao3
        '
        Me.cmb_selecao3.FormattingEnabled = True
        Me.cmb_selecao3.Location = New System.Drawing.Point(389, 118)
        Me.cmb_selecao3.Name = "cmb_selecao3"
        Me.cmb_selecao3.Size = New System.Drawing.Size(121, 21)
        Me.cmb_selecao3.TabIndex = 3
        '
        'txt_buscar3
        '
        Me.txt_buscar3.Location = New System.Drawing.Point(51, 119)
        Me.txt_buscar3.Name = "txt_buscar3"
        Me.txt_buscar3.Size = New System.Drawing.Size(176, 20)
        Me.txt_buscar3.TabIndex = 2
        '
        'dgw_dadosacre
        '
        Me.dgw_dadosacre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw_dadosacre.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column3, Me.Column1, Me.Column2})
        Me.dgw_dadosacre.Location = New System.Drawing.Point(6, 145)
        Me.dgw_dadosacre.Name = "dgw_dadosacre"
        Me.dgw_dadosacre.Size = New System.Drawing.Size(744, 250)
        Me.dgw_dadosacre.TabIndex = 1
        '
        'Column5
        '
        Me.Column5.HeaderText = "N_Quarto"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Nome Quarto"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "CPF"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Nome"
        Me.Column8.Name = "Column8"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Estado"
        Me.Column3.Name = "Column3"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Data"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Data da Saida"
        Me.Column2.Name = "Column2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(48, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Busca avançada"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(675, 331)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 31)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Voltar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 442)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form6"
        Me.Text = "Check-in Reserva"
        Me.TabControl1.ResumeLayout(False)
        Me.tab_cadacresc.ResumeLayout(False)
        Me.tab_cadacresc.PerformLayout()
        Me.tab_lstacresc.ResumeLayout(False)
        Me.tab_lstacresc.PerformLayout()
        CType(Me.dgw_dadosacre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_cadacresc As TabPage
    Friend WithEvents tab_lstacresc As TabPage
    Friend WithEvents txt_nomebem2 As TextBox
    Friend WithEvents txt_nomep5 As TextBox
    Friend WithEvents txt_idbem3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_descacre As TextBox
    Friend WithEvents txt_valoracre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_dataquiacre As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_canceacre As Button
    Friend WithEvents btn_salvaracre As Button
    Friend WithEvents txt_grupoacre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmb_selecao3 As ComboBox
    Friend WithEvents txt_buscar3 As TextBox
    Friend WithEvents dgw_dadosacre As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_cpfress As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_dateres As MaskedTextBox
    Friend WithEvents cmb_acomres As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class
