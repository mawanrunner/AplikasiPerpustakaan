Public Class FormHapusKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblHapusKoleksi.Text = FormPerpustakaan.selectedTableKoleksiNama


    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        FormPerpustakaan.Koleksi.DeleteDataKoleksiByIDDatabase(FormPerpustakaan.selectedTableKoleksi)
        Me.Close()
    End Sub

End Class