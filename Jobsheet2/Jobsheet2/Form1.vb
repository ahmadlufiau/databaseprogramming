Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Public Class Form1
    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim cmdInsert As New OleDbCommand
    Dim strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
        System.Environment.CurrentDirectory & "\Akademik.accdb"
    Public ADP As OleDbDataAdapter
    Public DS As New DataSet

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

    Private Sub TxtNoHP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNoHP.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 43 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
