Public Class FormPerpustakaan

    Public Shared selectedItem As String
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama

    Public Shared Koleksi As Koleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Koleksi = New Koleksi()

        ListBoxKoleksiBuku.Items.Clear()

        If Koleksi.GetDataKoleksiNameDatabase() IsNot Nothing Then
            For Each kol In Koleksi.GetDataKoleksiNameDatabase()
                ListBoxKoleksiBuku.Items.Add(kol)
            Next
        End If

        ReloadDataTableDatabase()

        If (DataGridKoleksi.Rows.Count > 0) Then
            DataGridKoleksi.Rows(0).Selected = True
            selectedTableKoleksi = DataGridKoleksi.Rows(selectedTableKoleksi).Cells(0).Value
        End If

    End Sub

    Private Sub TambahKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKoleksiToolStripMenuItem.Click
        Koleksi.dbConn.Close()
        Dim formTambahKoleksi = New FormTambahKoleksi()
        formTambahKoleksi.Show()
    End Sub

    Private Sub ToolStripButtonTambahKoleksi_Click(sender As Object, e As EventArgs) Handles ToolStripButtonTambahKoleksi.Click
        Dim formTambahKoleksi = New FormTambahKoleksi()
        formTambahKoleksi.Show()
    End Sub

    Private Sub ToolStripButtonHapusKoleksi_Click(sender As Object, e As EventArgs) Handles ToolStripButtonHapusKoleksi.Click
        If selectedTableKoleksi Is Nothing Then
            MessageBox.Show("Pilih koleksi yang ingin dihapus")
        Else
            Dim formHapusKoleksi = New FormHapusKoleksi()
            formHapusKoleksi.Show()
        End If
    End Sub

    Private Sub FormPerpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ListBoxKoleksiBuku.Items.Clear()

        If Koleksi.GetDataKoleksiNameDatabase() IsNot Nothing Then
            For Each kol In Koleksi.GetDataKoleksiNameDatabase()
                ListBoxKoleksiBuku.Items.Add(kol)
            Next
        End If

        ReloadDataTableDatabase()

        If FormPerpustakaan.Koleksi.getKoleksiDataTable.Count > 0 Then
            selectedTableKoleksi = DataGridKoleksi.CurrentRow.Index
            ListBoxKoleksiBuku.SetSelected(selectedTableKoleksi, True)
        End If

        'If (DataGridKoleksi.Rows.Count > 0) Then
        '    Dim currRow = DataGridKoleksi.CurrentRow.Index
        '    ListBoxKoleksiBuku.SetSelected(currRow, True)
        '    DataGridKoleksi.CurrentCell = DataGridKoleksi.Rows(currRow).Cells(0)
        '    DataGridKoleksi.Rows(currRow).Selected = True
        'End If
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridKoleksi.DataSource = Koleksi.GetDataKoleksiDatabase()
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Dim selectedKoleksi As List(Of String) = Koleksi.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        Koleksi.GSGambarKoleksi = selectedKoleksi(2)
        Koleksi.GSNamaKoleksi = selectedKoleksi(1)
        Koleksi.GSJenisKoleksi = selectedKoleksi(5)
        Koleksi.GSDeskripsi = selectedKoleksi(3)
        Koleksi.GSPenerbit = selectedKoleksi(4)
        Koleksi.GSTahunTerbit = selectedKoleksi(6)
        Koleksi.GSLokasiRak = selectedKoleksi(7)
        Koleksi.GSTanggalMasukKoleksi = selectedKoleksi(8)
        Koleksi.GSStock = selectedKoleksi(9)
        Koleksi.GSBahasa = selectedKoleksi(10)

        Dim data_kategori As List(Of String) = Koleksi.ConvertStringToKoleksi(selectedKoleksi(11))

        For Each info_kategori In data_kategori
            Koleksi.AddKategori(info_kategori)
        Next

        Dim infoTambah = New FormInfoTambahKoleksi()
        infoTambah.Show()
    End Sub

    Private Sub DataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksi.CellClick

        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridKoleksi.Rows(index)

        'ListBoxKoleksiBuku.SetSelected(index, True)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub ListBoxKoleksiBuku_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxKoleksiBuku.SelectedIndexChanged
        DataGridKoleksi.ClearSelection()
        DataGridKoleksi.Rows(ListBoxKoleksiBuku.SelectedIndex).Selected = True
        DataGridKoleksi.CurrentCell = DataGridKoleksi.Rows(ListBoxKoleksiBuku.SelectedIndex).Cells(0)
        selectedTableKoleksi = DataGridKoleksi.CurrentRow.Index

        selectedTableKoleksi = DataGridKoleksi.CurrentRow.Cells(0).Value
        selectedTableKoleksiNama = DataGridKoleksi.CurrentRow.Cells(1).Value
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim selectedKoleksi As List(Of String) = Koleksi.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        Koleksi.GSGambarKoleksi = selectedKoleksi(2)
        Koleksi.GSNamaKoleksi = selectedKoleksi(1)
        Koleksi.GSJenisKoleksi = selectedKoleksi(5)
        Koleksi.GSDeskripsi = selectedKoleksi(3)
        Koleksi.GSPenerbit = selectedKoleksi(4)
        Koleksi.GSTahunTerbit = selectedKoleksi(6)
        Koleksi.GSLokasiRak = selectedKoleksi(7)
        Koleksi.GSTanggalMasukKoleksi = selectedKoleksi(8)
        Koleksi.GSStock = selectedKoleksi(9)
        Koleksi.GSBahasa = selectedKoleksi(10)

        Dim data_kategori As List(Of String) = Koleksi.ConvertStringToKoleksi(selectedKoleksi(11))

        For Each info_kategori In data_kategori
            Koleksi.AddKategori(info_kategori)
        Next

        Dim formUpdate = New FormUpdateKoleksi()
        formUpdate.Show()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If selectedTableKoleksi Is Nothing Then
            MessageBox.Show("Pilih koleksi yang ingin dihapus")
        Else
            Dim formHapusKoleksi = New FormHapusKoleksi()
            formHapusKoleksi.Show()
        End If
    End Sub
End Class
