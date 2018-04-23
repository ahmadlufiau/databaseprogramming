<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.TxtUmur = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtIdBayi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtIdIbu = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbJK = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.mtbCari = New System.Windows.Forms.MaskedTextBox()
        Me.cmbCari = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(124, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(308, 25)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "FORM PENGISIAN DATA BAYI"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 280)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(469, 150)
        Me.DataGridView1.TabIndex = 88
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(113, 249)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpan.TabIndex = 87
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'TxtUmur
        '
        Me.TxtUmur.Location = New System.Drawing.Point(113, 196)
        Me.TxtUmur.Name = "TxtUmur"
        Me.TxtUmur.Size = New System.Drawing.Size(100, 20)
        Me.TxtUmur.TabIndex = 86
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(113, 172)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(143, 20)
        Me.TxtNama.TabIndex = 84
        '
        'TxtIdBayi
        '
        Me.TxtIdBayi.Location = New System.Drawing.Point(113, 124)
        Me.TxtIdBayi.Name = "TxtIdBayi"
        Me.TxtIdBayi.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdBayi.TabIndex = 83
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Umur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Nama Bayi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Id Bayi"
        '
        'TxtIdIbu
        '
        Me.TxtIdIbu.Location = New System.Drawing.Point(113, 148)
        Me.TxtIdIbu.Name = "TxtIdIbu"
        Me.TxtIdIbu.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdIbu.TabIndex = 91
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Id Ibu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Jenis Kelamin"
        '
        'CmbJK
        '
        Me.CmbJK.FormattingEnabled = True
        Me.CmbJK.Items.AddRange(New Object() {"Pria", "Wanita"})
        Me.CmbJK.Location = New System.Drawing.Point(113, 221)
        Me.CmbJK.Name = "CmbJK"
        Me.CmbJK.Size = New System.Drawing.Size(121, 21)
        Me.CmbJK.TabIndex = 93
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(278, 249)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 95
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(194, 249)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 94
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Controls.Add(Me.mtbCari)
        Me.GroupBox1.Controls.Add(Me.cmbCari)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 73)
        Me.GroupBox1.TabIndex = 96
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Data"
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(373, 43)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(47, 23)
        Me.btnCari.TabIndex = 52
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'mtbCari
        '
        Me.mtbCari.Location = New System.Drawing.Point(116, 45)
        Me.mtbCari.Name = "mtbCari"
        Me.mtbCari.Size = New System.Drawing.Size(239, 20)
        Me.mtbCari.TabIndex = 2
        '
        'cmbCari
        '
        Me.cmbCari.FormattingEnabled = True
        Me.cmbCari.Items.AddRange(New Object() {"Id Bayi", "Nama Bayi"})
        Me.cmbCari.Location = New System.Drawing.Point(116, 18)
        Me.cmbCari.Name = "cmbCari"
        Me.cmbCari.Size = New System.Drawing.Size(121, 21)
        Me.cmbCari.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Berdasarkan"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 444)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.CmbJK)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtIdIbu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.TxtUmur)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtIdBayi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Data Bayi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents TxtUmur As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtIdBayi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtIdIbu As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CmbJK As ComboBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCari As Button
    Friend WithEvents mtbCari As MaskedTextBox
    Friend WithEvents cmbCari As ComboBox
    Friend WithEvents Label6 As Label
End Class
