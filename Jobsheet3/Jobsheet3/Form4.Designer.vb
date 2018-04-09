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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BtnSimpan.Location = New System.Drawing.Point(113, 239)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpan.TabIndex = 87
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'TxtUmur
        '
        Me.TxtUmur.Location = New System.Drawing.Point(113, 172)
        Me.TxtUmur.Name = "TxtUmur"
        Me.TxtUmur.Size = New System.Drawing.Size(100, 20)
        Me.TxtUmur.TabIndex = 86
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(113, 137)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(143, 20)
        Me.TxtNama.TabIndex = 84
        '
        'TxtIdBayi
        '
        Me.TxtIdBayi.Location = New System.Drawing.Point(113, 64)
        Me.TxtIdBayi.Name = "TxtIdBayi"
        Me.TxtIdBayi.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdBayi.TabIndex = 83
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Umur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Nama Bayi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Id Bayi"
        '
        'TxtIdIbu
        '
        Me.TxtIdIbu.Location = New System.Drawing.Point(113, 101)
        Me.TxtIdIbu.Name = "TxtIdIbu"
        Me.TxtIdIbu.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdIbu.TabIndex = 91
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Id Ibu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Jenis Kelamin"
        '
        'CmbJK
        '
        Me.CmbJK.FormattingEnabled = True
        Me.CmbJK.Items.AddRange(New Object() {"Pria", "Wanita"})
        Me.CmbJK.Location = New System.Drawing.Point(113, 207)
        Me.CmbJK.Name = "CmbJK"
        Me.CmbJK.Size = New System.Drawing.Size(121, 21)
        Me.CmbJK.TabIndex = 93
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 444)
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
End Class
