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


End Class
