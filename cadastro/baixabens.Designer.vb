<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_baixabens = New System.Windows.Forms.TabPage()
        Me.txt_excali = New System.Windows.Forms.Button()
        Me.txt_altali = New System.Windows.Forms.Button()
        Me.btn_cancelarbaixa = New System.Windows.Forms.Button()
        Me.btn_gravarbaixa = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_nomebem5 = New System.Windows.Forms.TextBox()
        Me.txt_nomemp6 = New System.Windows.Forms.TextBox()
        Me.txt_valorbaixa1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_cancer2 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmb_selebaixa = New System.Windows.Forms.ComboBox()
        Me.txt_buscabaixa = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgw_baixa = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tab_baixabens.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgw_baixa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_baixabens)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(458, 308)
        Me.TabControl1.TabIndex = 1
        '
        'tab_baixabens
        '
        Me.tab_baixabens.Controls.Add(Me.txt_excali)
        Me.tab_baixabens.Controls.Add(Me.txt_altali)
        Me.tab_baixabens.Controls.Add(Me.btn_cancelarbaixa)
        Me.tab_baixabens.Controls.Add(Me.btn_gravarbaixa)
        Me.tab_baixabens.Controls.Add(Me.GroupBox1)
        Me.tab_baixabens.Location = New System.Drawing.Point(4, 22)
        Me.tab_baixabens.Name = "tab_baixabens"
        Me.tab_baixabens.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_baixabens.Size = New System.Drawing.Size(450, 282)
        Me.tab_baixabens.TabIndex = 0
        Me.tab_baixabens.Text = "Cadastro de Pratos"
        Me.tab_baixabens.UseVisualStyleBackColor = True
        '
        'txt_excali
        '
        Me.txt_excali.Location = New System.Drawing.Point(251, 172)
        Me.txt_excali.Name = "txt_excali"
        Me.txt_excali.Size = New System.Drawing.Size(80, 42)
        Me.txt_excali.TabIndex = 9
        Me.txt_excali.Text = "Excluir"
        Me.txt_excali.UseVisualStyleBackColor = True
        '
        'txt_altali
        '
        Me.txt_altali.Location = New System.Drawing.Point(166, 172)
        Me.txt_altali.Name = "txt_altali"
        Me.txt_altali.Size = New System.Drawing.Size(79, 42)
        Me.txt_altali.TabIndex = 8
        Me.txt_altali.Text = "Alterar"
        Me.txt_altali.UseVisualStyleBackColor = True
        '
        'btn_cancelarbaixa
        '
        Me.btn_cancelarbaixa.Image = CType(resources.GetObject("btn_cancelarbaixa.Image"), System.Drawing.Image)
        Me.btn_cancelarbaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelarbaixa.Location = New System.Drawing.Point(15, 218)
        Me.btn_cancelarbaixa.Name = "btn_cancelarbaixa"
        Me.btn_cancelarbaixa.Size = New System.Drawing.Size(75, 42)
        Me.btn_cancelarbaixa.TabIndex = 7
        Me.btn_cancelarbaixa.Text = "Cancelar"
        Me.btn_cancelarbaixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelarbaixa.UseVisualStyleBackColor = True
        '
        'btn_gravarbaixa
        '
        Me.btn_gravarbaixa.Image = CType(resources.GetObject("btn_gravarbaixa.Image"), System.Drawing.Image)
        Me.btn_gravarbaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_gravarbaixa.Location = New System.Drawing.Point(337, 172)
        Me.btn_gravarbaixa.Name = "btn_gravarbaixa"
        Me.btn_gravarbaixa.Size = New System.Drawing.Size(74, 42)
        Me.btn_gravarbaixa.TabIndex = 6
        Me.btn_gravarbaixa.Text = "Gravar"
        Me.btn_gravarbaixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_gravarbaixa.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_nomebem5)
        Me.GroupBox1.Controls.Add(Me.txt_nomemp6)
        Me.GroupBox1.Controls.Add(Me.txt_valorbaixa1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 149)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txt_nomebem5
        '
        Me.txt_nomebem5.Location = New System.Drawing.Point(108, 13)
        Me.txt_nomebem5.Name = "txt_nomebem5"
        Me.txt_nomebem5.Size = New System.Drawing.Size(39, 20)
        Me.txt_nomebem5.TabIndex = 4
        '
        'txt_nomemp6
        '
        Me.txt_nomemp6.Location = New System.Drawing.Point(90, 70)
        Me.txt_nomemp6.Name = "txt_nomemp6"
        Me.txt_nomemp6.Size = New System.Drawing.Size(263, 20)
        Me.txt_nomemp6.TabIndex = 3
        '
        'txt_valorbaixa1
        '
        Me.txt_valorbaixa1.Location = New System.Drawing.Point(90, 103)
        Me.txt_valorbaixa1.Name = "txt_valorbaixa1"
        Me.txt_valorbaixa1.Size = New System.Drawing.Size(99, 20)
        Me.txt_valorbaixa1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome do Prato"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(53, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Valor"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_cancer2)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.cmb_selebaixa)
        Me.TabPage2.Controls.Add(Me.txt_buscabaixa)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.dgw_baixa)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(450, 282)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lista de Pratos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_cancer2
        '
        Me.btn_cancer2.Location = New System.Drawing.Point(348, 53)
        Me.btn_cancer2.Name = "btn_cancer2"
        Me.btn_cancer2.Size = New System.Drawing.Size(70, 23)
        Me.btn_cancer2.TabIndex = 5
        Me.btn_cancer2.Text = "Cancelar"
        Me.btn_cancer2.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(161, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Selecione"
        '
        'cmb_selebaixa
        '
        Me.cmb_selebaixa.FormattingEnabled = True
        Me.cmb_selebaixa.Location = New System.Drawing.Point(164, 53)
        Me.cmb_selebaixa.Name = "cmb_selebaixa"
        Me.cmb_selebaixa.Size = New System.Drawing.Size(121, 21)
        Me.cmb_selebaixa.TabIndex = 3
        '
        'txt_buscabaixa
        '
        Me.txt_buscabaixa.Location = New System.Drawing.Point(35, 53)
        Me.txt_buscabaixa.Name = "txt_buscabaixa"
        Me.txt_buscabaixa.Size = New System.Drawing.Size(100, 20)
        Me.txt_buscabaixa.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(32, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Busca"
        '
        'dgw_baixa
        '
        Me.dgw_baixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw_baixa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column1, Me.Column2})
        Me.dgw_baixa.Location = New System.Drawing.Point(6, 83)
        Me.dgw_baixa.Name = "dgw_baixa"
        Me.dgw_baixa.Size = New System.Drawing.Size(421, 171)
        Me.dgw_baixa.TabIndex = 0
        '
        'Column6
        '
        Me.Column6.HeaderText = "Cod Prato"
        Me.Column6.Name = "Column6"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nome Prato"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Valor"
        Me.Column2.Name = "Column2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Código do Alimento"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 334)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form8"
        Me.Text = "Cadastro de Pratos"
        Me.TabControl1.ResumeLayout(False)
        Me.tab_baixabens.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgw_baixa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_baixabens As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_nomebem5 As TextBox
    Friend WithEvents txt_nomemp6 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_valorbaixa1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_cancelarbaixa As Button
    Friend WithEvents btn_gravarbaixa As Button
    Friend WithEvents dgw_baixa As DataGridView
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Label13 As Label
    Friend WithEvents cmb_selebaixa As ComboBox
    Friend WithEvents txt_buscabaixa As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_cancer2 As Button
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents txt_excali As Button
    Friend WithEvents txt_altali As Button
    Friend WithEvents Label2 As Label
End Class
