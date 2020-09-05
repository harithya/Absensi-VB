Imports System.Data.OleDb

Public Class HomeScreen

    'reset inputan form
    Public Sub resetLogin()

        inpUsername.Text = ""
        inpPassword.Text = ""

    End Sub

    'proses login
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Call connection()

        command = New OleDbCommand("SELECT * FROM admin WHERE username=@username AND password=@password", connect)
        command.Parameters.Add("@username", OleDbType.Char).Value = inpUsername.Text
        command.Parameters.Add("@password", OleDbType.Char).Value = inpPassword.Text

        dataReader = command.ExecuteReader

        'jika username dan password tersedia
        If dataReader.HasRows Then
            MsgBox("Berhasil")
            Me.Hide()
            Call resetLogin()
            Karyawan.ShowDialog()
        Else
            MsgBox("Opps username atau password salah")
        End If


    End Sub

   
    'form pertama kali di load
    Private Sub HomeScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim batasMasuk1 As String = "07:00:00"
        Dim batasMasuk2 As String = "08:00:00"
        Dim batasKeluar As String = "16:00:00"
        Dim time As String

        time = Format(Now, "HH:mm:ss")

        'pengecekan waktu
        If Date.Parse(time) > Date.Parse(batasMasuk1) And Date.Parse(time) < Date.Parse(batasMasuk2) Then
            statusLabel.Text = "Masuk"
        ElseIf Date.Parse(time) > Date.Parse(batasKeluar) Then
            statusLabel.Text = "Keluar"
        Else
            statusLabel.Text = "Belum di buka"
        End If



    End Sub

    'jika button absen di klik
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Call connection()
        Dim tanggal As Date = System.DateTime.Now.ToString("dd/MM/yyyy")

        command = New OleDbCommand("SELECT * FROM karyawan WHERE nip='" + absenNip.Text + "'  ", connect)
        dataReader = command.ExecuteReader

        'jika nip yang di masukan tersedia
        If dataReader.HasRows Then

            Select Case statusLabel.Text

                Case "Belum di buka"
                    MsgBox("Absensi di buka jam 08:00 dan 16:00")

                Case Else
                    command = New OleDbCommand("SELECT * FROM absensi WHERE nip='" + absenNip.Text + "' AND status='" + statusLabel.Text + "' AND FORMAT(tanggal, 'dd/MM/yyyy') = '" + tanggal + "'  ", connect)
                    dataReader = command.ExecuteReader
                    dataReader.Read()

                    'jika telah melakukan absen
                    If dataReader.HasRows Then
                        MsgBox("Opps anda telah melakukan absen")
                    Else
                        'melakukan absensi
                        command = New OleDbCommand("INSERT INTO absensi (nip,tanggal,status) VALUES (@nip,@tanggal,@status) ", connect)
                        command.Parameters.Add("@nip", OleDbType.Char).Value = absenNip.Text
                        command.Parameters.Add("@tanggal", OleDbType.DBDate).Value = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                        command.Parameters.Add("@status", OleDbType.Char).Value = statusLabel.Text
                        command.ExecuteNonQuery()

                        MsgBox("Berhasil melakukan absen")
                        absenNip.Clear()

                    End If

            End Select

        Else
            MsgBox("Opps NIP kamu belum terdaftar ")

        End If



    End Sub


End Class
