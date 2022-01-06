<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastro
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nqout = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nomeqout = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cpfout = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_dataeout = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_datasout = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_diasout = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_valordout = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_valortout = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_valortconout = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_valortpout = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_nomeout = New System.Windows.Forms.TextBox()
        Me.btn_cancelarout = New System.Windows.Forms.Button()
        Me.btn_checkout = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmb_buscaout = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_buscaout = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgw_checkout = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgw_checkout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero do Quarto"
        '
        'txt_nqout
        '
        Me.txt_nqout.Location = New System.Drawing.Point(163, 88)
        Me.txt_nqout.Name = "txt_nqout"
        Me.txt_nqout.Size = New System.Drawing.Size(43, 20)
        Me.txt_nqout.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(325, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome do Quarto"
        '
        'txt_nomeqout
        '
        Me.txt_nomeqout.Location = New System.Drawing.Point(416, 85)
        Me.txt_nomeqout.Name = "txt_nomeqout"
        Me.txt_nomeqout.ReadOnly = True
        Me.txt_nomeqout.Size = New System.Drawing.Size(265, 20)
        Me.txt_nomeqout.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CPF"
        '
        'txt_cpfout
        '
        Me.txt_cpfout.Location = New System.Drawing.Point(113, 120)
        Me.txt_cpfout.Mask = "999,999,999-99"
        Me.txt_cpfout.Name = "txt_cpfout"
        Me.txt_cpfout.ReadOnly = True
        Me.txt_cpfout.Size = New System.Drawing.Size(93, 20)
        Me.txt_cpfout.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(325, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nome do Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Data de Entrada"
        '
        'txt_dataeout
        '
        Me.txt_dataeout.Location = New System.Drawing.Point(159, 175)
        Me.txt_dataeout.Mask = "00/00/0000"
        Me.txt_dataeout.Name = "txt_dataeout"
        Me.txt_dataeout.ReadOnly = True
        Me.txt_dataeout.Size = New System.Drawing.Size(81, 20)
        Me.txt_dataeout.TabIndex = 8
        Me.txt_dataeout.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(413, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Data de Saida"
        '
        'txt_datasout
        '
        Me.txt_datasout.Location = New System.Drawing.Point(494, 171)
        Me.txt_datasout.Mask = "00/00/0000"
        Me.txt_datasout.Name = "txt_datasout"
        Me.txt_datasout.Size = New System.Drawing.Size(84, 20)
        Me.txt_datasout.TabIndex = 10
        Me.txt_datasout.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(68, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Dias permanecidos"
        '
        'txt_diasout
        '
        Me.txt_diasout.Location = New System.Drawing.Point(171, 217)
        Me.txt_diasout.Name = "txt_diasout"
        Me.txt_diasout.ReadOnly = True
        Me.txt_diasout.Size = New System.Drawing.Size(39, 20)
        Me.txt_diasout.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(413, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Valor da Diaria"
        '
        'txt_valordout
        '
        Me.txt_valordout.Location = New System.Drawing.Point(495, 213)
        Me.txt_valordout.Name = "txt_valordout"
        Me.txt_valordout.ReadOnly = True
        Me.txt_valordout.Size = New System.Drawing.Size(83, 20)
        Me.txt_valordout.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(261, 267)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Valor Total da Diaria"
        '
        'txt_valortout
        '
        Me.txt_valortout.Location = New System.Drawing.Point(264, 283)
        Me.txt_valortout.Name = "txt_valortout"
        Me.txt_valortout.ReadOnly = True
        Me.txt_valortout.Size = New System.Drawing.Size(100, 20)
        Me.txt_valortout.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(261, 306)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Valor total de consumo"
        '
        'txt_valortconout
        '
        Me.txt_valortconout.Location = New System.Drawing.Point(264, 322)
        Me.txt_valortconout.Name = "txt_valortconout"
        Me.txt_valortconout.ReadOnly = True
        Me.txt_valortconout.Size = New System.Drawing.Size(100, 20)
        Me.txt_valortconout.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(261, 345)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Valor total a pagar"
        '
        'txt_valortpout
        '
        Me.txt_valortpout.Location = New System.Drawing.Point(264, 361)
        Me.txt_valortpout.Name = "txt_valortpout"
        Me.txt_valortpout.ReadOnly = True
        Me.txt_valortpout.Size = New System.Drawing.Size(100, 20)
        Me.txt_valortpout.TabIndex = 21
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(725, 475)
        Me.TabControl1.TabIndex = 22
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.txt_nomeout)
        Me.TabPage1.Controls.Add(Me.btn_cancelarout)
        Me.TabPage1.Controls.Add(Me.btn_checkout)
        Me.TabPage1.Controls.Add(Me.txt_valortout)
        Me.TabPage1.Controls.Add(Me.txt_valortpout)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txt_nqout)
        Me.TabPage1.Controls.Add(Me.txt_valortconout)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txt_nomeqout)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txt_cpfout)
        Me.TabPage1.Controls.Add(Me.txt_valordout)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txt_diasout)
        Me.TabPage1.Controls.Add(Me.txt_dataeout)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txt_datasout)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(717, 449)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Check-out"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(246, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(164, 28)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "CHECK OUT"
        '
        'txt_nomeout
        '
        Me.txt_nomeout.Location = New System.Drawing.Point(416, 116)
        Me.txt_nomeout.Name = "txt_nomeout"
        Me.txt_nomeout.ReadOnly = True
        Me.txt_nomeout.Size = New System.Drawing.Size(265, 20)
        Me.txt_nomeout.TabIndex = 24
        '
        'btn_cancelarout
        '
        Me.btn_cancelarout.Location = New System.Drawing.Point(430, 386)
        Me.btn_cancelarout.Name = "btn_cancelarout"
        Me.btn_cancelarout.Size = New System.Drawing.Size(118, 45)
        Me.btn_cancelarout.TabIndex = 23
        Me.btn_cancelarout.Text = "Cancelar"
        Me.btn_cancelarout.UseVisualStyleBackColor = True
        '
        'btn_checkout
        '
        Me.btn_checkout.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_checkout.Location = New System.Drawing.Point(568, 386)
        Me.btn_checkout.Name = "btn_checkout"
        Me.btn_checkout.Size = New System.Drawing.Size(113, 45)
        Me.btn_checkout.TabIndex = 22
        Me.btn_checkout.Text = "REALIZAR CHECK OUT"
        Me.btn_checkout.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.cmb_buscaout)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txt_buscaout)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.dgw_checkout)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(717, 449)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lista de Consumo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(197, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(303, 25)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Lista de Consumo por Quarto"
        '
        'cmb_buscaout
        '
        Me.cmb_buscaout.FormattingEnabled = True
        Me.cmb_buscaout.Location = New System.Drawing.Point(440, 85)
        Me.cmb_buscaout.Name = "cmb_buscaout"
        Me.cmb_buscaout.Size = New System.Drawing.Size(165, 21)
        Me.cmb_buscaout.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(437, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Modo de busca"
        '
        'txt_buscaout
        '
        Me.txt_buscaout.Location = New System.Drawing.Point(85, 87)
        Me.txt_buscaout.Name = "txt_buscaout"
        Me.txt_buscaout.Size = New System.Drawing.Size(148, 20)
        Me.txt_buscaout.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(85, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Buscar"
        '
        'dgw_checkout
        '
        Me.dgw_checkout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw_checkout.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgw_checkout.Location = New System.Drawing.Point(37, 113)
        Me.dgw_checkout.Name = "dgw_checkout"
        Me.dgw_checkout.Size = New System.Drawing.Size(642, 298)
        Me.dgw_checkout.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Numero do Quarto"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nome do Quarto"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "CPF"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Nome"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Consumido"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Valor"
        Me.Column6.Name = "Column6"
        '
        'cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 499)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "cadastro"
        Me.Text = "Check-Out"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgw_checkout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nqout As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nomeqout As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cpfout As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_dataeout As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_datasout As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_diasout As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_valordout As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_valortout As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_valortconout As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_valortpout As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_cancelarout As Button
    Friend WithEvents btn_checkout As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmb_buscaout As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_buscaout As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dgw_checkout As DataGridView
    Friend WithEvents txt_nomeout As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
