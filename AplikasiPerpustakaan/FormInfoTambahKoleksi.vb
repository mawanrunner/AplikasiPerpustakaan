Public Class FormInfoTambahKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ListBoxKategoriValue.Items.Clear()

        If Not String.IsNullOrEmpty(FormPerpustakaan.Koleksi.GSGambarKoleksi) Then
            PicBukuValue.Load(FormPerpustakaan.Koleksi.GSGambarKoleksi)
            PicBukuValue.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        LblNamaKoleksiValue.Text = FormPerpustakaan.Koleksi.GSNamaKoleksi
        LblJenisKoleksiValue.Text = FormPerpustakaan.Koleksi.GSJenisKoleksi
        LblDeskripsiValue.Text = FormPerpustakaan.Koleksi.GSDeskripsi
        LblPenerbitValue.Text = FormPerpustakaan.Koleksi.GSPenerbit
        LblTahunTerbitValue.Text = FormPerpustakaan.Koleksi.GSTahunTerbit
        LblLokasiRakValue.Text = FormPerpustakaan.Koleksi.GSLokasiRak
        LblTanggalMasukKoleksiValue.Text = FormPerpustakaan.Koleksi.GSTanggalMasukKoleksi
        LblStockValue.Text = FormPerpustakaan.Koleksi.GSStock
        LblBahasaValue.Text = FormPerpustakaan.Koleksi.GSBahasa

        ListBoxKategoriValue.Items.Clear()

        For Each kat In FormPerpustakaan.Koleksi.getKategoriItem
            ListBoxKategoriValue.Items.Add(kat)
        Next

        FormPerpustakaan.Koleksi.resetKategori()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub
End Class