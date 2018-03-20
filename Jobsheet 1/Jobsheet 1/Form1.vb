Imports System.Data.OleDb
Public Class Form1
    Public DB As OleDbConnection
    Public ADP As OleDbDataAdapter
    Public DS As New DataSet
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Dbku = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Mahasiswa.mdb"
        DB = New OleDbConnection(Dbku)
        If DB.State = ConnectionState.Closed Then
            DB.Open()
            MsgBox("Koneksi ke Database Mahasiswa.mdb berhasil")
        End If
        ADP = New OleDbDataAdapter("Select * From DataPribadi", DB)
        DS = New DataSet
        ADP.Fill(DS, "DataPribadi")
        DataGridView1.DataSource = DS.Tables("DataPribadi")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DS.Clear()
        DataGridView1.Refresh()
    End Sub
End Class
