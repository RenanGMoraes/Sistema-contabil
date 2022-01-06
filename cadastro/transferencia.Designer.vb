<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form9
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nameq = New System.Windows.Forms.TextBox()
        Me.txt_descbemo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_chapao = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_doco = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nomempo = New System.Windows.Forms.TextBox()
        Me.txt_idbemo = New System.Windows.Forms.TextBox()
        Me.txt_datadest = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_cpffff = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_acompanha = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_dataex = New System.Windows.Forms.MaskedTextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_buscare = New System.Windows.Forms.TextBox()
        Me.cmb_selres = New System.Windows.Forms.ComboBox()
        Me.dgw_reserva = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgw_reserva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cod Quarto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CPF"
        '
        'txt_nameq
        '
        Me.txt_nameq.Location = New System.Drawing.Point(355, 80)
        Me.txt_nameq.Name = "txt_nameq"
        Me.txt_nameq.ReadOnly = True
        Me.txt_nameq.Size = New System.Drawing.Size(235, 20)
        Me.txt_nameq.TabIndex = 11
        '
        'txt_descbemo
        '
        Me.txt_descbemo.Location = New System.Drawing.Point(263, 226)
        Me.txt_descbemo.Name = "txt_descbemo"
        Me.txt_descbemo.ReadOnly = True
        Me.txt_descbemo.Size = New System.Drawing.Size(102, 20)
        Me.txt_descbemo.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(263, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Valor da Diaria"
        '
        'txt_chapao
        '
        Me.txt_chapao.Location = New System.Drawing.Point(266, 173)
        Me.txt_chapao.Name = "txt_chapao"
        Me.txt_chapao.ReadOnly = True
        Me.txt_chapao.Size = New System.Drawing.Size(135, 20)
        Me.txt_chapao.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(263, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Estado"
        '
        'txt_doco
        '
        Me.txt_doco.Location = New System.Drawing.Point(34, 172)
        Me.txt_doco.Name = "txt_doco"
        Me.txt_doco.ReadOnly = True
        Me.txt_doco.Size = New System.Drawing.Size(120, 20)
        Me.txt_doco.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tipo"
        '
        'txt_nomempo
        '
        Me.txt_nomempo.Location = New System.Drawing.Point(355, 114)
        Me.txt_nomempo.Name = "txt_nomempo"
        Me.txt_nomempo.ReadOnly = True
        Me.txt_nomempo.Size = New System.Drawing.Size(235, 20)
        Me.txt_nomempo.TabIndex = 4
        '
        'txt_idbemo
        '
        Me.txt_idbemo.Location = New System.Drawing.Point(89, 75)
        Me.txt_idbemo.Name = "txt_idbemo"
        Me.txt_idbemo.Size = New System.Drawing.Size(29, 20)
        Me.txt_idbemo.TabIndex = 2
        '
        'txt_datadest
        '
        Me.txt_datadest.Location = New System.Drawing.Point(124, 226)
        Me.txt_datadest.Mask = "00/00/0000"
        Me.txt_datadest.Name = "txt_datadest"
        Me.txt_datadest.Size = New System.Drawing.Size(76, 20)
        Me.txt_datadest.TabIndex = 4
        Me.txt_datadest.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Data de Entrada"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Data de Saida"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(392, 325)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 36)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Realizar Reserva"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(36, 325)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 36)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label9.Location = New System.Drawing.Point(213, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 33)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "RESERVA"
        '
        'txt_cpffff
        '
        Me.txt_cpffff.Location = New System.Drawing.Point(67, 113)
        Me.txt_cpffff.Mask = "999,999,999-99"
        Me.txt_cpffff.Name = "txt_cpffff"
        Me.txt_cpffff.Size = New System.Drawing.Size(100, 20)
        Me.txt_cpffff.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(263, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Nome do Quarto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(263, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Nome do Cliente"
        '
        'cmb_acompanha
        '
        Me.cmb_acompanha.FormattingEnabled = True
        Me.cmb_acompanha.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.cmb_acompanha.Location = New System.Drawing.Point(457, 172)
        Me.cmb_acompanha.Name = "cmb_acompanha"
        Me.cmb_acompanha.Size = New System.Drawing.Size(121, 21)
        Me.cmb_acompanha.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(454, 156)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Acompanhantes"
        '
        'txt_dataex
        '
        Me.txt_dataex.Location = New System.Drawing.Point(124, 260)
        Me.txt_dataex.Mask = "00/00/0000"
        Me.txt_dataex.Name = "txt_dataex"
        Me.txt_dataex.Size = New System.Drawing.Size(76, 20)
        Me.txt_dataex.TabIndex = 17
        Me.txt_dataex.ValidatingType = GetType(Date)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(626, 425)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_descbemo)
        Me.TabPage1.Controls.Add(Me.txt_dataex)
        Me.TabPage1.Controls.Add(Me.txt_idbemo)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.cmb_acompanha)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txt_nomempo)
        Me.TabPage1.Controls.Add(Me.txt_datadest)
        Me.TabPage1.Controls.Add(Me.txt_doco)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txt_chapao)
        Me.TabPage1.Controls.Add(Me.txt_cpffff)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txt_nameq)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(618, 399)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Reserva"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txt_buscare)
        Me.TabPage2.Controls.Add(Me.cmb_selres)
        Me.TabPage2.Controls.Add(Me.dgw_reserva)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(618, 399)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lista dos Quartos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label26.Location = New System.Drawing.Point(179, 12)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(210, 28)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "Lista dos Quartos"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(321, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Modo de Busca"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Busca"
        '
        'txt_buscare
        '
        Me.txt_buscare.Location = New System.Drawing.Point(24, 73)
        Me.txt_buscare.Name = "txt_buscare"
        Me.txt_buscare.Size = New System.Drawing.Size(100, 20)
        Me.txt_buscare.TabIndex = 2
        '
        'cmb_selres
        '
        Me.cmb_selres.FormattingEnabled = True
        Me.cmb_selres.Location = New System.Drawing.Point(324, 73)
        Me.cmb_selres.Name = "cmb_selres"
        Me.cmb_selres.Size = New System.Drawing.Size(121, 21)
        Me.cmb_selres.TabIndex = 1
        '
        'dgw_reserva
        '
        Me.dgw_reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw_reserva.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgw_reserva.Location = New System.Drawing.Point(6, 109)
        Me.dgw_reserva.Name = "dgw_reserva"
        Me.dgw_reserva.Size = New System.Drawing.Size(610, 305)
        Me.dgw_reserva.TabIndex = 0
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
        Me.Column3.HeaderText = "Tipo"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Valor"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Estado"
        Me.Column5.Name = "Column5"
        '
        'form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 441)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "form9"
        Me.Text = "RESERVA"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgw_reserva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nomempo As TextBox
    Friend WithEvents txt_idbemo As TextBox
    Friend WithEvents txt_descbemo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_chapao As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_doco As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_datadest As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_nameq As TextBox
    Friend WithEvents txt_cpffff As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmb_acompanha As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_dataex As MaskedTextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_buscare As TextBox
    Friend WithEvents cmb_selres As ComboBox
    Friend WithEvents dgw_reserva As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label26 As Label
End Class
