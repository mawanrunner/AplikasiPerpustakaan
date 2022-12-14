Public Class FormTambahKoleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        DateTimePickerTanggalMasukKoleksi.Format = DateTimePickerFormat.Custom
        DateTimePickerTanggalMasukKoleksi.CustomFormat = "yyyy/MM/dd"

    End Sub

    Private Sub BtnTambahKoleksi_Click(sender As Object, e As EventArgs) Handles BtnTambahKoleksi.Click

        If CBSains.Checked Then
            FormPerpustakaan.Koleksi.AddKategori("Sains")
        End If

        If CBSosial.Checked Then
            FormPerpustakaan.Koleksi.AddKategori("Sosial")
        End If

        If CBTeknologi.Checked Then
            FormPerpustakaan.Koleksi.AddKategori("Teknologi")
        End If

        If CBBudaya.Checked Then
            FormPerpustakaan.Koleksi.AddKategori("Budaya")
        End If

        FormPerpustakaan.Koleksi.GSNamaKoleksi = TxtNamaKoleksi.Text
        FormPerpustakaan.Koleksi.GSJenisKoleksi = CBJenisKoleksi.SelectedItem
        FormPerpustakaan.Koleksi.GSDeskripsi = RTxtDeskripsi.Text
        FormPerpustakaan.Koleksi.GSPenerbit = TxtPenerbit.Text
        FormPerpustakaan.Koleksi.GSTahunTerbit = Integer.Parse(TxtTahunTerbit.Text)
        FormPerpustakaan.Koleksi.GSLokasiRak = TxtLokasiRak.Text
        FormPerpustakaan.Koleksi.GSTanggalMasukKoleksi = DateTimePickerTanggalMasukKoleksi.Value.ToString("yyyy/MM/dd")
        FormPerpustakaan.Koleksi.GSStock = Integer.Parse(TxtStock.Text)

        Dim convertedKoleksi = FormPerpustakaan.Koleksi.ConvertKoleksiToString(FormPerpustakaan.Koleksi.getKategoriItem)

        FormPerpustakaan.Koleksi.AddDataKoleksiDatabase(FormPerpustakaan.Koleksi.GSGambarKoleksi,
                                                     FormPerpustakaan.Koleksi.GSNamaKoleksi,
                                                     FormPerpustakaan.Koleksi.GSJenisKoleksi,
                                                     FormPerpustakaan.Koleksi.GSPenerbit,
                                                     FormPerpustakaan.Koleksi.GSDeskripsi,
                                                     FormPerpustakaan.Koleksi.GSTahunTerbit,
                                                     FormPerpustakaan.Koleksi.GSLokasiRak,
                                                     FormPerpustakaan.Koleksi.GSTanggalMasukKoleksi,
                                                     FormPerpustakaan.Koleksi.GSStock,
                                                     FormPerpustakaan.Koleksi.GSBahasa,
                                                     convertedKoleksi)

        FormPerpustakaan.Koleksi.AddKoleksi(FormPerpustakaan.Koleksi.GSNamaKoleksi)

        Dim formInfoTambahKoleksi = New FormInfoTambahKoleksi()
        formInfoTambahKoleksi.Show()

        Me.Close()
    End Sub

    Private Sub RDIndonesia_CheckedChanged(sender As Object, e As EventArgs) Handles RDIndonesia.CheckedChanged
        FormPerpustakaan.Koleksi.GSBahasa = "Indonesia"
    End Sub

    Private Sub RDInggris_CheckedChanged(sender As Object, e As EventArgs) Handles RDInggris.CheckedChanged
        FormPerpustakaan.Koleksi.GSBahasa = "Inggris"
    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialogFoto.Title = "Open Foto"
        OpenFileDialogFoto.Filter = "All Format|*.*|Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif"
        OpenFileDialogFoto.ShowDialog()

        If Not String.IsNullOrEmpty(OpenFileDialogFoto.FileName) Then
            Dim picKoleksiDir As String = OpenFileDialogFoto.FileName
            FormPerpustakaan.Koleksi.GSGambarKoleksi = picKoleksiDir.ToString()
            FormPerpustakaan.Koleksi.GSGambarKoleksi = FormPerpustakaan.Koleksi.GSGambarKoleksi.Replace("\", "/")
            PicBuku.Load(OpenFileDialogFoto.FileName)
            PicBuku.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

End Class