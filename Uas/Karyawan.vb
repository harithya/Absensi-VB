Imports System.Data.OleDb

Public Class Karyawan

    'untuk menampilkan data karyawan
    Public Sub showKaryawan(Optional ByVal keyword As String = "")

        'jika keyword tidak kosong
        If keyword <> "" Then
            dataAdapter = New OleDbDataAdapter("SELECT * FROM karyawan WHERE nip LIKE '%" + keyword + "%' OR nama LIKE '%" + keyword + "%' OR jenis_kelamin LIKE '%" + keyword + "%' OR kategori LIKE '%" + keyword + "%' OR no_hp LIKE '%" + keyword + "%' ", connect)
        Else
            dataAdapter = New OleDbDataAdapter("SELECT * FROM karyawan", connect)
        End If

        dataSet = New DataSet
        dataAdapter.Fill(dataSet, "karyawan")
        karyawanGrid.DataSource = dataSet.Tables("karyawan")
        karyawanGrid.Columns(4).Width = 120

    End Sub

    'untuk mereset form karyawan
    Public Sub resetForm()

        inpNip.Text = ""
        inpNama.Text = ""
        inpLaki.Checked = False
        inpPerempuan.Checked = False
        inpKategori.SelectedIndex = -1
        inpNohp.Text = ""

    End Sub


    'form pertama kali di load
    Private Sub Karyawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call connection()
        Call showKaryawan()

        Dim i As Integer
        Dim kategori(5) As String

        'hapus semua item agar tidak terduplikat waktu form di buka kembali
        inpKategori.Items.Clear()

        'menampilkan data kategori
        kategori(0) = "CEO"
        kategori(1) = "HRD"
        kategori(2) = "Sekertaris"
        kategori(3) = "Programmer"
        kategori(4) = "UI / UX Designer"
        kategori(5) = "Database Engineer"

        For i = 0 To 5
            inpKategori.Items.Add(kategori(i))
        Next

    End Sub


    'jika button tambah di klik
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Call connection()
        Dim jenisKelamin As String

        'cek jenis kelamin yang di klik
        If inpLaki.Checked Then
            jenisKelamin = "Laki Laki"
        Else
            jenisKelamin = "Perempuan"
        End If

        command = New OleDbCommand("SELECT * FROM karyawan WHERE nip = '" + inpNip.Text + "' ", connect)
        dataReader = command.ExecuteReader

        'jika nip terdapat duplikat
        If dataReader.HasRows Then
            'reset nip jika tersedia
            MsgBox("NIP sudah tersedia")
            inpNip.Text = ""

        Else
            'proses tambah data karyawan
            command = New OleDbCommand("INSERT INTO karyawan (nip, nama, jenis_kelamin, kategori, no_hp) VALUES (@nip, @nama, @jenis_kelamin, @kategori, @no_hp) ", connect)
            command.Parameters.Add("@nip", OleDbType.Char).Value = inpNip.Text
            command.Parameters.Add("@nama", OleDbType.Char).Value = inpNama.Text
            command.Parameters.Add("@jenis_kelamin", OleDbType.Char).Value = jenisKelamin
            command.Parameters.Add("@kategori", OleDbType.Char).Value = inpKategori.Text
            command.Parameters.Add("@no_hp", OleDbType.Char).Value = inpNohp.Text

            command.ExecuteNonQuery()
            MsgBox("Berhasil menambahkan data")
            Call showKaryawan()
            Call resetForm()

        End If

    End Sub

    'jika button keluar di klik
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Me.Close()
        Call HomeScreen.resetLogin()
        HomeScreen.Show()

    End Sub



    'Jika table cell di klik
    Private Sub dataGrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles karyawanGrid.CellClick

        Dim nip As Double
        Call connection()

        nip = karyawanGrid.Rows(e.RowIndex).Cells(0).Value

        command = New OleDbCommand("SELECT * FROM karyawan WHERE nip=@nip ", connect)
        command.Parameters.AddWithValue("@nip", nip)
        dataReader = command.ExecuteReader
        dataReader.Read()

        inpNip.Text = dataReader(0)
        inpNama.Text = dataReader(1)
        If inpLaki.Text = dataReader(2) Then
            inpLaki.Checked = True
        Else
            inpPerempuan.Checked = True
        End If
        inpKategori.SelectedItem = dataReader(3)
        inpNohp.Text = dataReader(4)

    End Sub


    'jika button reset di klik
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Call resetForm()
    End Sub


    'jika button delete di klik
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Call connection()

        'jika data belum di pilih
        If inpNip.Text <> "" Then

            'melakukan fungsi delete
            command = New OleDbCommand("DELETE FROM karyawan WHERE nip=@nip", connect)
            command.Parameters.AddWithValue("@nip", inpNip.Text)
            command.ExecuteNonQuery()

            MsgBox("Berhasil menghapus data")
            Call resetForm()
            Call showKaryawan()

        Else
            MsgBox("Pilih data terlebih dahulu")
        End If

    End Sub

    'Jika button update di klik
    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click

        Call connection()
        Dim jenisKelamin As String

        'cek jenis kelamin yang di klik
        If inpLaki.Checked Then
            jenisKelamin = "Laki Laki"
        Else
            jenisKelamin = "Perempuan"
        End If

        command = New OleDbCommand("SELECT * FROM karyawan WHERE nip = '" + inpNip.Text + "' AND nip NOT IN ('" + inpNip.Text + "') ", connect)
        dataReader = command.ExecuteReader

        'jika nip terdapat duplikat
        If dataReader.HasRows Then
            'reset nip jika tersedia
            MsgBox("NIP sudah tersedia")
            inpNip.Text = ""

        Else
            'cek jika sudah memilih data
            If inpNip.Text <> "" Then

                'proses update data karyawan
                Call connection()
                command = New OleDbCommand("UPDATE karyawan SET nama = @nama, jenis_kelamin = @jenis_kelamin, kategori = @kataegori, no_hp = @no_hp WHERE nip=@nip ", connect)
                command.Parameters.AddWithValue("@nama", inpNama.Text)
                command.Parameters.AddWithValue("@jenis_kelamin", jenisKelamin)
                command.Parameters.AddWithValue("@kategori", inpKategori.Text)
                command.Parameters.AddWithValue("@no_hp", inpNohp.Text)
                command.Parameters.AddWithValue("@nip", inpNip.Text)
                command.ExecuteNonQuery()

                MsgBox("Berhasil mengubah data")

                Call showKaryawan()

            Else
                MsgBox("Pilih data terlebih dahulu ")
            End If

        End If

    End Sub

    'Jika button search di klik
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Call connection()

        Dim keyword As String
        keyword = inpSearch.Text
        Call showKaryawan(keyword)

    End Sub


    'tombol generate laporan
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Call connection()

        dataAdapter = New OleDbDataAdapter("SELECT karyawan.nip,karyawan.nama,karyawan.kategori,COUNT(*) AS total_absen  FROM absensi LEFT JOIN karyawan ON absensi.nip = karyawan.nip WHERE FORMAT(absensi.tanggal, 'dd/MM/yyyy') BETWEEN  '" + inpTanggalAwal.Text + "' AND '" + inpTanggalAkhir.Text + "' GROUP BY karyawan.nip,karyawan.nama,karyawan.kategori  ", connect)
        dataSet = New DataSet
        dataAdapter.Fill(dataSet, "absensi")
        laporanGrid.DataSource = dataSet.Tables("absensi")
        'width column
        laporanGrid.Columns(0).Width = 110
        laporanGrid.Columns(1).Width = 150
        laporanGrid.Columns(2).Width = 150

    End Sub

End Class