Imports System.Data.OleDb
Public Class Form2
    Public DB As OleDbConnection
    Public ADP As OleDbDataAdapter
    Public DS As New DataSet
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Dbku = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Kuliah\Semester 4\Pemrograman Database\Praktik\Jobsheet 1\Jobsheet 1\Instansi.accdb"
        DB = New OleDbConnection(Dbku)
        If DB.State = ConnectionState.Closed Then
            DB.Open()
        End If
        ADP = New OleDbDataAdapter("Select * From alat", DB)
        DS = New DataSet
        ADP.Fill(DS, "alat")
        DataGridView1.DataSource = DS.Tables("alat")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DS.Clear()
        DataGridView1.Refresh()
    End Sub
End Class