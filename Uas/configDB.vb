Imports System.Data.OleDb

Module configDB

    Public connect As OleDbConnection
    Public dataAdapter As OleDbDataAdapter
    Public command As OleDbCommand
    Public dataReader As OleDbDataReader
    Public dataSet As DataSet


    Public Sub connection()
        connect = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=absensi.accdb")
        connect.Open()
    End Sub

End Module
