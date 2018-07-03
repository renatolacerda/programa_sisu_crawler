<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DATAGRID_VIA_COD
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
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.btnLerDBF = New System.Windows.Forms.Button()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AllowUserToOrderColumns = True
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(3, 1)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(479, 216)
        Me.dg.TabIndex = 0
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
        'DATAGRID_VIA_COD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 252)
        Me.Controls.Add(Me.btnLerDBF)
        Me.Controls.Add(Me.dg)
        Me.Name = "DATAGRID_VIA_COD"
        Me.Text = "Ler DBF"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents btnLerDBF As System.Windows.Forms.Button

End Class
