<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nomemp3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_descbem = New System.Windows.Forms.TextBox()
        Me.tab_movbem = New System.Windows.Forms.TabControl()
        Me.cadbens = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_local = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_acomp = New System.Windows.Forms.ComboBox()
        Me.txt_cpff = New System.Windows.Forms.MaskedTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_tipocomp = New System.Windows.Forms.TextBox()
        Me.txt_id2 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_databaixa1 = New System.Windows.Forms.MaskedTextBox()
        Me.btn_cancelar1 = New System.Windows.Forms.Button()
        Me.txt_valorbaixa2 = New System.Windows.Forms.TextBox()
        Me.btn_salvar1 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_datacorre = New System.Windows.Forms.MaskedTextBox()
        Me.listabens = New System.Windows.Forms.TabPage()
        Me.cmb_selq = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_buscaq = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgw_listabens = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab_movbem.SuspendLayout()
        Me.cadbens.SuspendLayout()
        Me.listabens.SuspendLayout()
        CType(Me.dgw_listabens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(354, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome do Quarto"
        '
        'txt_nomemp3
        '
        Me.txt_nomemp3.Location = New System.Drawing.Point(357, 91)
        Me.txt_nomemp3.Name = "txt_nomemp3"
        Me.txt_nomemp3.ReadOnly = True
        Me.txt_nomemp3.Size = New System.Drawing.Size(265, 20)
        Me.txt_nomemp3.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(354, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome do Cliente"
        '
        'txt_descbem
        '
        Me.txt_descbem.Location = New System.Drawing.Point(357, 135)
        Me.txt_descbem.Name = "txt_descbem"
        Me.txt_descbem.ReadOnly = True
        Me.txt_descbem.Size = New System.Drawing.Size(265, 20)
        Me.txt_descbem.TabIndex = 3
        '
        'tab_movbem
        '
        Me.tab_movbem.Controls.Add(Me.cadbens)
        Me.tab_movbem.Controls.Add(Me.listabens)
        Me.tab_movbem.Location = New System.Drawing.Point(12, 12)
        Me.tab_movbem.Name = "tab_movbem"
        Me.tab_movbem.SelectedIndex = 0
        Me.tab_movbem.Size = New System.Drawing.Size(674, 418)
        Me.tab_movbem.TabIndex = 4
        '
        'cadbens
        '
        Me.cadbens.Controls.Add(Me.Label6)
        Me.cadbens.Controls.Add(Me.txt_local)
        Me.cadbens.Controls.Add(Me.Label3)
        Me.cadbens.Controls.Add(Me.cmb_acomp)
        Me.cadbens.Controls.Add(Me.txt_cpff)
        Me.cadbens.Controls.Add(Me.Label20)
        Me.cadbens.Controls.Add(Me.Label25)
        Me.cadbens.Controls.Add(Me.txt_tipocomp)
        Me.cadbens.Controls.Add(Me.txt_id2)
        Me.cadbens.Controls.Add(Me.Label19)
        Me.cadbens.Controls.Add(Me.Label24)
        Me.cadbens.Controls.Add(Me.txt_databaixa1)
        Me.cadbens.Controls.Add(Me.btn_cancelar1)
        Me.cadbens.Controls.Add(Me.txt_valorbaixa2)
        Me.cadbens.Controls.Add(Me.btn_salvar1)
        Me.cadbens.Controls.Add(Me.Label17)
        Me.cadbens.Controls.Add(Me.txt_nomemp3)
        Me.cadbens.Controls.Add(Me.Label2)
        Me.cadbens.Controls.Add(Me.txt_descbem)
        Me.cadbens.Controls.Add(Me.Label1)
        Me.cadbens.Controls.Add(Me.Label11)
        Me.cadbens.Controls.Add(Me.Label13)
        Me.cadbens.Controls.Add(Me.txt_datacorre)
        Me.cadbens.Location = New System.Drawing.Point(4, 22)
        Me.cadbens.Name = "cadbens"
        Me.cadbens.Padding = New System.Windows.Forms.Padding(3)
        Me.cadbens.Size = New System.Drawing.Size(666, 392)
        Me.cadbens.TabIndex = 0
        Me.cadbens.Text = "Check-in"
        Me.cadbens.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(223, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 33)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "CHECK IN"
        '
        'txt_local
        '
        Me.txt_local.Location = New System.Drawing.Point(357, 183)
        Me.txt_local.Name = "txt_local"
        Me.txt_local.ReadOnly = True
        Me.txt_local.Size = New System.Drawing.Size(143, 20)
        Me.txt_local.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(311, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Acompanhantes"
        '
        'cmb_acomp
        '
        Me.cmb_acomp.FormattingEnabled = True
        Me.cmb_acomp.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.cmb_acomp.Location = New System.Drawing.Point(401, 225)
        Me.cmb_acomp.Name = "cmb_acomp"
        Me.cmb_acomp.Size = New System.Drawing.Size(121, 21)
        Me.cmb_acomp.TabIndex = 26
        '
        'txt_cpff
        '
        Me.txt_cpff.Location = New System.Drawing.Point(26, 135)
        Me.txt_cpff.Mask = "999,999,999-99"
        Me.txt_cpff.Name = "txt_cpff"
        Me.txt_cpff.Size = New System.Drawing.Size(85, 20)
        Me.txt_cpff.TabIndex = 25
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(355, 167)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(40, 13)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Estado"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(24, 119)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(27, 13)
        Me.Label25.TabIndex = 24
        Me.Label25.Text = "CPF"
        '
        'txt_tipocomp
        '
        Me.txt_tipocomp.Location = New System.Drawing.Point(60, 172)
        Me.txt_tipocomp.Name = "txt_tipocomp"
        Me.txt_tipocomp.ReadOnly = True
        Me.txt_tipocomp.Size = New System.Drawing.Size(143, 20)
        Me.txt_tipocomp.TabIndex = 3
        '
        'txt_id2
        '
        Me.txt_id2.Location = New System.Drawing.Point(26, 91)
        Me.txt_id2.Name = "txt_id2"
        Me.txt_id2.Size = New System.Drawing.Size(28, 20)
        Me.txt_id2.TabIndex = 23
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(24, 172)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Tipo"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(23, 75)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(61, 13)
        Me.Label24.TabIndex = 22
        Me.Label24.Text = "Cod Quarto"
        '
        'txt_databaixa1
        '
        Me.txt_databaixa1.Location = New System.Drawing.Point(118, 263)
        Me.txt_databaixa1.Mask = "00/00/0000"
        Me.txt_databaixa1.Name = "txt_databaixa1"
        Me.txt_databaixa1.Size = New System.Drawing.Size(75, 20)
        Me.txt_databaixa1.TabIndex = 20
        Me.txt_databaixa1.ValidatingType = GetType(Date)
        '
        'btn_cancelar1
        '
        Me.btn_cancelar1.Image = CType(resources.GetObject("btn_cancelar1.Image"), System.Drawing.Image)
        Me.btn_cancelar1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar1.Location = New System.Drawing.Point(155, 332)
        Me.btn_cancelar1.Name = "btn_cancelar1"
        Me.btn_cancelar1.Size = New System.Drawing.Size(79, 32)
        Me.btn_cancelar1.TabIndex = 6
        Me.btn_cancelar1.Text = "Cancelar"
        Me.btn_cancelar1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar1.UseVisualStyleBackColor = True
        '
        'txt_valorbaixa2
        '
        Me.txt_valorbaixa2.Location = New System.Drawing.Point(401, 270)
        Me.txt_valorbaixa2.Name = "txt_valorbaixa2"
        Me.txt_valorbaixa2.ReadOnly = True
        Me.txt_valorbaixa2.Size = New System.Drawing.Size(90, 20)
        Me.txt_valorbaixa2.TabIndex = 19
        '
        'btn_salvar1
        '
        Me.btn_salvar1.Image = CType(resources.GetObject("btn_salvar1.Image"), System.Drawing.Image)
        Me.btn_salvar1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salvar1.Location = New System.Drawing.Point(420, 332)
        Me.btn_salvar1.Name = "btn_salvar1"
        Me.btn_salvar1.Size = New System.Drawing.Size(80, 32)
        Me.btn_salvar1.TabIndex = 5
        Me.btn_salvar1.Text = "Salvar"
        Me.btn_salvar1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salvar1.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(319, 273)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(76, 13)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Valor da Diária"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 225)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Data de Entrada"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(36, 266)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Data de Saida"
        '
        'txt_datacorre
        '
        Me.txt_datacorre.Location = New System.Drawing.Point(118, 222)
        Me.txt_datacorre.Mask = "00/00/0000"
        Me.txt_datacorre.Name = "txt_datacorre"
        Me.txt_datacorre.Size = New System.Drawing.Size(77, 20)
        Me.txt_datacorre.TabIndex = 8
        Me.txt_datacorre.ValidatingType = GetType(Date)
        '
        'listabens
        '
        Me.listabens.Controls.Add(Me.cmb_selq)
        Me.listabens.Controls.Add(Me.Label5)
        Me.listabens.Controls.Add(Me.txt_buscaq)
        Me.listabens.Controls.Add(Me.Label4)
        Me.listabens.Controls.Add(Me.Label26)
        Me.listabens.Controls.Add(Me.Button1)
        Me.listabens.Controls.Add(Me.dgw_listabens)
        Me.listabens.Location = New System.Drawing.Point(4, 22)
        Me.listabens.Name = "listabens"
        Me.listabens.Padding = New System.Windows.Forms.Padding(3)
        Me.listabens.Size = New System.Drawing.Size(666, 392)
        Me.listabens.TabIndex = 1
        Me.listabens.Text = "Lista dos Quartos"
        Me.listabens.UseVisualStyleBackColor = True
        '
        'cmb_selq
        '
        Me.cmb_selq.FormattingEnabled = True
        Me.cmb_selq.Location = New System.Drawing.Point(383, 66)
        Me.cmb_selq.Name = "cmb_selq"
        Me.cmb_selq.Size = New System.Drawing.Size(121, 21)
        Me.cmb_selq.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(380, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Modo de Busca"
        '
        'txt_buscaq
        '
        Me.txt_buscaq.Location = New System.Drawing.Point(21, 66)
        Me.txt_buscaq.Name = "txt_buscaq"
        Me.txt_buscaq.Size = New System.Drawing.Size(100, 20)
        Me.txt_buscaq.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Busca"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label26.Location = New System.Drawing.Point(163, 13)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(210, 28)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "Lista dos Quartos"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(560, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 32)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgw_listabens
        '
        Me.dgw_listabens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw_listabens.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column10})
        Me.dgw_listabens.Location = New System.Drawing.Point(6, 92)
        Me.dgw_listabens.Name = "dgw_listabens"
        Me.dgw_listabens.Size = New System.Drawing.Size(633, 294)
        Me.dgw_listabens.TabIndex = 0
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Numero do Quarto"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Nome do Quarto"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 101
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Tipo"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 53
        '
        'Column6
        '
        Me.Column6.HeaderText = "Valor"
        Me.Column6.Name = "Column6"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Estado"
        Me.Column10.Name = "Column10"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 455)
        Me.Controls.Add(Me.tab_movbem)
        Me.Name = "Form2"
        Me.Text = "CHECK-IN"
        Me.tab_movbem.ResumeLayout(False)
        Me.cadbens.ResumeLayout(False)
        Me.cadbens.PerformLayout()
        Me.listabens.ResumeLayout(False)
        Me.listabens.PerformLayout()
        CType(Me.dgw_listabens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nomemp3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_descbem As TextBox
    Friend WithEvents tab_movbem As TabControl
    Friend WithEvents cadbens As TabPage
    Friend WithEvents listabens As TabPage
    Friend WithEvents txt_datacorre As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_valorbaixa2 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_tipocomp As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btn_salvar1 As Button
    Friend WithEvents txt_databaixa1 As MaskedTextBox
    Friend WithEvents dgw_listabens As DataGridView
    Friend WithEvents txt_id2 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents btn_cancelar1 As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_acomp As ComboBox
    Friend WithEvents txt_cpff As MaskedTextBox
    Friend WithEvents cmb_selq As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_buscaq As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents txt_local As TextBox
    Friend WithEvents Label6 As Label
End Class
