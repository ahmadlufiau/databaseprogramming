Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Public Class TransaksiKelas

    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim cmdInsert As New OleDbCommand
    Dim cmdUpdate As New OleDbCommand
    Dim cmdDelete As New OleDbCommand
    Dim strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
        System.Environment.CurrentDirectory & "\Akademik.accdb"
    Public ADP As OleDbDataAdapter
    Public DS As New DataSet
    Public ADP2 As OleDbDataAdapter
    Public DS2 As New DataSet

    Private Sub TransaksiKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = strConnectionString
        cnnOLEDB.Open()
        Close()
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        TxtEdit1.Visible = False
        TxtEdit2.Visible = False
        MskEdit.Visible = False
        BtnOKEdit1.Visible = False
        BtnOKEdit2.Visible = False
    End Sub

    Private Sub RbNaikKelas_CheckedChanged(sender As Object, e As EventArgs) Handles RbNaikKelas.CheckedChanged
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = False
        TxtEdit1.Visible = True
        TxtEdit2.Visible = True
        MskEdit.Visible = False
        BtnOKEdit1.Visible = True
        BtnOKEdit2.Visible = False
    End Sub

    Private Sub RbStatusMhs_CheckedChanged(sender As Object, e As EventArgs) Handles RbStatusMhs.CheckedChanged
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = True
        TxtEdit1.Visible = False
        TxtEdit2.Visible = False
        MskEdit.Visible = True
        BtnOKEdit1.Visible = False
        BtnOKEdit2.Visible = True
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        For i = 0 To DataGridView1.RowCount - 2
            Dim NIM As Object = DataGridView1.Rows(i).Cells(1).Value
            Dim Status As Object = DataGridView1.Rows(i).Cells(4).Value
            cmdInsert.Parameters.AddWithValue("@NIM", CType(NIM, String))
            cmdInsert.Parameters.AddWithValue("@Kelas", CType(Me.TxtKelas.Text, String))
            cmdInsert.Parameters.AddWithValue("@Status", CType(Status, String))

            If DataGridView1.Item(0, i).Value = True Then
                Try
                    cmdInsert.CommandText = "INSERT INTO KELAS(NIM,Kelas,Status) VALUES(@NIM,@Kelas,@Status)"
                    cmdInsert.CommandType = CommandType.Text
                    cmdInsert.Connection = cnnOLEDB
                    cmdInsert.ExecuteNonQuery()
                    cmdInsert.Dispose()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        Next
        MsgBox("All Records Inserted")
        DS.Tables("Tabel1").Clear()

        DataGridView1.DataSource = DS.Tables("Tabel1")
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        For i = 0 To DataGridView1.RowCount - 2
            If DataGridView1.Item(0, i).Value = True Then
                Try
                    cmdUpdate.CommandText = "UPDATE Kelas SET Kelas=@Kelas, Status=@Status WHERE Kelas=@KelasSebelum AND NIM=@NIM"
                    cmdUpdate.Parameters.AddWithValue("@Kelas", Me.TxtEdit1.Text)
                    Dim Status As Object = DataGridView1.Rows(i).Cells(4).Value
                    cmdUpdate.Parameters.AddWithValue("@Status", CType(Status, String))
                    cmdUpdate.Parameters.AddWithValue("@KelasSebelum", Me.TxtEdit2.Text)
                    Dim NIM As Object = DataGridView1.Rows(i).Cells(1).Value
                    cmdUpdate.Parameters.AddWithValue("@NIM", CType(NIM, String))
                    cmdUpdate.CommandType = CommandType.Text
                    cmdUpdate.Connection = cnnOLEDB
                    cmdUpdate.ExecuteNonQuery()
                    cmdUpdate.Dispose()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        Next
        MsgBox("All Records Updated", MsgBoxStyle.OkOnly, "Kelas")
        DS.Tables("Tabel1").Clear()
        DataGridView1.DataSource = DS.Tables("Tabel1")
        TxtEdit1.Clear()
        TxtEdit2.Clear()
    End Sub

    Private Sub BtnOKEdit1_Click(sender As Object, e As EventArgs) Handles BtnOKEdit1.Click
        Dim query As String
        query = "SELECT m.NIM, m.Nama_Mhs, k.Kelas FROM Master_Mahasiswa m LEFT JOIN Kelas k ON m.NIM = k.NIM WHERE k.Kelas='" & TxtEdit1.Text & "' ORDER BY m.NIM"
        ADP = New OleDbDataAdapter(query, cnnOLEDB)
        DS = New DataSet
        ADP.Fill(DS, "Tabel1")
        DataGridView1.Columns.Clear()

        Dim chk As New DataGridViewCheckBoxColumn() With {.Width = 25}
        DataGridView1.Columns.Add(chk)
        chk.HeaderText = ""
        chk.Name = "chk"

        DataGridView1.DataSource = DS.Tables("Tabel1")

        Dim cmb As New DataGridViewComboBoxColumn()
        cmb.HeaderText = "Status"
        cmb.Name = "cmbStatus"
        cmb.MaxDropDownItems = 3
        cmb.Items.Add("Aktif")
        cmb.Items.Add("Cuti")
        cmb.Items.Add("DO")
        DataGridView1.Columns.Add(cmb)
        Dim Status As String
        Status = "SELECT Status FROM Kelas"
        ADP2 = New OleDbDataAdapter(Status, cnnOLEDB)
        DS2 = New DataSet
        ADP2.Fill(DS2, "Tabel2")

        For i = 0 To DataGridView1.RowCount - 2
            DataGridView1.Rows(i).Cells(4).Value = DS2.Tables("Tabel2").Rows(i)("Status")
        Next
    End Sub

    Private Sub BtnOKEdit2_Click(sender As Object, e As EventArgs) Handles BtnOKEdit2.Click
        Dim query As String
        query = "SELECT m.NIM, m.Nama_Mhs, k.Kelas FROM Master_Mahasiswa m INNER JOIN Kelas k ON m.NIM = k.NIM WHERE m.NIM='" & MskEdit.Text & "' ORDER BY m.NIM"
        ADP = New OleDbDataAdapter(query, cnnOLEDB)
        DS = New DataSet
        ADP.Fill(DS, "Tabel1")
        DataGridView1.Columns.Clear()

        Dim chk As New DataGridViewCheckBoxColumn() With {.Width = 25}
        DataGridView1.Columns.Add(chk)
        chk.HeaderText = ""
        chk.Name = "chk"

        DataGridView1.DataSource = DS.Tables("Tabel1")

        Dim cmb As New DataGridViewComboBoxColumn()
        cmb.HeaderText = "Status"
        cmb.Name = "cmbStatus"
        cmb.MaxDropDownItems = 3
        cmb.Items.Add("Aktif")
        cmb.Items.Add("Cuti")
        cmb.Items.Add("DO")
        DataGridView1.Columns.Add(cmb)
        Dim Status As String
        Status = "SELECT Status FROM Kelas"
        ADP2 = New OleDbDataAdapter(Status, cnnOLEDB)
        DS2 = New DataSet
        ADP2.Fill(DS2, "Tabel2")

        For i = 0 To DataGridView1.RowCount - 2
            DataGridView1.Rows(i).Cells(4).Value = DS2.Tables("Tabel2").Rows(i)("Status")
        Next
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim x As Integer = DataGridView1.RowCount
        If CheckBox1.Checked Then
            Do
                x = x - 1
                DataGridView1.Rows(x).Cells(0).Value = True
            Loop Until x = 0
        Else
            Do
                x = x - 1
                DataGridView1.Rows(x).Cells(0).Value = False
            Loop Until x = 0
        End If
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Dim query As String
        query = "SELECT m.NIM, m.Nama_Mhs, k.Kelas  FROM Master_Mahasiswa m LEFT JOIN Kelas k ON m.NIM = k.NIM WHERE k.Kelas IS NULL AND MID(m.NIM,6,2)='" & TxtTahunMasuk.Text.Substring(2, 2) & "' ORDER BY m.NIM"
        ADP = New OleDbDataAdapter(query, cnnOLEDB)
        DS = New DataSet
        ADP.Fill(DS, "Tabel1")

        DataGridView1.Columns.Clear()
        Dim chk As New DataGridViewCheckBoxColumn() With {.Width = 25}
        DataGridView1.Columns.Add(chk)
        chk.HeaderText = ""
        chk.Name = "chk"

        DataGridView1.DataSource = DS.Tables("Tabel1")

        Dim cmb As New DataGridViewComboBoxColumn()
        cmb.HeaderText = "Status"
        cmb.Name = "cmbStatus"
        cmb.MaxDropDownItems = 3
        cmb.Items.Add("Aktif")
        cmb.Items.Add("Cuti")
        cmb.Items.Add("DO")

        DataGridView1.Columns.Add(cmb)
        Dim x As Integer = DataGridView1.RowCount
        Do
            x = x - 1
            DataGridView1.Rows(x).Cells(4).Value = "Aktif"
        Loop Until x = 0
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        cmdDelete.Parameters.AddWithValue("@Kelas", Me.TxtNamaKelas2.Text)
        Try
            cmdDelete.CommandText = "DELETE FROM Kelas WHERE Kelas=@Kelas"
            cmdDelete.CommandType = CommandType.Text
            cmdDelete.Connection = cnnOLEDB
            cmdDelete.ExecuteNonQuery()
            cmdDelete.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MsgBox("All Records Deleted", MsgBoxStyle.OkOnly, "Kelas")
        DataGridView1.DataSource = DS.Tables("Tabel1")
        TxtNamaKelas2.Clear()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()
    End Sub
End Class