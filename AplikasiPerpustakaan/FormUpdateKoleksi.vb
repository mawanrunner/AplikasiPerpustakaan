Public Class FormUpdateKoleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        If Not String.IsNullOrEmpty(FormPerpustakaan.Koleksi.GSGambarKoleksi) Then
            PicBuku.Load(FormPerpustakaan.Koleksi.GSGambarKoleksi)
            PicBuku.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        DateTimePickerTanggalMasukKoleksi.Format = DateTimePickerFormat.Custom
        DateTimePickerTanggalMasukKoleksi.CustomFormat = "yyyy/MM/dd"

        TxtNamaKoleksi.Text = FormPerpustakaan.Koleksi.GSNamaKoleksi
        CBJenisKoleksi.SelectedItem = FormPerpustakaan.Koleksi.GSJenisKoleksi
        RTxtDeskripsi.Text = FormPerpustakaan.Koleksi.GSDeskripsi
        TxtPenerbit.Text = FormPerpustakaan.Koleksi.GSPenerbit
        TxtTahunTerbit.Text = FormPerpustakaan.Koleksi.GSTahunTerbit
        TxtLokasiRak.Text = FormPerpustakaan.Koleksi.GSLokasiRak
        DateTimePickerTanggalMasukKoleksi.Value = FormPerpustakaan.Koleksi.GSTanggalMasukKoleksi
        TxtStock.Text = FormPerpustakaan.Koleksi.GSStock

        If String.Compare(FormPerpustakaan.Koleksi.GSBahasa, "Indonesia") = 0 Then
            RDIndonesia.Checked = True
        ElseIf String.Compare(FormPerpustakaan.Koleksi.GSBahasa, "Inggris") = 0 Then
            RDInggris.Checked = True
        End If

        For Each kat In FormPerpustakaan.Koleksi.getKategoriItem
            If String.Compare(kat, "Sains") = 0 Then
                CBSains.Checked = True
            ElseIf String.Compare(kat, "Sosial") = 0 Then
                CBSosial.Checked = True
            ElseIf String.Compare(kat, "Teknologi") = 0 Then
                CBTeknologi.Checked = True
            ElseIf String.Compare(kat, "Budaya") = 0 Then
                CBBudaya.Checked = True
            End If
        Next

        FormPerpustakaan.Koleksi.resetKategori()
    End Sub

    Private Sub BtnUpdateGambar_Click(sender As Object, e As EventArgs) Handles BtnUpdateGambar.Click
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

    Private Sub BtnUpdateKoleksi_Click(sender As Object, e As EventArgs) Handles BtnUpdateKoleksi.Click
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

        FormPerpustakaan.Koleksi.UpdateDataKoleksiByIDDatabase(FormPerpustakaan.selectedTableKoleksi,
                                                               FormPerpustakaan.Koleksi.GSGambarKoleksi,
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

        Dim infoTambah = New FormInfoTambahKoleksi()
        infoTambah.Show()

        Me.Close()
    End Sub
End Class