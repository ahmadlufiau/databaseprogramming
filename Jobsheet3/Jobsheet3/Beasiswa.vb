Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class Beasiswa

    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim cmdInsert As New OleDbCommand
    Dim cmdUpdate As New OleDbCommand
    Dim cmdDelete As New OleDbCommand
    Dim strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
        System.Environment.CurrentDirectory & "\Akademik.accdb"
    Public ADP As OleDbDataAdapter
    Public DS As New DataSet

    Private Sub Beasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = strConnectionString
        cnnOLEDB.Open()
        TampilData()
        TxtKB.MaxLength = 4
        TxtNB.MaxLength = 30
        TxtIS.MaxLength = 20
        TxtJumlah.MaxLength = 20
        ButtonEnable()
    End Sub

    Sub TampilData()
        ADP = New OleDbDataAdapter("SELECT * FROM Master_Beasiswa ORDER BY Kode_BS", cnnOLEDB)
        DS = New DataSet
        ADP.Fill(DS, "Tabel1")
        DataGridView1.DataSource = DS.Tables("Tabel1")
    End Sub

    Sub Bersih()
        TxtKB.Text = ""
        TxtNB.Text = ""
        TxtIS.Text = ""
        TxtJumlah.Text = ""
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TxtKB.Text <> "" And TxtNB.Text <> "" And TxtIS.Text <> "" And TxtJumlah.Text <> "" Then
            Try
                cmdInsert.CommandText = "INSERT INTO Master_Beasiswa " &
               "(Kode_BS, Nama_BS, Institusi_Sponsor, Jumlah) " &
               "VALUES('" & TxtKB.Text & "','" & TxtNB.Text & "','" & TxtIS.Text & "','" & TxtJumlah.Text & "')"

                cmdInsert.CommandType = CommandType.Text
                cmdInsert.Connection = cnnOLEDB
                cmdInsert.ExecuteNonQuery()
                MsgBox("Record inserted")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Masukkan Data Secara Lengkap :")
        End If
        cmdInsert.Dispose()
        TampilData()
        Bersih()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        GetData(e)
    End Sub

    Private Sub DataGridView1_CellContextMenuStripChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContextMenuStripChanged
        GetData(e)
    End Sub

    Sub GetData(e)
        ButtonDisable()
        'Mendeklarasikan variabel sebagai Objek dan mengambil nilai pada 
        'setiap baris tabel yang dipilih 
        Dim KB As Object = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Dim NB As Object = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Dim Institusi As Object = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Dim Jumlah As Object = DataGridView1.Rows(e.RowIndex).Cells(3).Value

        'Mengubah tipe variabel yang diambil yang berbentuk objek 
        'menjadi berbentuk String dan menampilkan pada TextBox
        TxtKB.Text = CType(KB, String)
        TxtNB.Text = CType(NB, String)
        TxtIS.Text = CType(Institusi, String)
        TxtJumlah.Text = CType(Jumlah, String)
    End Sub

    Sub ButtonEnable()
        BtnSimpan.Enabled = True
        BtnUpdate.Enabled = False
        BtnDelete.Enabled = False
        TxtKB.Enabled = True
    End Sub
    Sub ButtonDisable()
        BtnSimpan.Enabled = False
        BtnUpdate.Enabled = True
        BtnDelete.Enabled = True
        TxtKB.Enabled = False
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If TxtKB.Text <> "" And TxtNB.Text <> "" And TxtIS.Text <> "" And TxtJumlah.Text <> "" Then
            Try
                cmdUpdate.CommandText = "UPDATE Master_Beasiswa SET " &
                "Kode_BS=@KB, Nama_BS=@NB, Institusi_Sponsor=@Institusi, Jumlah=@Jumlah WHERE Kode_BS=@KB "

                cmdUpdate.Parameters.AddWithValue("@KB", Me.TxtKB.Text)
                cmdUpdate.Parameters.AddWithValue("@NB", Me.TxtNB.Text)
                cmdUpdate.Parameters.AddWithValue("@Institusi", Me.TxtIS.Text)
                cmdUpdate.Parameters.AddWithValue("@Jumlah", Me.TxtJumlah.Text)

                cmdUpdate.CommandType = CommandType.Text
                cmdUpdate.Connection = cnnOLEDB
                cmdUpdate.ExecuteNonQuery()
                MsgBox("Record Updated")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        Else
            MsgBox("Masukkan Data Secara Lengkap :")
        End If
        cmdUpdate.Dispose()
        TampilData()
        Bersih()
        BtnSimpan.Enabled = True
        BtnUpdate.Enabled = True
        BtnDelete.Enabled = True
        TxtKB.Enabled = True
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            cmdDelete.CommandText = "DELETE FROM Master_Beasiswa WHERE Kode_BS=@KB"
            cmdDelete.Parameters.AddWithValue("@KB", Me.TxtKB.Text)
            cmdDelete.CommandType = CommandType.Text
            cmdDelete.Connection = cnnOLEDB
            cmdDelete.ExecuteNonQuery()
            MsgBox("Record Deleted")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        cmdDelete.Dispose()
        TampilData()
        Bersih()
        BtnSimpan.Enabled = True
        BtnUpdate.Enabled = True
        BtnDelete.Enabled = True
        TxtKB.Enabled = True
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        Dim query1 As String
        Dim query2 As String
        query1 = "SELECT * FROM Master_Beasiswa WHERE Kode_BS LIKE '" & MskCari.Text & "%'"
        query2 = "SELECT * FROM Master_Beasiswa WHERE Nama_BS LIKE '" & MskCari.Text & "%'"

        If CmbCari.Text = "Kode Beasiswa" Then
            ADP = New OleDbDataAdapter(query1, cnnOLEDB)
            DS = New DataSet
            ADP.Fill(DS, "Tabel1")
            DataGridView1.DataSource = DS.Tables("Tabel1")

            Dim KB As Object = DataGridView1.Rows(0).Cells(0).Value
            Dim NB As Object = DataGridView1.Rows(0).Cells(1).Value
            Dim Institusi As Object = DataGridView1.Rows(0).Cells(2).Value
            Dim Jumlah As Object = DataGridView1.Rows(0).Cells(3).Value

            TxtKB.Text = CType(KB, String)
            TxtNB.Text = CType(NB, String)
            TxtIS.Text = CType(Institusi, String)
            TxtJumlah.Text = CType(Jumlah, String)

        Else
            ADP = New OleDbDataAdapter(query2, cnnOLEDB)
            DS = New DataSet
            ADP.Fill(DS, "Tabel1")
            DataGridView1.DataSource = DS.Tables("Tabel1")
            If DataGridView1.RowCount = 2 Then
                Dim KB As Object = DataGridView1.Rows(0).Cells(0).Value
                Dim NB As Object = DataGridView1.Rows(0).Cells(1).Value
                Dim Institusi As Object = DataGridView1.Rows(0).Cells(2).Value
                Dim Jumlah As Object = DataGridView1.Rows(0).Cells(3).Value

                TxtKB.Text = CType(KB, String)
                TxtNB.Text = CType(NB, String)
                TxtIS.Text = CType(Institusi, String)
                TxtJumlah.Text = CType(Jumlah, String)
            End If
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        MenuUtama.Show()
        Hide()
    End Sub
End Class