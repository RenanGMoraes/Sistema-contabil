<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.btn_transf_ativ = New System.Windows.Forms.Button()
        Me.btn_baixaparc = New System.Windows.Forms.Button()
        Me.btn_cadacresc = New System.Windows.Forms.Button()
        Me.btn_cadbens_ativ = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_regcon = New System.Windows.Forms.Button()
        Me.btn_cadastrocliente = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_transf_ativ
        '
        Me.btn_transf_ativ.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_transf_ativ.Location = New System.Drawing.Point(66, 493)
        Me.btn_transf_ativ.Name = "btn_transf_ativ"
        Me.btn_transf_ativ.Size = New System.Drawing.Size(193, 53)
        Me.btn_transf_ativ.TabIndex = 7
        Me.btn_transf_ativ.Text = "RESERVA"
        Me.btn_transf_ativ.UseVisualStyleBackColor = True
        '
        'btn_baixaparc
        '
        Me.btn_baixaparc.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_baixaparc.Location = New System.Drawing.Point(66, 404)
        Me.btn_baixaparc.Name = "btn_baixaparc"
        Me.btn_baixaparc.Size = New System.Drawing.Size(193, 65)
        Me.btn_baixaparc.TabIndex = 8
        Me.btn_baixaparc.Text = "CADASTRO DE PRATOS"
        Me.btn_baixaparc.UseVisualStyleBackColor = True
        '
        'btn_cadacresc
        '
        Me.btn_cadacresc.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadacresc.Location = New System.Drawing.Point(508, 488)
        Me.btn_cadacresc.Name = "btn_cadacresc"
        Me.btn_cadacresc.Size = New System.Drawing.Size(187, 58)
        Me.btn_cadacresc.TabIndex = 9
        Me.btn_cadacresc.Text = "CHECK-IN RESERVA"
        Me.btn_cadacresc.UseVisualStyleBackColor = True
        '
        'btn_cadbens_ativ
        '
        Me.btn_cadbens_ativ.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadbens_ativ.Location = New System.Drawing.Point(508, 317)
        Me.btn_cadbens_ativ.Name = "btn_cadbens_ativ"
        Me.btn_cadbens_ativ.Size = New System.Drawing.Size(187, 62)
        Me.btn_cadbens_ativ.TabIndex = 11
        Me.btn_cadbens_ativ.Text = "CHECK-IN"
        Me.btn_cadbens_ativ.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btn_back.Location = New System.Drawing.Point(508, 400)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(187, 63)
        Me.btn_back.TabIndex = 13
        Me.btn_back.Text = "CHECK-OUT"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(37, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(698, 286)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'btn_regcon
        '
        Me.btn_regcon.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_regcon.Location = New System.Drawing.Point(288, 318)
        Me.btn_regcon.Name = "btn_regcon"
        Me.btn_regcon.Size = New System.Drawing.Size(187, 62)
        Me.btn_regcon.TabIndex = 15
        Me.btn_regcon.Text = "COMANDA"
        Me.btn_regcon.UseVisualStyleBackColor = True
        '
        'btn_cadastrocliente
        '
        Me.btn_cadastrocliente.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrocliente.Location = New System.Drawing.Point(66, 318)
        Me.btn_cadastrocliente.Name = "btn_cadastrocliente"
        Me.btn_cadastrocliente.Size = New System.Drawing.Size(193, 62)
        Me.btn_cadastrocliente.TabIndex = 16
        Me.btn_cadastrocliente.Text = "CADASTRO DE CLIENTES"
        Me.btn_cadastrocliente.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 569)
        Me.Controls.Add(Me.btn_cadastrocliente)
        Me.Controls.Add(Me.btn_regcon)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_cadbens_ativ)
        Me.Controls.Add(Me.btn_cadacresc)
        Me.Controls.Add(Me.btn_baixaparc)
        Me.Controls.Add(Me.btn_transf_ativ)
        Me.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Name = "Form5"
        Me.Text = "MENU PRINCIPAL"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_transf_ativ As Button
    Friend WithEvents btn_baixaparc As Button
    Friend WithEvents btn_cadacresc As Button
    Friend WithEvents btn_cadbens_ativ As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_regcon As Button
    Friend WithEvents btn_cadastrocliente As Button
End Class
