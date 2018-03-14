﻿Imports System.Data.OleDb
Public Class KoneksiDatabase
    Public DB As OleDbConnection
    Public ADP As OleDbDataAdapter
    Public DS As New DataSet
    Private Sub KoneksiDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnTampil_Click(sender As Object, e As EventArgs) Handles BtnTampil.Click
        Dim Dbku = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\D3TI\vb\KoneksiDatabase\Mahasiswa.mdb"
        DB = New OleDbConnection(Dbku)
        If DB.State = ConnectionState.Closed Then
            DB.Open()
            MsgBox("Koneksi ke Data Base Mahasiswa.mdb berhasil")
        End If
        ADP = New OleDbDataAdapter("Select * From DataPribadi", DB)
        DS = New DataSet
        ADP.Fill(DS, "DataPribadi")
        DataGridView1.DataSource = DS.Tables("DataPribadi")
    End Sub

    Private Sub BtnBersih_Click(sender As Object, e As EventArgs) Handles BtnBersih.Click
        DS.Clear()
        DataGridView1.Refresh()
    End Sub
End Class
