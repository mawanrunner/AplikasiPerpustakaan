<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInfoTambahKoleksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblKategori = New System.Windows.Forms.Label()
        Me.LblTanggalMasukKoleksi = New System.Windows.Forms.Label()
        Me.LblBahasa = New System.Windows.Forms.Label()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.LblLokasiRak = New System.Windows.Forms.Label()
        Me.LblTahunTerbit = New System.Windows.Forms.Label()
        Me.LblPenerbit = New System.Windows.Forms.Label()
        Me.LblDeskripsi = New System.Windows.Forms.Label()
        Me.LblJenisKoleksi = New System.Windows.Forms.Label()
        Me.LblNamaKoleksi = New System.Windows.Forms.Label()
        Me.PicBukuValue = New System.Windows.Forms.PictureBox()
        Me.LblNamaKoleksiValue = New System.Windows.Forms.Label()
        Me.LblJenisKoleksiValue = New System.Windows.Forms.Label()
        Me.LblDeskripsiValue = New System.Windows.Forms.Label()
        Me.LblPenerbitValue = New System.Windows.Forms.Label()
        Me.LblTahunTerbitValue = New System.Windows.Forms.Label()
        Me.LblLokasiRakValue = New System.Windows.Forms.Label()
        Me.LblTanggalMasukKoleksiValue = New System.Windows.Forms.Label()
        Me.LblStockValue = New System.Windows.Forms.Label()
        Me.LblBahasaValue = New System.Windows.Forms.Label()
        Me.ListBoxKategoriValue = New System.Windows.Forms.ListBox()
        Me.BtnTutup = New System.Windows.Forms.Button()
        CType(Me.PicBukuValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblKategori
        '
        Me.LblKategori.AutoSize = True
        Me.LblKategori.Location = New System.Drawing.Point(131, 330)
        Me.LblKategori.Name = "LblKategori"
        Me.LblKategori.Size = New System.Drawing.Size(46, 13)
        Me.LblKategori.TabIndex = 13
        Me.LblKategori.Text = "Kategori"
        '
        'LblTanggalMasukKoleksi
        '
        Me.LblTanggalMasukKoleksi.AutoSize = True
        Me.LblTanggalMasukKoleksi.Location = New System.Drawing.Point(131, 252)
        Me.LblTanggalMasukKoleksi.Name = "LblTanggalMasukKoleksi"
        Me.LblTanggalMasukKoleksi.Size = New System.Drawing.Size(118, 13)
        Me.LblTanggalMasukKoleksi.TabIndex = 14
        Me.LblTanggalMasukKoleksi.Text = "Tanggal Masuk Koleksi"
        '
        'LblBahasa
        '
        Me.LblBahasa.AutoSize = True
        Me.LblBahasa.Location = New System.Drawing.Point(131, 303)
        Me.LblBahasa.Name = "LblBahasa"
        Me.LblBahasa.Size = New System.Drawing.Size(43, 13)
        Me.LblBahasa.TabIndex = 15
        Me.LblBahasa.Text = "Bahasa"
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.Location = New System.Drawing.Point(131, 277)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(35, 13)
        Me.LblStock.TabIndex = 16
        Me.LblStock.Text = "Stock"
        '
        'LblLokasiRak
        '
        Me.LblLokasiRak.AutoSize = True
        Me.LblLokasiRak.Location = New System.Drawing.Point(131, 222)
        Me.LblLokasiRak.Name = "LblLokasiRak"
        Me.LblLokasiRak.Size = New System.Drawing.Size(61, 13)
        Me.LblLokasiRak.TabIndex = 17
        Me.LblLokasiRak.Text = "Lokasi Rak"
        '
        'LblTahunTerbit
        '
        Me.LblTahunTerbit.AutoSize = True
        Me.LblTahunTerbit.Location = New System.Drawing.Point(131, 196)
        Me.LblTahunTerbit.Name = "LblTahunTerbit"
        Me.LblTahunTerbit.Size = New System.Drawing.Size(68, 13)
        Me.LblTahunTerbit.TabIndex = 18
        Me.LblTahunTerbit.Text = "Tahun Terbit"
        '
        'LblPenerbit
        '
        Me.LblPenerbit.AutoSize = True
        Me.LblPenerbit.Location = New System.Drawing.Point(131, 170)
        Me.LblPenerbit.Name = "LblPenerbit"
        Me.LblPenerbit.Size = New System.Drawing.Size(46, 13)
        Me.LblPenerbit.TabIndex = 19
        Me.LblPenerbit.Text = "Penerbit"
        '
        'LblDeskripsi
        '
        Me.LblDeskripsi.AutoSize = True
        Me.LblDeskripsi.Location = New System.Drawing.Point(131, 65)
        Me.LblDeskripsi.Name = "LblDeskripsi"
        Me.LblDeskripsi.Size = New System.Drawing.Size(50, 13)
        Me.LblDeskripsi.TabIndex = 12
        Me.LblDeskripsi.Text = "Deskripsi"
        '
        'LblJenisKoleksi
        '
        Me.LblJenisKoleksi.AutoSize = True
        Me.LblJenisKoleksi.Location = New System.Drawing.Point(131, 38)
        Me.LblJenisKoleksi.Name = "LblJenisKoleksi"
        Me.LblJenisKoleksi.Size = New System.Drawing.Size(68, 13)
        Me.LblJenisKoleksi.TabIndex = 11
        Me.LblJenisKoleksi.Text = "Jenis Koleksi"
        '
        'LblNamaKoleksi
        '
        Me.LblNamaKoleksi.AutoSize = True
        Me.LblNamaKoleksi.Location = New System.Drawing.Point(131, 12)
        Me.LblNamaKoleksi.Name = "LblNamaKoleksi"
        Me.LblNamaKoleksi.Size = New System.Drawing.Size(72, 13)
        Me.LblNamaKoleksi.TabIndex = 10
        Me.LblNamaKoleksi.Text = "Nama Koleksi"
        '
        'PicBukuValue
        '
        Me.PicBukuValue.Location = New System.Drawing.Point(12, 12)
        Me.PicBukuValue.Name = "PicBukuValue"
        Me.PicBukuValue.Size = New System.Drawing.Size(100, 135)
        Me.PicBukuValue.TabIndex = 20
        Me.PicBukuValue.TabStop = False
        '
        'LblNamaKoleksiValue
        '
        Me.LblNamaKoleksiValue.AutoSize = True
        Me.LblNamaKoleksiValue.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaKoleksiValue.Location = New System.Drawing.Point(276, 12)
        Me.LblNamaKoleksiValue.MaximumSize = New System.Drawing.Size(180, 0)
        Me.LblNamaKoleksiValue.MinimumSize = New System.Drawing.Size(180, 0)
        Me.LblNamaKoleksiValue.Name = "LblNamaKoleksiValue"
        Me.LblNamaKoleksiValue.Size = New System.Drawing.Size(180, 14)
        Me.LblNamaKoleksiValue.TabIndex = 21
        Me.LblNamaKoleksiValue.Text = "Nama Koleksi"
        '
        'LblJenisKoleksiValue
        '
        Me.LblJenisKoleksiValue.AutoSize = True
        Me.LblJenisKoleksiValue.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenisKoleksiValue.Location = New System.Drawing.Point(276, 38)
        Me.LblJenisKoleksiValue.Name = "LblJenisKoleksiValue"
        Me.LblJenisKoleksiValue.Size = New System.Drawing.Size(73, 14)
        Me.LblJenisKoleksiValue.TabIndex = 22
        Me.LblJenisKoleksiValue.Text = "Jenis Koleksi"
        '
        'LblDeskripsiValue
        '
        Me.LblDeskripsiValue.AutoSize = True
        Me.LblDeskripsiValue.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDeskripsiValue.Location = New System.Drawing.Point(276, 65)
        Me.LblDeskripsiValue.MaximumSize = New System.Drawing.Size(180, 80)
        Me.LblDeskripsiValue.MinimumSize = New System.Drawing.Size(180, 80)
        Me.LblDeskripsiValue.Name = "LblDeskripsiValue"
        Me.LblDeskripsiValue.Size = New System.Drawing.Size(180, 80)
        Me.LblDeskripsiValue.TabIndex = 21
        Me.LblDeskripsiValue.Text = "Deksripsi"
        '
        'LblPenerbitValue
        '
        Me.LblPenerbitValue.AutoSize = True
        Me.LblPenerbitValue.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPenerbitValue.Location = New System.Drawing.Point(276, 170)
        Me.LblPenerbitValue.MaximumSize = New System.Drawing.Size(180, 0)
        Me.LblPenerbitValue.MinimumSize = New System.Drawing.Size(180, 0)
        Me.LblPenerbitValue.Name = "LblPenerbitValue"
        Me.LblPenerbitValue.Size = New System.Drawing.Size(180, 14)
        Me.LblPenerbitValue.TabIndex = 21
        Me.LblPenerbitValue.Text = "Penerbit"
        '
        'LblTahunTerbitValue
        '
        Me.LblTahunTerbitValue.AutoSize = True
        Me.LblTahunTerbitValue.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTahunTerbitValue.Location = New System.Drawing.Point(276, 196)
        Me.LblTahunTerbitValue.Name = "LblTahunTerbitValue"
        Me.LblTahunTerbitValue.Size = New System.Drawing.Size(73, 14)
        Me.LblTahunTerbitValue.TabIndex = 21
        Me.LblTahunTerbitValue.Text = "Tahun Terbit"
        '
        'LblLokasiRakValue
        '
        Me.LblLokasiRakValue.AutoSize = True
        Me.LblLokasiRakValue.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLokasiRakValue.Location = New System.Drawing.Point(276, 222)
        Me.LblLokasiRakValue.Name = "LblLokasiRakValue"
        Me.LblLokasiRakValue.Size = New System.Drawing.Size(62, 14)
        Me.LblLokasiRakValue.TabIndex = 21
        Me.LblLokasiRakValue.Text = "Lokasi Rak"
        '
        'LblTanggalMasukKoleksiValue
        '
        Me.LblTanggalMasukKoleksiValue.AutoSize = True
        Me.LblTanggalMasukKoleksiValue.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTanggalMasukKoleksiValue.Location = New System.Drawing.Point(276, 252)
        Me.LblTanggalMasukKoleksiValue.Name = "LblTanggalMasukKoleksiValue"
        Me.LblTanggalMasukKoleksiValue.Size = New System.Drawing.Size(127, 14)
        Me.LblTanggalMasukKoleksiValue.TabIndex = 21
        Me.LblTanggalMasukKoleksiValue.Text = "Tanggal Masuk Koleksi"
        '
        'LblStockValue
        '
        Me.LblStockValue.AutoSize = True
        Me.LblStockValue.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStockValue.Location = New System.Drawing.Point(276, 277)
        Me.LblStockValue.Name = "LblStockValue"
        Me.LblStockValue.Size = New System.Drawing.Size(35, 14)
        Me.LblStockValue.TabIndex = 21
        Me.LblStockValue.Text = "Stock"
        '
        'LblBahasaValue
        '
        Me.LblBahasaValue.AutoSize = True
        Me.LblBahasaValue.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBahasaValue.Location = New System.Drawing.Point(276, 303)
        Me.LblBahasaValue.Name = "LblBahasaValue"
        Me.LblBahasaValue.Size = New System.Drawing.Size(44, 14)
        Me.LblBahasaValue.TabIndex = 21
        Me.LblBahasaValue.Text = "Bahasa"
        '
        'ListBoxKategoriValue
        '
        Me.ListBoxKategoriValue.FormattingEnabled = True
        Me.ListBoxKategoriValue.Location = New System.Drawing.Point(279, 330)
        Me.ListBoxKategoriValue.Name = "ListBoxKategoriValue"
        Me.ListBoxKategoriValue.Size = New System.Drawing.Size(179, 95)
        Me.ListBoxKategoriValue.TabIndex = 23
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(200, 452)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 23)
        Me.BtnTutup.TabIndex = 24
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'FormInfoTambahKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 487)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.ListBoxKategoriValue)
        Me.Controls.Add(Me.LblJenisKoleksiValue)
        Me.Controls.Add(Me.LblBahasaValue)
        Me.Controls.Add(Me.LblStockValue)
        Me.Controls.Add(Me.LblTanggalMasukKoleksiValue)
        Me.Controls.Add(Me.LblLokasiRakValue)
        Me.Controls.Add(Me.LblTahunTerbitValue)
        Me.Controls.Add(Me.LblPenerbitValue)
        Me.Controls.Add(Me.LblDeskripsiValue)
        Me.Controls.Add(Me.LblNamaKoleksiValue)
        Me.Controls.Add(Me.PicBukuValue)
        Me.Controls.Add(Me.LblKategori)
        Me.Controls.Add(Me.LblTanggalMasukKoleksi)
        Me.Controls.Add(Me.LblBahasa)
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.LblLokasiRak)
        Me.Controls.Add(Me.LblTahunTerbit)
        Me.Controls.Add(Me.LblPenerbit)
        Me.Controls.Add(Me.LblDeskripsi)
        Me.Controls.Add(Me.LblJenisKoleksi)
        Me.Controls.Add(Me.LblNamaKoleksi)
        Me.Name = "FormInfoTambahKoleksi"
        Me.Text = "Info Koleksi"
        CType(Me.PicBukuValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblKategori As Label
    Friend WithEvents LblTanggalMasukKoleksi As Label
    Friend WithEvents LblBahasa As Label
    Friend WithEvents LblStock As Label
    Friend WithEvents LblLokasiRak As Label
    Friend WithEvents LblTahunTerbit As Label
    Friend WithEvents LblPenerbit As Label
    Friend WithEvents LblDeskripsi As Label
    Friend WithEvents LblJenisKoleksi As Label
    Friend WithEvents LblNamaKoleksi As Label
    Friend WithEvents PicBukuValue As PictureBox
    Friend WithEvents LblNamaKoleksiValue As Label
    Friend WithEvents LblJenisKoleksiValue As Label
    Friend WithEvents LblDeskripsiValue As Label
    Friend WithEvents LblPenerbitValue As Label
    Friend WithEvents LblTahunTerbitValue As Label
    Friend WithEvents LblLokasiRakValue As Label
    Friend WithEvents LblTanggalMasukKoleksiValue As Label
    Friend WithEvents LblStockValue As Label
    Friend WithEvents LblBahasaValue As Label
    Friend WithEvents ListBoxKategoriValue As ListBox
    Friend WithEvents BtnTutup As Button
End Class
