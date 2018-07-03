<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACESSODBF
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnLerDBF = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(479, 216)
        Me.DataGridView1.TabIndex = 0
        '
        'btnLerDBF
        '
        Me.btnLerDBF.Location = New System.Drawing.Point(334, 223)
        Me.btnLerDBF.Name = "btnLerDBF"
        Me.btnLerDBF.Size = New System.Drawing.Size(137, 23)
        Me.btnLerDBF.TabIndex = 1
        Me.btnLerDBF.Text = "Ler DBF"
        Me.btnLerDBF.UseVisualStyleBackColor = True
        '
        'ALTERANDO_DATAGRID_VIA_CODIGO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 252)
        Me.Controls.Add(Me.btnLerDBF)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ALTERANDO_DATAGRID_VIA_CODIGO"
        Me.Text = "ALTERANDO DATAGRID VIA CODIGO"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnLerDBF As System.Windows.Forms.Button

End Class
