Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Koleksi
    Private koleksiDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "127.0.0.1"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "perpustakaan"

    Private namaKoleksi As String
    Private jenisKoleksi As String
    Private deskripsi As String
    Private penerbit As String
    Private tahunTerbit As Integer
    Private lokasiRak As String
    Private tanggalMasukKoleksi As String
    Private stock As Integer
    Private bahasa As String
    Private gambarKoleksi As String
    Private kategori As New List(Of String)
    Private listKoleksi As New List(Of String)

    Public Property GSNamaKoleksi() As String
        Get
            Return namaKoleksi
        End Get
        Set(ByVal value As String)
            namaKoleksi = value
        End Set
    End Property

    Public Property GSJenisKoleksi() As String
        Get
            Return jenisKoleksi
        End Get
        Set(ByVal value As String)
            jenisKoleksi = value
        End Set
    End Property

    Public Property GSDeskripsi() As String
        Get
            Return deskripsi
        End Get
        Set(ByVal value As String)
            deskripsi = value
        End Set
    End Property

    Public Property GSPenerbit() As String
        Get
            Return penerbit
        End Get
        Set(ByVal value As String)
            penerbit = value
        End Set
    End Property

    Public Property GSTahunTerbit() As Integer
        Get
            Return tahunTerbit
        End Get
        Set(ByVal value As Integer)
            tahunTerbit = value
        End Set
    End Property

    Public Property GSLokasiRak() As String
        Get
            Return lokasiRak
        End Get
        Set(ByVal value As String)
            lokasiRak = value
        End Set
    End Property

    Public Property GSTanggalMasukKoleksi() As String
        Get
            Return tanggalMasukKoleksi
        End Get
        Set(ByVal value As String)
            tanggalMasukKoleksi = value
        End Set
    End Property

    Public Property GSStock() As Integer
        Get
            Return stock
        End Get
        Set(ByVal value As Integer)
            stock = value
        End Set
    End Property

    Public Property GSBahasa() As String
        Get
            Return bahasa
        End Get
        Set(ByVal value As String)
            bahasa = value
        End Set
    End Property

    Public Property GSGambarKoleksi() As String
        Get
            Return gambarKoleksi
        End Get
        Set(ByVal value As String)
            gambarKoleksi = value
        End Set
    End Property

    Public Function AddKategori(value As String)
        kategori.Add(value)
        Return ""
    End Function

    Public ReadOnly Property getKategoriItem() As List(Of String)
        Get
            Return kategori
        End Get
    End Property

    Public Function resetKategori()
        kategori.Clear()
    End Function

    Public Function AddKoleksi(value As String)
        listKoleksi.Add(value)
        Return ""
    End Function

    Public Function RemoveKoleksi(value As String)
        listKoleksi.Remove(value)
        Return ""
    End Function

    Public ReadOnly Property getKoleksiItem() As List(Of String)
        Get
            Return listKoleksi
        End Get
    End Property

    Public Function AddKoleksiDataTable(dirGambar As String,
                                        namaKoleksi As String,
                                        jenisKoleksi As String,
                                        penerbitKoleksi As String,
                                        deskripsiKoleksi As String,
                                        tahunTerbitKoleksi As String,
                                        lokasiRakKoleksi As String,
                                        tanggalMasukKoleksi As String,
                                        stockKoleksi As Integer,
                                        bahasaKoleksi As String,
                                        kategoriKoleksi As String)
        koleksiDataTable.Add({dirGambar,
                             namaKoleksi,
                             jenisKoleksi,
                             penerbitKoleksi,
                             deskripsiKoleksi,
                             tahunTerbitKoleksi,
                             lokasiRakKoleksi,
                             tanggalMasukKoleksi,
                             stockKoleksi,
                             bahasaKoleksi,
                             kategoriKoleksi})
    End Function

    Public Function AddDataKoleksiDatabase(dirGambar As String,
                                        namaKoleksi As String,
                                        jenisKoleksi As String,
                                        penerbitKoleksi As String,
                                        deskripsiKoleksi As String,
                                        tahunTerbitKoleksi As String,
                                        lokasiRakKoleksi As String,
                                        tanggalMasukKoleksi As Date,
                                        stockKoleksi As Integer,
                                        bahasaKoleksi As String,
                                        kategoriKoleksi As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
           + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO koleksi(nama_koleksi, dir_gambar,
                                      deskripsi, penerbit, jenis_koleksi,
                                      tahun_terbit, lokasi, tgl_masuk,
                                      stock, bahasa, kategori) VALUE ('" _
                                      & namaKoleksi & "', '" _
                                      & dirGambar & "', '" _
                                      & deskripsiKoleksi & "', '" _
                                      & penerbitKoleksi & "', '" _
                                      & jenisKoleksi & "', '" _
                                      & tahunTerbitKoleksi & "', '" _
                                      & lokasiRakKoleksi & "', '" _
                                      & tanggalMasukKoleksi.ToString("yyyy/MM/dd") & "', '" _
                                      & stockKoleksi & "', '" _
                                      & bahasaKoleksi & "', '" _
                                      & kategoriKoleksi & "')"


            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            Debug.WriteLine("input data")

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Debug.WriteLine(ex)
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try


    End Function

    Public Function GetDataKoleksiDatabase() As DataTable

        Try
            Dim result As New DataTable

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
                + "password =" + password + ";" + "database =" + database

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT
                                  id_koleksi AS 'ID',
                                  nama_koleksi AS 'Nama Koleksi',
                                  jenis_koleksi AS 'Jenis Koleksi',
                                  penerbit AS 'Penerbit',
                                  deskripsi AS 'Deskripsi',
                                  tahun_terbit AS 'Tahun Terbit',
                                  lokasi AS 'Lokasi Rak',
                                  tgl_masuk AS 'Tanggal Masuk',
                                  stock AS 'Stock',
                                  bahasa AS 'Bahasa',
                                  kategori AS 'Kategori'
                                  FROM koleksi"

            sqlRead = sqlCommand.ExecuteReader

            result.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show("Error")
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Function GetDataKoleksiByIDDatabase(ID As Integer) As List(Of String)

        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
                + "password =" + password + ";" + "database =" + database
            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id_koleksi,
                                  nama_koleksi,
                                  dir_gambar,
                                  deskripsi,
                                  penerbit,
                                  jenis_koleksi,
                                  tahun_terbit,
                                  lokasi,
                                  tgl_masuk,
                                  stock,
                                  bahasa,
                                  kategori
                                  FROM koleksi
                                  WHERE id_koleksi='" & ID & "'"

            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                result.Add(sqlRead.GetString(0).ToString())
                result.Add(sqlRead.GetString(1).ToString())
                result.Add(sqlRead.GetString(2).ToString())
                result.Add(sqlRead.GetString(3).ToString())
                result.Add(sqlRead.GetString(4).ToString())
                result.Add(sqlRead.GetString(5).ToString())
                result.Add(sqlRead.GetString(6).ToString())
                result.Add(sqlRead.GetString(7).ToString())
                result.Add(sqlRead.GetString(8).ToString())
                result.Add(sqlRead.GetString(9).ToString())
                result.Add(sqlRead.GetString(10).ToString())
                result.Add(sqlRead.GetString(11).ToString())
            End While

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show("Error")
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Function UpdateDataKoleksiByIDDatabase(ID As Integer,
                                        dirGambar As String,
                                        namaKoleksi As String,
                                        jenisKoleksi As String,
                                        penerbitKoleksi As String,
                                        deskripsiKoleksi As String,
                                        tahunTerbitKoleksi As String,
                                        lokasiRakKoleksi As String,
                                        tanggalMasukKoleksi As String,
                                        stockKoleksi As Integer,
                                        bahasaKoleksi As String,
                                        kategoriKoleksi As String)

        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
                + "password =" + password + ";" + "database =" + database

            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "UPDATE koleksi SET " &
                           "nama_koleksi='" & namaKoleksi & "', " &
                           "dir_gambar='" & dirGambar & "', " &
                           "deskripsi='" & deskripsiKoleksi & "', " &
                           "penerbit='" & penerbitKoleksi & "', " &
                           "jenis_koleksi='" & jenisKoleksi & "', " &
                           "tahun_terbit='" & tahunTerbitKoleksi & "', " &
                           "lokasi='" & lokasiRakKoleksi & "', " &
                           "tgl_masuk='" & tanggalMasukKoleksi & "', " &
                           "stock='" & stockKoleksi & "', " &
                           "bahasa='" & bahasaKoleksi & "', " &
                           "kategori='" & kategoriKoleksi & "' " &
                           "WHERE id_koleksi=" & ID

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
               + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "DELETE FROM koleksi " &
                       "WHERE id_koleksi = " & ID

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function RemoveKoleksiDataTable(index As Integer)
        koleksiDataTable.RemoveAt(index)
    End Function

    Public ReadOnly Property getKoleksiDataTable() As ArrayList
        Get
            Return koleksiDataTable
        End Get
    End Property

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        'Convert to string.
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        'Convert to list.
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    Public Function GetDataKoleksiNameDatabase() As List(Of String)
        Try
            Dim data As New DataTable
            Dim result As New List(Of String)

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
                + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT nama_koleksi FROM koleksi"

            sqlRead = sqlCommand.ExecuteReader

            data.Load(sqlRead)

            For index As Integer = 0 To (data.Rows.Count - 1)
                result.Add(data.Rows(index).Item("nama_koleksi"))
            Next

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show("error")
        Finally
            dbConn.Dispose()
        End Try

    End Function

End Class
