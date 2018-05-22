<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransaksiKelas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabSimpan = New System.Windows.Forms.TabPage()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTahunMasuk = New System.Windows.Forms.TextBox()
        Me.TxtKelas = New System.Windows.Forms.TextBox()
        Me.TabEdit = New System.Windows.Forms.TabPage()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnOKEdit2 = New System.Windows.Forms.Button()
        Me.BtnOKEdit1 = New System.Windows.Forms.Button()
        Me.TxtEdit2 = New System.Windows.Forms.TextBox()
        Me.TxtEdit1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RbStatusMhs = New System.Windows.Forms.RadioButton()
        Me.RbNaikKelas = New System.Windows.Forms.RadioButton()
        Me.TabHapus = New System.Windows.Forms.TabPage()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.TxtNamaKelas2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MskEdit = New System.Windows.Forms.MaskedTextBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabSimpan.SuspendLayout()
        Me.TabEdit.SuspendLayout()
        Me.TabHapus.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabSimpan)
        Me.TabControl1.Controls.Add(Me.TabEdit)
        Me.TabControl1.Controls.Add(Me.TabHapus)
        Me.TabControl1.Location = New System.Drawing.Point(13, 58)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(585, 206)
        Me.TabControl1.TabIndex = 0
        '
        'TabSimpan
        '
        Me.TabSimpan.Controls.Add(Me.BtnOK)
        Me.TabSimpan.Controls.Add(Me.BtnSimpan)
        Me.TabSimpan.Controls.Add(Me.Label2)
        Me.TabSimpan.Controls.Add(Me.Label1)
        Me.TabSimpan.Controls.Add(Me.TxtTahunMasuk)
        Me.TabSimpan.Controls.Add(Me.TxtKelas)
        Me.TabSimpan.Location = New System.Drawing.Point(4, 22)
        Me.TabSimpan.Name = "TabSimpan"
        Me.TabSimpan.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSimpan.Size = New System.Drawing.Size(577, 180)
        Me.TabSimpan.TabIndex = 0
        Me.TabSimpan.Text = "Simpan"
        Me.TabSimpan.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(241, 85)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(75, 23)
        Me.BtnOK.TabIndex = 5
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(135, 114)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpan.TabIndex = 4
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tahun Masuk"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kelas"
        '
        'TxtTahunMasuk
        '
        Me.TxtTahunMasuk.Location = New System.Drawing.Point(135, 87)
        Me.TxtTahunMasuk.Name = "TxtTahunMasuk"
        Me.TxtTahunMasuk.Size = New System.Drawing.Size(100, 20)
        Me.TxtTahunMasuk.TabIndex = 1
        '
        'TxtKelas
        '
        Me.TxtKelas.Location = New System.Drawing.Point(135, 50)
        Me.TxtKelas.Name = "TxtKelas"
        Me.TxtKelas.Size = New System.Drawing.Size(100, 20)
        Me.TxtKelas.TabIndex = 0
        '
        'TabEdit
        '
        Me.TabEdit.Controls.Add(Me.MskEdit)
        Me.TabEdit.Controls.Add(Me.BtnUbah)
        Me.TabEdit.Controls.Add(Me.BtnOKEdit2)
        Me.TabEdit.Controls.Add(Me.BtnOKEdit1)
        Me.TabEdit.Controls.Add(Me.TxtEdit2)
        Me.TabEdit.Controls.Add(Me.TxtEdit1)
        Me.TabEdit.Controls.Add(Me.Label5)
        Me.TabEdit.Controls.Add(Me.Label4)
        Me.TabEdit.Controls.Add(Me.Label3)
        Me.TabEdit.Controls.Add(Me.RbStatusMhs)
        Me.TabEdit.Controls.Add(Me.RbNaikKelas)
        Me.TabEdit.Location = New System.Drawing.Point(4, 22)
        Me.TabEdit.Name = "TabEdit"
        Me.TabEdit.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEdit.Size = New System.Drawing.Size(577, 180)
        Me.TabEdit.TabIndex = 1
        Me.TabEdit.Text = "Edit"
        Me.TabEdit.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Location = New System.Drawing.Point(231, 141)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(75, 23)
        Me.BtnUbah.TabIndex = 10
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnOKEdit2
        '
        Me.BtnOKEdit2.Location = New System.Drawing.Point(398, 101)
        Me.BtnOKEdit2.Name = "BtnOKEdit2"
        Me.BtnOKEdit2.Size = New System.Drawing.Size(75, 23)
        Me.BtnOKEdit2.TabIndex = 9
        Me.BtnOKEdit2.Text = "OK"
        Me.BtnOKEdit2.UseVisualStyleBackColor = True
        '
        'BtnOKEdit1
        '
        Me.BtnOKEdit1.Location = New System.Drawing.Point(398, 42)
        Me.BtnOKEdit1.Name = "BtnOKEdit1"
        Me.BtnOKEdit1.Size = New System.Drawing.Size(75, 23)
        Me.BtnOKEdit1.TabIndex = 8
        Me.BtnOKEdit1.Text = "OK"
        Me.BtnOKEdit1.UseVisualStyleBackColor = True
        '
        'TxtEdit2
        '
        Me.TxtEdit2.Location = New System.Drawing.Point(269, 74)
        Me.TxtEdit2.Name = "TxtEdit2"
        Me.TxtEdit2.Size = New System.Drawing.Size(100, 20)
        Me.TxtEdit2.TabIndex = 6
        '
        'TxtEdit1
        '
        Me.TxtEdit1.Location = New System.Drawing.Point(269, 42)
        Me.TxtEdit1.Name = "TxtEdit1"
        Me.TxtEdit1.Size = New System.Drawing.Size(100, 20)
        Me.TxtEdit1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(198, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "NIM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(198, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kelas Baru"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Kelas"
        '
        'RbStatusMhs
        '
        Me.RbStatusMhs.AutoSize = True
        Me.RbStatusMhs.Location = New System.Drawing.Point(72, 104)
        Me.RbStatusMhs.Name = "RbStatusMhs"
        Me.RbStatusMhs.Size = New System.Drawing.Size(111, 17)
        Me.RbStatusMhs.TabIndex = 1
        Me.RbStatusMhs.TabStop = True
        Me.RbStatusMhs.Text = "Status Mahasiswa"
        Me.RbStatusMhs.UseVisualStyleBackColor = True
        '
        'RbNaikKelas
        '
        Me.RbNaikKelas.AutoSize = True
        Me.RbNaikKelas.Location = New System.Drawing.Point(72, 42)
        Me.RbNaikKelas.Name = "RbNaikKelas"
        Me.RbNaikKelas.Size = New System.Drawing.Size(76, 17)
        Me.RbNaikKelas.TabIndex = 0
        Me.RbNaikKelas.TabStop = True
        Me.RbNaikKelas.Text = "Naik Kelas"
        Me.RbNaikKelas.UseVisualStyleBackColor = True
        '
        'TabHapus
        '
        Me.TabHapus.Controls.Add(Me.BtnHapus)
        Me.TabHapus.Controls.Add(Me.TxtNamaKelas2)
        Me.TabHapus.Controls.Add(Me.Label6)
        Me.TabHapus.Location = New System.Drawing.Point(4, 22)
        Me.TabHapus.Name = "TabHapus"
        Me.TabHapus.Size = New System.Drawing.Size(577, 180)
        Me.TabHapus.TabIndex = 2
        Me.TabHapus.Text = "Hapus"
        Me.TabHapus.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(236, 140)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapus.TabIndex = 13
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'TxtNamaKelas2
        '
        Me.TxtNamaKelas2.Location = New System.Drawing.Point(262, 87)
        Me.TxtNamaKelas2.Name = "TxtNamaKelas2"
        Me.TxtNamaKelas2.Size = New System.Drawing.Size(100, 20)
        Me.TxtNamaKelas2.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(169, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nama Kelas"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(17, 271)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Pilih Semua"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 306)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(578, 206)
        Me.DataGridView1.TabIndex = 2
        '
        'MskEdit
        '
        Me.MskEdit.Location = New System.Drawing.Point(231, 103)
        Me.MskEdit.Name = "MskEdit"
        Me.MskEdit.Size = New System.Drawing.Size(138, 20)
        Me.MskEdit.TabIndex = 11
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(538, 6)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(56, 46)
        Me.BtnExit.TabIndex = 88
        Me.BtnExit.Text = "X"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("NewsGoth Cn BT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(81, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(403, 39)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "FORM PENGISIAN TRANSAKSI KELAS"
        '
        'TransaksiKelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 533)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TransaksiKelas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransaksiKelas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabSimpan.ResumeLayout(False)
        Me.TabSimpan.PerformLayout()
        Me.TabEdit.ResumeLayout(False)
        Me.TabEdit.PerformLayout()
        Me.TabHapus.ResumeLayout(False)
        Me.TabHapus.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabSimpan As TabPage
    Friend WithEvents TabEdit As TabPage
    Friend WithEvents TabHapus As TabPage
    Friend WithEvents BtnOK As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTahunMasuk As TextBox
    Friend WithEvents TxtKelas As TextBox
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnOKEdit2 As Button
    Friend WithEvents BtnOKEdit1 As Button
    Friend WithEvents TxtEdit2 As TextBox
    Friend WithEvents TxtEdit1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RbStatusMhs As RadioButton
    Friend WithEvents RbNaikKelas As RadioButton
    Friend WithEvents BtnHapus As Button
    Friend WithEvents TxtNamaKelas2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MskEdit As MaskedTextBox
    Friend WithEvents BtnExit As Button
    Friend WithEvents Label7 As Label
End Class
