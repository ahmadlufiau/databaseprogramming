Imports System.Data.OleDb

Public Class Form3

    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim cmdInsert As New OleDbCommand
    Dim cmdUpdate As New OleDbCommand
    Dim cmdDelete As New OleDbCommand
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        cmdUpdate.Parameters.AddWithValue("@Id_Ibu", Me.TxtId.Text)
        cmdUpdate.Parameters.AddWithValue("@Nama", Me.TxtNama.Text)
        cmdUpdate.Parameters.AddWithValue("@Alamat", Me.TxtAlamat.Text)
        cmdUpdate.Parameters.AddWithValue("@Usia", Me.TxtUsia.Text)
        cmdUpdate.CommandText = "UPDATE Master_Ibu SET Id_Ibu=@Id_Ibu, Nama_Ibu= " &
            "@Nama, Alamat=@Alamat, Usia=@Usia WHERE Id_Ibu=@Id_Ibu"
        cmdUpdate.CommandType = CommandType.Text
        cmdUpdate.Connection = cnnOLEDB
        cmdUpdate.ExecuteNonQuery()
        MsgBox("Record Updated")
        cmdUpdate.Dispose()
        TampilData()
        Bersih()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            cmdDelete.CommandText = "DELETE FROM Master_Ibu WHERE Id_Ibu=@Id_Ibu"
            cmdDelete.Parameters.AddWithValue("@Id_Ibu", Me.TxtId.Text)
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
        If cmbCari.Text = "Id_Ibu" Then
            mtbCari.Mask = ""
        Else
            mtbCari.Mask = Nothing
            mtbCari.Text = ""
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Dim query1 As String
        Dim query2 As String
        query1 = "SELECT * FROM Master_Ibu WHERE Id_Ibu = '" & mtbCari.Text & "'"
        query2 = "SELECT * FROM Master_Ibu WHERE Nama_Ibu LIKE '" & mtbCari.Text & "%'"
        If cmbCari.Text = "Id Ibu" Then
            ADP = New OleDbDataAdapter(query1, cnnOLEDB)
            DS = New DataSet
            ADP.Fill(DS, "Tabel1")
            DataGridView1.DataSource = DS.Tables("Tabel1")

            Dim Id_Ibu As Object = DataGridView1.Rows(0).Cells(0).Value
            Dim Nama_Ibu As Object = DataGridView1.Rows(0).Cells(1).Value
            Dim Alamat As Object = DataGridView1.Rows(0).Cells(2).Value
            Dim Usia As Object = DataGridView1.Rows(0).Cells(3).Value
            TxtId.Text = CType(Id_Ibu, String)
            TxtNama.Text = CType(Nama_Ibu, String)
            TxtAlamat.Text = CType(Alamat, String)
            TxtUsia.Text = CType(Usia, String)

        Else
            ADP = New OleDbDataAdapter(query2, cnnOLEDB)
            DS = New DataSet
            ADP.Fill(DS, "Tabel1")
            DataGridView1.DataSource = DS.Tables("Tabel1")
            If DataGridView1.RowCount = 2 Then
                Dim Id_Ibu As Object = DataGridView1.Rows(0).Cells(0).Value
                Dim Nama_Ibu As Object = DataGridView1.Rows(0).Cells(1).Value
                Dim Alamat As Object = DataGridView1.Rows(0).Cells(2).Value
                Dim Usia As Object = DataGridView1.Rows(0).Cells(3).Value
                TxtId.Text = CType(Id_Ibu, String)
                TxtNama.Text = CType(Nama_Ibu, String)
                TxtAlamat.Text = CType(Alamat, String)
                TxtUsia.Text = CType(Usia, String)
            End If
        End If
    End Sub

End Class