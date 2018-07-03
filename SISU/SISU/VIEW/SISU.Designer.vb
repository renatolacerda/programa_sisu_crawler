<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SISU
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
        Me.wb = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInstituicao = New System.Windows.Forms.TextBox()
        Me.txtLocal = New System.Windows.Forms.TextBox()
        Me.txtCurso = New System.Windows.Forms.TextBox()
        Me.txtGrau = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtInscricao = New System.Windows.Forms.TextBox()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.Barra = New System.Windows.Forms.ProgressBar()
        Me.txtFim = New System.Windows.Forms.TextBox()
        Me.txtInicio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.lblContador = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wb
        '
        Me.wb.Location = New System.Drawing.Point(12, 3)
        Me.wb.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb.Name = "wb"
        Me.wb.Size = New System.Drawing.Size(903, 319)
        Me.wb.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 331)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Instituição:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Local:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(263, 331)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Curso:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(267, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Grau:"
        '
        'txtInstituicao
        '
        Me.txtInstituicao.Enabled = False
        Me.txtInstituicao.Location = New System.Drawing.Point(75, 328)
        Me.txtInstituicao.Name = "txtInstituicao"
        Me.txtInstituicao.Size = New System.Drawing.Size(173, 20)
        Me.txtInstituicao.TabIndex = 2
        '
        'txtLocal
        '
        Me.txtLocal.Enabled = False
        Me.txtLocal.Location = New System.Drawing.Point(75, 353)
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.Size = New System.Drawing.Size(173, 20)
        Me.txtLocal.TabIndex = 2
        '
        'txtCurso
        '
        Me.txtCurso.Enabled = False
        Me.txtCurso.Location = New System.Drawing.Point(306, 328)
        Me.txtCurso.Name = "txtCurso"
        Me.txtCurso.Size = New System.Drawing.Size(191, 20)
        Me.txtCurso.TabIndex = 2
        '
        'txtGrau
        '
        Me.txtGrau.Enabled = False
        Me.txtGrau.Location = New System.Drawing.Point(306, 353)
        Me.txtGrau.Name = "txtGrau"
        Me.txtGrau.Size = New System.Drawing.Size(191, 20)
        Me.txtGrau.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(532, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nome:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(517, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Matrícula:"
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(576, 328)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(223, 20)
        Me.txtNome.TabIndex = 2
        '
        'txtInscricao
        '
        Me.txtInscricao.Enabled = False
        Me.txtInscricao.Location = New System.Drawing.Point(576, 353)
        Me.txtInscricao.Name = "txtInscricao"
        Me.txtInscricao.Size = New System.Drawing.Size(223, 20)
        Me.txtInscricao.TabIndex = 2
        '
        'btnImportar
        '
        Me.btnImportar.Enabled = False
        Me.btnImportar.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportar.Location = New System.Drawing.Point(818, 331)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(90, 42)
        Me.btnImportar.TabIndex = 3
        Me.btnImportar.Text = "&Importar"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'Barra
        '
        Me.Barra.Location = New System.Drawing.Point(26, 592)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(786, 10)
        Me.Barra.Step = 1
        Me.Barra.TabIndex = 4
        '
        'txtFim
        '
        Me.txtFim.Location = New System.Drawing.Point(725, 376)
        Me.txtFim.MaxLength = 5
        Me.txtFim.Name = "txtFim"
        Me.txtFim.Size = New System.Drawing.Size(49, 20)
        Me.txtFim.TabIndex = 2
        '
        'txtInicio
        '
        Me.txtInicio.Location = New System.Drawing.Point(576, 376)
        Me.txtInicio.MaxLength = 5
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.Size = New System.Drawing.Size(49, 20)
        Me.txtInicio.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(533, 379)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Início:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(693, 379)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Fim:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 408)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(894, 178)
        Me.DataGridView1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(818, 379)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Encontrados"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(818, 589)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(97, 17)
        Me.btnExportar.TabIndex = 6
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Location = New System.Drawing.Point(782, 376)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(17, 20)
        Me.btnPause.TabIndex = 6
        Me.btnPause.Text = ">"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'lblContador
        '
        Me.lblContador.AutoSize = True
        Me.lblContador.Location = New System.Drawing.Point(635, 379)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(50, 13)
        Me.lblContador.TabIndex = 1
        Me.lblContador.Text = "Contador"
        '
        'SISU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 609)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.txtGrau)
        Me.Controls.Add(Me.txtCurso)
        Me.Controls.Add(Me.txtInscricao)
        Me.Controls.Add(Me.txtLocal)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtInicio)
        Me.Controls.Add(Me.txtFim)
        Me.Controls.Add(Me.txtInstituicao)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblContador)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.wb)
        Me.Name = "SISU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dados Sisu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wb As System.Windows.Forms.WebBrowser
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtInstituicao As System.Windows.Forms.TextBox
    Friend WithEvents txtLocal As System.Windows.Forms.TextBox
    Friend WithEvents txtCurso As System.Windows.Forms.TextBox
    Friend WithEvents txtGrau As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtInscricao As System.Windows.Forms.TextBox
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents Barra As System.Windows.Forms.ProgressBar
    Friend WithEvents txtFim As System.Windows.Forms.TextBox
    Friend WithEvents txtInicio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents lblContador As System.Windows.Forms.Label

End Class
