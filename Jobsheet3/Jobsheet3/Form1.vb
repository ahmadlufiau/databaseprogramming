Imports System.Data.OleDb
Public Class Form1

    'Browsing Data Using DataGridView

    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
        System.Environment.CurrentDirectory & "\Akademik.accdb"
    Public ADP As OleDbDataAdapter
    Public DS As New DataSet

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        GetData(e)
    End Sub

    Private Sub DataGridView1_CellContextMenuStripChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContextMenuStripChanged
        GetData(e)
    End Sub

    Sub GetData(e)
        'Mendeklarasikan variabel sebagai Objek dan mengambil nilai pada 
        'setiap baris tabel yang dipilih 
        Dim NIM As Object = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Dim Nama As Object = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Dim TempatLahir As Object = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Dim TanggalLahir As Object = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        Dim Alamat As Object = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        Dim Kota As Object = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        Dim Provinsi As Object = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        Dim NoHP As Object = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        Dim Email As Object = DataGridView1.Rows(e.RowIndex).Cells(8).Value

        'Mengubah tipe variabel yang diambil yang berbentuk objek 
        'menjadi berbentuk String dan menampilkan pada TextBox
        TxtNIM.Text = CType(NIM, String)
        TxtNama.Text = CType(Nama, String)
        TxtTLahir.Text = CType(TempatLahir, String)
        Tgl.Text = CType(TanggalLahir, String)
        TxtAlamat.Text = CType(Alamat, String)
        TxtNoHP.Text = CType(NoHP, String)
        CmbKota.Text = CType(Kota, String)
        CmbProvinsi.Text = CType(Provinsi, String)
        TxtEmail.Text = CType(Email, String)

        'Menambahkan parameter untuk mengambil data foto dari database
        Try
            Dim command As New OleDbCommand("SELECT Foto FROM Master_Mahasiswa WHERE NIM=@NIM", cnnOLEDB)
            command.Parameters.AddWithValue("@NIM", CType(NIM, String))
            'Deklarasi pengambilan file Foto sebagai file Byte
            Dim pictureData As Byte() = DirectCast(command.ExecuteScalar(), Byte())
            command.Dispose()
            'Mengubah file byte foto menjadi stream
            Dim Stream As New IO.MemoryStream(pictureData)
            'Menampilkan foto pada PictureBox
            Me.PictureBox1.Image = Image.FromStream(Stream)
            Stream.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = strConnectionString
        cnnOLEDB.Open()
        TampilData()
        TxtNIM.MaxLength = 12
        TxtNama.MaxLength = 30
        TxtTLahir.MaxLength = 20
        TxtAlamat.MaxLength = 50
        TxtNoHP.MaxLength = 13
        TxtEmail.MaxLength = 30
    End Sub

    Sub TampilData()
        ADP = New OleDbDataAdapter("SELECT * FROM Master_Mahasiswa ORDER BY NIM", cnnOLEDB)
        DS = New DataSet
        ADP.Fill(DS, "Tabel1")
        DataGridView1.DataSource = DS.Tables("Tabel1")
    End Sub
End Class
