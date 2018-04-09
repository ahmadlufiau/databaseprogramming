Imports System.Data.OleDb
Public Class Form4

    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim cmdInsert As New OleDbCommand
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

End Class