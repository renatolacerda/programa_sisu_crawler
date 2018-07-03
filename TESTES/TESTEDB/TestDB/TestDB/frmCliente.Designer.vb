<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.TabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.Page1 = New DevExpress.XtraTab.XtraTabPage()
        Me.lblRua = New DevExpress.XtraEditors.LabelControl()
        Me.lblNome = New DevExpress.XtraEditors.LabelControl()
        Me.txtRua = New DevExpress.XtraEditors.TextEdit()
        Me.txtNome = New DevExpress.XtraEditors.TextEdit()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.Page2 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtLocalizar = New DevExpress.XtraEditors.TextEdit()
        Me.dg = New System.Windows.Forms.DataGridView()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.TabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.Page1.SuspendLayout()
        CType(Me.txtRua.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Page2.SuspendLayout()
        CType(Me.txtLocalizar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.TabControl)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(401, 168)
        Me.PanelControl1.TabIndex = 0
        '
        'TabControl
        '
        Me.TabControl.Location = New System.Drawing.Point(6, 6)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedTabPage = Me.Page1
        Me.TabControl.Size = New System.Drawing.Size(390, 159)
        Me.TabControl.TabIndex = 0
        Me.TabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.Page1, Me.Page2})
        '
        'Page1
        '
        Me.Page1.Controls.Add(Me.lblRua)
        Me.Page1.Controls.Add(Me.lblNome)
        Me.Page1.Controls.Add(Me.txtRua)
        Me.Page1.Controls.Add(Me.txtNome)
        Me.Page1.Controls.Add(Me.btnAdd)
        Me.Page1.Name = "Page1"
        Me.Page1.Size = New System.Drawing.Size(384, 132)
        Me.Page1.Text = "&Cadastro"
        '
        'lblRua
        '
        Me.lblRua.Location = New System.Drawing.Point(28, 47)
        Me.lblRua.Name = "lblRua"
        Me.lblRua.Size = New System.Drawing.Size(23, 13)
        Me.lblRua.TabIndex = 2
        Me.lblRua.Text = "Rua:"
        '
        'lblNome
        '
        Me.lblNome.Location = New System.Drawing.Point(20, 21)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(31, 13)
        Me.lblNome.TabIndex = 2
        Me.lblNome.Text = "Nome:"
        '
        'txtRua
        '
        Me.txtRua.Enabled = False
        Me.txtRua.Location = New System.Drawing.Point(57, 44)
        Me.txtRua.Name = "txtRua"
        Me.txtRua.Size = New System.Drawing.Size(315, 20)
        Me.txtRua.TabIndex = 1
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(57, 18)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(315, 20)
        Me.txtNome.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(281, 87)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&Cadastrar"
        '
        'Page2
        '
        Me.Page2.Controls.Add(Me.dg)
        Me.Page2.Controls.Add(Me.txtLocalizar)
        Me.Page2.Name = "Page2"
        Me.Page2.Size = New System.Drawing.Size(384, 132)
        Me.Page2.Text = "&Localizar"
        '
        'txtLocalizar
        '
        Me.txtLocalizar.Location = New System.Drawing.Point(5, 3)
        Me.txtLocalizar.Name = "txtLocalizar"
        Me.txtLocalizar.Size = New System.Drawing.Size(376, 20)
        Me.txtLocalizar.TabIndex = 0
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AllowUserToOrderColumns = True
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(4, 30)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.Size = New System.Drawing.Size(377, 98)
        Me.dg.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 168)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "Form1"
        Me.Text = "Teste DB - SQL Express"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.TabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.Page1.ResumeLayout(False)
        Me.Page1.PerformLayout()
        CType(Me.txtRua.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Page2.ResumeLayout(False)
        CType(Me.txtLocalizar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents Page1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblRua As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNome As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRua As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNome As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Page2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents txtLocalizar As DevExpress.XtraEditors.TextEdit

End Class
