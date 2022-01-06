<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form11))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_login = New System.Windows.Forms.TabPage()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_usu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tab_login.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_login)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(285, 337)
        Me.TabControl1.TabIndex = 0
        '
        'tab_login
        '
        Me.tab_login.Controls.Add(Me.lbl_status)
        Me.tab_login.Controls.Add(Me.Label9)
        Me.tab_login.Controls.Add(Me.btn_entrar)
        Me.tab_login.Controls.Add(Me.Label3)
        Me.tab_login.Controls.Add(Me.txt_senha)
        Me.tab_login.Controls.Add(Me.Label2)
        Me.tab_login.Controls.Add(Me.txt_usu)
        Me.tab_login.Controls.Add(Me.Label1)
        Me.tab_login.Location = New System.Drawing.Point(4, 22)
        Me.tab_login.Name = "tab_login"
        Me.tab_login.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_login.Size = New System.Drawing.Size(277, 311)
        Me.tab_login.TabIndex = 0
        Me.tab_login.Text = "Login"
        Me.tab_login.UseVisualStyleBackColor = True
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Location = New System.Drawing.Point(48, 287)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(0, 13)
        Me.lbl_status.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 287)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Status"
        '
        'btn_entrar
        '
        Me.btn_entrar.Image = CType(resources.GetObject("btn_entrar.Image"), System.Drawing.Image)
        Me.btn_entrar.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_entrar.Location = New System.Drawing.Point(148, 247)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(123, 40)
        Me.btn_entrar.TabIndex = 5
        Me.btn_entrar.Text = "Entrar"
        Me.btn_entrar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(75, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 34)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "LOGIN"
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(21, 178)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(204, 20)
        Me.txt_senha.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Senha"
        '
        'txt_usu
        '
        Me.txt_usu.Location = New System.Drawing.Point(21, 125)
        Me.txt_usu.Name = "txt_usu"
        Me.txt_usu.Size = New System.Drawing.Size(204, 20)
        Me.txt_usu.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuário"
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 361)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form11"
        Me.Text = "Login"
        Me.TabControl1.ResumeLayout(False)
        Me.tab_login.ResumeLayout(False)
        Me.tab_login.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_login As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_usu As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_entrar As Button
    Friend WithEvents lbl_status As Label
    Friend WithEvents Label9 As Label
End Class
