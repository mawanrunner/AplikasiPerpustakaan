<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateKoleksi
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
        Me.BtnUpdateKoleksi = New System.Windows.Forms.Button()
        Me.BtnUpdateGambar = New System.Windows.Forms.Button()
        Me.GBKategori = New System.Windows.Forms.GroupBox()
        Me.CBBudaya = New System.Windows.Forms.CheckBox()
        Me.CBTeknologi = New System.Windows.Forms.CheckBox()
        Me.CBSosial = New System.Windows.Forms.CheckBox()
        Me.CBSains = New System.Windows.Forms.CheckBox()
        Me.GBBahasa = New System.Windows.Forms.GroupBox()
        Me.RDInggris = New System.Windows.Forms.RadioButton()
        Me.RDIndonesia = New System.Windows.Forms.RadioButton()
        Me.DateTimePickerTanggalMasukKoleksi = New System.Windows.Forms.DateTimePicker()
        Me.LblKategori = New System.Windows.Forms.Label()
        Me.LblTanggalMasukKoleksi = New System.Windows.Forms.Label()
        Me.LblBahasa = New System.Windows.Forms.Label()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.TxtLokasiRak = New System.Windows.Forms.TextBox()
        Me.LblLokasiRak = New System.Windows.Forms.Label()
        Me.TxtTahunTerbit = New System.Windows.Forms.TextBox()
        Me.LblTahunTerbit = New System.Windows.Forms.Label()
        Me.TxtPenerbit = New System.Windows.Forms.TextBox()
        Me.LblPenerbit = New System.Windows.Forms.Label()
        Me.RTxtDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.LblDeskripsi = New System.Windows.Forms.Label()
        Me.CBJenisKoleksi = New System.Windows.Forms.ComboBox()
        Me.LblJenisKoleksi = New System.Windows.Forms.Label()
        Me.TxtNamaKoleksi = New System.Windows.Forms.TextBox()
        Me.LblNamaKoleksi = New System.Windows.Forms.Label()
        Me.PicBuku = New System.Windows.Forms.PictureBox()
        Me.LblTambahKoleksi = New System.Windows.Forms.Label()
        Me.OpenFileDialogFoto = New System.Windows.Forms.OpenFileDialog()
        Me.GBKategori.SuspendLayout()
        Me.GBBahasa.SuspendLayout()
        CType(Me.PicBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnUpdateKoleksi
        '
        Me.BtnUpdateKoleksi.Location = New System.Drawing.Point(213, 563)
        Me.BtnUpdateKoleksi.Name = "BtnUpdateKoleksi"
        Me.BtnUpdateKoleksi.Size = New System.Drawing.Size(100, 23)
        Me.BtnUpdateKoleksi.TabIndex = 37
        Me.BtnUpdateKoleksi.Text = "Update Koleksi"
        Me.BtnUpdateKoleksi.UseVisualStyleBackColor = True
        '
        'BtnUpdateGambar
        '
        Me.BtnUpdateGambar.Location = New System.Drawing.Point(16, 192)
        Me.BtnUpdateGambar.Name = "BtnUpdateGambar"
        Me.BtnUpdateGambar.Size = New System.Drawing.Size(100, 23)
        Me.BtnUpdateGambar.TabIndex = 36
        Me.BtnUpdateGambar.Text = "Update Gambar"
        Me.BtnUpdateGambar.UseVisualStyleBackColor = True
        '
        'GBKategori
        '
        Me.GBKategori.Controls.Add(Me.CBBudaya)
        Me.GBKategori.Controls.Add(Me.CBTeknologi)
        Me.GBKategori.Controls.Add(Me.CBSosial)
        Me.GBKategori.Controls.Add(Me.CBSains)
        Me.GBKategori.Location = New System.Drawing.Point(309, 421)
        Me.GBKategori.Name = "GBKategori"
        Me.GBKategori.Size = New System.Drawing.Size(207, 116)
        Me.GBKategori.TabIndex = 35
        Me.GBKategori.TabStop = False
        Me.GBKategori.Text = "Kategori"
        '
        'CBBudaya
        '
        Me.CBBudaya.AutoSize = True
        Me.CBBudaya.Location = New System.Drawing.Point(11, 89)
        Me.CBBudaya.Name = "CBBudaya"
        Me.CBBudaya.Size = New System.Drawing.Size(62, 17)
        Me.CBBudaya.TabIndex = 0
        Me.CBBudaya.Text = "Budaya"
        Me.CBBudaya.UseVisualStyleBackColor = True
        '
        'CBTeknologi
        '
        Me.CBTeknologi.AutoSize = True
        Me.CBTeknologi.Location = New System.Drawing.Point(11, 66)
        Me.CBTeknologi.Name = "CBTeknologi"
        Me.CBTeknologi.Size = New System.Drawing.Size(73, 17)
        Me.CBTeknologi.TabIndex = 0
        Me.CBTeknologi.Text = "Teknologi"
        Me.CBTeknologi.UseVisualStyleBackColor = True
        '
        'CBSosial
        '
        Me.CBSosial.AutoSize = True
        Me.CBSosial.Location = New System.Drawing.Point(11, 43)
        Me.CBSosial.Name = "CBSosial"
        Me.CBSosial.Size = New System.Drawing.Size(54, 17)
        Me.CBSosial.TabIndex = 0
        Me.CBSosial.Text = "Sosial"
        Me.CBSosial.UseVisualStyleBackColor = True
        '
        'CBSains
        '
        Me.CBSains.AutoSize = True
        Me.CBSains.Location = New System.Drawing.Point(12, 20)
        Me.CBSains.Name = "CBSains"
        Me.CBSains.Size = New System.Drawing.Size(52, 17)
        Me.CBSains.TabIndex = 0
        Me.CBSains.Text = "Sains"
        Me.CBSains.UseVisualStyleBackColor = True
        '
        'GBBahasa
        '
        Me.GBBahasa.Controls.Add(Me.RDInggris)
        Me.GBBahasa.Controls.Add(Me.RDIndonesia)
        Me.GBBahasa.Location = New System.Drawing.Point(309, 342)
        Me.GBBahasa.Name = "GBBahasa"
        Me.GBBahasa.Size = New System.Drawing.Size(207, 73)
        Me.GBBahasa.TabIndex = 34
        Me.GBBahasa.TabStop = False
        Me.GBBahasa.Text = "Bahasa"
        '
        'RDInggris
        '
        Me.RDInggris.AutoSize = True
        Me.RDInggris.Location = New System.Drawing.Point(11, 43)
        Me.RDInggris.Name = "RDInggris"
        Me.RDInggris.Size = New System.Drawing.Size(95, 17)
        Me.RDInggris.TabIndex = 0
        Me.RDInggris.TabStop = True
        Me.RDInggris.Text = "Bahasa Inggris"
        Me.RDInggris.UseVisualStyleBackColor = True
        '
        'RDIndonesia
        '
        Me.RDIndonesia.AutoSize = True
        Me.RDIndonesia.Location = New System.Drawing.Point(12, 20)
        Me.RDIndonesia.Name = "RDIndonesia"
        Me.RDIndonesia.Size = New System.Drawing.Size(110, 17)
        Me.RDIndonesia.TabIndex = 0
        Me.RDIndonesia.TabStop = True
        Me.RDIndonesia.Text = "Bahasa Indonesia"
        Me.RDIndonesia.UseVisualStyleBackColor = True
        '
        'DateTimePickerTanggalMasukKoleksi
        '
        Me.DateTimePickerTanggalMasukKoleksi.Location = New System.Drawing.Point(309, 287)
        Me.DateTimePickerTanggalMasukKoleksi.Name = "DateTimePickerTanggalMasukKoleksi"
        Me.DateTimePickerTanggalMasukKoleksi.Size = New System.Drawing.Size(207, 20)
        Me.DateTimePickerTanggalMasukKoleksi.TabIndex = 33
        '
        'LblKategori
        '
        Me.LblKategori.AutoSize = True
        Me.LblKategori.Location = New System.Drawing.Point(163, 421)
        Me.LblKategori.Name = "LblKategori"
        Me.LblKategori.Size = New System.Drawing.Size(46, 13)
        Me.LblKategori.TabIndex = 28
        Me.LblKategori.Text = "Kategori"
        '
        'LblTanggalMasukKoleksi
        '
        Me.LblTanggalMasukKoleksi.AutoSize = True
        Me.LblTanggalMasukKoleksi.Location = New System.Drawing.Point(163, 291)
        Me.LblTanggalMasukKoleksi.Name = "LblTanggalMasukKoleksi"
        Me.LblTanggalMasukKoleksi.Size = New System.Drawing.Size(118, 13)
        Me.LblTanggalMasukKoleksi.TabIndex = 27
        Me.LblTanggalMasukKoleksi.Text = "Tanggal Masuk Koleksi"
        '
        'LblBahasa
        '
        Me.LblBahasa.AutoSize = True
        Me.LblBahasa.Location = New System.Drawing.Point(163, 342)
        Me.LblBahasa.Name = "LblBahasa"
        Me.LblBahasa.Size = New System.Drawing.Size(43, 13)
        Me.LblBahasa.TabIndex = 26
        Me.LblBahasa.Text = "Bahasa"
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(309, 313)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(207, 20)
        Me.TxtStock.TabIndex = 30
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.Location = New System.Drawing.Point(163, 316)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(35, 13)
        Me.LblStock.TabIndex = 25
        Me.LblStock.Text = "Stock"
        '
        'TxtLokasiRak
        '
        Me.TxtLokasiRak.Location = New System.Drawing.Point(309, 258)
        Me.TxtLokasiRak.Name = "TxtLokasiRak"
        Me.TxtLokasiRak.Size = New System.Drawing.Size(207, 20)
        Me.TxtLokasiRak.TabIndex = 32
        '
        'LblLokasiRak
        '
        Me.LblLokasiRak.AutoSize = True
        Me.LblLokasiRak.Location = New System.Drawing.Point(163, 261)
        Me.LblLokasiRak.Name = "LblLokasiRak"
        Me.LblLokasiRak.Size = New System.Drawing.Size(61, 13)
        Me.LblLokasiRak.TabIndex = 24
        Me.LblLokasiRak.Text = "Lokasi Rak"
        '
        'TxtTahunTerbit
        '
        Me.TxtTahunTerbit.Location = New System.Drawing.Point(309, 232)
        Me.TxtTahunTerbit.Name = "TxtTahunTerbit"
        Me.TxtTahunTerbit.Size = New System.Drawing.Size(207, 20)
        Me.TxtTahunTerbit.TabIndex = 29
        '
        'LblTahunTerbit
        '
        Me.LblTahunTerbit.AutoSize = True
        Me.LblTahunTerbit.Location = New System.Drawing.Point(163, 235)
        Me.LblTahunTerbit.Name = "LblTahunTerbit"
        Me.LblTahunTerbit.Size = New System.Drawing.Size(68, 13)
        Me.LblTahunTerbit.TabIndex = 23
        Me.LblTahunTerbit.Text = "Tahun Terbit"
        '
        'TxtPenerbit
        '
        Me.TxtPenerbit.Location = New System.Drawing.Point(309, 206)
        Me.TxtPenerbit.Name = "TxtPenerbit"
        Me.TxtPenerbit.Size = New System.Drawing.Size(207, 20)
        Me.TxtPenerbit.TabIndex = 31
        '
        'LblPenerbit
        '
        Me.LblPenerbit.AutoSize = True
        Me.LblPenerbit.Location = New System.Drawing.Point(163, 209)
        Me.LblPenerbit.Name = "LblPenerbit"
        Me.LblPenerbit.Size = New System.Drawing.Size(46, 13)
        Me.LblPenerbit.TabIndex = 22
        Me.LblPenerbit.Text = "Penerbit"
        '
        'RTxtDeskripsi
        '
        Me.RTxtDeskripsi.Location = New System.Drawing.Point(309, 104)
        Me.RTxtDeskripsi.Name = "RTxtDeskripsi"
        Me.RTxtDeskripsi.Size = New System.Drawing.Size(207, 96)
        Me.RTxtDeskripsi.TabIndex = 21
        Me.RTxtDeskripsi.Text = ""
        '
        'LblDeskripsi
        '
        Me.LblDeskripsi.AutoSize = True
        Me.LblDeskripsi.Location = New System.Drawing.Point(163, 104)
        Me.LblDeskripsi.Name = "LblDeskripsi"
        Me.LblDeskripsi.Size = New System.Drawing.Size(50, 13)
        Me.LblDeskripsi.TabIndex = 20
        Me.LblDeskripsi.Text = "Deskripsi"
        '
        'CBJenisKoleksi
        '
        Me.CBJenisKoleksi.FormattingEnabled = True
        Me.CBJenisKoleksi.Items.AddRange(New Object() {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi", "Penelitian"})
        Me.CBJenisKoleksi.Location = New System.Drawing.Point(309, 74)
        Me.CBJenisKoleksi.Name = "CBJenisKoleksi"
        Me.CBJenisKoleksi.Size = New System.Drawing.Size(207, 21)
        Me.CBJenisKoleksi.TabIndex = 19
        '
        'LblJenisKoleksi
        '
        Me.LblJenisKoleksi.AutoSize = True
        Me.LblJenisKoleksi.Location = New System.Drawing.Point(163, 77)
        Me.LblJenisKoleksi.Name = "LblJenisKoleksi"
        Me.LblJenisKoleksi.Size = New System.Drawing.Size(68, 13)
        Me.LblJenisKoleksi.TabIndex = 18
        Me.LblJenisKoleksi.Text = "Jenis Koleksi"
        '
        'TxtNamaKoleksi
        '
        Me.TxtNamaKoleksi.Location = New System.Drawing.Point(309, 48)
        Me.TxtNamaKoleksi.Name = "TxtNamaKoleksi"
        Me.TxtNamaKoleksi.Size = New System.Drawing.Size(207, 20)
        Me.TxtNamaKoleksi.TabIndex = 17
        '
        'LblNamaKoleksi
        '
        Me.LblNamaKoleksi.AutoSize = True
        Me.LblNamaKoleksi.Location = New System.Drawing.Point(163, 51)
        Me.LblNamaKoleksi.Name = "LblNamaKoleksi"
        Me.LblNamaKoleksi.Size = New System.Drawing.Size(72, 13)
        Me.LblNamaKoleksi.TabIndex = 16
        Me.LblNamaKoleksi.Text = "Nama Koleksi"
        '
        'PicBuku
        '
        Me.PicBuku.Location = New System.Drawing.Point(16, 51)
        Me.PicBuku.Name = "PicBuku"
        Me.PicBuku.Size = New System.Drawing.Size(100, 135)
        Me.PicBuku.TabIndex = 15
        Me.PicBuku.TabStop = False
        '
        'LblTambahKoleksi
        '
        Me.LblTambahKoleksi.AutoSize = True
        Me.LblTambahKoleksi.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTambahKoleksi.Location = New System.Drawing.Point(12, 11)
        Me.LblTambahKoleksi.Name = "LblTambahKoleksi"
        Me.LblTambahKoleksi.Size = New System.Drawing.Size(143, 23)
        Me.LblTambahKoleksi.TabIndex = 14
        Me.LblTambahKoleksi.Text = "Update Koleksi"
        '
        'OpenFileDialogFoto
        '
        Me.OpenFileDialogFoto.FileName = "OpenFileDialogFoto"
        '
        'FormUpdateKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 596)
        Me.Controls.Add(Me.BtnUpdateKoleksi)
        Me.Controls.Add(Me.BtnUpdateGambar)
        Me.Controls.Add(Me.GBKategori)
        Me.Controls.Add(Me.GBBahasa)
        Me.Controls.Add(Me.DateTimePickerTanggalMasukKoleksi)
        Me.Controls.Add(Me.LblKategori)
        Me.Controls.Add(Me.LblTanggalMasukKoleksi)
        Me.Controls.Add(Me.LblBahasa)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.TxtLokasiRak)
        Me.Controls.Add(Me.LblLokasiRak)
        Me.Controls.Add(Me.TxtTahunTerbit)
        Me.Controls.Add(Me.LblTahunTerbit)
        Me.Controls.Add(Me.TxtPenerbit)
        Me.Controls.Add(Me.LblPenerbit)
        Me.Controls.Add(Me.RTxtDeskripsi)
        Me.Controls.Add(Me.LblDeskripsi)
        Me.Controls.Add(Me.CBJenisKoleksi)
        Me.Controls.Add(Me.LblJenisKoleksi)
        Me.Controls.Add(Me.TxtNamaKoleksi)
        Me.Controls.Add(Me.LblNamaKoleksi)
        Me.Controls.Add(Me.PicBuku)
        Me.Controls.Add(Me.LblTambahKoleksi)
        Me.Name = "FormUpdateKoleksi"
        Me.Text = "Updata Koleksi"
        Me.GBKategori.ResumeLayout(False)
        Me.GBKategori.PerformLayout()
        Me.GBBahasa.ResumeLayout(False)
        Me.GBBahasa.PerformLayout()
        CType(Me.PicBuku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnUpdateKoleksi As Button
    Friend WithEvents BtnUpdateGambar As Button
    Friend WithEvents GBKategori As GroupBox
    Friend WithEvents CBBudaya As CheckBox
    Friend WithEvents CBTeknologi As CheckBox
    Friend WithEvents CBSosial As CheckBox
    Friend WithEvents CBSains As CheckBox
    Friend WithEvents GBBahasa As GroupBox
    Friend WithEvents RDInggris As RadioButton
    Friend WithEvents RDIndonesia As RadioButton
    Friend WithEvents DateTimePickerTanggalMasukKoleksi As DateTimePicker
    Friend WithEvents LblKategori As Label
    Friend WithEvents LblTanggalMasukKoleksi As Label
    Friend WithEvents LblBahasa As Label
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents LblStock As Label
    Friend WithEvents TxtLokasiRak As TextBox
    Friend WithEvents LblLokasiRak As Label
    Friend WithEvents TxtTahunTerbit As TextBox
    Friend WithEvents LblTahunTerbit As Label
    Friend WithEvents TxtPenerbit As TextBox
    Friend WithEvents LblPenerbit As Label
    Friend WithEvents RTxtDeskripsi As RichTextBox
    Friend WithEvents LblDeskripsi As Label
    Friend WithEvents CBJenisKoleksi As ComboBox
    Friend WithEvents LblJenisKoleksi As Label
    Friend WithEvents TxtNamaKoleksi As TextBox
    Friend WithEvents LblNamaKoleksi As Label
    Friend WithEvents PicBuku As PictureBox
    Friend WithEvents LblTambahKoleksi As Label
    Friend WithEvents OpenFileDialogFoto As OpenFileDialog
End Class
