<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNIM = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTLahir = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tgl = New System.Windows.Forms.DateTimePicker()
        Me.TxtNoHP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmbKota = New System.Windows.Forms.ComboBox()
        Me.CmbProvinsi = New System.Windows.Forms.ComboBox()
        Me.TxtFoto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIM"
        '
        'TxtNIM
        '
        Me.TxtNIM.Location = New System.Drawing.Point(104, 54)
        Me.TxtNIM.Name = "TxtNIM"
        Me.TxtNIM.Size = New System.Drawing.Size(216, 20)
        Me.TxtNIM.TabIndex = 1
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(104, 80)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(216, 20)
        Me.TxtNama.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tanggal Lahir"
        '
        'TxtTLahir
        '
        Me.TxtTLahir.Location = New System.Drawing.Point(104, 106)
        Me.TxtTLahir.Name = "TxtTLahir"
        Me.TxtTLahir.Size = New System.Drawing.Size(216, 20)
        Me.TxtTLahir.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tempat Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Kota"
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Location = New System.Drawing.Point(104, 158)
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(216, 20)
        Me.TxtAlamat.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Alamat"
        '
        'Tgl
        '
        Me.Tgl.Location = New System.Drawing.Point(104, 133)
        Me.Tgl.Name = "Tgl"
        Me.Tgl.Size = New System.Drawing.Size(216, 20)
        Me.Tgl.TabIndex = 12
        '
        'TxtNoHP
        '
        Me.TxtNoHP.Location = New System.Drawing.Point(104, 236)
        Me.TxtNoHP.Name = "TxtNoHP"
        Me.TxtNoHP.Size = New System.Drawing.Size(216, 20)
        Me.TxtNoHP.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "No HP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Provinsi"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(104, 262)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(216, 20)
        Me.TxtEmail.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Email"
        '
        'CmbKota
        '
        Me.CmbKota.FormattingEnabled = True
        Me.CmbKota.Items.AddRange(New Object() {"Kota Semarang", "Kab Semarang", "Kendal", "Demak", "Pati", "Magelang", "Wonosobo", "Purwokerto", "Blora", "Lamongan", "Rambang"})
        Me.CmbKota.Location = New System.Drawing.Point(104, 183)
        Me.CmbKota.Name = "CmbKota"
        Me.CmbKota.Size = New System.Drawing.Size(216, 21)
        Me.CmbKota.TabIndex = 19
        '
        'CmbProvinsi
        '
        Me.CmbProvinsi.FormattingEnabled = True
        Me.CmbProvinsi.Items.AddRange(New Object() {"Jawa Tengah", "Jawa Timur"})
        Me.CmbProvinsi.Location = New System.Drawing.Point(104, 209)
        Me.CmbProvinsi.Name = "CmbProvinsi"
        Me.CmbProvinsi.Size = New System.Drawing.Size(216, 21)
        Me.CmbProvinsi.TabIndex = 20
        '
        'TxtFoto
        '
        Me.TxtFoto.Location = New System.Drawing.Point(104, 288)
        Me.TxtFoto.Name = "TxtFoto"
        Me.TxtFoto.Size = New System.Drawing.Size(216, 20)
        Me.TxtFoto.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 291)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Foto"
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Location = New System.Drawing.Point(326, 287)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.BtnBrowse.TabIndex = 23
        Me.BtnBrowse.Text = "Browse"
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(104, 314)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpan.TabIndex = 24
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(339, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 176)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(35, 343)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(456, 164)
        Me.DataGridView1.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(73, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(388, 25)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "FORM PENGISIAN DATA MAHASISWA"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 512)
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
        Me.Controls.Add(Me.TxtNIM)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNIM As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTLahir As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Tgl As DateTimePicker
    Friend WithEvents TxtNoHP As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CmbKota As ComboBox
    Friend WithEvents CmbProvinsi As ComboBox
    Friend WithEvents TxtFoto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label11 As Label
End Class
