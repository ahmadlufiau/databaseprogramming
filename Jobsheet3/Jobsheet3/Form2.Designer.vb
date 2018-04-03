<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.TxtFoto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmbProvinsi = New System.Windows.Forms.ComboBox()
        Me.CmbKota = New System.Windows.Forms.ComboBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNoHP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tgl = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTLahir = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(84, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(334, 25)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "FORM PENGISIAN DATA DOSEN"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(35, 350)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(456, 164)
        Me.DataGridView1.TabIndex = 76
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(339, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 176)
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(104, 321)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpan.TabIndex = 74
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Location = New System.Drawing.Point(326, 294)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.BtnBrowse.TabIndex = 73
        Me.BtnBrowse.Text = "Browse"
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'TxtFoto
        '
        Me.TxtFoto.Location = New System.Drawing.Point(104, 295)
        Me.TxtFoto.Name = "TxtFoto"
        Me.TxtFoto.Size = New System.Drawing.Size(216, 20)
        Me.TxtFoto.TabIndex = 72
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 298)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Foto"
        '
        'CmbProvinsi
        '
        Me.CmbProvinsi.FormattingEnabled = True
        Me.CmbProvinsi.Items.AddRange(New Object() {"Jawa Tengah", "Jawa Timur", "Yogyakarta"})
        Me.CmbProvinsi.Location = New System.Drawing.Point(104, 216)
        Me.CmbProvinsi.Name = "CmbProvinsi"
        Me.CmbProvinsi.Size = New System.Drawing.Size(216, 21)
        Me.CmbProvinsi.TabIndex = 70
        '
        'CmbKota
        '
        Me.CmbKota.FormattingEnabled = True
        Me.CmbKota.Items.AddRange(New Object() {"Kota Semarang", "Kab Semarang", "Kendal", "Demak", "Pati", "Magelang", "Wonosobo", "Purwokerto", "Blora", "Lamongan", "Rambang", "Sleman"})
        Me.CmbKota.Location = New System.Drawing.Point(104, 190)
        Me.CmbKota.Name = "CmbKota"
        Me.CmbKota.Size = New System.Drawing.Size(216, 21)
        Me.CmbKota.TabIndex = 69
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(104, 269)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(216, 20)
        Me.TxtEmail.TabIndex = 68
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Email"
        '
        'TxtNoHP
        '
        Me.TxtNoHP.Location = New System.Drawing.Point(104, 243)
        Me.TxtNoHP.Name = "TxtNoHP"
        Me.TxtNoHP.Size = New System.Drawing.Size(216, 20)
        Me.TxtNoHP.TabIndex = 66
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "No HP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Provinsi"
        '
        'Tgl
        '
        Me.Tgl.Location = New System.Drawing.Point(104, 140)
        Me.Tgl.Name = "Tgl"
        Me.Tgl.Size = New System.Drawing.Size(216, 20)
        Me.Tgl.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Kota"
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Location = New System.Drawing.Point(104, 165)
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(216, 20)
        Me.TxtAlamat.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Tanggal Lahir"
        '
        'TxtTLahir
        '
        Me.TxtTLahir.Location = New System.Drawing.Point(104, 113)
        Me.TxtTLahir.Name = "TxtTLahir"
        Me.TxtTLahir.Size = New System.Drawing.Size(216, 20)
        Me.TxtTLahir.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Tempat Lahir"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(104, 87)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(216, 20)
        Me.TxtNama.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Nama"
        '
        'TxtNIP
        '
        Me.TxtNIP.Location = New System.Drawing.Point(104, 61)
        Me.TxtNIP.Name = "TxtNIP"
        Me.TxtNIP.Size = New System.Drawing.Size(216, 20)
        Me.TxtNIP.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "NIP"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 533)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.TxtFoto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CmbProvinsi)
        Me.Controls.Add(Me.CmbKota)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtNoHP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Tgl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtAlamat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTLahir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNIP)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents TxtFoto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CmbProvinsi As ComboBox
    Friend WithEvents CmbKota As ComboBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNoHP As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Tgl As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTLahir As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNIP As TextBox
    Friend WithEvents Label1 As Label
End Class
