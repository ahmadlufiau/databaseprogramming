Imports System.Data.OleDb
Imports System.IO
Public Class Form1

    'Browsing Data Using DataGridView

    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim cmdInsert As New OleDbCommand
    Dim cmdUpdate As New OleDbCommand
    Dim cmdDelete As New OleDbCommand
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
    Sub Bersih()
        TxtNIM.Text = ""
        TxtNama.Text = ""
        TxtTLahir.Text = ""
        Tgl.Text = ""
        TxtAlamat.Text = ""
        CmbKota.SelectedText = ""
        CmbProvinsi.SelectedText = ""
        TxtNoHP.Text = ""
        TxtFoto.Text = ""
        TxtEmail.Text = ""
        PictureBox1.Image = Nothing
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

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        'Declare a file stream object
        Dim o As System.IO.FileStream
        'Declare a stream reader object
        Dim r As StreamReader
        'Shorter variable name for FileStream (optional)
        Dim jpgFile As String = TxtFoto.Text
        'Open image file
        o = New FileStream(jpgFile, FileMode.Open, FileAccess.Read, FileShare.Read)
        'Read the image into a stream reader
        r = New StreamReader(o)
        If TxtNIM.Text <> "" And TxtNama.Text <> "" And TxtTLahir.Text <> "" And TxtAlamat.Text <> "" And CmbKota.Text <> "" _
            And CmbProvinsi.Text <> "" And TxtNoHP.Text <> "" And TxtFoto.Text <> "" Then

            Try
                'Declare a Byte array to hold the image
                Dim FileByteArray(o.Length - 1) As Byte

                'Fill the Byte array with image byte data
                o.Read(FileByteArray, 0, o.Length)

                cmdInsert.CommandText = "INSERT INTO Master_Mahasiswa " &
               "(NIM, Nama_Mhs, Tempat_Lahir, Tanggal_Lahir, Alamat, Kota, Provinsi, No_HP, Email, Foto) " &
               "VALUES('" & TxtNIM.Text & "','" & TxtNama.Text & "','" & TxtTLahir.Text & "','" & Tgl.Text & "','" & TxtAlamat.Text & "','" &
                CmbKota.Text & "','" & CmbProvinsi.Text & "','" & TxtNoHP.Text & "','" & TxtEmail.Text & "', @Gambar)"

                cmdInsert.Parameters.Add("@Gambar", System.Data.OleDb.OleDbType.Binary, o.Length).Value = FileByteArray

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

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If TxtNIM.Text <> "" And TxtNama.Text <> "" And TxtTLahir.Text <> "" And TxtAlamat.Text <> "" And CmbKota.Text <> "" And CmbProvinsi.Text <> "" And TxtNoHP.Text <> "" Then
            Try
                If TxtFoto.Text = "" Then
                    cmdUpdate.CommandText = "UPDATE Master_Mahasiswa SET " &
                                            "NIM=@NIM, Nama_Mhs=@Nama, Tempat_Lahir=@TLahir, Tanggal_Lahir=@Tgl, Alamat=@Alamat," &
                                            "Kota=@Kota, Provinsi=@Provinsi, No_HP=@NoHP, Email=@Email WHERE NIM=@NIM"
                    cmdUpdate.Parameters.AddWithValue("@NIM", Me.TxtNIM.Text)
                    cmdUpdate.Parameters.AddWithValue("@Nama", Me.TxtNama.Text)
                    cmdUpdate.Parameters.AddWithValue("@TLahir", Me.TxtTLahir.Text)
                    cmdUpdate.Parameters.AddWithValue("@Tgl", Me.Tgl.Text)
                    cmdUpdate.Parameters.AddWithValue("@Alamat", Me.TxtAlamat.Text)
                    cmdUpdate.Parameters.AddWithValue("@Kota", Me.CmbKota.Text)
                    cmdUpdate.Parameters.AddWithValue("@NProvinsi", Me.CmbProvinsi.Text)
                    cmdUpdate.Parameters.AddWithValue("@NoHP", Me.TxtNoHP.Text)
                    cmdUpdate.Parameters.AddWithValue("@Email", Me.TxtEmail.Text)
                Else
                    'Declare a file stream object
                    Dim o As System.IO.FileStream
                    'Declare a stream reader object
                    Dim r As StreamReader
                    'Shorter variable name for FileStream (optional)
                    Dim jpgFile As String = TxtFoto.Text
                    'Open image file
                    o = New FileStream(jpgFile, FileMode.Open, FileAccess.Read, FileShare.Read)
                    'Read the image into a stream reader
                    r = New StreamReader(o)
                    'Declare a Byte array to hold the image
                    Dim FileByteArray(o.Length - 1) As Byte
                    'Fill the Byte array with image byte data
                    o.Read(FileByteArray, 0, o.Length)
                    cmdUpdate.CommandText = "UPDATE Master_Mahasiswa SET " &
                                            "NIM=@NIM, Nama_Mhs=@Nama, Tempat_Lahir=@TLahir, Tanggal_Lahir=@Tgl, Alamat=@Alamat," &
                                            "Kota=@Kota, Provinsi=@Provinsi, No_HP=@NoHP, Email=@Email,Foto=@Gambar WHERE NIM=@NIM"
                    cmdUpdate.Parameters.AddWithValue("@NIM", Me.TxtNIM.Text)
                    cmdUpdate.Parameters.AddWithValue("@Nama", Me.TxtNama.Text)
                    cmdUpdate.Parameters.AddWithValue("@TLahir", Me.TxtTLahir.Text)
                    cmdUpdate.Parameters.AddWithValue("@Tgl", Me.Tgl.Text)
                    cmdUpdate.Parameters.AddWithValue("@Alamat", Me.TxtAlamat.Text)
                    cmdUpdate.Parameters.AddWithValue("@Kota", Me.CmbKota.Text)
                    cmdUpdate.Parameters.AddWithValue("@NProvinsi", Me.CmbProvinsi.Text)
                    cmdUpdate.Parameters.AddWithValue("@NoHP", Me.TxtNoHP.Text)
                    cmdUpdate.Parameters.AddWithValue("@Email", Me.TxtEmail.Text)
                    cmdUpdate.Parameters.Add("@Gambar", System.Data.OleDb.OleDbType.Binary, o.Length).Value = FileByteArray
                End If
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
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            cmdDelete.CommandText = "DELETE FROM Master_Mahasiswa WHERE NIM=@NIM"
            cmdDelete.Parameters.AddWithValue("@NIM", Me.TxtNIM.Text)
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

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        With OpenFileDialog1
            .CheckFileExists = True
            .ShowReadOnly = False
            .Filter = "All Files |*.*|Bitmap Files(*)|*.bmp;*.gif;*.jpg|PNG Files(*)|*.png"
            .FilterIndex = 2
            If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(.FileName)
                TxtFoto.Text = .FileName.ToString
            End If
        End With
    End Sub

    Private Sub CmbCari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCari.SelectedIndexChanged
        If CmbCari.Text = "NIM" Then
            MskCari.Mask = "#,##,##,#,##"
        Else
            MskCari.Mask = Nothing
            MskCari.Text = ""
        End If
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        Dim query1 As String
        Dim query2 As String
        query1 = "SELECT * FROM Master_Mahasiswa WHERE NIM= '" & MskCari.Text & "'"
        query2 = "SELECT * FROM Master_Mahasiswa WHERE Nama_Mhs LIKE '" & MskCari.Text & "%'"

        If CmbCari.Text = "NIM" Then
            ADP = New OleDbDataAdapter(query1, cnnOLEDB)
            DS = New DataSet
            ADP.Fill(DS, "Tabel1")
            DataGridView1.DataSource = DS.Tables("Tabel1")

            Dim NIM As Object = DataGridView1.Rows(0).Cells(0).Value
            Dim Nama As Object = DataGridView1.Rows(0).Cells(1).Value
            Dim TempatLahir As Object = DataGridView1.Rows(0).Cells(2).Value
            Dim TanggalLahir As Object = DataGridView1.Rows(0).Cells(3).Value
            Dim Alamat As Object = DataGridView1.Rows(0).Cells(4).Value
            Dim Kota As Object = DataGridView1.Rows(0).Cells(5).Value
            Dim Provinsi As Object = DataGridView1.Rows(0).Cells(6).Value
            Dim NoHP As Object = DataGridView1.Rows(0).Cells(7).Value
            Dim Email As Object = DataGridView1.Rows(0).Cells(8).Value

            TxtNIM.Text = CType(NIM, String)
            TxtNama.Text = CType(Nama, String)
            TxtTLahir.Text = CType(TempatLahir, String)
            Tgl.Text = CType(TanggalLahir, String)
            TxtAlamat.Text = CType(Alamat, String)
            TxtNoHP.Text = CType(NoHP, String)
            CmbKota.Text = CType(Kota, String)
            CmbProvinsi.Text = CType(Provinsi, String)
            TxtEmail.Text = CType(Email, String)

            Try
                Dim command As New OleDbCommand("SELECT Foto FROM Master_Mahasiswa WHERE NIM=@NIM", cnnOLEDB)
                command.Parameters.AddWithValue("@NIM", CType(NIM, String))
                Dim pictureData As Byte() = DirectCast(command.ExecuteScalar(), Byte())
                command.Dispose()
                Dim Stream As New IO.MemoryStream(pictureData)
                Me.PictureBox1.Image = Image.FromStream(Stream)
                Stream.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

        Else
            ADP = New OleDbDataAdapter(query2, cnnOLEDB)
            DS = New DataSet
            ADP.Fill(DS, "Tabel1")
            DataGridView1.DataSource = DS.Tables("Tabel1")
            If DataGridView1.RowCount = 2 Then
                Dim NIM As Object = DataGridView1.Rows(0).Cells(0).Value
                Dim Nama As Object = DataGridView1.Rows(0).Cells(1).Value
                Dim TempatLahir As Object = DataGridView1.Rows(0).Cells(2).Value
                Dim TanggalLahir As Object = DataGridView1.Rows(0).Cells(3).Value
                Dim Alamat As Object = DataGridView1.Rows(0).Cells(4).Value
                Dim Kota As Object = DataGridView1.Rows(0).Cells(5).Value
                Dim Provinsi As Object = DataGridView1.Rows(0).Cells(6).Value
                Dim NoHP As Object = DataGridView1.Rows(0).Cells(7).Value
                Dim Email As Object = DataGridView1.Rows(0).Cells(8).Value

                TxtNIM.Text = CType(NIM, String)
                TxtNama.Text = CType(Nama, String)
                TxtTLahir.Text = CType(TempatLahir, String)
                Tgl.Text = CType(TanggalLahir, String)
                TxtAlamat.Text = CType(Alamat, String)
                TxtNoHP.Text = CType(NoHP, String)
                CmbKota.Text = CType(Kota, String)
                CmbProvinsi.Text = CType(Provinsi, String)
                TxtEmail.Text = CType(Email, String)

                Try
                    Dim command As New OleDbCommand("SELECT Foto FROM Master_Mahasiswa WHERE NIM=@NIM", cnnOLEDB)
                    command.Parameters.AddWithValue("@NIM", CType(NIM, String))
                    Dim pictureData As Byte() = DirectCast(command.ExecuteScalar(), Byte())
                    command.Dispose()
                    Dim Stream As New IO.MemoryStream(pictureData)
                    Me.PictureBox1.Image = Image.FromStream(Stream)
                    Stream.Dispose()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            End If
        End If
    End Sub

End Class