Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class Form3

    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim cmdInsert As New OleDbCommand
    Dim strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
        System.Environment.CurrentDirectory & "\Posyandu.accdb"
    Public ADP As OleDbDataAdapter
    Public DS As New DataSet

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = strConnectionString
        cnnOLEDB.Open()
        TampilData()
        Bersih()
        TxtId.MaxLength = 12
        TxtNama.MaxLength = 30
        TxtAlamat.MaxLength = 50
        TxtUsia.MaxLength = 3
    End Sub

    Sub TampilData()
        ADP = New OleDbDataAdapter("SELECT * FROM Master_Ibu ORDER BY Id_Ibu", cnnOLEDB)
        DS = New DataSet
        ADP.Fill(DS, "Tabel1")
        DataGridView1.DataSource = DS.Tables("Tabel1")
    End Sub

    Sub Bersih()
        TxtId.Text = ""
        TxtNama.Text = ""
        TxtAlamat.Text = ""
        TxtUsia.Text = ""
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TxtId.Text <> "" And TxtNama.Text <> "" And TxtAlamat.Text <> "" And TxtUsia.Text <> "" Then

            Try
                cmdInsert.CommandText = "INSERT INTO Master_Ibu " &
                    "(Id_Ibu, Nama_Ibu, Alamat, Usia)" &
                    "VALUES(@Id, @Nama, @Alamat, @Usia)"

                'Deklarasi Variabel dengan parameter yang diambil dari TextBox
                cmdInsert.Parameters.AddWithValue("@Id_Ibu", Me.TxtId.Text)
                cmdInsert.Parameters.AddWithValue("@Nama", Me.TxtNama.Text)
                cmdInsert.Parameters.AddWithValue("@Alamat", Me.TxtAlamat.Text)
                cmdInsert.Parameters.AddWithValue("@Usia", Me.TxtUsia.Text)

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

    Private Sub TxtUsia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsia.KeyPress
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
        Dim Id_Ibu As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Dim Nama As Object = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Dim Alamat As Object = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Dim Usia As Object = DataGridView1.Rows(e.RowIndex).Cells(3).Value

        TxtId.Text = Id_Ibu
        TxtNama.Text = CType(Nama, String)
        TxtAlamat.Text = CType(Alamat, String)
        TxtUsia.Text = CType(Usia, String)
    End Sub
End Class