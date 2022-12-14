<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPerpustakaan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPerpustakaan))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonTambahKoleksi = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonHapusKoleksi = New System.Windows.Forms.ToolStripButton()
        Me.DataGridKoleksi = New System.Windows.Forms.DataGridView()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.ListBoxKoleksiBuku = New System.Windows.Forms.ListBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1071, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksiToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahKoleksiToolStripMenuItem
        '
        Me.TambahKoleksiToolStripMenuItem.Name = "TambahKoleksiToolStripMenuItem"
        Me.TambahKoleksiToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.TambahKoleksiToolStripMenuItem.Text = "Tambah Koleksi"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonTambahKoleksi, Me.ToolStripButtonHapusKoleksi})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1071, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButtonTambahKoleksi
        '
        Me.ToolStripButtonTambahKoleksi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonTambahKoleksi.Image = CType(resources.GetObject("ToolStripButtonTambahKoleksi.Image"), System.Drawing.Image)
        Me.ToolStripButtonTambahKoleksi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonTambahKoleksi.Name = "ToolStripButtonTambahKoleksi"
        Me.ToolStripButtonTambahKoleksi.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonTambahKoleksi.Text = "ToolStripButtonTambahKoleksi"
        '
        'ToolStripButtonHapusKoleksi
        '
        Me.ToolStripButtonHapusKoleksi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonHapusKoleksi.Image = CType(resources.GetObject("ToolStripButtonHapusKoleksi.Image"), System.Drawing.Image)
        Me.ToolStripButtonHapusKoleksi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonHapusKoleksi.Name = "ToolStripButtonHapusKoleksi"
        Me.ToolStripButtonHapusKoleksi.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonHapusKoleksi.Text = "ToolStripButton2"
        '
        'DataGridKoleksi
        '
        Me.DataGridKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKoleksi.Location = New System.Drawing.Point(12, 228)
        Me.DataGridKoleksi.Name = "DataGridKoleksi"
        Me.DataGridKoleksi.Size = New System.Drawing.Size(1045, 150)
        Me.DataGridKoleksi.TabIndex = 3
        '
        'BtnSelect
        '
        Me.BtnSelect.Location = New System.Drawing.Point(981, 387)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(75, 23)
        Me.BtnSelect.TabIndex = 4
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'ListBoxKoleksiBuku
        '
        Me.ListBoxKoleksiBuku.FormattingEnabled = True
        Me.ListBoxKoleksiBuku.Location = New System.Drawing.Point(12, 52)
        Me.ListBoxKoleksiBuku.Name = "ListBoxKoleksiBuku"
        Me.ListBoxKoleksiBuku.Size = New System.Drawing.Size(1045, 160)
        Me.ListBoxKoleksiBuku.TabIndex = 2
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(819, 387)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 5
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(900, 387)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 5
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'FormPerpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 424)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.DataGridKoleksi)
        Me.Controls.Add(Me.ListBoxKoleksiBuku)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormPerpustakaan"
        Me.Text = "Perpustakaan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButtonTambahKoleksi As ToolStripButton
    Friend WithEvents ToolStripButtonHapusKoleksi As ToolStripButton
    Friend WithEvents DataGridKoleksi As DataGridView
    Friend WithEvents BtnSelect As Button
    Friend WithEvents ListBoxKoleksiBuku As ListBox
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
End Class
