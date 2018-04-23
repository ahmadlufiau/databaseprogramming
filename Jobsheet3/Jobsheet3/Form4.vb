Imports System.Data.OleDb
Public Class Form4

    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim cmdInsert As New OleDbCommand
    Dim cmdUpdate As New OleDbCommand
    Dim cmdDelete As New OleDbCommand
    Dim strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
        System.Environment.CurrentDirectory & "\Posyandu.accdb"
    Public ADP As OleDbDataAdapter
    Public DS As New DataSet

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = strConnectionString
        cnnOLEDB.Open()
        TampilData()
        Bersih()
        TxtIdBayi.MaxLength = 12
        TxtIdIbu.MaxLength = 12
        TxtNama.MaxLength = 30
        TxtUmur.MaxLength = 3
    End Sub

    Sub TampilData()
        ADP = New OleDbDataAdapter("SELECT * FROM Bayi ORDER BY Id_Bayi", cnnOLEDB)
        DS = New DataSet
        ADP.Fill(DS, "Tabel1")
        DataGridView1.DataSource = DS.Tables("Tabel1")
    End Sub

    Sub Bersih()
        TxtIdBayi.Text = ""
        TxtIdIbu.Text = ""
        TxtNama.Text = ""
        TxtUmur.Text = ""
        CmbJK.Text = ""
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TxtIdBayi.Text <> "" And TxtIdIbu.Text <> "" And TxtNama.Text <> "" And TxtUmur.Text <> "" And CmbJK.Text <> "" Then

            Try
                cmdInsert.CommandText = "INSERT INTO Bayi " &
                    "(Id_Bayi, Id_Ibu, Nama_Bayi, Umur, Jenis_Kelamin)" &
                    "VALUES(@Id_Bayi, @Id_Ibu, @Nama_Bayi, @Umur, @Jenis_Kelamin)"

                'Deklarasi Variabel dengan parameter yang diambil dari TextBox
                cmdInsert.Parameters.AddWithValue("@Id_Bayi", Me.TxtIdBayi.Text)
                cmdInsert.Parameters.AddWithValue("@Id_Ibu", Me.TxtIdIbu.Text)
                cmdInsert.Parameters.AddWithValue("@Nama_Bayi", Me.TxtNama.Text)
                cmdInsert.Parameters.AddWithValue("@Umur", Me.TxtUmur.Text)
                cmdInsert.Parameters.AddWithValue("@Jenis_Kelamin", Me.CmbJK.Text)

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

    Private Sub TxtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUmur.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        GetData(e)
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        GetData(e)
    End Sub

    Sub GetData(e)
        Dim Id_Bayi As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Dim Id_Ibu As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Dim Nama As Object = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Dim Umur As Object = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        Dim Jenis_Kelamin As Object = DataGridView1.Rows(e.RowIndex).Cells(4).Value

        TxtIdBayi.Text = Id_Bayi
        TxtIdIbu.Text = CType(Id_Ibu, String)
        TxtNama.Text = CType(Nama, String)
        TxtUmur.Text = CType(Umur, String)
        CmbJK.Text = CType(Jenis_Kelamin, String)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If TxtIdBayi.Text <> "" And TxtIdIbu.Text <> "" And TxtNama.Text <> "" And TxtUmur.Text <> "" And CmbJK.Text <> "" Then
            Try
                cmdUpdate.CommandText = "Update Bayi SET Id_Bayi=@Id_Bayi, Id_Ibu=@Id_Ibu, Nama_Bayi= " &
                    "@Nama, Umur=@Umur, Jenis_Kelamin=@Jenis_Kelamin WHERE Id_Bayi=@Id_Bayi"
                cmdUpdate.Parameters.AddWithValue("@Id_Bayi", Me.TxtIdBayi.Text)
                cmdUpdate.Parameters.AddWithValue("@Id_Ibu", Me.TxtIdIbu.Text)
                cmdUpdate.Parameters.AddWithValue("@Nama", Me.TxtNama.Text)
                cmdUpdate.Parameters.AddWithValue("@Umur", Me.TxtUmur.Text)
                cmdUpdate.Parameters.AddWithValue("@Jenis_Kelamin", Me.CmbJK.Text)

                cmdUpdate.CommandType = CommandType.Text
                cmdUpdate.Connection = cnnOLEDB
                cmdUpdate.ExecuteNonQuery()
                MsgBox("Record Updated")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Masukkan Data secara Lengkap :")
        End If
        cmdUpdate.Dispose()
        TampilData()
        Bersih()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            cmdDelete.CommandText = "DELETE FROM Bayi WHERE Id_Bayi=@Id_Bayi"
            cmdDelete.Parameters.AddWithValue("@Id_Bayi", Me.TxtIdBayi.Text)
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
    End Sub

    Private Sub cmbCari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCari.SelectedIndexChanged
        If cmbCari.Text = "Id_Bayi" Then
            mtbCari.Mask = ""
        Else
            mtbCari.Mask = Nothing
            mtbCari.Text = ""
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Dim query1 As String
        Dim query2 As String
        query1 = "SELECT * FROM Bayi WHERE Id_Bayi = '" & mtbCari.Text & "'"
        query2 = "SELECT * FROM Bayi WHERE Nama_Bayi LIKE '" & mtbCari.Text & "%'"
        If cmbCari.Text = "Id Bayi" Then
            ADP = New OleDbDataAdapter(query1, cnnOLEDB)
            DS = New DataSet
            ADP.Fill(DS, "Tabel1")
            DataGridView1.DataSource = DS.Tables("Tabel1")

            Dim Id_Bayi As Object = DataGridView1.Rows(0).Cells(0).Value
            Dim Id_Ibu As Object = DataGridView1.Rows(0).Cells(1).Value
            Dim Nama_Bayi As Object = DataGridView1.Rows(0).Cells(2).Value
            Dim Umur As Object = DataGridView1.Rows(0).Cells(3).Value
            Dim Jenis_Kelamin As Object = DataGridView1.Rows(0).Cells(4).Value

            TxtIdBayi.Text = CType(Id_Bayi, String)
            TxtIdIbu.Text = CType(Id_Ibu, String)
            TxtNama.Text = CType(Nama_Bayi, String)
            TxtUmur.Text = CType(Umur, String)
            CmbJK.Text = CType(Jenis_Kelamin, String)

        Else
            ADP = New OleDbDataAdapter(query2, cnnOLEDB)
            DS = New DataSet
            ADP.Fill(DS, "Tabel1")
            DataGridView1.DataSource = DS.Tables("Tabel1")
            If DataGridView1.RowCount = 2 Then
                Dim Id_Bayi As Object = DataGridView1.Rows(0).Cells(0).Value
                Dim Id_Ibu As Object = DataGridView1.Rows(0).Cells(1).Value
                Dim Nama_Bayi As Object = DataGridView1.Rows(0).Cells(2).Value
                Dim Umur As Object = DataGridView1.Rows(0).Cells(3).Value
                Dim Jenis_Kelamin As Object = DataGridView1.Rows(0).Cells(4).Value

                TxtIdBayi.Text = CType(Id_Bayi, String)
                TxtIdIbu.Text = CType(Id_Ibu, String)
                TxtNama.Text = CType(Nama_Bayi, String)
                TxtUmur.Text = CType(Umur, String)
                CmbJK.Text = CType(Jenis_Kelamin, String)

            End If
        End If
    End Sub

End Class